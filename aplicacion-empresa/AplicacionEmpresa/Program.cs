using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace AplicacionEmpresa
{
    static class Program
    {
        /// &lt;summary&gt;
        /// The main entry point for the application.
        /// &lt;/summary&gt;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new FrmInicio());
            }
            catch(Exception ex)
            {
                MessageBox.Show("La aplicación se cerrará. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}