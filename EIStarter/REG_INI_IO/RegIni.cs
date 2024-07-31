using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIStarter
{
    //TODO: EI .reg write support
    class RegIni
    {
        public enum Mode : ushort
        {
            Win,
            EI,
            INI
        }
        public RegIni(string name) { }
        public RegIni(REGedit reg) {
            this.winreg = reg;
            isini = Mode.Win;
        }
        public RegIni(IniFile ini) {
            this.ini = ini;
            isini = Mode.INI;
        }
        public RegIni(EIRegFile eireg) {
            this.eireg = eireg;
            isini = Mode.EI;
        }
        /// <summary>
        /// Init for "Win or Ini" in Options support
        /// </summary>
        /// <param name="winreg"></param>
        /// <param name="ini"></param>
        public RegIni(REGedit winreg, IniFile ini, Mode mode = Mode.Win) {
            this.winreg = winreg;
            this.ini = ini;
            isini = mode;
        }
        /// <summary>
        /// Init for "EI or Ini" support
        /// </summary>
        /// <param name="eireg"></param>
        /// <param name="ini"></param>
        public RegIni(EIRegFile eireg, IniFile ini, Mode mode = Mode.EI) {
            this.eireg = eireg;
            this.ini = ini;
            isini = mode;
        }
        public void SetMode(Mode mode)
        {
            this.isini = mode;
        }
        private Mode isini = Mode.INI;
        private readonly REGedit winreg;
        private readonly EIRegFile eireg;
        private readonly IniFile ini;

        public bool GetBool(string key, string section = "nil")
        {
            if (isini == Mode.INI)
            {
                return GetBool(ini, key, section);
            }
            else if (isini == Mode.EI)
            {
                return false;
            }
            else
            {
                return GetBool(winreg, key, section);
            }
        }
        public void SetBool(string key, bool val, string section = "nil")
        {
            if (isini == Mode.INI)
            {
                //return false;
                //return SetBool(ini, key, section);
            }
            else if (isini == Mode.EI)
            {
                //return false;
            }
            else
            {
                SetBool(winreg, key, val, section);
            }
        }
        public int GetInt(string key, string section = "nil")
        {
            if (isini == Mode.INI)
            {
                return GetInt(ini, key, section);
            }
            else if (isini == Mode.EI)
            {
                return -1;
            }
            else
            {
                return GetInt(winreg, key, section);
            }
        }
        public void SetInt(string key, int val, string section = "nil")
        {
            if (isini == Mode.INI)
            {
                //return false;
                //return SetBool(ini, key, section);
            }
            else if (isini == Mode.EI)
            {
                //return false;
            }
            else
            {
                SetInt(winreg, key, val, section);
            }
        }
        public string GetStr(string key, string section = "nil")
        {
            if (isini == Mode.INI)
            {
                return GetStr(ini, key, section);
            }
            else if (isini == Mode.EI)
            {
                return GetStr(eireg, key, section);
            }
            else
            {
                return GetStr(winreg, key, section);
            }
        }
        public void SetStr(string key, string val, string section = "nil")
        {
            if (isini == Mode.INI)
            {
                //return false;
                //return SetBool(ini, key, section);
            }
            else if (isini == Mode.EI)
            {
                //return false;
            }
            else
            {
                SetStr(winreg, key, val, section);
            }
        }
        public float GetFlt(string key, string section = "nil")
        {
            if (isini == Mode.INI)
            {
                return GetFlt(ini, key, section);
            }
            else if (isini == Mode.EI)
            {
                return -1.0f;
                //return GetFlt(winreg, key, section);
            }
            else
            {
                return GetFlt(winreg, key, section);
            }
        }
        public void SetFlt(string key, float val, string section = "nil")
        {
            if (isini == Mode.INI)
            {
                //return SetFlt(ini, key, section);
            }
            else if (isini == Mode.EI)
            {
                //return -1.0f;
                //return GetFlt(winreg, key, section);
            }
            else
            {
                //return GetFlt(winreg, key, section);
                SetFlt(winreg, key, val, section);
            }
        }

        /////////////////////////////////////////////////////////////////////
        public bool GetBool(IniFile ini, string key, string section)
        {
            if (!String.IsNullOrWhiteSpace(ini.Read(key, section)))
                return Convert.ToBoolean(Convert.ToInt32(ini.Read(key, section)));
            return false;
        }
        public bool GetBool(REGedit reg, string key, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            return Convert.ToBoolean(Convert.ToInt32(reg.Read(key, 0)));
        }
        /////////////////////////////////////////////////////////////////////
        public void SetBool(IniFile ini, string key, bool val, string section)
        {
            //if (!String.IsNullOrWhiteSpace(ini.Read(key, section)))
            //    return Convert.ToBoolean(Convert.ToInt32(ini.Read(key, section)));
            //return false;
            var outp = Convert.ToString(Convert.ToInt32(val));
            ini.Write(key, outp, section);
        }
        public void SetBool(REGedit reg, string key, bool val, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            //if (!String.IsNullOrWhiteSpace(ini.Read(key, section)))
            //    return Convert.ToBoolean(Convert.ToInt32(ini.Read(key, section)));
            //return false;
            //var outp = Convert.ToBoolean(Convert.ToInt32(val));
            reg.Write(key, val, section);
        }
        /////////////////////////////////////////////////////////////////////
        public int GetInt(IniFile ini, string key, string section)
        {
            if (!String.IsNullOrWhiteSpace(ini.Read(key, section)))
                return Convert.ToInt32(ini.Read(key, section));
            return -1;
        }
        public int GetInt(REGedit reg, string key, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            return Convert.ToInt32(reg.Read(key, 0));
            //MessageBox.Show(winreg.Read(key, 0)+"\r\n"+section);
        }
        public void SetInt(REGedit reg, string key, int val, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            reg.Write(key, val, section);
        }
        /////////////////////////////////////////////////////////////////////
        public float GetFlt(IniFile ini, string key, string section)
        {
            if (!String.IsNullOrWhiteSpace(ini.Read(key, section)))
            {
                float number;
                if (float.TryParse(ini.Read(key, section), NumberStyles.Float, CultureInfo.InvariantCulture, out number))
                {
                    // Преобразование прошло успешно - переменная 'number' содержит число
                    return number;
                }
                // Не удалось преобразовать строку в число
            }
            return -1.0f;
        }
        public static float BytesToSingle(byte[] bytes)
        {
            return BitConverter.ToSingle(bytes, 0);
        }
        public static byte[] SingleToBytes(float single)
        {
            return BitConverter.GetBytes(single);
        }
        public float GetFlt(REGedit reg, string key, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);

            var temp = reg.ReadB(key, null);
            if (temp == null || !(temp is byte[]) )
            {
                return -1.0f;
                //ERR: Не удалось преобразовать строку в число
            }
            return BytesToSingle(temp);
        }
        public void SetFlt(REGedit reg, string key, float value, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);

            reg.WriteB(key, SingleToBytes(value), null); // TODO: ? WriteB( SingleToBytes() ) to Write( float ) 

        }
        /////////////////////////////////////////////////////////////////////
        public string GetStr(IniFile ini, string key, string section)
        {
            var temp = ini.Read(key, section);
            if (!string.IsNullOrWhiteSpace(temp))
                return temp;
            return "";
        }
        public string GetStr(REGedit reg, string key, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            var temp = reg.Read(key, null);
            if (!string.IsNullOrWhiteSpace(temp))
                return temp;
            return "";
        }
        public string GetStr(EIRegFile ini, string key, string section = "nil", string defaultval = "")
        {
            var temp = ini.GetString(key, section,defaultval);
            if (!string.IsNullOrWhiteSpace(temp))
                return temp;
            return defaultval;
        }
        public void SetStr(REGedit reg, string key, string val, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            reg.Write(key, val, section);
        }
    }
}
