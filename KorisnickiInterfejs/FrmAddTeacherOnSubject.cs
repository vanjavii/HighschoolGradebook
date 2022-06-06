using Domain;
using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmAddTeacherOnSubject : Form
    {
        _AddTeacherOnSubjectController controller;
     
        public FrmAddTeacherOnSubject()
        {
            InitializeComponent();
            controller = new _AddTeacherOnSubjectController();
        }

        private void btnSaveTeacher_Click(object sender, EventArgs e)
        {
            controller.SaveTeacher(this);            
        }

        private void ValidateTeacher()
        {
            controller.ValidateTeacher(this);            
        }
    }
}
