using ApplicationLogic;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmMyProfile : Form
    {
        _MyProfileController controller;
        public FrmMyProfile()
        {
            try
            {
                InitializeComponent();
                controller = new _MyProfileController();
                controller.InitData(this);
            }
            catch (ServerCommunicationException)
            {
                throw;
            }            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            controller.ChangePasswordArrangeFields(this);            
        }

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            controller.SaveNewPassword(this);       
        }        
    }
}
