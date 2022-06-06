using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLogic;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCFindClassgroup : UserControl
    {
        FindClassgroupController controller;
        public UCFindClassgroup()
        {
            InitializeComponent();
            controller = new FindClassgroupController();
            controller.InitData(this);          
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            controller.Find(this);            
        }
    }
}
