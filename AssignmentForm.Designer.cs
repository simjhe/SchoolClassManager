namespace SchoolClassManager
{
    partial class AssignmentForm
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
            this.lstBoxAssignments = new System.Windows.Forms.ListBox();
            this.dateTimePickerAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.cmbBoxSubject = new System.Windows.Forms.ComboBox();
            this.btnAddAssignment = new System.Windows.Forms.Button();
            this.btnChangeAssignment = new System.Windows.Forms.Button();
            this.btnDeleteAssignment = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblAssignmentName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblBoxName = new System.Windows.Forms.Label();
            this.lblBoxDate = new System.Windows.Forms.Label();
            this.lblBoxSubject = new System.Windows.Forms.Label();
            this.lblClosing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxAssignments
            // 
            this.lstBoxAssignments.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxAssignments.FormattingEnabled = true;
            this.lstBoxAssignments.ItemHeight = 27;
            this.lstBoxAssignments.Location = new System.Drawing.Point(440, 72);
            this.lstBoxAssignments.Name = "lstBoxAssignments";
            this.lstBoxAssignments.Size = new System.Drawing.Size(566, 571);
            this.lstBoxAssignments.TabIndex = 0;
            this.lstBoxAssignments.SelectedIndexChanged += new System.EventHandler(this.lstBoxAssignments_SelectedIndexChanged);
            // 
            // dateTimePickerAssignmentDate
            // 
            this.dateTimePickerAssignmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAssignmentDate.Location = new System.Drawing.Point(55, 172);
            this.dateTimePickerAssignmentDate.Name = "dateTimePickerAssignmentDate";
            this.dateTimePickerAssignmentDate.Size = new System.Drawing.Size(338, 35);
            this.dateTimePickerAssignmentDate.TabIndex = 1;
            // 
            // txtAssignmentName
            // 
            this.txtAssignmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentName.Location = new System.Drawing.Point(55, 72);
            this.txtAssignmentName.Name = "txtAssignmentName";
            this.txtAssignmentName.Size = new System.Drawing.Size(338, 35);
            this.txtAssignmentName.TabIndex = 2;
            // 
            // cmbBoxSubject
            // 
            this.cmbBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSubject.FormattingEnabled = true;
            this.cmbBoxSubject.Location = new System.Drawing.Point(55, 273);
            this.cmbBoxSubject.Name = "cmbBoxSubject";
            this.cmbBoxSubject.Size = new System.Drawing.Size(338, 37);
            this.cmbBoxSubject.TabIndex = 3;
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssignment.Location = new System.Drawing.Point(220, 688);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(140, 49);
            this.btnAddAssignment.TabIndex = 4;
            this.btnAddAssignment.Text = "Add";
            this.btnAddAssignment.UseVisualStyleBackColor = true;
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // btnChangeAssignment
            // 
            this.btnChangeAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAssignment.Location = new System.Drawing.Point(458, 688);
            this.btnChangeAssignment.Name = "btnChangeAssignment";
            this.btnChangeAssignment.Size = new System.Drawing.Size(140, 50);
            this.btnChangeAssignment.TabIndex = 5;
            this.btnChangeAssignment.Text = "Change";
            this.btnChangeAssignment.UseVisualStyleBackColor = true;
            this.btnChangeAssignment.Click += new System.EventHandler(this.btnChangeAssignment_Click);
            // 
            // btnDeleteAssignment
            // 
            this.btnDeleteAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAssignment.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteAssignment.Location = new System.Drawing.Point(698, 688);
            this.btnDeleteAssignment.Name = "btnDeleteAssignment";
            this.btnDeleteAssignment.Size = new System.Drawing.Size(140, 51);
            this.btnDeleteAssignment.TabIndex = 6;
            this.btnDeleteAssignment.Text = "Delete";
            this.btnDeleteAssignment.UseVisualStyleBackColor = true;
            this.btnDeleteAssignment.Click += new System.EventHandler(this.btnDeleteAssignment_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(55, 376);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(338, 35);
            this.txtGrade.TabIndex = 7;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(55, 491);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(338, 145);
            this.txtNotes.TabIndex = 8;
            // 
            // lblAssignmentName
            // 
            this.lblAssignmentName.AutoSize = true;
            this.lblAssignmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentName.Location = new System.Drawing.Point(50, 40);
            this.lblAssignmentName.Name = "lblAssignmentName";
            this.lblAssignmentName.Size = new System.Drawing.Size(82, 29);
            this.lblAssignmentName.TabIndex = 9;
            this.lblAssignmentName.Text = "Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(50, 140);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 29);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(50, 241);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(101, 29);
            this.lblSubject.TabIndex = 11;
            this.lblSubject.Text = "Subject";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(50, 344);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(85, 29);
            this.lblGrade.TabIndex = 12;
            this.lblGrade.Text = "Grade";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(50, 459);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(82, 29);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notes";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(440, 872);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(170, 66);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblBoxName
            // 
            this.lblBoxName.AutoSize = true;
            this.lblBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxName.Location = new System.Drawing.Point(435, 40);
            this.lblBoxName.Name = "lblBoxName";
            this.lblBoxName.Size = new System.Drawing.Size(75, 26);
            this.lblBoxName.TabIndex = 15;
            this.lblBoxName.Text = "Name";
            // 
            // lblBoxDate
            // 
            this.lblBoxDate.AutoSize = true;
            this.lblBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxDate.Location = new System.Drawing.Point(713, 40);
            this.lblBoxDate.Name = "lblBoxDate";
            this.lblBoxDate.Size = new System.Drawing.Size(62, 26);
            this.lblBoxDate.TabIndex = 16;
            this.lblBoxDate.Text = "Date";
            // 
            // lblBoxSubject
            // 
            this.lblBoxSubject.AutoSize = true;
            this.lblBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxSubject.Location = new System.Drawing.Point(860, 40);
            this.lblBoxSubject.Name = "lblBoxSubject";
            this.lblBoxSubject.Size = new System.Drawing.Size(92, 26);
            this.lblBoxSubject.TabIndex = 17;
            this.lblBoxSubject.Text = "Subject";
            // 
            // lblClosing
            // 
            this.lblClosing.AutoSize = true;
            this.lblClosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosing.ForeColor = System.Drawing.Color.Blue;
            this.lblClosing.Location = new System.Drawing.Point(350, 830);
            this.lblClosing.Name = "lblClosing";
            this.lblClosing.Size = new System.Drawing.Size(371, 26);
            this.lblClosing.TabIndex = 18;
            this.lblClosing.Text = "Click OK or close the window to save";
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 962);
            this.Controls.Add(this.lblClosing);
            this.Controls.Add(this.lblBoxSubject);
            this.Controls.Add(this.lblBoxDate);
            this.Controls.Add(this.lblBoxName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAssignmentName);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnDeleteAssignment);
            this.Controls.Add(this.btnChangeAssignment);
            this.Controls.Add(this.btnAddAssignment);
            this.Controls.Add(this.cmbBoxSubject);
            this.Controls.Add(this.txtAssignmentName);
            this.Controls.Add(this.dateTimePickerAssignmentDate);
            this.Controls.Add(this.lstBoxAssignments);
            this.Name = "AssignmentForm";
            this.Text = "Manage Student\'s Assignments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxAssignments;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssignmentDate;
        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.ComboBox cmbBoxSubject;
        private System.Windows.Forms.Button btnAddAssignment;
        private System.Windows.Forms.Button btnChangeAssignment;
        private System.Windows.Forms.Button btnDeleteAssignment;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblAssignmentName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblBoxName;
        private System.Windows.Forms.Label lblBoxDate;
        private System.Windows.Forms.Label lblBoxSubject;
        private System.Windows.Forms.Label lblClosing;
    }
}