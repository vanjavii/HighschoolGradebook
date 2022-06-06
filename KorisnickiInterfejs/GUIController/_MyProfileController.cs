using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class _MyProfileController
    {
        #region InitData ------> IMA GRESAKA, KORISTE SE PROPERTYJI Controllera
        public void InitData(FrmMyProfile f)
        {
            try
            {
                f.LblFirstName.Text = Communication.Instance.CurrentUser.FirstName;
                f.LblLastName.Text = Communication.Instance.CurrentUser.LastName;
                f.LblMyId.Text = Communication.Instance.CurrentUser.IdUser.ToString();
                f.LblUsername.Text = Communication.Instance.CurrentUser.Username;
                f.TxtPassword.Text = Communication.Instance.CurrentUser.Password;
                f.TxtPassword.Enabled = false;
                f.TxtPassword.PasswordChar = '*';
                string password = Communication.Instance.GetChangedPassword(Communication.Instance.CurrentUser.IdUser);
                f.TxtPassword.Text = StarsNum(password);
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

        #region private string StarsNum(string password)
        private string StarsNum(string password)
        {
            int length = password.Length;
            string newPassword = "";
            for (int i = 0; i < length; i++)
            {
                newPassword += "*";
            }
            return newPassword;
        }
        #endregion

        #region ChangePasswordArrangeFields(FrmMyProfile frmMyProfile)
        public void ChangePasswordArrangeFields(FrmMyProfile f)
        {
            f.TxtPassword.Clear();
            f.TxtPassword.Enabled = true;
            f.BtnSaveNewPassword.Visible = true;
            f.BtnChangePassword.Enabled = false;
        }
        #endregion

        #region public void SaveNewPassword(FrmMyProfile f)
        public void SaveNewPassword(FrmMyProfile f)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save new password?", "Password confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    User current = Communication.Instance.CurrentUser;
                    string password = f.TxtPassword.Text;
                    if (Communication.Instance.ChangeUserPassword(current, password) == 1)
                    {
                        MessageBox.Show("Password changed successfully!");
                        f.TxtPassword.Text = StarsNum(password);
                    }
                    else { MessageBox.Show("Password not changed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
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
