namespace WindowsFormsApplication1
{
    partial class returnMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnMedicine));
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DP_dateReturn = new System.Windows.Forms.DateTimePicker();
            this.cinvoice = new MetroFramework.Controls.MetroComboBox();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.LVreturn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_return = new Bunifu.Framework.UI.BunifuTileButton();
            this.label30 = new System.Windows.Forms.Label();
            this.itemname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_editable = new System.Windows.Forms.NumericUpDown();
            this.diskarte = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_editable)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(340, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 130;
            this.label4.Text = "Date Returned:";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.BackColor = System.Drawing.Color.White;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_item.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_item.Location = new System.Drawing.Point(9, 17);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(88, 24);
            this.lbl_item.TabIndex = 124;
            this.lbl_item.Text = "Invoice#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 127;
            this.label1.Text = "available qty:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.DP_dateReturn);
            this.panel2.Controls.Add(this.cinvoice);
            this.panel2.Controls.Add(this.lbl_item);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 59);
            this.panel2.TabIndex = 144;
            // 
            // DP_dateReturn
            // 
            this.DP_dateReturn.CustomFormat = "yyyy-MM-dd";
            this.DP_dateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DP_dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DP_dateReturn.Location = new System.Drawing.Point(496, 17);
            this.DP_dateReturn.Name = "DP_dateReturn";
            this.DP_dateReturn.Size = new System.Drawing.Size(186, 26);
            this.DP_dateReturn.TabIndex = 150;
            // 
            // cinvoice
            // 
            this.cinvoice.FormattingEnabled = true;
            this.cinvoice.ItemHeight = 23;
            this.cinvoice.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cinvoice.Location = new System.Drawing.Point(103, 14);
            this.cinvoice.Name = "cinvoice";
            this.cinvoice.Size = new System.Drawing.Size(229, 29);
            this.cinvoice.TabIndex = 146;
            this.cinvoice.UseSelectable = true;
            this.cinvoice.SelectedIndexChanged += new System.EventHandler(this.cinvoice_SelectedIndexChanged);
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(298, 526);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(127, 38);
            this.qty.TabIndex = 145;
            // 
            // LVreturn
            // 
            this.LVreturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVreturn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LVreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVreturn.FullRowSelect = true;
            this.LVreturn.GridLines = true;
            this.LVreturn.HoverSelection = true;
            this.LVreturn.Location = new System.Drawing.Point(25, 72);
            this.LVreturn.Name = "LVreturn";
            this.LVreturn.Size = new System.Drawing.Size(563, 416);
            this.LVreturn.TabIndex = 144;
            this.LVreturn.UseCompatibleStateImageBehavior = false;
            this.LVreturn.View = System.Windows.Forms.View.Details;
            this.LVreturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVreturn_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date purchased";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cashier";
            this.columnHeader6.Width = 121;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Green;
            this.btn_return.color = System.Drawing.Color.Green;
            this.btn_return.colorActive = System.Drawing.Color.DarkGreen;
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Image = ((System.Drawing.Image)(resources.GetObject("btn_return.Image")));
            this.btn_return.ImagePosition = 6;
            this.btn_return.ImageZoom = 15;
            this.btn_return.LabelPosition = 30;
            this.btn_return.LabelText = "Return";
            this.btn_return.Location = new System.Drawing.Point(584, 510);
            this.btn_return.Margin = new System.Windows.Forms.Padding(6);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(111, 55);
            this.btn_return.TabIndex = 144;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(8, 494);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(148, 25);
            this.label30.TabIndex = 146;
            this.label30.Text = "Selected Item:";
            // 
            // itemname
            // 
            this.itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Location = new System.Drawing.Point(9, 526);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(283, 38);
            this.itemname.TabIndex = 149;
            this.itemname.Text = "ITEM NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(451, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 127;
            this.label2.Text = "no. of qty:";
            // 
            // TB_editable
            // 
            this.TB_editable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_editable.Location = new System.Drawing.Point(455, 527);
            this.TB_editable.Name = "TB_editable";
            this.TB_editable.Size = new System.Drawing.Size(120, 38);
            this.TB_editable.TabIndex = 145;
            this.TB_editable.Enter += new System.EventHandler(this.TB_editable_Enter);
            this.TB_editable.Leave += new System.EventHandler(this.TB_editable_Leave);
            // 
            // diskarte
            // 
            this.diskarte.CustomFormat = "yyyy-MM-dd";
            this.diskarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskarte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.diskarte.Location = new System.Drawing.Point(380, 97);
            this.diskarte.Name = "diskarte";
            this.diskarte.Size = new System.Drawing.Size(110, 26);
            this.diskarte.TabIndex = 151;
            // 
            // returnMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(706, 576);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TB_editable);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVreturn);
            this.Controls.Add(this.diskarte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "returnMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "returnMedicine";
            this.Load += new System.EventHandler(this.returnMedicine_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_editable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView LVreturn;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private Bunifu.Framework.UI.BunifuTileButton btn_return;
        private System.Windows.Forms.NumericUpDown qty;
        private MetroFramework.Controls.MetroComboBox cinvoice;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.DateTimePicker DP_dateReturn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TB_editable;
        private System.Windows.Forms.DateTimePicker diskarte;
    }
}