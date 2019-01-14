namespace WindowsFormsApplication1
{
    partial class mform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mform));
            this.mformpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginfrm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bminimize1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bclose1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logpanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textUsername1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Blog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cshow = new System.Windows.Forms.CheckBox();
            this.atime = new System.Windows.Forms.Label();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.getid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblhint = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mformpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bminimize1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bclose1)).BeginInit();
            this.logpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mformpanel
            // 
            this.mformpanel.BackColor = System.Drawing.Color.White;
            this.mformpanel.Controls.Add(this.pictureBox1);
            this.mformpanel.Controls.Add(this.loginfrm);
            this.mformpanel.Controls.Add(this.bminimize1);
            this.mformpanel.Controls.Add(this.bclose1);
            this.mformpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mformpanel.Location = new System.Drawing.Point(0, 0);
            this.mformpanel.Name = "mformpanel";
            this.mformpanel.Size = new System.Drawing.Size(374, 33);
            this.mformpanel.TabIndex = 2;
            this.mformpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mformpanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // loginfrm
            // 
            this.loginfrm.AutoSize = true;
            this.loginfrm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.loginfrm.Location = new System.Drawing.Point(32, 7);
            this.loginfrm.Name = "loginfrm";
            this.loginfrm.Size = new System.Drawing.Size(141, 17);
            this.loginfrm.TabIndex = 7;
            this.loginfrm.Text = "MAHESECO Login Form";
            // 
            // bminimize1
            // 
            this.bminimize1.BackColor = System.Drawing.Color.White;
            this.bminimize1.Image = ((System.Drawing.Image)(resources.GetObject("bminimize1.Image")));
            this.bminimize1.ImageActive = null;
            this.bminimize1.Location = new System.Drawing.Point(318, 6);
            this.bminimize1.Name = "bminimize1";
            this.bminimize1.Size = new System.Drawing.Size(19, 20);
            this.bminimize1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bminimize1.TabIndex = 6;
            this.bminimize1.TabStop = false;
            this.bminimize1.Zoom = 10;
            this.bminimize1.Click += new System.EventHandler(this.bminimize1_Click);
            // 
            // bclose1
            // 
            this.bclose1.BackColor = System.Drawing.Color.White;
            this.bclose1.Image = ((System.Drawing.Image)(resources.GetObject("bclose1.Image")));
            this.bclose1.ImageActive = null;
            this.bclose1.Location = new System.Drawing.Point(343, 6);
            this.bclose1.Name = "bclose1";
            this.bclose1.Size = new System.Drawing.Size(19, 20);
            this.bclose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bclose1.TabIndex = 5;
            this.bclose1.TabStop = false;
            this.bclose1.Zoom = 10;
            this.bclose1.Click += new System.EventHandler(this.bclose1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.mformpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // logpanel
            // 
            this.logpanel.BackColor = System.Drawing.Color.Green;
            this.logpanel.Controls.Add(this.lblhint);
            this.logpanel.Controls.Add(this.pictureBox4);
            this.logpanel.Controls.Add(this.pictureBox3);
            this.logpanel.Controls.Add(this.pictureBox2);
            this.logpanel.Controls.Add(this.textPassword);
            this.logpanel.Controls.Add(this.textUsername1);
            this.logpanel.Controls.Add(this.Blog);
            this.logpanel.Controls.Add(this.cshow);
            this.logpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logpanel.Location = new System.Drawing.Point(0, 33);
            this.logpanel.Name = "logpanel";
            this.logpanel.Size = new System.Drawing.Size(374, 433);
            this.logpanel.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(113, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(147, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textPassword
            // 
            this.textPassword.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.textPassword.BorderColorIdle = System.Drawing.Color.Lavender;
            this.textPassword.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.textPassword.BorderThickness = 3;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.Lavender;
            this.textPassword.isPassword = false;
            this.textPassword.Location = new System.Drawing.Point(56, 252);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(285, 43);
            this.textPassword.TabIndex = 28;
            this.textPassword.Text = "Password";
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPassword.OnValueChanged += new System.EventHandler(this.textPassword_OnValueChanged);
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPassword_KeyDown);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // textUsername1
            // 
            this.textUsername1.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.textUsername1.BorderColorIdle = System.Drawing.Color.Lavender;
            this.textUsername1.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.textUsername1.BorderThickness = 3;
            this.textUsername1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername1.ForeColor = System.Drawing.Color.Lavender;
            this.textUsername1.isPassword = false;
            this.textUsername1.Location = new System.Drawing.Point(56, 191);
            this.textUsername1.Margin = new System.Windows.Forms.Padding(4);
            this.textUsername1.Name = "textUsername1";
            this.textUsername1.Size = new System.Drawing.Size(285, 43);
            this.textUsername1.TabIndex = 27;
            this.textUsername1.Text = "Username";
            this.textUsername1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textUsername1.Enter += new System.EventHandler(this.textUsername1_Enter);
            this.textUsername1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUsername1_KeyDown);
            this.textUsername1.Leave += new System.EventHandler(this.textUsername1_Leave);
            // 
            // Blog
            // 
            this.Blog.Activecolor = System.Drawing.Color.LimeGreen;
            this.Blog.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Blog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Blog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Blog.BorderRadius = 2;
            this.Blog.ButtonText = "Login";
            this.Blog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Blog.DisabledColor = System.Drawing.Color.Gray;
            this.Blog.Iconcolor = System.Drawing.Color.Transparent;
            this.Blog.Iconimage = null;
            this.Blog.Iconimage_right = null;
            this.Blog.Iconimage_right_Selected = null;
            this.Blog.Iconimage_Selected = null;
            this.Blog.IconMarginLeft = 0;
            this.Blog.IconMarginRight = 0;
            this.Blog.IconRightVisible = true;
            this.Blog.IconRightZoom = 0D;
            this.Blog.IconVisible = true;
            this.Blog.IconZoom = 60D;
            this.Blog.IsTab = false;
            this.Blog.Location = new System.Drawing.Point(56, 358);
            this.Blog.Name = "Blog";
            this.Blog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Blog.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.Blog.OnHoverTextColor = System.Drawing.Color.DarkGreen;
            this.Blog.selected = false;
            this.Blog.Size = new System.Drawing.Size(285, 46);
            this.Blog.TabIndex = 22;
            this.Blog.Text = "Login";
            this.Blog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Blog.Textcolor = System.Drawing.Color.White;
            this.Blog.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // cshow
            // 
            this.cshow.AutoSize = true;
            this.cshow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cshow.ForeColor = System.Drawing.Color.Lavender;
            this.cshow.Location = new System.Drawing.Point(25, 311);
            this.cshow.Name = "cshow";
            this.cshow.Size = new System.Drawing.Size(110, 20);
            this.cshow.TabIndex = 17;
            this.cshow.Text = "show password";
            this.cshow.ThreeState = true;
            this.cshow.UseVisualStyleBackColor = false;
            this.cshow.CheckedChanged += new System.EventHandler(this.cshow_CheckedChanged);
            // 
            // atime
            // 
            this.atime.AutoSize = true;
            this.atime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.atime.Location = new System.Drawing.Point(42, 51);
            this.atime.Name = "atime";
            this.atime.Size = new System.Drawing.Size(62, 25);
            this.atime.TabIndex = 4;
            this.atime.Text = "clock";
            // 
            // tick
            // 
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // getid
            // 
            this.getid.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.getid.BorderColorIdle = System.Drawing.Color.Lavender;
            this.getid.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.getid.BorderThickness = 3;
            this.getid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getid.ForeColor = System.Drawing.Color.Lavender;
            this.getid.isPassword = false;
            this.getid.Location = new System.Drawing.Point(22, 125);
            this.getid.Margin = new System.Windows.Forms.Padding(4);
            this.getid.Name = "getid";
            this.getid.Size = new System.Drawing.Size(260, 43);
            this.getid.TabIndex = 28;
            this.getid.Text = "Username";
            this.getid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblhint
            // 
            this.lblhint.AutoSize = true;
            this.lblhint.ForeColor = System.Drawing.Color.Red;
            this.lblhint.Location = new System.Drawing.Point(59, 295);
            this.lblhint.Name = "lblhint";
            this.lblhint.Size = new System.Drawing.Size(169, 13);
            this.lblhint.TabIndex = 32;
            this.lblhint.Text = "Password is invalid please re-enter";
            this.lblhint.Visible = false;
            // 
            // mform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(374, 466);
            this.Controls.Add(this.logpanel);
            this.Controls.Add(this.mformpanel);
            this.Controls.Add(this.atime);
            this.Controls.Add(this.getid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Load += new System.EventHandler(this.mform_Load);
            this.mformpanel.ResumeLayout(false);
            this.mformpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bminimize1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bclose1)).EndInit();
            this.logpanel.ResumeLayout(false);
            this.logpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mformpanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bminimize1;
        private Bunifu.Framework.UI.BunifuImageButton bclose1;
        private Bunifu.Framework.UI.BunifuCustomLabel loginfrm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel logpanel;
        private Bunifu.Framework.UI.BunifuMetroTextbox textPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox textUsername1;
        private Bunifu.Framework.UI.BunifuFlatButton Blog;
        private System.Windows.Forms.CheckBox cshow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label atime;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox getid;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblhint;
    }
}