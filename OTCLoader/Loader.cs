using System;
using System.Linq;
using System.Windows.Forms;
using ManualMapInjection.Injection;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Media;
using System.Drawing;

namespace OTCLoader
{
    public partial class Loader : UserControl
    {
        public int eventcounter = 0;
        private static object locker = new object();

        public Loader()
        {
            InitializeComponent();
            loadbtn.Click += loadbtn_Click;
            loadbtn.MouseEnter += loadbtn_MouseEnter;
            loadbtn.MouseLeave += loadbtn_MouseLeave;
        }

        internal Point loadbtnlocation = new Point(45, 232);
        internal Size loadbtnsize = new Size(210, 72);
        internal Point loadbtnlocationhover = new Point(42, 230);
        internal Size loadbtnsizehover = new Size(215, 73);

        internal void loadbtn_MouseEnter(object sender, EventArgs e)
        {
            loadbtn.Location = loadbtnlocationhover;
            loadbtn.Size = loadbtnsizehover;
        }

        internal void loadbtn_MouseLeave(object sender, EventArgs e)
        {
            loadbtn.Location = loadbtnlocation;
            loadbtn.Size = loadbtnsize;
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                lock (locker)
                {
                    eventcounter = 1;
                    Thread.Sleep(20);
                    Thread.CurrentThread.IsBackground = true;
                    Process[] pname = Process.GetProcessesByName("csgo");

                    if (pname.Length == 0)
                    {
                        csgonotrunning.Invoke((MethodInvoker)delegate
                        {
                            csgonotrunning.Show();
                        });

                        return;
                    }
                    else
                    {
                        csgonotrunning.Invoke((MethodInvoker)delegate
                        {
                            csgonotrunning.Hide();
                        });
                    }

                    eventcounter = 2;
                    WebClient wb = new WebClient();
                    eventcounter = 3;
                    Thread.Sleep(2);
                    string mainpath = "C:\\Windows\\OTCiQuick.dll";
                    wb.DownloadFile("https://github.com/iQuickGaming/OTCLoader/raw/master/OTCiQuick.dll", mainpath);
                    eventcounter = 4;
                    Thread.Sleep(2);
                    var name = "csgo";
                    var target = Process.GetProcessesByName(name).FirstOrDefault();
                    var path = mainpath;
                    var file = File.ReadAllBytes(path);
                    var injector = new ManualMapInjector(target) { AsyncInjection = true };
                    eventcounter = 5;
                    Thread.Sleep(50);

                    Thread.Sleep((int)Properties.Settings.Default.injectiondelay);

                    label2.Invoke((MethodInvoker)delegate
                    {
                        label2.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";
                    });

                    eventcounter = 6;
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

                    eventcounter = 7;
                }
            }).Start();
        }
    }
}

