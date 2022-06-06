using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class _LoginController
    {      
        private static int counter = 3;
        public void Login(FrmLogin frm)
        {
            string username = frm.TxtUsername.Text;
            string password = frm.TxtPassword.Text;
            #region validacija username-a i password-a
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                frm.TxtUsername.BackColor = Color.Salmon;
                frm.TxtPassword.BackColor = Color.Salmon;
                frm.LblNoUsername.Text = "Username not entered!";
                frm.LblNoUsername.Visible = true;
                frm.LblNoPassword.Text = "Password not entered!";
                frm.LblNoPassword.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                frm.TxtUsername.BackColor = Color.Salmon;
                frm.LblNoUsername.Text = "Username not entered!";
                frm.LblNoUsername.Visible = true;
                return;
            }

            else if (string.IsNullOrEmpty(password))
            {
                frm.TxtPassword.BackColor = Color.Salmon;
                frm.LblNoPassword.Text = "Password not entered!";
                frm.LblNoPassword.Visible = true;
                return;
            }
            #endregion
            try
            {
                User user = new User
                {
                    Username = username,
                    Password = password
                };

                Communication.Instance.Connect();
                Communication.Instance.Login(user);                                

                if (user != null)
                {
                    frm.DialogResult = DialogResult.OK;
                }
                else if (user == null && counter > 1)
                {
                    counter--;
                    MessageBox.Show($"User with those credentials doesn't exist! You have {counter} tries left!");
                    //return;
                }
                else
                {
                    MessageBox.Show("No tries left! Application will close!");
                    Application.Exit();
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);                
            }
            catch (SocketException ex)
            {                
                MessageBox.Show("Server is not running! Start the server to continue!","Server error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
