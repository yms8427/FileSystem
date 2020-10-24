using BilgeAdam.FileSystem.Editor.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.FileSystem.Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(PathContants.SETTINGS_FOLDER))
            {
                Directory.CreateDirectory(PathContants.SETTINGS_FOLDER);
                if (!File.Exists(PathContants.TOLLBAR_SETTINGS))
                {
                    var settings = new Settings();
                    var json = JsonConvert.SerializeObject(settings);
                    File.WriteAllText(PathContants.TOLLBAR_SETTINGS, json);
                }
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
