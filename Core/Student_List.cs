//Purpose: To develop a student managment desktop software that can at a minimum store data to a text file,
//load the stored data, change the data and save the changes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT710_Assig3_School_Manager.Core
{
    public class Student_List
    {
        private Student[] sL; //Creates an array of the student object
        private const int Size = 4; //Max size of the student array
        private int slot; //Stores the current index of the student array

        /// <summary>
        /// Constructor and initializes the variables
        /// </summary>
        public Student_List()
        {
            sL = new Student[Size];
            for (int i = 0; i < sL.Length; i++)
                sL[i] = new Student();
            slot = 0;
        }

        /// <summary>
        /// Returns the student array size
        /// </summary>
        /// <returns>
        /// The length of the student list
        /// </returns>
        public int GetStudentListSize()
        {
            return Size;
        }

        /// <summary>
        /// Returns the size of the course array in the student object
        /// </summary>
        /// <returns>
        /// </returns>
        public int GetCourseListSize()
        {
            return sL[0].GetSize();
        }

        /// <summary>
        /// Returns the index of the student array
        /// </summary>
        /// <returns></returns>
        public int GetIndex()
        {
            return slot;
        }

        /// <summary>
        /// Returns the index of the course array in the student object
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <returns></returns>
        public int GetCourseIndex(int index)
        {
            return sL[index].GetIndex();
        }

        /// <summary>
        /// Returns the name of a course in the student object
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="courseIndex">Array element of that course</param>
        /// <returns></returns>
        public string GetCourseName(int index, int courseIndex)
        {
            try
            {
                return sL[index].GetCourseName(courseIndex);
            }
            catch
            {
                return "Error out of range";
            }
        }

        /// <summary>
        /// Stores the name of a course in the student object
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="courseIndex">Array element of that course</param>
        /// <param name="name">Name of the class</param>
        public void SetCourseName(int index, int courseIndex, string name)
        {
            try
            {
                sL[index].SetCourseName(courseIndex, name);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the mark of a course for a student in the student object
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="markIndex">Array element of that course</param>
        /// <returns></returns>
        public int GetMark(int index, int markIndex)
        {
            try
            {
                return sL[index].GetMark(markIndex);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Stores the mark for a course in the student object
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="markIndex">Array element of that course</param>
        /// <param name="mark">The grade that the student got</param>
        public void SetMark(int index, int markIndex, int mark)
        {
            try
            {
                sL[index].SetMark(markIndex, mark);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the enabled option of a course for a student in the student object
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="courseIndex">Array element of that course</param>
        /// <returns></returns>
        public bool GetCourseEnabled(int index, int courseIndex)
        {
            try
            {
                return sL[index].GetCEnabled(courseIndex);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Stores the enabled option of a course for a student in the student object
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="courseIndex">Array element of that course</param>
        /// <param name="enabled">Sets if the class is actice or not</param>
        public void SetCourseEnabled(int index, int courseIndex, bool enabled)
        {
            try
            {
                sL[index].SetCEnabled(courseIndex, enabled);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Deletes a course of a student
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="courseIndex">Array element of that course</param>
        public void DeleteCourse(int index, int courseIndex)
        {
            try
            {
                sL[index].DeleteCourse(courseIndex);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Deletes all the courses for a student
        /// </summary>
        /// <param name="index">Array element of that student</param>
        public void DeleteAllCourses(int index)
        {
            try
            {
                sL[index].DeleteAllCourses();
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the students name
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <returns></returns>
        public string GetName(int index)
        {
            try
            {
                return sL[index].GetName();
            }
            catch
            {
                return "Error out of bounds.";
            }
        }

        /// <summary>
        /// Stores the students name
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="name">The students name</param>
        public void SetName(int index, string name)
        {
            try
            {
                sL[index].SetName(name);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the students ID number
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <returns></returns>
        public int GetID(int index)
        {
            try
            {
                return sL[index].GetID();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Stores the students ID number
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="id">The student identification number</param>
        public void SetID(int index, int id)
        {
            try
            {
                sL[index].SetID(id);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the students address
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <returns></returns>
        public string GetAddress(int index)
        {
            try
            {
                return sL[index].GetAddress();
            }
            catch
            {
                return "Error out of bounds.";
            }
        }

        /// <summary>
        /// Stores the students address
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="address">The students address</param>
        public void SetAddress(int index, string address)
        {
            try
            {
                sL[index].SetAddress(address);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returens the students birthday
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <returns></returns>
        public DateTime GetDOB(int index)
        {
            try
            {
                return sL[index].GetDOB();
            }
            catch
            {
                return sL[0].GetDOB();
            }
        }

        /// <summary>
        /// Stores the students birthday
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="dob">The students birthday</param>
        public void SetDOB(int index, DateTime dob)
        {
            try
            {
                sL[index].SetDOB(dob);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Returns the student enabled option
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <returns></returns>
        public bool GetStudentEnabled(int index)
        {
            try
            {
                return sL[index].GetEnabled();
            }
            catch
            {
                return true;
            }
        }

        /// <summary>
        /// Stores the student enabled option
        /// </summary>
        /// <param name="index">Array element of that student</param>
        /// <param name="enabled">Sets if the student is active or not</param>
        public void SetStudentEnabled(int index, bool enabled)
        {
            try
            {
                if (enabled == true)
                    slot++; //Increase the student index
                sL[index].SetEnabled(enabled);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Delete a student from the student array
        /// </summary>
        /// <param name="index">Array element of that student</param>
        public void DeleteStudent(int index)
        {
            bool deleted = true; //Ensures the student can be deleted

            if (index >= Size) //Makes sure the index isn't outside of the array
                deleted = false;

            if (deleted == true)
            {
                if (index != Size - 1)
                {
                    for (int m = index; m < Size - 1; m++) //Starting at the deleted index overwrite each index until the end
                        sL[m] = sL[m + 1];
                }

                sL[Size - 1] = new Student(); //Initialize the last index

                slot--; //Reduce student count
            }
        }

        /// <summary>
        /// Deletes all students in the student array
        /// </summary>
        public void DeleteAllStudents()
        {
            for (int i = 0; i < sL.Length; i++)
                sL[i] = new Student();
            slot = 0;
        }

        //Can not trust data entering the system so checks have been added
        /// <summary>
        /// Loads student data from a file
        /// </summary>
        /// <param name="data">The data from the file is passed as a string variable</param>
        public void Load(string data)
        {
            string[] students = new string[Size]; //Stores each student data
            string[] properties = new string[Size]; //Stores the items of the student
            bool error = false; //Was there an error durning the read
            bool sizeError = false; //Ensures that the file added is of a correct size
            string errorMessage = null; //Error message

            DeleteAllStudents(); //Ensures that there are no valid students in the list

            students = data.Split("\n"); //Stores each student into students along new lines

            if (students.Length != Size) //Ensures the file has the correct amount of students
            {//If file is too big or too small
                sL[0].SetName("Error"); //Set the name of student to error
                sL[0].SetAddress("Invalid file or file is corrupted."); //Set the address to a warning message
                SetStudentEnabled(0, true); //Enable the student
                sizeError = true; //pervents entering the loop due to error
            }

            for (int i = 0; i < Size && sizeError == false; i++)
            {
                properties = students[i].Split("|"); //Breaks up each students items along | and stores it into properties

                errorMessage = string.Format("Errors in file for {0}: ", properties[1]); //Start building error message

                try
                {
                    slot = Convert.ToInt32(properties[0]); //Ensures the student index is an int
                }
                catch
                {
                    error = true; //Error found
                    slot = 0;
                    errorMessage += "Index not a number, ";
                }
                sL[i].SetName(properties[1]);
                try
                {
                    sL[i].SetID(Convert.ToInt32(properties[2])); //Ensures the student ID is an int
                }
                catch
                {
                    error = true; //Error found
                    sL[i].SetID(0);
                    errorMessage += "Invalid ID, ";
                }
                sL[i].SetAddress(properties[3]);
                try
                {
                    sL[i].SetDOB(DateTime.Parse(properties[4])); //Ensures the birthday is valid
                }
                catch
                {
                    error = true; //Error found
                    sL[i].SetDOB(DateTime.Now);
                    errorMessage += "Invalid birthday, ";
                }
                try
                {
                    sL[i].SetEnabled(Convert.ToBoolean(properties[5])); //Ensures the enabled option is valid
                }
                catch
                {
                    error = true; //Error found
                    sL[i].SetEnabled(true);
                    errorMessage += "Student enabled error, ";
                }
                for (int m = 0; m < sL[i].GetSize(); m++)
                {
                    sL[i].SetCourseName(m, properties[6 + m * 3]); //Stores the course name
                    try
                    {
                        sL[i].SetMark(m, Convert.ToInt32(properties[7 + m * 3])); //Ensures the mark is an int
                    }
                    catch
                    {
                        error = true; //Error found
                        sL[i].SetMark(m, 0);
                        errorMessage += "Invalid mark for course " + (m + i) + ", ";
                    }
                    try
                    {
                        sL[i].SetCEnabled(m, Convert.ToBoolean(properties[8 + m * 3])); //Ensures the enabled option is valid
                    }
                    catch
                    {
                        error = true; //Error found
                        sL[i].SetCEnabled(m, true);
                        errorMessage += "Course enabled error, ";

                    }
                }
                if (error == true) //Display error message if error was found
                    sL[i].SetName(errorMessage);
            }
        }

        /// <summary>
        /// Save student data to a file
        /// </summary>
        /// <returns>
        /// Returns the student information as a string back to the calling function
        /// </returns>
        public string Save()
        {
            string data = null;
            //The assumption that the data leaving the application is right so no checks have been added
            for (int i = 0; i < Size; i++)
            {
                data += slot + "|";
                data += sL[i].GetName() + "|";
                data += sL[i].GetID() + "|";
                data += sL[i].GetAddress() + "|";
                data += sL[i].GetDOB() + "|";
                data += sL[i].GetEnabled() + "|";
                for (int m = 0; m < sL[i].GetSize(); m++)
                {
                    data += sL[i].GetCourseName(m) + "|";
                    data += sL[i].GetMark(m) + "|";
                    data += sL[i].GetCEnabled(m);
                    if (m != sL[i].GetSize() - 1)
                        data += "|";
                }

                if (i != Size - 1)
                    data += "\n";
            }

            return data;
        }
    }
}