using Domain;
using KorisnickiInterfejs.GUIController;
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
    public partial class FrmAddStudentToClassGroup : Form
    {
        _AddStudentToClassGroupController controller;
        
        public FrmAddStudentToClassGroup()
        {
            InitializeComponent();
            controller = new _AddStudentToClassGroupController();            
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            controller.AddStudent(this);            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            controller.Go(this);
        }
    }
}
