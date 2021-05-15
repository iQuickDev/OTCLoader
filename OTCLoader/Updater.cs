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
        internal const string CurrentVersion = "0.6";
        internal bool showupdatebutton = false;
        internal string updatepath;
        public Updater()
        {
            InitializeComponent();
            updatepostponer.Click += UpdatePostponer_Click;
            updatebtn.Click += UpdateBtn_Click;
            folderselector.Click += folderselector_Click;
            installationfolder.Text = "Select a folder...";
            UpdateChecker();
        }

        internal void folderselector_Click(object sender, EventArgs e)
        {
            updatefolderselector.ShowDialog();
            updatepath = updatefolderselector.SelectedPath;
            installationfolder.Text = "Folder selected";
            updatebtn.Enabled = true;
        }

        public bool UpdateChecker()
        {
            string versionfile = Web.DownloadString("https://raw.githubusercontent.com/iQuickGaming/OTCLoader/main/version");
            installedversion.Text = "Installed Version: v" + CurrentVersion;
            newversion.Text = "New Version: v" + versionfile;
            showupdatebutton = !versionfile.Contains(CurrentVersion);
            return UpdateResult = !versionfile.Contains(CurrentVersion);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updatepath = updatepath + "\\OTCLoader.exe";
            string downloadfile = Web.DownloadString("https://raw.githubusercontent.com/iQuickGaming/OTCLoader/main/downloader");
            new Thread(() =>
            {
                Web.DownloadFile(downloadfile, updatepath);
            }).Start();

        }
        private void UpdatePostponer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}