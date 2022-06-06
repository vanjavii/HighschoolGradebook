using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class AddStudentWithValidationController
    {
        #region InitData
        public void InitData(UCAddStudentWithValidation uc)
        {
            try
            {
                uc.NameComboBox.DataSource = Communication.Instance.GetAllClassGroups();
                uc.StudentBindingSource.DataSource = new Student();
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

        #region  public void GetClassGroupsFromSelectedYear(UCAddStudentWithValidation uCAddStudentWithValidation)
        public void GetClassGroupsFromSelectedYear(UCAddStudentWithValidation u)
        {
            try
            {
                int selectedYear = int.Parse(u.TxtYear.Text);
                u.NameComboBox.DataSource = Communication.Instance.GetAllClassGroupsFromSelectedYear(selectedYear);
            }
            catch (Exception)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion

        #region public void AddStudent(UCAddStudentWithValidation uCAddStudentWithValidation)
        public void AddStudent(UCAddStudentWithValidation u)
        {
            try
            {
                u.StudentBindingSource.EndEdit();
                Student student = u.StudentBindingSource.Current as Student;
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
                Student s = new Student();
                if (u.TxtJMBG.Text.Length == 13)
                {
                    s.JMBG = u.TxtJMBG.Text;
                }
                else
                {
                    MessageBox.Show("JMBG must contain 13 digits!");
                    return;
                }
                DialogResult res = MessageBox.Show("Are you sure you want to save this student?", "Saving confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    //Student s = new Student();
                    s.FirstName = u.FirstNameTextBox.Text;
                    s.LastName = u.LastNameTextBox.Text;
                    s.Address = u.AddressTextBox.Text;
                    s.PhoneNumber = u.PhoneNumberTextBox.Text;
                    s.ClassGroup = (ClassGroupDatabase)u.NameComboBox.SelectedItem;
                    s.BirthDate = u.BirthDateDateTimePicker.Value.Date;                    
                    if (Communication.Instance.AddStudent(s) == 1)
                    {
                        MessageBox.Show("Student saved successfully!");
                    }
                    else { MessageBox.Show("Problem saving Student!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        #region
        public void Go(UCAddStudentWithValidation u)
        {
            string dateOfBirth = u.BirthDateDateTimePicker.Value.ToString("ddMMyyyy");
            char[] characters = dateOfBirth.ToCharArray();
            string finalVal = characters[0].ToString() + characters[1] + characters[2] + characters[3] + characters[5] + characters[6] + characters[7];
            u.TxtJMBG.Text = finalVal;
        }
        #endregion
    }
}
