
namespace OTCLoader
{
    partial class Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.loadbtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(108, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 10;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.Aqua;
            this.xuiCircleProgressBar1.FilledColorAlpha = 255;
            this.xuiCircleProgressBar1.FilledThickness = 15;
            this.xuiCircleProgressBar1.IsAnimated = true;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(75, 58);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 20;
            this.xuiCircleProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xuiCircleProgressBar1.ShowText = false;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.xuiCircleProgressBar1.TabIndex = 12;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Transparent;
            this.xuiCircleProgressBar1.TextSize = 1;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.Transparent;
            this.xuiCircleProgressBar1.UnfilledThickness = 1;
            // 
            // loadbtn
            // 
            this.loadbtn.Animated = true;
            this.loadbtn.AnimatedGIF = true;
            this.loadbtn.AutoRoundedCorners = true;
            this.loadbtn.BackColor = System.Drawing.Color.Transparent;
            this.loadbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.loadbtn.BorderRadius = 35;
            this.loadbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.loadbtn.CheckedState.Parent = this.loadbtn;
            this.loadbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("loadbtn.CustomImages.Image")));
            this.loadbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loadbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -4);
            this.loadbtn.CustomImages.ImageSize = new System.Drawing.Size(115, 35);
            this.loadbtn.CustomImages.Parent = this.loadbtn;
            this.loadbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.loadbtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold);
            this.loadbtn.ForeColor = System.Drawing.Color.Transparent;
            this.loadbtn.HoverState.Parent = this.loadbtn;
            this.loadbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.loadbtn.Location = new System.Drawing.Point(45, 232);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.PressedColor = System.Drawing.Color.Aqua;
            this.loadbtn.PressedDepth = 255;
            this.loadbtn.ShadowDecoration.BorderRadius = 35;
            this.loadbtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.loadbtn.ShadowDecoration.Depth = 15;
            this.loadbtn.ShadowDecoration.Enabled = true;
            this.loadbtn.ShadowDecoration.Parent = this.loadbtn;
            this.loadbtn.Size = new System.Drawing.Size(210, 72);
            this.loadbtn.TabIndex = 19;
            this.loadbtn.UseTransparentBackground = true;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.Name = "Loader";
            this.Size = new System.Drawing.Size(300, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private Guna.UI2.WinForms.Guna2Button loadbtn;
    }
}
