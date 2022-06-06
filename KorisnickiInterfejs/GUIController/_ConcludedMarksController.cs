using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace KorisnickiInterfejs.GUIController
{
    public class _ConcludedMarksController
    {
        BindingList<Mark> marks = new BindingList<Mark>();
        public Student CurrentStudent { get; set; }

        #region InitData
        public void InitData(FrmConcludedMarks f)
        {
            try
            {
                f.DgvConcludedMarks.DataSource = marks;
                f.DgvConcludedMarks.Columns[1].Visible = false;
                f.DgvConcludedMarks.Columns[3].Visible = false;
                f.DgvConcludedMarks.Columns[4].Visible = false;
                f.DgvConcludedMarks.Columns[5].Visible = false;
                f.DgvConcludedMarks.Columns["TableName"].Visible = false;
                f.DgvConcludedMarks.Columns["InsertValues"].Visible = false;
                f.LblStudentFirstNameLastName.Visible = false;
                f.LblStudent.Visible = false;
                f.LblClassGroupValue.Visible = false;
                f.LblClassGroup.Visible = false;
                f.CbNew.DataSource = Communication.Instance.GetAllClassGroups();
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

        #region public void FindStudent(FrmConcludedMarks frmConcludedMarks)
        public void FindStudent(FrmConcludedMarks f)
        {            
            #region manipulacija sa poljima
            if (string.IsNullOrEmpty(f.TxtJMBGtoSearch.Text) && string.IsNullOrEmpty(f.TxtName.Text) && string.IsNullOrEmpty(f.TxtStudentId.Text))
            {
                MessageBox.Show("You need to insert some criteria for search!");
                return;
            }
            if (!string.IsNullOrEmpty(f.TxtJMBGtoSearch.Text) && !string.IsNullOrEmpty(f.TxtName.Text) && !string.IsNullOrEmpty(f.TxtStudentId.Text))
            {
                MessageBox.Show("You are allowed to insert only one search criteria, empty other fields!");
                return;
            }
            if (string.IsNullOrEmpty(f.TxtJMBGtoSearch.Text) && !string.IsNullOrEmpty(f.TxtName.Text) && !string.IsNullOrEmpty(f.TxtStudentId.Text))
            {
                MessageBox.Show("You are allowed to insert only one search criteria, empty other fields!");
                return;
            }
            if (!string.IsNullOrEmpty(f.TxtJMBGtoSearch.Text) && string.IsNullOrEmpty(f.TxtName.Text) && !string.IsNullOrEmpty(f.TxtStudentId.Text))
            {
                MessageBox.Show("You are allowed to insert only one search criteria, empty other fields!");
                return;
            }
            if (!string.IsNullOrEmpty(f.TxtJMBGtoSearch.Text) && !string.IsNullOrEmpty(f.TxtName.Text) && string.IsNullOrEmpty(f.TxtStudentId.Text))
            {
                MessageBox.Show("You are allowed to insert only one search criteria, empty other fields!");
                return;
            }
            #endregion
            #region FindByID
            if (!string.IsNullOrEmpty(f.TxtStudentId.Text) && string.IsNullOrEmpty(f.TxtName.Text) && string.IsNullOrEmpty(f.TxtJMBGtoSearch.Text))
            {
                try
                {
                    Student s = Communication.Instance.FindStudentById(int.Parse(f.TxtStudentId.Text));
                    CurrentStudent = s;
                    f.LblStudentFirstNameLastName.Text = s.FirstName + " " + s.LastName;
                    f.LblClassGroupValue.Text = s.ClassGroup.Name;
                    f.LblStudentFirstNameLastName.Visible = true;
                    f.LblStudent.Visible = true;
                    f.LblClassGroupValue.Visible = true;
                    f.LblClassGroup.Visible = true;
                    BindingList<Mark> marksList = new BindingList<Mark>(Communication.Instance.GetAllConcludedMarksFromStudent(int.Parse(f.TxtStudentId.Text)));
                    f.DgvConcludedMarks.DataSource = marksList;
                    if (marksList.Count == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("This Student doesn't have any concluded Mark yet!");
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!");
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Student with this ID doesn't exist!");
                    //throw;
                } 
            }
            #endregion
            #region FindByJMBG
            if (string.IsNullOrEmpty(f.TxtStudentId.Text) && string.IsNullOrEmpty(f.TxtName.Text) && !string.IsNullOrEmpty(f.TxtJMBGtoSearch.Text))
            {
                try
                {
                    if (f.TxtJMBGtoSearch.Text.Length != 13)
                    {
                        MessageBox.Show("JMBG must contain 13 digits!");
                        return;
                    }
                    if (!Regex.Match(f.TxtJMBGtoSearch.Text, "[0-9]{13}").Success)
                    {
                        MessageBox.Show("JMBG contains of digits only!");
                        return;
                    }
                    string jmbg = f.TxtJMBGtoSearch.Text;
                    Student s = Communication.Instance.FindStudentByJMBG(jmbg);
                    CurrentStudent = s;
                    f.LblStudentFirstNameLastName.Text = s.FirstName + " " + s.LastName;
                    f.LblClassGroupValue.Text = s.ClassGroup.Name;
                    f.LblStudentFirstNameLastName.Visible = true;
                    f.LblStudent.Visible = true;
                    f.LblClassGroupValue.Visible = true;
                    f.LblClassGroup.Visible = true;
                    //BindingList<Mark> marksList = new BindingList<Mark>(Communication.Instance.GetAllConcludedMarksFromStudent(int.Parse(f.TxtStudentId.Text)));
                    BindingList<Mark> marksList = new BindingList<Mark>(Communication.Instance.GetAllConcludedMarksFromStudent(CurrentStudent.IdStudent));
                    f.DgvConcludedMarks.DataSource = marksList;
                    if (marksList.Count == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("This Student doesn't have any concluded Mark yet!");
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!");
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Student with this JMBG doesn't exist!");
                    //throw;
                }
            }
            #endregion
            #region FindByName
            if (string.IsNullOrEmpty(f.TxtStudentId.Text) && !string.IsNullOrEmpty(f.TxtName.Text) && string.IsNullOrEmpty(f.TxtJMBGtoSearch.Text))
            {
                try
                {
                    if (!f.TxtName.Text.Contains(' '))
                    {
                        MessageBox.Show("You need to insert first and lastname divided by space!");
                        return;
                    }
                    string studentName = f.TxtName.Text;
                    Student s = Communication.Instance.FindStudentByName(studentName);
                    CurrentStudent = s;
                    f.LblStudentFirstNameLastName.Text = s.FirstName + " " + s.LastName;
                    f.LblClassGroupValue.Text = s.ClassGroup.Name;
                    f.LblStudentFirstNameLastName.Visible = true;
                    f.LblStudent.Visible = true;
                    f.LblClassGroupValue.Visible = true;
                    f.LblClassGroup.Visible = true;
                    //BindingList<Mark> marksList = new BindingList<Mark>(Communication.Instance.GetAllConcludedMarksFromStudent(int.Parse(f.TxtStudentId.Text)));
                    BindingList<Mark> marksList = new BindingList<Mark>(Communication.Instance.GetAllConcludedMarksFromStudent(CurrentStudent.IdStudent));
                    f.DgvConcludedMarks.DataSource = marksList;
                    if (marksList.Count == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("This Student doesn't have any concluded Mark yet!");
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!");
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Student with this Name doesn't exist!");
                    //throw;
                }
            }
            #endregion
        }
        #endregion
    }
}
