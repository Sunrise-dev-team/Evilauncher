using EIStarter.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using WMPLib;
using System.Drawing.Text;
using static EIStarter.StarterForm;
using System.Media;
using System.Globalization;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using static EIStarter.RegIni;
using static EIStarter.StarterForm;

namespace EIStarter
{
    public partial class StarterForm : Form
    {
        private List<Buttons> buttons = new List<Buttons>();
        string lang = "en";
        string design_dir = @"design\";
        public static string ExeName = @"game.exe";
        bool isusecustomskins = true;
        bool isINImods = false;
        private List<string> languages = new List<string>();
        public List<Mod> mods = new List<Mod>();
        public bool isModsExists = false;
        //WindowsMediaPlayer WMP = new WindowsMediaPlayer();
        SoundPlayer simpleSound = new SoundPlayer();
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public class Buttons
        {
            public Button button;
            public string mask;
        }
        public class Mod
        {
            public string name = "unknown";
            public string path;
            public string ver = "0.0.0";
            public string author = "unknown";
            public string email = "";
            public string site = "";
            public string date = "";
            public bool issingle = true;
            public bool ismulti = true;

            public string pluginpath = "none";
            public string plugintext = "Plugin";
        }
        bool ValidateExeName(string exename)
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

            EnumerateLangs();
            //lang = Settings.Default.lang;
            //lang = languages[0];
            var cfg = new IniFile("starter.config");
            var lastsel = cfg.Read("ModSel", "Settings");
            var tempconv = cfg.Read("UsingINIconfigs", "Settings"); //isINImods
            if (!string.IsNullOrWhiteSpace(tempconv))
                isINImods = Convert.ToBoolean(tempconv);

            var tempconv2 = cfg.Read("ExeName", "Settings","game.exe"); // custom EXE
            if (ValidateExeName(tempconv2))
                ExeName = tempconv2;

            string currentLanguage = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if(!string.IsNullOrWhiteSpace(currentLanguage))
                lang = cfg.Read("language", "Settings", currentLanguage);
            else
                lang = cfg.Read("language", "Settings", "en");
            
