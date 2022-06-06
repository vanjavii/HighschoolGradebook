using ApplicationLogic;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmMain : Form
    {
        _MainController controller;
        public FrmMain()
        {
            InitializeComponent();
            controller = new _MainController();
            controller.InitData(this);            
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePanel(new UCAddStudentWithValidation());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMyProfile frmMyProfile = new FrmMyProfile();
                frmMyProfile.ShowDialog();
            }
            catch (ServerCommunicationException) {                
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!","SERVER STOPPED",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void showStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePanel(new UCStudentsFromClassGroup());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void addProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            try
            {
                ChangePanel(new UCAddTeacherWithValidation());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void showProfessorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePanel(new UCTeachersBySubject());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void viewSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            try
            {
                ChangePanel(new UCSubjectInfo());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void findStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            try
            {
                ChangePanel(new UCChangeStudent());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePanel(new UCAddSubject());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }         
        }

        private void addNewClassGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            try
            {
                ChangePanel(new UCAddClassGroup());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void findClassGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePanel(new UCFindClassgroup());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

       
        private void createSuccessReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSuccessReport frmSuccessReport = new FrmSuccessReport();
                frmSuccessReport.ShowDialog();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddClass frmAddClass = new FrmAddClass();
                frmAddClass.ShowDialog();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void ChangePanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }

        private void concludedMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConcludedMarks frmConcludedMarks = new FrmConcludedMarks();
                frmConcludedMarks.ShowDialog();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.FrmMain_FormClosed(this);            
        }
    }
}
