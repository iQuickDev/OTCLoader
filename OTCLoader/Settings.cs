using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;

namespace OTCLoader
{
    public partial class Settings : UserControl
    {
        internal HttpClient wordsGrabber = new HttpClient();
        public Settings()
        {
            InitializeComponent();
            delaysetter.Click += delaysetter_Click;
            usernamesetter.Click += usernamesetter_ClickAsync;
            thememode.Checked = Properties.Settings.Default.lightmode;
            injectiondelay.Text = Properties.Settings.Default.injectiondelay.ToString();
        }

        internal void injectiondelay_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(injectiondelay.Text, "[^0-9]"))
            {
                injectiondelay.Text = injectiondelay.Text.Remove(injectiondelay.Text.Length - 1);
            }
        }

        internal void delaysetter_Click(object sender, EventArgs e)
        {
            if (injectiondelay.Text.Length == 0)
            {
                return;
            }

            ulong parseddelay = ulong.Parse(injectiondelay.Text);
            Properties.Settings.Default.injectiondelay = parseddelay;
            Properties.Settings.Default.Save();
        }

        internal async void usernamesetter_ClickAsync(object sender, EventArgs e)
        {
            string tempUname = usernamefield.Text.ToLower();
            string badWordsList = await wordsGrabber.GetStringAsync("https://raw.githubusercontent.com/iQuickGaming/OTCLoader/master/bannedwords");
            string[] badWords = badWordsList.Split(',');

            if (usernamefield.Text.Length == 0)
            {
                return;
            }

            for (int i = 0; i < badWords.Length; i++)
            {
                if (tempUname.Contains(badWords[i]))
                {
                    MessageBox.Show("Name unavailable");
                    usernamefield.Clear();
                    return;
                }
            }

            Properties.Settings.Default.username = usernamefield.Text;
            Properties.Settings.Default.Save();

            return;
        }
    }
}
