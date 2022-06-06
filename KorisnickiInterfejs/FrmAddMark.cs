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
    public partial class FrmAddMark : Form
    {
        _AddMarkController controller;        

        public FrmAddMark(IDomainObject s, int idSubject)
        {
            InitializeComponent();
            controller = new _AddMarkController(this, s, idSubject);
            controller.InitData(this);            
        }
        
        private void btnSaveMark_Click(object sender, EventArgs e)
        {
            controller.SaveMark(this);           
        }
    }
}
