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
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.Exceptions;

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCChangeStudent : UserControl
    {
        ChangeStudentController controller;
        public UCChangeStudent()
        {
            InitializeComponent();
            controller = new ChangeStudentController();
            controller.InitData(this);              
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            controller.FindStudent(this);            
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            controller.ChangeStudentInfo(this);            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            controller.SaveChanges(this);            
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            controller.RemoveStudent(this);           
        }
    }
}
