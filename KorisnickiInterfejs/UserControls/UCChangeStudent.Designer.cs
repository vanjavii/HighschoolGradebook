using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCChangeStudent
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthDateLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.classGroupTextBox = new System.Windows.Forms.TextBox();
            this.cbChooseNewClassGroup = new System.Windows.Forms.ComboBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJMBGtoSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(236, 280);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(236, 123);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 10;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(235, 166);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(235, 315);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 14;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(236, 354);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(62, 13);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Classgroup:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(236, 204);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 20;
            birthDateLabel.Text = "Birth Date:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentID:";
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdStudent.Location = new System.Drawing.Point(711, 43);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(100, 20);
            this.txtIdStudent.TabIndex = 1;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindStudent.Location = new System.Drawing.Point(435, 81);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(75, 23);
            this.btnFindStudent.TabIndex = 2;
            this.btnFindStudent.Text = "Find student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveChanges.Location = new System.Drawing.Point(664, 298);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(67, 39);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeInfo.Location = new System.Drawing.Point(664, 237);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(67, 42);
            this.btnChangeInfo.TabIndex = 5;
            this.btnChangeInfo.Text = "Change Info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(374, 273);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Domain.Student);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(374, 120);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 11;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(374, 159);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 13;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(374, 312);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 15;
            // 
            // classGroupTextBox
            // 
            this.classGroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ClassGroup.Name", true));
            this.classGroupTextBox.Location = new System.Drawing.Point(374, 351);
            this.classGroupTextBox.Name = "classGroupTextBox";
            this.classGroupTextBox.Size = new System.Drawing.Size(200, 20);
            this.classGroupTextBox.TabIndex = 19;
            // 
            // cbChooseNewClassGroup
            // 
            this.cbChooseNewClassGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbChooseNewClassGroup.FormattingEnabled = true;
            this.cbChooseNewClassGroup.Location = new System.Drawing.Point(374, 351);
            this.cbChooseNewClassGroup.Name = "cbChooseNewClassGroup";
            this.cbChooseNewClassGroup.Size = new System.Drawing.Size(200, 21);
            this.cbChooseNewClassGroup.TabIndex = 20;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(374, 201);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateDateTimePicker.TabIndex = 21;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.txtBirthDate.Location = new System.Drawing.Point(374, 201);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.txtBirthDate.TabIndex = 22;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveStudent.Location = new System.Drawing.Point(374, 389);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(200, 23);
            this.btnRemoveStudent.TabIndex = 23;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Choose a way to find Student";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "JMBG:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(216, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 20);
            this.txtName.TabIndex = 27;
            // 
            // txtJMBGtoSearch
            // 
            this.txtJMBGtoSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBGtoSearch.Location = new System.Drawing.Point(459, 43);
            this.txtJMBGtoSearch.Name = "txtJMBGtoSearch";
            this.txtJMBGtoSearch.Size = new System.Drawing.Size(157, 20);
            this.txtJMBGtoSearch.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "JMBG:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBG.Location = new System.Drawing.Point(374, 237);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(200, 20);
            this.txtJMBG.TabIndex = 30;
            // 
            // UCChangeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJMBGtoSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.cbChooseNewClassGroup);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.classGroupTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.label1);
            this.Name = "UCChangeStudent";
            this.Size = new System.Drawing.Size(929, 432);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox classGroupTextBox;
        private System.Windows.Forms.ComboBox cbChooseNewClassGroup;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Button btnRemoveStudent;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtJMBGtoSearch;
        private Label label5;
        private TextBox txtJMBG;

        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtIdStudent { get => txtIdStudent; set => txtIdStudent = value; }
        public Button BtnFindStudent { get => btnFindStudent; set => btnFindStudent = value; }
        public Button BtnSaveChanges { get => btnSaveChanges; set => btnSaveChanges = value; }
        public Button BtnChangeInfo { get => btnChangeInfo; set => btnChangeInfo = value; }
        public BindingSource StudentBindingSource { get => studentBindingSource; set => studentBindingSource = value; }
        public TextBox AddressTextBox { get => addressTextBox; set => addressTextBox = value; }
        public TextBox FirstNameTextBox { get => firstNameTextBox; set => firstNameTextBox = value; }
        public TextBox LastNameTextBox { get => lastNameTextBox; set => lastNameTextBox = value; }
        public TextBox PhoneNumberTextBox { get => phoneNumberTextBox; set => phoneNumberTextBox = value; }
        public TextBox ClassGroupTextBox { get => classGroupTextBox; set => classGroupTextBox = value; }
        public ComboBox CbChooseNewClassGroup { get => cbChooseNewClassGroup; set => cbChooseNewClassGroup = value; }
        public DateTimePicker BirthDateDateTimePicker { get => birthDateDateTimePicker; set => birthDateDateTimePicker = value; }
        public TextBox TxtBirthDate { get => txtBirthDate; set => txtBirthDate = value; }
        public Button BtnRemoveStudent { get => btnRemoveStudent; set => btnRemoveStudent = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public TextBox TxtJMBGtoSearch { get => txtJMBGtoSearch; set => txtJMBGtoSearch = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
    }
}
