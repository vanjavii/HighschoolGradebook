using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
    public class AddSubjectController
    {
        BindingList<Teacher> teachers = new BindingList<Teacher>();        

        #region InitData
        public void InitData(UCAddSubject uc)
        {
            try
            {
                uc.DgvTeachersOnSubject.DataSource = teachers;
                uc.DgvTeachersOnSubject.Columns["IdTeacher"].Visible = false;
                uc.DgvTeachersOnSubject.Columns["Subject"].Visible = false;
                uc.DgvTeachersOnSubject.Columns["ClassGroup"].Visible = false;
                uc.DgvTeachersOnSubject.Columns["InsertValues"].Visible = false;
                uc.DgvTeachersOnSubject.Columns["TableName"].Visible = false;
                uc.DgvTeachersOnSubject.ReadOnly = true;
                uc.CbNew.DataSource = Communication.Instance.GetAllClassGroups();                
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

        #region public void btnRemoveRow_Click(UCAddSubject uCAddSubject)
        public void btnRemoveRow_Click(UCAddSubject u)
        {
            try
            {
                if (u.DgvTeachersOnSubject.SelectedRows.Count == 0)
                {
                    MessageBox.Show("You haven't selected any row!");
                    return;
                }
                Teacher t = (Teacher)u.DgvTeachersOnSubject.SelectedRows[0].DataBoundItem;
                teachers.Remove(t);
            }
            catch (Exception)
            {
                //throw;
            }
        }
        #endregion

        #region public void SaveAll(UCAddSubject uCAddSubject)
        public void SaveAll(UCAddSubject u)
        {
            Subject s = new Subject();
            if (String.IsNullOrEmpty(u.TxtSubjectName.Text))
            {                              
                MessageBox.Show("Insert name of the Subject!");
                u.TxtSubjectName.BackColor = Color.PowderBlue;
                return;
            }
            u.TxtSubjectName.BackColor = Color.White;

            if (String.IsNullOrEmpty(u.TxtDescription.Text))
            {
                //s.Description = txtDescription.Text;               
                MessageBox.Show("Insert Description!");
                u.TxtDescription.BackColor = Color.PowderBlue;
                return;
            }
            u.TxtDescription.BackColor = Color.White;
            s.SubjectName = u.TxtSubjectName.Text;
            s.Description = u.TxtDescription.Text;
            
            try
            {
                if (teachers.Count==0)
                {
                    MessageBox.Show("You need to add Teachers!");
                    return;
                }
                
                DialogResult res = MessageBox.Show("Are you sure you want to save this Subject?", "Saving confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) { 
                    int check = Communication.Instance.AddNewSubjectAndTeachers(teachers.ToList(), s);
                    if (check == 1)
                    {
                        MessageBox.Show("Subject and Teachers saved successfully!");//
                    }
                    if (check == 0)
                    {
                        MessageBox.Show("Problem saving data!");
                    }
                }
                else { return;}
            }
            catch
            {
                MessageBox.Show("Problem saving data!");
            }
        }
        #endregion

        #region public void AddTeacher(UCAddSubject uCAddSubject)
        public void AddTeacher(UCAddSubject u)
        {
            FrmAddTeacherOnSubject frm = new FrmAddTeacherOnSubject();
            _AddTeacherOnSubjectController c2 = new _AddTeacherOnSubjectController();/// OVO DODALA
            if (frm.ShowDialog() == DialogResult.OK)
            {                
                c2.SaveTeacher(frm);
                Teacher t = c2.CurrentTeacher;  
                teachers.Add(t);
            }
            frm.Dispose();
        }
        #endregion
    }
}
