using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;

namespace KorisnickiInterfejs.GUIController
{
    public class FindClassgroupController
    {
        #region InitData
        public void InitData(UCFindClassgroup uc)
        {
            try
            {
                uc.DgvStudentsFromClassgroup.DataSource = Communication.Instance.GetAllStudents();
                uc.LblFormat.Visible = false;
                uc.LblHomeroomTeacher.Text = "";
                uc.DgvStudentsFromClassgroup.ReadOnly = true;
                uc.DgvStudentsFromClassgroup.Columns["TableName"].Visible = false;
                uc.DgvStudentsFromClassgroup.Columns["InsertValues"].Visible = false;
                //cbSelectClassGroup.DataSource = Controller.Instance.GetAllClassGroups();
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
        List<Student> check;
        #region public void Find(UCFindClassgroup uCFindClassgroup)
        public void Find(UCFindClassgroup u)
        {
            int selectedCG = int.Parse(u.TxtIdClassGroup.Text);
            try
            {
                u.LblFormat.Visible = false;
                check = Communication.Instance.GetStudentsFromSelectedClassGroup(selectedCG);

                if (check==null)
                {
                    System.Windows.Forms.MessageBox.Show("This Classgroup doesn't have any Students!");
                    u.LblHomeroomTeacher.Text = Communication.Instance.GetHomeroomTeacher(selectedCG).ToString();
                    //u.LblHomeroomTeacher.Text = "";
                    u.DgvStudentsFromClassgroup.DataSource = null;
                    return;
                }
                else
                {
                    u.DgvStudentsFromClassgroup.DataSource = Communication.Instance.GetStudentsFromSelectedClassGroup(selectedCG);
                    u.Label3.Visible = true;
                    u.DgvStudentsFromClassgroup.Columns["TableName"].Visible = false;
                    u.DgvStudentsFromClassgroup.Columns["InsertValues"].Visible = false;
                    //u.LblHomeroomTeacher.Text = Communication.Instance.GetHomeroomTeacher(selectedCG).ToString();
                }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED");
                u.LblHomeroomTeacher.Text = "";
            }
            catch (Exception ex)
            {
                u.Label3.Visible = false;
                u.DgvStudentsFromClassgroup.DataSource = null;
                MessageBox.Show("System couldn't find Classgroup with this ID!");
                u.LblFormat.Visible = true;
            }
            try
            {
                u.LblHomeroomTeacher.Text = Communication.Instance.GetHomeroomTeacher(selectedCG).ToString();
            }
            catch (Exception)
            {
                u.Label3.Visible = false;
                u.DgvStudentsFromClassgroup.DataSource = null;
                u.LblHomeroomTeacher.Text = "Unexisting ClassGroup!";
                u.LblHomeroomTeacher.Text = "";
                u.DgvStudentsFromClassgroup.DataSource = null;
                MessageBox.Show("System couldn't find Classgroup with this ID!");
                u.LblFormat.Visible = true;
            }
        }
        #endregion
    }
}
