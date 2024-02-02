using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EIStarterCS
{
    //TODO: Evil Islands .reg here, with RegIni Interface
    class EIREGfile
    {

        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        public EIREGfile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".reg").FullName;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            //GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
        public string Read(string Key, string Section = null, string Default = "")
        {
            var RetVal = new StringBuilder(255);
            //GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            if (RetVal.ToString() == "")
                return Default;
            return RetVal.ToString();
        }
    }
}
