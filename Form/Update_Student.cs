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

namespace ICT710_Assig3_School_Manager
{
    public partial class Update_Student : Form
    {
        private static Core.Student_List stu; //Declares Student_List stu
        private int index; //Stores index old relic that was too much work to remove when I relized a mistake was made
        public Update_Student()
        {
            InitializeComponent();
            stu = new Core.Student_List(); //Initialize stu
            index = 0; //Initialize index will remain 0
        }

        //
        //Custom and reuable functions section
        //


        /// <summary>
        /// Extracts the students information for the Update Student form
        /// </summary>
        /// <param name="student">Student_List object that contains the students information</param>
        /// <param name="slot">Array element index of the student in the Student_List</param>
        public void SetStudent(Core.Student_List student, int slot)
        {
            //Next few lines copies the student info into the 0 index of stu
            stu.SetName(0, student.GetName(slot));
            stu.SetAddress(0, student.GetAddress(slot));
            stu.SetID(0, student.GetID(slot));
            stu.SetDOB(0, student.GetDOB(slot));

            for (int i = 0; i < student.GetCourseListSize(); i++)
            {
                stu.SetCourseName(0, i, student.GetCourseName(slot, i));
                stu.SetMark(0, i, student.GetMark(slot, i));
                stu.SetCourseEnabled(0, i, student.GetCourseEnabled(slot, i));
            }

            //index = slot; //This can be enabled to make program more flexiable down the road don't able now

            //Next few lines populates the form and combobox with info from stu
            nameTXT.Text = stu.GetName(index);
            addressTXT.Text = stu.GetAddress(index);
            sidTXT.Text = Convert.ToString(stu.GetID(index));
            dob.Value = stu.GetDOB(index);

            if (stu.GetCourseIndex(index) == 0) //If the student has now courses
            {
                object[] dropDown = new object[1]; //Initialize
                dropDown[0] = "New course";
                courseSelectCB.Items.AddRange(dropDown); //Bind
                courseSelectCB.SelectedIndex++; //Go to first item
            }
            else if (stu.GetCourseIndex(index) == stu.GetCourseListSize()) //If student has max courses
            {
                object[] dropDown = new object[stu.GetCourseIndex(index)]; //Initialize
                for (int i = 0; i < stu.GetCourseIndex(index); i++)
                {
                    dropDown[i] = stu.GetCourseName(index, i);
                }
                courseSelectCB.Items.AddRange(dropDown); //Bind
                courseSelectCB.SelectedIndex = stu.GetCourseIndex(index) - 1; //Go to last item
            }
            else //If student has classes but not max classes
            {
                object[] dropDown = new object[stu.GetCourseIndex(index) + 1]; //Initialize
                for (int i = 0; i < stu.GetCourseIndex(index); i++)
                {
                    dropDown[i] = stu.GetCourseName(index, i);
                }
                dropDown[stu.GetCourseIndex(index)] = "New course";
                courseSelectCB.Items.AddRange(dropDown); //Bind
                courseSelectCB.SelectedIndex = stu.GetCourseIndex(index); //Go to last item "New course"
            }
        }

        /// <summary>
        /// Returns student info back to main form list object
        /// </summary>
        /// <param name="student">Student_List object that contains the students information</param>
        /// <param name="slot">Array element index of the student in the Student_List</param>
        public void GetStudent(Core.Student_List student, int slot)
        {
            //Updates the student with info from stu
            student.SetName(slot, stu.GetName(0));
            student.SetAddress(slot, stu.GetAddress(0));
            student.SetID(slot, stu.GetID(0));
            student.SetDOB(slot, stu.GetDOB(0));
            for(int i = 0; i < student.GetCourseListSize(); i++)
            {
                student.SetCourseName(slot, i, stu.GetCourseName(0, i));
                student.SetMark(slot, i, stu.GetMark(0, i));
                student.SetCourseEnabled(slot, i, stu.GetCourseEnabled(0, i));
            }
        }

        /// <summary>
        /// This function populates the combobox
        /// </summary>
        /// <param name="jump">The element of the combobox that should be selected after the function is done</param>
        private void FillDropDown(int jump)
        {
            courseSelectCB.Items.Clear(); //Clear combobox
            if (stu.GetCourseIndex(index) == stu.GetCourseListSize()) //If the student is taking make courses
            {
                object[] dropDown = new object[stu.GetCourseIndex(index)]; //Initialize combobox
                for (int i = 0; i < stu.GetCourseIndex(index); i++)
                {
                    dropDown[i] = stu.GetCourseName(index, i); //add names
                }
                courseSelectCB.Items.AddRange(dropDown); //bind
            }
            else
            {
                courseSelectCB.Items.Clear();
                object[] dropDown = new object[stu.GetCourseIndex(index) + 1]; //Initialize combobox
                for (int i = 0; i < stu.GetCourseIndex(index); i++)
                {
                    dropDown[i] = stu.GetCourseName(index, i); //add names
                }
                dropDown[stu.GetCourseIndex(index)] = "New course"; //add new course at the end of the list
                courseSelectCB.Items.AddRange(dropDown); //bind
            }
            courseSelectCB.SelectedIndex = jump; //go to the desired index
        }

        //
        //This is the event handler section
        //


