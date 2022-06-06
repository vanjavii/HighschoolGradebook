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
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCAddSubject : UserControl
    {
        AddSubjectController controller;
        
        public UCAddSubject()
        {
            InitializeComponent();
            controller = new AddSubjectController();
            controller.InitData(this);            
        }
        
        private void teacherDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            controller.btnRemoveRow_Click(this);            
        }        
                
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            controller.SaveAll(this);            
        }          

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            controller.AddTeacher(this);            
        }
    }
}
