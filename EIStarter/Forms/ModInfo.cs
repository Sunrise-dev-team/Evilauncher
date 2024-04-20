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

namespace EIStarter
{
    public partial class ModInfo : Form
    {
        string readmepath = "";
        string changelogpath = "";
        string insertdataorig = "{0} \r\nVersion: {1} \r\nAuthor(s): {2} \r\nDate: {3} \r\n\r\nSite: {4} \r\nE-mail: {5} \r\n\r\nSingleplayer: {6} \r\nMultiplayer: {7} \r\n";
        string insertdata = "{0} \r\nVersion: {1} \r\nAuthor(s): {2} \r\nDate: {3} \r\n\r\nSite: {4} \r\nE-mail: {5} \r\n\r\nSingleplayer: {6} \r\nMultiplayer: {7} \r\n";
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
            /*var tmp = $"{mod.name} \r\n" +
            $"Version: {mod.ver} \r\n" +
            $"Author(s): {mod.author} \r\n" +
            $"Date: {mod.date} \r\n\r\n" +
            $"Site: {mod.site} \r\n" +
            $"E-mail: {mod.email} \r\n\r\n" +
            $"Singleplayer: {mod.issingle} \r\n" +
            $"Multiplayer: {mod.ismulti} \r\n";*/

            NTRbtModAction.Visible = false;
            btReadme.Visible = false;
            btChangelog.Visible = false;

            foreach (var dirfile in Directory.EnumerateFiles(Path.GetDirectoryName(mod.path)))
            {
                if (Path.GetFileName(dirfile).ToLower().Contains("read")//, StringComparison.CurrentCultureIgnoreCase)
                    && Path.GetFileName(dirfile).ToLower().Contains("me")//, StringComparison.CurrentCultureIgnoreCase)
                    )
                {
                    readmepath = dirfile;
                    btReadme.Visible = true;
                }
                if (Path.GetFileName(dirfile).ToLower().Contains("change")//, StringComparison.CurrentCultureIgnoreCase)
                    && Path.GetFileName(dirfile).ToLower().Contains("log")//, StringComparison.CurrentCultureIgnoreCase)
                    )
                {
                    changelogpath = dirfile;
                    btChangelog.Visible = true;
                }
            }
            //pluginpath
            if (File.Exists(Path.GetDirectoryName(mod.path) + "\\" + mod.pluginpath))
            {
                NTRbtModAction.Visible = true;
                NTRbtModAction.Text = mod.plugintext;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory() + @"\" + Path.GetDirectoryName(mod.path) + @"\" + mod.pluginpath;
            Process.Start(@"C:\Windows\System32\cmd.exe", "/C \"" + path+"\"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimplyHelper.OpenWithDefaultProgram(readmepath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SimplyHelper.OpenWithDefaultProgram(changelogpath);
        }

        public void Localise(string lang, bool bCreate = false)
        {
            NTRtbModInfo.Text = string.Format(insertdata, mod.name, mod.ver, mod.author, mod.date, mod.site, mod.email, mod.issingle, mod.ismulti);

            if (!File.Exists(string.Format("lang/{0}/lang.ini", lang)))
                return;

            IniFile ini = new IniFile(string.Format("lang/{0}/lang.ini", lang));

            List<Control> allControls = SimplyHelper.GetAllControls(this);

            if (bCreate)
            {
                IniFile ini_save = new IniFile(string.Format("lang/{0}/lang_create.ini", lang));
                ini_save.Write(this.Text, this.Text, this.Text);
                ini_save.Write("ModDesc", insertdata.Replace("\r\n","<rn>"), this.Text);
                foreach (Control control in allControls)
                {
                    if (string.IsNullOrEmpty(control.Name))
                        continue;

                    if (!string.IsNullOrEmpty(control.Text)
                        && !control.Name.ToLower().StartsWith("cbb")
                        && !control.Name.ToLower().StartsWith("nb")
                        && !control.Name.ToLower().StartsWith("tb")
                        && !control.Name.ToLower().StartsWith("ntr")
                        )
                        ini_save.Write(control.Name, control.Text, this.Text);
                }
            }
            else
            {
                foreach (Control control in allControls)
                {
                    if (string.IsNullOrEmpty(control.Name))
                        continue;
                    if (
                        !control.Name.ToLower().StartsWith("cbb") &&
                        !control.Name.ToLower().StartsWith("nb") &&
                        !control.Name.ToLower().StartsWith("tb") &&
                        !control.Name.ToLower().StartsWith("ntr")
                        )
                        control.Text = ini.Read(control.Name, this.Text, control.Text);

                    else if (!string.IsNullOrEmpty(control.Text)
                        && control.Name.ToLower().StartsWith("tb")
                        && !control.Name.ToLower().StartsWith("ntr")
                        )
                    {
                        TextBox tb = (TextBox)control;
                        for (int i = 0; i < tb.Lines.Count(); i++)
                            tb.Lines[i] = ini.Read(control.Name + "_strN" + i, this.Text, tb.Lines[i]);
                    }
                }
                insertdata = ini.Read("ModDesc", this.Text, insertdataorig).Replace("<rn>", "\r\n");
                NTRtbModInfo.Text = string.Format(insertdata, mod.name, mod.ver, mod.author, mod.date, mod.site, mod.email, mod.issingle, mod.ismulti);

                this.Text = ini.Read(this.Text, this.Text, this.Text);
            }
        }
    }
}