        /// <summary>
        /// Adds a new course to a student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCourseBTN_Click(object sender, EventArgs e)
        {
            bool go = true; //Check to see no error has been made before adding a course

            try
            {
                Convert.ToInt32(cMarkTXT.Text); //Ensure mark in an int
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid mark."); //Warning
                go = false;
            }
            //If go is still true and neither textbox isn't empty
            if (go == true && 
                stu.GetCourseEnabled(index, courseSelectCB.SelectedIndex) == false && 
                cNameTXT.Text != string.Empty &&
                cMarkTXT.Text != string.Empty)
            {
                stu.SetCourseName(index, courseSelectCB.SelectedIndex, cNameTXT.Text);
                stu.SetMark(index, courseSelectCB.SelectedIndex, Convert.ToInt32(cMarkTXT.Text));
                stu.SetCourseEnabled(index, courseSelectCB.SelectedIndex, true);

                if (stu.GetCourseIndex(index) == stu.GetCourseListSize())
                    FillDropDown(stu.GetCourseIndex(index) - 1); //Populate combobox
                else
                    FillDropDown(stu.GetCourseIndex(index)); //populate combobox
            }
            else if (cNameTXT.Text == string.Empty) //Warning empty course name
                System.Windows.Forms.MessageBox.Show("Please enter a course name.");
            else if (cMarkTXT.Text == string.Empty) //Warning no mark
                System.Windows.Forms.MessageBox.Show("Please enter a course mark.");
            else if(stu.GetCourseIndex(index) == stu.GetCourseListSize()) ////Warning no more classes can be added
                System.Windows.Forms.MessageBox.Show("No more courses can be added.");
            else if(stu.GetCourseEnabled(index, courseSelectCB.SelectedIndex) == true) //Warning Tring to update instead of add
                System.Windows.Forms.MessageBox.Show("Use the \"Update Course\" button.");
        }

        /// <summary>
        /// Select course from combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void courseSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cNameTXT.Text = stu.GetCourseName(index, courseSelectCB.SelectedIndex); //Adds course name to cName textbox
            cMarkTXT.Text = Convert.ToString(stu.GetMark(index, courseSelectCB.SelectedIndex)); //Adds course mark to cMark textbox

            if (stu.GetCourseEnabled(0, courseSelectCB.SelectedIndex) == true) //Checks to see if coourse is enabled
                deleteCBTN.Enabled = true; //Enable delete
            else
                deleteCBTN.Enabled = false; //Disable delete
        }

        /// <summary>
        /// Click event fro the Update Course btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateCourseBTN_Click(object sender, EventArgs e)
        {
            bool go = true; //Ensures that no error have been made

            try
            {
                Convert.ToInt32(cMarkTXT.Text); //Ensures the new mark is an int
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid mark."); //Warning mark not int
                go = false;
            }
            //If go is still true and neither textbox is empty
            if (go == true &&
                stu.GetCourseEnabled(0, courseSelectCB.SelectedIndex) == true &&
                cNameTXT.Text != string.Empty &&
                cMarkTXT.Text != string.Empty)
            {
                stu.SetCourseName(index, courseSelectCB.SelectedIndex, cNameTXT.Text);
                stu.SetMark(index, courseSelectCB.SelectedIndex, Convert.ToInt32(cMarkTXT.Text));
                FillDropDown(courseSelectCB.SelectedIndex); //Populate combobox
            }
            else if (stu.GetCourseEnabled(0, courseSelectCB.SelectedIndex) == false) //Warning a course was not selected
                System.Windows.Forms.MessageBox.Show("Please select a course.");
            else if (cNameTXT.Text == string.Empty) //Warning a name hasn't been added
                System.Windows.Forms.MessageBox.Show("Please enter a course name.");
            else if (cMarkTXT.Text == string.Empty) //Warning a mark has not been added
                System.Windows.Forms.MessageBox.Show("Please enter a course mark.");
        }

        

        /// <summary>
        /// click event for Delete Course btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteCBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + stu.GetCourseName(0, courseSelectCB.SelectedIndex) + "?",
                "Delete " + stu.GetCourseName(0, courseSelectCB.SelectedIndex),
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) //Warning
            {
                stu.DeleteCourse(0, courseSelectCB.SelectedIndex); //Deletes the course

                if (stu.GetCourseIndex(index) == 0) //If the student has no courses
                {
                    FillDropDown(0); //Populate combobox
                }
                else
                {
                    FillDropDown(stu.GetCourseIndex(index)); //populate combobox
                }
            }
        }

        /// <summary>
        /// Click event for the update btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateBTN_Click(object sender, EventArgs e)
        {
            string message = null; //Error message
            bool done = true;

            if (nameTXT.Text == string.Empty) //Empty name
            {
                message += "\nA name.";
                done = false;
            }
            if (sidTXT.Text == string.Empty) //Empty ID
            {
                message += "\nA student ID";
                done = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(sidTXT.Text); //Ensure ID is an int
                }
                catch
                {
                    message += "\nA valid student ID.";
                    done = false;
                }
            }
            if (addressTXT.Text == string.Empty) //Empty address
            {
                message += "\nAn address.";
                done = false;
            }
            try
            {
                DateTime.Parse(dob.Text); //Ensure a proper birthday was added
            }
            catch
            {
                message += "\nA correct birthday.";
                done = false;
            }

            if (done == false) //If error was found
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Please enter: {0}", message));
                done = true;
            }
            else //update stu non course info
            {
                stu.SetName(0, nameTXT.Text);
                stu.SetAddress(0, addressTXT.Text);
                stu.SetID(0, Convert.ToInt32(sidTXT.Text));
                stu.SetDOB(0, DateTime.Parse(dob.Text));

                DialogResult = DialogResult.OK; //Return OK
                Close(); //Close form
            }
        }

        /// <summary>
        /// Click event for Cancel btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close(); //close form
        }
    }
}
