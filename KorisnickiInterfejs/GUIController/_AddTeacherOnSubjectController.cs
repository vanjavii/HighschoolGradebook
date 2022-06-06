using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class _AddTeacherOnSubjectController
    {
        public Teacher CurrentTeacher { get; set; }

        #region  public void SaveTeacher(FrmAddTeacherOnSubject f)
        public void SaveTeacher(FrmAddTeacherOnSubject f)
        {
            try
            {
                ValidateTeacher(f);
                Teacher t = new Teacher
                {
                    FirstName = f.TxtFirstName.Text,
                    LastName = f.TxtLastName.Text,
                    BirthDate = f.DtpDateOfBirth.Value.Date,
                    Address = f.TxtAddress.Text,
                    PhoneNumber = f.TxtPhoneNumber.Text,
                    AcademicLevel = int.Parse(f.TxtAcademicLevel.Text)
                };
                CurrentTeacher = t;
                f.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        #endregion

        #region public void ValidateTeacher(FrmAddTeacherOnSubject f)
        public void ValidateTeacher(FrmAddTeacherOnSubject f)
        {
            #region firstName
            if (string.IsNullOrEmpty(f.TxtFirstName.Text))
            {
                f.TxtFirstName.BackColor = Color.PowderBlue;
                throw new Exception("You must enter FirstName!");
                //txtFirstName.BackColor = Color.PowderBlue;
                //return;
            }
            f.TxtFirstName.BackColor = Color.White;
            if (!Regex.Match(f.TxtFirstName.Text, "[A-Z][a-z]*").Success)
            {
                f.TxtFirstName.BackColor = Color.PowderBlue;
                throw new Exception("FirstName you entered is not in valid format!");
                //txtFirstName.BackColor = Color.PowderBlue;
                //return;
            }
            f.TxtFirstName.BackColor = Color.White;
            #endregion
            #region lastName
            if (string.IsNullOrEmpty(f.TxtLastName.Text))
            {
                f.TxtLastName.BackColor = Color.PowderBlue;
                throw new Exception("You must enter LastName!");
                //txtLastName.BackColor = Color.PowderBlue;
                //return;
            }
            f.TxtLastName.BackColor = Color.White;
            if (!Regex.Match(f.TxtLastName.Text, "[A-Z][a-z]*").Success)
            {
                f.TxtLastName.BackColor = Color.PowderBlue;
                throw new Exception("LastName you entered is not in valid format!");
                //txtLastName.BackColor = Color.PowderBlue;
                //return;
            }
            f.TxtLastName.BackColor = Color.White;
            #endregion
            #region BirthDate
            if (f.DtpDateOfBirth.Value > DateTime.Now)
            {
                f.DtpDateOfBirth.CalendarForeColor = Color.PowderBlue;
                throw new Exception("You are allowed to pick only days from the past!");
            }
            f.DtpDateOfBirth.CalendarForeColor = Color.White;
            #endregion
            if (string.IsNullOrEmpty(f.TxtAddress.Text))
            {
                f.TxtAddress.BackColor = Color.PowderBlue;
                throw new Exception("You must enter Address!");
            }
            f.TxtAddress.BackColor = Color.White;
            #region phonenumber
            if (string.IsNullOrEmpty(f.TxtPhoneNumber.Text))
            {
                f.TxtPhoneNumber.BackColor = Color.PowderBlue;
                throw new Exception("You must enter Phonenumber!");
            }
            f.TxtPhoneNumber.BackColor = Color.PowderBlue;
            if (!Regex.Match((f.TxtPhoneNumber.Text), "0[1-3][0-9]{8}").Success)
            {
                f.TxtPhoneNumber.BackColor = Color.PowderBlue;
                throw new Exception("Phonenumber you entered is not in valid format!");
            }
            f.TxtPhoneNumber.BackColor = Color.White;
            #endregion
            #region academiclevel
            if (string.IsNullOrEmpty(f.TxtAcademicLevel.Text) || int.Parse(f.TxtAcademicLevel.Text) < 1 || int.Parse(f.TxtAcademicLevel.Text) > 3)
            {
                f.TxtAcademicLevel.BackColor = Color.PowderBlue;
                throw new Exception("Academic level is in range [1-3]!");
                //txtAcademicLevel.BackColor = Color.PowderBlue;
                //return;
            }
            f.TxtAcademicLevel.BackColor = Color.White;
            #endregion  
        }
        #endregion
    }
}
