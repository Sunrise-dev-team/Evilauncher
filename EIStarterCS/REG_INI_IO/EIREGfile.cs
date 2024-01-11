using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIStarterCS
{
    //TODO: Evil Islands .reg here, with RegIni Interface
    class EIREGfile
    {

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            //GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return "";//RetVal.ToString();
        }
    }
}
