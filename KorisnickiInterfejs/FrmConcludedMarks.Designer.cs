using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmConcludedMarks
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
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.dgvConcludedMarks = new System.Windows.Forms.DataGridView();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblStudentFirstNameLastName = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblClassGroup = new System.Windows.Forms.Label();
            this.lblClassGroupValue = new System.Windows.Forms.Label();
            this.cbNew = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJMBGtoSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcludedMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentId:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentId.Location = new System.Drawing.Point(174, 8);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(118, 20);
            this.txtStudentId.TabIndex = 1;
            // 
            // dgvConcludedMarks
            // 
            this.dgvConcludedMarks.AllowUserToAddRows = false;
            this.dgvConcludedMarks.AllowUserToDeleteRows = false;
            this.dgvConcludedMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvConcludedMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcludedMarks.Location = new System.Drawing.Point(98, 191);
            this.dgvConcludedMarks.Name = "dgvConcludedMarks";
            this.dgvConcludedMarks.ReadOnly = true;
            this.dgvConcludedMarks.Size = new System.Drawing.Size(246, 302);
            this.dgvConcludedMarks.TabIndex = 2;
            // 
            // lblStudent
            // 
            this.lblStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblStudent.Location = new System.Drawing.Point(95, 125);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(47, 13);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Student:";
            // 
            // lblStudentFirstNameLastName
            // 
            this.lblStudentFirstNameLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentFirstNameLastName.AutoSize = true;
            this.lblStudentFirstNameLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentFirstNameLastName.Location = new System.Drawing.Point(148, 125);
            this.lblStudentFirstNameLastName.Name = "lblStudentFirstNameLastName";
            this.lblStudentFirstNameLastName.Size = new System.Drawing.Size(35, 13);
            this.lblStudentFirstNameLastName.TabIndex = 4;
            this.lblStudentFirstNameLastName.Text = "label2";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.Location = new System.Drawing.Point(186, 147);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblClassGroup
            // 
            this.lblClassGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassGroup.AutoSize = true;
            this.lblClassGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblClassGroup.Location = new System.Drawing.Point(228, 125);
            this.lblClassGroup.Name = "lblClassGroup";
            this.lblClassGroup.Size = new System.Drawing.Size(64, 13);
            this.lblClassGroup.TabIndex = 6;
            this.lblClassGroup.Text = "ClassGroup:";
            // 
            // lblClassGroupValue
            // 
            this.lblClassGroupValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassGroupValue.AutoSize = true;
            this.lblClassGroupValue.BackColor = System.Drawing.Color.Transparent;
            this.lblClassGroupValue.Location = new System.Drawing.Point(298, 125);
            this.lblClassGroupValue.Name = "lblClassGroupValue";
            this.lblClassGroupValue.Size = new System.Drawing.Size(35, 13);
            this.lblClassGroupValue.TabIndex = 7;
            this.lblClassGroupValue.Text = "label2";
            // 
            // cbNew
            // 
            this.cbNew.FormattingEnabled = true;
            this.cbNew.Location = new System.Drawing.Point(174, 8);
            this.cbNew.Name = "cbNew";
            this.cbNew.Size = new System.Drawing.Size(118, 21);
            this.cbNew.TabIndex = 8;
            this.cbNew.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(114, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtJMBGtoSearch
            // 
            this.txtJMBGtoSearch.Location = new System.Drawing.Point(174, 91);
            this.txtJMBGtoSearch.Name = "txtJMBGtoSearch";
            this.txtJMBGtoSearch.Size = new System.Drawing.Size(118, 20);
            this.txtJMBGtoSearch.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(114, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(224, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "or";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(224, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "or";
            // 
            // FrmConcludedMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.pastel_blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 515);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJMBGtoSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNew);
            this.Controls.Add(this.lblClassGroupValue);
            this.Controls.Add(this.lblClassGroup);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblStudentFirstNameLastName);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.dgvConcludedMarks);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label1);
            this.Name = "FrmConcludedMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concluded Marks of the Student";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcludedMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.DataGridView dgvConcludedMarks;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblStudentFirstNameLastName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblClassGroup;
        private System.Windows.Forms.Label lblClassGroupValue;
        private ComboBox cbNew;
        private Label label2;
        private TextBox txtName;
        private TextBox txtJMBGtoSearch;
        private Label label3;
        private Label label4;
        private Label label5;

        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtStudentId { get => txtStudentId; set => txtStudentId = value; }
        public DataGridView DgvConcludedMarks { get => dgvConcludedMarks; set => dgvConcludedMarks = value; }
        public Label LblStudent { get => lblStudent; set => lblStudent = value; }
        public Label LblStudentFirstNameLastName { get => lblStudentFirstNameLastName; set => lblStudentFirstNameLastName = value; }
        public Button BtnFind { get => btnFind; set => btnFind = value; }
        public Label LblClassGroup { get => lblClassGroup; set => lblClassGroup = value; }
        public Label LblClassGroupValue { get => lblClassGroupValue; set => lblClassGroupValue = value; }
        public ComboBox CbNew { get => cbNew; set => cbNew = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public TextBox TxtJMBGtoSearch { get => txtJMBGtoSearch; set => txtJMBGtoSearch = value; }
    }
}