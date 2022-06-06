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
    public partial class FrmSuccessReport : Form
    {
        _SuccessReportController controller;
        
        public FrmSuccessReport()
        {
            InitializeComponent();
            controller = new _SuccessReportController();
            controller.InitData(this);            
        }
        
        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            controller.FindStudent(this);            
        }

        private void cbChooseSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.cbChooseSubject_SelectedIndexChanged(this);    
        }

        private void FillComboBox()
        {
            controller.FillComboBox(this);            
        }

        private void btnConcludeMark_Click(object sender, EventArgs e)
        {
            controller.ConcludeMark(this);           
        }

       
    }
}
