using OTCLoader.Properties;
using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace OTCLoader
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += (_, e) =>
            {
                if (e.Name.ToLower().Contains("guna"))
                {
                    return Assembly.Load(Resources.Guna_UI2);
                }

                if (e.Name.ToLower().Contains("discord"))
                {
                    return Assembly.Load(Resources.DiscordRPC);
                }

                if (e.Name.ToLower().Contains("json"))
                {
                    return Assembly.Load(Resources.Newtonsoft_Json);
                }

                return null;
            };

            Properties.Settings.Default.timeslaunched++;
            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.username == "unset")
            {
                Properties.Settings.Default.username = Environment.UserName;
                Properties.Settings.Default.Save();
            }

            //DISCORD WEBHOOK(uncomment if you have a webhook on discord)

            if (!Properties.Settings.Default.firstlaunch)
            {
                WebRequest wr = (HttpWebRequest)WebRequest.Create("https://discordwebhooklink");
                wr.ContentType = "application/json";
                wr.Method = "POST";
                using (var sw = new StreamWriter(wr.GetRequestStream()))
                {
                    sw.Write(Resources.Json.Set(new[]
                    {
                    ("UserName", Properties.Settings.Default.username),
                    ("UserName", Environment.UserName),
                    ("TimeNow", DateTime.UtcNow.ToString("hh:mm tt MM/dd/yyyy")),
                    ("Version", Updater.CurrentVersion),
                    ("Theme", Properties.Settings.Default.lightmode ? "Light" : "Dark"),
                    ("Music", Properties.Settings.Default.sound ? "On" : "Off"),
                    ("TimesLaunched", $"{Properties.Settings.Default.timeslaunched}"),
                    ("InjectionDelay", $"{Properties.Settings.Default.injectiondelay}")

                    }));
                }

                var response = (HttpWebResponse)wr.GetResponse();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}