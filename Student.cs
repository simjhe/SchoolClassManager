using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassManager
{
    /// <summary>
    /// handle student as own class
    /// </summary>
    public class Student
    {
        /// <summary>
        /// fields
        /// </summary>
        private Address address;
        private List<Assignment> assignments;
        private DateTime birthday;
        private string firstname;
        private string lastname;

        /// <summary>
        /// default constructor
        /// </summary>
        public Student()
        {
            assignments = new List<Assignment>(); // instantiate new collection of assignments when instantiating a student object
        }

        /// <summary>
        /// properties
        /// </summary>
        public Address Address 
        { 
            get { return address; } 
            set { address = value; } // no input validation here since this is handled in other classes
        }

        public List<Assignment> Assignments
        {
            get { return assignments; }
            set { assignments = value; }
        }

        public DateTime Birthday 
        { 
            get { return birthday; } 
            set { birthday = value; } 
        }

        public string Firstname 
        { 
            get { return firstname; } 
            set { firstname = value; } 
        }

        public string Lastname 
        { 
            get { return lastname; } 
            set { lastname = value; } 
        }
    }
}
