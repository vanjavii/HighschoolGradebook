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
    public partial class FrmAddClass : Form
    {
        _AddClassController controller;        

        public FrmAddClass()
        {
            InitializeComponent();
            controller = new _AddClassController();
            controller.InitData(this);            
        }

        private void cbSubjects_SelectedValueChanged(object sender, EventArgs e)
        {
            controller.cbSubjects_SelectedValueChanged(this);           
        }

        private void btnGetStudents_Click(object sender, EventArgs e)
        {
            controller.GetStudents(this);            
        }

        private void dgvStudentsFromSelectedClassGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.dgvStudentsFromSelectedClassGroup_CellDoubleClick(this);            
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            controller.SaveAll(this);           
        }

        #region RemoveRow
        private void btnRemoveSelectedRow_Click(object sender, EventArgs e)
        {
            controller.RemoveSelectedRow(this);  
        }
        #endregion

        #region FillComboBox()
        public void FillComboBox()
        {
            controller.FillComboBox(this);            
        }
        #endregion

        private void txtClassGroupID_TextChanged(object sender, EventArgs e)
        {
            controller.txtClassGroupID_TextChanged(this);            
        }

        private void dgvStudentsFromSelectedClassGroup_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }
    }
}
