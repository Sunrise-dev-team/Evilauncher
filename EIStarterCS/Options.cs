using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EIStarterCS.StarterForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EIStarterCS
{
    public partial class Options : Form
    {
        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(
              string deviceName, int modeNum, ref DEVMODE devMode);
        //const int ENUM_CURRENT_SETTINGS = -1;

        //const int ENUM_REGISTRY_SETTINGS = -2;

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {

            private const int CCHDEVICENAME = 0x20;
            private const int CCHFORMNAME = 0x20;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;

        }



        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct DISPLAY_DEVICE
        {
            public int cb;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DeviceName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceString;
            public int StateFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceKey;
        }

        [DllImport("user32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

        public Options()
        {
            InitializeComponent();
            AdapterBox.Items.Add("Primary Videodriver");

            uint deviceIndex = 0;
            DISPLAY_DEVICE displayDevice = new DISPLAY_DEVICE();
            displayDevice.cb = Marshal.SizeOf(displayDevice);

            while (EnumDisplayDevices(null, deviceIndex, ref displayDevice, 0))
            {
                if (!AdapterBox.Items.Contains(displayDevice.DeviceString))
                    AdapterBox.Items.Add(displayDevice.DeviceString);
                //Console.WriteLine("Device Name: " + displayDevice.DeviceName);
                //Console.WriteLine("Device String: " + displayDevice.DeviceString);
                //Console.WriteLine("Device ID: " + displayDevice.DeviceID);
                //Console.WriteLine("Device Key: " + displayDevice.DeviceKey);

                deviceIndex++;
                displayDevice.cb = Marshal.SizeOf(displayDevice);
            }



            DEVMODE vDevMode = new DEVMODE();
            int i = 0;
            while (EnumDisplaySettings(null, i, ref vDevMode))
            {
                if (!ResolutionsBox.Items.Contains(vDevMode.dmPelsWidth + @"x" + vDevMode.dmPelsHeight))// + @" " + vDevMode.dmBitsPerPel))
                    ResolutionsBox.Items.Add(vDevMode.dmPelsWidth + @"x" + vDevMode.dmPelsHeight);// + @" " + vDevMode.dmBitsPerPel);
                i++;
            }
            initSettings();
        }
        private void initSettings()
        {
            //TODO: registry/ini switch support

            RegIni.Mode DataSource = RegIni.Mode.Win;

            IniFile gameini = new IniFile("Engine/config/game.ini");
            IniFile addonini = new IniFile("Engine/addon.ini");

            REGedit addon = new REGedit("Software\\Gipat.ru\\EI_Starter");
            REGedit game = new REGedit("Software\\Gipat.ru\\EI_Starter\\EvilIslands");

            RegIni ri = new RegIni(game, gameini, DataSource);
            RegIni ri2 = new RegIni(addon, addonini, DataSource);

            //ri.SetMode(DataSource);
            //ri2.SetMode(DataSource);


            checkBox1.Checked = ri.GetBool("fullscreen", "general settings");
            checkBox2.Checked = ri.GetBool("mipmapping", "general settings");
            checkBox3.Checked = ri.GetBool("antialiasing", "general settings");
            checkBox4.Checked = ri.GetBool("dithering", "general settings");
            checkBox6.Checked = ri.GetBool("FPSIndependentCursor", "general settings");
            //checkBox7.Checked = GetBool(game, "safesound", "general settings");

            numericUpDown1.Value = ri2.GetInt("LandscapeDrawRadius", "settings");
            numericUpDown2.Value = ri2.GetInt("ObjectsDrawRadius", "settings");

            comboBox2.SelectedIndex = ri.GetInt("TextureQuality", "general settings");
            comboBox3.SelectedIndex = ri.GetInt("filtering", "general settings");
            comboBox8.SelectedIndex = ri.GetInt("audio", "general settings");
            comboBox7.SelectedIndex = ri.GetInt("video", "general settings");
            comboBox4.SelectedIndex = ri.GetInt("shadowquality", "shadow settings");

            AdapterBox.SelectedIndex = ri.GetInt("drawingtarget", "general settings");
            ResolutionsBox.SelectedIndex = ResolutionsBox.Items.IndexOf(ri.GetStr("videoresolution", "general settings"));

            int terrainQuality;
            if (ri.GetBool("EnableWaterWaves", "terrain settings"))
                terrainQuality = 0;
            else if (ri.GetFlt("LOD1", "terrain settings") == 90.0f && ri.GetFlt("LOD2", "terrain settings") == 130.0f)
                terrainQuality = 1;
            else
                terrainQuality = 2;
            comboBox5.SelectedIndex = terrainQuality;

            int lightingFreq;
            if (ri.GetInt("LIGHTINGFREQ", "terrain settings") == 1000)
                lightingFreq = 0;
            else if (ri.GetInt("LIGHTINGFREQ", "terrain settings") == 10000)
                lightingFreq = 1;
            else
                lightingFreq = 2;
            comboBox6.SelectedIndex = lightingFreq;

            int shadowingFreq;
            if (ri.GetInt("SHADOWINGFREQ", "terrain settings") == 1000)
                shadowingFreq = 0;
            else if (ri.GetInt("SHADOWINGFREQ", "terrain settings") == 10000)
                shadowingFreq = 1;
            else
                shadowingFreq = 2;
            comboBox1.SelectedIndex = shadowingFreq;

            return;
        }

        private void ApplySettings()
        {
            //TODO: registry/ini switch support

            RegIni.Mode DataSource = RegIni.Mode.Win;

            IniFile gameini = new IniFile("Engine/config/game.ini");
            IniFile addonini = new IniFile("Engine/addon.ini");

            REGedit addon = new REGedit("Software\\Gipat.ru\\EI_Starter");
            REGedit game = new REGedit("Software\\Gipat.ru\\EI_Starter\\EvilIslands");

            RegIni ri = new RegIni(game, gameini, DataSource);
            RegIni ri2 = new RegIni(addon, addonini, DataSource);


            ri.SetBool("fullscreen", checkBox1.Checked, "general settings");
            ri.SetBool("mipmapping", checkBox2.Checked, "general settings");
            ri.SetBool("antialiasing", checkBox3.Checked, "general settings");
            ri.SetBool("dithering", checkBox4.Checked, "general settings");
            ri.SetBool("FPSIndependentCursor", checkBox6.Checked, "general settings");

            numericUpDown1.Value = ri2.GetInt("LandscapeDrawRadius", "settings");
            numericUpDown2.Value = ri2.GetInt("ObjectsDrawRadius", "settings");

            ri.SetInt("TextureQuality", comboBox2.SelectedIndex, "general settings");
            ri.SetInt("filtering", comboBox3.SelectedIndex, "general settings");
            ri.SetInt("audio", comboBox8.SelectedIndex, "general settings");
            ri.SetInt("video", comboBox7.SelectedIndex, "general settings");
            ri.SetInt("shadowquality", comboBox4.SelectedIndex, "shadow settings");


            ri.SetInt("drawingtarget", AdapterBox.SelectedIndex, "general settings");
            ri.SetStr("videoresolution", ResolutionsBox.SelectedItem.ToString(), "general settings"); //TODO: add resolution validation
            

            int terrainQuality = comboBox5.SelectedIndex;
            if (terrainQuality < 2)
            {
                //ri.SetFlt("LOD1", 90.0f, "terrain settings");
                //ri.SetFlt("LOD2", 130.0f, "terrain settings");
                if (terrainQuality == 0)
                    ri.SetBool("EnableWaterWaves", true, "terrain settings");
                else
                    ri.SetBool("EnableWaterWaves", false, "terrain settings");
            }
            else
            {
                //ri.SetFlt("LOD1", /*FIXME: ??? - 90.0f - ???, "terrain settings");
                //ri.SetFlt("LOD2", ??? - 130.0f - ???, "terrain settings");
                ri.SetBool("EnableWaterWaves", false, "terrain settings");
            }

            
            int lightingFreq = comboBox6.SelectedIndex;
            switch (lightingFreq)
            {
                case 0:
                    ri.SetInt("LIGHTINGFREQ", 1000, "terrain settings");
                    break;
                case 1:
                    ri.SetInt("LIGHTINGFREQ", 10000, "terrain settings");
                    break;
                case 2:
                    ri.SetInt("LIGHTINGFREQ", 100000 /*FIXME: ??? */, "terrain settings");
                    break;
                default:
                    ri.SetInt("LIGHTINGFREQ", 100000 /*FIXME: ??? */, "terrain settings");
                    break;
            }
            
            int shadowingFreq = comboBox1.SelectedIndex;
            switch (shadowingFreq)
            {
                case 0:
                    ri.SetInt("SHADOWINGFREQ", 1000, "terrain settings");
                    break;
                case 1:
                    ri.SetInt("SHADOWINGFREQ", 10000, "terrain settings");
                    break;
                case 2:
                    ri.SetInt("SHADOWINGFREQ", 100000 /*FIXME: ??? */, "terrain settings");
                    break;
                default:
                    ri.SetInt("SHADOWINGFREQ", 100000 /*FIXME: ??? */, "terrain settings");
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            if (!numericUpDown1.Validate())
            {
                button2.Enabled = false;
            }
            //if()
        }


        private void _Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown tmp = (NumericUpDown)sender;
            if (Convert.ToString(tmp.Value) == "")
            {
                e.Cancel = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplySettings();
            //IniFile game = new IniFile("Engine/config/game.ini");
            /*SetBool(game, "fullscreen", checkBox1.Checked, "general settings");
            SetBool(game, "mipmapping", checkBox2.Checked, "general settings");
            SetBool(game, "antialiasing", checkBox3.Checked, "general settings");
            SetBool(game, "dithering", checkBox4.Checked, "general settings");
            SetBool(game, "FPSIndependentCursor", checkBox6.Checked, "general settings");
            checkBox4.Checked = GetBool(game, "dithering", "general settings");
            //checkBox1.Checked = GetBool(game, "fullscreen", "general settings");
            */
        }
    }
}
