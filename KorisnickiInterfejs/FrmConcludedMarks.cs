using ApplicationLogic;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmConcludedMarks : Form
    {
        _ConcludedMarksController controller;
        
        public FrmConcludedMarks()
        {
            InitializeComponent();
            controller = new _ConcludedMarksController();
            controller.InitData(this);            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            controller.FindStudent(this);            
        }
    }
}
