using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolClassManager
{
    public partial class AddStudentForm : Form
    {
        /// <summary>
        /// fields
        /// </summary>
        private Student student;

        /// <summary>
        /// default constructor
        /// </summary>
        public AddStudentForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// initialize the look and properties of the contact form
        /// </summary>
        private void InitializeGUI()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // fixed borders (no resizing possible)
            this.MaximizeBox = false; // no maximizing
            CenterToScreen(); // set form to center of screen

            // set format of the date time picker
            dateTimePickerBirthday.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthday.CustomFormat = "yyyy-MM-dd";
        }

        /// <summary>
        /// constructor that receives the current student object
        /// </summary>
        /// <param name="student"></param>
        public AddStudentForm(Student student) : this() 
        {
            this.student = student; // set student of form based on inputted student object

            if (student.Firstname != null) // if there were already values stored in the provided student-object
            {
                ShowStudentInfo(); // fill in information on student in input fields with this method
            }
        }

        /// <summary>
        /// fill in input fields with information on student - this is used when the user wants to edit personal student data
        /// </summary>
        private void ShowStudentInfo() 
        { 
            txtFirstName.Text = student.Firstname; // fill the values from the current student in the input fields for editing
            txtLastName.Text = student.Lastname;
            dateTimePickerBirthday.Value = student.Birthday;    
            txtStreet.Text = student.Address.Street;
            txtZip.Text = student.Address.Zip;
            txtCity.Text = student.Address.City;
        }

        /// <summary>
        /// functionalities after user clicked on okay-button - store values from input fields in student object and tell main form that user closed student form with OK
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            ReadInput(); // read the data from the input fields

            if (CheckData()) // if necessary data was added 
            {
                DialogResult = DialogResult.OK; // set property of DialogResult to OK
            }
            else // if the mandatory data was not provided
            {
                MessageBox.Show("Information on name, birthday, and address are required to proceed", "Error"); // return an error message
            }
        }

        /// <summary>
        /// read in values for student from the input fields
        /// </summary>
        private void ReadInput() 
        {
            // first, read the input for the name and birthday
            student.Firstname = txtFirstName.Text.Trim(); 
            student.Lastname = txtLastName.Text.Trim();
            student.Birthday = dateTimePickerBirthday.Value;
             
            ReadAddress(); // call additional method to read in values for address
        }

        /// <summary>
        /// read address from the input fields
        /// </summary>
        private void ReadAddress()
        {
             Address address = new Address(txtCity.Text.Trim(), txtStreet.Text.Trim(), txtZip.Text.Trim()); // instantiate an address object and read in values and put them in constructor
             student.Address = address; // assign address (from created address object) to current student object
        }

        /// <summary>
        /// check whether all required input values were provided 
        /// </summary>
        /// <returns>a boolean value indicating whether all required input values were provided</returns>
        private bool CheckData()
        {
            bool ok = false;
            DateTime checkDt = new DateTime(2020, 1, 1); // instantiate new DateTime object that is used to check whether students were born before 2020 - this will be used to check whether birthday is valid
           
            if (!string.IsNullOrEmpty(student.Firstname) && !string.IsNullOrEmpty(student.Lastname) && student.Birthday < checkDt && !string.IsNullOrEmpty(student.Address.City) && !string.IsNullOrEmpty(student.Address.Street) && !string.IsNullOrEmpty(student.Address.Zip)) // check whether values were provided for all important student properties (note that students' birthdays need to be before 2020 to be considered as valid)
                ok = true;
            
            return ok;
        }

        /// <summary>
        /// functionalities after user clicked on cancel-button - ask user for confirmation and tell main form that user canceled
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // local variables
            bool closeForm = false;

            // show a message box that asks for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) // if the user decides to close the form
            {
                this.Close(); // close the form
                closeForm = true;  // set closeForm to true
            }
            else if (result == DialogResult.No) // if the user decides to not close the form
            {
                // do nothing
            }

            // if the user decides and confirms to close the contact form the property of DialogResult should be set to Cancel
            if (closeForm)
                DialogResult = DialogResult.Cancel;
        }
    }
}
