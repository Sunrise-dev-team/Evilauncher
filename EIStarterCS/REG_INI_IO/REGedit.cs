using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EIStarterCS
{
    //TODO: In progress: WinRegistry full IO with float support
    class REGedit
    {
        private string KeyPath;
        private string defaultKeyPath;
        private RegistryKey BaseKey;

        public REGedit(string keyPath, RegistryKey baseKey = null)
        {
            KeyPath = keyPath;
            defaultKeyPath = KeyPath +"\\";

            BaseKey = baseKey ?? Registry.CurrentUser;
        }
        public void SwitchSubKeyPath(string newKeyPath)
        {
            if (KeyPath == newKeyPath || String.IsNullOrWhiteSpace(newKeyPath))
                return;
            KeyPath = defaultKeyPath + newKeyPath;
        }

        public string Read(string valueName, string defaultValue = null)
        {
            RegistryKey key = BaseKey.OpenSubKey(KeyPath);
            if (key != null)
            {
                string value = key.GetValue(valueName) as string;
                //MessageBox.Show(KeyPath + "\r\n" + key + "\r\n" + value);
                key.Close();
                return value ?? defaultValue;
            }
            else
            {
                return defaultValue;
            }
        }
        /*
        public object Read(string valueName, int defaultValue = -1)
        {
            RegistryKey key = BaseKey.OpenSubKey(KeyPath);
            if (key != null)
            {
                var value = key.GetValue(valueName);
                MessageBox.Show(KeyPath + "\r\n" + key + "\r\n" + value);
                key.Close();
                return value;// ?? defaultValue;
            }
            else
            {
                return defaultValue;
            }
        }
        */
        public int Read(string valueName, int defaultValue = 0)
        {
            RegistryKey key = BaseKey.OpenSubKey(KeyPath);
            if (key != null)
            {
                object value = key.GetValue(valueName);
                //MessageBox.Show(KeyPath + "\r\n" + key + "\r\n" + value);
                if (value != null && value is int)
                {
                    return (int)value;
                }
            }
            return defaultValue;
        }
        public byte[] ReadB(string valueName, byte[] defaultValue = null)
        {
            RegistryKey key = BaseKey.OpenSubKey(KeyPath);
            if (key != null)
            {
                object value = key.GetValue(valueName);
                //MessageBox.Show(KeyPath + "\r\n" + key + "\r\n" + value);
                if (value != null && value is byte[])
                {
                    return (byte[])value;
                }
            }
            return defaultValue;
        }

        public void Write(string valueName, string value)
        {
            RegistryKey key = BaseKey.CreateSubKey(KeyPath);
            key.SetValue(valueName, value);
            key.Close();
        }

        public void Write(string valueName, string value, string reserved0 = "nil" )
        {
            RegistryKey key = BaseKey.CreateSubKey(KeyPath);
            key.SetValue(valueName, value);
            key.Close();
        }
        public void Write(string valueName, bool value, string reserved0 = "nil" )
        {
            RegistryKey key = BaseKey.CreateSubKey(KeyPath);
            key.SetValue(valueName, value, RegistryValueKind.DWord);
            key.Close();
        }
        public void Write(string valueName, int value, string reserved0 = "nil" )
        {
            RegistryKey key = BaseKey.CreateSubKey(KeyPath);
            key.SetValue(valueName, value, RegistryValueKind.DWord);
            key.Close();
        }

        public void DeleteValue(string valueName)
        {
            RegistryKey key = BaseKey.OpenSubKey(KeyPath, true);
            if (key != null)
            {
                key.DeleteValue(valueName);
                key.Close();
            }
        }

        public void DeleteKey()
        {
            RegistryKey parentKey = BaseKey.OpenSubKey(Path.GetDirectoryName(KeyPath), true);
            if (parentKey != null)
            {
                parentKey.DeleteSubKey(Path.GetFileName(KeyPath));
                parentKey.Close();
            }
        }
    
    }
}
