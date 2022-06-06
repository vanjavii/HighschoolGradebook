using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmAddMark
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbExaminationType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtDateOfExamination = new System.Windows.Forms.TextBox();
            this.btnSaveMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentName.Location = new System.Drawing.Point(143, 39);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(208, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(90, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Examination Type:";
            // 
            // cbExaminationType
            // 
            this.cbExaminationType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbExaminationType.FormattingEnabled = true;
            this.cbExaminationType.Location = new System.Drawing.Point(201, 79);
            this.cbExaminationType.Name = "cbExaminationType";
            this.cbExaminationType.Size = new System.Drawing.Size(150, 21);
            this.cbExaminationType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(90, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Value:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(90, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date of Examiantion:";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValue.Location = new System.Drawing.Point(143, 122);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(208, 20);
            this.txtValue.TabIndex = 8;
            // 
            // txtDateOfExamination
            // 
            this.txtDateOfExamination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateOfExamination.Location = new System.Drawing.Point(201, 158);
            this.txtDateOfExamination.Name = "txtDateOfExamination";
            this.txtDateOfExamination.Size = new System.Drawing.Size(150, 20);
            this.txtDateOfExamination.TabIndex = 9;
            // 
            // btnSaveMark
            // 
            this.btnSaveMark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveMark.Location = new System.Drawing.Point(143, 207);
            this.btnSaveMark.Name = "btnSaveMark";
            this.btnSaveMark.Size = new System.Drawing.Size(161, 23);
            this.btnSaveMark.TabIndex = 10;
            this.btnSaveMark.Text = "Save Mark";
            this.btnSaveMark.UseVisualStyleBackColor = true;
            this.btnSaveMark.Click += new System.EventHandler(this.btnSaveMark_Click);
            // 
            // FrmAddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.pastel_blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 262);
            this.Controls.Add(this.btnSaveMark);
            this.Controls.Add(this.txtDateOfExamination);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbExaminationType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Mark to selected Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbExaminationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtDateOfExamination;
        private System.Windows.Forms.Button btnSaveMark;

        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtStudentName { get => txtStudentName; set => txtStudentName = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public ComboBox CbExaminationType { get => cbExaminationType; set => cbExaminationType = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtValue { get => txtValue; set => txtValue = value; }
        public TextBox TxtDateOfExamination { get => txtDateOfExamination; set => txtDateOfExamination = value; }
        public Button BtnSaveMark { get => btnSaveMark; set => btnSaveMark = value; }
    }
}