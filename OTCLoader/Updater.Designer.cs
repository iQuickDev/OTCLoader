
namespace OTCLoader
{
    partial class Updater
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.installedversion = new System.Windows.Forms.Label();
            this.newversion = new System.Windows.Forms.Label();
            this.updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.updatepostponer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.installationfolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // installedversion
            // 
            this.installedversion.AutoSize = true;
            this.installedversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.installedversion.ForeColor = System.Drawing.Color.White;
            this.installedversion.Location = new System.Drawing.Point(30, 101);
            this.installedversion.Name = "installedversion";
            this.installedversion.Size = new System.Drawing.Size(257, 25);
            this.installedversion.TabIndex = 19;
            this.installedversion.Text = "Installed Version: Fetching...";
            // 
            // newversion
            // 
            this.newversion.AutoSize = true;
            this.newversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newversion.ForeColor = System.Drawing.Color.White;
            this.newversion.Location = new System.Drawing.Point(30, 127);
            this.newversion.Name = "newversion";
            this.newversion.Size = new System.Drawing.Size(224, 25);
            this.newversion.TabIndex = 20;
            this.newversion.Text = "New Version: Fetching...";
            // 
            // updatebtn
            // 
            this.updatebtn.Animated = true;
            this.updatebtn.AnimatedGIF = true;
            this.updatebtn.AutoRoundedCorners = true;
            this.updatebtn.BackColor = System.Drawing.Color.Transparent;
            this.updatebtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.updatebtn.BorderRadius = 35;
            this.updatebtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.updatebtn.CheckedState.Parent = this.updatebtn;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("updatebtn.CustomImages.Image")));
            this.updatebtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updatebtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -15);
            this.updatebtn.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.updatebtn.CustomImages.Parent = this.updatebtn;
            this.updatebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.updatebtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold);
            this.updatebtn.ForeColor = System.Drawing.Color.Transparent;
            this.updatebtn.HoverState.Parent = this.updatebtn;
            this.updatebtn.Location = new System.Drawing.Point(45, 232);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.PressedColor = System.Drawing.Color.Aqua;
            this.updatebtn.PressedDepth = 255;
            this.updatebtn.ShadowDecoration.BorderRadius = 35;
            this.updatebtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.updatebtn.ShadowDecoration.Depth = 15;
            this.updatebtn.ShadowDecoration.Enabled = true;
            this.updatebtn.ShadowDecoration.Parent = this.updatebtn;
            this.updatebtn.Size = new System.Drawing.Size(210, 72);
            this.updatebtn.TabIndex = 21;
            this.updatebtn.UseTransparentBackground = true;
            // 
            // updatepostponer
            // 
            this.updatepostponer.AutoSize = true;
            this.updatepostponer.Cursor = System.Windows.Forms.Cursors.Help;
            this.updatepostponer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.updatepostponer.ForeColor = System.Drawing.Color.Gray;
            this.updatepostponer.Location = new System.Drawing.Point(96, 326);
            this.updatepostponer.Name = "updatepostponer";
            this.updatepostponer.Size = new System.Drawing.Size(108, 15);
            this.updatepostponer.TabIndex = 37;
            this.updatepostponer.Text = "[Postpone Update]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // installationfolder
            // 
            this.installationfolder.AutoSize = true;
            this.installationfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.installationfolder.ForeColor = System.Drawing.Color.White;
            this.installationfolder.Location = new System.Drawing.Point(78, 172);
            this.installationfolder.Name = "installationfolder";
            this.installationfolder.Size = new System.Drawing.Size(67, 25);
            this.installationfolder.TabIndex = 39;
            this.installationfolder.Text = "Folder";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.installationfolder);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.updatepostponer);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.newversion);
            this.Controls.Add(this.installedversion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Updater";
            this.Size = new System.Drawing.Size(300, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label installedversion;
        private System.Windows.Forms.Label newversion;
        private Guna.UI2.WinForms.Guna2Button updatebtn;
        private System.Windows.Forms.Label updatepostponer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label installationfolder;
    }
}
