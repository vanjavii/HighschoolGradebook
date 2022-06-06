using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmMyProfile
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblMyId = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSaveNewPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "My ID:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(56, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(56, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(262, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(262, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePassword.Location = new System.Drawing.Point(180, 152);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(140, 23);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(142, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "label6";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(142, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(35, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "label6";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(349, 62);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "label6";
            // 
            // lblMyId
            // 
            this.lblMyId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMyId.AutoSize = true;
            this.lblMyId.BackColor = System.Drawing.Color.Transparent;
            this.lblMyId.Location = new System.Drawing.Point(262, 22);
            this.lblMyId.Name = "lblMyId";
            this.lblMyId.Size = new System.Drawing.Size(35, 13);
            this.lblMyId.TabIndex = 10;
            this.lblMyId.Text = "label6";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(352, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // btnSaveNewPassword
            // 
            this.btnSaveNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveNewPassword.Location = new System.Drawing.Point(326, 152);
            this.btnSaveNewPassword.Name = "btnSaveNewPassword";
            this.btnSaveNewPassword.Size = new System.Drawing.Size(140, 23);
            this.btnSaveNewPassword.TabIndex = 12;
            this.btnSaveNewPassword.Text = "Save new password";
            this.btnSaveNewPassword.UseVisualStyleBackColor = true;
            this.btnSaveNewPassword.Visible = false;
            this.btnSaveNewPassword.Click += new System.EventHandler(this.btnSaveNewPassword_Click);
            // 
            // FrmMyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.pastel_blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 203);
            this.Controls.Add(this.btnSaveNewPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblMyId);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Profile Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMyId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSaveNewPassword;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnChangePassword { get => btnChangePassword; set => btnChangePassword = value; }
        public Label LblFirstName { get => lblFirstName; set => lblFirstName = value; }
        public Label LblLastName { get => lblLastName; set => lblLastName = value; }
        public Label LblUsername { get => lblUsername; set => lblUsername = value; }
        public Label LblMyId { get => lblMyId; set => lblMyId = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Button BtnSaveNewPassword { get => btnSaveNewPassword; set => btnSaveNewPassword = value; }
    }
}