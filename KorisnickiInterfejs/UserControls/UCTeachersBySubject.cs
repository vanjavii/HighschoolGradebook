using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLogic;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCTeachersBySubject : UserControl
    {
        TeachersBySubjectController controller;
        
        public UCTeachersBySubject()
        {
            InitializeComponent();
            controller = new TeachersBySubjectController();
            controller.InitData(this);            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            controller.Find(this);            
        }

        private void btnRemoveSelectedTeacher_Click(object sender, EventArgs e)
        {
            controller.RemoveSelectedTeacher(this);            
        }

        private void dgvTeachersBySubject_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            controller.DataError(this);
        }
    }
}
