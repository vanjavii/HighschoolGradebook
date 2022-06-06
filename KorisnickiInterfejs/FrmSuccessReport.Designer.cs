using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmSuccessReport
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
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblClassGroup = new System.Windows.Forms.Label();
            this.lblStream = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtClassGroup = new System.Windows.Forms.TextBox();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.gbMarksBySubject = new System.Windows.Forms.GroupBox();
            this.btnConcludeMark = new System.Windows.Forms.Button();
            this.txtFinalMark = new System.Windows.Forms.TextBox();
            this.lblFinalMark = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.dgvMarksOfStudent = new System.Windows.Forms.DataGridView();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNew = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.gbMarksBySubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksOfStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(158, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Name:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentId.Location = new System.Drawing.Point(564, 111);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.Visible = false;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindStudent.Location = new System.Drawing.Point(753, 18);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(75, 23);
            this.btnFindStudent.TabIndex = 2;
            this.btnFindStudent.Text = "Find student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(73, 71);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(306, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblClassGroup
            // 
            this.lblClassGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassGroup.AutoSize = true;
            this.lblClassGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblClassGroup.Location = new System.Drawing.Point(509, 70);
            this.lblClassGroup.Name = "lblClassGroup";
            this.lblClassGroup.Size = new System.Drawing.Size(64, 13);
            this.lblClassGroup.TabIndex = 5;
            this.lblClassGroup.Text = "ClassGroup:";
            // 
            // lblStream
            // 
            this.lblStream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStream.AutoSize = true;
            this.lblStream.BackColor = System.Drawing.Color.Transparent;
            this.lblStream.Location = new System.Drawing.Point(729, 70);
            this.lblStream.Name = "lblStream";
            this.lblStream.Size = new System.Drawing.Size(43, 13);
            this.lblStream.TabIndex = 6;
            this.lblStream.Text = "Stream:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(161, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(382, 68);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtClassGroup
            // 
            this.txtClassGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassGroup.Location = new System.Drawing.Point(595, 67);
            this.txtClassGroup.Name = "txtClassGroup";
            this.txtClassGroup.Size = new System.Drawing.Size(100, 20);
            this.txtClassGroup.TabIndex = 9;
            // 
            // txtStream
            // 
            this.txtStream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStream.Location = new System.Drawing.Point(790, 68);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(100, 20);
            this.txtStream.TabIndex = 10;
            // 
            // gbMarksBySubject
            // 
            this.gbMarksBySubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbMarksBySubject.BackColor = System.Drawing.Color.Transparent;
            this.gbMarksBySubject.Controls.Add(this.btnConcludeMark);
            this.gbMarksBySubject.Controls.Add(this.txtFinalMark);
            this.gbMarksBySubject.Controls.Add(this.lblFinalMark);
            this.gbMarksBySubject.Controls.Add(this.txtAverage);
            this.gbMarksBySubject.Controls.Add(this.lblAverage);
            this.gbMarksBySubject.Controls.Add(this.dgvMarksOfStudent);
            this.gbMarksBySubject.Controls.Add(this.cbSubjects);
            this.gbMarksBySubject.Controls.Add(this.label2);
            this.gbMarksBySubject.Controls.Add(this.txtStudentId);
            this.gbMarksBySubject.Location = new System.Drawing.Point(76, 111);
            this.gbMarksBySubject.Name = "gbMarksBySubject";
            this.gbMarksBySubject.Size = new System.Drawing.Size(814, 321);
            this.gbMarksBySubject.TabIndex = 11;
            this.gbMarksBySubject.TabStop = false;
            this.gbMarksBySubject.Text = "Marks by Subject";
            // 
            // btnConcludeMark
            // 
            this.btnConcludeMark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConcludeMark.Location = new System.Drawing.Point(585, 247);
            this.btnConcludeMark.Name = "btnConcludeMark";
            this.btnConcludeMark.Size = new System.Drawing.Size(102, 40);
            this.btnConcludeMark.TabIndex = 7;
            this.btnConcludeMark.Text = "Conclude Mark";
            this.btnConcludeMark.UseVisualStyleBackColor = true;
            this.btnConcludeMark.Click += new System.EventHandler(this.btnConcludeMark_Click);
            // 
            // txtFinalMark
            // 
            this.txtFinalMark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFinalMark.Location = new System.Drawing.Point(425, 258);
            this.txtFinalMark.Name = "txtFinalMark";
            this.txtFinalMark.Size = new System.Drawing.Size(100, 20);
            this.txtFinalMark.TabIndex = 6;
            //this.txtFinalMark.TextChanged += new System.EventHandler(this.txtFinalMark_TextChanged);
            // 
            // lblFinalMark
            // 
            this.lblFinalMark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFinalMark.AutoSize = true;
            this.lblFinalMark.Location = new System.Drawing.Point(362, 261);
            this.lblFinalMark.Name = "lblFinalMark";
            this.lblFinalMark.Size = new System.Drawing.Size(59, 13);
            this.lblFinalMark.TabIndex = 5;
            this.lblFinalMark.Text = "Final Mark:";
            //this.lblFinalMark.Click += new System.EventHandler(this.lblFinalMark_Click);
            // 
            // txtAverage
            // 
            this.txtAverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAverage.Location = new System.Drawing.Point(191, 258);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 4;
            //this.txtAverage.TextChanged += new System.EventHandler(this.txtAverage_TextChanged);
            // 
            // lblAverage
            // 
            this.lblAverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(135, 261);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average:";
            //this.lblAverage.Click += new System.EventHandler(this.lblAverage_Click);
            // 
            // dgvMarksOfStudent
            // 
            this.dgvMarksOfStudent.AllowUserToAddRows = false;
            this.dgvMarksOfStudent.AllowUserToDeleteRows = false;
            this.dgvMarksOfStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMarksOfStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarksOfStudent.Location = new System.Drawing.Point(138, 68);
            this.dgvMarksOfStudent.Name = "dgvMarksOfStudent";
            this.dgvMarksOfStudent.ReadOnly = true;
            this.dgvMarksOfStudent.Size = new System.Drawing.Size(549, 147);
            this.dgvMarksOfStudent.TabIndex = 2;
            //this.dgvMarksOfStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarksOfStudent_CellContentClick);
            // 
            // cbSubjects
            // 
            this.cbSubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(404, 26);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(121, 21);
            this.cbSubjects.TabIndex = 1;
            this.cbSubjects.SelectedIndexChanged += new System.EventHandler(this.cbChooseSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Subject:";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbNew
            // 
            this.cbNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNew.FormattingEnabled = true;
            this.cbNew.Location = new System.Drawing.Point(790, 67);
            this.cbNew.Name = "cbNew";
            this.cbNew.Size = new System.Drawing.Size(121, 21);
            this.cbNew.TabIndex = 8;
            this.cbNew.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(438, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "or           JMBG:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(248, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBG.Location = new System.Drawing.Point(540, 20);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(124, 20);
            this.txtJMBG.TabIndex = 14;
            // 
            // FrmSuccessReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.pastel_blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 466);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNew);
            this.Controls.Add(this.gbMarksBySubject);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.txtClassGroup);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblStream);
            this.Controls.Add(this.lblClassGroup);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.label1);
            this.Name = "FrmSuccessReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuccessReport";
            this.gbMarksBySubject.ResumeLayout(false);
            this.gbMarksBySubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksOfStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblClassGroup;
        private System.Windows.Forms.Label lblStream;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtClassGroup;
        private System.Windows.Forms.TextBox txtStream;
        private System.Windows.Forms.GroupBox gbMarksBySubject;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMarksOfStudent;
        private System.Windows.Forms.Button btnConcludeMark;
        private System.Windows.Forms.TextBox txtFinalMark;
        private System.Windows.Forms.Label lblFinalMark;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label lblAverage;
        private ComboBox cbNew;
        private Label label3;
        private TextBox txtName;
        private TextBox txtJMBG;

        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtStudentId { get => txtStudentId; set => txtStudentId = value; }
        public Button BtnFindStudent { get => btnFindStudent; set => btnFindStudent = value; }
        public Label LblFirstName { get => lblFirstName; set => lblFirstName = value; }
        public Label LblLastName { get => lblLastName; set => lblLastName = value; }
        public Label LblClassGroup { get => lblClassGroup; set => lblClassGroup = value; }
        public Label LblStream { get => lblStream; set => lblStream = value; }
        public TextBox TxtFirstName { get => txtFirstName; set => txtFirstName = value; }
        public TextBox TxtLastName { get => txtLastName; set => txtLastName = value; }
        public TextBox TxtClassGroup { get => txtClassGroup; set => txtClassGroup = value; }
        public TextBox TxtStream { get => txtStream; set => txtStream = value; }
        public GroupBox GbMarksBySubject { get => gbMarksBySubject; set => gbMarksBySubject = value; }
        public ComboBox CbSubjects { get => cbSubjects; set => cbSubjects = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public DataGridView DgvMarksOfStudent { get => dgvMarksOfStudent; set => dgvMarksOfStudent = value; }
        public Button BtnConcludeMark { get => btnConcludeMark; set => btnConcludeMark = value; }
        public TextBox TxtFinalMark { get => txtFinalMark; set => txtFinalMark = value; }
        public Label LblFinalMark { get => lblFinalMark; set => lblFinalMark = value; }
        public TextBox TxtAverage { get => txtAverage; set => txtAverage = value; }
        public Label LblAverage { get => lblAverage; set => lblAverage = value; }
        public ComboBox CbNew { get => cbNew; set => cbNew = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
    }
}