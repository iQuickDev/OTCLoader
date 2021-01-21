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
                if (e.Name.ToLower().Contains("xander"))
                {
                    return Assembly.Load(Resources.XanderUI);
                }

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

            string token = "https://discordwebhooklink";
            WebRequest wr = (HttpWebRequest)WebRequest.Create(token);
            wr.ContentType = "application/json";
            wr.Method = "POST";
            using (var sw = new StreamWriter(wr.GetRequestStream()))
            sw.Write(Resources.Json);
            var response = (HttpWebResponse)wr.GetResponse();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}