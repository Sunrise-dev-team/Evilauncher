using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIStarter
{
    public static class SimplyHelper
    {
        public static List<Control> GetAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.Add(c);
                controlList.AddRange(GetAllControls(c));
            }
            return controlList;
        }

        /// <summary>
        /// From: https://stackoverflow.com/questions/11365984/c-sharp-open-file-with-default-application-and-parameters
        /// </summary>
        /// <param name="path"></param>
        public static void OpenWithDefaultProgram(string path)
        {
            using Process fileopener = new Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = $"\"{path}\"";
            fileopener.Start();
        }

        public static bool IsGameRuning()
        {
            // имя процесса (без расширения)
            string processName = StarterForm.ExeName.Replace(".exe", "");
            string defaultProcessName = "game";
            string windowTitle = "Evil Islands";

            foreach (Process process in Process.GetProcesses())
            {
                if (
                    (
                    process.ProcessName.Equals(defaultProcessName, StringComparison.OrdinalIgnoreCase)
                    ||
                    process.ProcessName.Equals(processName, StringComparison.OrdinalIgnoreCase)
                    )
                    &&
                    (
                    //process.MainWindowTitle.Equals(windowTitle, StringComparison.OrdinalIgnoreCase) ||
                    process.MainWindowTitle.ToLower().Contains("evil") && 
                    process.MainWindowTitle.ToLower().Contains("islands")
                    )
                    )
                {
                    //Console.WriteLine($"Найден процесс: {process.ProcessName}, ID: {process.Id}, Заголовок окна: {process.MainWindowTitle}");
                    return true;
                }
            }
            return false;
        }

        public static bool ValidateExeName(string exename)
        {
            if (string.IsNullOrWhiteSpace(exename))
                return false;

            Regex regex = new Regex(@"^[^\\/:*?""<>|\r\n]+$");
            if (!regex.IsMatch(exename))
            {
                MessageBox.Show("Err666: └ї Є√ ярфыр, їрЎъхЁ эхт·хсхээ√щ!\r\nGame.exe path is incorrect!");
                return false;
            }

            return true;
        }

        public static string ComputeFileHash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                }
            }
        }

    }
}
