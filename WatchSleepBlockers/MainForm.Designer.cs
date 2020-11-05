namespace WatchSleepBlockers
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkPowercfgTimer = new System.Windows.Forms.Timer(this.components);
            this.blockersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Watch Sleep Blockers";
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // checkPowercfgTimer
            // 
            this.checkPowercfgTimer.Enabled = true;
            this.checkPowercfgTimer.Interval = 5000;
            this.checkPowercfgTimer.Tick += new System.EventHandler(this.checkPowercfgTimer_Tick);
            // 
            // blockersLabel
            // 
            this.blockersLabel.Location = new System.Drawing.Point(12, 9);
            this.blockersLabel.Name = "blockersLabel";
            this.blockersLabel.Size = new System.Drawing.Size(606, 211);
            this.blockersLabel.TabIndex = 0;
            this.blockersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 229);
            this.Controls.Add(this.blockersLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Watch Sleep Blockers";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Timer checkPowercfgTimer;
        private System.Windows.Forms.Label blockersLabel;
    }
}

