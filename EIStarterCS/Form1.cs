using EIStarterCS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
//using System.Media;
using WMPLib;
using System.Security;
using System.Drawing.Text;
using static EIStarterCS.StarterForm;
using static System.Collections.Specialized.BitVector32;

namespace EIStarterCS
{
    public partial class StarterForm : Form
    {
        private List<Buttons> buttons = new List<Buttons>();
        string lang = "en";
        string design_dir = @"design\";
        bool isusecustomskins = true;
        bool isINImods = false;
        private List<string> languages = new List<string>();
        public List<Mod> mods = new List<Mod>();
        WindowsMediaPlayer WMP = new WindowsMediaPlayer();
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public class Buttons
        {
            public Button button;
            public string mask;
        }
        public class Mod
        {
            public string name;
            public string path;
            public string ver;
            public string author;
            public string email;
            public string site;
            public string date;
            public bool issingle;
            public bool ismulti;

            public string pluginpath;
            public string plugintext = "Plugin";
        }
        public StarterForm()
        {
            InitializeComponent();
            buttons.Add(new Buttons() { button = button1, mask = "pl" });
            buttons.Add(new Buttons() { button = button2, mask = "op" });
            buttons.Add(new Buttons() { button = button3, mask = "re" });
            buttons.Add(new Buttons() { button = button4, mask = "we" });
            buttons.Add(new Buttons() { button = button5, mask = "un" });
            buttons.Add(new Buttons() { button = button6, mask = "ex" });
            buttons.Add(new Buttons() { button = langbtn, mask = "lang" });
            buttons.Add(new Buttons() { button = infobtn, mask = "info" });

            //languages.Add("en");
            /*languages.Add("ru");
            languages.Add("de");
            languages.Add("pl");
            languages.Add("ko");
            languages.Add("zh");*/
            EnumerateLangs();
            //lang = Settings.Default.lang;
            //lang = languages[0];
            var cfg = new IniFile("starter.config");
            var lastsel = cfg.Read("ModSel", "Settings");
            var tempconv = cfg.Read("UsingINIconfigs", "Settings"); //isINImods
            if (!String.IsNullOrWhiteSpace(tempconv))
                isINImods = Convert.ToBoolean(tempconv);

            lang = cfg.Read("language", "Settings", "en");
            //var bSkip1 = false;
            if (Directory.Exists(@"Mods\"))
            {
                foreach (var modpath in Directory.EnumerateDirectories(@"Mods\"))
                {
                    if (File.Exists(modpath + "\\mod.config") && isINImods)
                    {
                        var modcfg = new IniFile(modpath + "\\mod.config");
                        //MessageBox.Show(cfg.Read("Title", "MOD"));
                        mods.Add(new Mod()
                        {
                            name = "Unkn_Title",
                            path = modpath + "\\mod.config",
                            ver = "",
                            author = "Unknown_Author",
                            email = "",
                            site = "",
                            date = "",
                            issingle = true,
                            ismulti = true,
                            pluginpath = "none"
                        });
                        var mod = mods.Last();


                        mod.name = modcfg.Read("Title", "MOD", "Unkn_Title");
                        mod.path = modpath + "\\mod.config";
                        mod.ver = modcfg.Read("Version", "MOD", "");
                        mod.author = modcfg.Read("Author", "MOD", "Unknown_Author");
                        mod.email = modcfg.Read("AuthorEmail", "MOD", "");
                        mod.site = modcfg.Read("URL", "MOD", "");
                        mod.date = modcfg.Read("date_DMY", "MOD", "");
                        mod.pluginpath = modcfg.Read("pluginpath", "Starter", "none");
                        mod.plugintext = modcfg.Read("plugintext", "Starter", "Plugin");
                        try
                        {
                            if (modcfg.Read("Single", "MOD", "") != "")
                                mod.issingle = Convert.ToBoolean(int.Parse(modcfg.Read("Single", "MOD", "")));
                        }
                        catch { }
                        try
                        {
                            if (modcfg.Read("Multi", "MOD", "") != "")
                                mod.ismulti = Convert.ToBoolean(int.Parse(modcfg.Read("Multi", "MOD", "")));
                        }
                        catch { }
                        ModCombo.Items.Add(mods.Last().name);
                        if (mods.Last().path == lastsel)
                            ModCombo.SelectedIndex = ModCombo.Items.Count - 1;
                    }
                    else if (File.Exists(modpath + "\\config.reg"))
                    {
                        var modcfg = new EIRegFile();
                        if (!modcfg.isLoaded)
                            modcfg.Load(modpath + "\\config.reg");
                        //MessageBox.Show(cfg.Read("Title", "MOD"));
                        mods.Add(new Mod()
                        {
                            name = "Unkn_Title",
                            path = modpath + "\\mod.config",
                            ver = "",
                            author = "Unknown_Author",
                            email = "",
                            site = "",
                            date = "",
                            issingle = true,
                            ismulti = true,
                            pluginpath = "none"
                        });
                        var mod = mods.Last();


                        mod.name = modcfg.GetString("Title", "MOD", "Unkn_Title");
                        mod.path = modpath + "\\config.reg";
                        mod.ver = modcfg.GetString("Version", "MOD", "");
                        mod.author = modcfg.GetString("Author", "MOD", "Unknown_Author");
                        mod.email = modcfg.GetString("AuthorEmail", "MOD", "");
                        mod.site = modcfg.GetString("URL", "MOD", "");
                        mod.date = modcfg.GetString("date_DMY", "MOD", "");
                        mod.pluginpath = modcfg.GetString("pluginpath", "Starter", "none");
                        mod.plugintext = modcfg.GetString("plugintext", "Starter", "Plugin");
                        try
                        {
                            if (modcfg.GetString("Single", "MOD", "") != "")
                                mod.issingle = Convert.ToBoolean(int.Parse(modcfg.GetString("Single", "MOD", "")));
                        }
                        catch { }
                        try
                        {
                            if (modcfg.GetString("Multi", "MOD", "") != "")
                                mod.ismulti = Convert.ToBoolean(int.Parse(modcfg.GetString("Multi", "MOD", "")));
                        }
                        catch { }
                        ModCombo.Items.Add(mods.Last().name);
                        if (mods.Last().path == lastsel)
                            ModCombo.SelectedIndex = ModCombo.Items.Count - 1;
                    }
                    if (ModCombo.SelectedIndex < 0)
                        ModCombo.SelectedIndex = 0;
                }
            }
            else
            {
                mods.Add(new Mod()
                {
                    name = "Unkn_Title",
                    path = "\\mod.config",
                    ver = "",
                    author = "Unknown_Author",
                    email = "",
                    site = "",
                    date = "",
                    issingle = true,
                    ismulti = true,
                    pluginpath = "none"
                });
                ModCombo.Items.Clear();
                ModCombo.Items.Add("No mods");
                ModCombo.SelectedIndex = ModCombo.Items.Count - 1;
                //ModCombo.Visible = false;
            }

            /*if (File.Exists(@"design\" + lang + @"\autorun.mp3"))
            {
                WindowsMediaPlayer WMP = new WindowsMediaPlayer();
                WMP.settings.volume = 1000;
                WMP.URL = @"design\" + lang + @"\autorun.mp3";
                WMP.controls.play();
            }*/

            InitLang();
        }
        /// <summary>
        /// Set style for all elements by current design_dir + lang.
        /// </summary>
        public void InitLang()
        {
            if (File.Exists(design_dir + lang + @"\back.bmp"))
            {
                this.BackgroundImage = Image.FromFile(design_dir + lang + @"\back.bmp");
                foreach (var button in buttons)
                {
                    SetButtonStyle(button.button, button.mask);
                }
            }
            else
            {
                // message "language not found! select other? LangSel
            }


            //TODO: Switch construction is faster?
            // FONT
            var font_size = 11f;
            Font font = new Font("Arial", font_size);
            if (privateFontCollection.Families.Length > 0)
            {
                privateFontCollection.Families[0].Dispose();
            }
            // OTF
            if (File.Exists(design_dir + lang + @"\font.otf"))
            {
                privateFontCollection.AddFontFile(design_dir + lang + @"\font.otf");
                font = new Font(privateFontCollection.Families[0], font_size);
            }
            else if (File.Exists(@"design\" + lang + @"\font.otf"))
            {
                privateFontCollection.AddFontFile(@"design\" + lang + @"\font.otf");
                font = new Font(privateFontCollection.Families[0], font_size);
            }
            // No lang OTF
            else if (File.Exists(design_dir + @"font.otf"))
            {
                privateFontCollection.AddFontFile(design_dir + @"font.otf");
                font = new Font(privateFontCollection.Families[0], font_size);
            }
            else if (File.Exists(@"design\font.otf"))
            {
                privateFontCollection.AddFontFile(@"design\font.otf");
                font = new Font(privateFontCollection.Families[0], font_size);
            }
            // TTF
            else if (File.Exists(design_dir + lang + @"\font.ttf"))
            {
                privateFontCollection.AddFontFile(@"design\" + lang + @"\font.ttf");
                font = new Font(privateFontCollection.Families[0], font_size);
            }
            else if (File.Exists(@"design\" + lang + @"\font.ttf"))
            {
                privateFontCollection.AddFontFile(@"design\" + lang + @"\font.ttf");
                font = new Font(privateFontCollection.Families[0], font_size);
            }
            // No lang TTF
            else if (File.Exists(design_dir + @"font.ttf"))
            {
                privateFontCollection.AddFontFile(design_dir + @"font.ttf");
                font = new Font(privateFontCollection.Families[0], font_size);
            }
            else if (File.Exists(@"design\font.ttf"))
            {
                privateFontCollection.AddFontFile(@"design\font.ttf");
                font = new Font(privateFontCollection.Families[0], font_size);
            }
            if (privateFontCollection.Families.Length > 0)
            {
                ModCombo.Font = font;
            }
            // Other
            ModCombo.Location = new Point(x: button1.Location.X + button1.Width + 10,y: ModCombo.Location.Y);
            infobtn.Location = new Point(x: ModCombo.Location.X + ModCombo.Width + 10,y: infobtn.Location.Y);
            langbtn.Location = new Point(x: 1,y: this.Height - langbtn.Height);
        }
        /// <summary>
        /// Get all langs names in design_dir
        /// </summary>
        public void EnumerateLangs()
        {
            if (Directory.Exists(design_dir))
            {
                languages.Clear();
                foreach (var langpath in Directory.EnumerateDirectories(design_dir))
                {
                    if (File.Exists(langpath + "\\back.bmp"))
                    {
                        //languages.Add(Path.GetFileName(Path.GetDirectoryName(langpath + "\\back.bmp")));
                        languages.Add(Path.GetFileName(langpath));
                        //design_dir = Path.GetDirectoryName(mods[ModCombo.SelectedIndex].path) + @"\design\";
                    }
                }
                //InitLang();

            }
            //languages.Add("en");
        }
        /// <summary>
        /// Set button image. Autosize to image.
        /// </summary>
        /// <param name="button">target Button</param>
        /// <param name="mask">img name mask</param>
        private void SetButtonStyle(Button button, string mask)
        {
            //TODO: refactoring needed maybe
            if (File.Exists(design_dir + lang + @"\" + mask + @".png"))
            {
                button.Image = Image.FromFile(design_dir + lang + @"\" + mask + @".png");
            }
            else if (File.Exists(design_dir + lang + @"\" + mask + @".bmp"))
            {
                button.Image = Image.FromFile(design_dir + lang + @"\" + mask + @".bmp");
            }
            else if (File.Exists(@"design\" + lang + @"\" + mask + @".png"))
            {
                button.Image = Image.FromFile(@"design\" + lang + @"\" + mask + @".png");
            }
            else if (File.Exists(@"design\" + lang + @"\" + mask + @".bmp"))
            {
                button.Image = Image.FromFile(@"design\" + lang + @"\" + mask + @".bmp");
            }
            if (button.Image != null)
            {
                button.Height = button.Image.Height - 1;
                button.Width = button.Image.Width - 1;
                button.Text = "";
            }
        }

        private void _MouseEnter(object sender, EventArgs e)
        {
            foreach (var button in buttons)
            {
                if (sender.Equals(button.button))
                {
                    SetButtonStyle(button.button, button.mask + "_h");
                    return;
                }
            }
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            foreach (var button in buttons)
            {
                if (sender.Equals(button.button))
                {
                    SetButtonStyle(button.button, button.mask + "");
                    return;
                }
            }
        }

        private void StarterForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            //this.Opacity = 0.9; 
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void BtnS0(object sender)
        {
            foreach (var button in buttons)
            {
                if (sender.Equals(button.button))
                    SetButtonStyle(button.button, button.mask + "");
                // else
                //     SetButtonStyle(button.button, button.mask + "");
            }
        }
        private void BtnS1(object sender, bool fast = false)
        {
            if (!fast)
            {
                if (File.Exists(design_dir + lang + @"\click.wav"))
                {
                    //SoundPlayer simpleSound = new SoundPlayer(@"design\" + lang + @"\click.wav");
                    //simpleSound.Play();
                    WMP.settings.volume = 1000;
                    WMP.URL = design_dir + lang + @"\click.wav";
                    WMP.controls.play();
                }
                foreach (var button in buttons)
                {
                    if (sender.Equals(button.button))
                        SetButtonStyle(button.button, button.mask + "_d");
                    else
                        SetButtonStyle(button.button, button.mask + "");
                }
            }
            else
            {
                foreach (var button in buttons)
                {
                    if (sender.Equals(button.button))
                        SetButtonStyle(button.button, button.mask + "_d");
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            //TODO: custom game.exe path.
            if (File.Exists(@"Engine\Game.exe"))
            {
                ProcessStartInfo start = new ProcessStartInfo(Directory.GetCurrentDirectory() + @"\Engine\Game.exe");
                start.WorkingDirectory = Directory.GetCurrentDirectory() + @"\Engine";
                start.UseShellExecute = false;
                Process.Start(start);
                Application.Exit();
            }
            else
            {
                MessageBox.Show(@"Engine\Game.exe not found!");
                BtnS0(sender);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            Options options = new Options();
            var rez = options.ShowDialog();
            if (rez == DialogResult.OK || rez == DialogResult.Cancel)
                BtnS0(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            Process.Start(
                new ProcessStartInfo("https://allods.gipat.ru") 
                { UseShellExecute = true }
                );
            BtnS0(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            Application.Exit();
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //}


        private void _ChangeUICues(object sender, UICuesEventArgs e)
        {
            BtnS1(sender);
        }
        
        /// <summary>
        /// Set next lang from languages list.
        /// </summary>
        private void LangSwitch()
        {
            for (int i = 0; i < languages.Count; i++)
            {
                if (languages[i] == lang && i != languages.Count - 1)
                {
                    lang = languages[i + 1];
                    //return;
                    break;
                }
                //else if(languages[i] == lang && i == languages.Count - 1)
                //{
                //    lang = languages[0];
                //}
                if (i == languages.Count - 1)
                    lang = languages[0];
            }
            InitLang();
        }
        private void langbtn_Click(object sender, EventArgs e)
        {
            BtnS1(sender, true);

            LangSwitch();
            //this.Update();
            //foreach (var button in buttons)
            //{
            //    button.button.Update();
            //}
            //this.Invalidate();
        }

        private void StarterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var cfg = new IniFile("starter.config");
            cfg.Write("ModSel", mods[ModCombo.SelectedIndex].path, "Settings");
            cfg.Write("language", lang, "Settings");
            cfg.Write("ModSkins", isusecustomskins.ToString(), "Settings");
            cfg.Write("UsingINIconfigs", isINImods.ToString(), "Settings");
        }

        private void ModCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnS1(sender);
            if (Directory.Exists(Path.GetDirectoryName(mods[ModCombo.SelectedIndex].path) + @"\design\"))
            {
                for (int i = 0; i < languages.Count; i++)
                {
                    if (Directory.Exists(Path.GetDirectoryName(mods[ModCombo.SelectedIndex].path) + @"\design\" + lang) && isusecustomskins)
                    {
                        design_dir = Path.GetDirectoryName(mods[ModCombo.SelectedIndex].path) + @"\design\";
                        EnumerateLangs();
                        InitLang();
                        break;
                    }
                    else
                    {
                        LangSwitch();
                    }
                }
            }
            else if (design_dir != @"design\")
            {
                design_dir = @"design\";
                EnumerateLangs();
                InitLang();
            }

            RegIni.Mode DataSource = RegIni.Mode.Win;

            IniFile addonini = new IniFile("Engine/addon.ini");
            REGedit addon = new REGedit("Software\\Gipat.ru\\EI_Starter");
            RegIni ri2 = new RegIni(addon, addonini, DataSource);
            ri2.SetStr("AddonPath", Directory.GetCurrentDirectory() + @"\" + Path.GetDirectoryName( mods[ModCombo.SelectedIndex].path), "settings");
            
            BtnS0(sender);
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            ModInfo modInfo = new ModInfo();
            modInfo.SetMod(mods[ModCombo.SelectedIndex]);
            var rez = modInfo.ShowDialog();
            if (rez == DialogResult.OK || rez == DialogResult.Cancel)
                BtnS0(sender);
        }
    }
}
