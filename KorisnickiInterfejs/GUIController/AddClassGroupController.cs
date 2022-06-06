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
    public class AddClassGroupController
    {
        private BindingList<Student> students = new BindingList<Student>();        
        public int GeneratedId { get; set; }

        #region InitData
        public void InitData(UCAddClassGroup uc)
        {
            try
            {
                uc.DgvAddStudents.DataSource = students;
                uc.DgvAddStudents.Columns[0].Visible = false;
                uc.DgvAddStudents.Columns[6].Visible = false;
                uc.DgvAddStudents.Columns["InsertValues"].Visible = false;
                uc.DgvAddStudents.Columns["TableName"].Visible = false;
                uc.DgvAddStudents.ReadOnly = true;
                uc.TxtGeneratedId.Enabled = false;
                uc.CbHomeroomTeacher.DataSource = new BindingList<Teacher>(Communication.Instance.GetAllFreeTeachers());
                uc.TxtClassGroupName.Enabled = false;                
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

        #region  public void SaveAll(UCAddClassGroup u)
        public void SaveAll(UCAddClassGroup u)
        {            
            ValidateYear(u);
            GenerateId(u);
            ClassGroupDatabase cg = new ClassGroupDatabase();
            cg.IdClassGroup = GeneratedId;
            cg.Name = u.TxtClassGroupName.Text;

            if (u.RbSocial.Checked)
            {
                cg.Stream = 1;
            }
            if (u.RbMath.Checked)
            {
                cg.Stream = 2;
            }
            if (!u.RbMath.Checked && !u.RbSocial.Checked)
            {
                MessageBox.Show("You must choose the Stream!");
                return;
            }

            Teacher t = (Teacher)u.CbHomeroomTeacher.SelectedItem;

            if (students.Count == 0)
            {
                MessageBox.Show("You cannot save Classgroup without Students!", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to save the Classgroup?", "Saving confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Communication.Instance.AddClassGroup_HomeRoomTeacher_Students(cg, t, students.ToList());
                    u.CbHomeroomTeacher.DataSource = new BindingList<Teacher>(Communication.Instance.GetAllFreeTeachers());
                    MessageBox.Show("ClassGroup saved successfully!"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem saving data!");
                // throw;
            }
        }
        #endregion

        #region public void RemoveSelectedRow(UCAddClassGroup u)
        public void RemoveSelectedRow(UCAddClassGroup u)
        {
            try
            {
                if (u.DgvAddStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("You haven't selected Student!");
                    return;
                }
                Student p = (Student)u.DgvAddStudents.SelectedRows[0].DataBoundItem;
                students.Remove(p);
            }
            catch (Exception)
            {

                //throw;
            }
        }
        #endregion

        #region public void AddStudent(UCAddClassGroup uCAddClassGroup)
        public void AddStudent(UCAddClassGroup uCAddClassGroup)
        {
            FrmAddStudentToClassGroup frm = new FrmAddStudentToClassGroup();
            _AddStudentToClassGroupController c2 = new _AddStudentToClassGroupController();
            if (frm.ShowDialog() == DialogResult.OK)
            {                
                c2.AddStudent(frm);
                Student s = c2.CurrentStudent;
                students.Add(s);
            }
            frm.Dispose();
        }
        #endregion

        #region public void GenerateId(UCAddClassGroup u)
        public void GenerateId(UCAddClassGroup u)
        {
            try
            {
                int generatedId = Communication.Instance.GetFirstFreeClassGroupIdDependingOnYear(int.Parse(u.TxtYearOfStudies.Text));
                if (generatedId == 1)
                {
                    u.TxtGeneratedId.Text = "";
                    u.TxtClassGroupName.Text = "";
                    //throw new Exception();
                }
                else
                {
                    if (generatedId % 10 == 0 && generatedId.ToString().Length == 2)
                    {
                        int _year = (generatedId / 10) - 1;
                        int _num = 10;
                        string _s_year = _year.ToString();
                        string _s_num = _num.ToString();
                        string _full = _s_year + _s_num;
                        u.TxtGeneratedId.Text = _full;
                        GeneratedId = int.Parse(_full);
                    }
                    else
                    {
                        u.TxtGeneratedId.Text = generatedId.ToString();
                        GeneratedId = generatedId;
                    }
                    int genId = GeneratedId;
                    int length = genId.ToString().Length;
                    int year = 0;
                    int num = 0;
                    string full;
                    if (length == 2)
                    {
                        year = genId / 10;
                        num = genId % 10;
                    }
                    else if (length == 3)
                    {
                        year = genId / 100;
                        num = genId % 100;
                    }
                    if (year == 1)
                    {
                        full = "I-" + num.ToString();
                    }
                    else if (year == 2)
                    {
                        full = "II-" + num.ToString();
                    }
                    else if (year == 3)
                    {
                        full = "III-" + num.ToString();
                    }
                    else
                    {
                        full = "IV-" + num.ToString();
                    }
                    u.TxtClassGroupName.Text = full; 
                }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must enter Year!");
                u.TxtClassGroupName.Text = "";
                u.TxtGeneratedId.Text = "";
                //throw;
            }
        }
        #endregion

        #region public void ValidateYear(UCAddClassGroup u)
        public void ValidateYear(UCAddClassGroup u)
        {
            if (string.IsNullOrEmpty(u.TxtYearOfStudies.Text))
            {
                //MessageBox.Show("You need to enter Year!");
                u.TxtYearOfStudies.BackColor = Color.PowderBlue;
                return;
            }
            u.TxtYearOfStudies.BackColor = Color.White;
            if (int.Parse(u.TxtYearOfStudies.Text) > 4 || int.Parse(u.TxtYearOfStudies.Text) < 1)
            {
                MessageBox.Show("Year Of Studies must take value from range [1-4]!");
                u.TxtGeneratedId.Text = "";
                u.TxtClassGroupName.Text = "";
                u.TxtYearOfStudies.BackColor = Color.PowderBlue;
                return;
            }
            u.TxtYearOfStudies.BackColor = Color.White;
        }
        #endregion


        #region DataErrorEvent
        public void DataError(UCAddClassGroup u)
        {
            u.DgvAddStudents.Columns["InsertValues"].Visible = false;
            u.DgvAddStudents.Columns["TableName"].Visible = false;
        }
        #endregion

    }
}
