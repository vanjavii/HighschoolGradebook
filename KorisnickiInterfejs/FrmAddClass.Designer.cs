using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmAddClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.cbTeachersOnSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassGroupID = new System.Windows.Forms.TextBox();
            this.gbChooseStudent = new System.Windows.Forms.GroupBox();
            this.dgvStudentsFromSelectedClassGroup = new System.Windows.Forms.DataGridView();
            this.btnGetStudents = new System.Windows.Forms.Button();
            this.gbAssignedMarks = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedRow = new System.Windows.Forms.Button();
            this.dgvAssignedMarks = new System.Windows.Forms.DataGridView();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.gbChooseStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsFromSelectedClassGroup)).BeginInit();
            this.gbAssignedMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher:";
            // 
            // cbSubjects
            // 
            this.cbSubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(553, 61);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(121, 21);
            this.cbSubjects.TabIndex = 2;
            this.cbSubjects.SelectedValueChanged += new System.EventHandler(this.cbSubjects_SelectedValueChanged);
            // 
            // cbTeachersOnSubject
            // 
            this.cbTeachersOnSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTeachersOnSubject.FormattingEnabled = true;
            this.cbTeachersOnSubject.Location = new System.Drawing.Point(553, 98);
            this.cbTeachersOnSubject.Name = "cbTeachersOnSubject";
            this.cbTeachersOnSubject.Size = new System.Drawing.Size(121, 21);
            this.cbTeachersOnSubject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class Date:";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateTime.Location = new System.Drawing.Point(260, 101);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(111, 20);
            this.txtDateTime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ClassGroupID:";
            // 
            // txtClassGroupID
            // 
            this.txtClassGroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassGroupID.Location = new System.Drawing.Point(260, 66);
            this.txtClassGroupID.Name = "txtClassGroupID";
            this.txtClassGroupID.Size = new System.Drawing.Size(111, 20);
            this.txtClassGroupID.TabIndex = 7;
            this.txtClassGroupID.TextChanged += new System.EventHandler(this.txtClassGroupID_TextChanged);
            // 
            // gbChooseStudent
            // 
            this.gbChooseStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbChooseStudent.Controls.Add(this.dgvStudentsFromSelectedClassGroup);
            this.gbChooseStudent.Location = new System.Drawing.Point(27, 175);
            this.gbChooseStudent.Name = "gbChooseStudent";
            this.gbChooseStudent.Size = new System.Drawing.Size(764, 177);
            this.gbChooseStudent.TabIndex = 8;
            this.gbChooseStudent.TabStop = false;
            this.gbChooseStudent.Text = "Choose student";
            // 
            // dgvStudentsFromSelectedClassGroup
            // 
            this.dgvStudentsFromSelectedClassGroup.AllowUserToAddRows = false;
            this.dgvStudentsFromSelectedClassGroup.AllowUserToDeleteRows = false;
            this.dgvStudentsFromSelectedClassGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentsFromSelectedClassGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsFromSelectedClassGroup.Location = new System.Drawing.Point(28, 29);
            this.dgvStudentsFromSelectedClassGroup.Name = "dgvStudentsFromSelectedClassGroup";
            this.dgvStudentsFromSelectedClassGroup.ReadOnly = true;
            this.dgvStudentsFromSelectedClassGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentsFromSelectedClassGroup.Size = new System.Drawing.Size(708, 125);
            this.dgvStudentsFromSelectedClassGroup.TabIndex = 0;
            this.dgvStudentsFromSelectedClassGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsFromSelectedClassGroup_CellDoubleClick);
            this.dgvStudentsFromSelectedClassGroup.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvStudentsFromSelectedClassGroup_DataError);
            // 
            // btnGetStudents
            // 
            this.btnGetStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetStudents.Location = new System.Drawing.Point(334, 136);
            this.btnGetStudents.Name = "btnGetStudents";
            this.btnGetStudents.Size = new System.Drawing.Size(178, 23);
            this.btnGetStudents.TabIndex = 9;
            this.btnGetStudents.Text = "Get Students";
            this.btnGetStudents.UseVisualStyleBackColor = true;
            this.btnGetStudents.Click += new System.EventHandler(this.btnGetStudents_Click);
            // 
            // gbAssignedMarks
            // 
            this.gbAssignedMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbAssignedMarks.Controls.Add(this.btnRemoveSelectedRow);
            this.gbAssignedMarks.Controls.Add(this.dgvAssignedMarks);
            this.gbAssignedMarks.Location = new System.Drawing.Point(132, 358);
            this.gbAssignedMarks.Name = "gbAssignedMarks";
            this.gbAssignedMarks.Size = new System.Drawing.Size(556, 191);
            this.gbAssignedMarks.TabIndex = 12;
            this.gbAssignedMarks.TabStop = false;
            this.gbAssignedMarks.Text = "Assigned Marks";
            // 
            // btnRemoveSelectedRow
            // 
            this.btnRemoveSelectedRow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveSelectedRow.Location = new System.Drawing.Point(202, 151);
            this.btnRemoveSelectedRow.Name = "btnRemoveSelectedRow";
            this.btnRemoveSelectedRow.Size = new System.Drawing.Size(134, 23);
            this.btnRemoveSelectedRow.TabIndex = 1;
            this.btnRemoveSelectedRow.Text = "Remove selected row";
            this.btnRemoveSelectedRow.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedRow.Click += new System.EventHandler(this.btnRemoveSelectedRow_Click);
            // 
            // dgvAssignedMarks
            // 
            this.dgvAssignedMarks.AllowUserToAddRows = false;
            this.dgvAssignedMarks.AllowUserToDeleteRows = false;
            this.dgvAssignedMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAssignedMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedMarks.Location = new System.Drawing.Point(48, 29);
            this.dgvAssignedMarks.Name = "dgvAssignedMarks";
            this.dgvAssignedMarks.ReadOnly = true;
            this.dgvAssignedMarks.Size = new System.Drawing.Size(459, 105);
            this.dgvAssignedMarks.TabIndex = 0;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAll.Location = new System.Drawing.Point(363, 570);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(78, 23);
            this.btnSaveAll.TabIndex = 13;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // FrmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(821, 621);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.gbAssignedMarks);
            this.Controls.Add(this.btnGetStudents);
            this.Controls.Add(this.gbChooseStudent);
            this.Controls.Add(this.txtClassGroupID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTeachersOnSubject);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new Class";
            this.gbChooseStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsFromSelectedClassGroup)).EndInit();
            this.gbAssignedMarks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.ComboBox cbTeachersOnSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassGroupID;
        private System.Windows.Forms.GroupBox gbChooseStudent;
        private System.Windows.Forms.DataGridView dgvStudentsFromSelectedClassGroup;
        private System.Windows.Forms.Button btnGetStudents;
        private System.Windows.Forms.GroupBox gbAssignedMarks;
        private System.Windows.Forms.DataGridView dgvAssignedMarks;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnRemoveSelectedRow;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox CbSubjects { get => cbSubjects; set => cbSubjects = value; }
        public ComboBox CbTeachersOnSubject { get => cbTeachersOnSubject; set => cbTeachersOnSubject = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtDateTime { get => txtDateTime; set => txtDateTime = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public TextBox TxtClassGroupID { get => txtClassGroupID; set => txtClassGroupID = value; }
        public GroupBox GbChooseStudent { get => gbChooseStudent; set => gbChooseStudent = value; }
        public DataGridView DgvStudentsFromSelectedClassGroup { get => dgvStudentsFromSelectedClassGroup; set => dgvStudentsFromSelectedClassGroup = value; }
        public Button BtnGetStudents { get => btnGetStudents; set => btnGetStudents = value; }
        public GroupBox GbAssignedMarks { get => gbAssignedMarks; set => gbAssignedMarks = value; }
        public DataGridView DgvAssignedMarks { get => dgvAssignedMarks; set => dgvAssignedMarks = value; }
        public Button BtnSaveAll { get => btnSaveAll; set => btnSaveAll = value; }
        public Button BtnRemoveSelectedRow { get => btnRemoveSelectedRow; set => btnRemoveSelectedRow = value; }
    }
}