using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace OTCLoader
{
    public partial class SettingsSetup : UserControl
    {
        HttpClient wordsGrabber = new HttpClient();
        public SettingsSetup()
        {
            InitializeComponent();
            usernamefieldsetup.Click += usernamesettersetup_ClickAsync;
        }

        internal async void usernamesettersetup_ClickAsync(object sender, EventArgs e)
        {
            string tempUname = usernamefieldsetup.Text.ToLower();
            string badWordsList = await wordsGrabber.GetStringAsync("https://raw.githubusercontent.com/iQuickGaming/OTCLoader/master/bannedwords");
            string[] badWords = badWordsList.Split(',');

            if (usernamefieldsetup.Text.Length == 0)
            {
                return;
            }

            for (int i = 0; i < badWords.Length; i++)
            {
                if (tempUname.Contains(badWords[i]))
                {
                    MessageBox.Show("Name unavailable");
                    usernamefieldsetup.Clear();
                    return;
                }
            }

            Properties.Settings.Default.username = usernamefieldsetup.Text;
            Properties.Settings.Default.Save();

            return;
        }
    }
}
