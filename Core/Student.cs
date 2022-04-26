//Purpose: To develop a student managment desktop software that can at a minimum store data to a text file,
//load the stored data, change the data and save the changes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT710_Assig3_School_Manager.Core
{
    public class Student
    {
        private Course[] c; //Makes an array of the course object
        private const int Size = 3; //Max size for the course array
        private string name; //Stores the students name
        private int studentID; //Stores the student ID
        private string address; //Stores the students address
        private DateTime dob; //Stores the students date of birth
        private int slot; //Stores what index the course array is at
        private bool enabled; //Stores if the student is enabled


        /// <summary>
        /// Constructor and initializes the variables
        /// </summary>
        public Student()
        {
            c = new Course[Size];
            for (int i = 0; i < c.Length; i++)
                c[i] = new Course();
            name = null;
            studentID = 0;
            address = null;
            dob = new DateTime();
            slot = 0;
            enabled = false;
        }

        /// <summary>
        /// Returns the size of the course array
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return Size;
        }

        /// <summary>
        /// Returns the currrent index of the course array
        /// </summary>
        /// <returns></returns>
        public int GetIndex()
        {
            return slot;
        }

        /// <summary>
        /// Returns the name of a course at a particular index in the course array
        /// </summary>
        /// <param name="i">Array element of the course in the list</param>
        /// <returns></returns>
        public string GetCourseName(int i)
        {
            try
            {
                return c[i].GetName();
            }
            catch
            {
                return "Error out of range";
            }
        }

        /// <summary>
        /// Stores the name of a course at a particular index in the course array
        /// </summary>
        /// <param name="i">Array element of the course in the list</param>
        /// <param name="n">The name of the course</param>
        public void SetCourseName(int i, string n)
        {
            try
            {
                c[i].SetName(n);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the mark of a course at a particular index in the course array
        /// </summary>
        /// <param name="i">Array element of the course in the list</param>
        /// <returns></returns>
        public int GetMark(int i)
        {
            try
            {
                return c[i].GetMark();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Stores the mark of a course at a particular index in the course array
        /// </summary>
        /// <param name="i">Array element of the course in the list</param>
        /// <param name="m">The mark the student got</param>
        public void SetMark(int i, int m)
        {
            try
            {
                c[i].SetMark(m);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the enabled option of a course at a particular index in the course array
        /// </summary>
        /// <param name="i">Array element of the course in the list</param>
        /// <returns></returns>
        public bool GetCEnabled(int i)
        {
            try
            {
                return c[i].GetEnabled();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Stores the enabled option of a course at a particular index in the course array
        /// </summary>
        /// <param name="i">Array element of the course in the list</param>
        /// <param name="e">Sets if the course is active</param>
        public void SetCEnabled(int i, bool e)
        {
            try
            {
                if (e == true)
                    slot++; //If the index is enabled increase the index
                c[i].SetEnabled(e);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the student name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Stores the student name
        /// </summary>
        /// <param name="n">The students name</param>
        public void SetName(string n)
        {
            name = n;
        }

        /// <summary>
        /// Returns the student ID
        /// </summary>
        /// <returns></returns>
        public int GetID()
        {
            return studentID;
        }

        /// <summary>
        /// Stores the student ID
        /// </summary>
        /// <param name="id">The students identification number</param>
        public void SetID(int id)
        {
            studentID = id;
        }

        /// <summary>
        /// Returns the student address
        /// </summary>
        /// <returns></returns>
        public string GetAddress()
        {
            return address;
        }

        /// <summary>
        /// Stores the student address
        /// </summary>
        /// <param name="a">The students address</param>
        public void SetAddress(string a)
        {
            address = a;
        }

        /// <summary>
        /// Retunes the students birthday
        /// </summary>
        /// <returns></returns>
        public DateTime GetDOB()
        {
            return dob;
        }

        /// <summary>
        /// Store the students birthday
        /// </summary>
        /// <param name="d">The students date of birth</param>
        public void SetDOB(DateTime d)
        {
            dob = d;
        }

        /// <summary>
        /// Returns the student enabled option
        /// </summary>
        /// <returns></returns>
        public bool GetEnabled()
        {
            return enabled;
        }

        /// <summary>
        /// Stores the student enabled option
        /// </summary>
        /// <param name="e">Sets if the student is active or not</param>
        public void SetEnabled(bool e)
        {
            enabled = e;
        }

        /// <summary>
        /// Deletes a course in the course array based on the index
        /// </summary>
        /// <param name="i">Array element of the course in the course list</param>
        public void DeleteCourse(int i)
        {
            bool deleted = true; //Ensures the delete action can occur

            if (i >= Size) //Checks to see if the index falls out of bounds
                deleted = false;

            if(deleted == true) //Course can be deleted
            {
                //Not the best delete function, but it works
                if(i != Size - 1)
                {
                    for (int m = i; m < Size - 1; m++) //Starting at the deleted index overwrite each index until the end
                        c[m] = c[m + 1];
                }

                c[Size - 1] = new Course(); //Initialize the last index

                slot--; //reduce the course count
            }
        }

        /// <summary>
        /// Deletes all courses in the course array by initialize each index
        /// </summary>
        public void DeleteAllCourses()
        {
            for (int i = 0; i < c.Length; i++)
                c[i] = new Course();
            slot = 0;
        }
    }
}
