using System;
using System.Windows.Forms;

namespace OTCLoader
{
    public partial class Terms : UserControl
    {
        public Terms()
        {
            InitializeComponent();
        }

        internal void declinebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OTCLoader will not run unless the terms of service are accepted.", "Shutting Down", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        internal void acceptbtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.firstlaunch = false;
            Properties.Settings.Default.Save();
        }
    }
}
