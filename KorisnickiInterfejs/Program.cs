using KorisnickiInterfejs.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMain());

            while (true)
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    DialogResult result = frmLogin.ShowDialog();
                    frmLogin.Dispose();
                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (ServerCommunicationException ex)
                {                    
                    MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!");
                    //throw;
                } 
                catch(Exception e)
                {
                    Debug.WriteLine(">>>" + e.Message);
                }
            }
        }
    }
}
