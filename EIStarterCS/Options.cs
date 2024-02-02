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
        #region CAMERA struct
        public class CamShortcut
        {
            //[Browsable(true)]
            //[Description("Property: Shortcut")]
            //[Category("Shortcuts")]

            public float Distance { get; set; }
            public float AxisX { get; set; }
            public float AxisY { get; set; }
            public float AxisZ { get; set; }
            public float Angle { get; set; }
            public float Pitch { get; set; }
            public override string ToString()
            {
                return string.Format("Dist: {0}, Axis({1},{2},{3}), Angle: {4}, Pitch: {5}", float.Round(Distance,2),AxisX,AxisY,AxisZ,Angle, float.Round(Pitch, 2));
            }
        }
        public class CamMoveParam
        {
            public float Speed { get; set; }
            public float PowerMouse { get; set; }
            public float PowerKeyboard { get; set; }
            public override string ToString()
            {
                return string.Format("Speed: {0}, PwrMouse: {1}, PwrKey: {2}",Speed,PowerMouse,PowerKeyboard);
            }
        }
        public class CamMinMaxDefParam
        {
            public float Min { get; set; }
            public float Max { get; set; }
            public float Default { get; set; }
            public override string ToString()
            {
                return string.Format("Range: [{0} : {1} : {2}]",Min,Default, float.Round(Max, 2));
            }
        }
        public class CamMinMaxParam
        {
            public float Min { get; set; }
            public float Max { get; set; }
            public override string ToString()
            {
                return string.Format("Range: [{0} : {1}]", Min, float.Round(Max, 2));
            }
        }
        #endregion
        #region camprop
        class PropertyCategories
        {
            bool m_FlipXAxis;
            [Browsable(true)]
            [Description("Property: FlipXAxis")]
            [Category("General")]
            [DisplayName("Flip X Axis")]
            public bool FlipXAxis
            {
                get { return m_FlipXAxis; }
                set { m_FlipXAxis = value; }
            }

            bool m_FlipYAxis;
            [Browsable(true)]
            [Description("Property: FlipYAxis")]
            [Category("General")]
            [DisplayName("Flip Y Axis")]
            public bool FlipYAxis
            {
                get { return m_FlipYAxis; }
                set { m_FlipYAxis = value; }
            }

            float m_FarClipDistance;
            [Browsable(true)]
            [Description("Property: FarClipDistance")]
            [Category("General")]
            [DisplayName("Clip Distance: Far")]
            public float FarClipDistance
            {
                get { return m_FarClipDistance; }
                set { m_FarClipDistance = value; }
            }

            float m_NearClipDistance;
            [Browsable(true)]
            [Description("Property: NearClipDistance")]
            [Category("General")]
            [DisplayName("Clip Distance: Near")]
            public float NearClipDistance
            {
                get { return m_NearClipDistance; }
                set { m_NearClipDistance = value; }
            }

            float m_TerrainSensetiveArea;
            [Browsable(true)]
            [Description("Property: TerrainSensetiveArea")]
            [Category("Area")]
            [DisplayName("Terrain Sensetive")]
            public float TerrainSensetiveArea
            {
                get { return m_TerrainSensetiveArea; }
                set { m_TerrainSensetiveArea = value; }
            }

            int m_BorderScrollArea;
            [Browsable(true)]
            [Description("Property: BorderScrollArea")]
            [Category("Area")]
            [DisplayName("Border Scroll")]
            public int BorderScrollArea
            {
                get { return m_BorderScrollArea; }
                set { m_BorderScrollArea = value; }
            }

            int m_FrameSelectionSensetiveArea;
            [Browsable(true)]
            [Description("Property: FrameSelectionSensetiveArea")]
            [Category("Area")]
            [DisplayName("Frame Selection Sensetive")]
            public int FrameSelectionSensetiveArea
            {
                get { return m_FrameSelectionSensetiveArea; }
                set { m_FrameSelectionSensetiveArea = value; }
            }

            /// <summary>
            /// CAMERA
            /// </summary>

            CamMinMaxDefParam m_Height = new CamMinMaxDefParam();
            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Camera")]
            [DisplayName("Height")]
            public CamMinMaxDefParam Height
            {
                get { return m_Height; }
                set { m_Height = value; }
            }

            CamMinMaxDefParam m_DistanceToCarrier = new CamMinMaxDefParam();
            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Camera")]
            [DisplayName("Distance To Carrier")]
            public CamMinMaxDefParam DistanceToCarrier
            {
                get { return m_DistanceToCarrier; }
                set { m_DistanceToCarrier = value; }
            }

            CamMinMaxParam m_LimitDistanceToCarrier = new CamMinMaxParam();
            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Camera")]
            [DisplayName("Distance To Carrier Limit")]
            public CamMinMaxParam LimitDistanceToCarrier
            {
                get { return m_LimitDistanceToCarrier; }
                set { m_LimitDistanceToCarrier = value; }
            }

            CamMinMaxParam m_DefaultPitch = new CamMinMaxParam();
            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Camera")]
            [DisplayName("Pitch")]
            public CamMinMaxParam DefaultPitch
            {
                get { return m_DefaultPitch; }
                set { m_DefaultPitch = value; }
            }

            /// <summary>
            /// BRIEF CAMERA
            /// </summary>

            CamMinMaxParam m_BriefDistanceToCarrier = new CamMinMaxParam();
            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Briefing Camera")]
            [DisplayName("Distance To Carrier")]
            public CamMinMaxParam BriefDistanceToCarrier
            {
                get { return m_BriefDistanceToCarrier; }
                set { m_BriefDistanceToCarrier = value; }
            }

            CamMinMaxParam m_BriefLimitDistanceToCarrier = new CamMinMaxParam();
            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Briefing Camera")]
            [DisplayName("Distance To Carrier Limit")]
            public CamMinMaxParam BriefLimitDistanceToCarrier
            {
                get { return m_BriefLimitDistanceToCarrier; }
                set { m_BriefLimitDistanceToCarrier = value; }
            }

            CamMinMaxParam m_BriefDefaultPitch = new CamMinMaxParam();
            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Briefing Camera")]
            [DisplayName("Pitch")]
            public CamMinMaxParam BriefDefaultPitch
            {
                get { return m_BriefDefaultPitch; }
                set { m_BriefDefaultPitch = value; }
            }

            /// <summary>
            /// SHORTCUTS
            /// </summary>
            
            private CamShortcut m_Shortcut0 = new CamShortcut();
            private CamShortcut m_Shortcut1 = new CamShortcut();
            private CamShortcut m_Shortcut2 = new CamShortcut();
            private CamShortcut m_Shortcut3 = new CamShortcut();
            private CamMoveParam m_Pitch = new CamMoveParam();
            private CamMoveParam m_Rotate = new CamMoveParam();
            private CamMoveParam m_Scroll = new CamMoveParam();
            private CamMoveParam m_Zoom = new CamMoveParam();

            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("General")]
            [DisplayName("Pitch")]
            public CamMoveParam Pitch
            {

                get { return m_Pitch; }
                set { m_Pitch = value; }
            }

            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("General")]
            [DisplayName("Rotate")]
            public CamMoveParam Rotate
            {

                get { return m_Rotate; }
                set { m_Rotate = value; }
            }

            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("General")]
            [DisplayName("Scroll")]
            public CamMoveParam Scroll
            {

                get { return m_Scroll; }
                set { m_Scroll = value; }
            }

            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("General")]
            [DisplayName("Zoom")]
            public CamMoveParam Zoom
            {

                get { return m_Zoom; }
                set { m_Zoom = value; }
            }

            float m_XDeploy;
            [Browsable(true)]
            [Description("Property: XDeploy")]
            [Category("General")]
            [DisplayName("Deploy X")]
            public float XDeploy
            {
                get { return m_XDeploy; }
                set { m_XDeploy = value; }
            }

            float m_YDeploy;
            [Browsable(true)]
            [Description("Property: YDeploy")]
            [Category("General")]
            [DisplayName("Deploy Y")]
            public float YDeploy
            {
                get { return m_YDeploy; }
                set { m_YDeploy = value; }
            }

            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Shortcuts")]
            [DisplayName("Shortcut 0")]
            public CamShortcut Shortcut0
            {

                get { return m_Shortcut0; }
                set { m_Shortcut0 = value; }
            }

            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Shortcuts")]
            [DisplayName("Shortcut 1")]
            public CamShortcut Shortcut1
            {
                get { return m_Shortcut1; }
                set { m_Shortcut1 = value; }
            }

            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Shortcuts")]
            [DisplayName("Shortcut 2")]
            public CamShortcut Shortcut2
            {
                get { return m_Shortcut2; }
                set { m_Shortcut2 = value; }
            }

            [TypeConverter(typeof(ExpandableObjectConverter))]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Category("Shortcuts")]
            [DisplayName("Shortcut 3")]
            public CamShortcut Shortcut3
            {
                get { return m_Shortcut3; }
                set { m_Shortcut3 = value; }
            }
        }
