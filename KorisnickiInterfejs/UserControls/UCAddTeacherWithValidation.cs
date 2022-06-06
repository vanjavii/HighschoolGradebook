using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using System.ComponentModel.DataAnnotations;
using ApplicationLogic;
using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.Exceptions;

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCAddTeacherWithValidation : UserControl
    {
        AddTeacherWithValidationController controller;

        public UCAddTeacherWithValidation()
        {
            InitializeComponent();
            controller = new AddTeacherWithValidationController();
            controller.InitData(this);            
        }

        private void btnSaveTeacher_Click(object sender, EventArgs e)
        {
            controller.AddTeacher(this);            
        }           
       
    }
}
