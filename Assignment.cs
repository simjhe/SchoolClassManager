using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassManager
{
    /// <summary>
    /// treat an assignment as own class
    /// </summary>
    public class Assignment
    {
        /// <summary>
        /// fields
        /// </summary>
        private string name;
        private double grade;
        private DateTime date;
        private string notes;
        private Subjects subject;

        /// <summary>
        /// default constructor
        /// </summary>
        public Assignment () 
        { 
        
        }

        /// <summary>
        /// constructor with the class variables as input
        /// </summary>
        public Assignment(string name, double grade, DateTime date, string notes, Subjects subject) : this()
        {
            this.name = name; // assign inputted values of constructor to instance variables of class
            this.grade = grade;
            this.date = date;
            this.notes = notes;
            this.subject = subject;
        } 

        /// <summary>
        /// simple properties
        /// </summary>
        public string Name { get { return name; }  set { name = value; } } // no input validation here since this is handled in other classes

        public double Grade { get {  return grade; } set {  grade = value; } }

        public DateTime Date { get { return date; } set { date = value; } }

        public string Notes { get { return notes; } set { notes = value; } }

        public Subjects Subject { get { return subject; } set { subject = value; } }
    }
}
