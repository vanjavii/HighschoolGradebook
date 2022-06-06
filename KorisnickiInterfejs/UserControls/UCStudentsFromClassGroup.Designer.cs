using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCStudentsFromClassGroup
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
            this.dgvStudentsFromSelectedClassgroup = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClassGroups = new System.Windows.Forms.ComboBox();
            this.btnFindStudentsFromSelectedClassGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsFromSelectedClassgroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentsFromSelectedClassgroup
            // 
            this.dgvStudentsFromSelectedClassgroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentsFromSelectedClassgroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsFromSelectedClassgroup.Location = new System.Drawing.Point(119, 83);
            this.dgvStudentsFromSelectedClassgroup.Name = "dgvStudentsFromSelectedClassgroup";
            this.dgvStudentsFromSelectedClassgroup.ReadOnly = true;
            this.dgvStudentsFromSelectedClassgroup.Size = new System.Drawing.Size(739, 372);
            this.dgvStudentsFromSelectedClassgroup.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Classgroup:";
            // 
            // cbClassGroups
            // 
            this.cbClassGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClassGroups.FormattingEnabled = true;
            this.cbClassGroups.Location = new System.Drawing.Point(401, 30);
            this.cbClassGroups.Name = "cbClassGroups";
            this.cbClassGroups.Size = new System.Drawing.Size(121, 21);
            this.cbClassGroups.TabIndex = 3;
            // 
            // btnFindStudentsFromSelectedClassGroup
            // 
            this.btnFindStudentsFromSelectedClassGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindStudentsFromSelectedClassGroup.Location = new System.Drawing.Point(588, 28);
            this.btnFindStudentsFromSelectedClassGroup.Name = "btnFindStudentsFromSelectedClassGroup";
            this.btnFindStudentsFromSelectedClassGroup.Size = new System.Drawing.Size(151, 23);
            this.btnFindStudentsFromSelectedClassGroup.TabIndex = 4;
            this.btnFindStudentsFromSelectedClassGroup.Text = "Find students";
            this.btnFindStudentsFromSelectedClassGroup.UseVisualStyleBackColor = true;
            this.btnFindStudentsFromSelectedClassGroup.Click += new System.EventHandler(this.btnFindStudentsFromSelectedClassGroup_Click);
            // 
            // UCStudentsFromClassGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnFindStudentsFromSelectedClassGroup);
            this.Controls.Add(this.cbClassGroups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStudentsFromSelectedClassgroup);
            this.Name = "UCStudentsFromClassGroup";
            this.Size = new System.Drawing.Size(976, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsFromSelectedClassgroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentsFromSelectedClassgroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClassGroups;
        private System.Windows.Forms.Button btnFindStudentsFromSelectedClassGroup;

        public DataGridView DgvStudentsFromSelectedClassgroup { get => dgvStudentsFromSelectedClassgroup; set => dgvStudentsFromSelectedClassgroup = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox CbClassGroups { get => cbClassGroups; set => cbClassGroups = value; }
        public Button BtnFindStudentsFromSelectedClassGroup { get => btnFindStudentsFromSelectedClassGroup; set => btnFindStudentsFromSelectedClassGroup = value; }
    }
}
