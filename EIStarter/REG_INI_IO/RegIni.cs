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
        public enum APIMode : ushort
        {
            Win,
            EI,
            INI
        }
        public RegIni(string name) { }
        public RegIni(REGedit reg) {
            this.winreg = reg;
            CurrentAPI = APIMode.Win;
        }
        public RegIni(IniFile ini) {
            this.ini = ini;
            CurrentAPI = APIMode.INI;
        }
        public RegIni(EIRegFile eireg) {
            this.eireg = eireg;
            CurrentAPI = APIMode.EI;
        }
        /// <summary>
        /// Init for "Win or Ini" in Options support
        /// </summary>
        /// <param name="winreg"></param>
        /// <param name="ini"></param>
        public RegIni(REGedit winreg, IniFile ini, APIMode mode = APIMode.Win) {
            this.winreg = winreg;
            this.ini = ini;
            CurrentAPI = mode;
        }
        /// <summary>
        /// Init for "EI or Ini" support
        /// </summary>
        /// <param name="eireg"></param>
        /// <param name="ini"></param>
        public RegIni(EIRegFile eireg, IniFile ini, APIMode mode = APIMode.EI) {
            this.eireg = eireg;
            this.ini = ini;
            CurrentAPI = mode;
        }
        public void SetMode(APIMode mode)
        {
            this.CurrentAPI = mode;
        }
        private APIMode CurrentAPI = APIMode.INI;
        private readonly REGedit winreg;
        private readonly EIRegFile eireg;
        private readonly IniFile ini;

        public bool GetBool(string key, string section = "nil", bool def = false)
        {
            return CurrentAPI switch
            {
                APIMode.INI => GetBool(ini, key, section, def ),
                APIMode.EI => GetBool(eireg, key, section, def ),
                APIMode.Win => GetBool(winreg, key, section), //TODO: default bool value in registry
                _ => false
            };
        }
        public void SetBool(string key, bool val, string section = "nil")
        {
            if (CurrentAPI == APIMode.INI)
            {
                //return false;
                //return SetBool(ini, key, section);
            }
            else if (CurrentAPI == APIMode.EI)
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
            return CurrentAPI switch
            {
                APIMode.INI => GetInt(ini, key, section),
                APIMode.EI => -1,
                APIMode.Win => GetInt(winreg, key, section),
                _ => -1
            };
        }
        public void SetInt(string key, int val, string section = "nil")
        {
            if (CurrentAPI == APIMode.INI)
            {
                //return false;
                //return SetBool(ini, key, section);
            }
            else if (CurrentAPI == APIMode.EI)
            {
                //return false;
            }
            else
            {
                SetInt(winreg, key, val, section);
            }
        }
        public string GetStr(string key, string section = "nil",string def = "")
        {
            return CurrentAPI switch
            {
                APIMode.INI => GetStr(ini, key, section, def),
                APIMode.EI => GetStr(eireg, key, section, def),
                APIMode.Win => GetStr(winreg, key, section, def),
                _ => ""
            };
        }
        public void SetStr(string key, string val, string section = "nil")
        {
            if (CurrentAPI == APIMode.INI)
            {
                //return false;
                //return SetBool(ini, key, section);
            }
            else if (CurrentAPI == APIMode.EI)
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
            return CurrentAPI switch
            {
                APIMode.INI => GetFlt(ini, key, section),
                APIMode.EI => -1.0f,
                APIMode.Win => GetFlt(winreg, key, section),
                _ => -1.0f
            };
        }
        public void SetFlt(string key, float val, string section = "nil")
        {
            if (CurrentAPI == APIMode.INI)
            {
                //return SetFlt(ini, key, section);
            }
            else if (CurrentAPI == APIMode.EI)
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
        public bool GetBool(IniFile ini, string key, string section, bool def = false)
        {
            if (!string.IsNullOrWhiteSpace(ini.Read(key, section)))
                return Convert.ToBoolean(Convert.ToInt32(ini.Read(key, section)));
            return def;
        }
        public bool GetBool(REGedit reg, string key, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            return Convert.ToBoolean(Convert.ToInt32(reg.Read(key, 0)));
        }

        public bool GetBool(EIRegFile ini, string key, string section = "nil",bool def = false)
        {
            return ini.GetBool(key, section, def);
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
        public string GetStr(IniFile ini, string key, string section, string def = "")
        {
            var temp = ini.Read(key, section);
            if (!string.IsNullOrWhiteSpace(temp))
                return temp;

            return def;
        }
        public string GetStr(REGedit reg, string key, string section = "nil", string def = "")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            var temp = reg.Read(key, null);
            if (!string.IsNullOrWhiteSpace(temp))
                return temp;
            return def;
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
