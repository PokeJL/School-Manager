//Purpose: To develop a student managment desktop software that can at a minimum store data to a text file,
//load the stored data, change the data and save the changes.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICT710_Assig3_School_Manager
{
    public partial class Main_Student_Manager : Form
    {
        Core.Student_List list; //Object that stores the student list

        /// <summary>
        /// Constructor
        /// </summary>
        public Main_Student_Manager()
        {
            InitializeComponent();
            list = new Core.Student_List(); //Initialize list
            FillDropDown(0); //Initialize combobox
        }


        //
        //Reusable and custom code section
        //


        /// <summary>
        /// Function to populate the combobox
        /// </summary>
        /// <param name="jump">The element of the combobox that should be selected after the function is done</param>
        private void FillDropDown(int jump)
        {
            studentSelectCB.Items.Clear(); //Clears the combobox
            if (list.GetIndex() == 0)
            {
                object[] dropDown = new object[1]; //Initialize dropDown
                dropDown[0] = "-"; //Add element to dropDown
                studentSelectCB.Items.AddRange(dropDown); //Bind dropDown to combobox
            }
            else
            {
                object[] dropDown = new object[2 + list.GetIndex()]; //Initialize dropDown
                dropDown[0] = "-"; //Add element to dropDown
                dropDown[1] = "All"; //Adds element to dropDown
                for (int i = 0; i < list.GetIndex(); i++) //Adds names to dropDown
                    dropDown[1 + i + 1] = list.GetName(i);
                studentSelectCB.Items.AddRange(dropDown); //Bind dropDown to combobox
            }
            studentSelectCB.SelectedIndex = jump; //Set combobox to first element
        }

        /// <summary>
        /// Function displays student info to Info Viewer textbox
        /// </summary>
        /// <param name="index">Array index of the student in the list variable</param>
        private void PrintStudents(int index)
        {
            infoViewerTXB.Text += string.Format("Student Name: {1}{0}Student ID: {2}{0}Address: {3}{0}Date of birth: {4}{0}", Environment.NewLine, list.GetName(index), list.GetID(index), list.GetAddress(index), list.GetDOB(index).ToShortDateString());
            for (int i = 0; i < list.GetCourseListSize() && list.GetCourseEnabled(index, i) == true; i++) //Loop to display the students courses
            {
                infoViewerTXB.Text += string.Format("Course {0}: {1} Mark: {2}{3}", (i + 1), list.GetCourseName(index, i), list.GetMark(index, i), Environment.NewLine);
            }

            if (list.GetCourseEnabled(index, 0) == false) //If the student has no courses
                infoViewerTXB.Text += string.Format("No courses to show.{0}", Environment.NewLine);
        }


        //
        //Event handler section
        //


        /// <summary>
        /// Click event for Add Student button to add a new student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addStudentBTN_Click(object sender, EventArgs e)
        {
            if (list.GetIndex() != list.GetStudentListSize()) //Only allows the max size of the student list to be added
            {
                using (Add_Student aS = new Add_Student()) //Initialize the add student form 
                {
                    if (aS.ShowDialog() == DialogResult.OK) //Checks to ensure the Add_Student form to returning an OK
                    {
                        list.SetName(list.GetIndex(), aS.nameTXT.Text); //Set student name to list
                        list.SetID(list.GetIndex(), Convert.ToInt32(aS.sidTXT.Text)); //Set student ID to list
                        list.SetAddress(list.GetIndex(), aS.addressTXT.Text); //Set address to student list
                        list.SetDOB(list.GetIndex(), DateTime.Parse(aS.dob.Text)); //Set date of birth to list
                        list.SetStudentEnabled(list.GetIndex(), true); //Set thast the student is enabled
                        FillDropDown(2 + list.GetIndex() - 1); //Populate Combobox
                        deleteAllStudentsBTN.Enabled = true; //Enables the delete button
                        saveBTN.Enabled = true; //enables the save button
                    }
                } 
            }
            else
                System.Windows.Forms.MessageBox.Show("No more students can be added."); //When 4 students have been added
        }

        /// <summary>
        /// Click event for the Update Student button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateStudentBTN_Click(object sender, EventArgs e)
        {
            using (Update_Student uS = new Update_Student()) //Initialize Update_Student
            {
                uS.SetStudent(list, studentSelectCB.SelectedIndex - 2); //Passes the student info to the form

                if (uS.ShowDialog() == DialogResult.OK) //If Update_Students returns OK
                {
                    uS.GetStudent(list, studentSelectCB.SelectedIndex - 2); //Get the updated info for the student
                    FillDropDown(studentSelectCB.SelectedIndex); //Populate Combobox
                }
            }
        }

        /// <summary>
        /// Select/Click event for the combobox Select Student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentSelectCB.SelectedIndex == 0) //If first element was selected
            {
                infoViewerTXB.Text = string.Format("Student Information...{0}Select a student from the drop down menu or add a new student with \"Add Student\" button to begin.", Environment.NewLine);
                deleteStudentBTN.Enabled = false; //Disable Delete Student btn
                updateStudentBTN.Enabled = false; //Disable Update Student btn
            }
            else if (studentSelectCB.SelectedIndex == 1) //If the "All"/second element was selected
            {
                deleteStudentBTN.Enabled = false; //Diable
                updateStudentBTN.Enabled = false; //Diable
                infoViewerTXB.Text = string.Empty; //Clear Info Viewer textbox
                for (int i = 0; i < list.GetIndex(); i++) //display all student info
                {
                    PrintStudents(i); //Function to display info
                    infoViewerTXB.Text += Environment.NewLine; //new line
                }
            }
            else
            {
                deleteStudentBTN.Enabled = true; //Enable
                updateStudentBTN.Enabled = true; //Enable
                infoViewerTXB.Text = string.Empty; //clear viewer
                PrintStudents(studentSelectCB.SelectedIndex - 2); //Funcation to dispplay info
            }
        }

        /// <summary>
        /// Click event for delete student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteStudentBTN_Click(object sender, EventArgs e)
        {
            //Warning before deleting
            if (MessageBox.Show("Are you sure you want to delete " + list.GetName(studentSelectCB.SelectedIndex - 2) + "?", 
                "Delete " + list.GetName(studentSelectCB.SelectedIndex - 2), 
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                list.DeleteStudent(studentSelectCB.SelectedIndex - 2); //Delete student
                if (list.GetIndex() == 0) //Checks if there are any students in the system
                {
                    deleteStudentBTN.Enabled = false; //Disable
                    deleteAllStudentsBTN.Enabled = false; //Disable
                    updateStudentBTN.Enabled = false; //Disable
                    saveBTN.Enabled = false; //Disable
                    FillDropDown(0);
                }
                else //If at least 1 student has been added
                {
                    FillDropDown(studentSelectCB.SelectedIndex - 1); //Populate Combobox
                }
            }
        }

        /// <summary>
        /// Click event to delete all students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteAllStudentsBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all students?", "Delete All Students",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) //Warning 1
            {
                if (MessageBox.Show("Are you sure this action can not be undone?", "Delete All Students? Really?!",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) //Warning 2
                {
                    list.DeleteAllStudents(); //Initialize list
                    deleteStudentBTN.Enabled = false; //Disable
                    deleteAllStudentsBTN.Enabled = false; //Disable
                    updateStudentBTN.Enabled = false; //Disable
                    saveBTN.Enabled = false; //Disable
                    FillDropDown(0); //Populate Combobox
                }
            }
        }

        /// <summary>
        /// Click event for Load btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadBTN_Click(object sender, EventArgs e)
        {
            string path = null; //File path
            string data = null; //Stores info
            bool load = true; //Used to determine if data should be loaded

            if(list.GetIndex() != 0) //If there are students in the list
            {
                //Display dialog box asking if it is alright to load new data
                if (MessageBox.Show("The current data might not be saved do you still want to load new data?",
                    "Load New Data",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    load = false; //If the user selected "No" new data will not be loaded
            }

            if (load == true)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog()) //Initialize open file dialog
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt"; //Acceptable files
                    openFileDialog.FilterIndex = 1; //Sets filter index to 1
                    openFileDialog.RestoreDirectory = true; //Gets last directory user was in
                    FileStream fs = null; //Initializes the file stream
                    StreamReader textIn = null; //Initialize stream reader

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path = Path.GetFullPath(openFileDialog.FileName); //Gets the file pat
                            fs = new FileStream(path, FileMode.OpenOrCreate); //Try to set the path and modfe to the filestream
                            textIn = new StreamReader(fs); //Try to open the file
                        }
                        catch (IOException ex) //If there was an IO exception error
                        {
                            System.Windows.Forms.MessageBox.Show(string.Format("Error reading from the file: {0}", ex.Message));
                        }
                        catch //Catch all other errors
                        {
                            System.Windows.Forms.MessageBox.Show("Error reading from the file");
                        }
                        finally
                        {
                            data = textIn.ReadToEnd(); //Get text from the file and set it into input
                            textIn.Close(); //Close the file
                            list.Load(data); //Stores the data into list
                            saveBTN.Enabled = true; //Enables the Save btn
                        }
                    }
                }

                if (list.GetIndex() != 0)
                    FillDropDown(1); //Populate Combobox
                else
                    FillDropDown(0); //Populate Combobox
                deleteAllStudentsBTN.Enabled = true; //Enables
            }
        }

        /// <summary>
        /// Click event for Save btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBTN_Click(object sender, EventArgs e)
        {
            string path = null; //Initialize path
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); //Initialize Save dialog
            saveFileDialog1.Filter = "TXT|*.txt"; //Acceptable file types
            saveFileDialog1.Title = "Save Students"; //Dialog name
            saveFileDialog1.ShowDialog(); //Displays dialof
            path = Path.GetFullPath(saveFileDialog1.FileName); //Gets file path
            FileStream fs = null; //Initializes the file stream
            StreamWriter textOut = null; //Initialize stream writer
            if (saveFileDialog1.FileName != "") //Ensures a file name has been added
            {
                try
                {
                    fs = new FileStream(path, FileMode.Create, FileAccess.Write); //Try to open the filestrrean
                    textOut = new StreamWriter(fs); //Initialize textOut
                }
                catch (IOException ex)
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Error writing to the file: {0}", ex.Message)); //Error if there is an IO exception
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error writing to the file"); //Error message for all other errors
                }
                finally
                {
                    if (fs != null) //Write if the filestream isn't null
                    {
                        textOut.Write(list.Save()); //Write the input stream to the file
                        textOut.Close(); //Close the file
                    }
                }
            }
        }

        /// <summary>
        /// Click event for Exit btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Close the application
        }
    }
}
