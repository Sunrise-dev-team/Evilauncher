using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIStarter
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // TODO: activate exist copy of program or just close when game.exe running!
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                GuiHelper.setSelfDir();
                Application.Run(new StarterForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error:\r\n" + ex.Message + "\r\nHRESULT: " + ex.HResult.ToString() + "\r\nSource: " + ex.Source + "\r\nStack:\r\n" + ex.StackTrace);
            }
        }
    }
}
