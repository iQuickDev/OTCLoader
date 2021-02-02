using System;
using System.Windows.Forms;

namespace OTCLoader
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
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

        internal void setter_Click(object sender, EventArgs e)
        {
            if (injectiondelay.Text.Length == 0)
            {
                return;
            }

            ulong parseddelay = ulong.Parse(injectiondelay.Text);
            Properties.Settings.Default.injectiondelay = parseddelay;
            Properties.Settings.Default.Save();
        }
    }
}
