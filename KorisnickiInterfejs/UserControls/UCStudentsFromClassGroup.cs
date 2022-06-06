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
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCStudentsFromClassGroup : UserControl
    {
        private StudentsFromClassGroupController controller;       
        public UCStudentsFromClassGroup()
        {
            InitializeComponent();
            controller = new StudentsFromClassGroupController();
            controller.InitData(this);            
        }

        private void btnFindStudentsFromSelectedClassGroup_Click(object sender, EventArgs e)
        {
            controller.FindStudentsFromSelectedClassGroup(this);            
        }
    }
}
