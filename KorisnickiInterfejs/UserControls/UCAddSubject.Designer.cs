using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCAddSubject
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label subjectNameLabel;
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.dgvTeachersOnSubject = new System.Windows.Forms.DataGridView();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.cbNew = new System.Windows.Forms.ComboBox();
            descriptionLabel = new System.Windows.Forms.Label();
            subjectNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersOnSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(55, 78);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // subjectNameLabel
            // 
            subjectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            subjectNameLabel.AutoSize = true;
            subjectNameLabel.Location = new System.Drawing.Point(55, 31);
            subjectNameLabel.Name = "subjectNameLabel";
            subjectNameLabel.Size = new System.Drawing.Size(77, 13);
            subjectNameLabel.TabIndex = 3;
            subjectNameLabel.Text = "Subject Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(162, 75);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(406, 57);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Domain.Subject);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubjectName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "SubjectName", true));
            this.txtSubjectName.Location = new System.Drawing.Point(162, 31);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(122, 20);
            this.txtSubjectName.TabIndex = 4;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAll.Location = new System.Drawing.Point(422, 380);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(118, 23);
            this.btnSaveAll.TabIndex = 6;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveRow.Location = new System.Drawing.Point(236, 380);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(154, 23);
            this.btnRemoveRow.TabIndex = 7;
            this.btnRemoveRow.Text = "Remove selected Teacher";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // dgvTeachersOnSubject
            // 
            this.dgvTeachersOnSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTeachersOnSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachersOnSubject.Location = new System.Drawing.Point(58, 155);
            this.dgvTeachersOnSubject.Name = "dgvTeachersOnSubject";
            this.dgvTeachersOnSubject.Size = new System.Drawing.Size(648, 205);
            this.dgvTeachersOnSubject.TabIndex = 8;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Domain.Teacher);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTeacher.Location = new System.Drawing.Point(612, 82);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(65, 39);
            this.btnAddTeacher.TabIndex = 9;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // cbNew
            // 
            this.cbNew.FormattingEnabled = true;
            this.cbNew.Location = new System.Drawing.Point(162, 31);
            this.cbNew.Name = "cbNew";
            this.cbNew.Size = new System.Drawing.Size(121, 21);
            this.cbNew.TabIndex = 10;
            this.cbNew.Visible = false;
            // 
            // UCAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.cbNew);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.dgvTeachersOnSubject);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(subjectNameLabel);
            this.Controls.Add(this.txtSubjectName);
            this.Name = "UCAddSubject";
            this.Size = new System.Drawing.Size(767, 450);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersOnSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.DataGridView dgvTeachersOnSubject;
        private System.Windows.Forms.Button btnAddTeacher;
        private ComboBox cbNew;

        public BindingSource SubjectBindingSource { get => subjectBindingSource; set => subjectBindingSource = value; }
        public RichTextBox TxtDescription { get => txtDescription; set => txtDescription = value; }
        public TextBox TxtSubjectName { get => txtSubjectName; set => txtSubjectName = value; }
        public BindingSource TeacherBindingSource { get => teacherBindingSource; set => teacherBindingSource = value; }
        public Button BtnSaveAll { get => btnSaveAll; set => btnSaveAll = value; }
        public Button BtnRemoveRow { get => btnRemoveRow; set => btnRemoveRow = value; }
        public DataGridView DgvTeachersOnSubject { get => dgvTeachersOnSubject; set => dgvTeachersOnSubject = value; }
        public Button BtnAddTeacher { get => btnAddTeacher; set => btnAddTeacher = value; }
        public ComboBox CbNew { get => cbNew; set => cbNew = value; }
    }
}