            if (Directory.Exists(@"Mods\"))
            {
                foreach (var modpath in Directory.EnumerateDirectories(@"Mods\"))
                {
                    if (File.Exists($@"{modpath}\mod.config") && isINImods)
                    {
                        var modcfg = new IniFile($@"{modpath}\mod.config");
                        var mod = new Mod(){path = $@"{modpath}\mod.config"};
                        mods.Add(mod);
                        isModsExists = true;


                        mod.name = modcfg.Read("Title", "MOD", "Unkn_Title");
                        mod.path = $@"{modpath}\mod.config";
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
                                mod.issingle = Convert.ToBoolean(int.Parse(modcfg.Read("Single", "MOD", "1")));
                        }
                        catch { }
                        try
                        {
                            if (modcfg.Read("Multi", "MOD", "") != "")
                                mod.ismulti = Convert.ToBoolean(int.Parse(modcfg.Read("Multi", "MOD", "1")));
                        }
                        catch { }
                        ModCombo.Items.Add(mod.name);
                        if (mod.path == lastsel)
                            ModCombo.SelectedIndex = ModCombo.Items.Count - 1;
                    }
                    else if (File.Exists($@"{modpath}\config.reg"))
                    {
                        var modcfg = new EIRegFile();
                        if (!modcfg.isLoaded)
                            modcfg.Load($@"{modpath}\config.reg");
                        var mod = new Mod() { path = $@"{modpath}\mod.config" };
                        mods.Add(mod);
                        isModsExists = true;


                        mod.name = modcfg.GetString("Title", "MOD", "Unkn_Title");
                        mod.path = $@"{modpath}\config.reg";
                        mod.ver = modcfg.GetString("Version", "MOD", "");
                        mod.author = modcfg.GetString("Author", "MOD", "Unknown_Author");
                        mod.email = modcfg.GetString("AuthorEmail", "MOD", "");
                        mod.site = modcfg.GetString("URL", "MOD", "");
                        mod.date = modcfg.GetString("date_DMY", "MOD", "");
                        mod.pluginpath = modcfg.GetString("pluginpath", "Starter", "none");
                        mod.plugintext = modcfg.GetString("plugintext", "Starter", "Plugin");
                        try
                        {
                            mod.issingle = Convert.ToBoolean(modcfg.GetDword("Single", "MOD", 1));
                        }
                        catch { }
                        try
                        {
                            mod.ismulti = Convert.ToBoolean(modcfg.GetDword("Multi", "MOD", 1));
                        }
                        catch { }
                        ModCombo.Items.Add(mod.name);
                        if (mod.path == lastsel)
                            ModCombo.SelectedIndex = ModCombo.Items.Count - 1;
                    }
                    if (ModCombo.SelectedIndex < 0)
                        ModCombo.SelectedIndex = 0;
                }
            }
            else
            {
                var mod = new Mod() { path = $@"\mod.config" };
                mods.Add(mod);
                isModsExists = false;

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
            //if (File.Exists(design_dir + lang + @"\back.png"))
            //    this.BackgroundImage = Image.FromFile(design_dir + lang + @"\back.png");
            //else if (File.Exists(design_dir + lang + @"\back.bmp"))
            //    this.BackgroundImage = Image.FromFile(design_dir + lang + @"\back.bmp");
            //else
            // message "language not found! select other? LangSel

            string[] extensions = { ".png", ".bmp" };
            string[] directories = { design_dir + lang, design_dir, @"design\" + lang, @"design\" };

            var filename = "back";
            var fullbreak = false;
            try{
                foreach (string directory in directories)
                {
                    foreach (string extension in extensions)
                    {
                        string imagePath = Path.Combine(directory, filename + extension);
                        if (File.Exists(imagePath))
                        {
                            BackgroundImage = Image.FromFile(imagePath);
                            fullbreak = true;
                        }
                        if (fullbreak)
                            break;
                    }
                    if (fullbreak)
                        break;
                }
            }catch { }

            foreach (var button in buttons)
            {
                SetButtonStyle(button.button, button.mask);
            }

            //TODO: Switch construction is faster?
            // FONT
            var font_size = 10.7f;
            Font font = new Font("Arial", font_size);
            if (privateFontCollection.Families.Length > 0)
                privateFontCollection.Families[0].Dispose(); // TODO: check 

            try
            {
                // OTF
                if (File.Exists(@$"{design_dir}{lang}\font.otf"))
                    privateFontCollection.AddFontFile(@$"{design_dir}{lang}\font.otf");
                else if (File.Exists($@"design\{lang}\font.otf"))
                    privateFontCollection.AddFontFile(@$"design\{lang}\font.otf");

                // No lang OTF
                else if (File.Exists($"{design_dir}font.otf"))
                    privateFontCollection.AddFontFile($"{design_dir}font.otf");
                else if (File.Exists(@"design\font.otf"))
                    privateFontCollection.AddFontFile(@"design\font.otf");
            }
            catch{}

            if (privateFontCollection.Families.Length == 0)
            {
                try
                {
                    // TTF
                    if (File.Exists(@$"{design_dir}{lang}\font.ttf"))
                        privateFontCollection.AddFontFile(@$"{design_dir}{lang}\font.ttf");
                    else if (File.Exists(@$"design\{lang}\font.ttf"))
                        privateFontCollection.AddFontFile(@$"design\{lang}\font.ttf");

                    // No lang TTF
                    else if (File.Exists(@$"{design_dir}font.ttf"))
                        privateFontCollection.AddFontFile(@$"{design_dir}font.ttf");
                    else if (File.Exists(@"design\font.ttf"))
                        privateFontCollection.AddFontFile(@"design\font.ttf");
                }
                catch { }
            }
            
            if (privateFontCollection.Families.Length > 0)
            {
                font = new Font(privateFontCollection.Families[0], font_size);
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
                    foreach(var picpath in Directory.EnumerateFiles(langpath))
                    {
                        // TODO: know is true translate folder or not
                        var ext = Path.GetExtension(picpath).ToLower();
                        if (File.Exists(picpath) && (ext == ".png" || ext == ".bmp"))
                        {
                            languages.Add(Path.GetFileName(langpath));
                            break;
                        }
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
            string[] extensions = { ".png", ".bmp" };
            string[] directories = { design_dir + lang, design_dir, @"design\" + lang, @"design\" };

            foreach (string directory in directories)
            {
                foreach (string extension in extensions)
                {
                    string imagePath = Path.Combine(directory, mask + extension);
                    if (File.Exists(imagePath))
                    {
                        button.Image = Image.FromFile(imagePath);
                        if (button.Image != null)
                        {
                            button.Height = button.Image.Height - 1;
                            button.Width = button.Image.Width - 1;
                            button.Text = "";
                            return;
                        }
                    }
                }
            }
        }

        private void _MouseEnter(object sender, EventArgs e)
        {
            /*foreach (var button in buttons)
            {
                if (sender.Equals(button.button))
                {
                    SetButtonStyle(button.button, button.mask + "_h");
                    return;
                }
            }*/
            var hoveredButton = buttons.FirstOrDefault(b => sender.Equals(b.button));
            if (hoveredButton != null)
            {
                SetButtonStyle(hoveredButton.button, hoveredButton.mask + "_h");
            }
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            /*foreach (var button in buttons)
            {
                if (sender.Equals(button.button))
                {
                    SetButtonStyle(button.button, button.mask + "");
                    return;
                }
            }*/
            var hoveredButton = buttons.FirstOrDefault(b => sender.Equals(b.button));
            if (hoveredButton != null)
            {
                SetButtonStyle(hoveredButton.button, hoveredButton.mask + "");
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
        private bool SoundCheck(string str)
        {
            if (File.Exists(str))
            {
                if (simpleSound.SoundLocation != str)
                    simpleSound.SoundLocation = str;
                return true;
            }
            return false;
        }
        private void BtnS1(object sender, bool fast = false)
        {
            if (!fast)
            {
                var str = string.Format("{0}{1}{2}", design_dir, /*lang,*/ @"click.wav", "");
                var str2 = string.Format("{0}{1}{2}", @"design\", /*lang,*/ @"click.wav", "");
                if (SoundCheck(str))
                {
                    /*WMP.settings.volume = 1000;
                    WMP.URL = design_dir + lang + @"\click.wav";
                    WMP.controls.play();*/
                    simpleSound.Play();
                }
                else if(SoundCheck(str2))
                    simpleSound.Play();

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
            string engine_path = @$"Engine\{ExeName}";
            if (File.Exists(engine_path))
            {
                ProcessStartInfo start = new ProcessStartInfo(Directory.GetCurrentDirectory() +@"\"+ engine_path);
                start.WorkingDirectory = Directory.GetCurrentDirectory() + @"\Engine";
                start.UseShellExecute = false;
                if (Process.Start(start) != null)
                    Application.Exit();
            }
            else
            {
                MessageBox.Show($"{engine_path} not found!");
                BtnS0(sender);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            Options options = new Options();
            //options.Localise("ru",true); // DEBUG: Export translate
            options.Localise(lang);
            var rez = options.ShowDialog();
            if (rez == DialogResult.OK || rez == DialogResult.Cancel)
                BtnS0(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BtnS1(sender);

            string path = @$"lang\{lang}\readme.txt";
            string path_def = @"lang\en\readme.txt";
            if (File.Exists(path))
                SimplyHelper.OpenWithDefaultProgram(path);
            else if(File.Exists(path_def))
                SimplyHelper.OpenWithDefaultProgram(path_def);

            BtnS0(sender);
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
            if (File.Exists(@".\uninstall.exe"))
            {
                var rez = MessageBox.Show("Are you want uninstal EIStarter?", null, MessageBoxButtons.YesNo);
                if (rez != DialogResult.Yes)
                    return;

                ProcessStartInfo start = new ProcessStartInfo(Directory.GetCurrentDirectory() + @".\uninstall.exe");
                start.WorkingDirectory = Directory.GetCurrentDirectory();
                start.UseShellExecute = false;
                if(Process.Start(start) != null)
                    Application.Exit();
            }
            else
            {
                MessageBox.Show(@"Uninstall.exe not found!");
                BtnS0(sender);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            Application.Exit();
        }


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
            cfg.Write("ExeName", ExeName, "Settings");
        }

        private void ModCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnS1(sender);
            var mod = mods[ModCombo.SelectedIndex];
            /*if (!Directory.Exists(mod.path))
            {
                MessageBox.Show(@$"Mod: `{mod.name}` have wrong path: `{mod.path}`");
                BtnS0(sender);
                return;
            }*/


            if (Directory.Exists(mod.path) && Directory.Exists(Path.GetDirectoryName(mod.path) + @"\design\"))
            {
                for (int i = 0; i < languages.Count; i++)
                {
                    if (Directory.Exists(Path.GetDirectoryName(mod.path) + @"\design\" + lang) && isusecustomskins)
                    {
                        design_dir = Path.GetDirectoryName(mod.path) + @"\design\";
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

            APIMode DataSource = APIMode.Win; // use Windows Registry

            IniFile addonini = new IniFile("Engine/addon.ini");
            REGedit addon = new REGedit(@"Software\Gipat.ru\EI_Starter");
            RegIni ri2 = new RegIni(addon, addonini, DataSource);
            var modFullPath = "";
            if (isModsExists)
                modFullPath = Directory.GetCurrentDirectory() + @"\" + Path.GetDirectoryName(mod.path);
            ri2.SetStr("AddonPath", modFullPath, "settings");

            // Get addon.dll version
            try
            {
                if (File.Exists(modFullPath + @"\addon.dll"))
                    NTRlbAddonVer.Text = $"Parhelion(Addon.dll) v{FileVersionInfo.GetVersionInfo(modFullPath + @"\addon.dll").FileVersion}";
                else if (File.Exists(Directory.GetCurrentDirectory() + @"\addon.dll"))
                    NTRlbAddonVer.Text = $"Parhelion(Addon.dll) v{FileVersionInfo.GetVersionInfo(Directory.GetCurrentDirectory() + @"\addon.dll").FileVersion}";
                else
                    NTRlbAddonVer.Text = $"Parhelion(Addon.dll) not found!";
            }
            catch { }


            BtnS0(sender);
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            ModInfo modInfo = new ModInfo();
            modInfo.SetMod(mods[ModCombo.SelectedIndex]);
            //modInfo.Localise("ru", true); // DEBUG: Export translate
            modInfo.Localise(lang);
            var rez = modInfo.ShowDialog();
            if (rez == DialogResult.OK || rez == DialogResult.Cancel)
                BtnS0(sender);
        }

        private void NTRlbAddonVer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Addon.dll version click!
        }
    }
}
