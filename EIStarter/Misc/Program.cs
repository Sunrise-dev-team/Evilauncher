using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace EIStarter
{
    internal static class Program
    {
        private static Mutex mutex;
        const string uniqueMutexName = "EIStarterSharp";

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if CATCH
            try
            {
#endif
                bool createdNew;
                mutex = new Mutex(true, uniqueMutexName, out createdNew);

                if (!createdNew)
                {
                    const string windowTitle = "StarterForm"; // TODO: use class StarterForm.<window title>
                    IntPtr hWnd = FindWindow(null, windowTitle);

                    if (hWnd != IntPtr.Zero)
                        SetForegroundWindow(hWnd);
                    else
                        MessageBox.Show("The application is already running, but the window could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                GuiHelper.setSelfDir();
                Application.Run(new StarterForm());
#if CATCH
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error:\r\n{ex.Message}\r\nHRESULT: {ex.HResult}\r\nSource: {ex.Source}\r\nStack:\r\n{ex.StackTrace}");
            }
#endif
        }
    }
}
