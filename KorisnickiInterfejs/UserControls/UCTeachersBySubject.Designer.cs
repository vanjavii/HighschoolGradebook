using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCTeachersBySubject
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
            this.cbChooseSubject = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvTeachersBySubject = new System.Windows.Forms.DataGridView();
            this.btnRemoveSelectedTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersBySubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose subject:";
            // 
            // cbChooseSubject
            // 
            this.cbChooseSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbChooseSubject.FormattingEnabled = true;
            this.cbChooseSubject.Location = new System.Drawing.Point(438, 27);
            this.cbChooseSubject.Name = "cbChooseSubject";
            this.cbChooseSubject.Size = new System.Drawing.Size(121, 21);
            this.cbChooseSubject.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.Location = new System.Drawing.Point(603, 27);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvTeachersBySubject
            // 
            this.dgvTeachersBySubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTeachersBySubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachersBySubject.Location = new System.Drawing.Point(61, 77);
            this.dgvTeachersBySubject.Name = "dgvTeachersBySubject";
            this.dgvTeachersBySubject.Size = new System.Drawing.Size(850, 313);
            this.dgvTeachersBySubject.TabIndex = 3;
            this.dgvTeachersBySubject.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTeachersBySubject_DataError);
            // 
            // btnRemoveSelectedTeacher
            // 
            this.btnRemoveSelectedTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveSelectedTeacher.Location = new System.Drawing.Point(417, 406);
            this.btnRemoveSelectedTeacher.Name = "btnRemoveSelectedTeacher";
            this.btnRemoveSelectedTeacher.Size = new System.Drawing.Size(163, 23);
            this.btnRemoveSelectedTeacher.TabIndex = 4;
            this.btnRemoveSelectedTeacher.Text = "Remove selected Teacher";
            this.btnRemoveSelectedTeacher.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedTeacher.Click += new System.EventHandler(this.btnRemoveSelectedTeacher_Click);
            // 
            // UCTeachersBySubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnRemoveSelectedTeacher);
            this.Controls.Add(this.dgvTeachersBySubject);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbChooseSubject);
            this.Controls.Add(this.label1);
            this.Name = "UCTeachersBySubject";
            this.Size = new System.Drawing.Size(974, 457);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersBySubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChooseSubject;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvTeachersBySubject;
        private System.Windows.Forms.Button btnRemoveSelectedTeacher;

        public Label Label1 { get => label1; set => label1 = value; }
        public ComboBox CbChooseSubject { get => cbChooseSubject; set => cbChooseSubject = value; }
        public Button BtnFind { get => btnFind; set => btnFind = value; }
        public DataGridView DgvTeachersBySubject { get => dgvTeachersBySubject; set => dgvTeachersBySubject = value; }
        public Button BtnRemoveSelectedTeacher { get => btnRemoveSelectedTeacher; set => btnRemoveSelectedTeacher = value; }
    }
}
