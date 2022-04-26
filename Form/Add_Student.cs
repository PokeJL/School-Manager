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
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for Cancel btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close(); //Close form
        }

        /// <summary>
        /// Click event for the add student btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBTN_Click(object sender, EventArgs e)
        {
            string message = null; //The string that stores the error message
            bool done = true; //Ensures that no error was made during input of data
            
            if (nameTXT.Text == string.Empty) //Warning no name
            {
                message += "\nA name.";
                done = false;
            }
            if (sidTXT.Text == string.Empty) //Warning no ID
            {
                message += "\nA student ID";
                done = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(sidTXT.Text);
                }
                catch
                {
                    message += "\nA valid student ID."; //Warning ID isn't a int
                    done = false;
                }
            }
            if (addressTXT.Text == string.Empty) //Warning no address
            {
                message += "\nAn address.";
                done = false;
            }
            try
            {
                DateTime.Parse(dob.Text);
            }
            catch
            {
                message += "\nA correct birthday."; //Warning invalid birthday
                done = false;
            }

            if (done == false) //If error was encountered
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Please enter: {0}", message));
                done = true;
            }
            else
            {
                DialogResult = DialogResult.OK; //Return OK
                Close(); //Close form
            }
        }
    }
}
