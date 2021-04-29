namespace OTCLoader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DebugSelector = new System.Windows.Forms.Label();
            this.LoaderSelector = new System.Windows.Forms.Label();
            this.CreditsSelector = new System.Windows.Forms.Label();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.stopaudio = new System.Windows.Forms.PictureBox();
            this.pin = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.PictureBox();
            this.unpin = new System.Windows.Forms.PictureBox();
            this.playaudio = new System.Windows.Forms.PictureBox();
            this.LoggerRefresh = new System.Windows.Forms.Timer(this.components);
            this.ConnectionRefresh = new System.Windows.Forms.Timer(this.components);
            this.SettingsSelector = new System.Windows.Forms.Label();
            this.Titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopaudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playaudio)).BeginInit();
            this.SuspendLayout();
            // 
            // DebugSelector
            // 
            this.DebugSelector.AutoSize = true;
            this.DebugSelector.BackColor = System.Drawing.Color.Transparent;
            this.DebugSelector.Cursor = System.Windows.Forms.Cursors.Help;
            this.DebugSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DebugSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DebugSelector.ForeColor = System.Drawing.Color.Gray;
            this.DebugSelector.Location = new System.Drawing.Point(14, 326);
            this.DebugSelector.Name = "DebugSelector";
            this.DebugSelector.Size = new System.Drawing.Size(50, 15);
            this.DebugSelector.TabIndex = 38;
            this.DebugSelector.Text = "[Debug]";
            // 
            // LoaderSelector
            // 
            this.LoaderSelector.AutoSize = true;
            this.LoaderSelector.BackColor = System.Drawing.Color.Transparent;
            this.LoaderSelector.Cursor = System.Windows.Forms.Cursors.Help;
            this.LoaderSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoaderSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LoaderSelector.ForeColor = System.Drawing.Color.Gainsboro;
            this.LoaderSelector.Location = new System.Drawing.Point(163, 326);
            this.LoaderSelector.Name = "LoaderSelector";
            this.LoaderSelector.Size = new System.Drawing.Size(52, 15);
            this.LoaderSelector.TabIndex = 37;
            this.LoaderSelector.Text = "[Loader]";
            // 
            // CreditsSelector
            // 
            this.CreditsSelector.AutoSize = true;
            this.CreditsSelector.BackColor = System.Drawing.Color.Transparent;
            this.CreditsSelector.Cursor = System.Windows.Forms.Cursors.Help;
            this.CreditsSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CreditsSelector.ForeColor = System.Drawing.Color.Gray;
            this.CreditsSelector.Location = new System.Drawing.Point(236, 326);
            this.CreditsSelector.Name = "CreditsSelector";
            this.CreditsSelector.Size = new System.Drawing.Size(51, 15);
            this.CreditsSelector.TabIndex = 36;
            this.CreditsSelector.Text = "[Credits]";
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Titlebar.Controls.Add(this.stopaudio);
            this.Titlebar.Controls.Add(this.pin);
            this.Titlebar.Controls.Add(this.minimize);
            this.Titlebar.Controls.Add(this.close);
            this.Titlebar.Controls.Add(this.title);
            this.Titlebar.Controls.Add(this.unpin);
            this.Titlebar.Controls.Add(this.playaudio);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(300, 32);
            this.Titlebar.TabIndex = 39;
            // 
            // stopaudio
            // 
            this.stopaudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopaudio.Image = ((System.Drawing.Image)(resources.GetObject("stopaudio.Image")));
            this.stopaudio.Location = new System.Drawing.Point(183, 4);
            this.stopaudio.Name = "stopaudio";
            this.stopaudio.Size = new System.Drawing.Size(25, 25);
            this.stopaudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopaudio.TabIndex = 42;
            this.stopaudio.TabStop = false;
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.Transparent;
            this.pin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pin.Image = ((System.Drawing.Image)(resources.GetObject("pin.Image")));
            this.pin.Location = new System.Drawing.Point(211, 3);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(25, 25);
            this.pin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin.TabIndex = 33;
            this.pin.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(239, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 32;
            this.minimize.TabStop = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(268, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 18;
            this.close.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(3, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(140, 25);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.title.TabIndex = 9;
            this.title.TabStop = false;
            // 
            // unpin
            // 
            this.unpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unpin.Image = ((System.Drawing.Image)(resources.GetObject("unpin.Image")));
            this.unpin.Location = new System.Drawing.Point(211, 3);
            this.unpin.Name = "unpin";
            this.unpin.Size = new System.Drawing.Size(25, 25);
            this.unpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unpin.TabIndex = 40;
            this.unpin.TabStop = false;
            // 
            // playaudio
            // 
            this.playaudio.Image = ((System.Drawing.Image)(resources.GetObject("playaudio.Image")));
            this.playaudio.Location = new System.Drawing.Point(183, 4);
            this.playaudio.Name = "playaudio";
            this.playaudio.Size = new System.Drawing.Size(25, 25);
            this.playaudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playaudio.TabIndex = 42;
            this.playaudio.TabStop = false;
            // 
            // LoggerRefresh
            // 
            this.LoggerRefresh.Enabled = true;
            this.LoggerRefresh.Interval = 1;
            this.LoggerRefresh.Tick += new System.EventHandler(this.LoggerRefresh_Tick);
            // 
            // ConnectionRefresh
            // 
            this.ConnectionRefresh.Enabled = true;
            this.ConnectionRefresh.Interval = 5000;
            this.ConnectionRefresh.Tick += new System.EventHandler(this.ConnectionRefresh_Tick);
            // 
            // SettingsSelector
            // 
            this.SettingsSelector.AutoSize = true;
            this.SettingsSelector.BackColor = System.Drawing.Color.Transparent;
            this.SettingsSelector.Cursor = System.Windows.Forms.Cursors.Help;
            this.SettingsSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SettingsSelector.ForeColor = System.Drawing.Color.Gray;
            this.SettingsSelector.Location = new System.Drawing.Point(85, 326);
            this.SettingsSelector.Name = "SettingsSelector";
            this.SettingsSelector.Size = new System.Drawing.Size(57, 15);
            this.SettingsSelector.TabIndex = 41;
            this.SettingsSelector.Text = "[Settings]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.SettingsSelector);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.DebugSelector);
            this.Controls.Add(this.LoaderSelector);
            this.Controls.Add(this.CreditsSelector);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTC Loader";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stopaudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playaudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        public System.Windows.Forms.Panel Titlebar;
        public System.Windows.Forms.Label DebugSelector;
        public System.Windows.Forms.Label LoaderSelector;
        public System.Windows.Forms.Label CreditsSelector;
        public System.Windows.Forms.PictureBox pin;
        public System.Windows.Forms.PictureBox unpin;
        public System.Windows.Forms.Label SettingsSelector;
        private System.Windows.Forms.PictureBox stopaudio;
        private System.Windows.Forms.PictureBox playaudio;
        internal System.Windows.Forms.Timer LoggerRefresh;
        internal System.Windows.Forms.Timer ConnectionRefresh;
        private System.Windows.Forms.PictureBox title;
    }
}

