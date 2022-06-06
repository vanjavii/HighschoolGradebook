using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCFindClassgroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdClassGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHomeroomTeacher = new System.Windows.Forms.Label();
            this.dgvStudentsFromClassgroup = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsFromClassgroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Classgroup ID:";
            // 
            // txtIdClassGroup
            // 
            this.txtIdClassGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdClassGroup.Location = new System.Drawing.Point(352, 19);
            this.txtIdClassGroup.Name = "txtIdClassGroup";
            this.txtIdClassGroup.Size = new System.Drawing.Size(100, 20);
            this.txtIdClassGroup.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Homeroom Teacher:";
            // 
            // lblHomeroomTeacher
            // 
            this.lblHomeroomTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHomeroomTeacher.AutoSize = true;
            this.lblHomeroomTeacher.Location = new System.Drawing.Point(397, 67);
            this.lblHomeroomTeacher.Name = "lblHomeroomTeacher";
            this.lblHomeroomTeacher.Size = new System.Drawing.Size(35, 13);
            this.lblHomeroomTeacher.TabIndex = 5;
            this.lblHomeroomTeacher.Text = "label4";
            // 
            // dgvStudentsFromClassgroup
            // 
            this.dgvStudentsFromClassgroup.AllowUserToAddRows = false;
            this.dgvStudentsFromClassgroup.AllowUserToDeleteRows = false;
            this.dgvStudentsFromClassgroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentsFromClassgroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsFromClassgroup.Location = new System.Drawing.Point(20, 106);
            this.dgvStudentsFromClassgroup.Name = "dgvStudentsFromClassgroup";
            this.dgvStudentsFromClassgroup.ReadOnly = true;
            this.dgvStudentsFromClassgroup.Size = new System.Drawing.Size(758, 243);
            this.dgvStudentsFromClassgroup.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.Location = new System.Drawing.Point(486, 16);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormat.AutoSize = true;
            this.lblFormat.ForeColor = System.Drawing.Color.Blue;
            this.lblFormat.Location = new System.Drawing.Point(223, 42);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(338, 13);
            this.lblFormat.TabIndex = 8;
            this.lblFormat.Text = "Insert ID in format XY where X stands for Year and Y stands for Group!";
            // 
            // UCFindClassgroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvStudentsFromClassgroup);
            this.Controls.Add(this.lblHomeroomTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdClassGroup);
            this.Controls.Add(this.label1);
            this.Name = "UCFindClassgroup";
            this.Size = new System.Drawing.Size(804, 371);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsFromClassgroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdClassGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHomeroomTeacher;
        private System.Windows.Forms.DataGridView dgvStudentsFromClassgroup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblFormat;

        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtIdClassGroup { get => txtIdClassGroup; set => txtIdClassGroup = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label LblHomeroomTeacher { get => lblHomeroomTeacher; set => lblHomeroomTeacher = value; }
        public DataGridView DgvStudentsFromClassgroup { get => dgvStudentsFromClassgroup; set => dgvStudentsFromClassgroup = value; }
        public Button BtnFind { get => btnFind; set => btnFind = value; }
        public Label LblFormat { get => lblFormat; set => lblFormat = value; }
    }
}
