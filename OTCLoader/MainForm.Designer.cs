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
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoggerRefresh = new System.Windows.Forms.Timer(this.components);
            this.ConnectionRefresh = new System.Windows.Forms.Timer(this.components);
            this.pin = new System.Windows.Forms.PictureBox();
            this.unpin = new System.Windows.Forms.PictureBox();
            this.Titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpin)).BeginInit();
            this.SuspendLayout();
            // 
            // DebugSelector
            // 
            this.DebugSelector.AutoSize = true;
            this.DebugSelector.BackColor = System.Drawing.Color.Transparent;
            this.DebugSelector.Cursor = System.Windows.Forms.Cursors.Help;
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
            this.LoaderSelector.Cursor = System.Windows.Forms.Cursors.Help;
            this.LoaderSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LoaderSelector.ForeColor = System.Drawing.Color.Gainsboro;
            this.LoaderSelector.Location = new System.Drawing.Point(124, 326);
            this.LoaderSelector.Name = "LoaderSelector";
            this.LoaderSelector.Size = new System.Drawing.Size(52, 15);
            this.LoaderSelector.TabIndex = 37;
            this.LoaderSelector.Text = "[Loader]";
            // 
            // CreditsSelector
            // 
            this.CreditsSelector.AutoSize = true;
            this.CreditsSelector.Cursor = System.Windows.Forms.Cursors.Help;
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
            this.Titlebar.Controls.Add(this.pin);
            this.Titlebar.Controls.Add(this.pictureBox11);
            this.Titlebar.Controls.Add(this.pictureBox4);
            this.Titlebar.Controls.Add(this.pictureBox2);
            this.Titlebar.Controls.Add(this.unpin);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(300, 32);
            this.Titlebar.TabIndex = 39;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(239, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 32;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(268, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
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
            // pin
            // 
            this.pin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pin.Image = ((System.Drawing.Image)(resources.GetObject("pin.Image")));
            this.pin.Location = new System.Drawing.Point(211, 3);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(25, 25);
            this.pin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin.TabIndex = 33;
            this.pin.TabStop = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.DebugSelector);
            this.Controls.Add(this.LoaderSelector);
            this.Controls.Add(this.CreditsSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTC Loader";
            this.Titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.Timer LoggerRefresh;
        public System.Windows.Forms.Timer ConnectionRefresh;
        public System.Windows.Forms.Panel Titlebar;
        public System.Windows.Forms.Label DebugSelector;
        public System.Windows.Forms.Label LoaderSelector;
        public System.Windows.Forms.Label CreditsSelector;
        public System.Windows.Forms.PictureBox pin;
        public System.Windows.Forms.PictureBox unpin;
    }
}

