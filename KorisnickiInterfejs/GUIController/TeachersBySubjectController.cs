using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;
using ApplicationLogic;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;

namespace KorisnickiInterfejs.GUIController
{
    public class TeachersBySubjectController
    {
        BindingList<Teacher> teachers;// = new BindingList<Teacher>(Communication.Instance.GetAllTeachersWithoutClassGroup());
        bool criteriaUsed = false;
        #region InitData
        public void InitData(UCTeachersBySubject uc)
        {
            try
            {
                teachers = new BindingList<Teacher>(Communication.Instance.GetAllTeachersWithoutClassGroup());
                uc.CbChooseSubject.DataSource = Communication.Instance.GetAllSubjects();
                uc.DgvTeachersBySubject.DataSource = teachers;                
                uc.DgvTeachersBySubject.ReadOnly = true;
                uc.DgvTeachersBySubject.Columns[8].Visible = false;
                uc.DgvTeachersBySubject.Columns[9].Visible = false;
                uc.DgvTeachersBySubject.Columns[10].Visible = false;                
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region public void Find(UCTeachersBySubject uCTeachersBySubject)
        public void Find(UCTeachersBySubject u)
        {
            try
            {
                Subject selectedSubject = (Subject)u.CbChooseSubject.SelectedItem;
                int selectedSubjectId = selectedSubject.IdSubject;
                u.DgvTeachersBySubject.DataSource = new BindingList<Teacher>(Communication.Instance.GetAllTeachersOnSubject(selectedSubjectId));
                u.DgvTeachersBySubject.Columns[8].Visible = false;
                criteriaUsed = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion

        #region public void RemoveSelectedTeacher(UCTeachersBySubject uCTeachersBySubject)
        public void RemoveSelectedTeacher(UCTeachersBySubject u)
        {
            try
            {
                try
                {
                    if (u.DgvTeachersBySubject.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("You haven't selected row to delete!");
                        return;
                    }
                }
                catch (Exception)
                {
                    
                }
                Teacher selectedTeacher = (Teacher)u.DgvTeachersBySubject.SelectedRows[0].DataBoundItem;
                DialogResult res = MessageBox.Show("Are you sure you want to delete this Teacher?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (Controller.Instance.RemoveTeacherWithId(selectedTeacher.IdTeacher) == 1)
                    {
                        if (criteriaUsed == false)
                        {
                            u.DgvTeachersBySubject.Refresh();
                            teachers.Remove(selectedTeacher);
                        }
                        else if (criteriaUsed == true)
                        {
                            Subject selectedSubject = (Subject)u.CbChooseSubject.SelectedItem;
                            int selectedSubjectId = selectedSubject.IdSubject;
                            u.DgvTeachersBySubject.DataSource = Communication.Instance.GetAllTeachersOnSubject(selectedSubjectId);
                        }
                        MessageBox.Show("Teacher removed successfully!");
                    }
                    else
                    {
                        //MessageBox.Show("Problem removing Teacher!");
                        throw new ServerCommunicationException();
                    }
                }
                else { return; }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        #endregion

        #region public void DataError(UCTeachersBySubject uc)
        public void DataError(UCTeachersBySubject uc)
        {
            uc.DgvTeachersBySubject.Columns[8].Visible = false;
            uc.DgvTeachersBySubject.Columns[9].Visible = false;
            uc.DgvTeachersBySubject.Columns[10].Visible = false;
        }
        #endregion
    }
}
