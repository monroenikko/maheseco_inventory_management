namespace WindowsFormsApplication1
{
    partial class POSqty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSqty));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CLOSE = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_report = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_change = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_money = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ENTER = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "PAYMENT:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuMetroTextbox1);
            this.panel1.Controls.Add(this.ENTER);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_money);
            this.panel1.Controls.Add(this.tb_change);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.CLOSE);
            this.panel1.Location = new System.Drawing.Point(5, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 517);
            this.panel1.TabIndex = 0;
            // 
            // CLOSE
            // 
            this.CLOSE.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CLOSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CLOSE.BorderRadius = 0;
            this.CLOSE.ButtonText = "         CLOSE";
            this.CLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CLOSE.DisabledColor = System.Drawing.Color.Gray;
            this.CLOSE.ForeColor = System.Drawing.Color.Lime;
            this.CLOSE.Iconcolor = System.Drawing.Color.Transparent;
            this.CLOSE.Iconimage = ((System.Drawing.Image)(resources.GetObject("CLOSE.Iconimage")));
            this.CLOSE.Iconimage_right = null;
            this.CLOSE.Iconimage_right_Selected = null;
            this.CLOSE.Iconimage_Selected = null;
            this.CLOSE.IconMarginLeft = 100;
            this.CLOSE.IconMarginRight = 0;
            this.CLOSE.IconRightVisible = true;
            this.CLOSE.IconRightZoom = 0D;
            this.CLOSE.IconVisible = true;
            this.CLOSE.IconZoom = 60D;
            this.CLOSE.IsTab = false;
            this.CLOSE.Location = new System.Drawing.Point(28, 468);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CLOSE.OnHovercolor = System.Drawing.Color.Green;
            this.CLOSE.OnHoverTextColor = System.Drawing.Color.White;
            this.CLOSE.selected = false;
            this.CLOSE.Size = new System.Drawing.Size(341, 45);
            this.CLOSE.TabIndex = 53;
            this.CLOSE.Text = "         CLOSE";
            this.CLOSE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLOSE.Textcolor = System.Drawing.Color.White;
            this.CLOSE.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_report
            // 
            this.btn_report.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_report.BorderRadius = 0;
            this.btn_report.ButtonText = "         REPORT";
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report.DisabledColor = System.Drawing.Color.Gray;
            this.btn_report.ForeColor = System.Drawing.Color.Lime;
            this.btn_report.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_report.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_report.Iconimage")));
            this.btn_report.Iconimage_right = null;
            this.btn_report.Iconimage_right_Selected = null;
            this.btn_report.Iconimage_Selected = null;
            this.btn_report.IconMarginLeft = 100;
            this.btn_report.IconMarginRight = 0;
            this.btn_report.IconRightVisible = true;
            this.btn_report.IconRightZoom = 0D;
            this.btn_report.IconVisible = true;
            this.btn_report.IconZoom = 60D;
            this.btn_report.IsTab = false;
            this.btn_report.Location = new System.Drawing.Point(28, 417);
            this.btn_report.Name = "btn_report";
            this.btn_report.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_report.OnHovercolor = System.Drawing.Color.Green;
            this.btn_report.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_report.selected = false;
            this.btn_report.Size = new System.Drawing.Size(341, 45);
            this.btn_report.TabIndex = 54;
            this.btn_report.Text = "         REPORT";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_report.Textcolor = System.Drawing.Color.White;
            this.btn_report.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_print
            // 
            this.btn_print.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print.BorderRadius = 0;
            this.btn_print.ButtonText = "  PRINT RECEIPT";
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.DisabledColor = System.Drawing.Color.Gray;
            this.btn_print.ForeColor = System.Drawing.Color.Lime;
            this.btn_print.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_print.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_print.Iconimage")));
            this.btn_print.Iconimage_right = null;
            this.btn_print.Iconimage_right_Selected = null;
            this.btn_print.Iconimage_Selected = null;
            this.btn_print.IconMarginLeft = 100;
            this.btn_print.IconMarginRight = 0;
            this.btn_print.IconRightVisible = true;
            this.btn_print.IconRightZoom = 0D;
            this.btn_print.IconVisible = true;
            this.btn_print.IconZoom = 60D;
            this.btn_print.IsTab = false;
            this.btn_print.Location = new System.Drawing.Point(28, 366);
            this.btn_print.Name = "btn_print";
            this.btn_print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_print.OnHovercolor = System.Drawing.Color.Green;
            this.btn_print.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_print.selected = false;
            this.btn_print.Size = new System.Drawing.Size(341, 45);
            this.btn_print.TabIndex = 55;
            this.btn_print.Text = "  PRINT RECEIPT";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print.Textcolor = System.Drawing.Color.White;
            this.btn_print.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tb_change
            // 
            this.tb_change.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.tb_change.BorderColorIdle = System.Drawing.Color.DarkGreen;
            this.tb_change.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.tb_change.BorderThickness = 3;
            this.tb_change.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_change.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_change.isPassword = false;
            this.tb_change.Location = new System.Drawing.Point(130, 271);
            this.tb_change.Margin = new System.Windows.Forms.Padding(8);
            this.tb_change.Name = "tb_change";
            this.tb_change.Size = new System.Drawing.Size(239, 75);
            this.tb_change.TabIndex = 58;
            this.tb_change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_money
            // 
            this.tb_money.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.tb_money.BorderColorIdle = System.Drawing.Color.DarkGreen;
            this.tb_money.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.tb_money.BorderThickness = 3;
            this.tb_money.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_money.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_money.isPassword = false;
            this.tb_money.Location = new System.Drawing.Point(130, 112);
            this.tb_money.Margin = new System.Windows.Forms.Padding(8);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(239, 75);
            this.tb_money.TabIndex = 57;
            this.tb_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "CHANGE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "MONEY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "TOTAL:";
            // 
            // ENTER
            // 
            this.ENTER.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ENTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ENTER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ENTER.BorderRadius = 0;
            this.ENTER.ButtonText = "ENTER";
            this.ENTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ENTER.DisabledColor = System.Drawing.Color.Gray;
            this.ENTER.ForeColor = System.Drawing.Color.Lime;
            this.ENTER.Iconcolor = System.Drawing.Color.Transparent;
            this.ENTER.Iconimage = ((System.Drawing.Image)(resources.GetObject("ENTER.Iconimage")));
            this.ENTER.Iconimage_right = null;
            this.ENTER.Iconimage_right_Selected = null;
            this.ENTER.Iconimage_Selected = null;
            this.ENTER.IconMarginLeft = 80;
            this.ENTER.IconMarginRight = 0;
            this.ENTER.IconRightVisible = true;
            this.ENTER.IconRightZoom = 0D;
            this.ENTER.IconVisible = true;
            this.ENTER.IconZoom = 60D;
            this.ENTER.IsTab = false;
            this.ENTER.Location = new System.Drawing.Point(130, 198);
            this.ENTER.Name = "ENTER";
            this.ENTER.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ENTER.OnHovercolor = System.Drawing.Color.Green;
            this.ENTER.OnHoverTextColor = System.Drawing.Color.White;
            this.ENTER.selected = false;
            this.ENTER.Size = new System.Drawing.Size(239, 45);
            this.ENTER.TabIndex = 62;
            this.ENTER.Text = "ENTER";
            this.ENTER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ENTER.Textcolor = System.Drawing.Color.White;
            this.ENTER.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(156, 15);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(223, 44);
            this.bunifuMetroTextbox1.TabIndex = 63;
            this.bunifuMetroTextbox1.Text = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // POSqty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(416, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POSqty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSqty";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuFlatButton ENTER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_money;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_change;
        private Bunifu.Framework.UI.BunifuFlatButton btn_print;
        private Bunifu.Framework.UI.BunifuFlatButton btn_report;
        private Bunifu.Framework.UI.BunifuFlatButton CLOSE;
    }
}