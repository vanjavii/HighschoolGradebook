using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCAddTeacherWithValidation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label academicLevelLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label subjectNameLabel;
            this.academicLevelTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.subjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.btnSaveTeacher = new System.Windows.Forms.Button();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            academicLevelLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            subjectNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // academicLevelLabel
            // 
            academicLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            academicLevelLabel.AutoSize = true;
            academicLevelLabel.Location = new System.Drawing.Point(52, 249);
            academicLevelLabel.Name = "academicLevelLabel";
            academicLevelLabel.Size = new System.Drawing.Size(86, 13);
            academicLevelLabel.TabIndex = 1;
            academicLevelLabel.Text = "Academic Level:";
            //academicLevelLabel.Click += new System.EventHandler(this.academicLevelLabel_Click);
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(52, 149);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            //addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // birthDateLabel
            // 
            birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(52, 95);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 5;
            birthDateLabel.Text = "Birth Date:";
            //birthDateLabel.Click += new System.EventHandler(this.birthDateLabel_Click);
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(52, 43);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            //firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(333, 43);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name:";
            //lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(52, 197);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 13;
            phoneNumberLabel.Text = "Phone Number:";
            //phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // subjectNameLabel
            // 
            subjectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            subjectNameLabel.AutoSize = true;
            subjectNameLabel.Location = new System.Drawing.Point(52, 301);
            subjectNameLabel.Name = "subjectNameLabel";
            subjectNameLabel.Size = new System.Drawing.Size(77, 13);
            subjectNameLabel.TabIndex = 15;
            subjectNameLabel.Text = "Subject Name:";
            //subjectNameLabel.Click += new System.EventHandler(this.subjectNameLabel_Click);
            // 
            // academicLevelTextBox
            // 
            this.academicLevelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.academicLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "AcademicLevel", true));
            this.academicLevelTextBox.Location = new System.Drawing.Point(150, 246);
            this.academicLevelTextBox.Name = "academicLevelTextBox";
            this.academicLevelTextBox.Size = new System.Drawing.Size(154, 20);
            this.academicLevelTextBox.TabIndex = 2;
            //this.academicLevelTextBox.TextChanged += new System.EventHandler(this.academicLevelTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(148, 146);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(156, 20);
            this.addressTextBox.TabIndex = 4;
            //this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teacherBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(148, 95);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.birthDateDateTimePicker.TabIndex = 6;
            //this.birthDateDateTimePicker.ValueChanged += new System.EventHandler(this.birthDateDateTimePicker_ValueChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(149, 40);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.firstNameTextBox.TabIndex = 8;
            //this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(428, 40);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.lastNameTextBox.TabIndex = 12;
            //this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(148, 194);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(156, 20);
            this.phoneNumberTextBox.TabIndex = 14;
            //this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // subjectNameComboBox
            // 
            this.subjectNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subjectNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Subject.SubjectName", true));
            this.subjectNameComboBox.FormattingEnabled = true;
            this.subjectNameComboBox.Location = new System.Drawing.Point(149, 298);
            this.subjectNameComboBox.Name = "subjectNameComboBox";
            this.subjectNameComboBox.Size = new System.Drawing.Size(155, 21);
            this.subjectNameComboBox.TabIndex = 16;
            //this.subjectNameComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectNameComboBox_SelectedIndexChanged);
            // 
            // btnSaveTeacher
            // 
            this.btnSaveTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveTeacher.Location = new System.Drawing.Point(398, 296);
            this.btnSaveTeacher.Name = "btnSaveTeacher";
            this.btnSaveTeacher.Size = new System.Drawing.Size(135, 23);
            this.btnSaveTeacher.TabIndex = 17;
            this.btnSaveTeacher.Text = "Save Teacher";
            this.btnSaveTeacher.UseVisualStyleBackColor = true;
            this.btnSaveTeacher.Click += new System.EventHandler(this.btnSaveTeacher_Click);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Domain.Teacher);
            // 
            // UCAddTeacherWithValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnSaveTeacher);
            this.Controls.Add(subjectNameLabel);
            this.Controls.Add(this.subjectNameComboBox);
            this.Controls.Add(academicLevelLabel);
            this.Controls.Add(this.academicLevelTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Name = "UCAddTeacherWithValidation";
            this.Size = new System.Drawing.Size(631, 366);
            //this.Load += new System.EventHandler(this.UCAddTeacherWithValidation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.TextBox academicLevelTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.ComboBox subjectNameComboBox;
        private System.Windows.Forms.Button btnSaveTeacher;

        public BindingSource TeacherBindingSource { get => teacherBindingSource; set => teacherBindingSource = value; }
        public TextBox AcademicLevelTextBox { get => academicLevelTextBox; set => academicLevelTextBox = value; }
        public TextBox AddressTextBox { get => addressTextBox; set => addressTextBox = value; }
        public DateTimePicker BirthDateDateTimePicker { get => birthDateDateTimePicker; set => birthDateDateTimePicker = value; }
        public TextBox FirstNameTextBox { get => firstNameTextBox; set => firstNameTextBox = value; }
        public TextBox LastNameTextBox { get => lastNameTextBox; set => lastNameTextBox = value; }
        public TextBox PhoneNumberTextBox { get => phoneNumberTextBox; set => phoneNumberTextBox = value; }
        public ComboBox SubjectNameComboBox { get => subjectNameComboBox; set => subjectNameComboBox = value; }
        public Button BtnSaveTeacher { get => btnSaveTeacher; set => btnSaveTeacher = value; }
    }
}
