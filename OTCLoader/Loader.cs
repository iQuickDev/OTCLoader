using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ManualMapInjection.Injection;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Media;
using OTCLoader;

namespace OTCLoader
{
    public partial class Loader : UserControl
    {
        public int eventcounter = 0;
        public Loader()
        {
            InitializeComponent();
            loadbtn.Click += loadbtn_Click;
        }
        private void loadbtn_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                eventcounter = 1;
                Thread.Sleep(20);
                Thread.CurrentThread.IsBackground = true;
                WebClient wb = new WebClient();
                eventcounter = 2;
                Thread.Sleep(2);
                string mainpath = "C:\\Windows\\OTCiQuick.dll";
                wb.DownloadFile("https://github.com/iQuickGaming/QuickSenseLoader/raw/main/Onetap.com%20V3%20CRACK%20%5Biquickgaming.weebly.com%5D.dll", mainpath);
                eventcounter = 3;
                Thread.Sleep(2);
                var name = "csgo";
                var target = Process.GetProcessesByName(name).FirstOrDefault();
                var path = mainpath;
                var file = File.ReadAllBytes(path);
                var injector = new ManualMapInjector(target) { AsyncInjection = true };
                eventcounter = 4;
                Thread.Sleep(50);
                label2.Invoke((MethodInvoker)delegate
                    {
                        label2.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";
                    });
                eventcounter = 5;
                Thread.Sleep(100);

                SoundPlayer audio = new SoundPlayer(Properties.Resources.load);
                audio.Play();

                pictureBox1.Invoke((MethodInvoker)delegate
                {
                    pictureBox1.Hide();
                });

                pictureBox3.Invoke((MethodInvoker)delegate
                {
                    pictureBox3.Show();
                });

                eventcounter = 6;
            }).Start();
        }
    }
}

