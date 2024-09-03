namespace SchoolClassManager
{
    partial class AddStudentForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpBirthday = new System.Windows.Forms.GroupBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.grpName.SuspendLayout();
            this.grpBirthday.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(96, 765);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(162, 46);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(369, 765);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 46);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(171, 59);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(341, 35);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(171, 137);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(341, 35);
            this.txtLastName.TabIndex = 3;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(171, 60);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(341, 35);
            this.txtStreet.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(171, 221);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(341, 35);
            this.txtCity.TabIndex = 5;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(171, 140);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(341, 35);
            this.txtZip.TabIndex = 6;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(147, 62);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(265, 35);
            this.dateTimePickerBirthday.TabIndex = 7;
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.lblLastName);
            this.grpName.Controls.Add(this.lblFirstName);
            this.grpName.Controls.Add(this.txtLastName);
            this.grpName.Controls.Add(this.txtFirstName);
            this.grpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpName.Location = new System.Drawing.Point(48, 24);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(545, 211);
            this.grpName.TabIndex = 8;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(24, 140);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(123, 29);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(126, 29);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First name";
            // 
            // grpBirthday
            // 
            this.grpBirthday.Controls.Add(this.dateTimePickerBirthday);
            this.grpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBirthday.Location = new System.Drawing.Point(48, 256);
            this.grpBirthday.Name = "grpBirthday";
            this.grpBirthday.Size = new System.Drawing.Size(545, 134);
            this.grpBirthday.TabIndex = 9;
            this.grpBirthday.TabStop = false;
            this.grpBirthday.Text = "Birthday";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.lblZip);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Controls.Add(this.txtZip);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddress.Location = new System.Drawing.Point(48, 412);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(545, 305);
            this.grpAddress.TabIndex = 10;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(94, 227);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(53, 29);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(43, 143);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(107, 29);
            this.lblZip.TabIndex = 11;
            this.lblZip.Text = "Zip code";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(73, 63);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(77, 29);
            this.lblStreet.TabIndex = 7;
            this.lblStreet.Text = "Street";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 852);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpBirthday);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "AddStudentForm";
            this.Text = "Manage Personal Student Data";
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpBirthday.ResumeLayout(false);
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpBirthday;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblStreet;
    }
}