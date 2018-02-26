namespace WindowsFormsApplication1
{
    partial class permission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(permission));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textUsername1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Blog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cshow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(54, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // textPassword
            // 
            this.textPassword.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.textPassword.BorderColorIdle = System.Drawing.Color.Lavender;
            this.textPassword.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.textPassword.BorderThickness = 3;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textPassword.ForeColor = System.Drawing.Color.Lavender;
            this.textPassword.isPassword = false;
            this.textPassword.Location = new System.Drawing.Point(102, 133);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(260, 43);
            this.textPassword.TabIndex = 34;
            this.textPassword.Text = "Password";
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textUsername1
            // 
            this.textUsername1.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.textUsername1.BorderColorIdle = System.Drawing.Color.Lavender;
            this.textUsername1.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.textUsername1.BorderThickness = 3;
            this.textUsername1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textUsername1.ForeColor = System.Drawing.Color.Lavender;
            this.textUsername1.isPassword = false;
            this.textUsername1.Location = new System.Drawing.Point(102, 72);
            this.textUsername1.Margin = new System.Windows.Forms.Padding(4);
            this.textUsername1.Name = "textUsername1";
            this.textUsername1.Size = new System.Drawing.Size(260, 43);
            this.textUsername1.TabIndex = 33;
            this.textUsername1.Text = "Username";
            this.textUsername1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Blog
            // 
            this.Blog.Activecolor = System.Drawing.Color.LimeGreen;
            this.Blog.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Blog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Blog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Blog.BorderRadius = 2;
            this.Blog.ButtonText = "Update        ";
            this.Blog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Blog.DisabledColor = System.Drawing.Color.Gray;
            this.Blog.Iconcolor = System.Drawing.Color.Transparent;
            this.Blog.Iconimage = ((System.Drawing.Image)(resources.GetObject("Blog.Iconimage")));
            this.Blog.Iconimage_right = null;
            this.Blog.Iconimage_right_Selected = null;
            this.Blog.Iconimage_Selected = null;
            this.Blog.IconMarginLeft = 30;
            this.Blog.IconMarginRight = 0;
            this.Blog.IconRightVisible = true;
            this.Blog.IconRightZoom = 0D;
            this.Blog.IconVisible = true;
            this.Blog.IconZoom = 60D;
            this.Blog.IsTab = false;
            this.Blog.Location = new System.Drawing.Point(54, 236);
            this.Blog.Name = "Blog";
            this.Blog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Blog.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.Blog.OnHoverTextColor = System.Drawing.Color.DarkGreen;
            this.Blog.selected = false;
            this.Blog.Size = new System.Drawing.Size(308, 46);
            this.Blog.TabIndex = 32;
            this.Blog.Text = "Update        ";
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
            this.cshow.Location = new System.Drawing.Point(54, 201);
            this.cshow.Name = "cshow";
            this.cshow.Size = new System.Drawing.Size(110, 20);
            this.cshow.TabIndex = 31;
            this.cshow.Text = "show password";
            this.cshow.ThreeState = true;
            this.cshow.UseVisualStyleBackColor = false;
            // 
            // permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(411, 321);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername1);
            this.Controls.Add(this.Blog);
            this.Controls.Add(this.cshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "permission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "permission";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox textPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox textUsername1;
        private Bunifu.Framework.UI.BunifuFlatButton Blog;
        private System.Windows.Forms.CheckBox cshow;
    }
}