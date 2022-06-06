using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCSubjectInfo
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
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblIdSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtIdSubject = new System.Windows.Forms.TextBox();
            this.btnSearchForInfo = new System.Windows.Forms.Button();
            this.dgvTeachersOnSubject = new System.Windows.Forms.DataGridView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnChangeDescription = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnRemoveSelectedSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersOnSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSubjects
            // 
            this.cbSubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(318, 21);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(121, 21);
            this.cbSubjects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Subject:";
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(159, 77);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject:";
            // 
            // lblIdSubject
            // 
            this.lblIdSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdSubject.AutoSize = true;
            this.lblIdSubject.Location = new System.Drawing.Point(560, 77);
            this.lblIdSubject.Name = "lblIdSubject";
            this.lblIdSubject.Size = new System.Drawing.Size(60, 13);
            this.lblIdSubject.TabIndex = 3;
            this.lblIdSubject.Text = "Subject ID:";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubject.Location = new System.Drawing.Point(248, 74);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 20);
            this.txtSubject.TabIndex = 4;
            // 
            // txtIdSubject
            // 
            this.txtIdSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdSubject.Location = new System.Drawing.Point(678, 74);
            this.txtIdSubject.Name = "txtIdSubject";
            this.txtIdSubject.Size = new System.Drawing.Size(100, 20);
            this.txtIdSubject.TabIndex = 5;
            // 
            // btnSearchForInfo
            // 
            this.btnSearchForInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchForInfo.Location = new System.Drawing.Point(472, 19);
            this.btnSearchForInfo.Name = "btnSearchForInfo";
            this.btnSearchForInfo.Size = new System.Drawing.Size(116, 23);
            this.btnSearchForInfo.TabIndex = 6;
            this.btnSearchForInfo.Text = "Search for Info";
            this.btnSearchForInfo.UseVisualStyleBackColor = true;
            this.btnSearchForInfo.Click += new System.EventHandler(this.btnSearchForInfo_Click);
            // 
            // dgvTeachersOnSubject
            // 
            this.dgvTeachersOnSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTeachersOnSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachersOnSubject.Location = new System.Drawing.Point(71, 217);
            this.dgvTeachersOnSubject.Name = "dgvTeachersOnSubject";
            this.dgvTeachersOnSubject.Size = new System.Drawing.Size(832, 223);
            this.dgvTeachersOnSubject.TabIndex = 7;
            this.dgvTeachersOnSubject.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTeachersOnSubject_DataError);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(159, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Location = new System.Drawing.Point(248, 120);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(429, 78);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Text = "";
            // 
            // btnChangeDescription
            // 
            this.btnChangeDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeDescription.Location = new System.Drawing.Point(703, 120);
            this.btnChangeDescription.Name = "btnChangeDescription";
            this.btnChangeDescription.Size = new System.Drawing.Size(75, 34);
            this.btnChangeDescription.TabIndex = 10;
            this.btnChangeDescription.Text = "Change Description";
            this.btnChangeDescription.UseVisualStyleBackColor = true;
            this.btnChangeDescription.Click += new System.EventHandler(this.btnChangeDescription_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveChanges.Location = new System.Drawing.Point(703, 160);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 37);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnRemoveSelectedSubject
            // 
            this.btnRemoveSelectedSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveSelectedSubject.Location = new System.Drawing.Point(623, 19);
            this.btnRemoveSelectedSubject.Name = "btnRemoveSelectedSubject";
            this.btnRemoveSelectedSubject.Size = new System.Drawing.Size(108, 23);
            this.btnRemoveSelectedSubject.TabIndex = 12;
            this.btnRemoveSelectedSubject.Text = "Remove Subject";
            this.btnRemoveSelectedSubject.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedSubject.Click += new System.EventHandler(this.btnRemoveSelectedSubject_Click);
            // 
            // UCSubjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnRemoveSelectedSubject);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnChangeDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dgvTeachersOnSubject);
            this.Controls.Add(this.btnSearchForInfo);
            this.Controls.Add(this.txtIdSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblIdSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSubjects);
            this.Name = "UCSubjectInfo";
            this.Size = new System.Drawing.Size(972, 465);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersOnSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblIdSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtIdSubject;
        private System.Windows.Forms.Button btnSearchForInfo;
        private System.Windows.Forms.DataGridView dgvTeachersOnSubject;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnChangeDescription;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnRemoveSelectedSubject;

        public ComboBox CbSubjects { get => cbSubjects; set => cbSubjects = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label LblSubject { get => lblSubject; set => lblSubject = value; }
        public Label LblIdSubject { get => lblIdSubject; set => lblIdSubject = value; }
        public TextBox TxtSubject { get => txtSubject; set => txtSubject = value; }
        public TextBox TxtIdSubject { get => txtIdSubject; set => txtIdSubject = value; }
        public Button BtnSearchForInfo { get => btnSearchForInfo; set => btnSearchForInfo = value; }
        public DataGridView DgvTeachersOnSubject { get => dgvTeachersOnSubject; set => dgvTeachersOnSubject = value; }
        public Label LblDescription { get => lblDescription; set => lblDescription = value; }
        public RichTextBox TxtDescription { get => txtDescription; set => txtDescription = value; }
        public Button BtnChangeDescription { get => btnChangeDescription; set => btnChangeDescription = value; }
        public Button BtnSaveChanges { get => btnSaveChanges; set => btnSaveChanges = value; }
        public Button BtnRemoveSelectedSubject { get => btnRemoveSelectedSubject; set => btnRemoveSelectedSubject = value; }
    }
}
