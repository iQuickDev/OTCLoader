using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using OTCLoader;

namespace OTCLoader
{
    public partial class Credits : UserControl
    {
        public Credits()
        {
            InitializeComponent();

            pictureBox4.Click += pictureBox4_Click;
            pictureBox5.Click += pictureBox5_Click;
            pictureBox6.Click += pictureBox6_Click;
            pictureBox7.Click += pictureBox7_Click;
            pictureBox8.Click += pictureBox8_Click;
            pictureBox9.Click += pictureBox9_Click;
            pictureBox1.Parent = xuiCircleProgressBar1;
            pictureBox1.Location = new Point(xuiCircleProgressBar1.Width / 2 - pictureBox1.Width / 2, xuiCircleProgressBar1.Height / 2 - pictureBox1.Height / 2);
        }
        private void pictureBox4_Click (object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/iQuickGaming/featured");
        }

        private void pictureBox5_Click (object sender, EventArgs e)
        {
            Process.Start("https://github.com/iQuickGaming");
        }
        private void pictureBox6_Click (object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/eNDZrQZ");
        }

        private void pictureBox7_Click (object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/id/iQuickGaming/");
        }

        private void pictureBox8_Click (object sender, EventArgs e)
        {
            Process.Start("https://iquickgaming.weebly.com");
        }

        private void pictureBox9_Click (object sender, EventArgs e)
        {
            Process.Start("https://quicksense.xyz");
        }
    }
}
