using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //TODO: registry support
            bool isini = false;
            if (isini == true)
            {
                /*
                IniFile game = new IniFile("Engine/config/game.ini");
                IniFile addon = new IniFile("Engine/addon.ini");
                checkBox1.Checked = GetBool(game, "fullscreen", "general settings");
                checkBox2.Checked = GetBool(game, "mipmapping", "general settings");
                checkBox3.Checked = GetBool(game, "antialiasing", "general settings");
                checkBox4.Checked = GetBool(game, "dithering", "general settings");
                checkBox6.Checked = GetBool(game, "FPSIndependentCursor", "general settings");
                //checkBox7.Checked = GetBool(game, "safesound", "general settings");

                numericUpDown1.Text = GetStr(addon, "LandscapeDrawRadius", "settings");
                numericUpDown2.Text = GetStr(addon, "ObjectsDrawRadius", "settings");

                comboBox2.SelectedIndex = GetInt(game, "TextureQuality", "general settings");
                comboBox3.SelectedIndex = GetInt(game, "filtering", "general settings");
                comboBox8.SelectedIndex = GetInt(game, "audio", "general settings");
                comboBox7.SelectedIndex = GetInt(game, "video", "general settings");
                comboBox4.SelectedIndex = GetInt(game, "shadowquality", "shadow settings");
                AdapterBox.SelectedIndex = GetInt(game, "drawingtarget", "general settings");
                ResolutionsBox.SelectedIndex = ResolutionsBox.Items.IndexOf(GetStr(game, "videoresolution", "general settings"));

                int terrainQuality;
                if (GetBool(game, "EnableWaterWaves", "terrain settings"))
                {
                    terrainQuality = 0;
                }
                else if (GetFlt(game, "LOD1", "terrain settings") == 90.0f && GetFlt(game, "LOD2", "terrain settings") == 130.0f)
                {
                    terrainQuality = 1;
                }
                else
                {
                    terrainQuality = 2;
                }
                comboBox5.SelectedIndex = terrainQuality;//m_cbTerrainQuality.SetCurSel(terrainQuality);

                int lightingFreq;
                if (GetInt(game, "LIGHTINGFREQ", "terrain settings") == 1000)
                {
                    lightingFreq = 0;
                }
                else if (GetInt(game, "LIGHTINGFREQ", "terrain settings") == 10000)
                {
                    lightingFreq = 1;
                }
                else
                {
                    lightingFreq = 2;
                }
                comboBox6.SelectedIndex = lightingFreq;

                int shadowingFreq;
                if (GetInt(game, "SHADOWINGFREQ", "terrain settings") == 1000)
                {
                    shadowingFreq = 0;
                }
                else if (GetInt(game, "SHADOWINGFREQ", "terrain settings") == 10000)
                {
                    shadowingFreq = 1;
                }
                else
                {
                    shadowingFreq = 2;
                }
                comboBox1.SelectedIndex = shadowingFreq;
                */
            }
            else
            {
                //var defsec = "Software\\Gipat.ru\\EI_Starter\\EvilIslands\\";
                REGedit addon = new REGedit("Software\\Gipat.ru\\EI_Starter");
                REGedit game = new REGedit("Software\\Gipat.ru\\EI_Starter\\EvilIslands");
                RegIni ri = new RegIni(game);
                checkBox1.Checked = ri.GetBool("fullscreen", "general settings");
                checkBox2.Checked = ri.GetBool("mipmapping", "general settings");
                checkBox3.Checked = ri.GetBool("antialiasing", "general settings");
                checkBox4.Checked = ri.GetBool("dithering", "general settings");
                checkBox6.Checked = ri.GetBool("FPSIndependentCursor", "general settings");
                //checkBox7.Checked = GetBool(game, "safesound", "general settings");
/*
                numericUpDown1.Text = GetStr(addon, "LandscapeDrawRadius", "settings");
                numericUpDown2.Text = GetStr(addon, "ObjectsDrawRadius", "settings");
                */

                comboBox2.SelectedIndex = ri.GetInt("TextureQuality", "general settings");
                comboBox3.SelectedIndex = ri.GetInt("filtering", "general settings");
                comboBox8.SelectedIndex = ri.GetInt("audio", "general settings");
                comboBox7.SelectedIndex = ri.GetInt("video", "general settings");
                comboBox4.SelectedIndex = ri.GetInt("shadowquality", "shadow settings");
                AdapterBox.SelectedIndex = ri.GetInt("drawingtarget", "general settings");
                ResolutionsBox.SelectedIndex = ResolutionsBox.Items.IndexOf(ri.GetStr("videoresolution", "general settings"));

                int terrainQuality;
                if (ri.GetBool("EnableWaterWaves", "terrain settings"))
                {
                    terrainQuality = 0;
                }
                //else if (GetFlt(game, "LOD1", "terrain settings") == 90.0f && GetFlt(game, "LOD2", "terrain settings") == 130.0f)
                //{
                //    terrainQuality = 1;
                //}
                else
                {
                    terrainQuality = 2;
                }
                comboBox5.SelectedIndex = terrainQuality;//m_cbTerrainQuality.SetCurSel(terrainQuality);

                int lightingFreq;
                if (ri.GetInt("LIGHTINGFREQ", "terrain settings") == 1000)
                {
                    lightingFreq = 0;
                }
                else if (ri.GetInt("LIGHTINGFREQ", "terrain settings") == 10000)
                {
                    lightingFreq = 1;
                }
                else
                {
                    lightingFreq = 2;
                }
                comboBox6.SelectedIndex = lightingFreq;

                int shadowingFreq;
                if (ri.GetInt("SHADOWINGFREQ", "terrain settings") == 1000)
                {
                    shadowingFreq = 0;
                }
                else if (ri.GetInt("SHADOWINGFREQ", "terrain settings") == 10000)
                {
                    shadowingFreq = 1;
                }
                else
                {
                    shadowingFreq = 2;
                }
                comboBox1.SelectedIndex = shadowingFreq;
            }
            
            return;




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

            IniFile game = new IniFile("Engine/config/game.ini");
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
