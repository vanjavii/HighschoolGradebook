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
using ApplicationLogic;
using System.ComponentModel.DataAnnotations;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCAddStudentWithValidation : UserControl
    {
        AddStudentWithValidationController controller;
        public UCAddStudentWithValidation()
        {
            InitializeComponent();
            controller = new AddStudentWithValidationController();
            controller.InitData(this);            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            controller.GetClassGroupsFromSelectedYear(this);       
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            controller.AddStudent(this);           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Go(this);
        }
    }
}
