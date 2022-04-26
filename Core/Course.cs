//Purpose: To develop a student managment desktop software that can at a minimum store data to a text file,
//load the stored data, change the data and save the changes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT710_Assig3_School_Manager.Core
{
    class Course
    {
        private string name; //Stores course name
        private int mark; //Stores course mark
        private bool enabled; //Stores if the course is enabled

        /// <summary>
        /// Constructor and initializes the variables
        /// </summary>
        public Course()
        {
            name = null;
            mark = 0;
            enabled = false;
        }

        /// <summary>
        /// Returns the course name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Stores the course name
        /// </summary>
        /// <param name="n"></param>
        public void SetName(string n)
        {
            name = n;
        }

        /// <summary>
        /// Returns the mark
        /// </summary>
        /// <returns></returns>
        public int GetMark()
        {
            return mark;
        }

        /// <summary>
        /// Stores the mark
        /// </summary>
        /// <param name="m"></param>
        public void SetMark(int m)
        {
            mark = m;
        }

        /// <summary>
        /// Returns if the course is enabled
        /// </summary>
        /// <returns></returns>
        public bool GetEnabled()
        {
            return enabled;
        }

        /// <summary>
        /// Store if the course's enabled option
        /// </summary>
        /// <param name="e"></param>
        public void SetEnabled(bool e)
        {
            enabled = e;
        }
    }
}
