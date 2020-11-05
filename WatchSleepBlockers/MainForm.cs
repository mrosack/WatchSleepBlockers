using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchSleepBlockers
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            checkPowercfgTimer_Tick(null, null);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayIcon.Visible = true;
            }
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;

        }

        private async void checkPowercfgTimer_Tick(object sender, EventArgs e)
        {
            var requests = await PowercfgRequestParser.GetActiveRequests();
            Icon icon;

            if (requests.Length == 0)
            {
                blockersLabel.Text = "There is nothing preventing this computer from sleeping!";
                icon = new System.Drawing.Icon("sleeping_emoji.ico");
            }
            else
            {
                blockersLabel.Text = "The following issues are preventing the computer from sleeping: " + Environment.NewLine + Environment.NewLine;
                icon = new System.Drawing.Icon("angry_face_with_horns.ico");

                foreach (var request in requests)
                {
                    blockersLabel.Text += request + Environment.NewLine;
                }
            }

            this.Icon = icon;
            trayIcon.Icon = icon;
        }
    }
}
