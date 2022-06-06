using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLogic;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;

namespace KorisnickiInterfejs.GUIController
{
    public class StudentsFromClassGroupController
    {
        #region InitData
        public void InitData(UCStudentsFromClassGroup uc)
        {
            try
            {
                uc.CbClassGroups.DataSource = Communication.Instance.GetAllClassGroups();
                uc.DgvStudentsFromSelectedClassgroup.DataSource = Communication.Instance.GetAllStudents();
                uc.DgvStudentsFromSelectedClassgroup.Columns[8].Visible = false;
                uc.DgvStudentsFromSelectedClassgroup.Columns[9].Visible = false;
                //uc.DgvStudentsFromSelectedClassgroup.Columns[1].Visible = false;
                uc.DgvStudentsFromSelectedClassgroup.ReadOnly = true;
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region public void FindStudentsFromSelectedClassGroup(UCStudentsFromClassGroup uCStudentsFromClassGroup)
        public void FindStudentsFromSelectedClassGroup(UCStudentsFromClassGroup u)
        {
            try
            {
                ClassGroupDatabase selectedClassGroup = (ClassGroupDatabase)u.CbClassGroups.SelectedItem;
                int selected = selectedClassGroup.IdClassGroup;
                u.DgvStudentsFromSelectedClassgroup.DataSource = Communication.Instance.GetStudentsFromSelectedClassGroup(selected);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion
    }
}
