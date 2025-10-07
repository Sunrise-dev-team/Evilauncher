using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
//using WMPLib;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Media;
using System.Windows.Forms;
using static EIStarter.RegIni;

namespace EIStarter
{
    public partial class StarterForm : Form
    {
        // TODO: lang button -> lang(planet) & theme(brush) buttons

        public string lang = "en";
        public string theme = "";

        public string design_dir = @"design\";
        public static string ExeName = @"game.exe";

        public bool isusecustomskins = true;

        // "mod.config" override "config.reg"
        public bool isINImods = false;

        private List<string> languages = [];
        private List<string> themes = [];
        public List<Mod> mods = [];

        private Dictionary<Control, string> btn2maskMap = [];

        // folder "Mods" exists and contains one or more mods
        public bool isModsExists = false;

        //WindowsMediaPlayer WMP = new WindowsMediaPlayer();
        private SoundPlayer simpleSound = new();

        private PrivateFontCollection privateFontCollection = new();

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
        public StarterForm()
        {
            InitializeComponent();
#if DEBUG
            NTRlbDebug1.Visible = true;
#else
            NTRlbDebug1.Visible = false;
#endif
            btn2maskMap.Add(btPlay, "pl");
            btn2maskMap.Add(btOptions, "op");
            btn2maskMap.Add(btReadme, "re");
            btn2maskMap.Add(btWeb, "we");
            btn2maskMap.Add(btUninstall, "un");
            btn2maskMap.Add(btExit, "ex");
            btn2maskMap.Add(btLang, "lang");
            btn2maskMap.Add(btSkin, "theme");
            btn2maskMap.Add(btModInfo, "info");

            EnumerateLangs();


            IniFile cfg = new("starter.config");

            theme = cfg.Read("Theme", "Settings", "");

            string lastsel = cfg.Read("ModSel", "Settings");
            string tempconv = cfg.Read("UsingINIconfigs", "Settings"); //isINImods
            if (!string.IsNullOrWhiteSpace(tempconv))
                isINImods = Convert.ToBoolean(tempconv);

            string tempExeName = cfg.Read("ExeName", "Settings", "game.exe"); // custom EXE
            if (SimplyHelper.ValidateExeName(tempExeName))
                ExeName = tempExeName;

            string currentLanguage = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if (!string.IsNullOrWhiteSpace(currentLanguage))
                lang = cfg.Read("language", "Settings", currentLanguage);
            else
                lang = cfg.Read("language", "Settings", "en");

            if (Directory.Exists(@"Mods\"))
            {
                foreach (string modpath in Directory.EnumerateDirectories(@"Mods\"))
                {
                    if (!File.Exists($@"{modpath}\config.reg") && !File.Exists($@"{modpath}\mod.config"))
                        continue;

                    APIMode curMode = APIMode.EI;

                    IniFile iniCfg = new($@"{modpath}\mod.config");

                    EIRegFile regCfg = new();

                    if (File.Exists($@"{modpath}\config.reg") && !regCfg.isLoaded)
                        regCfg.Load($@"{modpath}\config.reg");


                    if (isINImods && File.Exists($@"{modpath}\mod.config"))
                        curMode = APIMode.INI;
                    else if (!regCfg.isLoaded)
                        continue;

                    RegIni ri = new(regCfg, iniCfg, curMode);

                    Mod mod;
                    if (curMode == APIMode.INI)
                        mod = new() { path = $@"{modpath}\mod.config" };
                    else
                        mod = new() { path = $@"{modpath}\config.reg" };
                    mods.Add(mod);
                    isModsExists = true;

                    mod.name = ri.GetStr("Title", "MOD", "Unkn_Title");
                    //mod.path = $@"{modpath}\mod.config";
                    mod.ver = ri.GetStr("Version", "MOD", "");
                    mod.author = ri.GetStr("Author", "MOD", "Unknown_Author");
                    mod.email = ri.GetStr("AuthorEmail", "MOD", "");
                    mod.site = ri.GetStr("URL", "MOD", "");
                    mod.date = ri.GetStr("date_DMY", "MOD", "");
                    mod.pluginpath = ri.GetStr("pluginpath", "Starter", "none");
                    mod.plugintext = ri.GetStr("plugintext", "Starter", "Plugin");
                    try
                    {
                        mod.issingle = ri.GetBool("Single", "MOD", true);
                    }
                    catch { }
                    try
                    {
                        mod.ismulti = ri.GetBool("Multi", "MOD", true);
                    }
                    catch { }
                    cbbMod.Items.Add(mod.name);
                    if (mod.path == lastsel)
                        cbbMod.SelectedIndex = cbbMod.Items.Count - 1;

                    if (cbbMod.SelectedIndex < 0)
                        cbbMod.SelectedIndex = 0;
                }
            }
            else
            {
                Mod mod = new() { path = $@"\mod.config" };
                mods.Add(mod);
                isModsExists = false;

                cbbMod.Items.Clear();
                cbbMod.Items.Add("No mods");
                cbbMod.SelectedIndex = cbbMod.Items.Count - 1;
                //cbbMod.Visible = false;
            }

            /*if (File.Exists(@"design\" + lang + @"\autorun.mp3"))
            {
                WindowsMediaPlayer WMP = new WindowsMediaPlayer();
                WMP.settings.volume = 1000;
                WMP.URL = @"design\" + lang + @"\autorun.mp3";
                WMP.controls.play();
            }*/

            EnumerateThemes();

            InitLang();


            if (SimplyHelper.IsGameRuning())
                MessageBox.Show("game runing!", "Warning!");

            NTRlbDebug1.Text = theme;
        }

        /// <summary>
        /// Set style for all elements by current design_dir + lang.
        /// </summary>
        public void InitLang()
        {
            string[] imgExt = { ".png",".gif", ".bmp" };
            string[] fontExt = { ".otf", ".ttf" };

            string[] directories = GetPriorityDirs();

            string filename = "back";
            bool fullbreak = false;
            try
            {
                foreach (string directory in directories)
                {
                    foreach (string extension in imgExt)
                    {
                        string imagePath = Path.Combine(directory, filename + extension);
                        if (File.Exists(imagePath))
                        {
                            // TODO: animated gif background?
                            /*if (extension == ".gif")
                            {
                                //animatedImage = new Bitmap(Image.FromFile(imagePath));
                                NTRimgBack.Image = Image.FromFile(imagePath);
                                NTRimgBack.Visible = true;
                            }
                            else
                            {*/
                                BackgroundImage = Image.FromFile(imagePath);
                            //    NTRimgBack.Visible = false;
                            //    NTRimgBack.Image = null;
                            //}
                            fullbreak = true;
                        }
                        if (fullbreak)
                            break;
                    }
                    if (fullbreak)
                        break;
                }
            }
            catch { }

            filename = "logo";
            fullbreak = false;
            try
            {
                foreach (string directory in directories)
                {
                    foreach (string extension in imgExt)
                    {
                        string imagePath = Path.Combine(directory, filename + extension);
                        if (File.Exists(imagePath))
                        {
                            NTRimgLogo.Image = Image.FromFile(imagePath);
                            fullbreak = true;
                        }
                        if (fullbreak)
                            break;
                    }
                    if (fullbreak)
                        break;
                }
                NTRimgLogo.Width = NTRimgLogo.Image.Width;
                NTRimgLogo.Height = NTRimgLogo.Image.Height;
                NTRimgLogo.Location = new Point(x: Width / 2 - NTRimgLogo.Width / 2, y: 0);
            }
            catch { }

            foreach (var button in btn2maskMap)
                SetButtonStyle((Button)button.Key, button.Value);

            //TODO: Switch construction is faster?
            // FONT
            float font_size = 10.7f;
            Font font = new("Arial", font_size);
            if (privateFontCollection.Families.Length > 0)
                privateFontCollection.Families[0].Dispose(); // TODO: check 

            fullbreak = false;
            try
            {
                foreach (var dir in directories)
                {
                    foreach (var ext in fontExt)
                    {
                        if (File.Exists(Path.Combine(dir, "font" + ext)))
                            privateFontCollection.AddFontFile(Path.Combine(dir, "font" + ext));
                        if (privateFontCollection.Families.Length != 0)
                            fullbreak = true;

                        if (fullbreak)
                            break;
                    }
                    if (fullbreak)
                        break;
                }
            }
            catch { }

            if (privateFontCollection.Families.Length > 0)
            {
                font = new Font(privateFontCollection.Families[0], font_size);
                cbbMod.Font = font;
            }

            // Other
            cbbMod.Location = new Point(x: btPlay.Location.X + btPlay.Width + 10, y: cbbMod.Location.Y);
            btModInfo.Location = new Point(x: cbbMod.Location.X + cbbMod.Width + 10, y: btModInfo.Location.Y);
            btLang.Location = new Point(x: 1, y: this.Height - btLang.Height - 1);
            btSkin.Location = new Point(x: btLang.Location.X + btLang.Width + 1, y: this.Height - btSkin.Height - 1);
        }

        /// <summary>
        /// Get all language codes in 'lang' directory.
        /// (old) Get all langs names in design_dir
        /// </summary>
        public void EnumerateLangs()
        {
            if (Directory.Exists("lang"))
            {
                languages.Clear();
                foreach (var langpath in Directory.EnumerateDirectories("lang"))
                {
                    // TODO: know is true translate folder or not

                    languages.Add(Path.GetFileName(langpath));
                }
                //InitLang();
            }
            if (languages.Count < 1)
                languages.Add("en");
        }

        /// <summary>
        /// Get design folder and enumerate themes in directory.
        /// </summary>
        public void EnumerateThemes()
        {
            if (cbbMod.SelectedIndex >= 0)
            {
                var mod = mods[cbbMod.SelectedIndex];

                if (File.Exists(mod.path)
                    && Directory.Exists($@"{Path.GetDirectoryName(mod.path)}\design\")
                    )
                {
                    design_dir = $@"{Path.GetDirectoryName(mod.path)}\design\";
                }
                else //if (design_dir != @"design\")
                    design_dir = @"design\";
            }
            else
                design_dir = @"design\";

            themes.Clear();
            foreach (var dir in new string[] { design_dir, @"design\" })
            {
                if (!Directory.Exists(dir))
                    continue;
                foreach (var langpath in Directory.EnumerateDirectories(dir))
                {
                    if (!langpath.ToLowerInvariant().EndsWith("locale")
                        && !themes.Contains(Path.GetFileName(langpath))
                        )
                        themes.Add(Path.GetFileName(langpath));
                }
            }
            //if (themes.Count < 1)
            themes.Add("");
        }

        /// <summary>
        /// Generate design directory priority list
        /// </summary>
        /// <returns></returns>
        public string[] GetPriorityDirs()
        {
            // TODO: HOT! sort by lang or by theme
            return [
                @$"{design_dir}{theme}\locale\{lang}\",
                @$"{design_dir}{theme}\",
                @$"{design_dir}locale\{lang}\",
                design_dir,

                @$"design\{theme}\locale\{lang}\",
                @$"design\{theme}\",
                @$"design\locale\{lang}\",
                @"design\" ];
        }

        /// <summary>
        /// Set button image. Autosize to image.
        /// </summary>
        /// <param name="button">target Button</param>
        /// <param name="mask">img name mask</param>
        private void SetButtonStyle(Button button, string mask)
        {
            string[] extensions = [".png", ".bmp"];
            string[] directories = GetPriorityDirs();

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
            if (btn2maskMap.ContainsKey((Control)sender))
                SetButtonStyle((Button)sender, btn2maskMap[(Control)sender] + "_h");
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            if (btn2maskMap.ContainsKey((Control)sender))
                SetButtonStyle((Button)sender, btn2maskMap[(Control)sender]);
        }

        private void StarterForm_MouseMove(object sender, MouseEventArgs e)
        {
            var s = (Control)sender;
            s.Capture = false;
            //this.Opacity = 0.9; 
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void BtnS0(object sender)
        {
            if (btn2maskMap.ContainsKey((Control)sender))
                SetButtonStyle((Button)sender, btn2maskMap[(Control)sender]);
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
                foreach (var path in GetPriorityDirs())
                {
                    if (SoundCheck(Path.Combine(path, "click.wav")))
                    {
                        /*
                        WMP.settings.volume = 1000;
                        WMP.URL = design_dir + lang + @"\click.wav";
                        WMP.controls.play();
                        */
                        simpleSound.Play();
                        break;
                    }
                }

                foreach (var button in btn2maskMap)
                {
                    if (button.Key.Equals(sender))
                        SetButtonStyle((Button)button.Key, button.Value + "_d");
                    else
                        SetButtonStyle((Button)button.Key, button.Value);
                }
            }
            else
            {
                foreach (var button in btn2maskMap)
                {
                    if (button.Key.Equals(sender))
                    {
                        SetButtonStyle((Button)button.Key, button.Value + "_d");
                        return;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnS1(sender);

            if (!SimplyHelper.ValidateExeName(ExeName))
                ExeName = "game.exe";

            string engine_path = @$"Engine\{ExeName}";
            if (File.Exists(engine_path))
            {
                ProcessStartInfo start = new($@"{Directory.GetCurrentDirectory()}\{engine_path}")
                {
                    WorkingDirectory = $@"{Directory.GetCurrentDirectory()}\Engine",
                    UseShellExecute = false
                };
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
            Options options = new();
            //options.Localise("ru",true); // DEBUG: Export translate
            options.Localise(lang);
            options.ShowDialog();
            BtnS0(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BtnS1(sender);

            string path = @$"lang\{lang}\readme.txt";
            string path_def = @"lang\en\readme.txt";
            if (File.Exists(path))
                SimplyHelper.OpenWithDefaultProgram(path);
            else if (File.Exists(path_def))
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
                DialogResult rez = MessageBox.Show("Are you want uninstal EIStarter?", null, MessageBoxButtons.YesNo);
                if (rez != DialogResult.Yes)
                    return;

                ProcessStartInfo start = new(Directory.GetCurrentDirectory() + @".\uninstall.exe")
                {
                    WorkingDirectory = Directory.GetCurrentDirectory(),
                    UseShellExecute = false
                };
                if (Process.Start(start) != null)
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
                    break;
                }
                if (i == languages.Count - 1)
                    lang = languages[0];
            }
            InitLang();
        }

        /// <summary>
        /// Set next theme from themes list.
        /// </summary>
        private void ThemeSwitch()
        {

            for (int i = 0; i < themes.Count; i++)
            {
                if (themes[i] == theme && i != themes.Count - 1)
                {
                    theme = themes[i + 1];
                    break;
                }
                if (i == themes.Count - 1)
                    theme = themes[0];
            }
            NTRlbDebug1.Text = theme;
            InitLang();
        }

        private void langbtn_Click(object sender, EventArgs e)
        {
            BtnS1(sender, true);

            LangSwitch();
        }

        private void skinbtn_Click(object sender, EventArgs e)
        {
            BtnS1(sender, true);

            ThemeSwitch();
        }

        private void StarterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IniFile cfg = new("starter.config");

            if (cbbMod.SelectedIndex >= 0)
                cfg.Write("ModSel", mods[cbbMod.SelectedIndex].path, "Settings");
            cfg.Write("language", lang, "Settings");
            cfg.Write("Theme", theme, "Settings");
            cfg.Write("ModSkins", isusecustomskins.ToString(), "Settings");
            cfg.Write("UsingINIconfigs", isINImods.ToString(), "Settings");
            cfg.Write("ExeName", ExeName, "Settings");
        }

        private void ModCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnS1(sender);
            Mod mod = mods[cbbMod.SelectedIndex];
            /*if (!Directory.Exists(mod.path))
            {
                MessageBox.Show(@$"Mod: `{mod.name}` have wrong path: `{mod.path}`");
                BtnS0(sender);
                return;
            }*/

            EnumerateLangs();
            EnumerateThemes();

            InitLang();

            APIMode DataSource = APIMode.Win; // use Windows Registry

            IniFile addonini = new("Engine/addon.ini");
            REGedit addon = new(@"Software\Gipat.ru\EI_Starter");
            RegIni ri2 = new(addon, addonini, DataSource);
            var modFullPath = "";
            if (isModsExists)
                modFullPath = $@"{Directory.GetCurrentDirectory()}\{Path.GetDirectoryName(mod.path)}";
            ri2.SetStr("AddonPath", modFullPath, "settings");

            // Get addon.dll version
            try
            {
                if (File.Exists(@$"{modFullPath}\addon.dll"))
                    NTRlbAddonVer.Text = $"Parhelion(Addon.dll) v{FileVersionInfo.GetVersionInfo(@$"{modFullPath}\addon.dll").FileVersion}";
                else if (File.Exists($@"{Directory.GetCurrentDirectory()}\addon.dll"))
                    NTRlbAddonVer.Text = $"Parhelion(Addon.dll) v{FileVersionInfo.GetVersionInfo($@"{Directory.GetCurrentDirectory()}\addon.dll").FileVersion}";
                else
                    NTRlbAddonVer.Text = $"Parhelion(Addon.dll) not found!";
            }
            catch { }


            BtnS0(sender);
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            BtnS1(sender);
            if (cbbMod.SelectedIndex < 0)
            {
                BtnS0(sender);
                return;
            }
            ModInfo modInfo = new();
            modInfo.SetMod(mods[cbbMod.SelectedIndex]);
            //modInfo.Localise("ru", true); // DEBUG: Export translate
            modInfo.Localise(lang);
            modInfo.ShowDialog();
            BtnS0(sender);
        }

        private void NTRlbAddonVer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Addon.dll version click!
        }

    }
}
