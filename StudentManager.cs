using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchoolClassManager
{
    public class StudentManager
    {
        /// <summary>
        /// fields
        /// </summary>
        private List<Student> students; // list of students

        /// <summary>
        /// constructor of class
        /// </summary>
        public StudentManager()
        {
            students = new List<Student>(); // instantiate a new collection of student objects
        }

        /// <summary>
        /// add a student to the student list
        /// </summary>
        /// <param name="student">a student object</param>
        public void AddStudent(Student student)
        {
            students.Add(student); // add the student object to the student list 
        }

        /// <summary>
        /// change a student object at a given index
        /// </summary>
        /// <param name="student">a student object</param>
        /// <param name="index">the index at which the student should be changed</param>
        public void ChangeStudent(Student student, int index)
        {
            students[index] = student;  // replace the student at the given index by the provided student
        }

        /// <summary>
        /// delete a student at a given index
        /// </summary>
        /// <param name="index"></param>
        public void DeleteStudent(int index) 
        {
            students.RemoveAt(index); // remove the object (student) at the provided index
        
        }

        /// <summary>
        /// determine whether there are any students in the student list
        /// </summary>
        /// <returns>a boolean value indicating whether there are students in the student collection</returns>
        public bool ExistStudents() 
        { 
            return students.Count > 0; // return whether the length of the student list is above 0
        }

        /// <summary>
        /// return the student object at the provided index
        /// </summary>
        /// <param name="index">the index from which the student should be retrieved from</param>
        /// <returns>a student object</returns>
        public Student GetStudent(int index)
        {
            Student student = students[index]; // assign a the student at the given index to a local student object

            return student; // return the local student object
        }

        /// <summary>
        /// create a string array containing information on all students in the student list
        /// </summary>
        /// <returns>a string array with student information</returns>
        public string[] GetStudentInfoStrings()
        {
            // initialize local variables
            int size = students.Count;
            string firstName = string.Empty;
            string lastName = string.Empty;
            string name = string.Empty;
            string birthday = string.Empty;
            string city = string.Empty;
            string zip = string.Empty;
            string addressInfo = string.Empty;  

            if (size <= 0) // if there are no students currently stored, don't return anything
                return null;

            string[] studentInfoString = new string[size]; // initialize an empty string array based on the number of students

            for (int i = 0, j = 0; i < size; i++) // iterate over i and j to get all elements from the student list and store them in the new empty array containing student information
            {
                if (students[i] != null)
                {
                    // get all the interesting information for each student in the student collection
                    lastName = students[i].Lastname;
                    firstName = students[i].Firstname;
                    name = lastName.ToUpper() + ", " + firstName;  // generate output format for the name
                    birthday = students[i].Birthday.ToShortDateString();
                    city = students[i].Address.City;
                    zip = students[i].Address.Zip; 
                    addressInfo = zip + " " + city;

                    // store the information on a student in the newly created student array
                    studentInfoString[j++] = $"{name,-20} {birthday,-10} {addressInfo,-15}"; // each array field contains a string with the name, the birthday, and parts of the address
                }
            }
            return studentInfoString; // return a string array of the student information
        }

        /// <summary>
        /// create a formatted string array that contains information on each assignment - for the assignment form
        /// </summary>
        /// <param name="student">the student for which the assignment information should be created</param>
        /// <returns>string array with assignment information (name, date, subject)</returns>
        public string[] GetAssignmentInfoStringAssignmentForm(Student student)
        {
            // initialize local variables
            List<Assignment> assignments = student.Assignments;
            int size = assignments.Count;
            string name = string.Empty;
            Subjects subject = 0;
            string subjectStr = string.Empty;
            string date = string.Empty;


            if (size <= 0) // if there are no assignments currently stored, don't return anything
                return null;

            string[] assignmentInfoString = new string[size]; // initialize an empty string array with size based on the number of assignments

            for (int i = 0, j = 0; i < size; i++) // iterate over i and j to get all elements from the assignments collection and storing them in the new empty array containing assignment information
            {
                if (assignments[i] != null)
                {
                    // get all the interesting information for each assignment in the assignment list
                    name = assignments[i].Name;
                    date = assignments[i].Date.ToShortDateString();
                    subject = assignments[i].Subject;
                    subjectStr = subject.ToString();

                    // store the information on an assignment in the newly created assignment info array
                    assignmentInfoString[j++] = $"{name,-17} {date,-9} {subjectStr,-11}"; // each array field contains a string with the name, the date, and the subject
                }
            }
            return assignmentInfoString;
        }

        /// <summary>
        /// create a formatted string array that contains information on the last assignments - for the main form
        /// </summary>
        /// <param name="index">the index of the student for which we need the assignment information</param>
        /// <returns>a string array with information on each assignment (name, subject, grade, note)</returns>
        public string[] GetAssignmentInfoStringMainForm(int index) 
        {
            // local variables
            Student student = students[index]; // get the student at the given index
            string assignmentName = string.Empty; // initialize empty string variables
            string assignmentSubject = string.Empty;
            string assignmentGrade = string.Empty;
            string assignmentNote = string.Empty;
            int size = student.Assignments.Count;

            // make sure that only information on the last 6 assignments are shown 
            if (size > 6) 
                size = 6;

            // fill in the string array with the assignment information
            if (student.Assignments.Count != 0) // of the list of assignments for the student is not zero
            {
                string[] assignmentInfoString = new string[size]; // initialize an empty string array

                // fill in the string array with the information for each assignment
                for (int i = 0, j = 0; i < size; i++) 
                {
                    if (student.Assignments[i] != null)
                    {
                        assignmentName = student.Assignments[i].Name;
                        assignmentSubject = student.Assignments[i].Subject.ToString();
                        assignmentGrade = student.Assignments[i].Grade.ToString();
                        assignmentNote = student.Assignments[i].Notes;
                    }
                    assignmentInfoString[j++] = $"{assignmentName, -17} {assignmentSubject, -11} {assignmentGrade, -5} {assignmentNote, -17}";
                }

                return assignmentInfoString; // return the string array with the assignment information
            }
            else // if the list of assignments for the student is zero - when the assignment form is opened for the first time for example
            {
                return null; // return null
            }

        }

        /// <summary>
        /// create a string that shows average grades for each subject where grades exist - this is shown in the transcript
        /// </summary>
        /// <param name="index">the index of the selected student</param>
        /// <returns>a formatted string with average grades</returns>
        private string GetSubjectSummaries(int index) 
        {
            // local variables
            Student student = students[index]; // get the student at the provided index

            string subjectSummary = string.Empty;
            int size = student.Assignments.Count; // store the number of assignments

            List<double> gradesArt = new List<double>(); // create a list for each subject that contains the grades for that subject
            List<double> gradesMusic = new List<double>();
            List<double> gradesBiology = new List<double>();
            List<double> gradesMath = new List<double>();
            List<double> gradesEnglish = new List<double>();
            List<double> gradesPhysics = new List<double>();
            List<double> gradesChemistry = new List<double>();
            List<double> gradesHistory = new List<double>();

            List<string> subjectSummaryList = new List<string>(); // create a list in which all information on each subject will be stored in as string
            List<List<double>> gradesList = new List<List<double>>(); // create a nested list that will store all grades lists in another list
            List<string> subjectNames = new List<string>(); // create a list for the subject names

            // for each assignment in the assignment list, check to which subject the assignment belongs to and store the grades and the subject's name in lists
            for (int i = 0; i < size; i++)
            {
                if (student.Assignments[i].Subject == Subjects.Art) // e.g., if the subject of assignment at index i is arts
                {
                    gradesArt.Add(student.Assignments[i].Grade); // add the grades to the grades list for arts
                    subjectNames.Add("Art"); // and add art to the subject names
                }
                else if (student.Assignments[i].Subject == Subjects.Music)
                {
                    gradesMusic.Add(student.Assignments[i].Grade);
                    subjectNames.Add("Music");
                }
                else if (student.Assignments[i].Subject == Subjects.Biology)
                {
                    gradesBiology.Add(student.Assignments[i].Grade);
                    subjectNames.Add("Biology");
                }
                else if (student.Assignments[i].Subject == Subjects.Math)
                {
                    gradesMath.Add(student.Assignments[i].Grade);
                    subjectNames.Add("Math");
                }
                else if (student.Assignments[i].Subject == Subjects.English)
                {
                    gradesEnglish.Add(student.Assignments[i].Grade);
                    subjectNames.Add("English");
                }
                else if (student.Assignments[i].Subject == Subjects.Physics)
                {
                    gradesPhysics.Add(student.Assignments[i].Grade);
                    subjectNames.Add("Physics");
                }
                else if (student.Assignments[i].Subject == Subjects.Chemistry)
                {
                    gradesChemistry.Add(student.Assignments[i].Grade);
                    subjectNames.Add("Chemistry");
                }
                else if (student.Assignments[i].Subject == Subjects.History)
                {
                    gradesHistory.Add(student.Assignments[i].Grade);
                    subjectNames.Add("History");
                }
            }

            // remove multiple entries of subjects from the subjectNames-list - this is used for the string output
            subjectNames = subjectNames.Distinct().ToList(); 

            // add all the lists containing grades for each subject to another list
            gradesList.AddRange(new List<List<double>>
            {
                gradesArt, gradesMusic, gradesBiology, gradesMath, gradesEnglish, gradesPhysics, gradesChemistry, gradesHistory
            });

            // initialize a variable that counts the subject already handled in the next foreach-loop
            int subjectCount = 0;

            // for each subject where grades exist calculate the mean value of grades, append it with the subject name, and add it to the summary-list
            foreach (List<double> grades in gradesList)
            {
                if (grades.Count > 0) // if there were grades stored in the grades list
                {
                    double gradesSum = grades.Sum(); // store the sum of the grades
                    double gradesAvg = Math.Round(gradesSum / grades.Count, 2); // store the rounded mean of the grades 
                    string subject = subjectNames[subjectCount]; // get the name of the subject for which the average grade was calculated

                    subjectSummaryList.Add($"{subject}: {gradesAvg}"); // add average grade and subject to a summary-list

                    subjectCount = subjectCount + 1; // increase the variable that counts the subject by one
                }
            }

            subjectSummary = string.Join("\n\n", subjectSummaryList); // show each entry on subject in a new line and store it in a local variable subjectSummary

            return subjectSummary; // return the formatted string subjectSummary
        }

        /// <summary>
        /// create a string containing the information used in the transcript - this is used by the main form
        /// </summary>
        /// <param name="index">index of the student for which the transcript is created</param>
        /// <returns>a string containing the information used in the transcript</returns>
        public string CreateTranscript(int index)
        {
            // local variables
            Student student = students[index]; // get the student at the provided index
            string firstName = string.Empty; // initialize empty string variables
            string lastName = string.Empty;
            DateTime today = DateTime.Today;
            string ageStr = string.Empty;
            string street = string.Empty;
            string zip = string.Empty;
            string city = string.Empty;
            string subjectSummary = string.Empty;
            string overallGrades = string.Empty;
            string strOut = string.Empty;

            // assign the values used in the output based on the student's variables
            firstName = student.Firstname;
            lastName = student.Lastname;
            DateTime birthdate = student.Birthday;
            int age = today.Year - birthdate.Year; // calculate the age based on the year
            if ((today.Month < birthdate.Month) | ((today.Month == birthdate.Month) && (today.Day < birthdate.Day))) // but: if the current month is lower than the month of birthday OR the current month is equal to the month of birthday and the current day is lower than the day of the birthday
                age = age - 1; // decrease the age by one (that person didn't have birthday yet in the current year)
            ageStr = age.ToString();
            street = student.Address.Street;
            zip = student.Address.Zip;
            city = student.Address.City;

            // get the average grades for the subjects as well as the overall average grade
            subjectSummary = GetSubjectSummaries(index);
            overallGrades = GetAverageGrades(index).ToString();

            // store all the information for the transcript in one formatted string
            strOut = $"-----PERSONAL INFORMATION----- \n\nName: {firstName} {lastName}         Age: {age}\nAddress: {street}, {zip} {city} \n\n-----ACADEMIC RECORDS-----\n\n{subjectSummary}\n\nOverall score: {overallGrades}";

            // return the formatted string
            return strOut; 
        }


        /// <summary>
        /// check whether the index is properly provided and does not have a problematic value
        /// </summary>
        /// <param name="index">the index of a selected item</param>
        /// <returns>a boolean value whether the selected index is above -1 and smaller than the number of elements in the list (so not out of bound)</returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;

            if (index >= 0 && index < students.Count) // if index is above -1 and lower than the length of the student collection
                ok = true;  // return true indicating that the index is properly chosen

            return ok;
        }

        /// <summary>
        /// calculate the mean over all grades of the student
        /// </summary>
        /// <param name="index">index of student for which we want the average grade</param>
        /// <returns>a double indicating the average grades of the student</returns>

        public double GetAverageGrades(int index)
        {
            // local variables
            double average = 0;
            double sum = 0;

            // get the student at the in the constructor provided index
            Student student = students[index];

            // get the size of the array in which grades will be stored
            int size = student.Assignments.Count();

            // initialize grade array
            double[] grades = new double[size];

            // fill grade array with grades from all stored assignments from student
            for (int i = 0; i < size; i++)
            {
                grades[i] = student.Assignments[i].Grade;
            }

            // calculate and round the average
            for (int i = 0; i < size; i++) // size is equal to the number of grades 
            {
                sum += grades[i];
            }

            average = Math.Round(sum / size, 2);

            // return the average grade value
            return average;
        }

        /// <summary>
        /// get a string description/a rating of the performance based on the grade
        /// </summary>
        /// <param name="grade">a double value for the grade</param>
        /// <returns>a string rating based on the grade</returns>
        public string GetStudentRating(double grade) 
        {
            string desc = string.Empty;  // initialize an empty string variable

            if (grade >= 1 && grade <= 1.75)   // now based on each grade interval
            {
                desc = "Great performance. No additional support required"; // set a new string rating 
            }
            else if (grade > 1.75 && grade <= 2.5)
            {
                desc = "Good performance. No additional support required";
            }
            else if (grade > 2.5 && grade <= 3.25)
            {
                desc = "Medium performance. Support required in the worst subjects";
            }
            else if (grade > 2.5 && grade <= 3.25)
            {
                desc = "Medium performance. Support required in the worst subjects";
            }
            else if (grade > 3.25 && grade <= 4)
            {
                desc = "Medium to unsatisfactory performance. Support required";
            }
            else if (grade > 4 && grade <= 4.75)
            {
                desc = "Unsatisfactory performance. Urgeht support required";
            }
            else
            {
                desc = "Alarming performance. Various immediate support measures required";
            }

            return desc; // return the string description/rating of the grade
        }
    }
}
