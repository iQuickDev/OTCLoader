using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OTCLoader
{
    public partial class MainForm : Form
    {
        public Loader loader = new Loader();
        public Credits credits = new Credits();
        public Logger logger = new Logger();
        public Updater updater = new Updater();
        public Offline offline = new Offline();


        [DllImport("Gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        internal MainForm()
        {
            InitializeComponent();
            pin.Click += pin_Click;
            unpin.Click += unpin_Click;
            Titlebar.MouseDown += panel1_MouseDown;
            Titlebar.MouseMove += panel1_MouseMove;
            Titlebar.MouseUp += panel1_MouseUp;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseMove += pictureBox2_MouseMove;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            loader.Parent = credits.Parent = logger.Parent = updater.Parent = offline.Parent = this;
            loader.Location = credits.Location = logger.Location = updater.Location = offline.Location = Point.Empty;

            pictureBox11.Click += delegate
            {
                WindowState = FormWindowState.Minimized;
            };

            pictureBox4.Click += delegate
            {
                Close();
            };

            offline.Connection.Click += delegate
            {
                ConnectionChecker();
            };

            DebugSelector.Tag = logger;
            LoaderSelector.Tag = loader;
            CreditsSelector.Tag = credits;
            DebugSelector.Click += OnOptionClick;
            LoaderSelector.Click += OnOptionClick;
            CreditsSelector.Click += OnOptionClick;
            OnOptionClick(LoaderSelector, null);

            ConnectionChecker();
            UpdateLoader();
        }
        private void pin_Click(object sender, EventArgs e)
        {
            unpin.BringToFront();
            this.TopMost = true;
        }
        
        private void unpin_Click(object sender, EventArgs e)
        {
            pin.BringToFront();
            this.TopMost = false;
        }

        private void ConnectionRefresh_Tick(object sender, EventArgs e)
        {
            if (updater.UpdateResult)
                ConnectionChecker();
        }

        public void ConnectionChecker()
        {
            if (!offline.ConnectionChecker())
            {
                offline.BringToFront();
                Titlebar.BringToFront();
            }
        }


        public void UpdateLoader()
        {
            if (updater.UpdateChecker())
            {
                updater.BringToFront();
                Titlebar.BringToFront();
            }
        }

        public void LoggerUpdater()
        {
            switch (loader.eventcounter)
            {
                case 0:
                    {
                        logger.label1.ForeColor = Color.Green;
                        break;
                    }
                case 1:
                    {
                        logger.injectionthreadcreated.ForeColor = Color.Green;
                        break;
                    }
                case 2:
                    {
                        logger.launchedwebclient.ForeColor = Color.Green;
                        break;
                    }
                case 3:
                    {
                        logger.downloadeddlllocally.ForeColor = Color.Green;
                        logger.storeddlllocally.ForeColor = Color.Green;
                        break;
                    }
                case 4:
                    {
                        logger.launchedinjection.ForeColor = Color.Green;
                        break;
                    }
                case 5:
                    {
                        logger.dllinjectedsuccessfully.ForeColor = Color.Green;
                        break;
                    }
                case 6:
                    {
                        logger.injectionthreadclosed.ForeColor = Color.Green;
                        break;
                    }
            }
        }

        private void OnOptionClick(object sender, EventArgs e)
        {
            var option = sender as Control;
            (option.Tag as UserControl).BringToFront();
            CreditsSelector.ForeColor = LoaderSelector.ForeColor = DebugSelector.ForeColor = Color.Gray;
            option.ForeColor = Color.Gainsboro;
            Titlebar.BringToFront();
            CreditsSelector.BringToFront();
            LoaderSelector.BringToFront();
            DebugSelector.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region draggable panel

        // Draggable Panel

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //drag is your variable flag.
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
            drag = true; //drag is your variable flag.
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoggerRefresh_Tick(object sender, EventArgs e)
        {
            LoggerUpdater();
        }
    }
}
