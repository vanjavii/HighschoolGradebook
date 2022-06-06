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
using System.Diagnostics;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCAddClassGroup : UserControl
    {
        AddClassGroupController controller;
        //private BindingList<Student> students = new BindingList<Student>();
        //public int GeneratedId { get; set; }

        public UCAddClassGroup()
        {
            InitializeComponent();
            controller = new AddClassGroupController();
            controller.InitData(this);            
        }

        #region  btnRemoveSelectedRow_Click
        private void btnRemoveSelectedRow_Click(object sender, EventArgs e)
        {
            controller.RemoveSelectedRow(this);
            //if (dgvAddStudents.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("You haven't selected Student!");
            //    return;
            //}
            //Student p = (Student)dgvAddStudents.SelectedRows[0].DataBoundItem;
            //students.Remove(p);
        }
        #endregion

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            controller.AddStudent(this);           
        }         

        #region GenerateId
        private void btnGenerateId_Click(object sender, EventArgs e)
        {
            controller.ValidateYear(this);
            controller.GenerateId(this);              
        }
        #endregion

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            controller.SaveAll(this);
        }

        private void dgvAddStudents_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            controller.DataError(this);
        }
    }
}
