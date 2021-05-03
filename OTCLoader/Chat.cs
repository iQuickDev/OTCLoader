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
    public partial class Chat : UserControl
    {
        HttpClient wordsGrabber = new HttpClient();
        public Chat()
        {
            InitializeComponent();
            sendbtn.Click += sendbtn_ClickAsync;
        }

        internal static void SendWebHook(string url, string msg, string username)
        {
            DiscordChat.Post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    username
                },
                {
                    "content",
                    msg
                }
            });
        }
        internal async void sendbtn_ClickAsync(object sender, EventArgs e)
        {
            string tempMsg = chatbox.Text.ToLower();
            string badWordsList = await wordsGrabber.GetStringAsync("https://raw.githubusercontent.com/iQuickGaming/OTCLoader/master/bannedwords");
            string[] badWords = badWordsList.Split(',');

            if (chatbox.Text.Length == 0)
            {
                return;
            }

            for (int i = 0; i < badWords.Length; i++)
            {
                if (tempMsg.Contains(badWords[i]))
                {
                    MessageBox.Show("Message contains inappropriate words");
                    chatbox.Clear();
                    return;
                }
            }
            //DISCORD WEBHOOK(uncomment if you have a webhook on discord)
            //SendWebHook("https://discordwebhooklink", chatbox.Text, Properties.Settings.Default.username);
            chatbox.Clear();
        }
    }
}
