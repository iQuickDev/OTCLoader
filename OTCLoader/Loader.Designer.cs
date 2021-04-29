
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
            this.loadbtn = new Guna.UI2.WinForms.Guna2Button();
            this.spinningbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.csgonotrunning = new System.Windows.Forms.Label();
            this.versionlabel = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Visible = false;
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
            // spinningbar
            // 
            this.spinningbar.Animated = true;
            this.spinningbar.AnimationSpeed = 2F;
            this.spinningbar.BackColor = System.Drawing.Color.Transparent;
            this.spinningbar.FillColor = System.Drawing.Color.Transparent;
            this.spinningbar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.spinningbar.Location = new System.Drawing.Point(75, 58);
            this.spinningbar.Name = "spinningbar";
            this.spinningbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.spinningbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.spinningbar.ProgressThickness = 15;
            this.spinningbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.spinningbar.ShadowDecoration.Parent = this.spinningbar;
            this.spinningbar.Size = new System.Drawing.Size(150, 150);
            this.spinningbar.TabIndex = 20;
            this.spinningbar.UseTransparentBackground = true;
            this.spinningbar.Value = 25;
            // 
            // csgonotrunning
            // 
            this.csgonotrunning.AutoSize = true;
            this.csgonotrunning.ForeColor = System.Drawing.Color.Red;
            this.csgonotrunning.Location = new System.Drawing.Point(31, 212);
            this.csgonotrunning.Name = "csgonotrunning";
            this.csgonotrunning.Size = new System.Drawing.Size(244, 13);
            this.csgonotrunning.TabIndex = 21;
            this.csgonotrunning.Text = "ERROR: Injection canceled, CS:GO is not running";
            this.csgonotrunning.Visible = false;
            // 
            // versionlabel
            // 
            this.versionlabel.AutoSize = true;
            this.versionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.versionlabel.ForeColor = System.Drawing.Color.Gray;
            this.versionlabel.Location = new System.Drawing.Point(3, 36);
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(35, 17);
            this.versionlabel.TabIndex = 22;
            this.versionlabel.Text = "v0.4";
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.versionlabel);
            this.Controls.Add(this.csgonotrunning);
            this.Controls.Add(this.spinningbar);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
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
        private Guna.UI2.WinForms.Guna2Button loadbtn;
        internal Guna.UI2.WinForms.Guna2CircleProgressBar spinningbar;
        private System.Windows.Forms.Label csgonotrunning;
        private System.Windows.Forms.Label versionlabel;
    }
}
