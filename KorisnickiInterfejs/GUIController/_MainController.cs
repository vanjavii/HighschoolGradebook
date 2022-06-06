using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class _MainController
    {
        #region InitData
        public void InitData(FrmMain f)
        {
            try
            {
                f.Text = $"Current user: {Communication.Instance.CurrentUser.FirstName} {Communication.Instance.CurrentUser.LastName}";            
                f.Button1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                //lblUserLogged.Text = $"{Controller.Instance.CurrentUser.FirstName} {Controller.Instance.CurrentUser.LastName}!";
                //lblUserLogged.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
                //menuStrip1.ForeColor = Color.Red;
                f.LblUserLogged.Text = Communication.Instance.CurrentUser.FirstName + " " + Communication.Instance.CurrentUser.LastName;
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

        #region public void FrmMain_FormClosed(FrmMain frmMain)
        public void FrmMain_FormClosed(FrmMain frmMain)
        {
            try
            {
                Communication.Instance.Close();
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>Form closed event!>>>" + ex.Message);
                //throw;
            }
        }
        #endregion
    }
}
