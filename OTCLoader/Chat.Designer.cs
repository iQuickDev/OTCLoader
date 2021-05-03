
namespace OTCLoader
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.sendbtn = new Guna.UI2.WinForms.Guna2Button();
            this.chatbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.alertbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendbtn
            // 
            this.sendbtn.Animated = true;
            this.sendbtn.AnimatedGIF = true;
            this.sendbtn.BackColor = System.Drawing.Color.Transparent;
            this.sendbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.sendbtn.BorderRadius = 5;
            this.sendbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.sendbtn.CheckedState.Parent = this.sendbtn;
            this.sendbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("sendbtn.CustomImages.Image")));
            this.sendbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sendbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, 1);
            this.sendbtn.CustomImages.Parent = this.sendbtn;
            this.sendbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.ForeColor = System.Drawing.Color.Transparent;
            this.sendbtn.HoverState.Parent = this.sendbtn;
            this.sendbtn.Location = new System.Drawing.Point(231, 275);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.PressedColor = System.Drawing.Color.Aqua;
            this.sendbtn.PressedDepth = 255;
            this.sendbtn.ShadowDecoration.BorderRadius = 15;
            this.sendbtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.sendbtn.ShadowDecoration.Depth = 15;
            this.sendbtn.ShadowDecoration.Enabled = true;
            this.sendbtn.ShadowDecoration.Parent = this.sendbtn;
            this.sendbtn.Size = new System.Drawing.Size(50, 30);
            this.sendbtn.TabIndex = 27;
            this.sendbtn.Text = "SET";
            this.sendbtn.UseTransparentBackground = true;
            // 
            // chatbox
            // 
            this.chatbox.Animated = true;
            this.chatbox.BackColor = System.Drawing.Color.Transparent;
            this.chatbox.BorderColor = System.Drawing.Color.Black;
            this.chatbox.BorderRadius = 5;
            this.chatbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatbox.DefaultText = "";
            this.chatbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chatbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chatbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatbox.DisabledState.Parent = this.chatbox;
            this.chatbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chatbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatbox.FocusedState.Parent = this.chatbox;
            this.chatbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chatbox.ForeColor = System.Drawing.Color.White;
            this.chatbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatbox.HoverState.Parent = this.chatbox;
            this.chatbox.Location = new System.Drawing.Point(21, 275);
            this.chatbox.Name = "chatbox";
            this.chatbox.PasswordChar = '\0';
            this.chatbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.chatbox.PlaceholderText = "message";
            this.chatbox.SelectedText = "";
            this.chatbox.ShadowDecoration.Parent = this.chatbox;
            this.chatbox.Size = new System.Drawing.Size(200, 30);
            this.chatbox.TabIndex = 26;
            // 
            // alertbox
            // 
            this.alertbox.Animated = true;
            this.alertbox.BackColor = System.Drawing.Color.Transparent;
            this.alertbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.alertbox.BorderRadius = 10;
            this.alertbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.alertbox.DefaultText = resources.GetString("alertbox.DefaultText");
            this.alertbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.alertbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.alertbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.alertbox.DisabledState.Parent = this.alertbox;
            this.alertbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.alertbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.alertbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.alertbox.FocusedState.Parent = this.alertbox;
            this.alertbox.Font = new System.Drawing.Font("Segoe UI", 8.6F);
            this.alertbox.ForeColor = System.Drawing.Color.White;
            this.alertbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.alertbox.HoverState.Parent = this.alertbox;
            this.alertbox.Location = new System.Drawing.Point(25, 120);
            this.alertbox.Multiline = true;
            this.alertbox.Name = "alertbox";
            this.alertbox.PasswordChar = '\0';
            this.alertbox.PlaceholderForeColor = System.Drawing.Color.White;
            this.alertbox.PlaceholderText = "";
            this.alertbox.ReadOnly = true;
            this.alertbox.SelectedText = "";
            this.alertbox.SelectionStart = 238;
            this.alertbox.ShadowDecoration.Parent = this.alertbox;
            this.alertbox.Size = new System.Drawing.Size(250, 135);
            this.alertbox.TabIndex = 28;
            this.alertbox.TabStop = false;
            this.alertbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.alertbox);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.chatbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(300, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        internal Guna.UI2.WinForms.Guna2Button sendbtn;
        internal Guna.UI2.WinForms.Guna2TextBox chatbox;
        internal Guna.UI2.WinForms.Guna2TextBox alertbox;
    }
}
