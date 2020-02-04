using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGGDrafus
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
            GameForm mainForm = null;
            try
            {
                mainForm = new GameForm();
                Application.Run(mainForm);
            }
            finally
            {
                if (mainForm != null)
                    mainForm.Close();
            }
        }
    }
}
