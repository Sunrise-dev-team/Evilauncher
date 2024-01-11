using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            foreach (var dirfile in Directory.EnumerateFiles(Path.GetDirectoryName(mod.path)))
            {
                if (Path.GetFileName(dirfile).ToLower().Contains("read")
                    && Path.GetFileName(dirfile).ToLower().Contains("me")
                    && Path.GetFileName(dirfile).ToLower().Contains(".txt"))
                {
                    textBox2.Text = File.ReadAllText(dirfile, Encoding.GetEncoding("windows-1251"));
                    break;
                }
            }

        }
    }
}
