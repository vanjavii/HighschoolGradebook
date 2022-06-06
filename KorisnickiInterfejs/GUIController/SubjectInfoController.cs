using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;

namespace KorisnickiInterfejs.GUIController
{
    public class SubjectInfoController
    {
        private BindingList<Teacher> teachers = new BindingList<Teacher>();

        #region InitData
        public void InitData(UCSubjectInfo uc)
        {
            try
            {
                uc.CbSubjects.DataSource = Communication.Instance.GetAllSubjects();
                uc.TxtDescription.Enabled = false;
                uc.TxtIdSubject.Enabled = false;
                uc.TxtSubject.Enabled = false;
                uc.BtnSaveChanges.Enabled = false;
                uc.BtnChangeDescription.Enabled = false;
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

        #region public void RemoveSelectedSubject(UCSubjectInfo uCSubjectInfo)
        public void RemoveSelectedSubject(UCSubjectInfo u)
        {
            try
            {
                Subject s = (Subject)u.CbSubjects.SelectedItem;
                
                DialogResult res = MessageBox.Show("Are you sure you want to delete this Subject?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    DialogResult decission = MessageBox.Show("There are Teachers on that subject! By deleting Subject you will erase all the Teachers! Are you sure you want to continue?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    Subject selected = (Subject)u.CbSubjects.SelectedItem;
                    teachers = new BindingList<Teacher>(Communication.Instance.GetAllTeachersOnSubject(selected.IdSubject));
                    if (decission == DialogResult.Yes)
                    {                       
                        int check = Communication.Instance.RemoveSubjectAndTeachersOnSubject(selected.IdSubject, teachers);
                        if (check==2)
                        {
                            MessageBox.Show("Subject and all the Teachers are now removed!");
                            u.CbSubjects.SelectedItem = new BindingList<Teacher>();
                            u.DgvTeachersOnSubject.DataSource = null;
                            u.CbSubjects.DataSource = Communication.Instance.GetAllSubjects();
                            u.TxtDescription.Text = "";
                            u.TxtIdSubject.Text = "";
                            u.TxtSubject.Text = ""; 
                        }else if (check == 1)
                        {
                            MessageBox.Show("Problem deleting teachers!");
                        }
                        else
                        {
                            MessageBox.Show("Problem deleting data!!!");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else { return; }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
        #endregion

        #region public void ArrangeFields(UCSubjectInfo uCSubjectInfo)
        public void ArrangeFields(UCSubjectInfo u)
        {
            u.TxtDescription.Enabled = true;
            u.TxtDescription.Clear();
            u.BtnSaveChanges.Enabled = true;
            u.BtnChangeDescription.Enabled = false;
        }
        #endregion

        #region public void SearchForInfo(UCSubjectInfo uCSubjectInfo)
        public void SearchForInfo(UCSubjectInfo u)
        {
            try
            {
                Subject selectedSubject = (Subject)u.CbSubjects.SelectedItem;                
                u.TxtDescription.Text = Communication.Instance.GetLatestSubjectDescription(selectedSubject.IdSubject);
                u.TxtSubject.Text = selectedSubject.SubjectName;
                u.TxtIdSubject.Text = selectedSubject.IdSubject.ToString();
                u.DgvTeachersOnSubject.DataSource = Communication.Instance.GetAllTeachersOnSubject(selectedSubject.IdSubject);
                u.DgvTeachersOnSubject.Columns[8].Visible = false;
                u.DgvTeachersOnSubject.Columns["InsertValues"].Visible = false;
                u.DgvTeachersOnSubject.Columns["TableName"].Visible = false;
                u.BtnChangeDescription.Enabled = true;
                u.DgvTeachersOnSubject.ReadOnly = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion

        #region public void SaveChanges(UCSubjectInfo uCSubjectInfo)
        public void SaveChanges(UCSubjectInfo u)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to save changes in description?", "Saving confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    string newDescription = u.TxtDescription.Text;
                    int subjectId = int.Parse(u.TxtIdSubject.Text);
                    if (Communication.Instance.ChangeSubjectDescription(newDescription, subjectId) == 1)
                    {
                        MessageBox.Show("Description saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Problem saving changed description!");
                    }
                }
                else { return; }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion

        #region DataErrorEvent
        public void DataError(UCSubjectInfo u)
        {
            u.DgvTeachersOnSubject.Columns["InsertValues"].Visible = false;
            u.DgvTeachersOnSubject.Columns["TableName"].Visible = false;
        }
        #endregion
    }
}
