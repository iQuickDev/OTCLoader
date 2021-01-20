using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTCLoader
{
    public partial class Offline : UserControl
    {
        public Offline()
        {
            InitializeComponent();

            Connection.Click += delegate
            {
                if (ConnectionChecker())
                {
                    var form = ((MainForm)ParentForm);
                    if (form.CreditsSelector.ForeColor == Color.Gainsboro)
                        (form.CreditsSelector.Tag as Control).BringToFront();
                    else if (form.LoaderSelector.ForeColor == Color.Gainsboro)
                        (form.LoaderSelector.Tag as Control).BringToFront();
                    else if (form.DebugSelector.ForeColor == Color.Gainsboro)
                        (form.DebugSelector.Tag as Control).BringToFront();
                    form.Titlebar.BringToFront();
                    form.CreditsSelector.BringToFront();
                    form.LoaderSelector.BringToFront();
                    form.DebugSelector.BringToFront();
                }
            };
        }

        public bool ConnectionChecker()
        {
            IDisposable stream = null;
            try
            {
                stream = Updater.Web.OpenRead("https://www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                stream?.Dispose();
            }
        }
    }
}
