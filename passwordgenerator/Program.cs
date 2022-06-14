using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordgenerator
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
            try
            {
                if (AppDomain.CurrentDomain.FriendlyName == "passwordgenerator.exe") { Application.Run(new MainForm()); }
                else { MessageBox.Show("a"); Application.Exit(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Programı başlatırken bir sorun oluştu! Programı yönetici olarak çalıştırdığınızdan emin olun.", "Password Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
