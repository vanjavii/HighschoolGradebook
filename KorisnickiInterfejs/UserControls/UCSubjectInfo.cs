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
    public partial class UCSubjectInfo : UserControl
    {
        SubjectInfoController controller;
        private BindingList<Teacher> teachers=new BindingList<Teacher>();
        public UCSubjectInfo()
        {
            InitializeComponent();
            controller = new SubjectInfoController();
            controller.InitData(this);            
        }

        private void btnSearchForInfo_Click(object sender, EventArgs e)
        {
            controller.SearchForInfo(this);            
        }

        private void btnChangeDescription_Click(object sender, EventArgs e)
        {
            controller.ArrangeFields(this);            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            controller.SaveChanges(this);            
            Refresh();
        }

        private void btnRemoveSelectedSubject_Click(object sender, EventArgs e)
        {
            controller.RemoveSelectedSubject(this);         
        }

        private void dgvTeachersOnSubject_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            controller.DataError(this);
        }
    }
}
