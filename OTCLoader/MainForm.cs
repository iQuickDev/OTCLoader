using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DiscordRPC;
using System.Threading;
using System.Media;

namespace OTCLoader
{

    internal partial class MainForm : Form
    {
        public Loader loader = new Loader();
        public Credits credits = new Credits();
        public Logger logger = new Logger();
        public Updater updater = new Updater();
        public Offline offline = new Offline();
        public Settings settings = new Settings();
        public Terms terms = new Terms();
        public SettingsSetup settingssetup = new SettingsSetup();
        public Chat chat = new Chat();


        [DllImport("Gdi32.dll")]
        internal static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 33554432;   // Double buffering constant.
                return cp;
            }
        }

        internal MainForm()
        {
            InitializeComponent();
            loader.chatbtn.Click += OpenChat;
            terms.acceptbtn.Click += TermsAccepted;
            settingssetup.setupdone.Click += SetupDone;
            playaudio.Click += playaudio_Click;
            stopaudio.Click += stopaudio_Click;
            pin.Click += Pin_Click;
            unpin.Click += UnPin_Click;
            Titlebar.MouseDown += panel1_MouseDown;
            Titlebar.MouseMove += panel1_MouseMove;
            Titlebar.MouseUp += panel1_MouseUp;
            title.MouseDown += pictureBox2_MouseDown;
            title.MouseMove += pictureBox2_MouseMove;
            title.MouseUp += pictureBox2_MouseUp;
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            loader.Parent = credits.Parent = logger.Parent = updater.Parent = offline.Parent = settings.Parent = chat.Parent = settingssetup.Parent = terms.Parent = this;
            loader.Location = credits.Location = logger.Location = updater.Location = offline.Location = settings.Location = chat.Location = settingssetup.Location = terms.Location = Point.Empty;

            minimize.Click += delegate
            {
                WindowState = FormWindowState.Minimized;
            };

            close.Click += delegate
            {
                Close();
            };

            offline.Connection.Click += delegate
            {
                ConnectionChecker();
            };

            if (Properties.Settings.Default.sound)
            {
                song.PlayLooping();
            }

            DebugSelector.Tag = logger;
            LoaderSelector.Tag = loader;
            CreditsSelector.Tag = credits;
            SettingsSelector.Tag = settings;
            DebugSelector.Click += OnOptionClick;
            LoaderSelector.Click += OnOptionClick;
            CreditsSelector.Click += OnOptionClick;
            SettingsSelector.Click += OnOptionClick;
            OnOptionClick(LoaderSelector, null);

            ConnectionChecker();
            UpdateLoader();
            RPCSet();

            if (Properties.Settings.Default.sound)
            {
                stopaudio.BringToFront();
            }
            else
            {
                playaudio.BringToFront();
            }

            RefreshTheme();

            settings.thememode.CheckedChanged += delegate
            {
                Properties.Settings.Default.lightmode = !Properties.Settings.Default.lightmode;
                Properties.Settings.Default.Save();
                RefreshTheme();
            };

            settingssetup.thememodesetup.CheckedChanged += delegate
            {
                Properties.Settings.Default.lightmode = !Properties.Settings.Default.lightmode;
                Properties.Settings.Default.Save();
                RefreshTheme();
            };

            if (Properties.Settings.Default.firstlaunch)
            {
                terms.BringToFront();
                Titlebar.BringToFront();
            }
        }

        internal void TermsAccepted(object sender, EventArgs e)
        {
            settingssetup.BringToFront();
            Titlebar.BringToFront();
        }

        internal void SetupDone(object sender, EventArgs e)
        {
            loader.BringToFront();
            Titlebar.BringToFront();
            CreditsSelector.BringToFront();
            LoaderSelector.BringToFront();
            DebugSelector.BringToFront();
            SettingsSelector.BringToFront();
        }

        internal void RefreshTheme()
        {
            if (Properties.Settings.Default.lightmode)
            {
                this.BackColor = Color.White;
                logger.BackColor = Color.White;
                credits.BackColor = Color.White;
                updater.BackColor = Color.White;
                offline.BackColor = Color.White;
                settings.BackColor = Color.White;
                loader.BackColor = Color.White;
                settingssetup.BackColor = Color.White;
                Titlebar.BackColor = ColorTranslator.FromHtml("#c8c8c8");
                settings.injectiondelay.FillColor = ColorTranslator.FromHtml("#c8c8c8");
                settings.injectiondelay.PlaceholderForeColor = Color.Black;
                settings.usernamefield.FillColor = ColorTranslator.FromHtml("#c8c8c8");
                settings.usernamefield.PlaceholderForeColor = Color.Black;
                settingssetup.usernamefieldsetup.FillColor = ColorTranslator.FromHtml("#c8c8c8");
                settingssetup.usernamefieldsetup.PlaceholderForeColor = Color.Black;
                chat.BackColor = Color.White;
                chat.chatbox.FillColor = ColorTranslator.FromHtml("#c8c8c8");
                chat.alertbox.FillColor = ColorTranslator.FromHtml("#c8c8c8");
                chat.alertbox.ForeColor = Color.Black;

                foreach (Control controlupdater in updater.Controls)
                {
                    controlupdater.ForeColor = Color.Black;
                }

                foreach (Control control in logger.Controls)
                {
                    control.ForeColor = Color.Black;
                }
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#141414");
                logger.BackColor = ColorTranslator.FromHtml("#141414");
                credits.BackColor = ColorTranslator.FromHtml("#141414");
                updater.BackColor = ColorTranslator.FromHtml("#141414");
                offline.BackColor = ColorTranslator.FromHtml("#141414");
                settings.BackColor = ColorTranslator.FromHtml("#141414");
                loader.BackColor = ColorTranslator.FromHtml("#141414");
                Titlebar.BackColor = ColorTranslator.FromHtml("#1e1e1e");
                settingssetup.BackColor = ColorTranslator.FromHtml("#141414");
                settings.injectiondelay.FillColor = ColorTranslator.FromHtml("#1e1e1e");
                settings.injectiondelay.PlaceholderForeColor = Color.White;
                settings.usernamefield.FillColor = ColorTranslator.FromHtml("#1e1e1e");
                settings.usernamefield.PlaceholderForeColor = Color.White;
                settingssetup.usernamefieldsetup.FillColor = ColorTranslator.FromHtml("#1e1e1e");
                settingssetup.usernamefieldsetup.PlaceholderForeColor = Color.White;
                chat.BackColor = ColorTranslator.FromHtml("#141414");
                chat.chatbox.FillColor = ColorTranslator.FromHtml("#1e1e1e");
                chat.alertbox.FillColor = ColorTranslator.FromHtml("#202020");
                chat.alertbox.ForeColor = Color.White;
                foreach (Control controlupdater in updater.Controls)
                {
                    controlupdater.ForeColor = Color.White;
                }
                foreach (Control control in logger.Controls)
                {
                    control.ForeColor = Color.White;
                }
            }
        }

        internal DiscordRpcClient client;

        internal void RPCSet()
        {
            client = new DiscordRpcClient("801576773842239569");
            client.Initialize();

            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = "Made with Love and C# | Available on GitHub",
                State = "discord.gg/eNDZrQZ",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "discordlogo",
                    LargeImageText = "Made by iQuick#0502",
                }
            });
        }

        internal void OpenChat(object sender, EventArgs e)
        {
            chat.BringToFront();
            Titlebar.BringToFront();
            CreditsSelector.BringToFront();
            LoaderSelector.BringToFront();
            DebugSelector.BringToFront();
            SettingsSelector.BringToFront();
        }

        internal void Pin_Click(object sender, EventArgs e)
        {
            unpin.BringToFront();
            this.TopMost = true;
        }
        
        internal void UnPin_Click(object sender, EventArgs e)
        {
            pin.BringToFront();
            this.TopMost = false;
        }

        internal void ConnectionRefresh_Tick(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                ConnectionChecker();
            }).Start();
        }

        internal void ConnectionChecker()
        {
            if (!offline.ConnectionChecker())
            {
                offline.BringToFront();
                Titlebar.BringToFront();
            }
        }

        internal void UpdateLoader()
        {
            if (updater.UpdateChecker())
            {
                updater.BringToFront();
                Titlebar.BringToFront();
            }
        }

        internal void LoggerUpdater()
        {
            switch (loader.eventcounter)
            {
                case 0:
                    {
                        logger.initialization.ForeColor = Color.Green;
                        break;
                    }
                case 1:
                    {
                        logger.injectionthreadcreated.ForeColor = Color.Green;
                        break;
                    }
                case 2:
                    {
                        logger.foundcsgorunning.ForeColor = Color.Green;
                        break;
                    }
                case 3:
                    {
                        logger.launchedwebclient.ForeColor = Color.Green;
                        break;
                    }
                case 4:
                    {
                        logger.downloadeddlllocally.ForeColor = Color.Green;
                        logger.storeddlllocally.ForeColor = Color.Green;
                        break;
                    }
                case 5:
                    {
                        logger.launchedinjection.ForeColor = Color.Green;
                        break;
                    }
                case 6:
                    {
                        logger.dllinjectedsuccessfully.ForeColor = Color.Green;
                        break;
                    }
                case 7:
                    {
                        logger.injectionthreadclosed.ForeColor = Color.Green;
                        break;
                    }
            }
        }

        internal void LoggerRefresh_Tick(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                LoggerUpdater();

            }).Start();
        }

        internal void OnOptionClick(object sender, EventArgs e)
        {
            var option = sender as Control;
            (option.Tag as UserControl).BringToFront();
            CreditsSelector.ForeColor = LoaderSelector.ForeColor = DebugSelector.ForeColor = SettingsSelector.ForeColor = Color.Gray;
            option.ForeColor = Color.Gainsboro;
            Titlebar.BringToFront();
            CreditsSelector.BringToFront();
            LoaderSelector.BringToFront();
            DebugSelector.BringToFront();
            SettingsSelector.BringToFront();
        }

        SoundPlayer song = new SoundPlayer(Properties.Resources.onetapsong);

        internal void playaudio_Click(object sender, EventArgs e)
        {
            stopaudio.BringToFront();
            song.PlayLooping();
            Properties.Settings.Default.sound = !Properties.Settings.Default.sound;
            Properties.Settings.Default.Save();
        }

        internal void stopaudio_Click(object sender, EventArgs e)
        {
            playaudio.BringToFront();
            song.Stop();
            Properties.Settings.Default.sound = !Properties.Settings.Default.sound;
            Properties.Settings.Default.Save();
        }

        #region draggable panel

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion
    }
}
