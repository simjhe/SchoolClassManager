using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolClassManager
{
    public partial class AssignmentForm : Form
    {
        /// <summary>
        /// fields
        /// </summary>
        private Student student;
        private List<Assignment> assignments;
        private StudentManager studentManager;

        /// <summary>
        /// default constructor
        /// </summary>
        public AssignmentForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// initialize the look and properties of the assignments form
        /// </summary>
        private void InitializeGUI()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // fixed borders (no resizing possible)
            this.MaximizeBox = false; // no maximizing
            CenterToScreen(); // set form to center of screen

            // set format of date time picker
            dateTimePickerAssignmentDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerAssignmentDate.CustomFormat = "yyyy-MM-dd";

            // make subjects based on the enum class available in combobox
            cmbBoxSubject.Items.AddRange(Enum.GetNames(typeof(Subjects)));
        }

        /// <summary>
        /// constructor with student object as input
        /// </summary>
        /// <param name="student"></param>
        public AssignmentForm(Student student, StudentManager studentManager) : this()
        {
            // assign the student from the constructor input, its list of assignments and the already instantiated studentManager-object (from MainForm) to the instance variables of the form
            this.student = student;
            this.assignments = student.Assignments;
            this.studentManager = studentManager;

            // show information on assignments in listBox after opening the form
            UpdateAssignmentList();
        }

        /// <summary>
        /// add an assignment to the assignment list when user clicks on add-button
        /// </summary>
        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            Assignment assignment = ReadInput(); // read in assignment information from user and store it in assignment object

            if (assignment != null) // if a proper assignment object was provided
            {
                assignments.Add(assignment); // add the assignment to the assignment collection

                UpdateAssignmentList(); // update the listBox containing the assignments
            }
        }

        /// <summary>
        /// change an assignment based on the input values at the selected item from the assignment list
        /// </summary>
        private void btnChangeAssignment_Click(object sender, EventArgs e)
        {
            int index = lstBoxAssignments.SelectedIndex; // get the index of the by user selected item

            if (CheckIndex(index)) // if a proper index (in range) was provided 
            {
                Assignment assignment = ReadInput(); // read in assignment information from user input and store it in assignment object

                if (assignment != null) // if a proper assignment object was provided
                {
                    assignments[index] = assignment; // store the assignment in the assignment list

                    UpdateAssignmentList(); // update the listBox containing the assignments
                }
            }
            else // if no proper index was provided
            {
                MessageBox.Show("Please select an assignment from the assignment list", "Error");  // return an error message
            }
        }

        /// <summary>
        /// delete an assignment from the assignment list at the selected index
        /// </summary>
        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            int index = lstBoxAssignments.SelectedIndex; // get the index of the by user selected item

            if (CheckIndex(index)) // if a proper index (in range) was provided 
            {
                assignments.RemoveAt(index); // remove the assignment from the assignment list at the provided index

                UpdateAssignmentList(); // update the listBox showing assignment information
            }
            else // if no proper index was provided
            {
                MessageBox.Show("Please select an assignment from the assignment list", "Error"); // return an error message
            }
        }

        /// <summary>
        /// fill in input fields based on selected assignment in assignment list
        /// </summary>
        private void lstBoxAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBoxAssignments.SelectedIndex; // get the index of the by user selected item

            if (CheckIndex(index)) // if a proper index (in range) was provided 
            { 
                Assignment assignment = assignments[index]; // store the assignment at the provided index in local variable

                // show information of selected assignment in input fields
                txtAssignmentName.Text = assignment.Name;
                txtGrade.Text = assignment.Grade.ToString();
                txtNotes.Text = assignment.Notes;
                cmbBoxSubject.SelectedIndex = (int)assignment.Subject;
                dateTimePickerAssignmentDate.Value = assignment.Date;
            }
        }

        /// <summary>
        /// read and validate assignment information from user input
        /// </summary>
        /// <returns>assignment object or null</returns>
        private Assignment ReadInput() 
        { 
            // read in all input values and store in local variables
            string name = txtAssignmentName.Text.Trim();
            DateTime date = dateTimePickerAssignmentDate.Value;
            Subjects subject = (Subjects)cmbBoxSubject.SelectedIndex;
            string grade = txtGrade.Text.Trim();
            string notes = txtNotes.Text;

            if (CheckData(name, date, subject, grade)) // if all necessary assignment information (name, date, subject, grade) were provided 
            {
                if (CheckGrade(grade)) // and if grade has a proper value (a double between 1 and 6)
                {
                    double gradeDbl = double.Parse(grade); // store the grade as double

                    Assignment assignment = new Assignment(name, gradeDbl, date, notes, subject); // instantiate new assignment object and put assignment information to constructor

                    return assignment; // return the assignment object containing the assignment information
                } 
                else // if grade has no proper value
                {
                    MessageBox.Show("Grade needs to be a numeric value between 1 and 6", "Error"); // show an error message
                    return null;  // return null
                }
            }
            else // if assignment information are missing from the input
            {
                MessageBox.Show("Please provide the name, the date, the subject and the grade of the assignment", "Input error"); // show an error message to the user
                return null; // return null
            }
        }

        /// <summary>
        /// check whether all required input values for assignment (name, date, subject, grade) were provided 
        /// </summary>
        /// <returns>a boolean value indicating whether all required input values were provided</returns>
        private bool CheckData(string name, DateTime date, Subjects subject, string grade)
        {
            bool ok = false;
            DateTime checkDt = new DateTime(2020, 1, 1); // instantiate new DateTime object that is used to check whether assignments were after 2015 - this will be used to check whether assignment date is valid

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(grade) && date > checkDt && Enum.IsDefined(typeof(Subjects), subject)) // if values for all important assignments properties were provided (note that assignments' dates need to be after 2015 to be considered as valid)
                ok = true; // ok is true

            return ok;
        }

        /// <summary>
        /// check whether a value for grade was provided that is a double and lies between 1 and 6
        /// </summary>
        /// <param name="grade">the grade string</param>
        /// <returns>a boolean value indicating whether a proper grade value was provided</returns>
        private bool CheckGrade(string grade) 
        { 
            bool parsable = double.TryParse(grade, out double gradeDouble); // store in bool whether the input value (string) can be parsed to a double and return the double of grade (if it is possible to parse)
   
            bool ok = false;

            if (gradeDouble >= 1 && gradeDouble <= 6 && parsable) // if the double of grade lies between 1 and 6 and is parsable (the last condition is technically not necessary, but makes it logically more readable)
                ok = true; // return true

            return ok;        
        }

        /// <summary>
        /// check whether an assignment index was provided that is not out of range
        /// </summary>
        /// <param name="index">the index of the selected assignment in the assignment list</param>
        /// <returns>a bool value indicating whether a proper assignment index was provided</returns>
        private bool CheckIndex(int index)
        {
            bool ok = false;

            if (index >= 0 && index < assignments.Count) // if index is above -1 and lower than the length of the assignment list
                ok = true;  // return true indicating that the index is properly chosen

            return ok;
        }

        /// <summary>
        /// update the assignment information in the listBox
        /// </summary>
        private void UpdateAssignmentList() 
        {
            lstBoxAssignments.Items.Clear(); // clear listBox before entering new values

            // return information on each assignment in array and put it into listBox
            string[] assignmentInfos = studentManager.GetAssignmentInfoStringAssignmentForm(student); // create a string array that contains information on each assignment with information retrieved from another method in studentManager

            if (assignmentInfos != null) // if the array of assignment information is not empty
            {
                // put each assignment information string in the string array of assignment information in the listBox one by one
                foreach (string assignmentInfosOut in assignmentInfos) 
                {
                    lstBoxAssignments.Items.Add(assignmentInfosOut);
                }
            }

            ClearInputFields(); // clear all the input fields after updating the assignment listBox
        }

        /// <summary>
        /// clear all input fields
        /// </summary>
        private void ClearInputFields() 
        { 
            txtAssignmentName.Text = string.Empty;  // empty each text input fields
            txtGrade.Text = string.Empty;
            txtNotes.Text = string.Empty;
            cmbBoxSubject.SelectedIndex = -1;  // and set the combobox and the date time picker to its default values
            dateTimePickerAssignmentDate.Value = DateTime.Now;        
        }

        /// <summary>
        /// when the user clicks on the OK-button, close the assignment form
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
