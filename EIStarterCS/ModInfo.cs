using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIStarterCS
{
    public partial class ModInfo : Form
    {
        string readmepath = "";
        string changelogpath = "";
        StarterForm.Mod mod = new StarterForm.Mod();
        public ModInfo()
        {
            InitializeComponent();
        }
        public void SetMod(StarterForm.Mod inputmod)
        {
            mod = inputmod;
        }

        private void ModInfo_Load(object sender, EventArgs e)
        {
            var tmp = "";
            tmp += mod.name + "\r\n";
            tmp += "Version: " + mod.ver + "\r\n";
            tmp += "Author(s): " + mod.author + "\r\n";
            tmp += "Date: " + mod.date + "\r\n";
            tmp += "\r\n";
            tmp += "Site: " + mod.site + "\r\n";
            tmp += "E-mail: " + mod.email + "\r\n";
            tmp += "\r\n";
            tmp += "Singleplayer: " + mod.issingle + "\r\n";
            tmp += "Multiplayer: " + mod.ismulti + "\r\n";

            textBox1.Text = tmp;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            foreach (var dirfile in Directory.EnumerateFiles(Path.GetDirectoryName(mod.path)))
            {
                if (Path.GetFileName(dirfile).Contains("read", StringComparison.CurrentCultureIgnoreCase)
                    && Path.GetFileName(dirfile).Contains("me", StringComparison.CurrentCultureIgnoreCase)
                    )
                {
                    readmepath = dirfile;
                    button2.Visible = true;
                }
                if (Path.GetFileName(dirfile).Contains("change", StringComparison.CurrentCultureIgnoreCase)
                    && Path.GetFileName(dirfile).Contains("log", StringComparison.CurrentCultureIgnoreCase)
                    )
                {
                    changelogpath = dirfile;
                    button3.Visible = true;
                }
            }
            //pluginpath
            //MessageBox.Show(Path.GetDirectoryName(mod.path) + "\\" + mod.pluginpath);
            if (Path.Exists(Path.GetDirectoryName(mod.path) + "\\" + mod.pluginpath))
            {
                button1.Visible = true;
                button1.Text = mod.plugintext;
            }

        }
        /// <summary>
        /// From: https://stackoverflow.com/questions/11365984/c-sharp-open-file-with-default-application-and-parameters
        /// </summary>
        /// <param name="path"></param>
        public static void OpenWithDefaultProgram(string path)
        {
            using Process fileopener = new Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory() + @"\" + Path.GetDirectoryName(mod.path) + @"\" + mod.pluginpath;
            //MessageBox.Show(path);
            Process.Start(@"C:\Windows\System32\cmd.exe", "/C \"" + path+"\"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenWithDefaultProgram(readmepath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenWithDefaultProgram(changelogpath);
        }
    }
}
