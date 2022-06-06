using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCAddStudentWithValidation
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label nameLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(53, 169);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(53, 115);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 3;
            birthDateLabel.Text = "Birth Date:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(53, 57);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(318, 60);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(53, 222);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(53, 327);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(62, 13);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Classgroup:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(150, 166);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(141, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(150, 115);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.birthDateDateTimePicker.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(150, 57);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(406, 57);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(150, 219);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(141, 20);
            this.phoneNumberTextBox.TabIndex = 10;
            // 
            // nameComboBox
            // 
            this.nameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ClassGroup.Name", true));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(150, 324);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(141, 21);
            this.nameComboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYear.Location = new System.Drawing.Point(150, 272);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(141, 20);
            this.txtYear.TabIndex = 14;
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveStudent.Location = new System.Drawing.Point(380, 324);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(171, 23);
            this.btnSaveStudent.TabIndex = 15;
            this.btnSaveStudent.Text = "Save Student";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGo.Location = new System.Drawing.Point(321, 272);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(42, 23);
            this.btnGo.TabIndex = 16;
            this.btnGo.Text = "Find";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "JMBG:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBG.Location = new System.Drawing.Point(406, 118);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(164, 20);
            this.txtJMBG.TabIndex = 18;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Domain.Student);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(259, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCAddStudentWithValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
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
            this.Name = "UCAddStudentWithValidation";
            this.Size = new System.Drawing.Size(642, 409);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Button btnGo;
        private Label label2;
        private TextBox txtJMBG;
        private Button button1;

        public BindingSource StudentBindingSource { get => studentBindingSource; set => studentBindingSource = value; }
        public TextBox AddressTextBox { get => addressTextBox; set => addressTextBox = value; }
        public DateTimePicker BirthDateDateTimePicker { get => birthDateDateTimePicker; set => birthDateDateTimePicker = value; }
        public TextBox FirstNameTextBox { get => firstNameTextBox; set => firstNameTextBox = value; }
        public TextBox LastNameTextBox { get => lastNameTextBox; set => lastNameTextBox = value; }
        public TextBox PhoneNumberTextBox { get => phoneNumberTextBox; set => phoneNumberTextBox = value; }
        public ComboBox NameComboBox { get => nameComboBox; set => nameComboBox = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtYear { get => txtYear; set => txtYear = value; }
        public Button BtnSaveStudent { get => btnSaveStudent; set => btnSaveStudent = value; }
        public Button BtnGo { get => btnGo; set => btnGo = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
    }
}
