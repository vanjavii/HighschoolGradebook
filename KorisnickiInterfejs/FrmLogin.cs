using ApplicationLogic;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmLogin : Form
    {
        _LoginController loginController;        

        public FrmLogin()
        {
            InitializeComponent();
            loginController = new _LoginController();
            txtUsername.Text = "pera";
            txtPassword.Text = "pera";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            loginController.Login(this);       
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Communication.Instance.Close();
        }
    }
}
