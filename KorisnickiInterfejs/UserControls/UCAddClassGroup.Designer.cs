using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCAddClassGroup
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
            this.dgvAddStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassGroupName = new System.Windows.Forms.TextBox();
            this.txtGeneratedId = new System.Windows.Forms.TextBox();
            this.btnGenerateId = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHomeroomTeacher = new System.Windows.Forms.ComboBox();
            this.btnRemoveSelectedRow = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.classGroupDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtYearOfStudies = new System.Windows.Forms.TextBox();
            this.rbSocial = new System.Windows.Forms.RadioButton();
            this.rbMath = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGroupDatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddStudents
            // 
            this.dgvAddStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAddStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddStudents.Location = new System.Drawing.Point(84, 133);
            this.dgvAddStudents.Name = "dgvAddStudents";
            this.dgvAddStudents.Size = new System.Drawing.Size(540, 170);
            this.dgvAddStudents.TabIndex = 0;
            this.dgvAddStudents.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAddStudents_DataError);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ClassGroup Name;";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generated ID:";
            // 
            // txtClassGroupName
            // 
            this.txtClassGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassGroupName.Location = new System.Drawing.Point(502, 23);
            this.txtClassGroupName.Name = "txtClassGroupName";
            this.txtClassGroupName.Size = new System.Drawing.Size(121, 20);
            this.txtClassGroupName.TabIndex = 3;
            // 
            // txtGeneratedId
            // 
            this.txtGeneratedId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGeneratedId.Location = new System.Drawing.Point(503, 59);
            this.txtGeneratedId.Name = "txtGeneratedId";
            this.txtGeneratedId.Size = new System.Drawing.Size(121, 20);
            this.txtGeneratedId.TabIndex = 4;
            // 
            // btnGenerateId
            // 
            this.btnGenerateId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateId.Location = new System.Drawing.Point(240, 23);
            this.btnGenerateId.Name = "btnGenerateId";
            this.btnGenerateId.Size = new System.Drawing.Size(113, 23);
            this.btnGenerateId.TabIndex = 5;
            this.btnGenerateId.Text = "Generate ID";
            this.btnGenerateId.UseVisualStyleBackColor = true;
            this.btnGenerateId.Click += new System.EventHandler(this.btnGenerateId_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stream:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Homeroom Teacher:";
            // 
            // cbHomeroomTeacher
            // 
            this.cbHomeroomTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHomeroomTeacher.FormattingEnabled = true;
            this.cbHomeroomTeacher.Location = new System.Drawing.Point(202, 94);
            this.cbHomeroomTeacher.Name = "cbHomeroomTeacher";
            this.cbHomeroomTeacher.Size = new System.Drawing.Size(121, 21);
            this.cbHomeroomTeacher.TabIndex = 8;
            // 
            // btnRemoveSelectedRow
            // 
            this.btnRemoveSelectedRow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveSelectedRow.Location = new System.Drawing.Point(221, 332);
            this.btnRemoveSelectedRow.Name = "btnRemoveSelectedRow";
            this.btnRemoveSelectedRow.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveSelectedRow.TabIndex = 9;
            this.btnRemoveSelectedRow.Text = "Remove Selected Row";
            this.btnRemoveSelectedRow.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedRow.Click += new System.EventHandler(this.btnRemoveSelectedRow_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAll.Location = new System.Drawing.Point(400, 332);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAll.TabIndex = 10;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudent.Location = new System.Drawing.Point(464, 97);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(110, 23);
            this.btnAddStudent.TabIndex = 13;
            this.btnAddStudent.Text = "AddStudent";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // classGroupDatabaseBindingSource
            // 
            this.classGroupDatabaseBindingSource.DataSource = typeof(Domain.ClassGroupDatabase);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enter Year:";
            // 
            // txtYearOfStudies
            // 
            this.txtYearOfStudies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYearOfStudies.Location = new System.Drawing.Point(147, 25);
            this.txtYearOfStudies.Name = "txtYearOfStudies";
            this.txtYearOfStudies.Size = new System.Drawing.Size(78, 20);
            this.txtYearOfStudies.TabIndex = 15;
            // 
            // rbSocial
            // 
            this.rbSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSocial.AutoSize = true;
            this.rbSocial.Location = new System.Drawing.Point(147, 63);
            this.rbSocial.Name = "rbSocial";
            this.rbSocial.Size = new System.Drawing.Size(52, 17);
            this.rbSocial.TabIndex = 18;
            this.rbSocial.TabStop = true;
            this.rbSocial.Text = "social";
            this.rbSocial.UseVisualStyleBackColor = true;
            // 
            // rbMath
            // 
            this.rbMath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMath.AutoSize = true;
            this.rbMath.Location = new System.Drawing.Point(221, 63);
            this.rbMath.Name = "rbMath";
            this.rbMath.Size = new System.Drawing.Size(48, 17);
            this.rbMath.TabIndex = 19;
            this.rbMath.TabStop = true;
            this.rbMath.Text = "math";
            this.rbMath.UseVisualStyleBackColor = true;
            // 
            // UCAddClassGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.rbMath);
            this.Controls.Add(this.rbSocial);
            this.Controls.Add(this.txtYearOfStudies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.btnRemoveSelectedRow);
            this.Controls.Add(this.cbHomeroomTeacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerateId);
            this.Controls.Add(this.txtGeneratedId);
            this.Controls.Add(this.txtClassGroupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAddStudents);
            this.Name = "UCAddClassGroup";
            this.Size = new System.Drawing.Size(721, 382);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGroupDatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource classGroupDatabaseBindingSource;
        private System.Windows.Forms.DataGridView dgvAddStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassGroupName;
        private System.Windows.Forms.TextBox txtGeneratedId;
        private System.Windows.Forms.Button btnGenerateId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHomeroomTeacher;
        private System.Windows.Forms.Button btnRemoveSelectedRow;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYearOfStudies;
        private System.Windows.Forms.RadioButton rbSocial;
        private System.Windows.Forms.RadioButton rbMath;

        public BindingSource ClassGroupDatabaseBindingSource { get => classGroupDatabaseBindingSource; set => classGroupDatabaseBindingSource = value; }
        public DataGridView DgvAddStudents { get => dgvAddStudents; set => dgvAddStudents = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtClassGroupName { get => txtClassGroupName; set => txtClassGroupName = value; }
        public TextBox TxtGeneratedId { get => txtGeneratedId; set => txtGeneratedId = value; }
        public Button BtnGenerateId { get => btnGenerateId; set => btnGenerateId = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public ComboBox CbHomeroomTeacher { get => cbHomeroomTeacher; set => cbHomeroomTeacher = value; }
        public Button BtnRemoveSelectedRow { get => btnRemoveSelectedRow; set => btnRemoveSelectedRow = value; }
        public Button BtnSaveAll { get => btnSaveAll; set => btnSaveAll = value; }
        public Button BtnAddStudent { get => btnAddStudent; set => btnAddStudent = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtYearOfStudies { get => txtYearOfStudies; set => txtYearOfStudies = value; }
        public RadioButton RbSocial { get => rbSocial; set => rbSocial = value; }
        public RadioButton RbMath { get => rbMath; set => rbMath = value; }
    }
}