#endregion
        private void readshortcut(RegIni ri, CamShortcut cut, string regname)
        {
            cut.Distance = ri.GetFlt(regname + "Distance", "camera settings");
            cut.AxisX = ri.GetFlt(regname + "AxisX", "camera settings");
            cut.AxisY = ri.GetFlt(regname + "AxisY", "camera settings");
            cut.AxisZ = ri.GetFlt(regname + "AxisZ", "camera settings");
            cut.Angle = ri.GetFlt(regname + "Angle", "camera settings");
            cut.Pitch = ri.GetFlt(regname + "Pitch", "camera settings");
        }
        private void readminmax(RegIni ri, CamMinMaxParam cut, string regname)
        {
            cut.Min = ri.GetFlt(string.Format(regname, "Min"), "camera settings");
            cut.Max = ri.GetFlt(string.Format(regname, "Max"), "camera settings");
        }
        private void readminmaxdef(RegIni ri, CamMinMaxDefParam cut, string regname)
        {
            cut.Min = ri.GetFlt(string.Format(regname, "Min"), "camera settings");
            cut.Max = ri.GetFlt(string.Format(regname, "Max"), "camera settings");
            cut.Default = ri.GetFlt(string.Format(regname, "Default"), "camera settings");
        }
        private void readmov(RegIni ri, CamMoveParam cut, string regname)
        {
            cut.Speed = ri.GetFlt(string.Format(regname, "Speed"), "camera settings");
            cut.PowerKeyboard = ri.GetFlt(string.Format(regname, "PowerKeyboard"), "camera settings");
            cut.PowerMouse = ri.GetFlt(string.Format(regname, "PowerMouse"), "camera settings");
        }
        private void writeshortcut(RegIni ri, CamShortcut cut, string regname)
        {
            //TODO shortcut write
            cut.Distance = ri.GetFlt(regname + "Distance", "camera settings");
            cut.AxisX = ri.GetFlt(regname + "AxisX", "camera settings");
            cut.AxisY = ri.GetFlt(regname + "AxisY", "camera settings");
            cut.AxisZ = ri.GetFlt(regname + "AxisZ", "camera settings");
            cut.Angle = ri.GetFlt(regname + "Angle", "camera settings");
            cut.Pitch = ri.GetFlt(regname + "Pitch", "camera settings");
        }
        private void writeminmax(RegIni ri, CamMinMaxParam cut, string regname)
        {
            ri.SetFlt(string.Format(regname, "Min"), cut.Min, "camera settings");
            ri.SetFlt(string.Format(regname, "Max"), cut.Max, "camera settings");
        }
        private void writeminmaxdef(RegIni ri, CamMinMaxDefParam cut, string regname)
        {
            ri.SetFlt(string.Format(regname, "Min"), cut.Min, "camera settings");
            ri.SetFlt(string.Format(regname, "Max"), cut.Max, "camera settings");
            ri.SetFlt(string.Format(regname, "Default"), cut.Default, "camera settings");
        }
        private void writemov(RegIni ri, CamMoveParam cut, string regname)
        {
            ri.SetFlt(string.Format(regname, "Speed"), cut.Speed, "camera settings");
            ri.SetFlt(string.Format(regname, "PowerKeyboard"), cut.PowerKeyboard, "camera settings");
            ri.SetFlt(string.Format(regname, "PowerMouse"), cut.PowerMouse, "camera settings");
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

            propertyGrid1.SelectedObject = new PropertyCategories();
            PropertyCategories prop = (PropertyCategories)propertyGrid1.SelectedObject;
            
            prop.BorderScrollArea = ri.GetInt("CameraBorderScrollArea", "camera settings");
            prop.TerrainSensetiveArea = ri.GetFlt("CameraTerrainSensetiveArea", "camera settings");
            prop.FrameSelectionSensetiveArea = ri.GetInt("CameraFrameSelectionSensetiveArea", "camera settings");

            prop.FarClipDistance = ri.GetFlt("FarClipDistance", "camera settings");
            prop.NearClipDistance = ri.GetFlt("NearClipDistance", "camera settings");
            prop.FlipXAxis = ri.GetBool("CameraFlipXAxis", "camera settings");
            prop.FlipYAxis = ri.GetBool("CameraFlipYAxis", "camera settings");
            prop.XDeploy = ri.GetFlt("CAMERADEFAULTXDEPLOY", "camera settings");
            prop.YDeploy = ri.GetFlt("CAMERADEFAULTYDEPLOY", "camera settings");

            readshortcut(ri, prop.Shortcut0, "CameraShortcut 0 ");
            readshortcut(ri, prop.Shortcut1, "CameraShortcut 1 ");
            readshortcut(ri, prop.Shortcut2, "CameraShortcut 2 ");
            readshortcut(ri, prop.Shortcut3, "CameraShortcut 3 ");

            readminmax(ri, prop.DefaultPitch, "CameraDefault{0}Pitch");
            readminmax(ri, prop.LimitDistanceToCarrier, "Camera{0}LimitDistanceToCarrier");
            readminmax(ri, prop.BriefLimitDistanceToCarrier, "CameraBriefing{0}LimitDistanceToCarrier");
            readminmax(ri, prop.BriefDistanceToCarrier, "CameraBriefing{0}DistanceToCarrier");
            readminmax(ri, prop.BriefDefaultPitch, "CameraBriefing{0}Pitch");
            readminmaxdef(ri, prop.DistanceToCarrier, "Camera{0}DistanceToCarrier");
            readminmaxdef(ri, prop.Height, "Camera{0}Height");

            readmov(ri, prop.Pitch, "CameraDefaultPitch{0}");
            readmov(ri, prop.Rotate, "CameraDefaultRotate{0}");
            readmov(ri, prop.Scroll, "CameraDefaultScroll{0}");
            readmov(ri, prop.Zoom, "CameraDefaultZoom{0}");

            checkBox1.Checked = ri.GetBool("fullscreen", "general settings");
            checkBox2.Checked = ri.GetBool("mipmapping", "general settings");
            checkBox3.Checked = ri.GetBool("antialiasing", "general settings");
            checkBox4.Checked = ri.GetBool("dithering", "general settings");
            checkBox6.Checked = ri.GetBool("FPSIndependentCursor", "general settings");
            //checkBox7.Checked = GetBool(game, "safesound", "general settings");

            numericUpDown1.Value = ri2.GetInt("LandscapeDrawRadius", "settings");
            numericUpDown2.Value = ri2.GetInt("ObjectsDrawRadius", "settings");
            checkBox5.Checked = ri2.GetBool("PauseOnMinimize", "settings");

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
            PropertyCategories prop = (PropertyCategories)propertyGrid1.SelectedObject;


            ri.SetBool("fullscreen", checkBox1.Checked, "general settings");
            ri.SetBool("mipmapping", checkBox2.Checked, "general settings");
            ri.SetBool("antialiasing", checkBox3.Checked, "general settings");
            ri.SetBool("dithering", checkBox4.Checked, "general settings");
            ri.SetBool("FPSIndependentCursor", checkBox6.Checked, "general settings");
            
            ri2.SetBool("PauseOnMinimize", checkBox5.Checked, "settings");
            ri2.SetInt("LandscapeDrawRadius", Convert.ToInt32(numericUpDown1.Value), "settings");
            ri2.SetInt("ObjectsDrawRadius", Convert.ToInt32(numericUpDown2.Value), "settings");

            ri2.SetInt("Xoptions Active", 1, "settings"); //Force Extra options support!
            ri2.SetInt("ModesFiltration", 0, "settings"); //Force All resolutions displaying!


            ri.SetFlt("FarClipDistance", prop.FarClipDistance, "camera settings");
            ri.SetFlt("NearClipDistance", prop.NearClipDistance, "camera settings");

            writeminmax(ri, prop.DefaultPitch, "CameraDefault{0}Pitch");
            writeminmax(ri, prop.LimitDistanceToCarrier, "Camera{0}LimitDistanceToCarrier");
            writeminmax(ri, prop.BriefLimitDistanceToCarrier, "CameraBriefing{0}LimitDistanceToCarrier");
            writeminmax(ri, prop.BriefDistanceToCarrier, "CameraBriefing{0}DistanceToCarrier");
            writeminmax(ri, prop.BriefDefaultPitch, "CameraBriefing{0}Pitch");
            writeminmaxdef(ri, prop.DistanceToCarrier, "Camera{0}DistanceToCarrier");
            writeminmaxdef(ri, prop.Height, "Camera{0}Height");

            writemov(ri, prop.Pitch, "CameraDefaultPitch{0}");
            writemov(ri, prop.Rotate, "CameraDefaultRotate{0}");
            writemov(ri, prop.Scroll, "CameraDefaultScroll{0}");
            writemov(ri, prop.Zoom, "CameraDefaultZoom{0}");

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
