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
    public class _AddStudentToClassGroupController
    {
        public Student CurrentStudent { get; set; }

        #region public void AddStudent(FrmAddStudentToClassGroup frmAddStudentToClassGroup)
        public void AddStudent(FrmAddStudentToClassGroup f)
        {           
            Student s = new Student();
            #region validacija da polja nisu prazna i Regex poklapanje, kao i DateTimePicker.Value da nije posle danasnjeg datuma
            if (string.IsNullOrEmpty(f.TxtFirstName.Text))
            {
                MessageBox.Show("You haven't entered FirstName!");
                f.TxtFirstName.BackColor = Color.PowderBlue;
                return;
            }
            if (!Regex.Match(f.TxtFirstName.Text, "[A-Z][a-z]*").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid FirstName!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f.TxtFirstName.Focus();
                return;
            }
            f.TxtFirstName.BackColor = Color.White;
            if (string.IsNullOrEmpty(f.TxtLastName.Text))
            {
                MessageBox.Show("You haven't entered LastName!");
                f.TxtLastName.BackColor = Color.PowderBlue;
                return;
            }
            if (!Regex.Match(f.TxtLastName.Text, "[A-Z][a-z]*").Success)
            {
                MessageBox.Show("Invalid LastName!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f.TxtLastName.Focus();
                return;
            }
            f.TxtLastName.BackColor = Color.White;
            // mora validacija datetTimePicker-a
            if (f.DtpBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show($"BirthDate cant't take dates after Today! Todays date: {DateTime.Now.ToString("dd.MM.yyyy")}");
                return;
            }
            if(f.TxtJMBG.Text.Length!=13){
                MessageBox.Show("JMBG is not correct!");
                return;
            }
            //f.TxtJMBG.Text = f.DtpBirthDate.Value.ToString("ddMMyyy");
            // __________________________________________________
            if (string.IsNullOrEmpty(f.TxtAddress.Text))
            {
                MessageBox.Show("You haven't entered Address!");
                f.TxtAddress.BackColor = Color.PowderBlue;
                return;
            }
            f.TxtAddress.BackColor = Color.White;
            if (string.IsNullOrEmpty(f.TxtPhoneNumber.Text))
            {
                MessageBox.Show("You haven't entered PhoneNumber!");
                f.TxtPhoneNumber.BackColor = Color.PowderBlue;
                return;
            }
            if (!Regex.Match(f.TxtPhoneNumber.Text, "0[1-3][0-9]{8}").Success)
            {
                MessageBox.Show("Invalid PhoneNumber!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f.TxtPhoneNumber.Focus();
                return;
            }
            f.TxtPhoneNumber.BackColor = Color.White;
            #endregion
            s.FirstName = f.TxtFirstName.Text;
            s.LastName = f.TxtLastName.Text;
            s.PhoneNumber = f.TxtPhoneNumber.Text;
            s.Address = f.TxtAddress.Text;            
            s.BirthDate = f.DtpBirthDate.Value.Date;
            s.JMBG = f.TxtJMBG.Text;
            CurrentStudent = s;
            f.DialogResult = DialogResult.OK;
        }


        internal void Go(FrmAddStudentToClassGroup f)
        {
            string dateOfBirth = f.DtpBirthDate.Value.ToString("ddMMyyyy");
            char[] characters = dateOfBirth.ToCharArray();
            string finalVal = characters[0].ToString() + characters[1]+characters[2]+characters[3]+characters[5]+characters[6]+characters[7];
            f.TxtJMBG.Text = finalVal;
        }

        #endregion
    }
}
