
namespace OTCLoader
{
    partial class Offline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offline));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Connection = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "The Loader could not connect to the servers.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Connection
            // 
            this.Connection.Animated = true;
            this.Connection.AnimatedGIF = true;
            this.Connection.AutoRoundedCorners = true;
            this.Connection.BackColor = System.Drawing.Color.Transparent;
            this.Connection.BorderColor = System.Drawing.Color.Red;
            this.Connection.BorderRadius = 35;
            this.Connection.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Connection.CheckedState.Parent = this.Connection;
            this.Connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connection.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("Connection.CustomImages.Image")));
            this.Connection.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Connection.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.Connection.CustomImages.ImageSize = new System.Drawing.Size(180, 30);
            this.Connection.CustomImages.Parent = this.Connection;
            this.Connection.FillColor = System.Drawing.Color.Red;
            this.Connection.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold);
            this.Connection.ForeColor = System.Drawing.Color.Transparent;
            this.Connection.HoverState.Parent = this.Connection;
            this.Connection.Location = new System.Drawing.Point(45, 248);
            this.Connection.Name = "Connection";
            this.Connection.PressedColor = System.Drawing.Color.Orange;
            this.Connection.PressedDepth = 255;
            this.Connection.ShadowDecoration.BorderRadius = 35;
            this.Connection.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.Connection.ShadowDecoration.Depth = 15;
            this.Connection.ShadowDecoration.Enabled = true;
            this.Connection.ShadowDecoration.Parent = this.Connection;
            this.Connection.Size = new System.Drawing.Size(210, 72);
            this.Connection.TabIndex = 22;
            this.Connection.UseTransparentBackground = true;
            // 
            // Offline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Offline";
            this.Size = new System.Drawing.Size(300, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal Guna.UI2.WinForms.Guna2Button Connection;
    }
}
