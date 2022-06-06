using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class _SuccessReportController
    {
        BindingList<Mark> marks = new BindingList<Mark>();
        //int helper = 0;
        Student s;
        public Student CurrentStudent { get; set; }

        #region InitData
        public void InitData(FrmSuccessReport f)
        {
            try
            {
                f.GbMarksBySubject.Enabled = false;
                #region manipulacije sa poljima forme
                f.LblClassGroup.Visible = false;
                f.LblFirstName.Visible = false;
                f.LblStream.Visible = false;
                f.LblLastName.Visible = false;
                f.TxtFirstName.Visible = false;
                f.TxtLastName.Visible = false;
                f.TxtStream.Visible = false;
                f.TxtClassGroup.Visible = false;
                f.DgvMarksOfStudent.DataSource = marks;
                //dgvMarksOfStudent.Columns[0].DataPropertyName = "Subject";
                //dgvMarksOfStudent.Columns[0].Width = 100;
                f.DgvMarksOfStudent.Columns[3].Width = 200;
                f.DgvMarksOfStudent.Columns[4].Width = 200;
                f.DgvMarksOfStudent.Columns[1].Visible = false;
                f.DgvMarksOfStudent.Columns["IsFinal"].Visible = false;
                f.DgvMarksOfStudent.Columns["TableName"].Visible = false;
                f.DgvMarksOfStudent.Columns["InsertValues"].Visible = false;
                f.DgvMarksOfStudent.Columns["Class"].Visible = false;
                f.DgvMarksOfStudent.ReadOnly = true;
                f.TxtAverage.Enabled = false;
                f.CbNew.DataSource = Communication.Instance.GetAllClassGroups();
                #endregion
                //f.GbMarksBySubject.Enabled = false;
                //Timer timer = new Timer();
                //timer.Tick += ChangeAverageMark;
                //timer.Interval = 1000;
                //timer.Start();
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

        #region public void FillComboBox(FrmSuccessReport frmSuccessReport)
        public void FillComboBox(FrmSuccessReport f)
        {
            try
            {
                int idClassGroup = s.ClassGroup.IdClassGroup;
                int length = idClassGroup.ToString().Length;
                bool isMath = Communication.Instance.GetStreamFromClassGroup(idClassGroup);
                #region length=2 i social
                if (!isMath && length == 2 && (idClassGroup / 10 == 1 || idClassGroup / 10 == 2))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_1st_2nd_Social();
                }
                if (!isMath && length == 2 && (idClassGroup / 10 == 3))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_3rd_Social();
                }
                if (!isMath && length == 2 && (idClassGroup / 10 == 4))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_4th_Social();
                }
                #endregion
                #region length=3 i social
                if (!isMath && length == 3 && (idClassGroup / 100 == 1 || idClassGroup / 100 == 2))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_1st_2nd_Social();
                }
                if (!isMath && length == 3 && (idClassGroup / 100 == 3))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_3rd_Social();
                }
                if (!isMath && length == 3 && (idClassGroup / 100 == 4))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_4th_Social();
                }
                #endregion
                #region length=2 i mathematical
                if (isMath && length == 2 && (idClassGroup / 10 == 1))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_1st_2nd_Social();
                }
                if (isMath && length == 2 && (idClassGroup / 10 == 2))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_2nd_Math();
                }
                if (isMath && length == 2 && (idClassGroup / 10 == 3))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_3rd_Math();
                }
                if (isMath && length == 2 && (idClassGroup / 10 == 4))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_4th_Math();
                }
                #endregion
                #region length=3 i mathematical
                if (isMath && length == 3 && (idClassGroup / 100 == 1))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_1st_2nd_Social();
                }
                if (isMath && length == 3 && (idClassGroup / 100 == 2))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_2nd_Math();
                }
                if (isMath && length == 3 && (idClassGroup / 100 == 3))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_3rd_Math();
                }
                if (isMath && length == 3 && (idClassGroup / 100 == 4))
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_4th_Math();
                }
                #endregion
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion               

        #region public void cbChooseSubject_SelectedIndexChanged(FrmSuccessReport frmSuccessReport)
        public void cbChooseSubject_SelectedIndexChanged(FrmSuccessReport f)
        {
            try
            {
                //if (helper == 0)
                //{
                //    f.CbSubjects.SelectedIndex = -1;
                //    helper++;
                //    selectedSubject = (Subject)f.CbSubjects.SelectedItem;
                //}
                Subject selectedSubject = (Subject)f.CbSubjects.SelectedItem;
                //int idStudent = int.Parse(f.TxtStudentId.Text);
                int idStudent = CurrentStudent.IdStudent;
                BindingList<Mark> subjectMarks = Communication.Instance.GetAllMarksFromStudentFromSelectedSubject(selectedSubject.IdSubject, idStudent);
                f.BtnConcludeMark.Visible = true;
                f.TxtFinalMark.Visible = true;
                f.LblFinalMark.Visible = true;
                f.TxtFinalMark.Enabled = true;
                f.LblAverage.Visible = true;
                f.TxtAverage.Visible = true;
                f.BtnConcludeMark.Enabled = true;
                double sum = 0;
                if (subjectMarks.Count > 0)
                {
                    foreach (Mark m in subjectMarks)
                    {
                        sum += m.Value;
                    }
                    f.TxtAverage.Text = (sum / subjectMarks.Count).ToString();
                }
                else
                {
                    f.TxtAverage.Text = "";
                }
                if (Communication.Instance.MarkIsConcluded(selectedSubject.IdSubject, idStudent))
                {
                    //f.TxtFinalMark.Enabled = false;                 
                    f.BtnConcludeMark.Visible = false;
                    f.TxtFinalMark.Visible = false;
                    f.LblFinalMark.Visible = false;
                    f.LblAverage.Visible = false;
                    f.TxtAverage.Visible = false;
                    MessageBox.Show("Mark from this Subject is already concluded!");
                    //throw new Exception("Mark from this Subject is already concluded!");
                    //f.TxtFinalMark.Text = (Communication.Instance.GetConcludedMarkFromStudentOnSubject(selectedSubject.IdSubject, idStudent)).ToString();
                }
                f.DgvMarksOfStudent.Columns["Class"].Visible = false;

                if (subjectMarks.Count == 0)
                {
                    f.DgvMarksOfStudent.DataSource = Communication.Instance.GetAllMarksFromStudentFromSelectedSubject(selectedSubject.IdSubject, idStudent);
                    f.TxtAverage.Text = "";
                    f.TxtFinalMark.Enabled = false;
                    f.BtnConcludeMark.Enabled = false;
                    f.BtnConcludeMark.Visible = false;
                    f.TxtFinalMark.Visible = false;
                    f.LblFinalMark.Visible = false;
                    f.LblAverage.Visible = false;
                    f.TxtAverage.Visible = false;
                    MessageBox.Show("You are not allowed to conclude Mark if Student doesn't have any!");
                    return;
                }
                f.DgvMarksOfStudent.DataSource = subjectMarks;                
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                f.TxtFinalMark.Enabled = true;
                f.BtnConcludeMark.Enabled = true;
                MessageBox.Show(ex.Message);                
                //throw;
            }
        }
        #endregion

        #region public void FindStudent(FrmSuccessReport frmSuccessReport)
        public void FindStudent(FrmSuccessReport f)
        {
            #region manipulacija sa poljima
            f.LblClassGroup.Visible = true;
            f.LblFirstName.Visible = true;
            f.LblStream.Visible = true;
            f.LblLastName.Visible = true;
            f.TxtFirstName.Visible = true;
            f.TxtLastName.Visible = true;
            f.TxtStream.Visible = true;
            f.TxtClassGroup.Visible = true;
            f.TxtFirstName.Enabled = false;
            f.TxtLastName.Enabled = false;
            f.TxtStream.Enabled = false;
            f.TxtClassGroup.Enabled = false;
            #endregion
            if(string.IsNullOrEmpty(f.TxtName.Text) && string.IsNullOrEmpty(f.TxtJMBG.Text))
            {
                MessageBox.Show("You must enter one search criteria!");
                return;
            }
            if (!string.IsNullOrEmpty(f.TxtName.Text) && !string.IsNullOrEmpty(f.TxtJMBG.Text))
            {
                MessageBox.Show("You are allowed to search only by one criteria! Empty other field!");
                return;
            }
            #region FindByName
            if (string.IsNullOrEmpty(f.TxtJMBG.Text) && !string.IsNullOrEmpty(f.TxtName.Text))
            {
                try
                {
                    if (!f.TxtName.Text.Contains(' '))
                    {
                        MessageBox.Show("You need to insert first and lastname divided by space!");
                        return;
                    }
                    string name = f.TxtName.Text;
                    s = Communication.Instance.FindStudentByName(name);
                    //s = Communication.Instance.FindStudentById(idStudent);
                    int classGroup = s.ClassGroup.IdClassGroup;
                    MessageBox.Show("System found Student with this ID!");
                    CurrentStudent = s;
                    f.GbMarksBySubject.Enabled = true;
                    f.TxtFirstName.Text = s.FirstName;
                    f.TxtLastName.Text = s.LastName;
                    if (s.ClassGroup.Stream == 1)
                    {
                        f.TxtStream.Text = "mathematical";
                    }
                    else
                    {
                        f.TxtStream.Text = "social";
                    }
                    f.TxtClassGroup.Text = s.ClassGroup.Name;
                    f.GbMarksBySubject.Enabled = true;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ID you entered is not in valid format!");
                    MessageBox.Show("Student with this ID doesn't exist!");
                    f.GbMarksBySubject.Enabled = false;
                    f.TxtFinalMark.Enabled = false;
                    //f.CbSubjects.Enabled = false;
                    return;
                }
            }
            #endregion
            #region FindByJMBG
            if (!string.IsNullOrEmpty(f.TxtJMBG.Text) && string.IsNullOrEmpty(f.TxtName.Text))
            {
                try
                {
                    //int idStudent = int.Parse(f.TxtStudentId.Text);
                    if (f.TxtJMBG.Text.Length != 13)
                    {
                        MessageBox.Show("JMBG must contain 13 digits!");
                        return;
                    }
                    if (!Regex.Match(f.TxtJMBG.Text, "[0-9]{13}").Success)
                    {
                        MessageBox.Show("JMBG contains of digits only!");
                        return;
                    }
                    string jmbg = f.TxtJMBG.Text;
                    s = Communication.Instance.FindStudentByJMBG(jmbg);
                    CurrentStudent = s;
                    //s = Communication.Instance.FindStudentById(idStudent);
                    int classGroup = s.ClassGroup.IdClassGroup;
                    MessageBox.Show("System found Student with this ID!");
                    f.GbMarksBySubject.Enabled = true;
                    f.TxtFirstName.Text = s.FirstName;
                    f.TxtLastName.Text = s.LastName;
                    if (s.ClassGroup.Stream == 1)
                    {
                        f.TxtStream.Text = "mathematical";
                    }
                    else
                    {
                        f.TxtStream.Text = "social";
                    }
                    f.TxtClassGroup.Text = s.ClassGroup.Name;
                    f.GbMarksBySubject.Enabled = true;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ID you entered is not in valid format!");
                    MessageBox.Show("Student with this ID doesn't exist!");
                    f.GbMarksBySubject.Enabled = false;
                    f.TxtFinalMark.Enabled = false;
                    //f.CbSubjects.Enabled = false;
                    return;
                } 
            }
            #endregion
            try
            {
                FillComboBox(f);
                //cbChooseSubject.DataSource=Controller.Instance.subje                    
                //dgvMarksOfStudent.DataSource = Controller.Instance.GetAllMarksFromStudent(idStudent);
                f.GbMarksBySubject.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ID you entered is not in valid format!");
                //f.TxtFinalMark.Enabled = false;
                //f.CbSubjects.Enabled = false;
                return;
            }
        }
        #endregion

        #region public void ConcludeMark(FrmSuccessReport frmSuccessReport)
        public void ConcludeMark(FrmSuccessReport f)
        {
            try
            {
                if (string.IsNullOrEmpty(f.TxtFinalMark.Text) || int.Parse(f.TxtFinalMark.Text) > 5 || int.Parse(f.TxtFinalMark.Text) < 1)
                {
                    MessageBox.Show("Enter value from range [1-5]!");
                    f.TxtFinalMark.BackColor = Color.PowderBlue;
                    return;
                }
                f.TxtFinalMark.BackColor = Color.White;
                Subject subj = (Subject)f.CbSubjects.SelectedItem;
                int idSubj = subj.IdSubject;
                BindingList<Teacher> teachersOnSubj = new BindingList<Teacher>(Communication.Instance.GetAllTeachersOnSubject(idSubj));
                Teacher first = teachersOnSubj[0];
                int finalValue = int.Parse(f.TxtFinalMark.Text);
                Class concludeClass = new Class
                {
                    //IdClass = Controller.Instance.GetNewClassId(),
                    Teacher = new Teacher
                    {
                        IdTeacher = first.IdTeacher,
                        FirstName = first.FirstName,
                        LastName = first.LastName,
                        Address = first.Address,
                        PhoneNumber = first.PhoneNumber,
                        BirthDate = first.BirthDate,
                        AcademicLevel = first.AcademicLevel,
                        ClassGroup = first.ClassGroup,
                        Subject = first.Subject
                    },
                    DateAndTime = DateTime.Now.ToString("yyyyMMdd HH:mm"),
                    ClassGroup = new ClassGroupDatabase
                    {
                        IdClassGroup = s.ClassGroup.IdClassGroup,
                        Name = s.ClassGroup.Name,
                        Stream = s.ClassGroup.Stream
                    }
                };
                //int idStud = int.Parse(f.TxtStudentId.Text);
                int idStud = CurrentStudent.IdStudent;
                Student stud = Communication.Instance.FindStudentById(idStud);
                //Controller.Instance.SaveClassAndAssignedMarks(concludeClass, null);
                Mark finalMark = new Mark()
                {
                    Student = new Student
                    {
                        IdStudent = idStud,
                        FirstName = stud.FirstName,
                        LastName = stud.LastName,
                        BirthDate = stud.BirthDate,
                        Address = stud.Address,
                        PhoneNumber = stud.PhoneNumber,
                        ClassGroup = stud.ClassGroup
                    },
                    Class = concludeClass,
                    Value = finalValue,
                    DateOfExamination = DateTime.Now.ToString("yyyyMMdd HH:mm"),
                    IsFinal = 1
                };
                bool isConcluded = Communication.Instance.MarkIsConcluded(idSubj, s.IdStudent);
                if (isConcluded)
                {
                    MessageBox.Show("Mark is already concluded! You are not allowed to change given Mark!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult res = MessageBox.Show("Are you sure you want to save Final Mark? Reminder: Once you do this, there ain't no turning back!", "Saving confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (Communication.Instance.SaveClassAndFinalMark(concludeClass, finalMark) == 1 && !isConcluded)
                    {
                        MessageBox.Show("Mark successfully concluded!");
                    }
                    else
                    {
                        MessageBox.Show("Problem saving Final Mark!");
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
        
    }
}
