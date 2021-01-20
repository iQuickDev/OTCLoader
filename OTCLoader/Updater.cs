using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace OTCLoader
{
    public partial class Updater : UserControl
    {
        internal bool UpdateResult { get; private set; } = false;
        public static WebClient Web { get; set; } = new WebClient();
        private const string CurrentVersion = "0.1";

        public Updater()
        {
            InitializeComponent();
            updatepostponer.Click += UpdatePostponer_Click;
            updatebtn.Click += UpdateBtn_Click;
            installationfolder.Text = "Desktop";
            UpdateChecker();
        }
        public bool UpdateChecker()
        {
            string versionfile = Web.DownloadString("https://raw.githubusercontent.com/iQuickGaming/OTCLoader/main/version");
            installedversion.Text = "Installed Version: v" + CurrentVersion;
            newversion.Text = "New Version: v" + versionfile;
            return UpdateResult = !versionfile.Contains(CurrentVersion);
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string desktopfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string updatepath = desktopfolder + "\\OTCLoader.exe";
            string downloadfile = Web.DownloadString("https://raw.githubusercontent.com/iQuickGaming/OTCLoader/main/downloader");
            new Thread(() =>
            {
                Web.DownloadFile(downloadfile, updatepath);
            }).Start();

            Application.Exit();
        }
        private void UpdatePostponer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}