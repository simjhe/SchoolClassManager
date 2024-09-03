using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ActivationContext;

namespace SchoolClassManager
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// fields
        /// </summary>
        private StudentManager studentManager;

        /// <summary>
        /// default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// set up the look and behavior of the main form and instantiate the instance variables
        /// </summary>
        private void InitializeGUI() 
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // fixed borders (no resizing possible)
            this.MaximizeBox = false; // no maximizing
            CenterToScreen(); // set form to center of screen

            studentManager = new StudentManager(); // instantiate the studentManager class

            ActivateButtons();  // deactivate some of the buttons
        }

        /// <summary>
        /// activate and deactivate the buttons on editing assignments/students and deleting based on whether there are students in the student list
        /// </summary>
        private void ActivateButtons() 
        { 
            if (studentManager.ExistStudents()) // if there are any students in the student list
            { 
                // activate the buttons
                btnChangeStudentData.Enabled = true; 
                btnDeleteStudent.Enabled = true;
                btnAssignments.Enabled = true;
                btnTranscript.Enabled = true;
            } 
            else // in any other case
            { 
                // deactivate most of the buttons
                btnChangeStudentData.Enabled = false;
                btnDeleteStudent.Enabled = false;
                btnAssignments.Enabled = false;
                btnTranscript.Enabled = false;
            }
        
        }

        /// <summary>
        /// add a student (based on the inputs in the student form) to the student list
        /// </summary>
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student(); // instantiate a new student object

            AddStudentForm addStudentForm = new AddStudentForm(student); // pass the new student object to the student form

            DialogResult studentFormResult = addStudentForm.ShowDialog(); // show the student form

            if (studentFormResult == DialogResult.OK) // if the user exited the contact form with clicking on OK
            {
                studentManager.AddStudent(student); // use function to add contact object to the student listt

                UpdateStudentList(); // update the GUI

                ClearFields(); // clear all output fields

                ActivateButtons(); // and activate the buttons
            }
            else // if user clicked on anything else
            {
                // do nothing
            }
        }

        /// <summary>
        /// change the personal data of a student
        /// </summary>
        private void btnChangeStudentData_Click(object sender, EventArgs e)
        {
            int index = lstBoxStudents.SelectedIndex; // get the index of selected student in the listBox

            if (studentManager.CheckIndex(index)) // if a proper index (in range) of a student was provided
            {
                Student student = studentManager.GetStudent(index); // get the student object at the selected index

                AddStudentForm addStudentForm = new AddStudentForm(student); // pass the student to the student form

                DialogResult studentFormResult = addStudentForm.ShowDialog(); // show the student form

                if (studentFormResult == DialogResult.OK) // if the user exited the contact form with clicking on OK
                {
                    studentManager.ChangeStudent(student, index); // use function to change contact object at given index by replacing the existing student object

                    UpdateStudentList(); // update the listBox of students

                    ClearFields(); // clear all output fields
                }
                else // if user clicked on anything else
                {
                    // do nothing
                }
            }
            else // if no proper index from the student list was provided 
            {
                MessageBox.Show("Please select a student from the list", "Error"); // show an error message
            }
        }

        /// <summary>
        /// manage the assignments of the selected student
        /// </summary>
        private void btnAssignments_Click(object sender, EventArgs e)
        {
            int index = lstBoxStudents.SelectedIndex; // get index of selected student

            if (studentManager.CheckIndex(index)) // if a proper index was provided
            {
                Student student = studentManager.GetStudent(index); // get the student object at the selected index

                AssignmentForm assignmentForm = new AssignmentForm(student, studentManager); // pass the selected student and the studentManager-object to the AssignmentForm

                DialogResult assignmentFormResult = assignmentForm.ShowDialog(); // show the AssignmentForm

                ShowPerformanceInfo(); // after editing the assignments, fill in the information on the students performance in the output fields

                ShowAssignmentInfo(); // and show information on the last assignments in the output fields
            }
            else // if no proper index was provided
            { 
                MessageBox.Show("Please select a student from the list", "Error"); // return an error message
            }
        }

        /// <summary>
        /// remove a student from the student list
        /// </summary>
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int index = lstBoxStudents.SelectedIndex; // get index of selected student

            if (studentManager.CheckIndex(index)) // if a proper index was provided
            {
                studentManager.DeleteStudent(index); // delete student at the provided index

                UpdateStudentList();  // update the listBox of students

                ActivateButtons(); // deactivate the buttons if all students were deleted from the student list

                ClearFields(); // clear all output fields
            }
            else  // if no proper index was provided
            {
                MessageBox.Show("Please select a student from the list", "Error"); // return an error message
            }
        }

        /// <summary>
        /// update the student information in the listBox
        /// </summary>
        private void UpdateStudentList()
        {
            lstBoxStudents.Items.Clear(); // clear listBox before entering new values

            // return information on each student in array and put it into listBox
            string[] studentInfos = studentManager.GetStudentInfoStrings(); // create a string array that contains information on each student

            if (studentInfos != null) // if the array of student information is not empty
            {
                // put each student information string in the string array of student information in the listBox one by one
                foreach (string studentInfosOut in studentInfos)
                {
                    lstBoxStudents.Items.Add(studentInfosOut);
                }
            }
        }

        /// <summary>
        /// create and show a transcript of the selected student in a message box
        /// </summary>
        private void btnTranscript_Click(object sender, EventArgs e)
        {
            int index = lstBoxStudents.SelectedIndex; // get the index of the in the listbox selected student
            string strOut = string.Empty; // initialize an empty string that will store the output of the message box

            if (studentManager.CheckIndex(index)) // if a proper index was provided
            {
                strOut = studentManager.CreateTranscript(index); // and store the transcript string in the local variable

                MessageBox.Show(strOut, "Transcript"); // show a message box with the transcript information
            }
            else  // if no proper index was provided
            {
                MessageBox.Show("Please select a student from the list", "Error"); // show an error message
            }
        }

        /// <summary>
        /// show information on the students performance and assignments in the output fields
        /// </summary>
        private void lstBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFields(); // clear all output fields

            ShowPerformanceInfo(); // fill in the information on the students performance in the output fields

            ShowAssignmentInfo(); // show information on the last assignments in the output fields
        }

        /// <summary>
        /// show information on the student's last assignments in the output fields
        /// </summary>
        private void ShowAssignmentInfo()
        {
            int index = lstBoxStudents.SelectedIndex;  // get the index of the in the listbox selected student

            if (studentManager.CheckIndex(index))  // if the index is valid
            {
                string[] assigmnentInfos = studentManager.GetAssignmentInfoStringMainForm(index); // get a string array with formatted information on the assignments and store it in a local variable 

                if (assigmnentInfos != null) // if the string array is not empty
                {
                    string lblOut = string.Empty; // initialize an empty string variable

                    lblOut = string.Join("\n", assigmnentInfos); // join the assignment information together so that each assignment has its own row

                    lblAssignments.Text = lblOut; // show the assignment information (row-wise) in an output label 
                }
            }
        }

        /// <summary>
        /// fill in information on a student's performance in the labels provided for this purpose
        /// </summary>
        private void ShowPerformanceInfo() 
        {
            int index = lstBoxStudents.SelectedIndex;  // get the index of the in the listbox selected student

            if (studentManager.CheckIndex(index))  // if the index is valid
            {
                double avgGrade = studentManager.GetAverageGrades(index); // get the average grade of the student as double

                if (avgGrade > 0)  // if the average grade is above 0 (it is 0 when no assignments were added yet)
                {
                    string avgGradeStr = avgGrade.ToString();  // turn the average grade to a string

                    lblAvgGrade.Text = avgGradeStr;  // and show it in the label for the average grade

                    lblRating.Text = studentManager.GetStudentRating(avgGrade);  // show also the rating of the student based on his/her grade
                }
            }        
        }

        /// <summary>
        /// clear all output fields at once
        /// </summary>
        private void ClearFields()
        {
            lblRating.Text = string.Empty;
            lblAvgGrade.Text = string.Empty;
            lblAssignments.Text = string.Empty;
        }
    }
}
