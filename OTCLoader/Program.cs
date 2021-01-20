using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTCLoader.Properties;
using OTCLoader;

namespace OTCLoader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (_, e) =>
            {
                if (e.Name.Substring(0, e.Name.IndexOf(",")) == "XanderUI")
                {
                    return Assembly.Load(Resources.XanderUI);
                }

                if (e.Name.Substring(0, e.Name.IndexOf(",")) == "Guna.UI2")
                {
                    return Assembly.Load(Resources.Guna_UI2);
                }

                return null;
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
