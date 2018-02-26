namespace WindowsFormsApplication1
{
    partial class Cashier
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cpanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bminimize2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bclose2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.paneluser = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plbl2 = new System.Windows.Forms.Label();
            this.plbl1 = new System.Windows.Forms.Label();
            this.plbl3 = new System.Windows.Forms.Label();
            this.plbl4 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox5 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bminimize2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bclose2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneluser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // cpanel
            // 
            this.cpanel.BackColor = System.Drawing.Color.Green;
            this.cpanel.Controls.Add(this.bunifuCustomLabel1);
            this.cpanel.Controls.Add(this.bminimize2);
            this.cpanel.Controls.Add(this.bclose2);
            this.cpanel.Controls.Add(this.bunifuMetroTextbox1);
            this.cpanel.Controls.Add(this.pictureBox1);
            this.animation.SetDecoration(this.cpanel, BunifuAnimatorNS.DecorationType.None);
            this.cpanel.Location = new System.Drawing.Point(409, 68);
            this.cpanel.Name = "cpanel";
            this.cpanel.Size = new System.Drawing.Size(340, 112);
            this.cpanel.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "P.O.S.";
            // 
            // bminimize2
            // 
            this.bminimize2.BackColor = System.Drawing.Color.Lavender;
            this.bminimize2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.animation.SetDecoration(this.bminimize2, BunifuAnimatorNS.DecorationType.None);
            this.bminimize2.Image = ((System.Drawing.Image)(resources.GetObject("bminimize2.Image")));
            this.bminimize2.ImageActive = null;
            this.bminimize2.Location = new System.Drawing.Point(1175, 7);
            this.bminimize2.Name = "bminimize2";
            this.bminimize2.Size = new System.Drawing.Size(19, 19);
            this.bminimize2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bminimize2.TabIndex = 6;
            this.bminimize2.TabStop = false;
            this.bminimize2.Zoom = 10;
            this.bminimize2.Click += new System.EventHandler(this.bminimize2_Click);
            // 
            // bclose2
            // 
            this.bclose2.BackColor = System.Drawing.Color.Lavender;
            this.bclose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.animation.SetDecoration(this.bclose2, BunifuAnimatorNS.DecorationType.None);
            this.bclose2.Image = ((System.Drawing.Image)(resources.GetObject("bclose2.Image")));
            this.bclose2.ImageActive = null;
            this.bclose2.Location = new System.Drawing.Point(1203, 7);
            this.bclose2.Name = "bclose2";
            this.bclose2.Size = new System.Drawing.Size(19, 19);
            this.bclose2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bclose2.TabIndex = 5;
            this.bclose2.TabStop = false;
            this.bclose2.Zoom = 10;
            this.bclose2.Click += new System.EventHandler(this.bclose2_Click);
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Lavender;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.White;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.bunifuMetroTextbox1.BorderThickness = 2;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.bunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(64, 68);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(313, 34);
            this.bunifuMetroTextbox1.TabIndex = 2;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.animation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.cpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // paneluser
            // 
            this.paneluser.BackColor = System.Drawing.Color.PaleGreen;
            this.paneluser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paneluser.Controls.Add(this.tableLayoutPanel1);
            this.animation.SetDecoration(this.paneluser, BunifuAnimatorNS.DecorationType.None);
            this.paneluser.Location = new System.Drawing.Point(696, 186);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(244, 322);
            this.paneluser.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.17241F));
            this.tableLayoutPanel1.Controls.Add(this.plbl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.plbl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plbl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.plbl4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bunifuMetroTextbox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bunifuMetroTextbox4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bunifuMetroTextbox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuMetroTextbox5, 1, 3);
            this.animation.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.00855F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.99145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 286);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // plbl2
            // 
            this.plbl2.AutoSize = true;
            this.animation.SetDecoration(this.plbl2, BunifuAnimatorNS.DecorationType.None);
            this.plbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plbl2.ForeColor = System.Drawing.Color.DarkGreen;
            this.plbl2.Location = new System.Drawing.Point(8, 68);
            this.plbl2.Name = "plbl2";
            this.plbl2.Size = new System.Drawing.Size(131, 24);
            this.plbl2.TabIndex = 17;
            this.plbl2.Text = "NO. of ITEM:";
            // 
            // plbl1
            // 
            this.plbl1.AutoSize = true;
            this.plbl1.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.plbl1, BunifuAnimatorNS.DecorationType.None);
            this.plbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plbl1.ForeColor = System.Drawing.Color.DarkGreen;
            this.plbl1.Location = new System.Drawing.Point(8, 5);
            this.plbl1.Name = "plbl1";
            this.plbl1.Size = new System.Drawing.Size(83, 24);
            this.plbl1.TabIndex = 18;
            this.plbl1.Text = "TOTAL:";
            this.plbl1.Click += new System.EventHandler(this.plbl1_Click);
            // 
            // plbl3
            // 
            this.plbl3.AutoSize = true;
            this.animation.SetDecoration(this.plbl3, BunifuAnimatorNS.DecorationType.None);
            this.plbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plbl3.ForeColor = System.Drawing.Color.DarkGreen;
            this.plbl3.Location = new System.Drawing.Point(8, 139);
            this.plbl3.Name = "plbl3";
            this.plbl3.Size = new System.Drawing.Size(115, 24);
            this.plbl3.TabIndex = 16;
            this.plbl3.Text = "PAYMENT:";
            // 
            // plbl4
            // 
            this.plbl4.AutoSize = true;
            this.animation.SetDecoration(this.plbl4, BunifuAnimatorNS.DecorationType.None);
            this.plbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plbl4.ForeColor = System.Drawing.Color.DarkGreen;
            this.plbl4.Location = new System.Drawing.Point(8, 215);
            this.plbl4.Name = "plbl4";
            this.plbl4.Size = new System.Drawing.Size(103, 24);
            this.plbl4.TabIndex = 15;
            this.plbl4.Text = "CHANGE:";
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.Green;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.bunifuMetroTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(206, 9);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(234, 51);
            this.bunifuMetroTextbox2.TabIndex = 19;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.Green;
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox4.BorderThickness = 3;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.bunifuMetroTextbox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(206, 143);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(234, 54);
            this.bunifuMetroTextbox4.TabIndex = 21;
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.Green;
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox3.BorderThickness = 3;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.bunifuMetroTextbox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(206, 72);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(234, 52);
            this.bunifuMetroTextbox3.TabIndex = 20;
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox5
            // 
            this.bunifuMetroTextbox5.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox5.BorderColorIdle = System.Drawing.Color.Green;
            this.bunifuMetroTextbox5.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox5.BorderThickness = 3;
            this.bunifuMetroTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.bunifuMetroTextbox5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox5.isPassword = false;
            this.bunifuMetroTextbox5.Location = new System.Drawing.Point(206, 219);
            this.bunifuMetroTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox5.Name = "bunifuMetroTextbox5";
            this.bunifuMetroTextbox5.Size = new System.Drawing.Size(234, 49);
            this.bunifuMetroTextbox5.TabIndex = 23;
            this.bunifuMetroTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.animation.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.LinkColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(335, 126);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(65, 21);
            this.logout.TabIndex = 2;
            this.logout.TabStop = true;
            this.logout.Text = "Logout";
            // 
            // pictureBox2
            // 
            this.animation.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.animation.SetDecoration(this.lUsername, BunifuAnimatorNS.DecorationType.None);
            this.lUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.ForeColor = System.Drawing.Color.Lime;
            this.lUsername.Location = new System.Drawing.Point(69, 131);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(79, 16);
            this.lUsername.TabIndex = 0;
            this.lUsername.Text = "Username";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 0;
            this.bunifuElipse2.TargetControl = this.paneluser;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // animation
            // 
            this.animation.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.animation.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 1F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animation.DefaultAnimation = animation2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.bunifuCustomDataGrid1);
            this.animation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(3, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 518);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logout);
            this.panel3.Controls.Add(this.lUsername);
            this.panel3.Controls.Add(this.pictureBox2);
            this.animation.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(140, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 194);
            this.panel3.TabIndex = 25;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.animation.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Green;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(26, 38);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(672, 427);
            this.bunifuCustomDataGrid1.TabIndex = 14;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Item#";
            this.ProductID.Name = "ProductID";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ItemName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(986, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneluser);
            this.Controls.Add(this.cpanel);
            this.animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.Click += new System.EventHandler(this.Cashier_Click);
            this.cpanel.ResumeLayout(false);
            this.cpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bminimize2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bclose2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneluser.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cpanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bminimize2;
        private Bunifu.Framework.UI.BunifuImageButton bclose2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel paneluser;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.ImageList imageList1;
        private BunifuAnimatorNS.BunifuTransition animation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label plbl3;
        private System.Windows.Forms.Label plbl2;
        private System.Windows.Forms.Label plbl1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label plbl4;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox4;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox5;
    }
}