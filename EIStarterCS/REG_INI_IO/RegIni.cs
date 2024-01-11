using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIStarterCS
{
    //TODO: EI .reg support, WinRegistry full support
    class RegIni
    {
        public RegIni(string name) { }
        public RegIni(REGedit reg) {
            this.reg = reg;
            isini = false;
        }
        public RegIni(IniFile ini) {
            this.ini = ini;
            isini = true;
        }
        private bool isini = true;
        private REGedit reg;
        private IniFile ini;

        public bool GetBool(string key, string section = "nil")
        {
            if (isini)
            {
                return GetBool(ini, key, section);
            }
            else
            {
                return GetBool(reg, key, section);
            }
        }
        public int GetInt(string key, string section = "nil")
        {
            if (isini)
            {
                return GetInt(ini, key, section);
            }
            else
            {
                return GetInt(reg, key, section);
            }
        }
        public string GetStr(string key, string section = "nil")
        {
            if (isini)
            {
                return GetStr(ini, key, section);
            }
            else
            {
                return GetStr(reg, key, section);
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
            //MessageBox.Show(reg.Read(key, 0)+"\r\n"+section);
        }
        /////////////////////////////////////////////////////////////////////
        public float GetFlt(IniFile ini, string key, string section)
        {
            if (!String.IsNullOrWhiteSpace(ini.Read(key, section)))
            {
                //    return Convert.ToDouble(ini.Read(key, section));
                //return -1;
                float number;
                if (float.TryParse(ini.Read(key, section), NumberStyles.Float, CultureInfo.InvariantCulture, out number))
                {
                    // Преобразование прошло успешно - переменная 'number' содержит число
                    return number;
                }
                //else
                //{
                // Не удалось преобразовать строку в число
                //}
            }
            return -1.0f;
        }
        /////////////////////////////////////////////////////////////////////
        public string GetStr(IniFile ini, string key, string section)
        {
            if (!String.IsNullOrWhiteSpace(ini.Read(key, section)))
                return ini.Read(key, section);
            return "";
        }
        public string GetStr(REGedit reg, string key, string section = "nil")
        {
            if (section != "nil")
                reg.SwitchSubKeyPath(section);
            if (!String.IsNullOrWhiteSpace(reg.Read(key,null)))
                return reg.Read(key, null);
            return "";
        }
    }
}
