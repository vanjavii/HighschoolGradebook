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
    public class AddTeacherWithValidationController
    {
        #region InitData
        public void InitData(UCAddTeacherWithValidation uc)
        {
            try
            {
                uc.SubjectNameComboBox.DataSource = Communication.Instance.GetAllSubjects();
                uc.TeacherBindingSource.DataSource = new Teacher();
                uc.SubjectNameComboBox.SelectedIndex = 0;
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

        #region public void AddTeacher(UCAddTeacherWithValidation uCAddTeacherWithValidation)
        public void AddTeacher(UCAddTeacherWithValidation u)
        {
            try
            {
                u.TeacherBindingSource.EndEdit();
                Teacher teacher = u.TeacherBindingSource.Current as Teacher;
                if (teacher != null)
                {
                    ValidationContext context = new ValidationContext(teacher, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(teacher, context, errors, true))
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
                DialogResult res = MessageBox.Show("Are you sure you want to save this teacher?", "Saving confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Teacher t = new Teacher();
                    t.FirstName = u.FirstNameTextBox.Text;
                    t.LastName = u.LastNameTextBox.Text;
                    t.Address = u.AddressTextBox.Text;
                    t.BirthDate = u.BirthDateDateTimePicker.Value.Date;
                    t.PhoneNumber = u.PhoneNumberTextBox.Text;
                    t.AcademicLevel = int.Parse(u.AcademicLevelTextBox.Text);
                    List<Subject> subjs = (List<Subject>)Communication.Instance.GetAllSubjects();
                    Subject defaultSub = subjs[0];
                    if (u.SubjectNameComboBox.SelectedIndex < 0)
                    {
                        t.Subject = defaultSub;
                    }
                    else
                    {
                        t.Subject = (Subject)u.SubjectNameComboBox.SelectedItem;
                    }
                    try
                    {
                        if (Communication.Instance.AddTeacher(t) == 1)
                        {
                            MessageBox.Show("Teacher added successfully!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Problem saving Teacher!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { return; }
                #endregion
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
