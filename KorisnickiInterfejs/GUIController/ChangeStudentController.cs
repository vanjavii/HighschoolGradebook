using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;

namespace KorisnickiInterfejs.GUIController
{
    public class ChangeStudentController
    {
        public int CurrentId { get; set; }
        public Student CurrentStudent { get; set; }
        #region InitData
        public void InitData(UCChangeStudent uc)
        {
            try
            {
                uc.StudentBindingSource.DataSource = new Student();
                uc.CbChooseNewClassGroup.Visible = false;
                uc.CbChooseNewClassGroup.DataSource = Communication.Instance.GetAllClassGroups();
                uc.BtnChangeInfo.Enabled = false;
                uc.BtnSaveChanges.Enabled = false;
                uc.FirstNameTextBox.Enabled = false;
                uc.LastNameTextBox.Enabled = false;
                uc.AddressTextBox.Enabled = false;
                uc.PhoneNumberTextBox.Enabled = false;
                uc.ClassGroupTextBox.Enabled = false;
                uc.TxtJMBG.Enabled = false;
                //sledeci red
                uc.ClassGroupTextBox.Anchor = AnchorStyles.None;
                uc.BtnSaveChanges.Enabled = false;
                uc.BirthDateDateTimePicker.Enabled = false;
                uc.BirthDateDateTimePicker.Visible = false;
                //sledeci red
                uc.BirthDateDateTimePicker.Anchor = AnchorStyles.None;
                uc.TxtBirthDate.Visible = true;
                uc.TxtBirthDate.Enabled = false;
                uc.BtnChangeInfo.Enabled = false;
                uc.BtnSaveChanges.Enabled = false;
                uc.BtnRemoveStudent.Enabled = false;
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

        #region public void FindStudent(UCChangeStudent uCChangeStudent)
        public void FindStudent(UCChangeStudent u)
        {
            u.TxtBirthDate.Visible = false;
            #region manipulacija sa popunjavanjem polja
            if (string.IsNullOrEmpty(u.TxtJMBGtoSearch.Text) && string.IsNullOrEmpty(u.TxtName.Text) && string.IsNullOrEmpty(u.TxtIdStudent.Text))
            {
                MessageBox.Show("You need to insert some criteria for search!");
                return;
            }
            if (!string.IsNullOrEmpty(u.TxtJMBGtoSearch.Text) && !string.IsNullOrEmpty(u.TxtName.Text) && !string.IsNullOrEmpty(u.TxtIdStudent.Text))
            {
                MessageBox.Show("You are allowed to insert only one search criteria, empty other fields!");
                return;
            }
            if (string.IsNullOrEmpty(u.TxtJMBGtoSearch.Text) && !string.IsNullOrEmpty(u.TxtName.Text) && !string.IsNullOrEmpty(u.TxtIdStudent.Text))
            {
                MessageBox.Show("You are allowed to insert only one search criteria, empty other fields!");
                return;
            }
            if (!string.IsNullOrEmpty(u.TxtJMBGtoSearch.Text) && string.IsNullOrEmpty(u.TxtName.Text) && !string.IsNullOrEmpty(u.TxtIdStudent.Text))
            {
                MessageBox.Show("You are allowed to insert only one search criteria, empty other fields!");
                return;
            }
            if (!string.IsNullOrEmpty(u.TxtJMBGtoSearch.Text) && !string.IsNullOrEmpty(u.TxtName.Text) && string.IsNullOrEmpty(u.TxtIdStudent.Text))
            {
                MessageBox.Show("You are allowed to insert only one search criteria, empty other fields!");
                return;
            }
            #endregion
            #region FindStudentById
            if (string.IsNullOrEmpty(u.TxtJMBGtoSearch.Text) && string.IsNullOrEmpty(u.TxtName.Text) && !string.IsNullOrEmpty(u.TxtIdStudent.Text))
            {
                try
                {
                    int idStudent = int.Parse(u.TxtIdStudent.Text);
                    Student s = Communication.Instance.FindStudentById(idStudent);
                    if (s != null)
                    {
                        MessageBox.Show("System found Student with this ID!");
                        CurrentStudent = s;
                        CurrentId = s.IdStudent;
                        u.FirstNameTextBox.Text = s.FirstName;
                        u.LastNameTextBox.Text = s.LastName;
                        u.AddressTextBox.Text = s.Address;
                        u.PhoneNumberTextBox.Text = s.PhoneNumber;
                        u.ClassGroupTextBox.Text = s.ClassGroup.Name;
                        u.BirthDateDateTimePicker.Value = s.BirthDate;//"dd/MM/yyyy"
                                                                      // txtYear.Text = s.ClassGroup.IdClassGroup.ToString();
                        u.TxtJMBG.Text = s.JMBG;
                        u.TxtBirthDate.Visible = false;
                        u.BirthDateDateTimePicker.Visible = true;
                        u.BtnChangeInfo.Enabled = true;
                        u.BtnRemoveStudent.Enabled = true;
                    }
                    //else { MessageBox.Show("Student with this ID doesn't exist!"); }
                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show("Student with this ID doesn't exist!");
                    u.TxtBirthDate.Text = "";
                    u.FirstNameTextBox.Text = "";
                    u.LastNameTextBox.Text = "";
                    u.BtnRemoveStudent.Enabled = false;
                    u.BtnChangeInfo.Enabled = false;
                    u.BtnSaveChanges.Enabled = false;
                    u.AddressTextBox.Text = "";
                    u.PhoneNumberTextBox.Text = "";
                    u.ClassGroupTextBox.Text = "";
                    u.TxtBirthDate.Visible = true;
                    u.TxtJMBG.Text = "";
                    //throw;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
            #region FindStudentByJMBG
            if (!string.IsNullOrEmpty(u.TxtJMBGtoSearch.Text) && string.IsNullOrEmpty(u.TxtName.Text) && string.IsNullOrEmpty(u.TxtIdStudent.Text))
            {
                try
                {
                    if (u.TxtJMBGtoSearch.Text.Length != 13)
                    {
                        MessageBox.Show("JMBG must contain 13 digits!");
                        return;
                    }
                    if (!Regex.Match(u.TxtJMBGtoSearch.Text, "[0-9]{13}").Success)
                    {
                        MessageBox.Show("JMBG contains of digits only!");
                        return;
                    }                    
                    string jmbg = u.TxtJMBGtoSearch.Text;
                    Student s = Communication.Instance.FindStudentByJMBG(jmbg);
                    if (s != null)
                    {
                        MessageBox.Show("System found Student with this JMBG!");
                        CurrentStudent = s;
                        CurrentId = s.IdStudent;
                        u.FirstNameTextBox.Text = s.FirstName;
                        u.LastNameTextBox.Text = s.LastName;
                        u.AddressTextBox.Text = s.Address;
                        u.PhoneNumberTextBox.Text = s.PhoneNumber;
                        u.ClassGroupTextBox.Text = s.ClassGroup.Name;
                        u.BirthDateDateTimePicker.Value = s.BirthDate;//"dd/MM/yyyy"
                                                                      // txtYear.Text = s.ClassGroup.IdClassGroup.ToString();
                        u.TxtJMBG.Text = s.JMBG;
                        u.TxtBirthDate.Visible = false;
                        u.BirthDateDateTimePicker.Visible = true;
                        u.BtnChangeInfo.Enabled = true;
                        u.BtnRemoveStudent.Enabled = true;
                    }
                    //else { MessageBox.Show("Student with this ID doesn't exist!"); }
                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show("Student with this JMBG doesn't exist!");
                    u.TxtBirthDate.Text = "";
                    u.FirstNameTextBox.Text = "";
                    u.LastNameTextBox.Text = "";
                    u.BtnRemoveStudent.Enabled = false;
                    u.BtnChangeInfo.Enabled = false;
                    u.BtnSaveChanges.Enabled = false;
                    u.AddressTextBox.Text = "";
                    u.PhoneNumberTextBox.Text = "";
                    u.ClassGroupTextBox.Text = "";
                    u.TxtBirthDate.Visible = true;
                    u.TxtJMBG.Text = "";
                    //throw;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
            #region FindStudentByName
            if (string.IsNullOrEmpty(u.TxtJMBGtoSearch.Text) && !string.IsNullOrEmpty(u.TxtName.Text) && string.IsNullOrEmpty(u.TxtIdStudent.Text))
            {
                try
                {
                    if(!u.TxtName.Text.Contains(' '))
                    {
                        MessageBox.Show("You need to insert first and lastname divided by space!");
                        return;
                    }
                    string studentName = u.TxtName.Text;
                    Student s = Communication.Instance.FindStudentByName(studentName);
                    if (s != null)
                    {
                        MessageBox.Show("System found Student with this Name!");
                        CurrentStudent = s;
                        CurrentId = s.IdStudent;
                        u.FirstNameTextBox.Text = s.FirstName;
                        u.LastNameTextBox.Text = s.LastName;
                        u.AddressTextBox.Text = s.Address;
                        u.PhoneNumberTextBox.Text = s.PhoneNumber;
                        u.ClassGroupTextBox.Text = s.ClassGroup.Name;
                        u.BirthDateDateTimePicker.Value = s.BirthDate;//"dd/MM/yyyy"
                                                                      // txtYear.Text = s.ClassGroup.IdClassGroup.ToString();
                        u.TxtJMBG.Text = s.JMBG;
                        u.TxtBirthDate.Visible = false;
                        u.BirthDateDateTimePicker.Visible = true;
                        u.BtnChangeInfo.Enabled = true;
                        u.BtnRemoveStudent.Enabled = true;
                    }
                    //else { MessageBox.Show("Student with this ID doesn't exist!"); }
                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show("Student with this Name doesn't exist!");
                    u.TxtBirthDate.Text = "";
                    u.FirstNameTextBox.Text = "";
                    u.LastNameTextBox.Text = "";
                    u.BtnRemoveStudent.Enabled = false;
                    u.BtnChangeInfo.Enabled = false;
                    u.BtnSaveChanges.Enabled = false;
                    u.AddressTextBox.Text = "";
                    u.PhoneNumberTextBox.Text = "";
                    u.ClassGroupTextBox.Text = "";
                    u.TxtBirthDate.Visible = true;
                    u.TxtJMBG.Text = "";
                    //throw;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
        }
        #endregion

        #region public void ChangeStudentInfo(UCChangeStudent uCChangeStudent)
        public void ChangeStudentInfo(UCChangeStudent u)
        {
            try
            {
                u.BtnSaveChanges.Enabled = true;
                u.BtnChangeInfo.Enabled = false;
                u.BirthDateDateTimePicker.Enabled = false;
                u.AddressTextBox.Enabled = true;
                u.PhoneNumberTextBox.Enabled = true;
                u.ClassGroupTextBox.Visible = false;
                u.CbChooseNewClassGroup.Visible = true;
                //u.BtnChangeInfo.Enabled = true;
                int idStudent = CurrentId;
                //int year = Communication.Instance.FindStudentById(idStudent).ClassGroup.IdClassGroup / 10;
                int year = CurrentStudent.ClassGroup.IdClassGroup / 10;
                u.CbChooseNewClassGroup.DataSource = Communication.Instance.GetAllClassGroupsFromSelectedYear(year);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }            
        }
        #endregion

        #region public void SaveChanges(UCChangeStudent uCChangeStudent)
        public void SaveChanges(UCChangeStudent u)
        {
            try
            {
                u.BtnChangeInfo.Enabled = false;
                //Student s = Communication.Instance.FindStudentById(int.Parse(u.TxtIdStudent.Text));
                Student s = CurrentStudent;
                u.FirstNameTextBox.Text = s.FirstName;
                u.LastNameTextBox.Text = s.LastName;
                u.StudentBindingSource.EndEdit();
                Student student = u.StudentBindingSource.Current as Student;
                student.BirthDate = s.BirthDate;
                if (student != null)
                {
                    ValidationContext context = new ValidationContext(student, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(student, context, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                #region are you sure you wanna save
                DialogResult res = MessageBox.Show("Are you sure you want to save changes?", "Saving confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    int idStudent = CurrentId;
                    string address = u.AddressTextBox.Text;
                    string phoneNumber = u.PhoneNumberTextBox.Text;
                    ClassGroupDatabase classGroup = (ClassGroupDatabase)u.CbChooseNewClassGroup.SelectedItem;
                    int classGroupId = classGroup.IdClassGroup;
                    if (Communication.Instance.ChangeStudentInfo(idStudent, address, phoneNumber, classGroupId) == 1)
                    {
                        MessageBox.Show("Student Info changed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Problem saving changes!");
                    }
                }
                else { return; }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Problem saving changes!");
            }
            #endregion
        }
        #endregion

        #region public void RemoveStudent(UCChangeStudent uCChangeStudent)
        public void RemoveStudent(UCChangeStudent u)
        {
            try
            {
                int selectedId = CurrentId;
                DialogResult res = MessageBox.Show("Are you sure you want to delete this Student?", "Delete confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (Communication.Instance.RemoveStudentWithId(selectedId) == 1)
                    {
                        u.TxtBirthDate.Clear();
                        u.FirstNameTextBox.Clear();
                        u.LastNameTextBox.Clear();
                        u.AddressTextBox.Clear();
                        u.PhoneNumberTextBox.Clear();
                        u.ClassGroupTextBox.Clear();
                        u.BirthDateDateTimePicker.CustomFormat = " ";
                        u.TxtJMBG.Text = "";
                        u.BirthDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                        MessageBox.Show("Student deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("You are not allowed to remove Student who has existing Marks!", "Problem deleting", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
