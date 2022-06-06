using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uceniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProfessorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClassGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findClassGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.succesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSuccessReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concludedMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.calToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblUserLogged = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uceniciToolStripMenuItem,
            this.professorsToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.classGroupsToolStripMenuItem,
            this.classToolStripMenuItem,
            this.succesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uceniciToolStripMenuItem
            // 
            this.uceniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.showStudentsToolStripMenuItem,
            this.findStudentToolStripMenuItem});
            this.uceniciToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uceniciToolStripMenuItem.Name = "uceniciToolStripMenuItem";
            this.uceniciToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.uceniciToolStripMenuItem.Text = "Students";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addStudentToolStripMenuItem.Text = "Add student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // showStudentsToolStripMenuItem
            // 
            this.showStudentsToolStripMenuItem.Name = "showStudentsToolStripMenuItem";
            this.showStudentsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.showStudentsToolStripMenuItem.Text = "Show students";
            this.showStudentsToolStripMenuItem.Click += new System.EventHandler(this.showStudentsToolStripMenuItem_Click);
            // 
            // findStudentToolStripMenuItem
            // 
            this.findStudentToolStripMenuItem.Name = "findStudentToolStripMenuItem";
            this.findStudentToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.findStudentToolStripMenuItem.Text = "Find student";
            this.findStudentToolStripMenuItem.Click += new System.EventHandler(this.findStudentToolStripMenuItem_Click);
            // 
            // professorsToolStripMenuItem
            // 
            this.professorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProfessorToolStripMenuItem,
            this.showProfessorsToolStripMenuItem});
            this.professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            this.professorsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.professorsToolStripMenuItem.Text = "Teachers";
            // 
            // addProfessorToolStripMenuItem
            // 
            this.addProfessorToolStripMenuItem.Name = "addProfessorToolStripMenuItem";
            this.addProfessorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addProfessorToolStripMenuItem.Text = "Add Teacher";
            this.addProfessorToolStripMenuItem.Click += new System.EventHandler(this.addProfessorToolStripMenuItem_Click);
            // 
            // showProfessorsToolStripMenuItem
            // 
            this.showProfessorsToolStripMenuItem.Name = "showProfessorsToolStripMenuItem";
            this.showProfessorsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.showProfessorsToolStripMenuItem.Text = "Show Teachers";
            this.showProfessorsToolStripMenuItem.Click += new System.EventHandler(this.showProfessorsToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSubjectsToolStripMenuItem,
            this.addSubjectToolStripMenuItem});
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // viewSubjectsToolStripMenuItem
            // 
            this.viewSubjectsToolStripMenuItem.Name = "viewSubjectsToolStripMenuItem";
            this.viewSubjectsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.viewSubjectsToolStripMenuItem.Text = "View subjects";
            this.viewSubjectsToolStripMenuItem.Click += new System.EventHandler(this.viewSubjectsToolStripMenuItem_Click);
            // 
            // addSubjectToolStripMenuItem
            // 
            this.addSubjectToolStripMenuItem.Name = "addSubjectToolStripMenuItem";
            this.addSubjectToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addSubjectToolStripMenuItem.Text = "Add subject";
            this.addSubjectToolStripMenuItem.Click += new System.EventHandler(this.addSubjectToolStripMenuItem_Click);
            // 
            // classGroupsToolStripMenuItem
            // 
            this.classGroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClassGroupToolStripMenuItem,
            this.findClassGroupToolStripMenuItem});
            this.classGroupsToolStripMenuItem.Name = "classGroupsToolStripMenuItem";
            this.classGroupsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.classGroupsToolStripMenuItem.Text = "Class Groups";
            // 
            // addNewClassGroupToolStripMenuItem
            // 
            this.addNewClassGroupToolStripMenuItem.Name = "addNewClassGroupToolStripMenuItem";
            this.addNewClassGroupToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addNewClassGroupToolStripMenuItem.Text = "Add new Class group";
            this.addNewClassGroupToolStripMenuItem.Click += new System.EventHandler(this.addNewClassGroupToolStripMenuItem_Click);
            // 
            // findClassGroupToolStripMenuItem
            // 
            this.findClassGroupToolStripMenuItem.Name = "findClassGroupToolStripMenuItem";
            this.findClassGroupToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.findClassGroupToolStripMenuItem.Text = "Find Class group";
            this.findClassGroupToolStripMenuItem.Click += new System.EventHandler(this.findClassGroupToolStripMenuItem_Click);
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassToolStripMenuItem});
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.classToolStripMenuItem.Text = "Class";
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addClassToolStripMenuItem.Text = "Add class";
            this.addClassToolStripMenuItem.Click += new System.EventHandler(this.addClassToolStripMenuItem_Click);
            // 
            // succesToolStripMenuItem
            // 
            this.succesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSuccessReportToolStripMenuItem,
            this.concludedMarksToolStripMenuItem});
            this.succesToolStripMenuItem.Name = "succesToolStripMenuItem";
            this.succesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.succesToolStripMenuItem.Text = "Success report";
            // 
            // createSuccessReportToolStripMenuItem
            // 
            this.createSuccessReportToolStripMenuItem.Name = "createSuccessReportToolStripMenuItem";
            this.createSuccessReportToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.createSuccessReportToolStripMenuItem.Text = "Create Success report";
            this.createSuccessReportToolStripMenuItem.Click += new System.EventHandler(this.createSuccessReportToolStripMenuItem_Click);
            // 
            // concludedMarksToolStripMenuItem
            // 
            this.concludedMarksToolStripMenuItem.Name = "concludedMarksToolStripMenuItem";
            this.concludedMarksToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.concludedMarksToolStripMenuItem.Text = "Concluded Marks";
            this.concludedMarksToolStripMenuItem.Click += new System.EventHandler(this.concludedMarksToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "My profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calToolStripMenuItem
            // 
            this.calToolStripMenuItem.Name = "calToolStripMenuItem";
            this.calToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.calToolStripMenuItem.Text = "Cal";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMain.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.School_hallway;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.lblUserLogged);
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(971, 495);
            this.pnlMain.TabIndex = 1;
            //this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // lblUserLogged
            // 
            this.lblUserLogged.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserLogged.AutoSize = true;
            this.lblUserLogged.BackColor = System.Drawing.Color.Transparent;
            this.lblUserLogged.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogged.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblUserLogged.Location = new System.Drawing.Point(379, 399);
            this.lblUserLogged.Name = "lblUserLogged";
            this.lblUserLogged.Size = new System.Drawing.Size(0, 43);
            this.lblUserLogged.TabIndex = 1;
            //this.lblUserLogged.Click += new System.EventHandler(this.lblUserLogged_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblWelcome.Location = new System.Drawing.Point(393, 344);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(197, 43);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome,";
            //this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uceniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProfessorsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem addSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClassGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findClassGroupToolStripMenuItem;
        private System.Windows.Forms.Label lblUserLogged;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem succesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSuccessReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concludedMarksToolStripMenuItem;

        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem UceniciToolStripMenuItem { get => uceniciToolStripMenuItem; set => uceniciToolStripMenuItem = value; }
        public ToolStripMenuItem AddStudentToolStripMenuItem { get => addStudentToolStripMenuItem; set => addStudentToolStripMenuItem = value; }
        public ToolStripMenuItem ShowStudentsToolStripMenuItem { get => showStudentsToolStripMenuItem; set => showStudentsToolStripMenuItem = value; }
        public ToolStripMenuItem FindStudentToolStripMenuItem { get => findStudentToolStripMenuItem; set => findStudentToolStripMenuItem = value; }
        public ToolStripMenuItem SubjectsToolStripMenuItem { get => subjectsToolStripMenuItem; set => subjectsToolStripMenuItem = value; }
        public ToolStripMenuItem ViewSubjectsToolStripMenuItem { get => viewSubjectsToolStripMenuItem; set => viewSubjectsToolStripMenuItem = value; }
        public ToolStripMenuItem ProfessorsToolStripMenuItem { get => professorsToolStripMenuItem; set => professorsToolStripMenuItem = value; }
        public ToolStripMenuItem AddProfessorToolStripMenuItem { get => addProfessorToolStripMenuItem; set => addProfessorToolStripMenuItem = value; }
        public ToolStripMenuItem ShowProfessorsToolStripMenuItem { get => showProfessorsToolStripMenuItem; set => showProfessorsToolStripMenuItem = value; }
        public Panel PnlMain { get => pnlMain; set => pnlMain = value; }
        public Button Button1 { get => button1; set => button1 = value; }
        public ToolStripMenuItem AddSubjectToolStripMenuItem { get => addSubjectToolStripMenuItem; set => addSubjectToolStripMenuItem = value; }
        public ToolStripMenuItem ClassGroupsToolStripMenuItem { get => classGroupsToolStripMenuItem; set => classGroupsToolStripMenuItem = value; }
        public ToolStripMenuItem AddNewClassGroupToolStripMenuItem { get => addNewClassGroupToolStripMenuItem; set => addNewClassGroupToolStripMenuItem = value; }
        public ToolStripMenuItem FindClassGroupToolStripMenuItem { get => findClassGroupToolStripMenuItem; set => findClassGroupToolStripMenuItem = value; }
        public Label LblUserLogged { get => lblUserLogged; set => lblUserLogged = value; }
        public Label LblWelcome { get => lblWelcome; set => lblWelcome = value; }
        public ToolStripMenuItem SuccesToolStripMenuItem { get => succesToolStripMenuItem; set => succesToolStripMenuItem = value; }
        public ToolStripMenuItem CreateSuccessReportToolStripMenuItem { get => createSuccessReportToolStripMenuItem; set => createSuccessReportToolStripMenuItem = value; }
        public ToolStripMenuItem ToolStripMenuItem1 { get => toolStripMenuItem1; set => toolStripMenuItem1 = value; }
        public ToolStripMenuItem ClassToolStripMenuItem { get => classToolStripMenuItem; set => classToolStripMenuItem = value; }
        public ToolStripMenuItem AddClassToolStripMenuItem { get => addClassToolStripMenuItem; set => addClassToolStripMenuItem = value; }
        public ToolStripMenuItem CalToolStripMenuItem { get => calToolStripMenuItem; set => calToolStripMenuItem = value; }
        public ToolStripMenuItem ConcludedMarksToolStripMenuItem { get => concludedMarksToolStripMenuItem; set => concludedMarksToolStripMenuItem = value; }
    }
}

