using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmAddTeacherOnSubject
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
            this.btnSaveTeacher = new System.Windows.Forms.Button();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAcademicLevel = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveTeacher
            // 
            this.btnSaveTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveTeacher.Location = new System.Drawing.Point(248, 331);
            this.btnSaveTeacher.Name = "btnSaveTeacher";
            this.btnSaveTeacher.Size = new System.Drawing.Size(152, 23);
            this.btnSaveTeacher.TabIndex = 29;
            this.btnSaveTeacher.Text = "Save Teacher";
            this.btnSaveTeacher.UseVisualStyleBackColor = true;
            this.btnSaveTeacher.Click += new System.EventHandler(this.btnSaveTeacher_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(206, 122);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dtpDateOfBirth.TabIndex = 28;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(448, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(206, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 26;
            // 
            // txtAcademicLevel
            // 
            this.txtAcademicLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcademicLevel.Location = new System.Drawing.Point(206, 268);
            this.txtAcademicLevel.Name = "txtAcademicLevel";
            this.txtAcademicLevel.Size = new System.Drawing.Size(100, 20);
            this.txtAcademicLevel.TabIndex = 25;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNumber.Location = new System.Drawing.Point(206, 224);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 24;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(206, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(90, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Birth Date:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(90, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Academic Level:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(90, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(366, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name;";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(90, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(90, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name:";
            // 
            // FrmAddTeacherOnSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.pastel_blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 414);
            this.Controls.Add(this.btnSaveTeacher);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAcademicLevel);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddTeacherOnSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Teacher on Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveTeacher;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAcademicLevel;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public Button BtnSaveTeacher { get => btnSaveTeacher; set => btnSaveTeacher = value; }
        public DateTimePicker DtpDateOfBirth { get => dtpDateOfBirth; set => dtpDateOfBirth = value; }
        public TextBox TxtLastName { get => txtLastName; set => txtLastName = value; }
        public TextBox TxtAddress { get => txtAddress; set => txtAddress = value; }
        public TextBox TxtAcademicLevel { get => txtAcademicLevel; set => txtAcademicLevel = value; }
        public TextBox TxtPhoneNumber { get => txtPhoneNumber; set => txtPhoneNumber = value; }
        public TextBox TxtFirstName { get => txtFirstName; set => txtFirstName = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
    }
}