namespace SchoolClassManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBoxStudents = new System.Windows.Forms.ListBox();
            this.lblAssignments = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAssignments = new System.Windows.Forms.Button();
            this.btnChangeStudentData = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnTranscript = new System.Windows.Forms.Button();
            this.lblAvgGrade = new System.Windows.Forms.Label();
            this.lblAvgGradesDesc = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblRatingDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAssigmentOverview = new System.Windows.Forms.Label();
            this.lblAssignmentName = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblStudentData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxStudents
            // 
            this.lstBoxStudents.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxStudents.FormattingEnabled = true;
            this.lstBoxStudents.ItemHeight = 27;
            this.lstBoxStudents.Location = new System.Drawing.Point(44, 138);
            this.lstBoxStudents.Name = "lstBoxStudents";
            this.lstBoxStudents.Size = new System.Drawing.Size(755, 436);
            this.lstBoxStudents.TabIndex = 0;
            this.lstBoxStudents.SelectedIndexChanged += new System.EventHandler(this.lstBoxStudents_SelectedIndexChanged);
            // 
            // lblAssignments
            // 
            this.lblAssignments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAssignments.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignments.Location = new System.Drawing.Point(841, 138);
            this.lblAssignments.Name = "lblAssignments";
            this.lblAssignments.Size = new System.Drawing.Size(733, 424);
            this.lblAssignments.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(218, 613);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(393, 44);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignments.Location = new System.Drawing.Point(218, 778);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(393, 45);
            this.btnAssignments.TabIndex = 3;
            this.btnAssignments.Text = "Manage Assignments";
            this.btnAssignments.UseVisualStyleBackColor = true;
            this.btnAssignments.Click += new System.EventHandler(this.btnAssignments_Click);
            // 
            // btnChangeStudentData
            // 
            this.btnChangeStudentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStudentData.Location = new System.Drawing.Point(218, 690);
            this.btnChangeStudentData.Name = "btnChangeStudentData";
            this.btnChangeStudentData.Size = new System.Drawing.Size(393, 45);
            this.btnChangeStudentData.TabIndex = 4;
            this.btnChangeStudentData.Text = "Change Personal Student Data";
            this.btnChangeStudentData.UseVisualStyleBackColor = true;
            this.btnChangeStudentData.Click += new System.EventHandler(this.btnChangeStudentData_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteStudent.Location = new System.Drawing.Point(218, 859);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(393, 45);
            this.btnDeleteStudent.TabIndex = 5;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnTranscript
            // 
            this.btnTranscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranscript.Location = new System.Drawing.Point(1141, 872);
            this.btnTranscript.Name = "btnTranscript";
            this.btnTranscript.Size = new System.Drawing.Size(256, 44);
            this.btnTranscript.TabIndex = 6;
            this.btnTranscript.Text = "Create Transcript";
            this.btnTranscript.UseVisualStyleBackColor = true;
            this.btnTranscript.Click += new System.EventHandler(this.btnTranscript_Click);
            // 
            // lblAvgGrade
            // 
            this.lblAvgGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgGrade.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGrade.Location = new System.Drawing.Point(1393, 605);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Size = new System.Drawing.Size(181, 44);
            this.lblAvgGrade.TabIndex = 7;
            // 
            // lblAvgGradesDesc
            // 
            this.lblAvgGradesDesc.AutoSize = true;
            this.lblAvgGradesDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGradesDesc.Location = new System.Drawing.Point(1136, 613);
            this.lblAvgGradesDesc.Name = "lblAvgGradesDesc";
            this.lblAvgGradesDesc.Size = new System.Drawing.Size(175, 29);
            this.lblAvgGradesDesc.TabIndex = 8;
            this.lblAvgGradesDesc.Text = "Average Grade";
            // 
            // lblRating
            // 
            this.lblRating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRating.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(1239, 690);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(335, 133);
            this.lblRating.TabIndex = 9;
            // 
            // lblRatingDesc
            // 
            this.lblRatingDesc.AutoSize = true;
            this.lblRatingDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingDesc.Location = new System.Drawing.Point(1136, 690);
            this.lblRatingDesc.Name = "lblRatingDesc";
            this.lblRatingDesc.Size = new System.Drawing.Size(82, 29);
            this.lblRatingDesc.TabIndex = 10;
            this.lblRatingDesc.Text = "Rating";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(40, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(359, 99);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(108, 29);
            this.lblBirthday.TabIndex = 12;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(525, 99);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(223, 29);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address (Zip/City)";
            // 
            // lblAssigmentOverview
            // 
            this.lblAssigmentOverview.AutoSize = true;
            this.lblAssigmentOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssigmentOverview.Location = new System.Drawing.Point(836, 27);
            this.lblAssigmentOverview.Name = "lblAssigmentOverview";
            this.lblAssigmentOverview.Size = new System.Drawing.Size(228, 30);
            this.lblAssigmentOverview.TabIndex = 15;
            this.lblAssigmentOverview.Text = "Last assignments";
            // 
            // lblAssignmentName
            // 
            this.lblAssignmentName.AutoSize = true;
            this.lblAssignmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentName.Location = new System.Drawing.Point(836, 99);
            this.lblAssignmentName.Name = "lblAssignmentName";
            this.lblAssignmentName.Size = new System.Drawing.Size(82, 29);
            this.lblAssignmentName.TabIndex = 16;
            this.lblAssignmentName.Text = "Name";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(1084, 99);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(101, 29);
            this.lblSubject.TabIndex = 17;
            this.lblSubject.Text = "Subject";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(1240, 99);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(85, 29);
            this.lblGrade.TabIndex = 18;
            this.lblGrade.Text = "Grade";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(1327, 99);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(82, 29);
            this.lblNotes.TabIndex = 19;
            this.lblNotes.Text = "Notes";
            // 
            // lblStudentData
            // 
            this.lblStudentData.AutoSize = true;
            this.lblStudentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentData.Location = new System.Drawing.Point(39, 27);
            this.lblStudentData.Name = "lblStudentData";
            this.lblStudentData.Size = new System.Drawing.Size(310, 30);
            this.lblStudentData.TabIndex = 20;
            this.lblStudentData.Text = "Students\' Personal Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 949);
            this.Controls.Add(this.lblStudentData);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblAssignmentName);
            this.Controls.Add(this.lblAssigmentOverview);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRatingDesc);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblAvgGradesDesc);
            this.Controls.Add(this.lblAvgGrade);
            this.Controls.Add(this.btnTranscript);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnChangeStudentData);
            this.Controls.Add(this.btnAssignments);
            this.Controls.Add(this.lstBoxStudents);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblAssignments);
            this.Name = "MainForm";
            this.Text = "School class manager by Simon Herrmann";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstBoxStudents;
        private System.Windows.Forms.Label lblAssignments;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button btnChangeStudentData;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnTranscript;
        private System.Windows.Forms.Label lblAvgGrade;
        private System.Windows.Forms.Label lblAvgGradesDesc;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblRatingDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAssigmentOverview;
        private System.Windows.Forms.Label lblAssignmentName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblStudentData;
    }
}

