using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmLogin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lblNoUsername = new System.Windows.Forms.Label();
            this.lblNoPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(89, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(89, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(167, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 20);
            this.txtUsername.TabIndex = 2;
            //this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(167, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 3;
            //this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogin.Location = new System.Drawing.Point(206, 177);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblNoUsername
            // 
            this.lblNoUsername.AutoSize = true;
            this.lblNoUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNoUsername.Location = new System.Drawing.Point(168, 85);
            this.lblNoUsername.Name = "lblNoUsername";
            this.lblNoUsername.Size = new System.Drawing.Size(35, 13);
            this.lblNoUsername.TabIndex = 5;
            this.lblNoUsername.Text = "label3";
            this.lblNoUsername.Visible = false;
            // 
            // lblNoPassword
            // 
            this.lblNoPassword.AutoSize = true;
            this.lblNoPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNoPassword.Location = new System.Drawing.Point(168, 156);
            this.lblNoPassword.Name = "lblNoPassword";
            this.lblNoPassword.Size = new System.Drawing.Size(35, 13);
            this.lblNoPassword.TabIndex = 6;
            this.lblNoPassword.Text = "label3";
            this.lblNoPassword.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.pastel_blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 255);
            this.Controls.Add(this.lblNoPassword);
            this.Controls.Add(this.lblNoUsername);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label lblNoUsername;
        private System.Windows.Forms.Label lblNoPassword;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Button BtnLogin1 { get => BtnLogin; set => BtnLogin = value; }
        public Label LblNoUsername { get => lblNoUsername; set => lblNoUsername = value; }
        public Label LblNoPassword { get => lblNoPassword; set => lblNoPassword = value; }
    }
}