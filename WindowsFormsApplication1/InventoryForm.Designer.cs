namespace WindowsFormsApplication1
{
    partial class InventoryForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Red, System.Drawing.Color.Empty, null);
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.btn_slidePanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnupdatetbris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label91 = new System.Windows.Forms.Label();
            this.btnrequiredqty = new System.Windows.Forms.NumericUpDown();
            this.label90 = new System.Windows.Forms.Label();
            this.selecteditemtb = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.currentqty = new System.Windows.Forms.NumericUpDown();
            this.label88 = new System.Windows.Forms.Label();
            this.btnx = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.label86 = new System.Windows.Forms.Label();
            this.btncloseme = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.label87 = new System.Windows.Forms.Label();
            this.tbselecteditem = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.qtysearch = new System.Windows.Forms.NumericUpDown();
            this.btnaddsearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnrefreshresult = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel40 = new System.Windows.Forms.Panel();
            this.cbcategorysearch = new System.Windows.Forms.ComboBox();
            this.tbsearchitem = new System.Windows.Forms.TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.LVSearch = new System.Windows.Forms.ListView();
            this.columnHeader75 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader77 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader78 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader88 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader69 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hideme = new System.Windows.Forms.LinkLabel();
            this.timein = new System.Windows.Forms.Label();
            this.time_in = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.lblPM = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LVEXP = new System.Windows.Forms.ListView();
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader76 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader96 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_prnitExpDamaged = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblBadge = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.psearch = new System.Windows.Forms.Panel();
            this.pdate = new System.Windows.Forms.Panel();
            this.pset = new System.Windows.Forms.Panel();
            this.btnaddproduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncatSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slider = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slider1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_po = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_outofstock = new Bunifu.Framework.UI.BunifuTileButton();
            this.rreturn = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnrequested_items = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_unused = new Bunifu.Framework.UI.BunifuTileButton();
            this.rinventory = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_recap = new Bunifu.Framework.UI.BunifuTileButton();
            this.rexpired = new Bunifu.Framework.UI.BunifuTileButton();
            this.paneltitleris = new System.Windows.Forms.Panel();
            this.label92 = new System.Windows.Forms.Label();
            this.psearch_add = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.add_panel = new System.Windows.Forms.Panel();
            this.preports = new System.Windows.Forms.Panel();
            this.psettings = new System.Windows.Forms.Panel();
            this.panelCP = new System.Windows.Forms.Panel();
            this.productset = new System.Windows.Forms.Panel();
            this.p_category = new System.Windows.Forms.Panel();
            this.paddproduct = new System.Windows.Forms.Panel();
            this.additem_panel = new System.Windows.Forms.Panel();
            this.label103 = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.NumericUpDown();
            this.label57 = new System.Windows.Forms.Label();
            this.btnsaveproduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_suppliername = new System.Windows.Forms.ComboBox();
            this.addproductcategory = new System.Windows.Forms.ComboBox();
            this.cbaddunit = new System.Windows.Forms.ComboBox();
            this.cbaddunitmeasure = new System.Windows.Forms.ComboBox();
            this.cbcategoryunit = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.ProductName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label80 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.catpanel = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.btnupdate4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsave4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbcat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.supppanel = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.lblsupname = new System.Windows.Forms.Label();
            this.supnametxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cb_set_supplier = new System.Windows.Forms.ComboBox();
            this.btn_update2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_sve2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.unitpanel = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cbunitSelector = new System.Windows.Forms.ComboBox();
            this.panel31 = new System.Windows.Forms.Panel();
            this.label38 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.cb_set_unit = new System.Windows.Forms.ComboBox();
            this.btn_update3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_sve3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_setunit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.emppanel = new System.Windows.Forms.Panel();
            this.cb_categorySignature = new System.Windows.Forms.ComboBox();
            this.panel45 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbfullname = new System.Windows.Forms.ComboBox();
            this.btnupdatefn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsavefn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbfullname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.deppanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbdepartment = new System.Windows.Forms.ComboBox();
            this.btnupdate5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsave5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbdepartment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btndep = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnemp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnunit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btn_update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.isearch = new System.Windows.Forms.PictureBox();
            this.LVitem = new System.Windows.Forms.ListView();
            this.columnHeader84 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader85 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader86 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader87 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader97 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelitemedit = new System.Windows.Forms.Panel();
            this.label58 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbitemcat = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.editUnitPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label104 = new System.Windows.Forms.Label();
            this.tbitemid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label67 = new System.Windows.Forms.Label();
            this.panelpassword = new System.Windows.Forms.Panel();
            this.cshow = new System.Windows.Forms.CheckBox();
            this.Blog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.savePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tcpw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tnpw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tun = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.shownew = new System.Windows.Forms.CheckBox();
            this.getid = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cgender = new MetroFramework.Controls.MetroComboBox();
            this.ctitle = new MetroFramework.Controls.MetroComboBox();
            this.tempid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tfn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tusername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tln = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tpassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tmn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.saveUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.p_rsales = new System.Windows.Forms.Panel();
            this.p_returned_med = new System.Windows.Forms.Panel();
            this.p_invmed = new System.Windows.Forms.Panel();
            this.p_unusedstocks = new System.Windows.Forms.Panel();
            this.p_expired = new System.Windows.Forms.Panel();
            this.panel_recap = new System.Windows.Forms.Panel();
            this.panel_outstock = new System.Windows.Forms.Panel();
            this.panel_pending_item = new System.Windows.Forms.Panel();
            this.label102 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_expiredLogs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExpired = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_expBatch = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.cb_dateExp = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.btnfetchexp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.p_HistoryLogs = new System.Windows.Forms.Panel();
            this.tbGrandTotal = new System.Windows.Forms.TextBox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label59 = new System.Windows.Forms.Label();
            this.batchbtn = new System.Windows.Forms.ComboBox();
            this.btn_Closeme = new Bunifu.Framework.UI.BunifuImageButton();
            this.LVLogs = new System.Windows.Forms.ListView();
            this.columnHeader62 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader63 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader64 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader65 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader66 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader67 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader68 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MedLOGS = new System.Windows.Forms.Label();
            this.p_damageMed = new System.Windows.Forms.Panel();
            this.btn_expClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSetdamaged = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_expInputno = new System.Windows.Forms.NumericUpDown();
            this.tb_expQty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_itemnamedamage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_generatedLogs = new System.Windows.Forms.TableLayoutPanel();
            this.GLLV = new System.Windows.Forms.ListView();
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.GLfromdate = new MetroFramework.Controls.MetroDateTime();
            this.btn_fetchrecordGL = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_batchGL = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.GLtodate = new MetroFramework.Controls.MetroDateTime();
            this.PMtable = new System.Windows.Forms.TableLayoutPanel();
            this.PMLV = new System.Windows.Forms.ListView();
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader90 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_PMprint = new Bunifu.Framework.UI.BunifuTileButton();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.tbgetyear = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateforIM = new MetroFramework.Controls.MetroDateTime();
            this.label22 = new System.Windows.Forms.Label();
            this.PMfetchbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_batchno = new System.Windows.Forms.ComboBox();
            this.RTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.rfrom = new MetroFramework.Controls.MetroDateTime();
            this.rto = new MetroFramework.Controls.MetroDateTime();
            this.btn_rfetch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label53 = new System.Windows.Forms.Label();
            this.rlistview = new System.Windows.Forms.ListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_rprint = new Bunifu.Framework.UI.BunifuTileButton();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.from = new MetroFramework.Controls.MetroDateTime();
            this.to = new MetroFramework.Controls.MetroDateTime();
            this.btnfetch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.LVsales = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.total_monthly = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Charge = new Bunifu.Framework.UI.BunifuTileButton();
            this.sprint = new Bunifu.Framework.UI.BunifuTileButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.fromdate = new MetroFramework.Controls.MetroDateTime();
            this.todate = new MetroFramework.Controls.MetroDateTime();
            this.cbdepreport = new System.Windows.Forms.ComboBox();
            this.fetch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LVreport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader95 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel47 = new System.Windows.Forms.Panel();
            this.label101 = new System.Windows.Forms.Label();
            this.cblogreceived = new System.Windows.Forms.ComboBox();
            this.label100 = new System.Windows.Forms.Label();
            this.cblogissued = new System.Windows.Forms.ComboBox();
            this.panel50 = new System.Windows.Forms.Panel();
            this.btnprint = new Bunifu.Framework.UI.BunifuTileButton();
            this.label99 = new System.Windows.Forms.Label();
            this.cblogreq = new System.Windows.Forms.ComboBox();
            this.panelRIS = new System.Windows.Forms.Panel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.LVRIS = new System.Windows.Forms.ListView();
            this.columnHeader71 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader72 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader73 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader74 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader79 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader89 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel41 = new System.Windows.Forms.Panel();
            this.btnPrintRIS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveRIS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel37 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.btndeleteris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneditris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel31 = new System.Windows.Forms.TableLayoutPanel();
            this.tbRisID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tableLayoutPanel32 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel38 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.cbissued = new System.Windows.Forms.ComboBox();
            this.label84 = new System.Windows.Forms.Label();
            this.cbreceived = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.cbdept = new System.Windows.Forms.ComboBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.cbrequest = new System.Windows.Forms.ComboBox();
            this.label77 = new System.Windows.Forms.Label();
            this.dtrisdate = new System.Windows.Forms.DateTimePicker();
            this.panel42 = new System.Windows.Forms.Panel();
            this.RisLogs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnNotifExpired = new Bunifu.Framework.UI.BunifuImageButton();
            this.tInventory = new System.Windows.Forms.TableLayoutPanel();
            this.LVPO = new System.Windows.Forms.ListView();
            this.columnHeader55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader57 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader58 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader59 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader60 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader61 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader70 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader80 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader81 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader82 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader83 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.logsToday = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnpoprint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label98 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.cbapprovedpo = new System.Windows.Forms.ComboBox();
            this.cbreqbypo = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label76 = new System.Windows.Forms.Label();
            this.dtpodate = new System.Windows.Forms.DateTimePicker();
            this.btnaddexistingpo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnpoupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnpodelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnposave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbsearchpo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LVnotification = new System.Windows.Forms.ListView();
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.lblsecond = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.phome = new System.Windows.Forms.Panel();
            this.btnPOS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.b3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnhome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ppoedit = new System.Windows.Forms.Panel();
            this.btnclosepoedit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel30 = new System.Windows.Forms.Panel();
            this.hideMeEditPanel = new System.Windows.Forms.Panel();
            this.cbitemcatup = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.tbunitup = new System.Windows.Forms.ComboBox();
            this.tbumeasureupdate = new System.Windows.Forms.ComboBox();
            this.cbucatup = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.tbitemnameupdate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label74 = new System.Windows.Forms.Label();
            this.tbitemidupate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label40 = new System.Windows.Forms.Label();
            this.tbpoidupdate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.nmqtyupdate = new System.Windows.Forms.NumericUpDown();
            this.dtexpired = new System.Windows.Forms.DateTimePicker();
            this.dtmob4expire = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.tbreorderup = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label68 = new System.Windows.Forms.Label();
            this.tbamountup = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.tbupriceupdate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label71 = new System.Windows.Forms.Label();
            this.cbsupup = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.panel34 = new System.Windows.Forms.Panel();
            this.btnupdatepo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label73 = new System.Windows.Forms.Label();
            this.psearchpo = new System.Windows.Forms.Panel();
            this.LVPOSEARCH = new System.Windows.Forms.ListView();
            this.columnHeader91 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader92 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader93 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader94 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel25 = new System.Windows.Forms.Panel();
            this.hideDate = new System.Windows.Forms.Panel();
            this.btn_ADD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.getItemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_poid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbqty = new System.Windows.Forms.NumericUpDown();
            this.dt_expired_date = new System.Windows.Forms.DateTimePicker();
            this.dt_before_expire = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_poreorderedlvl = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbamount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label78 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.tbunitprice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label47 = new System.Windows.Forms.Label();
            this.tbsupplier = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.panel36 = new System.Windows.Forms.Panel();
            this.cbcategoryitem = new System.Windows.Forms.ComboBox();
            this.tbsearchpoitem = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.psearchclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label41 = new System.Windows.Forms.Label();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.epeks = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_slidePanel)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrequiredqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnx)).BeginInit();
            this.panelsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncloseme)).BeginInit();
            this.panel39.SuspendLayout();
            this.panel48.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtysearch)).BeginInit();
            this.panel40.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.psearch.SuspendLayout();
            this.pdate.SuspendLayout();
            this.pset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider1)).BeginInit();
            this.paneltitleris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.add_panel.SuspendLayout();
            this.preports.SuspendLayout();
            this.psettings.SuspendLayout();
            this.panelCP.SuspendLayout();
            this.productset.SuspendLayout();
            this.p_category.SuspendLayout();
            this.paddproduct.SuspendLayout();
            this.additem_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitPrice)).BeginInit();
            this.panel23.SuspendLayout();
            this.catpanel.SuspendLayout();
            this.panel35.SuspendLayout();
            this.supppanel.SuspendLayout();
            this.panel29.SuspendLayout();
            this.unitpanel.SuspendLayout();
            this.panel31.SuspendLayout();
            this.emppanel.SuspendLayout();
            this.panel45.SuspendLayout();
            this.deppanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isearch)).BeginInit();
            this.panelitemedit.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panelpassword.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.p_rsales.SuspendLayout();
            this.p_returned_med.SuspendLayout();
            this.p_invmed.SuspendLayout();
            this.p_unusedstocks.SuspendLayout();
            this.p_expired.SuspendLayout();
            this.panel_recap.SuspendLayout();
            this.panel_outstock.SuspendLayout();
            this.panel_pending_item.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.p_HistoryLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Closeme)).BeginInit();
            this.p_damageMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_expClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_expInputno)).BeginInit();
            this.tb_generatedLogs.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.PMtable.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.panel7.SuspendLayout();
            this.RTable.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel47.SuspendLayout();
            this.panel50.SuspendLayout();
            this.panelRIS.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel37.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            this.tableLayoutPanel31.SuspendLayout();
            this.tableLayoutPanel32.SuspendLayout();
            this.panel38.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            this.panel42.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotifExpired)).BeginInit();
            this.tInventory.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel44.SuspendLayout();
            this.panel46.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.phome.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ppoedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclosepoedit)).BeginInit();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmqtyupdate)).BeginInit();
            this.panel34.SuspendLayout();
            this.psearchpo.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbqty)).BeginInit();
            this.panel36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psearchclose)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_slidePanel
            // 
            this.btn_slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_slidePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_slidePanel, BunifuAnimatorNS.DecorationType.None);
            this.btn_slidePanel.Image = ((System.Drawing.Image)(resources.GetObject("btn_slidePanel.Image")));
            this.btn_slidePanel.ImageActive = null;
            this.btn_slidePanel.Location = new System.Drawing.Point(3, 3);
            this.btn_slidePanel.Name = "btn_slidePanel";
            this.btn_slidePanel.Size = new System.Drawing.Size(56, 36);
            this.btn_slidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_slidePanel.TabIndex = 1;
            this.btn_slidePanel.TabStop = false;
            this.btn_slidePanel.Zoom = 10;
            this.btn_slidePanel.Click += new System.EventHandler(this.btn_slidePanel_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Green;
            this.panelEdit.Controls.Add(this.btnupdatetbris);
            this.panelEdit.Controls.Add(this.label91);
            this.panelEdit.Controls.Add(this.btnrequiredqty);
            this.panelEdit.Controls.Add(this.label90);
            this.panelEdit.Controls.Add(this.selecteditemtb);
            this.panelEdit.Controls.Add(this.label89);
            this.panelEdit.Controls.Add(this.currentqty);
            this.panelEdit.Controls.Add(this.label88);
            this.panelEdit.Controls.Add(this.btnx);
            this.panelEdit.Controls.Add(this.panel43);
            this.epeks.SetDecoration(this.panelEdit, BunifuAnimatorNS.DecorationType.None);
            this.panelEdit.Location = new System.Drawing.Point(399, 164);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(358, 314);
            this.panelEdit.TabIndex = 123;
            // 
            // btnupdatetbris
            // 
            this.btnupdatetbris.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnupdatetbris.BackColor = System.Drawing.Color.DarkGreen;
            this.btnupdatetbris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdatetbris.BorderRadius = 5;
            this.btnupdatetbris.ButtonText = "                                  UPDATE";
            this.btnupdatetbris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnupdatetbris, BunifuAnimatorNS.DecorationType.None);
            this.btnupdatetbris.DisabledColor = System.Drawing.Color.Gray;
            this.btnupdatetbris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatetbris.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdatetbris.Iconimage = null;
            this.btnupdatetbris.Iconimage_right = null;
            this.btnupdatetbris.Iconimage_right_Selected = null;
            this.btnupdatetbris.Iconimage_Selected = null;
            this.btnupdatetbris.IconMarginLeft = 20;
            this.btnupdatetbris.IconMarginRight = 0;
            this.btnupdatetbris.IconRightVisible = true;
            this.btnupdatetbris.IconRightZoom = 0D;
            this.btnupdatetbris.IconVisible = true;
            this.btnupdatetbris.IconZoom = 60D;
            this.btnupdatetbris.IsTab = false;
            this.btnupdatetbris.Location = new System.Drawing.Point(17, 244);
            this.btnupdatetbris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdatetbris.Name = "btnupdatetbris";
            this.btnupdatetbris.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnupdatetbris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdatetbris.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdatetbris.selected = false;
            this.btnupdatetbris.Size = new System.Drawing.Size(325, 50);
            this.btnupdatetbris.TabIndex = 129;
            this.btnupdatetbris.Text = "                                  UPDATE";
            this.btnupdatetbris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdatetbris.Textcolor = System.Drawing.Color.White;
            this.btnupdatetbris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatetbris.Click += new System.EventHandler(this.btnupdatetbris_Click);
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.epeks.SetDecoration(this.label91, BunifuAnimatorNS.DecorationType.None);
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.ForeColor = System.Drawing.Color.White;
            this.label91.Location = new System.Drawing.Point(218, 125);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(103, 20);
            this.label91.TabIndex = 128;
            this.label91.Text = "Required qty:";
            // 
            // btnrequiredqty
            // 
            this.epeks.SetDecoration(this.btnrequiredqty, BunifuAnimatorNS.DecorationType.None);
            this.btnrequiredqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrequiredqty.Location = new System.Drawing.Point(199, 149);
            this.btnrequiredqty.Name = "btnrequiredqty";
            this.btnrequiredqty.Size = new System.Drawing.Size(142, 53);
            this.btnrequiredqty.TabIndex = 127;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.epeks.SetDecoration(this.label90, BunifuAnimatorNS.DecorationType.None);
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = System.Drawing.Color.White;
            this.label90.Location = new System.Drawing.Point(11, 44);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(116, 17);
            this.label90.TabIndex = 126;
            this.label90.Text = "SELECTED ITEM";
            // 
            // selecteditemtb
            // 
            this.selecteditemtb.AllowDrop = true;
            this.selecteditemtb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selecteditemtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.selecteditemtb.BackColor = System.Drawing.Color.White;
            this.selecteditemtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epeks.SetDecoration(this.selecteditemtb, BunifuAnimatorNS.DecorationType.None);
            this.selecteditemtb.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecteditemtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.selecteditemtb.Location = new System.Drawing.Point(11, 69);
            this.selecteditemtb.Name = "selecteditemtb";
            this.selecteditemtb.Size = new System.Drawing.Size(338, 39);
            this.selecteditemtb.TabIndex = 125;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.epeks.SetDecoration(this.label89, BunifuAnimatorNS.DecorationType.None);
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.White;
            this.label89.Location = new System.Drawing.Point(29, 125);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(91, 20);
            this.label89.TabIndex = 124;
            this.label89.Text = "Current qty:";
            // 
            // currentqty
            // 
            this.epeks.SetDecoration(this.currentqty, BunifuAnimatorNS.DecorationType.None);
            this.currentqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentqty.Location = new System.Drawing.Point(16, 150);
            this.currentqty.Name = "currentqty";
            this.currentqty.Size = new System.Drawing.Size(136, 53);
            this.currentqty.TabIndex = 123;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.epeks.SetDecoration(this.label88, BunifuAnimatorNS.DecorationType.None);
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = System.Drawing.Color.White;
            this.label88.Location = new System.Drawing.Point(8, 7);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(97, 17);
            this.label88.TabIndex = 122;
            this.label88.Text = "SEARCH BOX";
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.Transparent;
            this.epeks.SetDecoration(this.btnx, BunifuAnimatorNS.DecorationType.None);
            this.btnx.Image = ((System.Drawing.Image)(resources.GetObject("btnx.Image")));
            this.btnx.ImageActive = null;
            this.btnx.Location = new System.Drawing.Point(328, 1);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(28, 24);
            this.btnx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnx.TabIndex = 118;
            this.btnx.TabStop = false;
            this.btnx.Zoom = 10;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.epeks.SetDecoration(this.panel43, BunifuAnimatorNS.DecorationType.None);
            this.panel43.Location = new System.Drawing.Point(11, 236);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(338, 66);
            this.panel43.TabIndex = 130;
            // 
            // panelsearch
            // 
            this.panelsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelsearch.Controls.Add(this.label86);
            this.panelsearch.Controls.Add(this.btncloseme);
            this.panelsearch.Controls.Add(this.panel39);
            this.panelsearch.Controls.Add(this.panel40);
            this.panelsearch.Controls.Add(this.LVSearch);
            this.epeks.SetDecoration(this.panelsearch, BunifuAnimatorNS.DecorationType.None);
            this.panelsearch.Location = new System.Drawing.Point(479, 287);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(697, 373);
            this.panelsearch.TabIndex = 122;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.epeks.SetDecoration(this.label86, BunifuAnimatorNS.DecorationType.None);
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.ForeColor = System.Drawing.Color.White;
            this.label86.Location = new System.Drawing.Point(3, 7);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(97, 17);
            this.label86.TabIndex = 121;
            this.label86.Text = "SEARCH BOX";
            // 
            // btncloseme
            // 
            this.btncloseme.BackColor = System.Drawing.Color.Transparent;
            this.epeks.SetDecoration(this.btncloseme, BunifuAnimatorNS.DecorationType.None);
            this.btncloseme.Image = ((System.Drawing.Image)(resources.GetObject("btncloseme.Image")));
            this.btncloseme.ImageActive = null;
            this.btncloseme.Location = new System.Drawing.Point(992, 3);
            this.btncloseme.Name = "btncloseme";
            this.btncloseme.Size = new System.Drawing.Size(35, 25);
            this.btncloseme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncloseme.TabIndex = 117;
            this.btncloseme.TabStop = false;
            this.btncloseme.Zoom = 10;
            this.btncloseme.Click += new System.EventHandler(this.btncloseme_Click);
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel39.Controls.Add(this.panel48);
            this.panel39.Controls.Add(this.label85);
            this.panel39.Controls.Add(this.qtysearch);
            this.panel39.Controls.Add(this.btnaddsearch);
            this.panel39.Controls.Add(this.btnrefreshresult);
            this.epeks.SetDecoration(this.panel39, BunifuAnimatorNS.DecorationType.None);
            this.panel39.Location = new System.Drawing.Point(3, 489);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(1024, 110);
            this.panel39.TabIndex = 120;
            // 
            // panel48
            // 
            this.panel48.BackColor = System.Drawing.Color.Green;
            this.panel48.Controls.Add(this.label87);
            this.panel48.Controls.Add(this.tbselecteditem);
            this.epeks.SetDecoration(this.panel48, BunifuAnimatorNS.DecorationType.None);
            this.panel48.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel48.Location = new System.Drawing.Point(0, 0);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(1024, 29);
            this.panel48.TabIndex = 125;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.epeks.SetDecoration(this.label87, BunifuAnimatorNS.DecorationType.None);
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label87.Location = new System.Drawing.Point(11, 4);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(182, 25);
            this.label87.TabIndex = 121;
            this.label87.Text = "SELECTED  ITEM:";
            // 
            // tbselecteditem
            // 
            this.tbselecteditem.AutoSize = true;
            this.epeks.SetDecoration(this.tbselecteditem, BunifuAnimatorNS.DecorationType.None);
            this.tbselecteditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbselecteditem.ForeColor = System.Drawing.Color.GreenYellow;
            this.tbselecteditem.Location = new System.Drawing.Point(192, 4);
            this.tbselecteditem.Name = "tbselecteditem";
            this.tbselecteditem.Size = new System.Drawing.Size(60, 25);
            this.tbselecteditem.TabIndex = 124;
            this.tbselecteditem.Text = "ITEM";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.epeks.SetDecoration(this.label85, BunifuAnimatorNS.DecorationType.None);
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.ForeColor = System.Drawing.Color.White;
            this.label85.Location = new System.Drawing.Point(15, 49);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(112, 46);
            this.label85.TabIndex = 118;
            this.label85.Text = "QTY:";
            // 
            // qtysearch
            // 
            this.epeks.SetDecoration(this.qtysearch, BunifuAnimatorNS.DecorationType.None);
            this.qtysearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtysearch.Location = new System.Drawing.Point(133, 44);
            this.qtysearch.Name = "qtysearch";
            this.qtysearch.Size = new System.Drawing.Size(146, 53);
            this.qtysearch.TabIndex = 117;
            // 
            // btnaddsearch
            // 
            this.btnaddsearch.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnaddsearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnaddsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddsearch.BorderRadius = 5;
            this.btnaddsearch.ButtonText = "ADD";
            this.btnaddsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnaddsearch, BunifuAnimatorNS.DecorationType.None);
            this.btnaddsearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnaddsearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnaddsearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnaddsearch.Iconimage")));
            this.btnaddsearch.Iconimage_right = null;
            this.btnaddsearch.Iconimage_right_Selected = null;
            this.btnaddsearch.Iconimage_Selected = null;
            this.btnaddsearch.IconMarginLeft = 0;
            this.btnaddsearch.IconMarginRight = 0;
            this.btnaddsearch.IconRightVisible = true;
            this.btnaddsearch.IconRightZoom = 0D;
            this.btnaddsearch.IconVisible = true;
            this.btnaddsearch.IconZoom = 60D;
            this.btnaddsearch.IsTab = false;
            this.btnaddsearch.Location = new System.Drawing.Point(285, 43);
            this.btnaddsearch.Name = "btnaddsearch";
            this.btnaddsearch.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnaddsearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnaddsearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnaddsearch.selected = false;
            this.btnaddsearch.Size = new System.Drawing.Size(120, 56);
            this.btnaddsearch.TabIndex = 119;
            this.btnaddsearch.Text = "ADD";
            this.btnaddsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddsearch.Textcolor = System.Drawing.Color.White;
            this.btnaddsearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddsearch.Click += new System.EventHandler(this.btnaddsearch_Click);
            // 
            // btnrefreshresult
            // 
            this.btnrefreshresult.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnrefreshresult.BackColor = System.Drawing.Color.DarkGreen;
            this.btnrefreshresult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefreshresult.BorderRadius = 5;
            this.btnrefreshresult.ButtonText = "REFRESH (F5)";
            this.btnrefreshresult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnrefreshresult, BunifuAnimatorNS.DecorationType.None);
            this.btnrefreshresult.DisabledColor = System.Drawing.Color.Gray;
            this.btnrefreshresult.Iconcolor = System.Drawing.Color.Transparent;
            this.btnrefreshresult.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnrefreshresult.Iconimage")));
            this.btnrefreshresult.Iconimage_right = null;
            this.btnrefreshresult.Iconimage_right_Selected = null;
            this.btnrefreshresult.Iconimage_Selected = null;
            this.btnrefreshresult.IconMarginLeft = 0;
            this.btnrefreshresult.IconMarginRight = 0;
            this.btnrefreshresult.IconRightVisible = true;
            this.btnrefreshresult.IconRightZoom = 0D;
            this.btnrefreshresult.IconVisible = true;
            this.btnrefreshresult.IconZoom = 60D;
            this.btnrefreshresult.IsTab = false;
            this.btnrefreshresult.Location = new System.Drawing.Point(829, 39);
            this.btnrefreshresult.Name = "btnrefreshresult";
            this.btnrefreshresult.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnrefreshresult.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnrefreshresult.OnHoverTextColor = System.Drawing.Color.White;
            this.btnrefreshresult.selected = false;
            this.btnrefreshresult.Size = new System.Drawing.Size(181, 56);
            this.btnrefreshresult.TabIndex = 126;
            this.btnrefreshresult.Text = "REFRESH (F5)";
            this.btnrefreshresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefreshresult.Textcolor = System.Drawing.Color.White;
            this.btnrefreshresult.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefreshresult.Click += new System.EventHandler(this.btnrefreshresult_Click);
            // 
            // panel40
            // 
            this.panel40.BackColor = System.Drawing.Color.Green;
            this.panel40.Controls.Add(this.cbcategorysearch);
            this.panel40.Controls.Add(this.tbsearchitem);
            this.panel40.Controls.Add(this.pictureBox11);
            this.epeks.SetDecoration(this.panel40, BunifuAnimatorNS.DecorationType.None);
            this.panel40.Location = new System.Drawing.Point(3, 31);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(1024, 54);
            this.panel40.TabIndex = 115;
            // 
            // cbcategorysearch
            // 
            this.epeks.SetDecoration(this.cbcategorysearch, BunifuAnimatorNS.DecorationType.None);
            this.cbcategorysearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategorysearch.FormattingEnabled = true;
            this.cbcategorysearch.Location = new System.Drawing.Point(14, 9);
            this.cbcategorysearch.Name = "cbcategorysearch";
            this.cbcategorysearch.Size = new System.Drawing.Size(270, 32);
            this.cbcategorysearch.TabIndex = 113;
            this.cbcategorysearch.Text = "Select filter category";
            this.cbcategorysearch.SelectedIndexChanged += new System.EventHandler(this.cbcategorysearch_SelectedIndexChanged);
            this.cbcategorysearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbcategorysearch_MouseClick);
            // 
            // tbsearchitem
            // 
            this.tbsearchitem.AllowDrop = true;
            this.tbsearchitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbsearchitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbsearchitem.BackColor = System.Drawing.Color.White;
            this.tbsearchitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epeks.SetDecoration(this.tbsearchitem, BunifuAnimatorNS.DecorationType.None);
            this.tbsearchitem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearchitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbsearchitem.Location = new System.Drawing.Point(684, 6);
            this.tbsearchitem.Name = "tbsearchitem";
            this.tbsearchitem.Size = new System.Drawing.Size(338, 39);
            this.tbsearchitem.TabIndex = 109;
            this.tbsearchitem.TextChanged += new System.EventHandler(this.tbsearchitem_TextChanged);
            // 
            // pictureBox11
            // 
            this.epeks.SetDecoration(this.pictureBox11, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(643, 9);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(41, 34);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox11.TabIndex = 110;
            this.pictureBox11.TabStop = false;
            // 
            // LVSearch
            // 
            this.LVSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader75,
            this.columnHeader77,
            this.columnHeader78,
            this.columnHeader88,
            this.columnHeader69,
            this.columnHeader39,
            this.columnHeader45});
            this.epeks.SetDecoration(this.LVSearch, BunifuAnimatorNS.DecorationType.None);
            this.LVSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVSearch.FullRowSelect = true;
            this.LVSearch.GridLines = true;
            this.LVSearch.HideSelection = false;
            this.LVSearch.Location = new System.Drawing.Point(3, 84);
            this.LVSearch.Name = "LVSearch";
            this.LVSearch.Size = new System.Drawing.Size(1024, 403);
            this.LVSearch.TabIndex = 116;
            this.LVSearch.UseCompatibleStateImageBehavior = false;
            this.LVSearch.View = System.Windows.Forms.View.Details;
            this.LVSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVSearch_MouseClick);
            // 
            // columnHeader75
            // 
            this.columnHeader75.Text = "P.O. NO.";
            this.columnHeader75.Width = 150;
            // 
            // columnHeader77
            // 
            this.columnHeader77.Text = "ITEM NO.";
            this.columnHeader77.Width = 150;
            // 
            // columnHeader78
            // 
            this.columnHeader78.Text = "CATEGORY";
            this.columnHeader78.Width = 150;
            // 
            // columnHeader88
            // 
            this.columnHeader88.Text = "ITEM NAME";
            this.columnHeader88.Width = 150;
            // 
            // columnHeader69
            // 
            this.columnHeader69.Text = "UNIT";
            this.columnHeader69.Width = 120;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "ENDING";
            this.columnHeader39.Width = 150;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "DATE PURCHASE";
            this.columnHeader45.Width = 180;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.lblPM);
            this.panel4.Controls.Add(this.btn_slidePanel);
            this.panel4.Controls.Add(this.panel10);
            this.epeks.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(0, 47);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(1236, 47);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanel2.Controls.Add(this.hideme, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.timein, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.time_in, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.logout, 0, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(951, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 37);
            this.tableLayoutPanel2.TabIndex = 71;
            // 
            // hideme
            // 
            this.hideme.AutoSize = true;
            this.epeks.SetDecoration(this.hideme, BunifuAnimatorNS.DecorationType.None);
            this.hideme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideme.LinkColor = System.Drawing.Color.White;
            this.hideme.Location = new System.Drawing.Point(84, 17);
            this.hideme.Name = "hideme";
            this.hideme.Size = new System.Drawing.Size(76, 20);
            this.hideme.TabIndex = 72;
            this.hideme.TabStop = true;
            this.hideme.Text = "Minimize";
            this.hideme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hideme_MouseClick);
            // 
            // timein
            // 
            this.timein.AutoSize = true;
            this.epeks.SetDecoration(this.timein, BunifuAnimatorNS.DecorationType.None);
            this.timein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timein.ForeColor = System.Drawing.Color.White;
            this.timein.Location = new System.Drawing.Point(84, 0);
            this.timein.Name = "timein";
            this.timein.Size = new System.Drawing.Size(54, 17);
            this.timein.TabIndex = 70;
            this.timein.Text = "00:00";
            // 
            // time_in
            // 
            this.time_in.AutoSize = true;
            this.epeks.SetDecoration(this.time_in, BunifuAnimatorNS.DecorationType.None);
            this.time_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_in.ForeColor = System.Drawing.Color.White;
            this.time_in.Location = new System.Drawing.Point(3, 0);
            this.time_in.Name = "time_in";
            this.time_in.Size = new System.Drawing.Size(56, 17);
            this.time_in.TabIndex = 69;
            this.time_in.Text = "TIME IN: ";
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.epeks.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.LinkColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(3, 17);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(65, 20);
            this.logout.TabIndex = 71;
            this.logout.TabStop = true;
            this.logout.Text = "Logout";
            this.logout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logout_MouseClick);
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.epeks.SetDecoration(this.lblPM, BunifuAnimatorNS.DecorationType.None);
            this.lblPM.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.lblPM.ForeColor = System.Drawing.Color.Lavender;
            this.lblPM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPM.Location = new System.Drawing.Point(64, 2);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(413, 44);
            this.lblPM.TabIndex = 0;
            this.lblPM.Text = "Product Maintenance";
            // 
            // panel10
            // 
            this.epeks.SetDecoration(this.panel10, BunifuAnimatorNS.DecorationType.None);
            this.panel10.Location = new System.Drawing.Point(572, 47);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(233, 100);
            this.panel10.TabIndex = 113;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Successfully Minimize!";
            this.notifyIcon1.BalloonTipTitle = "Inventory Form";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Maheseco Inventory Form";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // LVEXP
            // 
            this.LVEXP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader38,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48,
            this.columnHeader49,
            this.columnHeader54,
            this.columnHeader76,
            this.columnHeader96});
            this.epeks.SetDecoration(this.LVEXP, BunifuAnimatorNS.DecorationType.None);
            this.LVEXP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVEXP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVEXP.FullRowSelect = true;
            this.LVEXP.GridLines = true;
            this.LVEXP.HoverSelection = true;
            this.LVEXP.Location = new System.Drawing.Point(13, 74);
            this.LVEXP.Name = "LVEXP";
            this.LVEXP.Size = new System.Drawing.Size(1105, 444);
            this.LVEXP.TabIndex = 2;
            this.LVEXP.UseCompatibleStateImageBehavior = false;
            this.LVEXP.View = System.Windows.Forms.View.Details;
            this.LVEXP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVEXP_MouseClick);
            this.LVEXP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LVEXP_MouseDoubleClick);
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "ITEM NO";
            this.columnHeader38.Width = 100;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "PO I.D.";
            this.columnHeader46.Width = 150;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "PARTICULAR";
            this.columnHeader47.Width = 200;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "UNIT";
            this.columnHeader48.Width = 150;
            // 
            // columnHeader49
            // 
            this.columnHeader49.Text = "EXPIRED DATE";
            this.columnHeader49.Width = 150;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "PRICE";
            this.columnHeader54.Width = 150;
            // 
            // columnHeader76
            // 
            this.columnHeader76.Text = "QTY";
            this.columnHeader76.Width = 150;
            // 
            // columnHeader96
            // 
            this.columnHeader96.Text = "TOTAL PRICE";
            this.columnHeader96.Width = 150;
            // 
            // btn_prnitExpDamaged
            // 
            this.btn_prnitExpDamaged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_prnitExpDamaged.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_prnitExpDamaged.colorActive = System.Drawing.Color.Green;
            this.btn_prnitExpDamaged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_prnitExpDamaged, BunifuAnimatorNS.DecorationType.None);
            this.btn_prnitExpDamaged.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_prnitExpDamaged.ForeColor = System.Drawing.Color.White;
            this.btn_prnitExpDamaged.Image = ((System.Drawing.Image)(resources.GetObject("btn_prnitExpDamaged.Image")));
            this.btn_prnitExpDamaged.ImagePosition = 10;
            this.btn_prnitExpDamaged.ImageZoom = 50;
            this.btn_prnitExpDamaged.LabelPosition = 0;
            this.btn_prnitExpDamaged.LabelText = "";
            this.btn_prnitExpDamaged.Location = new System.Drawing.Point(1051, 5);
            this.btn_prnitExpDamaged.Margin = new System.Windows.Forms.Padding(6);
            this.btn_prnitExpDamaged.Name = "btn_prnitExpDamaged";
            this.btn_prnitExpDamaged.Size = new System.Drawing.Size(40, 36);
            this.btn_prnitExpDamaged.TabIndex = 153;
            this.btn_prnitExpDamaged.Click += new System.EventHandler(this.btn_prnitExpDamaged_Click);
            // 
            // lblBadge
            // 
            this.lblBadge.AutoSize = true;
            this.lblBadge.BackColor = System.Drawing.Color.Red;
            this.epeks.SetDecoration(this.lblBadge, BunifuAnimatorNS.DecorationType.None);
            this.lblBadge.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBadge.Location = new System.Drawing.Point(306, 2);
            this.lblBadge.Name = "lblBadge";
            this.lblBadge.Size = new System.Drawing.Size(89, 40);
            this.lblBadge.TabIndex = 111;
            this.lblBadge.Text = "1200";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.psearch);
            this.panel5.Controls.Add(this.add_panel);
            this.panel5.Controls.Add(this.phome);
            this.epeks.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1236, 680);
            this.panel5.TabIndex = 2;
            // 
            // psearch
            // 
            this.psearch.BackColor = System.Drawing.Color.Green;
            this.psearch.Controls.Add(this.pdate);
            this.psearch.Controls.Add(this.paneltitleris);
            this.psearch.Controls.Add(this.psearch_add);
            this.psearch.Controls.Add(this.bunifuImageButton2);
            this.epeks.SetDecoration(this.psearch, BunifuAnimatorNS.DecorationType.None);
            this.psearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.psearch.Location = new System.Drawing.Point(59, 0);
            this.psearch.Name = "psearch";
            this.psearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.psearch.Size = new System.Drawing.Size(1177, 64);
            this.psearch.TabIndex = 0;
            // 
            // pdate
            // 
            this.pdate.Controls.Add(this.pset);
            this.pdate.Controls.Add(this.slider1);
            this.pdate.Controls.Add(this.btn_po);
            this.pdate.Controls.Add(this.btn_outofstock);
            this.pdate.Controls.Add(this.rreturn);
            this.pdate.Controls.Add(this.btnrequested_items);
            this.pdate.Controls.Add(this.btn_unused);
            this.pdate.Controls.Add(this.rinventory);
            this.pdate.Controls.Add(this.btn_recap);
            this.pdate.Controls.Add(this.rexpired);
            this.epeks.SetDecoration(this.pdate, BunifuAnimatorNS.DecorationType.None);
            this.pdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdate.Location = new System.Drawing.Point(0, 0);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(1177, 64);
            this.pdate.TabIndex = 109;
            // 
            // pset
            // 
            this.pset.Controls.Add(this.btnaddproduct);
            this.pset.Controls.Add(this.btncatSettings);
            this.pset.Controls.Add(this.bunifuFlatButton2);
            this.pset.Controls.Add(this.slider);
            this.pset.Controls.Add(this.bunifuFlatButton4);
            this.pset.Controls.Add(this.bunifuFlatButton1);
            this.epeks.SetDecoration(this.pset, BunifuAnimatorNS.DecorationType.None);
            this.pset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pset.Location = new System.Drawing.Point(0, 0);
            this.pset.Name = "pset";
            this.pset.Size = new System.Drawing.Size(1177, 64);
            this.pset.TabIndex = 96;
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnaddproduct.BackColor = System.Drawing.Color.Green;
            this.btnaddproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddproduct.BorderRadius = 0;
            this.btnaddproduct.ButtonText = "   ADD ITEM";
            this.btnaddproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnaddproduct, BunifuAnimatorNS.DecorationType.None);
            this.btnaddproduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnaddproduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnaddproduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnaddproduct.Iconimage")));
            this.btnaddproduct.Iconimage_right = null;
            this.btnaddproduct.Iconimage_right_Selected = null;
            this.btnaddproduct.Iconimage_Selected = null;
            this.btnaddproduct.IconMarginLeft = 0;
            this.btnaddproduct.IconMarginRight = 0;
            this.btnaddproduct.IconRightVisible = true;
            this.btnaddproduct.IconRightZoom = 0D;
            this.btnaddproduct.IconVisible = true;
            this.btnaddproduct.IconZoom = 50D;
            this.btnaddproduct.IsTab = false;
            this.btnaddproduct.Location = new System.Drawing.Point(741, 10);
            this.btnaddproduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Normalcolor = System.Drawing.Color.Green;
            this.btnaddproduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnaddproduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnaddproduct.selected = false;
            this.btnaddproduct.Size = new System.Drawing.Size(133, 43);
            this.btnaddproduct.TabIndex = 136;
            this.btnaddproduct.Text = "   ADD ITEM";
            this.btnaddproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddproduct.Textcolor = System.Drawing.Color.White;
            this.btnaddproduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // btncatSettings
            // 
            this.btncatSettings.Activecolor = System.Drawing.Color.LimeGreen;
            this.btncatSettings.BackColor = System.Drawing.Color.Green;
            this.btncatSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncatSettings.BorderRadius = 0;
            this.btncatSettings.ButtonText = "   ADD/EDIT REQUIREMENTS";
            this.btncatSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btncatSettings, BunifuAnimatorNS.DecorationType.None);
            this.btncatSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btncatSettings.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btncatSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncatSettings.Iconimage")));
            this.btncatSettings.Iconimage_right = null;
            this.btncatSettings.Iconimage_right_Selected = null;
            this.btncatSettings.Iconimage_Selected = null;
            this.btncatSettings.IconMarginLeft = 0;
            this.btncatSettings.IconMarginRight = 0;
            this.btncatSettings.IconRightVisible = true;
            this.btncatSettings.IconRightZoom = 0D;
            this.btncatSettings.IconVisible = true;
            this.btncatSettings.IconZoom = 50D;
            this.btncatSettings.IsTab = false;
            this.btncatSettings.Location = new System.Drawing.Point(367, 10);
            this.btncatSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncatSettings.Name = "btncatSettings";
            this.btncatSettings.Normalcolor = System.Drawing.Color.Green;
            this.btncatSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncatSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btncatSettings.selected = false;
            this.btncatSettings.Size = new System.Drawing.Size(237, 43);
            this.btncatSettings.TabIndex = 135;
            this.btncatSettings.Text = "   ADD/EDIT REQUIREMENTS";
            this.btncatSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncatSettings.Textcolor = System.Drawing.Color.White;
            this.btncatSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatSettings.Click += new System.EventHandler(this.btncatSettings_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.LimeGreen;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Green;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   CHANGE PASSWORD";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(162, 9);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Green;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(199, 43);
            this.bunifuFlatButton2.TabIndex = 133;
            this.bunifuFlatButton2.Text = "   CHANGE PASSWORD";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.Honeydew;
            this.epeks.SetDecoration(this.slider, BunifuAnimatorNS.DecorationType.None);
            this.slider.ErrorImage = null;
            this.slider.Image = ((System.Drawing.Image)(resources.GetObject("slider.Image")));
            this.slider.ImageActive = null;
            this.slider.Location = new System.Drawing.Point(745, 54);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(135, 10);
            this.slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slider.TabIndex = 134;
            this.slider.TabStop = false;
            this.slider.Zoom = 10;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.LimeGreen;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Green;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "     EDIT ITEM";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 50D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(606, 10);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Green;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(135, 43);
            this.bunifuFlatButton4.TabIndex = 133;
            this.bunifuFlatButton4.Text = "     EDIT ITEM";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LimeGreen;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   ADD USER";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(21, 11);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(138, 43);
            this.bunifuFlatButton1.TabIndex = 133;
            this.bunifuFlatButton1.Text = "   ADD USER";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // slider1
            // 
            this.slider1.BackColor = System.Drawing.Color.Honeydew;
            this.epeks.SetDecoration(this.slider1, BunifuAnimatorNS.DecorationType.None);
            this.slider1.ErrorImage = null;
            this.slider1.Image = ((System.Drawing.Image)(resources.GetObject("slider1.Image")));
            this.slider1.ImageActive = null;
            this.slider1.Location = new System.Drawing.Point(5, 56);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(169, 10);
            this.slider1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slider1.TabIndex = 134;
            this.slider1.TabStop = false;
            this.slider1.Zoom = 10;
            // 
            // btn_po
            // 
            this.btn_po.BackColor = System.Drawing.Color.Green;
            this.btn_po.color = System.Drawing.Color.Green;
            this.btn_po.colorActive = System.Drawing.Color.DarkGreen;
            this.btn_po.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_po, BunifuAnimatorNS.DecorationType.None);
            this.btn_po.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_po.ForeColor = System.Drawing.Color.White;
            this.btn_po.Image = ((System.Drawing.Image)(resources.GetObject("btn_po.Image")));
            this.btn_po.ImagePosition = 6;
            this.btn_po.ImageZoom = 18;
            this.btn_po.LabelPosition = 30;
            this.btn_po.LabelText = "PENDING ITEM";
            this.btn_po.Location = new System.Drawing.Point(1105, -1);
            this.btn_po.Margin = new System.Windows.Forms.Padding(6);
            this.btn_po.Name = "btn_po";
            this.btn_po.Size = new System.Drawing.Size(154, 63);
            this.btn_po.TabIndex = 137;
            this.btn_po.Click += new System.EventHandler(this.btn_po_Click);
            // 
            // btn_outofstock
            // 
            this.btn_outofstock.BackColor = System.Drawing.Color.Green;
            this.btn_outofstock.color = System.Drawing.Color.Green;
            this.btn_outofstock.colorActive = System.Drawing.Color.DarkGreen;
            this.btn_outofstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_outofstock, BunifuAnimatorNS.DecorationType.None);
            this.btn_outofstock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_outofstock.ForeColor = System.Drawing.Color.White;
            this.btn_outofstock.Image = ((System.Drawing.Image)(resources.GetObject("btn_outofstock.Image")));
            this.btn_outofstock.ImagePosition = 6;
            this.btn_outofstock.ImageZoom = 18;
            this.btn_outofstock.LabelPosition = 30;
            this.btn_outofstock.LabelText = "OUT OF STOCK";
            this.btn_outofstock.Location = new System.Drawing.Point(954, 0);
            this.btn_outofstock.Margin = new System.Windows.Forms.Padding(6);
            this.btn_outofstock.Name = "btn_outofstock";
            this.btn_outofstock.Size = new System.Drawing.Size(154, 63);
            this.btn_outofstock.TabIndex = 137;
            this.btn_outofstock.Click += new System.EventHandler(this.btn_outofstock_Click);
            // 
            // rreturn
            // 
            this.rreturn.BackColor = System.Drawing.Color.Green;
            this.rreturn.color = System.Drawing.Color.Green;
            this.rreturn.colorActive = System.Drawing.Color.DarkGreen;
            this.rreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.rreturn, BunifuAnimatorNS.DecorationType.None);
            this.rreturn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rreturn.ForeColor = System.Drawing.Color.White;
            this.rreturn.Image = ((System.Drawing.Image)(resources.GetObject("rreturn.Image")));
            this.rreturn.ImagePosition = 6;
            this.rreturn.ImageZoom = 15;
            this.rreturn.LabelPosition = 30;
            this.rreturn.LabelText = "RETURNED MED";
            this.rreturn.Location = new System.Drawing.Point(795, 0);
            this.rreturn.Margin = new System.Windows.Forms.Padding(6);
            this.rreturn.Name = "rreturn";
            this.rreturn.Size = new System.Drawing.Size(154, 63);
            this.rreturn.TabIndex = 137;
            this.rreturn.Click += new System.EventHandler(this.rreturn_Click);
            // 
            // btnrequested_items
            // 
            this.btnrequested_items.BackColor = System.Drawing.Color.Green;
            this.btnrequested_items.color = System.Drawing.Color.Green;
            this.btnrequested_items.colorActive = System.Drawing.Color.DarkGreen;
            this.btnrequested_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnrequested_items, BunifuAnimatorNS.DecorationType.None);
            this.btnrequested_items.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrequested_items.ForeColor = System.Drawing.Color.White;
            this.btnrequested_items.Image = ((System.Drawing.Image)(resources.GetObject("btnrequested_items.Image")));
            this.btnrequested_items.ImagePosition = 6;
            this.btnrequested_items.ImageZoom = 15;
            this.btnrequested_items.LabelPosition = 30;
            this.btnrequested_items.LabelText = "REQUESTED ITEMS";
            this.btnrequested_items.Location = new System.Drawing.Point(176, 0);
            this.btnrequested_items.Margin = new System.Windows.Forms.Padding(6);
            this.btnrequested_items.Name = "btnrequested_items";
            this.btnrequested_items.Size = new System.Drawing.Size(179, 64);
            this.btnrequested_items.TabIndex = 137;
            this.btnrequested_items.Click += new System.EventHandler(this.transact_Click);
            // 
            // btn_unused
            // 
            this.btn_unused.BackColor = System.Drawing.Color.Green;
            this.btn_unused.color = System.Drawing.Color.Green;
            this.btn_unused.colorActive = System.Drawing.Color.DarkGreen;
            this.btn_unused.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_unused, BunifuAnimatorNS.DecorationType.None);
            this.btn_unused.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unused.ForeColor = System.Drawing.Color.White;
            this.btn_unused.Image = ((System.Drawing.Image)(resources.GetObject("btn_unused.Image")));
            this.btn_unused.ImagePosition = 6;
            this.btn_unused.ImageZoom = 15;
            this.btn_unused.LabelPosition = 30;
            this.btn_unused.LabelText = "UNUSED STOCKS";
            this.btn_unused.Location = new System.Drawing.Point(355, -1);
            this.btn_unused.Margin = new System.Windows.Forms.Padding(6);
            this.btn_unused.Name = "btn_unused";
            this.btn_unused.Size = new System.Drawing.Size(177, 64);
            this.btn_unused.TabIndex = 137;
            this.btn_unused.Click += new System.EventHandler(this.rArStaff_Click);
            // 
            // rinventory
            // 
            this.rinventory.BackColor = System.Drawing.Color.Green;
            this.rinventory.color = System.Drawing.Color.Green;
            this.rinventory.colorActive = System.Drawing.Color.DarkGreen;
            this.rinventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.rinventory, BunifuAnimatorNS.DecorationType.None);
            this.rinventory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rinventory.ForeColor = System.Drawing.Color.White;
            this.rinventory.Image = ((System.Drawing.Image)(resources.GetObject("rinventory.Image")));
            this.rinventory.ImagePosition = 6;
            this.rinventory.ImageZoom = 20;
            this.rinventory.LabelPosition = 30;
            this.rinventory.LabelText = "INVENTORY";
            this.rinventory.Location = new System.Drawing.Point(6, 0);
            this.rinventory.Margin = new System.Windows.Forms.Padding(6);
            this.rinventory.Name = "rinventory";
            this.rinventory.Size = new System.Drawing.Size(165, 64);
            this.rinventory.TabIndex = 137;
            this.rinventory.Click += new System.EventHandler(this.rinventory_Click);
            // 
            // btn_recap
            // 
            this.btn_recap.BackColor = System.Drawing.Color.Green;
            this.btn_recap.color = System.Drawing.Color.Green;
            this.btn_recap.colorActive = System.Drawing.Color.DarkGreen;
            this.btn_recap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_recap, BunifuAnimatorNS.DecorationType.None);
            this.btn_recap.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recap.ForeColor = System.Drawing.Color.White;
            this.btn_recap.Image = ((System.Drawing.Image)(resources.GetObject("btn_recap.Image")));
            this.btn_recap.ImagePosition = 6;
            this.btn_recap.ImageZoom = 20;
            this.btn_recap.LabelPosition = 30;
            this.btn_recap.LabelText = "RECAP";
            this.btn_recap.Location = new System.Drawing.Point(536, -1);
            this.btn_recap.Margin = new System.Windows.Forms.Padding(6);
            this.btn_recap.Name = "btn_recap";
            this.btn_recap.Size = new System.Drawing.Size(125, 64);
            this.btn_recap.TabIndex = 137;
            this.btn_recap.Click += new System.EventHandler(this.btn_recap_Click);
            // 
            // rexpired
            // 
            this.rexpired.BackColor = System.Drawing.Color.Green;
            this.rexpired.color = System.Drawing.Color.Green;
            this.rexpired.colorActive = System.Drawing.Color.DarkGreen;
            this.rexpired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.rexpired, BunifuAnimatorNS.DecorationType.None);
            this.rexpired.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rexpired.ForeColor = System.Drawing.Color.White;
            this.rexpired.Image = ((System.Drawing.Image)(resources.GetObject("rexpired.Image")));
            this.rexpired.ImagePosition = 6;
            this.rexpired.ImageZoom = 25;
            this.rexpired.LabelPosition = 30;
            this.rexpired.LabelText = "EXPIRED";
            this.rexpired.Location = new System.Drawing.Point(665, -1);
            this.rexpired.Margin = new System.Windows.Forms.Padding(6);
            this.rexpired.Name = "rexpired";
            this.rexpired.Size = new System.Drawing.Size(125, 64);
            this.rexpired.TabIndex = 137;
            this.rexpired.Click += new System.EventHandler(this.rexpired_Click);
            // 
            // paneltitleris
            // 
            this.paneltitleris.Controls.Add(this.label92);
            this.epeks.SetDecoration(this.paneltitleris, BunifuAnimatorNS.DecorationType.None);
            this.paneltitleris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltitleris.Location = new System.Drawing.Point(0, 0);
            this.paneltitleris.Name = "paneltitleris";
            this.paneltitleris.Size = new System.Drawing.Size(1177, 64);
            this.paneltitleris.TabIndex = 111;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.epeks.SetDecoration(this.label92, BunifuAnimatorNS.DecorationType.None);
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.ForeColor = System.Drawing.Color.White;
            this.label92.Location = new System.Drawing.Point(10, 18);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(79, 33);
            this.label92.TabIndex = 111;
            this.label92.Text = "R.I.S";
            // 
            // psearch_add
            // 
            this.psearch_add.AutoSize = true;
            this.epeks.SetDecoration(this.psearch_add, BunifuAnimatorNS.DecorationType.None);
            this.psearch_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psearch_add.ForeColor = System.Drawing.Color.White;
            this.psearch_add.Location = new System.Drawing.Point(52, 21);
            this.psearch_add.Name = "psearch_add";
            this.psearch_add.Size = new System.Drawing.Size(357, 33);
            this.psearch_add.TabIndex = 110;
            this.psearch_add.Text = "ADD PURCHASE ORDER";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.epeks.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(19, 18);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 34);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // add_panel
            // 
            this.add_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_panel.Controls.Add(this.preports);
            this.add_panel.Controls.Add(this.panelRIS);
            this.add_panel.Controls.Add(this.panel13);
            this.add_panel.Controls.Add(this.tInventory);
            this.add_panel.Controls.Add(this.LVnotification);
            this.add_panel.Controls.Add(this.panel17);
            this.add_panel.Controls.Add(this.panel28);
            this.epeks.SetDecoration(this.add_panel, BunifuAnimatorNS.DecorationType.None);
            this.add_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_panel.Location = new System.Drawing.Point(59, 0);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(1177, 680);
            this.add_panel.TabIndex = 0;
            // 
            // preports
            // 
            this.preports.Controls.Add(this.psettings);
            this.preports.Controls.Add(this.p_rsales);
            this.preports.Controls.Add(this.tableLayoutPanel3);
            this.epeks.SetDecoration(this.preports, BunifuAnimatorNS.DecorationType.None);
            this.preports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preports.Location = new System.Drawing.Point(0, 63);
            this.preports.Name = "preports";
            this.preports.Size = new System.Drawing.Size(1177, 617);
            this.preports.TabIndex = 4;
            // 
            // psettings
            // 
            this.psettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.psettings.Controls.Add(this.panelCP);
            this.psettings.Controls.Add(this.tableLayoutPanel1);
            this.epeks.SetDecoration(this.psettings, BunifuAnimatorNS.DecorationType.None);
            this.psettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psettings.Location = new System.Drawing.Point(0, 0);
            this.psettings.Name = "psettings";
            this.psettings.Size = new System.Drawing.Size(1177, 617);
            this.psettings.TabIndex = 3;
            // 
            // panelCP
            // 
            this.panelCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCP.Controls.Add(this.productset);
            this.panelCP.Controls.Add(this.panelpassword);
            this.panelCP.Controls.Add(this.panel16);
            this.epeks.SetDecoration(this.panelCP, BunifuAnimatorNS.DecorationType.None);
            this.panelCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCP.Location = new System.Drawing.Point(0, 0);
            this.panelCP.Name = "panelCP";
            this.panelCP.Size = new System.Drawing.Size(1177, 617);
            this.panelCP.TabIndex = 1;
            // 
            // productset
            // 
            this.productset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.productset.Controls.Add(this.p_category);
            this.productset.Controls.Add(this.tableLayoutPanel26);
            this.epeks.SetDecoration(this.productset, BunifuAnimatorNS.DecorationType.None);
            this.productset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productset.Location = new System.Drawing.Point(0, 0);
            this.productset.Name = "productset";
            this.productset.Size = new System.Drawing.Size(1177, 617);
            this.productset.TabIndex = 117;
            // 
            // p_category
            // 
            this.p_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.p_category.Controls.Add(this.paddproduct);
            this.p_category.Controls.Add(this.catpanel);
            this.p_category.Controls.Add(this.supppanel);
            this.p_category.Controls.Add(this.unitpanel);
            this.p_category.Controls.Add(this.emppanel);
            this.p_category.Controls.Add(this.deppanel);
            this.p_category.Controls.Add(this.panel9);
            this.epeks.SetDecoration(this.p_category, BunifuAnimatorNS.DecorationType.None);
            this.p_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_category.Location = new System.Drawing.Point(0, 0);
            this.p_category.Name = "p_category";
            this.p_category.Size = new System.Drawing.Size(1177, 617);
            this.p_category.TabIndex = 120;
            // 
            // paddproduct
            // 
            this.paddproduct.Controls.Add(this.additem_panel);
            this.epeks.SetDecoration(this.paddproduct, BunifuAnimatorNS.DecorationType.None);
            this.paddproduct.Location = new System.Drawing.Point(1081, 464);
            this.paddproduct.Name = "paddproduct";
            this.paddproduct.Size = new System.Drawing.Size(96, 153);
            this.paddproduct.TabIndex = 33;
            // 
            // additem_panel
            // 
            this.additem_panel.BackColor = System.Drawing.Color.PaleGreen;
            this.additem_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.additem_panel.Controls.Add(this.label103);
            this.additem_panel.Controls.Add(this.unitPrice);
            this.additem_panel.Controls.Add(this.label57);
            this.additem_panel.Controls.Add(this.btnsaveproduct);
            this.additem_panel.Controls.Add(this.panel23);
            this.additem_panel.Controls.Add(this.cb_suppliername);
            this.additem_panel.Controls.Add(this.addproductcategory);
            this.additem_panel.Controls.Add(this.cbaddunit);
            this.additem_panel.Controls.Add(this.cbaddunitmeasure);
            this.additem_panel.Controls.Add(this.cbcategoryunit);
            this.additem_panel.Controls.Add(this.label49);
            this.additem_panel.Controls.Add(this.ProductName);
            this.additem_panel.Controls.Add(this.label80);
            this.additem_panel.Controls.Add(this.label93);
            this.epeks.SetDecoration(this.additem_panel, BunifuAnimatorNS.DecorationType.None);
            this.additem_panel.Location = new System.Drawing.Point(30, 23);
            this.additem_panel.Name = "additem_panel";
            this.additem_panel.Size = new System.Drawing.Size(563, 419);
            this.additem_panel.TabIndex = 0;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.epeks.SetDecoration(this.label103, BunifuAnimatorNS.DecorationType.None);
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.Color.DarkGreen;
            this.label103.Location = new System.Drawing.Point(41, 150);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(131, 20);
            this.label103.TabIndex = 132;
            this.label103.Text = "Supplier Name:";
            // 
            // unitPrice
            // 
            this.epeks.SetDecoration(this.unitPrice, BunifuAnimatorNS.DecorationType.None);
            this.unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice.Location = new System.Drawing.Point(198, 298);
            this.unitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(120, 30);
            this.unitPrice.TabIndex = 130;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.epeks.SetDecoration(this.label57, BunifuAnimatorNS.DecorationType.None);
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.DarkGreen;
            this.label57.Location = new System.Drawing.Point(37, 307);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(92, 20);
            this.label57.TabIndex = 129;
            this.label57.Text = "Unit Price:";
            // 
            // btnsaveproduct
            // 
            this.btnsaveproduct.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnsaveproduct.BackColor = System.Drawing.Color.DarkGreen;
            this.btnsaveproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsaveproduct.BorderRadius = 5;
            this.btnsaveproduct.ButtonText = "    ADD";
            this.btnsaveproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnsaveproduct, BunifuAnimatorNS.DecorationType.None);
            this.btnsaveproduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnsaveproduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsaveproduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsaveproduct.Iconimage")));
            this.btnsaveproduct.Iconimage_right = null;
            this.btnsaveproduct.Iconimage_right_Selected = null;
            this.btnsaveproduct.Iconimage_Selected = null;
            this.btnsaveproduct.IconMarginLeft = 20;
            this.btnsaveproduct.IconMarginRight = 0;
            this.btnsaveproduct.IconRightVisible = true;
            this.btnsaveproduct.IconRightZoom = 0D;
            this.btnsaveproduct.IconVisible = true;
            this.btnsaveproduct.IconZoom = 60D;
            this.btnsaveproduct.IsTab = false;
            this.btnsaveproduct.Location = new System.Drawing.Point(353, 338);
            this.btnsaveproduct.Name = "btnsaveproduct";
            this.btnsaveproduct.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnsaveproduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsaveproduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsaveproduct.selected = false;
            this.btnsaveproduct.Size = new System.Drawing.Size(144, 43);
            this.btnsaveproduct.TabIndex = 128;
            this.btnsaveproduct.Text = "    ADD";
            this.btnsaveproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveproduct.Textcolor = System.Drawing.Color.White;
            this.btnsaveproduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveproduct.Click += new System.EventHandler(this.btnsaveproduct_Click);
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.Green;
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Controls.Add(this.label4);
            this.epeks.SetDecoration(this.panel23, BunifuAnimatorNS.DecorationType.None);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(561, 39);
            this.panel23.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.epeks.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "ADD ITEM";
            // 
            // cb_suppliername
            // 
            this.epeks.SetDecoration(this.cb_suppliername, BunifuAnimatorNS.DecorationType.None);
            this.cb_suppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_suppliername.FormattingEnabled = true;
            this.cb_suppliername.Location = new System.Drawing.Point(198, 148);
            this.cb_suppliername.Name = "cb_suppliername";
            this.cb_suppliername.Size = new System.Drawing.Size(310, 28);
            this.cb_suppliername.TabIndex = 119;
            this.cb_suppliername.Text = "Select Supplier";
            this.cb_suppliername.SelectedIndexChanged += new System.EventHandler(this.cb_suppliername_SelectedIndexChanged);
            // 
            // addproductcategory
            // 
            this.epeks.SetDecoration(this.addproductcategory, BunifuAnimatorNS.DecorationType.None);
            this.addproductcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproductcategory.FormattingEnabled = true;
            this.addproductcategory.Location = new System.Drawing.Point(198, 202);
            this.addproductcategory.Name = "addproductcategory";
            this.addproductcategory.Size = new System.Drawing.Size(310, 28);
            this.addproductcategory.TabIndex = 119;
            this.addproductcategory.Text = "Select Item Category";
            // 
            // cbaddunit
            // 
            this.epeks.SetDecoration(this.cbaddunit, BunifuAnimatorNS.DecorationType.None);
            this.cbaddunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbaddunit.FormattingEnabled = true;
            this.cbaddunit.Location = new System.Drawing.Point(426, 253);
            this.cbaddunit.Name = "cbaddunit";
            this.cbaddunit.Size = new System.Drawing.Size(82, 28);
            this.cbaddunit.TabIndex = 119;
            this.cbaddunit.Text = "Select";
            // 
            // cbaddunitmeasure
            // 
            this.epeks.SetDecoration(this.cbaddunitmeasure, BunifuAnimatorNS.DecorationType.None);
            this.cbaddunitmeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbaddunitmeasure.FormattingEnabled = true;
            this.cbaddunitmeasure.Location = new System.Drawing.Point(338, 253);
            this.cbaddunitmeasure.Name = "cbaddunitmeasure";
            this.cbaddunitmeasure.Size = new System.Drawing.Size(82, 28);
            this.cbaddunitmeasure.TabIndex = 119;
            this.cbaddunitmeasure.Text = "Select";
            // 
            // cbcategoryunit
            // 
            this.epeks.SetDecoration(this.cbcategoryunit, BunifuAnimatorNS.DecorationType.None);
            this.cbcategoryunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoryunit.FormattingEnabled = true;
            this.cbcategoryunit.Location = new System.Drawing.Point(199, 253);
            this.cbcategoryunit.Name = "cbcategoryunit";
            this.cbcategoryunit.Size = new System.Drawing.Size(133, 28);
            this.cbcategoryunit.TabIndex = 119;
            this.cbcategoryunit.Text = "Select";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.epeks.SetDecoration(this.label49, BunifuAnimatorNS.DecorationType.None);
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.DarkGreen;
            this.label49.Location = new System.Drawing.Point(41, 256);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(47, 20);
            this.label49.TabIndex = 126;
            this.label49.Text = "Unit:";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.White;
            this.ProductName.BorderColorFocused = System.Drawing.Color.Lime;
            this.ProductName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProductName.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.ProductName.BorderThickness = 3;
            this.ProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.ProductName, BunifuAnimatorNS.DecorationType.None);
            this.ProductName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.DarkGreen;
            this.ProductName.isPassword = false;
            this.ProductName.Location = new System.Drawing.Point(198, 78);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(310, 44);
            this.ProductName.TabIndex = 121;
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.epeks.SetDecoration(this.label80, BunifuAnimatorNS.DecorationType.None);
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.Color.DarkGreen;
            this.label80.Location = new System.Drawing.Point(41, 206);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(86, 20);
            this.label80.TabIndex = 123;
            this.label80.Text = "Category:";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.epeks.SetDecoration(this.label93, BunifuAnimatorNS.DecorationType.None);
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.ForeColor = System.Drawing.Color.DarkGreen;
            this.label93.Location = new System.Drawing.Point(41, 90);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(127, 20);
            this.label93.TabIndex = 124;
            this.label93.Text = "Product Name:";
            // 
            // catpanel
            // 
            this.catpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.catpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catpanel.Controls.Add(this.panel35);
            this.catpanel.Controls.Add(this.label79);
            this.catpanel.Controls.Add(this.cbcat);
            this.catpanel.Controls.Add(this.btnupdate4);
            this.catpanel.Controls.Add(this.btnsave4);
            this.catpanel.Controls.Add(this.tbcat);
            this.epeks.SetDecoration(this.catpanel, BunifuAnimatorNS.DecorationType.None);
            this.catpanel.Location = new System.Drawing.Point(203, 2);
            this.catpanel.Name = "catpanel";
            this.catpanel.Size = new System.Drawing.Size(374, 285);
            this.catpanel.TabIndex = 27;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.Green;
            this.panel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel35.Controls.Add(this.label43);
            this.epeks.SetDecoration(this.panel35, BunifuAnimatorNS.DecorationType.None);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel35.Location = new System.Drawing.Point(0, 0);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(372, 36);
            this.panel35.TabIndex = 28;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.epeks.SetDecoration(this.label43, BunifuAnimatorNS.DecorationType.None);
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label43.Location = new System.Drawing.Point(129, 8);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(107, 20);
            this.label43.TabIndex = 23;
            this.label43.Text = "CATEGORY";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.epeks.SetDecoration(this.label79, BunifuAnimatorNS.DecorationType.None);
            this.label79.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(23, 129);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(113, 20);
            this.label79.TabIndex = 27;
            this.label79.Text = "Category Name";
            // 
            // cbcat
            // 
            this.epeks.SetDecoration(this.cbcat, BunifuAnimatorNS.DecorationType.None);
            this.cbcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(25, 77);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(327, 32);
            this.cbcat.TabIndex = 20;
            this.cbcat.Text = "Select Category";
            this.cbcat.SelectedIndexChanged += new System.EventHandler(this.cbcat_SelectedIndexChanged);
            this.cbcat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbcat_MouseClick);
            // 
            // btnupdate4
            // 
            this.btnupdate4.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnupdate4.BackColor = System.Drawing.Color.DarkGreen;
            this.btnupdate4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate4.BorderRadius = 5;
            this.btnupdate4.ButtonText = "UPDATE";
            this.btnupdate4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnupdate4, BunifuAnimatorNS.DecorationType.None);
            this.btnupdate4.DisabledColor = System.Drawing.Color.Gray;
            this.btnupdate4.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdate4.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnupdate4.Iconimage")));
            this.btnupdate4.Iconimage_right = null;
            this.btnupdate4.Iconimage_right_Selected = null;
            this.btnupdate4.Iconimage_Selected = null;
            this.btnupdate4.IconMarginLeft = 0;
            this.btnupdate4.IconMarginRight = 0;
            this.btnupdate4.IconRightVisible = true;
            this.btnupdate4.IconRightZoom = 0D;
            this.btnupdate4.IconVisible = true;
            this.btnupdate4.IconZoom = 60D;
            this.btnupdate4.IsTab = false;
            this.btnupdate4.Location = new System.Drawing.Point(230, 218);
            this.btnupdate4.Name = "btnupdate4";
            this.btnupdate4.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnupdate4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdate4.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdate4.selected = false;
            this.btnupdate4.Size = new System.Drawing.Size(120, 43);
            this.btnupdate4.TabIndex = 22;
            this.btnupdate4.Text = "UPDATE";
            this.btnupdate4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate4.Textcolor = System.Drawing.Color.White;
            this.btnupdate4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate4.Click += new System.EventHandler(this.btnupdate4_Click);
            // 
            // btnsave4
            // 
            this.btnsave4.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnsave4.BackColor = System.Drawing.Color.DarkGreen;
            this.btnsave4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave4.BorderRadius = 5;
            this.btnsave4.ButtonText = "    ADD";
            this.btnsave4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnsave4, BunifuAnimatorNS.DecorationType.None);
            this.btnsave4.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave4.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsave4.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsave4.Iconimage")));
            this.btnsave4.Iconimage_right = null;
            this.btnsave4.Iconimage_right_Selected = null;
            this.btnsave4.Iconimage_Selected = null;
            this.btnsave4.IconMarginLeft = 20;
            this.btnsave4.IconMarginRight = 0;
            this.btnsave4.IconRightVisible = true;
            this.btnsave4.IconRightZoom = 0D;
            this.btnsave4.IconVisible = true;
            this.btnsave4.IconZoom = 60D;
            this.btnsave4.IsTab = false;
            this.btnsave4.Location = new System.Drawing.Point(26, 218);
            this.btnsave4.Name = "btnsave4";
            this.btnsave4.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnsave4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave4.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsave4.selected = false;
            this.btnsave4.Size = new System.Drawing.Size(120, 43);
            this.btnsave4.TabIndex = 22;
            this.btnsave4.Text = "    ADD";
            this.btnsave4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave4.Textcolor = System.Drawing.Color.White;
            this.btnsave4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave4.Click += new System.EventHandler(this.btnsave4_Click);
            // 
            // tbcat
            // 
            this.tbcat.BackColor = System.Drawing.Color.White;
            this.tbcat.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbcat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbcat.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tbcat.BorderThickness = 3;
            this.tbcat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbcat, BunifuAnimatorNS.DecorationType.None);
            this.tbcat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcat.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbcat.isPassword = false;
            this.tbcat.Location = new System.Drawing.Point(24, 153);
            this.tbcat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbcat.Name = "tbcat";
            this.tbcat.Size = new System.Drawing.Size(328, 41);
            this.tbcat.TabIndex = 21;
            this.tbcat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // supppanel
            // 
            this.supppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.supppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supppanel.Controls.Add(this.panel29);
            this.supppanel.Controls.Add(this.lblsupname);
            this.supppanel.Controls.Add(this.supnametxt);
            this.supppanel.Controls.Add(this.cb_set_supplier);
            this.supppanel.Controls.Add(this.btn_update2);
            this.supppanel.Controls.Add(this.btn_sve2);
            this.epeks.SetDecoration(this.supppanel, BunifuAnimatorNS.DecorationType.None);
            this.supppanel.Location = new System.Drawing.Point(203, 2);
            this.supppanel.Name = "supppanel";
            this.supppanel.Size = new System.Drawing.Size(373, 285);
            this.supppanel.TabIndex = 25;
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.Green;
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel29.Controls.Add(this.label32);
            this.epeks.SetDecoration(this.panel29, BunifuAnimatorNS.DecorationType.None);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel29.Location = new System.Drawing.Point(0, 0);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(371, 36);
            this.panel29.TabIndex = 26;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.epeks.SetDecoration(this.label32, BunifuAnimatorNS.DecorationType.None);
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label32.Location = new System.Drawing.Point(136, 7);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(102, 20);
            this.label32.TabIndex = 23;
            this.label32.Text = "SUPPLIER ";
            // 
            // lblsupname
            // 
            this.lblsupname.AutoSize = true;
            this.epeks.SetDecoration(this.lblsupname, BunifuAnimatorNS.DecorationType.None);
            this.lblsupname.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupname.Location = new System.Drawing.Point(28, 126);
            this.lblsupname.Name = "lblsupname";
            this.lblsupname.Size = new System.Drawing.Size(105, 20);
            this.lblsupname.TabIndex = 27;
            this.lblsupname.Text = "Supplier Name";
            // 
            // supnametxt
            // 
            this.supnametxt.BackColor = System.Drawing.Color.White;
            this.supnametxt.BorderColorFocused = System.Drawing.Color.Lime;
            this.supnametxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.supnametxt.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.supnametxt.BorderThickness = 3;
            this.supnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.supnametxt, BunifuAnimatorNS.DecorationType.None);
            this.supnametxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supnametxt.ForeColor = System.Drawing.Color.DarkGreen;
            this.supnametxt.isPassword = false;
            this.supnametxt.Location = new System.Drawing.Point(31, 150);
            this.supnametxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.supnametxt.Name = "supnametxt";
            this.supnametxt.Size = new System.Drawing.Size(306, 41);
            this.supnametxt.TabIndex = 25;
            this.supnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb_set_supplier
            // 
            this.epeks.SetDecoration(this.cb_set_supplier, BunifuAnimatorNS.DecorationType.None);
            this.cb_set_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_set_supplier.FormattingEnabled = true;
            this.cb_set_supplier.Location = new System.Drawing.Point(31, 76);
            this.cb_set_supplier.Name = "cb_set_supplier";
            this.cb_set_supplier.Size = new System.Drawing.Size(306, 32);
            this.cb_set_supplier.TabIndex = 20;
            this.cb_set_supplier.Text = "Select Supplier";
            this.cb_set_supplier.SelectedIndexChanged += new System.EventHandler(this.cb_set_catUnit_SelectedIndexChanged);
            this.cb_set_supplier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_set_supplier_MouseClick);
            // 
            // btn_update2
            // 
            this.btn_update2.Activecolor = System.Drawing.Color.LimeGreen;
            this.btn_update2.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_update2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update2.BorderRadius = 5;
            this.btn_update2.ButtonText = "UPDATE";
            this.btn_update2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_update2, BunifuAnimatorNS.DecorationType.None);
            this.btn_update2.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update2.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_update2.Iconimage")));
            this.btn_update2.Iconimage_right = null;
            this.btn_update2.Iconimage_right_Selected = null;
            this.btn_update2.Iconimage_Selected = null;
            this.btn_update2.IconMarginLeft = 0;
            this.btn_update2.IconMarginRight = 0;
            this.btn_update2.IconRightVisible = true;
            this.btn_update2.IconRightZoom = 0D;
            this.btn_update2.IconVisible = true;
            this.btn_update2.IconZoom = 60D;
            this.btn_update2.IsTab = false;
            this.btn_update2.Location = new System.Drawing.Point(217, 215);
            this.btn_update2.Name = "btn_update2";
            this.btn_update2.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btn_update2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_update2.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update2.selected = false;
            this.btn_update2.Size = new System.Drawing.Size(120, 43);
            this.btn_update2.TabIndex = 22;
            this.btn_update2.Text = "UPDATE";
            this.btn_update2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update2.Textcolor = System.Drawing.Color.White;
            this.btn_update2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update2.Click += new System.EventHandler(this.btn_update2_Click);
            // 
            // btn_sve2
            // 
            this.btn_sve2.Activecolor = System.Drawing.Color.LimeGreen;
            this.btn_sve2.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_sve2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sve2.BorderRadius = 5;
            this.btn_sve2.ButtonText = "    ADD";
            this.btn_sve2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_sve2, BunifuAnimatorNS.DecorationType.None);
            this.btn_sve2.DisabledColor = System.Drawing.Color.Gray;
            this.btn_sve2.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_sve2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_sve2.Iconimage")));
            this.btn_sve2.Iconimage_right = null;
            this.btn_sve2.Iconimage_right_Selected = null;
            this.btn_sve2.Iconimage_Selected = null;
            this.btn_sve2.IconMarginLeft = 20;
            this.btn_sve2.IconMarginRight = 0;
            this.btn_sve2.IconRightVisible = true;
            this.btn_sve2.IconRightZoom = 0D;
            this.btn_sve2.IconVisible = true;
            this.btn_sve2.IconZoom = 60D;
            this.btn_sve2.IsTab = false;
            this.btn_sve2.Location = new System.Drawing.Point(31, 217);
            this.btn_sve2.Name = "btn_sve2";
            this.btn_sve2.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btn_sve2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sve2.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sve2.selected = false;
            this.btn_sve2.Size = new System.Drawing.Size(120, 43);
            this.btn_sve2.TabIndex = 22;
            this.btn_sve2.Text = "    ADD";
            this.btn_sve2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sve2.Textcolor = System.Drawing.Color.White;
            this.btn_sve2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sve2.Click += new System.EventHandler(this.btn_sve2_Click);
            // 
            // unitpanel
            // 
            this.unitpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.unitpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitpanel.Controls.Add(this.label28);
            this.unitpanel.Controls.Add(this.label27);
            this.unitpanel.Controls.Add(this.cbunitSelector);
            this.unitpanel.Controls.Add(this.panel31);
            this.unitpanel.Controls.Add(this.label44);
            this.unitpanel.Controls.Add(this.cb_set_unit);
            this.unitpanel.Controls.Add(this.btn_update3);
            this.unitpanel.Controls.Add(this.btn_sve3);
            this.unitpanel.Controls.Add(this.tb_setunit);
            this.epeks.SetDecoration(this.unitpanel, BunifuAnimatorNS.DecorationType.None);
            this.unitpanel.Location = new System.Drawing.Point(203, 2);
            this.unitpanel.Name = "unitpanel";
            this.unitpanel.Size = new System.Drawing.Size(373, 348);
            this.unitpanel.TabIndex = 25;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.epeks.SetDecoration(this.label28, BunifuAnimatorNS.DecorationType.None);
            this.label28.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(30, 126);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 20);
            this.label28.TabIndex = 36;
            this.label28.Text = "Item name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.epeks.SetDecoration(this.label27, BunifuAnimatorNS.DecorationType.None);
            this.label27.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(33, 58);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(169, 20);
            this.label27.TabIndex = 31;
            this.label27.Text = "Select Category for edit";
            // 
            // cbunitSelector
            // 
            this.epeks.SetDecoration(this.cbunitSelector, BunifuAnimatorNS.DecorationType.None);
            this.cbunitSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitSelector.FormattingEnabled = true;
            this.cbunitSelector.Items.AddRange(new object[] {
            "Unit Category",
            "Unit Measure",
            "Unit"});
            this.cbunitSelector.Location = new System.Drawing.Point(34, 81);
            this.cbunitSelector.Name = "cbunitSelector";
            this.cbunitSelector.Size = new System.Drawing.Size(299, 32);
            this.cbunitSelector.TabIndex = 30;
            this.cbunitSelector.Text = "select";
            this.cbunitSelector.SelectedIndexChanged += new System.EventHandler(this.cbunitSelector_SelectedIndexChanged);
            this.cbunitSelector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbunitSelector_MouseClick);
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.Green;
            this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel31.Controls.Add(this.label38);
            this.epeks.SetDecoration(this.panel31, BunifuAnimatorNS.DecorationType.None);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel31.Location = new System.Drawing.Point(0, 0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(371, 36);
            this.panel31.TabIndex = 26;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.epeks.SetDecoration(this.label38, BunifuAnimatorNS.DecorationType.None);
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label38.Location = new System.Drawing.Point(157, 7);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(50, 20);
            this.label38.TabIndex = 23;
            this.label38.Text = "UNIT";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.epeks.SetDecoration(this.label44, BunifuAnimatorNS.DecorationType.None);
            this.label44.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(29, 203);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(81, 20);
            this.label44.TabIndex = 29;
            this.label44.Text = "Unit Name";
            // 
            // cb_set_unit
            // 
            this.epeks.SetDecoration(this.cb_set_unit, BunifuAnimatorNS.DecorationType.None);
            this.cb_set_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_set_unit.FormattingEnabled = true;
            this.cb_set_unit.Location = new System.Drawing.Point(34, 151);
            this.cb_set_unit.Name = "cb_set_unit";
            this.cb_set_unit.Size = new System.Drawing.Size(299, 32);
            this.cb_set_unit.TabIndex = 20;
            this.cb_set_unit.Text = "select";
            this.cb_set_unit.SelectedIndexChanged += new System.EventHandler(this.cb_set_unit_SelectedIndexChanged);
            // 
            // btn_update3
            // 
            this.btn_update3.Activecolor = System.Drawing.Color.LimeGreen;
            this.btn_update3.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_update3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update3.BorderRadius = 5;
            this.btn_update3.ButtonText = " UPDATE";
            this.btn_update3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_update3, BunifuAnimatorNS.DecorationType.None);
            this.btn_update3.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update3.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update3.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_update3.Iconimage")));
            this.btn_update3.Iconimage_right = null;
            this.btn_update3.Iconimage_right_Selected = null;
            this.btn_update3.Iconimage_Selected = null;
            this.btn_update3.IconMarginLeft = 0;
            this.btn_update3.IconMarginRight = 0;
            this.btn_update3.IconRightVisible = true;
            this.btn_update3.IconRightZoom = 0D;
            this.btn_update3.IconVisible = true;
            this.btn_update3.IconZoom = 60D;
            this.btn_update3.IsTab = false;
            this.btn_update3.Location = new System.Drawing.Point(213, 282);
            this.btn_update3.Name = "btn_update3";
            this.btn_update3.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btn_update3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_update3.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update3.selected = false;
            this.btn_update3.Size = new System.Drawing.Size(120, 43);
            this.btn_update3.TabIndex = 22;
            this.btn_update3.Text = " UPDATE";
            this.btn_update3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update3.Textcolor = System.Drawing.Color.White;
            this.btn_update3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update3.Click += new System.EventHandler(this.btn_update3_Click);
            // 
            // btn_sve3
            // 
            this.btn_sve3.Activecolor = System.Drawing.Color.LimeGreen;
            this.btn_sve3.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_sve3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sve3.BorderRadius = 5;
            this.btn_sve3.ButtonText = "    ADD";
            this.btn_sve3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_sve3, BunifuAnimatorNS.DecorationType.None);
            this.btn_sve3.DisabledColor = System.Drawing.Color.Gray;
            this.btn_sve3.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_sve3.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_sve3.Iconimage")));
            this.btn_sve3.Iconimage_right = null;
            this.btn_sve3.Iconimage_right_Selected = null;
            this.btn_sve3.Iconimage_Selected = null;
            this.btn_sve3.IconMarginLeft = 20;
            this.btn_sve3.IconMarginRight = 0;
            this.btn_sve3.IconRightVisible = true;
            this.btn_sve3.IconRightZoom = 0D;
            this.btn_sve3.IconVisible = true;
            this.btn_sve3.IconZoom = 60D;
            this.btn_sve3.IsTab = false;
            this.btn_sve3.Location = new System.Drawing.Point(31, 282);
            this.btn_sve3.Name = "btn_sve3";
            this.btn_sve3.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btn_sve3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sve3.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sve3.selected = false;
            this.btn_sve3.Size = new System.Drawing.Size(120, 43);
            this.btn_sve3.TabIndex = 22;
            this.btn_sve3.Text = "    ADD";
            this.btn_sve3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sve3.Textcolor = System.Drawing.Color.White;
            this.btn_sve3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sve3.Click += new System.EventHandler(this.btn_sve3_Click);
            // 
            // tb_setunit
            // 
            this.tb_setunit.BackColor = System.Drawing.Color.White;
            this.tb_setunit.BorderColorFocused = System.Drawing.Color.Lime;
            this.tb_setunit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_setunit.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tb_setunit.BorderThickness = 3;
            this.tb_setunit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tb_setunit, BunifuAnimatorNS.DecorationType.None);
            this.tb_setunit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_setunit.ForeColor = System.Drawing.Color.DarkGreen;
            this.tb_setunit.isPassword = false;
            this.tb_setunit.Location = new System.Drawing.Point(29, 227);
            this.tb_setunit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tb_setunit.Name = "tb_setunit";
            this.tb_setunit.Size = new System.Drawing.Size(304, 41);
            this.tb_setunit.TabIndex = 21;
            this.tb_setunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emppanel
            // 
            this.emppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.emppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emppanel.Controls.Add(this.cb_categorySignature);
            this.emppanel.Controls.Add(this.panel45);
            this.emppanel.Controls.Add(this.label6);
            this.emppanel.Controls.Add(this.cbfullname);
            this.emppanel.Controls.Add(this.btnupdatefn);
            this.emppanel.Controls.Add(this.btnsavefn);
            this.emppanel.Controls.Add(this.tbfullname);
            this.epeks.SetDecoration(this.emppanel, BunifuAnimatorNS.DecorationType.None);
            this.emppanel.Location = new System.Drawing.Point(203, 2);
            this.emppanel.Name = "emppanel";
            this.emppanel.Size = new System.Drawing.Size(373, 355);
            this.emppanel.TabIndex = 35;
            // 
            // cb_categorySignature
            // 
            this.epeks.SetDecoration(this.cb_categorySignature, BunifuAnimatorNS.DecorationType.None);
            this.cb_categorySignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categorySignature.FormattingEnabled = true;
            this.cb_categorySignature.Items.AddRange(new object[] {
            "Approved by",
            "Issued by",
            "Prepared by",
            "Received by"});
            this.cb_categorySignature.Location = new System.Drawing.Point(25, 217);
            this.cb_categorySignature.Name = "cb_categorySignature";
            this.cb_categorySignature.Size = new System.Drawing.Size(312, 32);
            this.cb_categorySignature.TabIndex = 33;
            this.cb_categorySignature.Text = "Select Category";
            // 
            // panel45
            // 
            this.panel45.BackColor = System.Drawing.Color.Green;
            this.panel45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel45.Controls.Add(this.label5);
            this.epeks.SetDecoration(this.panel45, BunifuAnimatorNS.DecorationType.None);
            this.panel45.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel45.Location = new System.Drawing.Point(0, 0);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(371, 36);
            this.panel45.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.epeks.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(122, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "EMPLOYEE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.epeks.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Employee Name";
            // 
            // cbfullname
            // 
            this.epeks.SetDecoration(this.cbfullname, BunifuAnimatorNS.DecorationType.None);
            this.cbfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfullname.FormattingEnabled = true;
            this.cbfullname.Location = new System.Drawing.Point(25, 76);
            this.cbfullname.Name = "cbfullname";
            this.cbfullname.Size = new System.Drawing.Size(312, 32);
            this.cbfullname.TabIndex = 20;
            this.cbfullname.Text = "Select Employee";
            this.cbfullname.SelectedIndexChanged += new System.EventHandler(this.cbfullname_SelectedIndexChanged_1);
            this.cbfullname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbfullname_MouseClick);
            // 
            // btnupdatefn
            // 
            this.btnupdatefn.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnupdatefn.BackColor = System.Drawing.Color.DarkGreen;
            this.btnupdatefn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdatefn.BorderRadius = 5;
            this.btnupdatefn.ButtonText = "UPDATE";
            this.btnupdatefn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnupdatefn, BunifuAnimatorNS.DecorationType.None);
            this.btnupdatefn.DisabledColor = System.Drawing.Color.Gray;
            this.btnupdatefn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdatefn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnupdatefn.Iconimage")));
            this.btnupdatefn.Iconimage_right = null;
            this.btnupdatefn.Iconimage_right_Selected = null;
            this.btnupdatefn.Iconimage_Selected = null;
            this.btnupdatefn.IconMarginLeft = 0;
            this.btnupdatefn.IconMarginRight = 0;
            this.btnupdatefn.IconRightVisible = true;
            this.btnupdatefn.IconRightZoom = 0D;
            this.btnupdatefn.IconVisible = true;
            this.btnupdatefn.IconZoom = 60D;
            this.btnupdatefn.IsTab = false;
            this.btnupdatefn.Location = new System.Drawing.Point(215, 285);
            this.btnupdatefn.Name = "btnupdatefn";
            this.btnupdatefn.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnupdatefn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdatefn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdatefn.selected = false;
            this.btnupdatefn.Size = new System.Drawing.Size(120, 43);
            this.btnupdatefn.TabIndex = 22;
            this.btnupdatefn.Text = "UPDATE";
            this.btnupdatefn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdatefn.Textcolor = System.Drawing.Color.White;
            this.btnupdatefn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatefn.Click += new System.EventHandler(this.btnupdatefn_Click_1);
            // 
            // btnsavefn
            // 
            this.btnsavefn.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnsavefn.BackColor = System.Drawing.Color.DarkGreen;
            this.btnsavefn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsavefn.BorderRadius = 5;
            this.btnsavefn.ButtonText = "    ADD";
            this.btnsavefn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnsavefn, BunifuAnimatorNS.DecorationType.None);
            this.btnsavefn.DisabledColor = System.Drawing.Color.Gray;
            this.btnsavefn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsavefn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsavefn.Iconimage")));
            this.btnsavefn.Iconimage_right = null;
            this.btnsavefn.Iconimage_right_Selected = null;
            this.btnsavefn.Iconimage_Selected = null;
            this.btnsavefn.IconMarginLeft = 20;
            this.btnsavefn.IconMarginRight = 0;
            this.btnsavefn.IconRightVisible = true;
            this.btnsavefn.IconRightZoom = 0D;
            this.btnsavefn.IconVisible = true;
            this.btnsavefn.IconZoom = 60D;
            this.btnsavefn.IsTab = false;
            this.btnsavefn.Location = new System.Drawing.Point(32, 285);
            this.btnsavefn.Name = "btnsavefn";
            this.btnsavefn.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnsavefn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsavefn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsavefn.selected = false;
            this.btnsavefn.Size = new System.Drawing.Size(120, 43);
            this.btnsavefn.TabIndex = 22;
            this.btnsavefn.Text = "    ADD";
            this.btnsavefn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsavefn.Textcolor = System.Drawing.Color.White;
            this.btnsavefn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavefn.Click += new System.EventHandler(this.btnsavefn_Click_1);
            // 
            // tbfullname
            // 
            this.tbfullname.BackColor = System.Drawing.Color.White;
            this.tbfullname.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbfullname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbfullname.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tbfullname.BorderThickness = 3;
            this.tbfullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbfullname, BunifuAnimatorNS.DecorationType.None);
            this.tbfullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfullname.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbfullname.isPassword = false;
            this.tbfullname.Location = new System.Drawing.Point(24, 149);
            this.tbfullname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbfullname.Name = "tbfullname";
            this.tbfullname.Size = new System.Drawing.Size(313, 41);
            this.tbfullname.TabIndex = 21;
            this.tbfullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // deppanel
            // 
            this.deppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deppanel.Controls.Add(this.panel6);
            this.deppanel.Controls.Add(this.label2);
            this.deppanel.Controls.Add(this.cbdepartment);
            this.deppanel.Controls.Add(this.btnupdate5);
            this.deppanel.Controls.Add(this.btnsave5);
            this.deppanel.Controls.Add(this.tbdepartment);
            this.epeks.SetDecoration(this.deppanel, BunifuAnimatorNS.DecorationType.None);
            this.deppanel.Location = new System.Drawing.Point(202, 2);
            this.deppanel.Name = "deppanel";
            this.deppanel.Size = new System.Drawing.Size(373, 285);
            this.deppanel.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label1);
            this.epeks.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 36);
            this.panel6.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.epeks.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(114, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "DEPARTMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.epeks.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Department Name";
            // 
            // cbdepartment
            // 
            this.epeks.SetDecoration(this.cbdepartment, BunifuAnimatorNS.DecorationType.None);
            this.cbdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepartment.FormattingEnabled = true;
            this.cbdepartment.Location = new System.Drawing.Point(26, 76);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(310, 32);
            this.cbdepartment.TabIndex = 20;
            this.cbdepartment.Text = "Select Department";
            this.cbdepartment.SelectedIndexChanged += new System.EventHandler(this.cbdepartment_SelectedIndexChanged_1);
            this.cbdepartment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbdepartment_MouseClick);
            // 
            // btnupdate5
            // 
            this.btnupdate5.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnupdate5.BackColor = System.Drawing.Color.DarkGreen;
            this.btnupdate5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate5.BorderRadius = 5;
            this.btnupdate5.ButtonText = "UPDATE";
            this.btnupdate5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnupdate5, BunifuAnimatorNS.DecorationType.None);
            this.btnupdate5.DisabledColor = System.Drawing.Color.Gray;
            this.btnupdate5.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdate5.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnupdate5.Iconimage")));
            this.btnupdate5.Iconimage_right = null;
            this.btnupdate5.Iconimage_right_Selected = null;
            this.btnupdate5.Iconimage_Selected = null;
            this.btnupdate5.IconMarginLeft = 0;
            this.btnupdate5.IconMarginRight = 0;
            this.btnupdate5.IconRightVisible = true;
            this.btnupdate5.IconRightZoom = 0D;
            this.btnupdate5.IconVisible = true;
            this.btnupdate5.IconZoom = 60D;
            this.btnupdate5.IsTab = false;
            this.btnupdate5.Location = new System.Drawing.Point(214, 218);
            this.btnupdate5.Name = "btnupdate5";
            this.btnupdate5.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnupdate5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdate5.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdate5.selected = false;
            this.btnupdate5.Size = new System.Drawing.Size(120, 43);
            this.btnupdate5.TabIndex = 22;
            this.btnupdate5.Text = "UPDATE";
            this.btnupdate5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate5.Textcolor = System.Drawing.Color.White;
            this.btnupdate5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate5.Click += new System.EventHandler(this.btnupdate5_Click_1);
            // 
            // btnsave5
            // 
            this.btnsave5.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnsave5.BackColor = System.Drawing.Color.DarkGreen;
            this.btnsave5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave5.BorderRadius = 5;
            this.btnsave5.ButtonText = "    ADD";
            this.btnsave5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnsave5, BunifuAnimatorNS.DecorationType.None);
            this.btnsave5.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave5.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsave5.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsave5.Iconimage")));
            this.btnsave5.Iconimage_right = null;
            this.btnsave5.Iconimage_right_Selected = null;
            this.btnsave5.Iconimage_Selected = null;
            this.btnsave5.IconMarginLeft = 20;
            this.btnsave5.IconMarginRight = 0;
            this.btnsave5.IconRightVisible = true;
            this.btnsave5.IconRightZoom = 0D;
            this.btnsave5.IconVisible = true;
            this.btnsave5.IconZoom = 60D;
            this.btnsave5.IsTab = false;
            this.btnsave5.Location = new System.Drawing.Point(26, 218);
            this.btnsave5.Name = "btnsave5";
            this.btnsave5.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnsave5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave5.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsave5.selected = false;
            this.btnsave5.Size = new System.Drawing.Size(120, 43);
            this.btnsave5.TabIndex = 22;
            this.btnsave5.Text = "    ADD";
            this.btnsave5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave5.Textcolor = System.Drawing.Color.White;
            this.btnsave5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave5.Click += new System.EventHandler(this.btnsave5_Click_1);
            // 
            // tbdepartment
            // 
            this.tbdepartment.BackColor = System.Drawing.Color.White;
            this.tbdepartment.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbdepartment.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbdepartment.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tbdepartment.BorderThickness = 3;
            this.tbdepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbdepartment, BunifuAnimatorNS.DecorationType.None);
            this.tbdepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdepartment.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbdepartment.isPassword = false;
            this.tbdepartment.Location = new System.Drawing.Point(26, 148);
            this.tbdepartment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbdepartment.Name = "tbdepartment";
            this.tbdepartment.Size = new System.Drawing.Size(310, 41);
            this.tbdepartment.TabIndex = 21;
            this.tbdepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.btndep);
            this.panel9.Controls.Add(this.btnemp);
            this.panel9.Controls.Add(this.btnunit);
            this.panel9.Controls.Add(this.btnsup);
            this.panel9.Controls.Add(this.btncat);
            this.epeks.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.panel9.Location = new System.Drawing.Point(-1, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(182, 676);
            this.panel9.TabIndex = 34;
            // 
            // btndep
            // 
            this.btndep.Activecolor = System.Drawing.Color.LimeGreen;
            this.btndep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndep.BorderRadius = 0;
            this.btndep.ButtonText = "     Department";
            this.btndep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btndep, BunifuAnimatorNS.DecorationType.None);
            this.btndep.DisabledColor = System.Drawing.Color.Gray;
            this.btndep.Iconcolor = System.Drawing.Color.Transparent;
            this.btndep.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndep.Iconimage")));
            this.btndep.Iconimage_right = null;
            this.btndep.Iconimage_right_Selected = null;
            this.btndep.Iconimage_Selected = null;
            this.btndep.IconMarginLeft = 18;
            this.btndep.IconMarginRight = 0;
            this.btndep.IconRightVisible = true;
            this.btndep.IconRightZoom = 0D;
            this.btndep.IconVisible = true;
            this.btndep.IconZoom = 70D;
            this.btndep.IsTab = true;
            this.btndep.Location = new System.Drawing.Point(0, 194);
            this.btndep.Name = "btndep";
            this.btndep.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndep.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btndep.OnHoverTextColor = System.Drawing.Color.Green;
            this.btndep.selected = false;
            this.btndep.Size = new System.Drawing.Size(205, 40);
            this.btndep.TabIndex = 1;
            this.btndep.Text = "     Department";
            this.btndep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndep.Textcolor = System.Drawing.Color.White;
            this.btndep.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btnemp
            // 
            this.btnemp.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnemp.BorderRadius = 0;
            this.btnemp.ButtonText = "     Employee";
            this.btnemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnemp, BunifuAnimatorNS.DecorationType.None);
            this.btnemp.DisabledColor = System.Drawing.Color.Gray;
            this.btnemp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnemp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnemp.Iconimage")));
            this.btnemp.Iconimage_right = null;
            this.btnemp.Iconimage_right_Selected = null;
            this.btnemp.Iconimage_Selected = null;
            this.btnemp.IconMarginLeft = 18;
            this.btnemp.IconMarginRight = 0;
            this.btnemp.IconRightVisible = true;
            this.btnemp.IconRightZoom = 0D;
            this.btnemp.IconVisible = true;
            this.btnemp.IconZoom = 70D;
            this.btnemp.IsTab = true;
            this.btnemp.Location = new System.Drawing.Point(0, 148);
            this.btnemp.Name = "btnemp";
            this.btnemp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnemp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnemp.OnHoverTextColor = System.Drawing.Color.Green;
            this.btnemp.selected = false;
            this.btnemp.Size = new System.Drawing.Size(205, 40);
            this.btnemp.TabIndex = 1;
            this.btnemp.Text = "     Employee";
            this.btnemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemp.Textcolor = System.Drawing.Color.White;
            this.btnemp.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btnunit
            // 
            this.btnunit.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnunit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnunit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnunit.BorderRadius = 0;
            this.btnunit.ButtonText = "     Unit";
            this.btnunit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnunit, BunifuAnimatorNS.DecorationType.None);
            this.btnunit.DisabledColor = System.Drawing.Color.Gray;
            this.btnunit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnunit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnunit.Iconimage")));
            this.btnunit.Iconimage_right = null;
            this.btnunit.Iconimage_right_Selected = null;
            this.btnunit.Iconimage_Selected = null;
            this.btnunit.IconMarginLeft = 18;
            this.btnunit.IconMarginRight = 0;
            this.btnunit.IconRightVisible = true;
            this.btnunit.IconRightZoom = 0D;
            this.btnunit.IconVisible = true;
            this.btnunit.IconZoom = 70D;
            this.btnunit.IsTab = true;
            this.btnunit.Location = new System.Drawing.Point(0, 102);
            this.btnunit.Name = "btnunit";
            this.btnunit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnunit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnunit.OnHoverTextColor = System.Drawing.Color.Green;
            this.btnunit.selected = false;
            this.btnunit.Size = new System.Drawing.Size(205, 40);
            this.btnunit.TabIndex = 1;
            this.btnunit.Text = "     Unit";
            this.btnunit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnunit.Textcolor = System.Drawing.Color.White;
            this.btnunit.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunit.Click += new System.EventHandler(this.btnunit_Click);
            // 
            // btnsup
            // 
            this.btnsup.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnsup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsup.BorderRadius = 0;
            this.btnsup.ButtonText = "     Supplier";
            this.btnsup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnsup, BunifuAnimatorNS.DecorationType.None);
            this.btnsup.DisabledColor = System.Drawing.Color.Gray;
            this.btnsup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsup.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsup.Iconimage")));
            this.btnsup.Iconimage_right = null;
            this.btnsup.Iconimage_right_Selected = null;
            this.btnsup.Iconimage_Selected = null;
            this.btnsup.IconMarginLeft = 18;
            this.btnsup.IconMarginRight = 0;
            this.btnsup.IconRightVisible = true;
            this.btnsup.IconRightZoom = 0D;
            this.btnsup.IconVisible = true;
            this.btnsup.IconZoom = 70D;
            this.btnsup.IsTab = true;
            this.btnsup.Location = new System.Drawing.Point(0, 56);
            this.btnsup.Name = "btnsup";
            this.btnsup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsup.OnHoverTextColor = System.Drawing.Color.Green;
            this.btnsup.selected = false;
            this.btnsup.Size = new System.Drawing.Size(205, 40);
            this.btnsup.TabIndex = 1;
            this.btnsup.Text = "     Supplier";
            this.btnsup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsup.Textcolor = System.Drawing.Color.White;
            this.btnsup.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // btncat
            // 
            this.btncat.Activecolor = System.Drawing.Color.LimeGreen;
            this.btncat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncat.BorderRadius = 0;
            this.btncat.ButtonText = "     Category";
            this.btncat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btncat, BunifuAnimatorNS.DecorationType.None);
            this.btncat.DisabledColor = System.Drawing.Color.Gray;
            this.btncat.Iconcolor = System.Drawing.Color.Transparent;
            this.btncat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncat.Iconimage")));
            this.btncat.Iconimage_right = null;
            this.btncat.Iconimage_right_Selected = null;
            this.btncat.Iconimage_Selected = null;
            this.btncat.IconMarginLeft = 18;
            this.btncat.IconMarginRight = 0;
            this.btncat.IconRightVisible = true;
            this.btncat.IconRightZoom = 0D;
            this.btncat.IconVisible = true;
            this.btncat.IconZoom = 70D;
            this.btncat.IsTab = true;
            this.btncat.Location = new System.Drawing.Point(0, 10);
            this.btncat.Name = "btncat";
            this.btncat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncat.OnHoverTextColor = System.Drawing.Color.Green;
            this.btncat.selected = false;
            this.btncat.Size = new System.Drawing.Size(205, 40);
            this.btncat.TabIndex = 1;
            this.btncat.Text = "     Category";
            this.btncat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncat.Textcolor = System.Drawing.Color.White;
            this.btncat.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel26.ColumnCount = 4;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel26.Controls.Add(this.panel26, 1, 3);
            this.tableLayoutPanel26.Controls.Add(this.panel2, 2, 3);
            this.tableLayoutPanel26.Controls.Add(this.panel19, 1, 1);
            this.tableLayoutPanel26.Controls.Add(this.LVitem, 1, 2);
            this.tableLayoutPanel26.Controls.Add(this.panelitemedit, 2, 2);
            this.tableLayoutPanel26.Controls.Add(this.panel24, 2, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel26, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 4;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(1177, 617);
            this.tableLayoutPanel26.TabIndex = 118;
            this.tableLayoutPanel26.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel26_Paint);
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel26.Controls.Add(this.btn_update);
            this.epeks.SetDecoration(this.panel26, BunifuAnimatorNS.DecorationType.None);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(11, 562);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(731, 52);
            this.panel26.TabIndex = 111;
            // 
            // btn_update
            // 
            this.btn_update.Activecolor = System.Drawing.Color.LimeGreen;
            this.btn_update.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.BorderRadius = 5;
            this.btn_update.ButtonText = "     EDIT";
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_update, BunifuAnimatorNS.DecorationType.None);
            this.btn_update.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_update.Iconimage")));
            this.btn_update.Iconimage_right = null;
            this.btn_update.Iconimage_right_Selected = null;
            this.btn_update.Iconimage_Selected = null;
            this.btn_update.IconMarginLeft = 30;
            this.btn_update.IconMarginRight = 0;
            this.btn_update.IconRightVisible = true;
            this.btn_update.IconRightZoom = 0D;
            this.btn_update.IconVisible = true;
            this.btn_update.IconZoom = 60D;
            this.btn_update.IsTab = false;
            this.btn_update.Location = new System.Drawing.Point(4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btn_update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update.selected = false;
            this.btn_update.Size = new System.Drawing.Size(141, 43);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "     EDIT";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Textcolor = System.Drawing.Color.White;
            this.btn_update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.epeks.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(748, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 52);
            this.panel2.TabIndex = 140;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.LimeGreen;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 5;
            this.bunifuFlatButton3.ButtonText = "    UPDATE";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 20;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(253, 7);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(144, 43);
            this.bunifuFlatButton3.TabIndex = 139;
            this.bunifuFlatButton3.Text = "    UPDATE";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click_1);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Green;
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Controls.Add(this.tb_search);
            this.panel19.Controls.Add(this.isearch);
            this.epeks.SetDecoration(this.panel19, BunifuAnimatorNS.DecorationType.None);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(11, 12);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(731, 52);
            this.panel19.TabIndex = 111;
            // 
            // tb_search
            // 
            this.tb_search.AllowDrop = true;
            this.tb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tb_search.BackColor = System.Drawing.Color.White;
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epeks.SetDecoration(this.tb_search, BunifuAnimatorNS.DecorationType.None);
            this.tb_search.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_search.Location = new System.Drawing.Point(80, 6);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(368, 39);
            this.tb_search.TabIndex = 107;
            this.tb_search.Text = "search";
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            this.tb_search.Enter += new System.EventHandler(this.tb_search_Enter);
            this.tb_search.Leave += new System.EventHandler(this.tb_search_Leave);
            // 
            // isearch
            // 
            this.epeks.SetDecoration(this.isearch, BunifuAnimatorNS.DecorationType.None);
            this.isearch.Image = ((System.Drawing.Image)(resources.GetObject("isearch.Image")));
            this.isearch.Location = new System.Drawing.Point(33, 10);
            this.isearch.Name = "isearch";
            this.isearch.Size = new System.Drawing.Size(41, 34);
            this.isearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.isearch.TabIndex = 108;
            this.isearch.TabStop = false;
            // 
            // LVitem
            // 
            this.LVitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader84,
            this.columnHeader85,
            this.columnHeader86,
            this.columnHeader87,
            this.columnHeader42,
            this.columnHeader97});
            this.epeks.SetDecoration(this.LVitem, BunifuAnimatorNS.DecorationType.None);
            this.LVitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVitem.FullRowSelect = true;
            this.LVitem.GridLines = true;
            this.LVitem.HideSelection = false;
            this.LVitem.Location = new System.Drawing.Point(11, 70);
            this.LVitem.Name = "LVitem";
            this.LVitem.Size = new System.Drawing.Size(731, 486);
            this.LVitem.TabIndex = 113;
            this.LVitem.UseCompatibleStateImageBehavior = false;
            this.LVitem.View = System.Windows.Forms.View.Details;
            this.LVitem.SelectedIndexChanged += new System.EventHandler(this.LVitem_SelectedIndexChanged);
            this.LVitem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVitem_MouseClick);
            // 
            // columnHeader84
            // 
            this.columnHeader84.Text = "ITEM #";
            this.columnHeader84.Width = 80;
            // 
            // columnHeader85
            // 
            this.columnHeader85.Text = "DESCRIPTION";
            this.columnHeader85.Width = 170;
            // 
            // columnHeader86
            // 
            this.columnHeader86.Text = "SUPPLIER";
            this.columnHeader86.Width = 170;
            // 
            // columnHeader87
            // 
            this.columnHeader87.Text = "CATEGORY";
            this.columnHeader87.Width = 170;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "UNIT";
            this.columnHeader42.Width = 170;
            // 
            // columnHeader97
            // 
            this.columnHeader97.Text = "UNIT PRICE";
            this.columnHeader97.Width = 100;
            // 
            // panelitemedit
            // 
            this.panelitemedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelitemedit.Controls.Add(this.label58);
            this.panelitemedit.Controls.Add(this.cbSupplier);
            this.panelitemedit.Controls.Add(this.cbitemcat);
            this.panelitemedit.Controls.Add(this.comboBox2);
            this.panelitemedit.Controls.Add(this.comboBox3);
            this.panelitemedit.Controls.Add(this.comboBox4);
            this.panelitemedit.Controls.Add(this.label63);
            this.panelitemedit.Controls.Add(this.editUnitPrice);
            this.panelitemedit.Controls.Add(this.tbname);
            this.panelitemedit.Controls.Add(this.label104);
            this.panelitemedit.Controls.Add(this.tbitemid);
            this.panelitemedit.Controls.Add(this.label64);
            this.panelitemedit.Controls.Add(this.label65);
            this.panelitemedit.Controls.Add(this.label66);
            this.epeks.SetDecoration(this.panelitemedit, BunifuAnimatorNS.DecorationType.None);
            this.panelitemedit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelitemedit.Location = new System.Drawing.Point(748, 70);
            this.panelitemedit.Name = "panelitemedit";
            this.panelitemedit.Size = new System.Drawing.Size(406, 486);
            this.panelitemedit.TabIndex = 114;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.epeks.SetDecoration(this.label58, BunifuAnimatorNS.DecorationType.None);
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.DarkGreen;
            this.label58.Location = new System.Drawing.Point(45, 416);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(92, 20);
            this.label58.TabIndex = 139;
            this.label58.Text = "Unit Price:";
            // 
            // cbSupplier
            // 
            this.epeks.SetDecoration(this.cbSupplier, BunifuAnimatorNS.DecorationType.None);
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(46, 231);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(310, 28);
            this.cbSupplier.TabIndex = 129;
            this.cbSupplier.Text = "Select Supplier";
            // 
            // cbitemcat
            // 
            this.epeks.SetDecoration(this.cbitemcat, BunifuAnimatorNS.DecorationType.None);
            this.cbitemcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbitemcat.FormattingEnabled = true;
            this.cbitemcat.Location = new System.Drawing.Point(47, 305);
            this.cbitemcat.Name = "cbitemcat";
            this.cbitemcat.Size = new System.Drawing.Size(310, 28);
            this.cbitemcat.TabIndex = 129;
            this.cbitemcat.Text = "Select Item Category";
            // 
            // comboBox2
            // 
            this.epeks.SetDecoration(this.comboBox2, BunifuAnimatorNS.DecorationType.None);
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(276, 371);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 28);
            this.comboBox2.TabIndex = 130;
            this.comboBox2.Text = "Select";
            // 
            // comboBox3
            // 
            this.epeks.SetDecoration(this.comboBox3, BunifuAnimatorNS.DecorationType.None);
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(188, 371);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(82, 28);
            this.comboBox3.TabIndex = 131;
            this.comboBox3.Text = "Select";
            // 
            // comboBox4
            // 
            this.epeks.SetDecoration(this.comboBox4, BunifuAnimatorNS.DecorationType.None);
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(49, 371);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(133, 28);
            this.comboBox4.TabIndex = 132;
            this.comboBox4.Text = "Select";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.epeks.SetDecoration(this.label63, BunifuAnimatorNS.DecorationType.None);
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.DarkGreen;
            this.label63.Location = new System.Drawing.Point(46, 348);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(47, 20);
            this.label63.TabIndex = 138;
            this.label63.Text = "Unit:";
            // 
            // editUnitPrice
            // 
            this.editUnitPrice.BackColor = System.Drawing.Color.White;
            this.editUnitPrice.BorderColorFocused = System.Drawing.Color.Lime;
            this.editUnitPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.editUnitPrice.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.editUnitPrice.BorderThickness = 3;
            this.editUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.editUnitPrice, BunifuAnimatorNS.DecorationType.None);
            this.editUnitPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUnitPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.editUnitPrice.isPassword = false;
            this.editUnitPrice.Location = new System.Drawing.Point(46, 442);
            this.editUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.editUnitPrice.Name = "editUnitPrice";
            this.editUnitPrice.Size = new System.Drawing.Size(314, 44);
            this.editUnitPrice.TabIndex = 134;
            this.editUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.Color.White;
            this.tbname.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbname.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tbname.BorderThickness = 3;
            this.tbname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbname, BunifuAnimatorNS.DecorationType.None);
            this.tbname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbname.isPassword = false;
            this.tbname.Location = new System.Drawing.Point(46, 144);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(310, 44);
            this.tbname.TabIndex = 134;
            this.tbname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.epeks.SetDecoration(this.label104, BunifuAnimatorNS.DecorationType.None);
            this.label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.ForeColor = System.Drawing.Color.DarkGreen;
            this.label104.Location = new System.Drawing.Point(41, 207);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(80, 20);
            this.label104.TabIndex = 135;
            this.label104.Text = "Supplier:";
            // 
            // tbitemid
            // 
            this.tbitemid.BackColor = System.Drawing.Color.White;
            this.tbitemid.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbitemid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbitemid.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tbitemid.BorderThickness = 3;
            this.tbitemid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbitemid, BunifuAnimatorNS.DecorationType.None);
            this.tbitemid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbitemid.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbitemid.isPassword = false;
            this.tbitemid.Location = new System.Drawing.Point(46, 55);
            this.tbitemid.Margin = new System.Windows.Forms.Padding(4);
            this.tbitemid.Name = "tbitemid";
            this.tbitemid.Size = new System.Drawing.Size(311, 44);
            this.tbitemid.TabIndex = 133;
            this.tbitemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.epeks.SetDecoration(this.label64, BunifuAnimatorNS.DecorationType.None);
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.DarkGreen;
            this.label64.Location = new System.Drawing.Point(42, 281);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(86, 20);
            this.label64.TabIndex = 135;
            this.label64.Text = "Category:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.epeks.SetDecoration(this.label65, BunifuAnimatorNS.DecorationType.None);
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.DarkGreen;
            this.label65.Location = new System.Drawing.Point(42, 122);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(127, 20);
            this.label65.TabIndex = 136;
            this.label65.Text = "Product Name:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.epeks.SetDecoration(this.label66, BunifuAnimatorNS.DecorationType.None);
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.DarkGreen;
            this.label66.Location = new System.Drawing.Point(42, 32);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(100, 20);
            this.label66.TabIndex = 137;
            this.label66.Text = "Product ID:";
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.Green;
            this.panel24.Controls.Add(this.label67);
            this.epeks.SetDecoration(this.panel24, BunifuAnimatorNS.DecorationType.None);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(748, 12);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(406, 52);
            this.panel24.TabIndex = 115;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.epeks.SetDecoration(this.label67, BunifuAnimatorNS.DecorationType.None);
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(43, 16);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(136, 24);
            this.label67.TabIndex = 1;
            this.label67.Text = "UPDATE ITEM";
            // 
            // panelpassword
            // 
            this.panelpassword.BackColor = System.Drawing.Color.Green;
            this.panelpassword.Controls.Add(this.cshow);
            this.panelpassword.Controls.Add(this.Blog);
            this.epeks.SetDecoration(this.panelpassword, BunifuAnimatorNS.DecorationType.None);
            this.panelpassword.Location = new System.Drawing.Point(25, 361);
            this.panelpassword.Name = "panelpassword";
            this.panelpassword.Size = new System.Drawing.Size(484, 244);
            this.panelpassword.TabIndex = 116;
            // 
            // cshow
            // 
            this.cshow.AutoSize = true;
            this.epeks.SetDecoration(this.cshow, BunifuAnimatorNS.DecorationType.None);
            this.cshow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cshow.ForeColor = System.Drawing.Color.Lavender;
            this.cshow.Location = new System.Drawing.Point(88, 16);
            this.cshow.Name = "cshow";
            this.cshow.Size = new System.Drawing.Size(110, 20);
            this.cshow.TabIndex = 34;
            this.cshow.Text = "show password";
            this.cshow.ThreeState = true;
            this.cshow.UseVisualStyleBackColor = false;
            this.cshow.CheckedChanged += new System.EventHandler(this.cshow_CheckedChanged);
            // 
            // Blog
            // 
            this.Blog.Activecolor = System.Drawing.Color.LimeGreen;
            this.Blog.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Blog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Blog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Blog.BorderRadius = 2;
            this.Blog.ButtonText = "Verify";
            this.Blog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.Blog, BunifuAnimatorNS.DecorationType.None);
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
            this.Blog.Location = new System.Drawing.Point(85, 45);
            this.Blog.Name = "Blog";
            this.Blog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Blog.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.Blog.OnHoverTextColor = System.Drawing.Color.DarkGreen;
            this.Blog.selected = false;
            this.Blog.Size = new System.Drawing.Size(313, 46);
            this.Blog.TabIndex = 33;
            this.Blog.Text = "Verify";
            this.Blog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Blog.Textcolor = System.Drawing.Color.White;
            this.Blog.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Green;
            this.panel16.Controls.Add(this.savePassword);
            this.panel16.Controls.Add(this.label10);
            this.panel16.Controls.Add(this.tcpw);
            this.panel16.Controls.Add(this.tnpw);
            this.panel16.Controls.Add(this.pictureBox6);
            this.panel16.Controls.Add(this.pictureBox4);
            this.panel16.Controls.Add(this.pictureBox5);
            this.panel16.Controls.Add(this.pictureBox3);
            this.panel16.Controls.Add(this.pictureBox1);
            this.panel16.Controls.Add(this.tpw);
            this.panel16.Controls.Add(this.tun);
            this.panel16.Controls.Add(this.shownew);
            this.panel16.Controls.Add(this.getid);
            this.epeks.SetDecoration(this.panel16, BunifuAnimatorNS.DecorationType.None);
            this.panel16.Location = new System.Drawing.Point(25, 29);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(484, 576);
            this.panel16.TabIndex = 0;
            // 
            // savePassword
            // 
            this.savePassword.Activecolor = System.Drawing.Color.LimeGreen;
            this.savePassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.savePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.savePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savePassword.BorderRadius = 2;
            this.savePassword.ButtonText = "Save";
            this.savePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.savePassword, BunifuAnimatorNS.DecorationType.None);
            this.savePassword.DisabledColor = System.Drawing.Color.Gray;
            this.savePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.savePassword.Iconimage = null;
            this.savePassword.Iconimage_right = null;
            this.savePassword.Iconimage_right_Selected = null;
            this.savePassword.Iconimage_Selected = null;
            this.savePassword.IconMarginLeft = 0;
            this.savePassword.IconMarginRight = 0;
            this.savePassword.IconRightVisible = true;
            this.savePassword.IconRightZoom = 0D;
            this.savePassword.IconVisible = true;
            this.savePassword.IconZoom = 60D;
            this.savePassword.IsTab = false;
            this.savePassword.Location = new System.Drawing.Point(88, 500);
            this.savePassword.Name = "savePassword";
            this.savePassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.savePassword.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.savePassword.OnHoverTextColor = System.Drawing.Color.DarkGreen;
            this.savePassword.selected = false;
            this.savePassword.Size = new System.Drawing.Size(310, 46);
            this.savePassword.TabIndex = 33;
            this.savePassword.Text = "Save";
            this.savePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savePassword.Textcolor = System.Drawing.Color.White;
            this.savePassword.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePassword.Click += new System.EventHandler(this.savePassword_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.epeks.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(4, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 24);
            this.label10.TabIndex = 114;
            this.label10.Text = "Change Password:";
            // 
            // tcpw
            // 
            this.tcpw.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.tcpw.BorderColorIdle = System.Drawing.Color.Lavender;
            this.tcpw.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.tcpw.BorderThickness = 3;
            this.tcpw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tcpw, BunifuAnimatorNS.DecorationType.None);
            this.tcpw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpw.ForeColor = System.Drawing.Color.Lavender;
            this.tcpw.isPassword = true;
            this.tcpw.Location = new System.Drawing.Point(123, 435);
            this.tcpw.Margin = new System.Windows.Forms.Padding(4);
            this.tcpw.Name = "tcpw";
            this.tcpw.Size = new System.Drawing.Size(276, 43);
            this.tcpw.TabIndex = 4;
            this.tcpw.Text = "Confirm new Password";
            this.tcpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tcpw.Enter += new System.EventHandler(this.tcpw_Enter);
            this.tcpw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcpw_KeyDown);
            this.tcpw.Leave += new System.EventHandler(this.tcpw_Leave);
            // 
            // tnpw
            // 
            this.tnpw.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.tnpw.BorderColorIdle = System.Drawing.Color.Lavender;
            this.tnpw.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.tnpw.BorderThickness = 3;
            this.tnpw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tnpw, BunifuAnimatorNS.DecorationType.None);
            this.tnpw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnpw.ForeColor = System.Drawing.Color.Lavender;
            this.tnpw.isPassword = true;
            this.tnpw.Location = new System.Drawing.Point(125, 348);
            this.tnpw.Margin = new System.Windows.Forms.Padding(4);
            this.tnpw.Name = "tnpw";
            this.tnpw.Size = new System.Drawing.Size(274, 43);
            this.tnpw.TabIndex = 3;
            this.tnpw.Text = "Enter new Password";
            this.tnpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tnpw.Enter += new System.EventHandler(this.tnpw_Enter);
            this.tnpw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tnpw_KeyDown);
            this.tnpw.Leave += new System.EventHandler(this.tnpw_Leave);
            // 
            // pictureBox6
            // 
            this.epeks.SetDecoration(this.pictureBox6, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(87, 438);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.epeks.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(168, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(147, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.epeks.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(88, 353);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.epeks.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(88, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.epeks.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // tpw
            // 
            this.tpw.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.tpw.BorderColorIdle = System.Drawing.Color.Lavender;
            this.tpw.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.tpw.BorderThickness = 3;
            this.tpw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tpw, BunifuAnimatorNS.DecorationType.None);
            this.tpw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpw.ForeColor = System.Drawing.Color.Lavender;
            this.tpw.isPassword = false;
            this.tpw.Location = new System.Drawing.Point(124, 287);
            this.tpw.Margin = new System.Windows.Forms.Padding(4);
            this.tpw.Name = "tpw";
            this.tpw.Size = new System.Drawing.Size(274, 43);
            this.tpw.TabIndex = 2;
            this.tpw.Text = "Enter old Password";
            this.tpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tpw.OnValueChanged += new System.EventHandler(this.tpw_OnValueChanged);
            this.tpw.Enter += new System.EventHandler(this.tpw_Enter);
            this.tpw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tpw_KeyDown_1);
            this.tpw.Leave += new System.EventHandler(this.tpw_Leave);
            // 
            // tun
            // 
            this.tun.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.tun.BorderColorIdle = System.Drawing.Color.Lavender;
            this.tun.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.tun.BorderThickness = 3;
            this.tun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tun, BunifuAnimatorNS.DecorationType.None);
            this.tun.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tun.ForeColor = System.Drawing.Color.Lavender;
            this.tun.isPassword = false;
            this.tun.Location = new System.Drawing.Point(124, 226);
            this.tun.Margin = new System.Windows.Forms.Padding(4);
            this.tun.Name = "tun";
            this.tun.Size = new System.Drawing.Size(274, 43);
            this.tun.TabIndex = 1;
            this.tun.Text = "Enter your Username";
            this.tun.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tun.Enter += new System.EventHandler(this.tun_Enter);
            this.tun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tun_KeyDown);
            this.tun.Leave += new System.EventHandler(this.tun_Leave);
            // 
            // shownew
            // 
            this.shownew.AutoSize = true;
            this.epeks.SetDecoration(this.shownew, BunifuAnimatorNS.DecorationType.None);
            this.shownew.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shownew.ForeColor = System.Drawing.Color.Lavender;
            this.shownew.Location = new System.Drawing.Point(88, 404);
            this.shownew.Name = "shownew";
            this.shownew.Size = new System.Drawing.Size(137, 20);
            this.shownew.TabIndex = 34;
            this.shownew.Text = "show new password";
            this.shownew.ThreeState = true;
            this.shownew.UseVisualStyleBackColor = false;
            this.shownew.CheckedChanged += new System.EventHandler(this.shownew_CheckedChanged);
            this.shownew.CheckStateChanged += new System.EventHandler(this.shownew_CheckStateChanged);
            // 
            // getid
            // 
            this.getid.AutoSize = true;
            this.epeks.SetDecoration(this.getid, BunifuAnimatorNS.DecorationType.None);
            this.getid.Location = new System.Drawing.Point(207, 168);
            this.getid.Name = "getid";
            this.getid.Size = new System.Drawing.Size(41, 13);
            this.getid.TabIndex = 115;
            this.getid.Text = "label11";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.680067F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.31993F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1177, 617);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.tableLayoutPanel9);
            this.epeks.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(68, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 577);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.label37, 1, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel9, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.197134F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.80286F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(658, 577);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.62576F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.37424F));
            this.tableLayoutPanel10.Controls.Add(this.panel12, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel15, 0, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel10, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.11215F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(650, 530);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel12.Controls.Add(this.checkBox1);
            this.panel12.Controls.Add(this.cgender);
            this.panel12.Controls.Add(this.ctitle);
            this.panel12.Controls.Add(this.tempid);
            this.panel12.Controls.Add(this.tfn);
            this.panel12.Controls.Add(this.tusername);
            this.panel12.Controls.Add(this.tln);
            this.panel12.Controls.Add(this.tpassword);
            this.panel12.Controls.Add(this.tmn);
            this.panel12.Controls.Add(this.saveUser);
            this.epeks.SetDecoration(this.panel12, BunifuAnimatorNS.DecorationType.None);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(247, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(400, 524);
            this.panel12.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.epeks.SetDecoration(this.checkBox1, BunifuAnimatorNS.DecorationType.None);
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(33, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "show password";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cgender
            // 
            this.epeks.SetDecoration(this.cgender, BunifuAnimatorNS.DecorationType.None);
            this.cgender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cgender.FormattingEnabled = true;
            this.cgender.ItemHeight = 23;
            this.cgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Confirm"});
            this.cgender.Location = new System.Drawing.Point(33, 410);
            this.cgender.Name = "cgender";
            this.cgender.PromptText = "Unknown";
            this.cgender.Size = new System.Drawing.Size(324, 29);
            this.cgender.TabIndex = 8;
            this.cgender.UseSelectable = true;
            // 
            // ctitle
            // 
            this.epeks.SetDecoration(this.ctitle, BunifuAnimatorNS.DecorationType.None);
            this.ctitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctitle.FormattingEnabled = true;
            this.ctitle.ItemHeight = 23;
            this.ctitle.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.ctitle.Location = new System.Drawing.Point(33, 364);
            this.ctitle.Name = "ctitle";
            this.ctitle.PromptText = "--------------Select Title or Position-------------";
            this.ctitle.Size = new System.Drawing.Size(324, 29);
            this.ctitle.TabIndex = 7;
            this.ctitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ctitle.UseSelectable = true;
            // 
            // tempid
            // 
            this.tempid.BackColor = System.Drawing.Color.White;
            this.tempid.BorderColorFocused = System.Drawing.Color.Lime;
            this.tempid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tempid.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tempid.BorderThickness = 3;
            this.tempid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tempid, BunifuAnimatorNS.DecorationType.None);
            this.tempid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempid.ForeColor = System.Drawing.Color.DarkGreen;
            this.tempid.isPassword = false;
            this.tempid.Location = new System.Drawing.Point(33, 16);
            this.tempid.Margin = new System.Windows.Forms.Padding(4);
            this.tempid.Name = "tempid";
            this.tempid.Size = new System.Drawing.Size(322, 43);
            this.tempid.TabIndex = 1;
            this.tempid.Text = "blank";
            this.tempid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tfn
            // 
            this.tfn.BackColor = System.Drawing.Color.White;
            this.tfn.BorderColorFocused = System.Drawing.Color.Lime;
            this.tfn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tfn.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tfn.BorderThickness = 3;
            this.tfn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tfn, BunifuAnimatorNS.DecorationType.None);
            this.tfn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfn.ForeColor = System.Drawing.Color.DarkGreen;
            this.tfn.isPassword = false;
            this.tfn.Location = new System.Drawing.Point(33, 200);
            this.tfn.Margin = new System.Windows.Forms.Padding(4);
            this.tfn.Name = "tfn";
            this.tfn.Size = new System.Drawing.Size(324, 43);
            this.tfn.TabIndex = 4;
            this.tfn.Text = "blank";
            this.tfn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tfn.Enter += new System.EventHandler(this.tfn_Enter);
            this.tfn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfn_KeyDown);
            this.tfn.Leave += new System.EventHandler(this.tfn_Leave);
            // 
            // tusername
            // 
            this.tusername.BackColor = System.Drawing.Color.White;
            this.tusername.BorderColorFocused = System.Drawing.Color.Lime;
            this.tusername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tusername.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tusername.BorderThickness = 3;
            this.tusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tusername, BunifuAnimatorNS.DecorationType.None);
            this.tusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusername.ForeColor = System.Drawing.Color.DarkGreen;
            this.tusername.isPassword = false;
            this.tusername.Location = new System.Drawing.Point(33, 70);
            this.tusername.Margin = new System.Windows.Forms.Padding(4);
            this.tusername.Name = "tusername";
            this.tusername.Size = new System.Drawing.Size(324, 43);
            this.tusername.TabIndex = 2;
            this.tusername.Text = "blank";
            this.tusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tusername.Enter += new System.EventHandler(this.tusername_Enter);
            this.tusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tusername_KeyDown);
            this.tusername.Leave += new System.EventHandler(this.tusername_Leave);
            // 
            // tln
            // 
            this.tln.BackColor = System.Drawing.Color.White;
            this.tln.BorderColorFocused = System.Drawing.Color.Lime;
            this.tln.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tln.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tln.BorderThickness = 3;
            this.tln.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tln, BunifuAnimatorNS.DecorationType.None);
            this.tln.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tln.ForeColor = System.Drawing.Color.DarkGreen;
            this.tln.isPassword = false;
            this.tln.Location = new System.Drawing.Point(33, 305);
            this.tln.Margin = new System.Windows.Forms.Padding(4);
            this.tln.Name = "tln";
            this.tln.Size = new System.Drawing.Size(324, 43);
            this.tln.TabIndex = 6;
            this.tln.Text = "blank";
            this.tln.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tln.Enter += new System.EventHandler(this.tln_Enter);
            this.tln.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tln_KeyDown);
            this.tln.Leave += new System.EventHandler(this.tln_Leave);
            // 
            // tpassword
            // 
            this.tpassword.BackColor = System.Drawing.Color.White;
            this.tpassword.BorderColorFocused = System.Drawing.Color.Lime;
            this.tpassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tpassword.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tpassword.BorderThickness = 3;
            this.tpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tpassword, BunifuAnimatorNS.DecorationType.None);
            this.tpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpassword.ForeColor = System.Drawing.Color.DarkGreen;
            this.tpassword.isPassword = true;
            this.tpassword.Location = new System.Drawing.Point(33, 123);
            this.tpassword.Margin = new System.Windows.Forms.Padding(4);
            this.tpassword.Name = "tpassword";
            this.tpassword.Size = new System.Drawing.Size(324, 43);
            this.tpassword.TabIndex = 3;
            this.tpassword.Text = "blank";
            this.tpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tpassword.Enter += new System.EventHandler(this.tpassword_Enter);
            this.tpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tpassword_KeyDown);
            this.tpassword.Leave += new System.EventHandler(this.tpassword_Leave);
            // 
            // tmn
            // 
            this.tmn.BackColor = System.Drawing.Color.White;
            this.tmn.BorderColorFocused = System.Drawing.Color.Lime;
            this.tmn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tmn.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.tmn.BorderThickness = 3;
            this.tmn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tmn, BunifuAnimatorNS.DecorationType.None);
            this.tmn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmn.ForeColor = System.Drawing.Color.DarkGreen;
            this.tmn.isPassword = false;
            this.tmn.Location = new System.Drawing.Point(33, 252);
            this.tmn.Margin = new System.Windows.Forms.Padding(4);
            this.tmn.Name = "tmn";
            this.tmn.Size = new System.Drawing.Size(324, 43);
            this.tmn.TabIndex = 5;
            this.tmn.Text = "blank";
            this.tmn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tmn.Enter += new System.EventHandler(this.tmn_Enter);
            this.tmn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tmn_KeyDown);
            this.tmn.Leave += new System.EventHandler(this.tmn_Leave);
            // 
            // saveUser
            // 
            this.saveUser.Activecolor = System.Drawing.Color.LimeGreen;
            this.saveUser.BackColor = System.Drawing.Color.Green;
            this.saveUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveUser.BorderRadius = 5;
            this.saveUser.ButtonText = "   SAVE";
            this.saveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.saveUser, BunifuAnimatorNS.DecorationType.None);
            this.saveUser.DisabledColor = System.Drawing.Color.Gray;
            this.saveUser.Iconcolor = System.Drawing.Color.Transparent;
            this.saveUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveUser.Iconimage")));
            this.saveUser.Iconimage_right = null;
            this.saveUser.Iconimage_right_Selected = null;
            this.saveUser.Iconimage_Selected = null;
            this.saveUser.IconMarginLeft = 0;
            this.saveUser.IconMarginRight = 0;
            this.saveUser.IconRightVisible = true;
            this.saveUser.IconRightZoom = 0D;
            this.saveUser.IconVisible = true;
            this.saveUser.IconZoom = 60D;
            this.saveUser.IsTab = false;
            this.saveUser.Location = new System.Drawing.Point(187, 457);
            this.saveUser.Name = "saveUser";
            this.saveUser.Normalcolor = System.Drawing.Color.Green;
            this.saveUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.saveUser.OnHoverTextColor = System.Drawing.Color.White;
            this.saveUser.selected = false;
            this.saveUser.Size = new System.Drawing.Size(166, 45);
            this.saveUser.TabIndex = 10;
            this.saveUser.Text = "   SAVE";
            this.saveUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveUser.Textcolor = System.Drawing.Color.White;
            this.saveUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUser.Click += new System.EventHandler(this.saveUser_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel15.Controls.Add(this.label26);
            this.panel15.Controls.Add(this.label29);
            this.panel15.Controls.Add(this.label30);
            this.panel15.Controls.Add(this.label31);
            this.panel15.Controls.Add(this.label33);
            this.panel15.Controls.Add(this.label34);
            this.panel15.Controls.Add(this.label35);
            this.panel15.Controls.Add(this.label36);
            this.epeks.SetDecoration(this.panel15, BunifuAnimatorNS.DecorationType.None);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(3, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(238, 524);
            this.panel15.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.epeks.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label26.ForeColor = System.Drawing.Color.DarkGreen;
            this.label26.Location = new System.Drawing.Point(105, 407);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 24);
            this.label26.TabIndex = 113;
            this.label26.Text = "Gender:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.epeks.SetDecoration(this.label29, BunifuAnimatorNS.DecorationType.None);
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label29.ForeColor = System.Drawing.Color.DarkGreen;
            this.label29.Location = new System.Drawing.Point(105, 317);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 24);
            this.label29.TabIndex = 113;
            this.label29.Text = "Last Name:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.epeks.SetDecoration(this.label30, BunifuAnimatorNS.DecorationType.None);
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label30.ForeColor = System.Drawing.Color.DarkGreen;
            this.label30.Location = new System.Drawing.Point(105, 24);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(135, 24);
            this.label30.TabIndex = 113;
            this.label30.Text = "Employee ID:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.epeks.SetDecoration(this.label31, BunifuAnimatorNS.DecorationType.None);
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label31.ForeColor = System.Drawing.Color.DarkGreen;
            this.label31.Location = new System.Drawing.Point(105, 80);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(111, 24);
            this.label31.TabIndex = 113;
            this.label31.Text = "Username:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.epeks.SetDecoration(this.label33, BunifuAnimatorNS.DecorationType.None);
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label33.ForeColor = System.Drawing.Color.DarkGreen;
            this.label33.Location = new System.Drawing.Point(105, 207);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(117, 24);
            this.label33.TabIndex = 113;
            this.label33.Text = "First Name:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.epeks.SetDecoration(this.label34, BunifuAnimatorNS.DecorationType.None);
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label34.ForeColor = System.Drawing.Color.DarkGreen;
            this.label34.Location = new System.Drawing.Point(105, 363);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 24);
            this.label34.TabIndex = 113;
            this.label34.Text = "Title:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.epeks.SetDecoration(this.label35, BunifuAnimatorNS.DecorationType.None);
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label35.ForeColor = System.Drawing.Color.DarkGreen;
            this.label35.Location = new System.Drawing.Point(105, 260);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(140, 24);
            this.label35.TabIndex = 113;
            this.label35.Text = "Middle Name:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.epeks.SetDecoration(this.label36, BunifuAnimatorNS.DecorationType.None);
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label36.ForeColor = System.Drawing.Color.DarkGreen;
            this.label36.Location = new System.Drawing.Point(105, 133);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 24);
            this.label36.TabIndex = 113;
            this.label36.Text = "password:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.epeks.SetDecoration(this.label37, BunifuAnimatorNS.DecorationType.None);
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label37.Location = new System.Drawing.Point(4, 10);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(176, 24);
            this.label37.TabIndex = 113;
            this.label37.Text = "ADD EMPLOYEE:";
            // 
            // p_rsales
            // 
            this.p_rsales.Controls.Add(this.p_returned_med);
            this.p_rsales.Controls.Add(this.tableLayoutPanel8);
            this.epeks.SetDecoration(this.p_rsales, BunifuAnimatorNS.DecorationType.None);
            this.p_rsales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_rsales.Location = new System.Drawing.Point(0, 0);
            this.p_rsales.Name = "p_rsales";
            this.p_rsales.Size = new System.Drawing.Size(1177, 617);
            this.p_rsales.TabIndex = 4;
            // 
            // p_returned_med
            // 
            this.p_returned_med.Controls.Add(this.p_invmed);
            this.p_returned_med.Controls.Add(this.RTable);
            this.epeks.SetDecoration(this.p_returned_med, BunifuAnimatorNS.DecorationType.None);
            this.p_returned_med.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_returned_med.Location = new System.Drawing.Point(0, 0);
            this.p_returned_med.Name = "p_returned_med";
            this.p_returned_med.Size = new System.Drawing.Size(1177, 617);
            this.p_returned_med.TabIndex = 142;
            // 
            // p_invmed
            // 
            this.p_invmed.Controls.Add(this.p_unusedstocks);
            this.p_invmed.Controls.Add(this.PMtable);
            this.epeks.SetDecoration(this.p_invmed, BunifuAnimatorNS.DecorationType.None);
            this.p_invmed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_invmed.Location = new System.Drawing.Point(0, 0);
            this.p_invmed.Name = "p_invmed";
            this.p_invmed.Size = new System.Drawing.Size(1177, 617);
            this.p_invmed.TabIndex = 143;
            // 
            // p_unusedstocks
            // 
            this.p_unusedstocks.Controls.Add(this.p_expired);
            this.p_unusedstocks.Controls.Add(this.tb_generatedLogs);
            this.epeks.SetDecoration(this.p_unusedstocks, BunifuAnimatorNS.DecorationType.None);
            this.p_unusedstocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_unusedstocks.Location = new System.Drawing.Point(0, 0);
            this.p_unusedstocks.Name = "p_unusedstocks";
            this.p_unusedstocks.Size = new System.Drawing.Size(1177, 617);
            this.p_unusedstocks.TabIndex = 144;
            // 
            // p_expired
            // 
            this.p_expired.Controls.Add(this.panel_recap);
            this.p_expired.Controls.Add(this.tableLayoutPanel22);
            this.p_expired.Controls.Add(this.p_HistoryLogs);
            this.p_expired.Controls.Add(this.p_damageMed);
            this.epeks.SetDecoration(this.p_expired, BunifuAnimatorNS.DecorationType.None);
            this.p_expired.Location = new System.Drawing.Point(1048, 516);
            this.p_expired.Name = "p_expired";
            this.p_expired.Size = new System.Drawing.Size(129, 101);
            this.p_expired.TabIndex = 147;
            // 
            // panel_recap
            // 
            this.panel_recap.Controls.Add(this.panel_outstock);
            this.epeks.SetDecoration(this.panel_recap, BunifuAnimatorNS.DecorationType.None);
            this.panel_recap.Location = new System.Drawing.Point(899, 474);
            this.panel_recap.Name = "panel_recap";
            this.panel_recap.Size = new System.Drawing.Size(278, 143);
            this.panel_recap.TabIndex = 148;
            // 
            // panel_outstock
            // 
            this.panel_outstock.Controls.Add(this.panel_pending_item);
            this.panel_outstock.Controls.Add(this.label94);
            this.epeks.SetDecoration(this.panel_outstock, BunifuAnimatorNS.DecorationType.None);
            this.panel_outstock.Location = new System.Drawing.Point(46, 84);
            this.panel_outstock.Name = "panel_outstock";
            this.panel_outstock.Size = new System.Drawing.Size(1131, 533);
            this.panel_outstock.TabIndex = 0;
            // 
            // panel_pending_item
            // 
            this.panel_pending_item.Controls.Add(this.label102);
            this.epeks.SetDecoration(this.panel_pending_item, BunifuAnimatorNS.DecorationType.None);
            this.panel_pending_item.Location = new System.Drawing.Point(71, 87);
            this.panel_pending_item.Name = "panel_pending_item";
            this.panel_pending_item.Size = new System.Drawing.Size(1106, 530);
            this.panel_pending_item.TabIndex = 1;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.epeks.SetDecoration(this.label102, BunifuAnimatorNS.DecorationType.None);
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(388, 97);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(110, 31);
            this.label102.TabIndex = 0;
            this.label102.Text = "pending";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.epeks.SetDecoration(this.label94, BunifuAnimatorNS.DecorationType.None);
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(381, 115);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(154, 31);
            this.label94.TabIndex = 0;
            this.label94.Text = "out of stock";
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 3;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel22.Controls.Add(this.LVEXP, 1, 2);
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel23, 1, 3);
            this.tableLayoutPanel22.Controls.Add(this.panel22, 1, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel22, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel22.Location = new System.Drawing.Point(46, 43);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 4;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.46396F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53604F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(1131, 574);
            this.tableLayoutPanel22.TabIndex = 145;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 3;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.53897F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.46103F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 724F));
            this.tableLayoutPanel23.Controls.Add(this.btn_expiredLogs, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.btnExpired, 0, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel23, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(13, 524);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(1105, 47);
            this.tableLayoutPanel23.TabIndex = 3;
            // 
            // btn_expiredLogs
            // 
            this.btn_expiredLogs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_expiredLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_expiredLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_expiredLogs.BorderRadius = 5;
            this.btn_expiredLogs.ButtonText = "         Expired Medicine Logs";
            this.btn_expiredLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_expiredLogs, BunifuAnimatorNS.DecorationType.None);
            this.btn_expiredLogs.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btn_expiredLogs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_expiredLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expiredLogs.ForeColor = System.Drawing.Color.Lime;
            this.btn_expiredLogs.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_expiredLogs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_expiredLogs.Iconimage")));
            this.btn_expiredLogs.Iconimage_right = null;
            this.btn_expiredLogs.Iconimage_right_Selected = null;
            this.btn_expiredLogs.Iconimage_Selected = null;
            this.btn_expiredLogs.IconMarginLeft = 20;
            this.btn_expiredLogs.IconMarginRight = 0;
            this.btn_expiredLogs.IconRightVisible = true;
            this.btn_expiredLogs.IconRightZoom = 0D;
            this.btn_expiredLogs.IconVisible = true;
            this.btn_expiredLogs.IconZoom = 50D;
            this.btn_expiredLogs.IsTab = false;
            this.btn_expiredLogs.Location = new System.Drawing.Point(166, 4);
            this.btn_expiredLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_expiredLogs.Name = "btn_expiredLogs";
            this.btn_expiredLogs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_expiredLogs.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btn_expiredLogs.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_expiredLogs.selected = false;
            this.btn_expiredLogs.Size = new System.Drawing.Size(1, 39);
            this.btn_expiredLogs.TabIndex = 141;
            this.btn_expiredLogs.Text = "         Expired Medicine Logs";
            this.btn_expiredLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_expiredLogs.Textcolor = System.Drawing.Color.White;
            this.btn_expiredLogs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expiredLogs.Click += new System.EventHandler(this.btn_expiredLogs_Click);
            // 
            // btnExpired
            // 
            this.btnExpired.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExpired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExpired.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpired.BorderRadius = 5;
            this.btnExpired.ButtonText = "         Expired";
            this.btnExpired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnExpired, BunifuAnimatorNS.DecorationType.None);
            this.btnExpired.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btnExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpired.ForeColor = System.Drawing.Color.Lime;
            this.btnExpired.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExpired.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExpired.Iconimage")));
            this.btnExpired.Iconimage_right = null;
            this.btnExpired.Iconimage_right_Selected = null;
            this.btnExpired.Iconimage_Selected = null;
            this.btnExpired.IconMarginLeft = 0;
            this.btnExpired.IconMarginRight = 0;
            this.btnExpired.IconRightVisible = true;
            this.btnExpired.IconRightZoom = 0D;
            this.btnExpired.IconVisible = true;
            this.btnExpired.IconZoom = 50D;
            this.btnExpired.IsTab = false;
            this.btnExpired.Location = new System.Drawing.Point(4, 4);
            this.btnExpired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExpired.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnExpired.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExpired.selected = false;
            this.btnExpired.Size = new System.Drawing.Size(154, 39);
            this.btnExpired.TabIndex = 140;
            this.btnExpired.Text = "         Expired";
            this.btnExpired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpired.Textcolor = System.Drawing.Color.White;
            this.btnExpired.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpired.Click += new System.EventHandler(this.btnExpired_Click);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Green;
            this.panel22.Controls.Add(this.tableLayoutPanel25);
            this.epeks.SetDecoration(this.panel22, BunifuAnimatorNS.DecorationType.None);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(13, 11);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(1105, 57);
            this.panel22.TabIndex = 4;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 12;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.87878F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel25.Controls.Add(this.cb_expBatch, 2, 1);
            this.tableLayoutPanel25.Controls.Add(this.label61, 1, 1);
            this.tableLayoutPanel25.Controls.Add(this.cb_dateExp, 5, 1);
            this.tableLayoutPanel25.Controls.Add(this.label62, 4, 1);
            this.tableLayoutPanel25.Controls.Add(this.btnfetchexp, 7, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel25, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 3;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(1105, 57);
            this.tableLayoutPanel25.TabIndex = 103;
            // 
            // cb_expBatch
            // 
            this.epeks.SetDecoration(this.cb_expBatch, BunifuAnimatorNS.DecorationType.None);
            this.cb_expBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_expBatch.FormattingEnabled = true;
            this.cb_expBatch.Location = new System.Drawing.Point(3, 11);
            this.cb_expBatch.Name = "cb_expBatch";
            this.cb_expBatch.Size = new System.Drawing.Size(179, 32);
            this.cb_expBatch.TabIndex = 100;
            this.cb_expBatch.Text = "----BATCH----";
            this.cb_expBatch.SelectedIndexChanged += new System.EventHandler(this.cb_expBatch_SelectedIndexChanged);
            this.cb_expBatch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_expBatch_MouseClick);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.epeks.SetDecoration(this.label61, BunifuAnimatorNS.DecorationType.None);
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Location = new System.Drawing.Point(3, 8);
            this.label61.Name = "label61";
            this.label61.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label61.Size = new System.Drawing.Size(1, 41);
            this.label61.TabIndex = 101;
            this.label61.Text = "Available batch:";
            // 
            // cb_dateExp
            // 
            this.epeks.SetDecoration(this.cb_dateExp, BunifuAnimatorNS.DecorationType.None);
            this.cb_dateExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_dateExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dateExp.FormattingEnabled = true;
            this.cb_dateExp.Location = new System.Drawing.Point(372, 11);
            this.cb_dateExp.Name = "cb_dateExp";
            this.cb_dateExp.Size = new System.Drawing.Size(161, 32);
            this.cb_dateExp.TabIndex = 102;
            this.cb_dateExp.Text = "DATE";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.epeks.SetDecoration(this.label62, BunifuAnimatorNS.DecorationType.None);
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(205, 8);
            this.label62.Name = "label62";
            this.label62.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label62.Size = new System.Drawing.Size(153, 34);
            this.label62.TabIndex = 103;
            this.label62.Text = "EXPIRED DATE:";
            // 
            // btnfetchexp
            // 
            this.btnfetchexp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnfetchexp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnfetchexp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfetchexp.BorderRadius = 0;
            this.btnfetchexp.ButtonText = "Fetch Record";
            this.btnfetchexp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnfetchexp, BunifuAnimatorNS.DecorationType.None);
            this.btnfetchexp.DisabledColor = System.Drawing.Color.Gray;
            this.btnfetchexp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnfetchexp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnfetchexp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnfetchexp.Iconimage")));
            this.btnfetchexp.Iconimage_right = null;
            this.btnfetchexp.Iconimage_right_Selected = null;
            this.btnfetchexp.Iconimage_Selected = null;
            this.btnfetchexp.IconMarginLeft = 0;
            this.btnfetchexp.IconMarginRight = 0;
            this.btnfetchexp.IconRightVisible = true;
            this.btnfetchexp.IconRightZoom = 0D;
            this.btnfetchexp.IconVisible = true;
            this.btnfetchexp.IconZoom = 90D;
            this.btnfetchexp.IsTab = false;
            this.btnfetchexp.Location = new System.Drawing.Point(547, 11);
            this.btnfetchexp.Name = "btnfetchexp";
            this.btnfetchexp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnfetchexp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnfetchexp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnfetchexp.selected = false;
            this.btnfetchexp.Size = new System.Drawing.Size(180, 35);
            this.btnfetchexp.TabIndex = 99;
            this.btnfetchexp.Text = "Fetch Record";
            this.btnfetchexp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfetchexp.Textcolor = System.Drawing.Color.White;
            this.btnfetchexp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetchexp.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // p_HistoryLogs
            // 
            this.p_HistoryLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.p_HistoryLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_HistoryLogs.Controls.Add(this.tbGrandTotal);
            this.p_HistoryLogs.Controls.Add(this.bunifuMetroTextbox1);
            this.p_HistoryLogs.Controls.Add(this.label59);
            this.p_HistoryLogs.Controls.Add(this.batchbtn);
            this.p_HistoryLogs.Controls.Add(this.btn_Closeme);
            this.p_HistoryLogs.Controls.Add(this.LVLogs);
            this.p_HistoryLogs.Controls.Add(this.MedLOGS);
            this.p_HistoryLogs.Controls.Add(this.btn_prnitExpDamaged);
            this.epeks.SetDecoration(this.p_HistoryLogs, BunifuAnimatorNS.DecorationType.None);
            this.p_HistoryLogs.Location = new System.Drawing.Point(106, 16);
            this.p_HistoryLogs.Name = "p_HistoryLogs";
            this.p_HistoryLogs.Size = new System.Drawing.Size(1142, 583);
            this.p_HistoryLogs.TabIndex = 147;
            // 
            // tbGrandTotal
            // 
            this.epeks.SetDecoration(this.tbGrandTotal, BunifuAnimatorNS.DecorationType.None);
            this.tbGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGrandTotal.Location = new System.Drawing.Point(921, 529);
            this.tbGrandTotal.Name = "tbGrandTotal";
            this.tbGrandTotal.Size = new System.Drawing.Size(211, 38);
            this.tbGrandTotal.TabIndex = 157;
            this.tbGrandTotal.Text = "100,000";
            this.tbGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Green;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.bunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(194, 714);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(387, 60);
            this.bunifuMetroTextbox1.TabIndex = 156;
            this.bunifuMetroTextbox1.Text = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.epeks.SetDecoration(this.label59, BunifuAnimatorNS.DecorationType.None);
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(794, 532);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(121, 25);
            this.label59.TabIndex = 155;
            this.label59.Text = "Grand Total:";
            // 
            // batchbtn
            // 
            this.epeks.SetDecoration(this.batchbtn, BunifuAnimatorNS.DecorationType.None);
            this.batchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchbtn.FormattingEnabled = true;
            this.batchbtn.Location = new System.Drawing.Point(258, 6);
            this.batchbtn.Name = "batchbtn";
            this.batchbtn.Size = new System.Drawing.Size(179, 32);
            this.batchbtn.TabIndex = 154;
            this.batchbtn.Text = "----BATCH----";
            this.batchbtn.SelectedIndexChanged += new System.EventHandler(this.batchbtn_SelectedIndexChanged);
            // 
            // btn_Closeme
            // 
            this.btn_Closeme.BackColor = System.Drawing.Color.Transparent;
            this.epeks.SetDecoration(this.btn_Closeme, BunifuAnimatorNS.DecorationType.None);
            this.btn_Closeme.Image = ((System.Drawing.Image)(resources.GetObject("btn_Closeme.Image")));
            this.btn_Closeme.ImageActive = null;
            this.btn_Closeme.Location = new System.Drawing.Point(1095, 0);
            this.btn_Closeme.Name = "btn_Closeme";
            this.btn_Closeme.Size = new System.Drawing.Size(35, 32);
            this.btn_Closeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Closeme.TabIndex = 142;
            this.btn_Closeme.TabStop = false;
            this.btn_Closeme.Zoom = 10;
            this.btn_Closeme.Click += new System.EventHandler(this.btn_Closeme_Click);
            // 
            // LVLogs
            // 
            this.LVLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader62,
            this.columnHeader63,
            this.columnHeader64,
            this.columnHeader65,
            this.columnHeader66,
            this.columnHeader67,
            this.columnHeader68,
            this.columnHeader44});
            this.epeks.SetDecoration(this.LVLogs, BunifuAnimatorNS.DecorationType.None);
            this.LVLogs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVLogs.FullRowSelect = true;
            this.LVLogs.GridLines = true;
            this.LVLogs.HoverSelection = true;
            this.LVLogs.Location = new System.Drawing.Point(6, 45);
            this.LVLogs.Name = "LVLogs";
            this.LVLogs.Size = new System.Drawing.Size(1128, 476);
            this.LVLogs.TabIndex = 3;
            this.LVLogs.UseCompatibleStateImageBehavior = false;
            this.LVLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader62
            // 
            this.columnHeader62.Text = "ITEM #";
            this.columnHeader62.Width = 80;
            // 
            // columnHeader63
            // 
            this.columnHeader63.Text = "PO I.D.";
            this.columnHeader63.Width = 110;
            // 
            // columnHeader64
            // 
            this.columnHeader64.Text = "PARTICULAR";
            this.columnHeader64.Width = 160;
            // 
            // columnHeader65
            // 
            this.columnHeader65.Text = "UNIT";
            this.columnHeader65.Width = 160;
            // 
            // columnHeader66
            // 
            this.columnHeader66.Text = "EXPIRED DATE";
            this.columnHeader66.Width = 150;
            // 
            // columnHeader67
            // 
            this.columnHeader67.Text = "PRICE";
            this.columnHeader67.Width = 150;
            // 
            // columnHeader68
            // 
            this.columnHeader68.Text = "QTY";
            this.columnHeader68.Width = 150;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "TOTAL PRICE";
            this.columnHeader44.Width = 150;
            // 
            // MedLOGS
            // 
            this.MedLOGS.AutoSize = true;
            this.epeks.SetDecoration(this.MedLOGS, BunifuAnimatorNS.DecorationType.None);
            this.MedLOGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedLOGS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MedLOGS.Location = new System.Drawing.Point(1, 4);
            this.MedLOGS.Name = "MedLOGS";
            this.MedLOGS.Size = new System.Drawing.Size(291, 31);
            this.MedLOGS.TabIndex = 101;
            this.MedLOGS.Text = "MEDICINE EXPIRED";
            // 
            // p_damageMed
            // 
            this.p_damageMed.BackColor = System.Drawing.Color.Green;
            this.p_damageMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_damageMed.Controls.Add(this.btn_expClose);
            this.p_damageMed.Controls.Add(this.btnSetdamaged);
            this.p_damageMed.Controls.Add(this.label24);
            this.p_damageMed.Controls.Add(this.label25);
            this.p_damageMed.Controls.Add(this.label21);
            this.p_damageMed.Controls.Add(this.tb_expInputno);
            this.p_damageMed.Controls.Add(this.tb_expQty);
            this.p_damageMed.Controls.Add(this.tb_itemnamedamage);
            this.epeks.SetDecoration(this.p_damageMed, BunifuAnimatorNS.DecorationType.None);
            this.p_damageMed.Location = new System.Drawing.Point(488, 206);
            this.p_damageMed.Name = "p_damageMed";
            this.p_damageMed.Size = new System.Drawing.Size(406, 287);
            this.p_damageMed.TabIndex = 146;
            // 
            // btn_expClose
            // 
            this.btn_expClose.BackColor = System.Drawing.Color.Transparent;
            this.epeks.SetDecoration(this.btn_expClose, BunifuAnimatorNS.DecorationType.None);
            this.btn_expClose.Image = ((System.Drawing.Image)(resources.GetObject("btn_expClose.Image")));
            this.btn_expClose.ImageActive = null;
            this.btn_expClose.Location = new System.Drawing.Point(370, -1);
            this.btn_expClose.Name = "btn_expClose";
            this.btn_expClose.Size = new System.Drawing.Size(35, 32);
            this.btn_expClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_expClose.TabIndex = 142;
            this.btn_expClose.TabStop = false;
            this.btn_expClose.Zoom = 10;
            this.btn_expClose.Click += new System.EventHandler(this.btn_expClose_Click);
            // 
            // btnSetdamaged
            // 
            this.btnSetdamaged.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSetdamaged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSetdamaged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetdamaged.BorderRadius = 5;
            this.btnSetdamaged.ButtonText = "                       Damaged";
            this.btnSetdamaged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnSetdamaged, BunifuAnimatorNS.DecorationType.None);
            this.btnSetdamaged.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btnSetdamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetdamaged.ForeColor = System.Drawing.Color.Lime;
            this.btnSetdamaged.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetdamaged.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetdamaged.Iconimage")));
            this.btnSetdamaged.Iconimage_right = null;
            this.btnSetdamaged.Iconimage_right_Selected = null;
            this.btnSetdamaged.Iconimage_Selected = null;
            this.btnSetdamaged.IconMarginLeft = 50;
            this.btnSetdamaged.IconMarginRight = 0;
            this.btnSetdamaged.IconRightVisible = true;
            this.btnSetdamaged.IconRightZoom = 0D;
            this.btnSetdamaged.IconVisible = true;
            this.btnSetdamaged.IconZoom = 50D;
            this.btnSetdamaged.IsTab = false;
            this.btnSetdamaged.Location = new System.Drawing.Point(21, 224);
            this.btnSetdamaged.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetdamaged.Name = "btnSetdamaged";
            this.btnSetdamaged.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSetdamaged.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnSetdamaged.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSetdamaged.selected = false;
            this.btnSetdamaged.Size = new System.Drawing.Size(368, 50);
            this.btnSetdamaged.TabIndex = 141;
            this.btnSetdamaged.Text = "                       Damaged";
            this.btnSetdamaged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetdamaged.Textcolor = System.Drawing.Color.White;
            this.btnSetdamaged.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetdamaged.Click += new System.EventHandler(this.btnSetdamaged_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.epeks.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(214, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(124, 25);
            this.label24.TabIndex = 101;
            this.label24.Text = "INPUT QTY:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.epeks.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(3, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(252, 25);
            this.label25.TabIndex = 101;
            this.label25.Text = "FOR DAMAGE MEDICINE:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.epeks.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(25, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 25);
            this.label21.TabIndex = 101;
            this.label21.Text = "TOTAL QTY:";
            // 
            // tb_expInputno
            // 
            this.tb_expInputno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_expInputno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epeks.SetDecoration(this.tb_expInputno, BunifuAnimatorNS.DecorationType.None);
            this.tb_expInputno.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_expInputno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_expInputno.Location = new System.Drawing.Point(219, 141);
            this.tb_expInputno.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tb_expInputno.Name = "tb_expInputno";
            this.tb_expInputno.Size = new System.Drawing.Size(165, 60);
            this.tb_expInputno.TabIndex = 99;
            this.tb_expInputno.Enter += new System.EventHandler(this.tb_expInputno_Enter);
            this.tb_expInputno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_expInputno_KeyDown);
            this.tb_expInputno.Leave += new System.EventHandler(this.tb_expInputno_Leave);
            // 
            // tb_expQty
            // 
            this.tb_expQty.BackColor = System.Drawing.Color.LightGreen;
            this.tb_expQty.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.tb_expQty.BorderColorIdle = System.Drawing.Color.DarkGreen;
            this.tb_expQty.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.tb_expQty.BorderThickness = 3;
            this.tb_expQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tb_expQty, BunifuAnimatorNS.DecorationType.None);
            this.tb_expQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_expQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_expQty.isPassword = false;
            this.tb_expQty.Location = new System.Drawing.Point(21, 142);
            this.tb_expQty.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tb_expQty.Name = "tb_expQty";
            this.tb_expQty.Size = new System.Drawing.Size(152, 58);
            this.tb_expQty.TabIndex = 98;
            this.tb_expQty.Text = "0";
            this.tb_expQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_itemnamedamage
            // 
            this.tb_itemnamedamage.BackColor = System.Drawing.Color.LightGreen;
            this.tb_itemnamedamage.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.tb_itemnamedamage.BorderColorIdle = System.Drawing.Color.DarkGreen;
            this.tb_itemnamedamage.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.tb_itemnamedamage.BorderThickness = 3;
            this.tb_itemnamedamage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tb_itemnamedamage, BunifuAnimatorNS.DecorationType.None);
            this.tb_itemnamedamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_itemnamedamage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_itemnamedamage.isPassword = false;
            this.tb_itemnamedamage.Location = new System.Drawing.Point(22, 53);
            this.tb_itemnamedamage.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tb_itemnamedamage.Name = "tb_itemnamedamage";
            this.tb_itemnamedamage.Size = new System.Drawing.Size(361, 42);
            this.tb_itemnamedamage.TabIndex = 100;
            this.tb_itemnamedamage.Text = "Item name";
            this.tb_itemnamedamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_generatedLogs
            // 
            this.tb_generatedLogs.ColumnCount = 3;
            this.tb_generatedLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tb_generatedLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_generatedLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tb_generatedLogs.Controls.Add(this.GLLV, 1, 2);
            this.tb_generatedLogs.Controls.Add(this.tableLayoutPanel16, 1, 3);
            this.tb_generatedLogs.Controls.Add(this.panel18, 1, 1);
            this.epeks.SetDecoration(this.tb_generatedLogs, BunifuAnimatorNS.DecorationType.None);
            this.tb_generatedLogs.Location = new System.Drawing.Point(32, 24);
            this.tb_generatedLogs.Name = "tb_generatedLogs";
            this.tb_generatedLogs.RowCount = 4;
            this.tb_generatedLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tb_generatedLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tb_generatedLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.44444F));
            this.tb_generatedLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.55556F));
            this.tb_generatedLogs.Size = new System.Drawing.Size(1145, 593);
            this.tb_generatedLogs.TabIndex = 144;
            // 
            // GLLV
            // 
            this.GLLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36,
            this.columnHeader37});
            this.epeks.SetDecoration(this.GLLV, BunifuAnimatorNS.DecorationType.None);
            this.GLLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GLLV.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLLV.FullRowSelect = true;
            this.GLLV.GridLines = true;
            this.GLLV.HoverSelection = true;
            this.GLLV.Location = new System.Drawing.Point(12, 74);
            this.GLLV.Name = "GLLV";
            this.GLLV.Size = new System.Drawing.Size(1120, 460);
            this.GLLV.TabIndex = 2;
            this.GLLV.UseCompatibleStateImageBehavior = false;
            this.GLLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "ITEM ID";
            this.columnHeader33.Width = 200;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "MEDICINE NAME";
            this.columnHeader34.Width = 200;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "STOCK";
            this.columnHeader35.Width = 200;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "OUT MEDICINE";
            this.columnHeader36.Width = 200;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "ENDING";
            this.columnHeader37.Width = 200;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.60691F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39309F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel19, 1, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel16, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(12, 540);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(1120, 50);
            this.tableLayoutPanel16.TabIndex = 3;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.3672F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.6328F));
            this.epeks.SetDecoration(this.tableLayoutPanel19, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(569, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(548, 44);
            this.tableLayoutPanel19.TabIndex = 139;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Green;
            this.panel18.Controls.Add(this.tableLayoutPanel4);
            this.epeks.SetDecoration(this.panel18, BunifuAnimatorNS.DecorationType.None);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(12, 11);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1120, 57);
            this.panel18.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 11;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel4.Controls.Add(this.GLfromdate, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_fetchrecordGL, 9, 1);
            this.tableLayoutPanel4.Controls.Add(this.cb_batchGL, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label54, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label55, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.label56, 6, 1);
            this.tableLayoutPanel4.Controls.Add(this.GLtodate, 7, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel4, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1120, 57);
            this.tableLayoutPanel4.TabIndex = 103;
            // 
            // GLfromdate
            // 
            this.GLfromdate.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.GLfromdate, BunifuAnimatorNS.DecorationType.None);
            this.GLfromdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GLfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GLfromdate.Location = new System.Drawing.Point(309, 12);
            this.GLfromdate.MinimumSize = new System.Drawing.Size(4, 29);
            this.GLfromdate.Name = "GLfromdate";
            this.GLfromdate.Size = new System.Drawing.Size(192, 29);
            this.GLfromdate.TabIndex = 152;
            // 
            // btn_fetchrecordGL
            // 
            this.btn_fetchrecordGL.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_fetchrecordGL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_fetchrecordGL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fetchrecordGL.BorderRadius = 0;
            this.btn_fetchrecordGL.ButtonText = "Fetch Record";
            this.btn_fetchrecordGL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_fetchrecordGL, BunifuAnimatorNS.DecorationType.None);
            this.btn_fetchrecordGL.DisabledColor = System.Drawing.Color.Gray;
            this.btn_fetchrecordGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_fetchrecordGL.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_fetchrecordGL.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_fetchrecordGL.Iconimage")));
            this.btn_fetchrecordGL.Iconimage_right = null;
            this.btn_fetchrecordGL.Iconimage_right_Selected = null;
            this.btn_fetchrecordGL.Iconimage_Selected = null;
            this.btn_fetchrecordGL.IconMarginLeft = 0;
            this.btn_fetchrecordGL.IconMarginRight = 0;
            this.btn_fetchrecordGL.IconRightVisible = true;
            this.btn_fetchrecordGL.IconRightZoom = 0D;
            this.btn_fetchrecordGL.IconVisible = true;
            this.btn_fetchrecordGL.IconZoom = 90D;
            this.btn_fetchrecordGL.IsTab = false;
            this.btn_fetchrecordGL.Location = new System.Drawing.Point(801, 12);
            this.btn_fetchrecordGL.Name = "btn_fetchrecordGL";
            this.btn_fetchrecordGL.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_fetchrecordGL.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_fetchrecordGL.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_fetchrecordGL.selected = false;
            this.btn_fetchrecordGL.Size = new System.Drawing.Size(179, 32);
            this.btn_fetchrecordGL.TabIndex = 99;
            this.btn_fetchrecordGL.Text = "Fetch Record";
            this.btn_fetchrecordGL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fetchrecordGL.Textcolor = System.Drawing.Color.White;
            this.btn_fetchrecordGL.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fetchrecordGL.Click += new System.EventHandler(this.btn_fetchrecordGL_Click);
            // 
            // cb_batchGL
            // 
            this.epeks.SetDecoration(this.cb_batchGL, BunifuAnimatorNS.DecorationType.None);
            this.cb_batchGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_batchGL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_batchGL.FormattingEnabled = true;
            this.cb_batchGL.Location = new System.Drawing.Point(53, 12);
            this.cb_batchGL.Name = "cb_batchGL";
            this.cb_batchGL.Size = new System.Drawing.Size(140, 32);
            this.cb_batchGL.TabIndex = 100;
            this.cb_batchGL.Text = "----BATCH----";
            this.cb_batchGL.SelectedIndexChanged += new System.EventHandler(this.cb_batchGL_SelectedIndexChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.epeks.SetDecoration(this.label54, BunifuAnimatorNS.DecorationType.None);
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(13, 9);
            this.label54.Name = "label54";
            this.label54.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label54.Size = new System.Drawing.Size(34, 38);
            this.label54.TabIndex = 101;
            this.label54.Text = "Available batch:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.epeks.SetDecoration(this.label55, BunifuAnimatorNS.DecorationType.None);
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(219, 9);
            this.label55.Name = "label55";
            this.label55.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label55.Size = new System.Drawing.Size(84, 38);
            this.label55.TabIndex = 101;
            this.label55.Text = "FROM:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.epeks.SetDecoration(this.label56, BunifuAnimatorNS.DecorationType.None);
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(507, 9);
            this.label56.Name = "label56";
            this.label56.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label56.Size = new System.Drawing.Size(76, 38);
            this.label56.TabIndex = 101;
            this.label56.Text = "TO:";
            // 
            // GLtodate
            // 
            this.GLtodate.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.GLtodate, BunifuAnimatorNS.DecorationType.None);
            this.GLtodate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GLtodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GLtodate.Location = new System.Drawing.Point(589, 12);
            this.GLtodate.MinimumSize = new System.Drawing.Size(4, 29);
            this.GLtodate.Name = "GLtodate";
            this.GLtodate.Size = new System.Drawing.Size(180, 29);
            this.GLtodate.TabIndex = 152;
            // 
            // PMtable
            // 
            this.PMtable.ColumnCount = 3;
            this.PMtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.PMtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PMtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.PMtable.Controls.Add(this.PMLV, 1, 2);
            this.PMtable.Controls.Add(this.tableLayoutPanel17, 1, 3);
            this.PMtable.Controls.Add(this.panel7, 1, 1);
            this.epeks.SetDecoration(this.PMtable, BunifuAnimatorNS.DecorationType.None);
            this.PMtable.Location = new System.Drawing.Point(20, 43);
            this.PMtable.Name = "PMtable";
            this.PMtable.RowCount = 4;
            this.PMtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.PMtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.PMtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.01099F));
            this.PMtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.PMtable.Size = new System.Drawing.Size(1157, 574);
            this.PMtable.TabIndex = 143;
            // 
            // PMLV
            // 
            this.PMLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader90,
            this.columnHeader40,
            this.columnHeader41});
            this.epeks.SetDecoration(this.PMLV, BunifuAnimatorNS.DecorationType.None);
            this.PMLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMLV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMLV.FullRowSelect = true;
            this.PMLV.GridLines = true;
            this.PMLV.HideSelection = false;
            this.PMLV.Location = new System.Drawing.Point(12, 74);
            this.PMLV.Name = "PMLV";
            this.PMLV.Size = new System.Drawing.Size(1134, 441);
            this.PMLV.TabIndex = 2;
            this.PMLV.UseCompatibleStateImageBehavior = false;
            this.PMLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "ITEM #";
            this.columnHeader28.Width = 80;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "ITEM NAME";
            this.columnHeader29.Width = 150;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "UNIT";
            this.columnHeader30.Width = 150;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "BEGINNING";
            this.columnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader31.Width = 150;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "OUT MEDICINE";
            this.columnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader32.Width = 150;
            // 
            // columnHeader90
            // 
            this.columnHeader90.Text = "ENDING";
            this.columnHeader90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader90.Width = 150;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "UNIT PRICE";
            this.columnHeader40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader40.Width = 150;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "TOTAL AMOUNT";
            this.columnHeader41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader41.Width = 150;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.17361F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.82639F));
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel18, 1, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel17, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(12, 521);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(1134, 50);
            this.tableLayoutPanel17.TabIndex = 3;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 3;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.68316F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.31684F));
            this.tableLayoutPanel18.Controls.Add(this.btn_PMprint, 2, 0);
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel21, 1, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel18, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(288, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(843, 44);
            this.tableLayoutPanel18.TabIndex = 139;
            // 
            // btn_PMprint
            // 
            this.btn_PMprint.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_PMprint.color = System.Drawing.Color.DarkGreen;
            this.btn_PMprint.colorActive = System.Drawing.Color.DarkGreen;
            this.btn_PMprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_PMprint, BunifuAnimatorNS.DecorationType.None);
            this.btn_PMprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PMprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PMprint.ForeColor = System.Drawing.Color.White;
            this.btn_PMprint.Image = ((System.Drawing.Image)(resources.GetObject("btn_PMprint.Image")));
            this.btn_PMprint.ImagePosition = 6;
            this.btn_PMprint.ImageZoom = 20;
            this.btn_PMprint.LabelPosition = 27;
            this.btn_PMprint.LabelText = "PRINT";
            this.btn_PMprint.Location = new System.Drawing.Point(686, 6);
            this.btn_PMprint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_PMprint.Name = "btn_PMprint";
            this.btn_PMprint.Size = new System.Drawing.Size(152, 32);
            this.btn_PMprint.TabIndex = 138;
            this.btn_PMprint.Click += new System.EventHandler(this.btn_PMprint_Click);
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 3;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.99214F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.00786F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel21.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel21.Controls.Add(this.label60, 0, 1);
            this.tableLayoutPanel21.Controls.Add(this.tbgetyear, 2, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel21, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(11, 3);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 3;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.93023F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.06977F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(667, 38);
            this.tableLayoutPanel21.TabIndex = 140;
            // 
            // comboBox1
            // 
            this.epeks.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox1.Location = new System.Drawing.Point(284, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 32);
            this.comboBox1.TabIndex = 100;
            this.comboBox1.Text = "----Select Month----";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.epeks.SetDecoration(this.label60, BunifuAnimatorNS.DecorationType.None);
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(3, 5);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(275, 22);
            this.label60.TabIndex = 101;
            this.label60.Text = "Select Month:";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbgetyear
            // 
            this.epeks.SetDecoration(this.tbgetyear, BunifuAnimatorNS.DecorationType.None);
            this.tbgetyear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbgetyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgetyear.Location = new System.Drawing.Point(505, 8);
            this.tbgetyear.Name = "tbgetyear";
            this.tbgetyear.Size = new System.Drawing.Size(159, 33);
            this.tbgetyear.TabIndex = 102;
            this.tbgetyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Controls.Add(this.dateforIM);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.PMfetchbtn);
            this.panel7.Controls.Add(this.cb_batchno);
            this.epeks.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(12, 11);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.panel7.Size = new System.Drawing.Size(1134, 57);
            this.panel7.TabIndex = 4;
            // 
            // dateforIM
            // 
            this.dateforIM.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.dateforIM, BunifuAnimatorNS.DecorationType.None);
            this.dateforIM.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateforIM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateforIM.Location = new System.Drawing.Point(945, 20);
            this.dateforIM.MinimumSize = new System.Drawing.Size(4, 29);
            this.dateforIM.Name = "dateforIM";
            this.dateforIM.Size = new System.Drawing.Size(169, 29);
            this.dateforIM.TabIndex = 152;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.epeks.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(9, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 24);
            this.label22.TabIndex = 101;
            this.label22.Text = "Available P.O. I.D:";
            // 
            // PMfetchbtn
            // 
            this.PMfetchbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PMfetchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PMfetchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PMfetchbtn.BorderRadius = 0;
            this.PMfetchbtn.ButtonText = "Fetch Record";
            this.PMfetchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.PMfetchbtn, BunifuAnimatorNS.DecorationType.None);
            this.PMfetchbtn.DisabledColor = System.Drawing.Color.Gray;
            this.PMfetchbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.PMfetchbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("PMfetchbtn.Iconimage")));
            this.PMfetchbtn.Iconimage_right = null;
            this.PMfetchbtn.Iconimage_right_Selected = null;
            this.PMfetchbtn.Iconimage_Selected = null;
            this.PMfetchbtn.IconMarginLeft = 0;
            this.PMfetchbtn.IconMarginRight = 0;
            this.PMfetchbtn.IconRightVisible = true;
            this.PMfetchbtn.IconRightZoom = 0D;
            this.PMfetchbtn.IconVisible = true;
            this.PMfetchbtn.IconZoom = 90D;
            this.PMfetchbtn.IsTab = false;
            this.PMfetchbtn.Location = new System.Drawing.Point(438, 10);
            this.PMfetchbtn.Name = "PMfetchbtn";
            this.PMfetchbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PMfetchbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PMfetchbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.PMfetchbtn.selected = false;
            this.PMfetchbtn.Size = new System.Drawing.Size(167, 39);
            this.PMfetchbtn.TabIndex = 99;
            this.PMfetchbtn.Text = "Fetch Record";
            this.PMfetchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PMfetchbtn.Textcolor = System.Drawing.Color.White;
            this.PMfetchbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMfetchbtn.Click += new System.EventHandler(this.PMfetchbtn_Click_1);
            // 
            // cb_batchno
            // 
            this.epeks.SetDecoration(this.cb_batchno, BunifuAnimatorNS.DecorationType.None);
            this.cb_batchno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_batchno.FormattingEnabled = true;
            this.cb_batchno.Location = new System.Drawing.Point(179, 13);
            this.cb_batchno.Name = "cb_batchno";
            this.cb_batchno.Size = new System.Drawing.Size(253, 32);
            this.cb_batchno.TabIndex = 100;
            this.cb_batchno.Text = "----P.O. I.D.----";
            this.cb_batchno.SelectedIndexChanged += new System.EventHandler(this.cb_batchno_SelectedIndexChanged_1);
            this.cb_batchno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_batchno_MouseClick);
            // 
            // RTable
            // 
            this.RTable.ColumnCount = 3;
            this.RTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.RTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.RTable.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.RTable.Controls.Add(this.rlistview, 1, 2);
            this.RTable.Controls.Add(this.tableLayoutPanel14, 1, 3);
            this.epeks.SetDecoration(this.RTable, BunifuAnimatorNS.DecorationType.None);
            this.RTable.Location = new System.Drawing.Point(19, 28);
            this.RTable.Name = "RTable";
            this.RTable.RowCount = 4;
            this.RTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.RTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.RTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.56987F));
            this.RTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43013F));
            this.RTable.Size = new System.Drawing.Size(1158, 589);
            this.RTable.TabIndex = 142;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel7.ColumnCount = 12;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.73444F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.26556F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.tableLayoutPanel7.Controls.Add(this.label50, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.label51, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.label52, 7, 1);
            this.tableLayoutPanel7.Controls.Add(this.rfrom, 5, 1);
            this.tableLayoutPanel7.Controls.Add(this.rto, 8, 1);
            this.tableLayoutPanel7.Controls.Add(this.btn_rfetch, 10, 1);
            this.tableLayoutPanel7.Controls.Add(this.label53, 1, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel7, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.59184F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1133, 58);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.epeks.SetDecoration(this.label50, BunifuAnimatorNS.DecorationType.None);
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(65, 10);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(85, 31);
            this.label50.TabIndex = 0;
            this.label50.Text = "From:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.epeks.SetDecoration(this.label51, BunifuAnimatorNS.DecorationType.None);
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(57, 10);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(2, 39);
            this.label51.TabIndex = 0;
            this.label51.Text = "Date:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.epeks.SetDecoration(this.label52, BunifuAnimatorNS.DecorationType.None);
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(355, 10);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(54, 31);
            this.label52.TabIndex = 0;
            this.label52.Text = "To:";
            // 
            // rfrom
            // 
            this.rfrom.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.rfrom, BunifuAnimatorNS.DecorationType.None);
            this.rfrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rfrom.Location = new System.Drawing.Point(168, 13);
            this.rfrom.MinimumSize = new System.Drawing.Size(4, 29);
            this.rfrom.Name = "rfrom";
            this.rfrom.Size = new System.Drawing.Size(169, 29);
            this.rfrom.TabIndex = 96;
            // 
            // rto
            // 
            this.rto.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.rto, BunifuAnimatorNS.DecorationType.None);
            this.rto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rto.Location = new System.Drawing.Point(426, 13);
            this.rto.MinimumSize = new System.Drawing.Size(4, 29);
            this.rto.Name = "rto";
            this.rto.Size = new System.Drawing.Size(170, 29);
            this.rto.TabIndex = 96;
            // 
            // btn_rfetch
            // 
            this.btn_rfetch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_rfetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_rfetch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rfetch.BorderRadius = 0;
            this.btn_rfetch.ButtonText = "Fetch Record";
            this.btn_rfetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_rfetch, BunifuAnimatorNS.DecorationType.None);
            this.btn_rfetch.DisabledColor = System.Drawing.Color.Gray;
            this.btn_rfetch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rfetch.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_rfetch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_rfetch.Iconimage")));
            this.btn_rfetch.Iconimage_right = null;
            this.btn_rfetch.Iconimage_right_Selected = null;
            this.btn_rfetch.Iconimage_Selected = null;
            this.btn_rfetch.IconMarginLeft = 0;
            this.btn_rfetch.IconMarginRight = 0;
            this.btn_rfetch.IconRightVisible = true;
            this.btn_rfetch.IconRightZoom = 0D;
            this.btn_rfetch.IconVisible = true;
            this.btn_rfetch.IconZoom = 90D;
            this.btn_rfetch.IsTab = false;
            this.btn_rfetch.Location = new System.Drawing.Point(621, 13);
            this.btn_rfetch.Name = "btn_rfetch";
            this.btn_rfetch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_rfetch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_rfetch.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_rfetch.selected = false;
            this.btn_rfetch.Size = new System.Drawing.Size(197, 33);
            this.btn_rfetch.TabIndex = 97;
            this.btn_rfetch.Text = "Fetch Record";
            this.btn_rfetch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rfetch.Textcolor = System.Drawing.Color.White;
            this.btn_rfetch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rfetch.Click += new System.EventHandler(this.btn_rfetch_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.epeks.SetDecoration(this.label53, BunifuAnimatorNS.DecorationType.None);
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(4, 10);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(29, 39);
            this.label53.TabIndex = 0;
            this.label53.Text = "Returned Med:";
            // 
            // rlistview
            // 
            this.rlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
            this.epeks.SetDecoration(this.rlistview, BunifuAnimatorNS.DecorationType.None);
            this.rlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rlistview.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlistview.FullRowSelect = true;
            this.rlistview.GridLines = true;
            this.rlistview.HoverSelection = true;
            this.rlistview.Location = new System.Drawing.Point(12, 76);
            this.rlistview.Name = "rlistview";
            this.rlistview.Size = new System.Drawing.Size(1133, 440);
            this.rlistview.TabIndex = 2;
            this.rlistview.UseCompatibleStateImageBehavior = false;
            this.rlistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "INVOICE NO:";
            this.columnHeader21.Width = 130;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "ITEM NAME:";
            this.columnHeader22.Width = 190;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "ITEM QTY:";
            this.columnHeader23.Width = 190;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "COST:";
            this.columnHeader24.Width = 170;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "DATE PURCHASED:";
            this.columnHeader25.Width = 190;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "DATE RETURNED:";
            this.columnHeader26.Width = 190;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "CASHIER INCHARGE:";
            this.columnHeader27.Width = 190;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.60691F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39309F));
            this.tableLayoutPanel14.Controls.Add(this.btn_rprint, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 1, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel14, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(12, 522);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(1133, 64);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // btn_rprint
            // 
            this.btn_rprint.BackColor = System.Drawing.Color.Green;
            this.btn_rprint.color = System.Drawing.Color.Green;
            this.btn_rprint.colorActive = System.Drawing.Color.DarkGreen;
            this.btn_rprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_rprint, BunifuAnimatorNS.DecorationType.None);
            this.btn_rprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rprint.ForeColor = System.Drawing.Color.White;
            this.btn_rprint.Image = ((System.Drawing.Image)(resources.GetObject("btn_rprint.Image")));
            this.btn_rprint.ImagePosition = 6;
            this.btn_rprint.ImageZoom = 20;
            this.btn_rprint.LabelPosition = 27;
            this.btn_rprint.LabelText = "PRINT";
            this.btn_rprint.Location = new System.Drawing.Point(5, 6);
            this.btn_rprint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_rprint.Name = "btn_rprint";
            this.btn_rprint.Size = new System.Drawing.Size(150, 46);
            this.btn_rprint.TabIndex = 138;
            this.btn_rprint.Click += new System.EventHandler(this.btn_rprint_Click);
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.3672F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.6328F));
            this.epeks.SetDecoration(this.tableLayoutPanel15, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(576, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(554, 58);
            this.tableLayoutPanel15.TabIndex = 139;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.LVsales, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 1, 3);
            this.epeks.SetDecoration(this.tableLayoutPanel8, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(27, 43);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.56987F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43013F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1150, 574);
            this.tableLayoutPanel8.TabIndex = 141;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel5.ColumnCount = 12;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel5.Controls.Add(this.label11, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label13, 7, 1);
            this.tableLayoutPanel5.Controls.Add(this.from, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.to, 8, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnfetch, 10, 1);
            this.tableLayoutPanel5.Controls.Add(this.cb_category, 1, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel5, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1126, 59);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.epeks.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(294, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "From:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.epeks.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(195, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 31);
            this.label12.TabIndex = 0;
            this.label12.Text = "Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.epeks.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(584, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "To:";
            // 
            // from
            // 
            this.from.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.from, BunifuAnimatorNS.DecorationType.None);
            this.from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from.Location = new System.Drawing.Point(397, 11);
            this.from.MinimumSize = new System.Drawing.Size(4, 29);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(169, 29);
            this.from.TabIndex = 96;
            // 
            // to
            // 
            this.to.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.to, BunifuAnimatorNS.DecorationType.None);
            this.to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to.Location = new System.Drawing.Point(655, 11);
            this.to.MinimumSize = new System.Drawing.Size(4, 29);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(170, 29);
            this.to.TabIndex = 96;
            // 
            // btnfetch
            // 
            this.btnfetch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnfetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnfetch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfetch.BorderRadius = 0;
            this.btnfetch.ButtonText = "Fetch Record";
            this.btnfetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnfetch, BunifuAnimatorNS.DecorationType.None);
            this.btnfetch.DisabledColor = System.Drawing.Color.Gray;
            this.btnfetch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnfetch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnfetch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnfetch.Iconimage")));
            this.btnfetch.Iconimage_right = null;
            this.btnfetch.Iconimage_right_Selected = null;
            this.btnfetch.Iconimage_Selected = null;
            this.btnfetch.IconMarginLeft = 0;
            this.btnfetch.IconMarginRight = 0;
            this.btnfetch.IconRightVisible = true;
            this.btnfetch.IconRightZoom = 0D;
            this.btnfetch.IconVisible = true;
            this.btnfetch.IconZoom = 90D;
            this.btnfetch.IsTab = false;
            this.btnfetch.Location = new System.Drawing.Point(850, 11);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnfetch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnfetch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnfetch.selected = false;
            this.btnfetch.Size = new System.Drawing.Size(197, 36);
            this.btnfetch.TabIndex = 97;
            this.btnfetch.Text = "Fetch Record";
            this.btnfetch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfetch.Textcolor = System.Drawing.Color.White;
            this.btnfetch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // cb_category
            // 
            this.epeks.SetDecoration(this.cb_category, BunifuAnimatorNS.DecorationType.None);
            this.cb_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "IN PATIENT",
            "OUT PATIENT"});
            this.cb_category.Location = new System.Drawing.Point(11, 11);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(145, 32);
            this.cb_category.TabIndex = 98;
            this.cb_category.Text = "-------SELECT SALES------";
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // LVsales
            // 
            this.LVsales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.epeks.SetDecoration(this.LVsales, BunifuAnimatorNS.DecorationType.None);
            this.LVsales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVsales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVsales.FullRowSelect = true;
            this.LVsales.GridLines = true;
            this.LVsales.HoverSelection = true;
            this.LVsales.Location = new System.Drawing.Point(12, 76);
            this.LVsales.Name = "LVsales";
            this.LVsales.Size = new System.Drawing.Size(1126, 427);
            this.LVsales.TabIndex = 2;
            this.LVsales.UseCompatibleStateImageBehavior = false;
            this.LVsales.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "INVOICE ID";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TOTAL QTY";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "TOTAL";
            this.columnHeader14.Width = 140;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "SUBTOTAL";
            this.columnHeader15.Width = 140;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "DISCOUNT %";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "DISCOUNT AMT";
            this.columnHeader17.Width = 140;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "DATE";
            this.columnHeader18.Width = 140;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "TIME";
            this.columnHeader19.Width = 140;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "CASHIER";
            this.columnHeader20.Width = 140;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.60691F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39309F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel24, 0, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel11, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(12, 509);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1126, 62);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.3672F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.6328F));
            this.tableLayoutPanel12.Controls.Add(this.total_monthly, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel12, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(572, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(551, 56);
            this.tableLayoutPanel12.TabIndex = 139;
            // 
            // total_monthly
            // 
            this.total_monthly.BackColor = System.Drawing.Color.White;
            this.total_monthly.BorderColorFocused = System.Drawing.Color.Lime;
            this.total_monthly.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.total_monthly.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.total_monthly.BorderThickness = 3;
            this.total_monthly.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.total_monthly, BunifuAnimatorNS.DecorationType.None);
            this.total_monthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_monthly.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_monthly.ForeColor = System.Drawing.Color.DarkGreen;
            this.total_monthly.isPassword = false;
            this.total_monthly.Location = new System.Drawing.Point(306, 7);
            this.total_monthly.Margin = new System.Windows.Forms.Padding(7);
            this.total_monthly.Name = "total_monthly";
            this.total_monthly.Size = new System.Drawing.Size(238, 42);
            this.total_monthly.TabIndex = 140;
            this.total_monthly.Text = "0.00";
            this.total_monthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.tableLayoutPanel13.Controls.Add(this.label23, 1, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel13, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.90566F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(293, 50);
            this.tableLayoutPanel13.TabIndex = 141;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.epeks.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(143, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(140, 29);
            this.label23.TabIndex = 0;
            this.label23.Text = "Total Sale:";
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 2;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.39286F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.60714F));
            this.tableLayoutPanel24.Controls.Add(this.btn_Charge, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.sprint, 0, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel24, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(563, 56);
            this.tableLayoutPanel24.TabIndex = 1;
            // 
            // btn_Charge
            // 
            this.btn_Charge.BackColor = System.Drawing.Color.Green;
            this.btn_Charge.color = System.Drawing.Color.Green;
            this.btn_Charge.colorActive = System.Drawing.Color.DarkGreen;
            this.btn_Charge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_Charge, BunifuAnimatorNS.DecorationType.None);
            this.btn_Charge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Charge.ForeColor = System.Drawing.Color.White;
            this.btn_Charge.Image = ((System.Drawing.Image)(resources.GetObject("btn_Charge.Image")));
            this.btn_Charge.ImagePosition = 6;
            this.btn_Charge.ImageZoom = 20;
            this.btn_Charge.LabelPosition = 27;
            this.btn_Charge.LabelText = "Search charge";
            this.btn_Charge.Location = new System.Drawing.Point(193, 6);
            this.btn_Charge.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Charge.Name = "btn_Charge";
            this.btn_Charge.Size = new System.Drawing.Size(150, 44);
            this.btn_Charge.TabIndex = 139;
            this.btn_Charge.Click += new System.EventHandler(this.btn_Charge_Click);
            // 
            // sprint
            // 
            this.sprint.BackColor = System.Drawing.Color.Green;
            this.sprint.color = System.Drawing.Color.Green;
            this.sprint.colorActive = System.Drawing.Color.DarkGreen;
            this.sprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.sprint, BunifuAnimatorNS.DecorationType.None);
            this.sprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprint.ForeColor = System.Drawing.Color.White;
            this.sprint.Image = ((System.Drawing.Image)(resources.GetObject("sprint.Image")));
            this.sprint.ImagePosition = 6;
            this.sprint.ImageZoom = 20;
            this.sprint.LabelPosition = 27;
            this.sprint.LabelText = "PRINT";
            this.sprint.Location = new System.Drawing.Point(5, 6);
            this.sprint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.sprint.Name = "sprint";
            this.sprint.Size = new System.Drawing.Size(150, 44);
            this.sprint.TabIndex = 138;
            this.sprint.Click += new System.EventHandler(this.sprint_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.LVreport, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel47, 2, 3);
            this.epeks.SetDecoration(this.tableLayoutPanel3, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(21, 54);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1156, 563);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel6.ColumnCount = 12;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.37736F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.62264F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel6.Controls.Add(this.label8, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.label9, 7, 1);
            this.tableLayoutPanel6.Controls.Add(this.label15, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.fromdate, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this.todate, 8, 1);
            this.tableLayoutPanel6.Controls.Add(this.cbdepreport, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.fetch, 10, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel6, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(13, 11);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1130, 58);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.epeks.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(334, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.epeks.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(234, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.epeks.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(613, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "To:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.epeks.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "R.I.S LOG";
            // 
            // fromdate
            // 
            this.fromdate.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.fromdate, BunifuAnimatorNS.DecorationType.None);
            this.fromdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromdate.Location = new System.Drawing.Point(426, 12);
            this.fromdate.MinimumSize = new System.Drawing.Size(4, 29);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(173, 29);
            this.fromdate.TabIndex = 96;
            // 
            // todate
            // 
            this.todate.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.todate, BunifuAnimatorNS.DecorationType.None);
            this.todate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todate.Location = new System.Drawing.Point(673, 12);
            this.todate.MinimumSize = new System.Drawing.Size(4, 29);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(170, 29);
            this.todate.TabIndex = 96;
            // 
            // cbdepreport
            // 
            this.epeks.SetDecoration(this.cbdepreport, BunifuAnimatorNS.DecorationType.None);
            this.cbdepreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbdepreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepreport.FormattingEnabled = true;
            this.cbdepreport.Items.AddRange(new object[] {
            "IN PATIENT",
            "OUT PATIENT"});
            this.cbdepreport.Location = new System.Drawing.Point(3, 12);
            this.cbdepreport.Name = "cbdepreport";
            this.cbdepreport.Size = new System.Drawing.Size(225, 32);
            this.cbdepreport.TabIndex = 98;
            this.cbdepreport.Text = "Select Department";
            this.cbdepreport.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            this.cbdepreport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbdepreport_MouseClick);
            // 
            // fetch
            // 
            this.fetch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fetch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fetch.BorderRadius = 0;
            this.fetch.ButtonText = "Fetch Record";
            this.fetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.fetch, BunifuAnimatorNS.DecorationType.None);
            this.fetch.DisabledColor = System.Drawing.Color.Gray;
            this.fetch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fetch.Iconcolor = System.Drawing.Color.Transparent;
            this.fetch.Iconimage = ((System.Drawing.Image)(resources.GetObject("fetch.Iconimage")));
            this.fetch.Iconimage_right = null;
            this.fetch.Iconimage_right_Selected = null;
            this.fetch.Iconimage_Selected = null;
            this.fetch.IconMarginLeft = 0;
            this.fetch.IconMarginRight = 0;
            this.fetch.IconRightVisible = true;
            this.fetch.IconRightZoom = 0D;
            this.fetch.IconVisible = true;
            this.fetch.IconZoom = 90D;
            this.fetch.IsTab = false;
            this.fetch.Location = new System.Drawing.Point(858, 12);
            this.fetch.Name = "fetch";
            this.fetch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fetch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fetch.OnHoverTextColor = System.Drawing.Color.White;
            this.fetch.selected = false;
            this.fetch.Size = new System.Drawing.Size(187, 31);
            this.fetch.TabIndex = 97;
            this.fetch.Text = "Fetch Record";
            this.fetch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fetch.Textcolor = System.Drawing.Color.White;
            this.fetch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // LVreport
            // 
            this.LVreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVreport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader95});
            this.epeks.SetDecoration(this.LVreport, BunifuAnimatorNS.DecorationType.None);
            this.LVreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVreport.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVreport.FullRowSelect = true;
            this.LVreport.GridLines = true;
            this.LVreport.HoverSelection = true;
            this.LVreport.Location = new System.Drawing.Point(13, 75);
            this.LVreport.Name = "LVreport";
            this.LVreport.Size = new System.Drawing.Size(1130, 412);
            this.LVreport.TabIndex = 138;
            this.LVreport.UseCompatibleStateImageBehavior = false;
            this.LVreport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "P.O. No.";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "R.I.S. No.";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ITEM No.";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ITEM NAME";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "UNIT";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "QTY";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ENDING";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "DEPARTMENT";
            this.columnHeader10.Width = 130;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "REQUESTED BY";
            this.columnHeader11.Width = 130;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "RECEIVED BY";
            this.columnHeader12.Width = 110;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ISSUED BY";
            this.columnHeader13.Width = 130;
            // 
            // columnHeader95
            // 
            this.columnHeader95.Text = "DATE";
            this.columnHeader95.Width = 130;
            // 
            // panel47
            // 
            this.panel47.BackColor = System.Drawing.Color.Green;
            this.panel47.Controls.Add(this.label101);
            this.panel47.Controls.Add(this.cblogreceived);
            this.panel47.Controls.Add(this.label100);
            this.panel47.Controls.Add(this.cblogissued);
            this.panel47.Controls.Add(this.panel50);
            this.panel47.Controls.Add(this.label99);
            this.panel47.Controls.Add(this.cblogreq);
            this.epeks.SetDecoration(this.panel47, BunifuAnimatorNS.DecorationType.None);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel47.Location = new System.Drawing.Point(13, 493);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(1130, 67);
            this.panel47.TabIndex = 139;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.epeks.SetDecoration(this.label101, BunifuAnimatorNS.DecorationType.None);
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = System.Drawing.Color.LightGreen;
            this.label101.Location = new System.Drawing.Point(620, 7);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(111, 20);
            this.label101.TabIndex = 144;
            this.label101.Text = "Received by:";
            // 
            // cblogreceived
            // 
            this.epeks.SetDecoration(this.cblogreceived, BunifuAnimatorNS.DecorationType.None);
            this.cblogreceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblogreceived.FormattingEnabled = true;
            this.cblogreceived.Location = new System.Drawing.Point(624, 30);
            this.cblogreceived.Name = "cblogreceived";
            this.cblogreceived.Size = new System.Drawing.Size(275, 28);
            this.cblogreceived.TabIndex = 143;
            this.cblogreceived.Text = "Select";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.epeks.SetDecoration(this.label100, BunifuAnimatorNS.DecorationType.None);
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.Color.LightGreen;
            this.label100.Location = new System.Drawing.Point(323, 7);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(91, 20);
            this.label100.TabIndex = 142;
            this.label100.Text = "Issued by:";
            // 
            // cblogissued
            // 
            this.epeks.SetDecoration(this.cblogissued, BunifuAnimatorNS.DecorationType.None);
            this.cblogissued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblogissued.FormattingEnabled = true;
            this.cblogissued.Location = new System.Drawing.Point(327, 30);
            this.cblogissued.Name = "cblogissued";
            this.cblogissued.Size = new System.Drawing.Size(275, 28);
            this.cblogissued.TabIndex = 141;
            this.cblogissued.Text = "Select";
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.btnprint);
            this.epeks.SetDecoration(this.panel50, BunifuAnimatorNS.DecorationType.None);
            this.panel50.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel50.Location = new System.Drawing.Point(922, 0);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(208, 67);
            this.panel50.TabIndex = 140;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnprint.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnprint.colorActive = System.Drawing.Color.Lime;
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnprint, BunifuAnimatorNS.DecorationType.None);
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImagePosition = 6;
            this.btnprint.ImageZoom = 20;
            this.btnprint.LabelPosition = 27;
            this.btnprint.LabelText = "PRINT";
            this.btnprint.Location = new System.Drawing.Point(46, 14);
            this.btnprint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(147, 44);
            this.btnprint.TabIndex = 137;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.epeks.SetDecoration(this.label99, BunifuAnimatorNS.DecorationType.None);
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.LightGreen;
            this.label99.Location = new System.Drawing.Point(21, 7);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(125, 20);
            this.label99.TabIndex = 139;
            this.label99.Text = "Requested by:";
            // 
            // cblogreq
            // 
            this.epeks.SetDecoration(this.cblogreq, BunifuAnimatorNS.DecorationType.None);
            this.cblogreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblogreq.FormattingEnabled = true;
            this.cblogreq.Location = new System.Drawing.Point(25, 30);
            this.cblogreq.Name = "cblogreq";
            this.cblogreq.Size = new System.Drawing.Size(275, 28);
            this.cblogreq.TabIndex = 138;
            this.cblogreq.Text = "Select";
            // 
            // panelRIS
            // 
            this.panelRIS.Controls.Add(this.tableLayoutPanel27);
            this.epeks.SetDecoration(this.panelRIS, BunifuAnimatorNS.DecorationType.None);
            this.panelRIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRIS.Location = new System.Drawing.Point(0, 63);
            this.panelRIS.Name = "panelRIS";
            this.panelRIS.Size = new System.Drawing.Size(1177, 617);
            this.panelRIS.TabIndex = 29;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 4;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel27.Controls.Add(this.LVRIS, 2, 2);
            this.tableLayoutPanel27.Controls.Add(this.panel41, 2, 3);
            this.tableLayoutPanel27.Controls.Add(this.panel37, 2, 1);
            this.tableLayoutPanel27.Controls.Add(this.panel38, 1, 1);
            this.tableLayoutPanel27.Controls.Add(this.tableLayoutPanel29, 1, 2);
            this.tableLayoutPanel27.Controls.Add(this.panel42, 1, 3);
            this.epeks.SetDecoration(this.tableLayoutPanel27, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 4;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(1177, 617);
            this.tableLayoutPanel27.TabIndex = 122;
            // 
            // LVRIS
            // 
            this.LVRIS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader71,
            this.columnHeader72,
            this.columnHeader73,
            this.columnHeader74,
            this.columnHeader79,
            this.columnHeader89});
            this.epeks.SetDecoration(this.LVRIS, BunifuAnimatorNS.DecorationType.None);
            this.LVRIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVRIS.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVRIS.FullRowSelect = true;
            this.LVRIS.GridLines = true;
            this.LVRIS.HideSelection = false;
            this.LVRIS.Location = new System.Drawing.Point(422, 83);
            this.LVRIS.Name = "LVRIS";
            this.LVRIS.Size = new System.Drawing.Size(741, 470);
            this.LVRIS.TabIndex = 111;
            this.LVRIS.UseCompatibleStateImageBehavior = false;
            this.LVRIS.View = System.Windows.Forms.View.Details;
            this.LVRIS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVRIS_MouseClick);
            // 
            // columnHeader71
            // 
            this.columnHeader71.Text = "PO ID";
            this.columnHeader71.Width = 130;
            // 
            // columnHeader72
            // 
            this.columnHeader72.Text = "ITEM ID";
            this.columnHeader72.Width = 130;
            // 
            // columnHeader73
            // 
            this.columnHeader73.Text = "QTY";
            this.columnHeader73.Width = 130;
            // 
            // columnHeader74
            // 
            this.columnHeader74.Text = "UNIT";
            this.columnHeader74.Width = 150;
            // 
            // columnHeader79
            // 
            this.columnHeader79.Text = "DESCRIPTION";
            this.columnHeader79.Width = 150;
            // 
            // columnHeader89
            // 
            this.columnHeader89.Text = "ENDING";
            this.columnHeader89.Width = 150;
            // 
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.Color.PaleGreen;
            this.panel41.Controls.Add(this.btnPrintRIS);
            this.panel41.Controls.Add(this.btnSaveRIS);
            this.epeks.SetDecoration(this.panel41, BunifuAnimatorNS.DecorationType.None);
            this.panel41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel41.Location = new System.Drawing.Point(422, 559);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(741, 55);
            this.panel41.TabIndex = 117;
            // 
            // btnPrintRIS
            // 
            this.btnPrintRIS.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnPrintRIS.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPrintRIS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintRIS.BorderRadius = 5;
            this.btnPrintRIS.ButtonText = "PRINT";
            this.btnPrintRIS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnPrintRIS, BunifuAnimatorNS.DecorationType.None);
            this.btnPrintRIS.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintRIS.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintRIS.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintRIS.Iconimage")));
            this.btnPrintRIS.Iconimage_right = null;
            this.btnPrintRIS.Iconimage_right_Selected = null;
            this.btnPrintRIS.Iconimage_Selected = null;
            this.btnPrintRIS.IconMarginLeft = 0;
            this.btnPrintRIS.IconMarginRight = 0;
            this.btnPrintRIS.IconRightVisible = true;
            this.btnPrintRIS.IconRightZoom = 0D;
            this.btnPrintRIS.IconVisible = true;
            this.btnPrintRIS.IconZoom = 60D;
            this.btnPrintRIS.IsTab = false;
            this.btnPrintRIS.Location = new System.Drawing.Point(138, 5);
            this.btnPrintRIS.Name = "btnPrintRIS";
            this.btnPrintRIS.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnPrintRIS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrintRIS.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintRIS.selected = false;
            this.btnPrintRIS.Size = new System.Drawing.Size(120, 48);
            this.btnPrintRIS.TabIndex = 113;
            this.btnPrintRIS.Text = "PRINT";
            this.btnPrintRIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintRIS.Textcolor = System.Drawing.Color.White;
            this.btnPrintRIS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintRIS.Click += new System.EventHandler(this.btnPrintRIS_Click);
            // 
            // btnSaveRIS
            // 
            this.btnSaveRIS.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnSaveRIS.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSaveRIS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveRIS.BorderRadius = 5;
            this.btnSaveRIS.ButtonText = "    SAVE";
            this.btnSaveRIS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnSaveRIS, BunifuAnimatorNS.DecorationType.None);
            this.btnSaveRIS.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveRIS.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveRIS.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveRIS.Iconimage")));
            this.btnSaveRIS.Iconimage_right = null;
            this.btnSaveRIS.Iconimage_right_Selected = null;
            this.btnSaveRIS.Iconimage_Selected = null;
            this.btnSaveRIS.IconMarginLeft = 20;
            this.btnSaveRIS.IconMarginRight = 0;
            this.btnSaveRIS.IconRightVisible = true;
            this.btnSaveRIS.IconRightZoom = 0D;
            this.btnSaveRIS.IconVisible = true;
            this.btnSaveRIS.IconZoom = 60D;
            this.btnSaveRIS.IsTab = false;
            this.btnSaveRIS.Location = new System.Drawing.Point(3, 4);
            this.btnSaveRIS.Name = "btnSaveRIS";
            this.btnSaveRIS.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnSaveRIS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveRIS.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveRIS.selected = false;
            this.btnSaveRIS.Size = new System.Drawing.Size(129, 49);
            this.btnSaveRIS.TabIndex = 114;
            this.btnSaveRIS.Text = "    SAVE";
            this.btnSaveRIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveRIS.Textcolor = System.Drawing.Color.White;
            this.btnSaveRIS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRIS.Click += new System.EventHandler(this.btnSaveRIS_Click);
            // 
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.Color.LightGreen;
            this.panel37.Controls.Add(this.tableLayoutPanel28);
            this.epeks.SetDecoration(this.panel37, BunifuAnimatorNS.DecorationType.None);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel37.Location = new System.Drawing.Point(422, 11);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(741, 66);
            this.panel37.TabIndex = 115;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.ColumnCount = 4;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel28.Controls.Add(this.btndeleteris, 3, 1);
            this.tableLayoutPanel28.Controls.Add(this.btnsearch, 1, 1);
            this.tableLayoutPanel28.Controls.Add(this.btneditris, 2, 1);
            this.tableLayoutPanel28.Controls.Add(this.tableLayoutPanel31, 0, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel28, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 3;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(741, 66);
            this.tableLayoutPanel28.TabIndex = 0;
            // 
            // btndeleteris
            // 
            this.btndeleteris.Activecolor = System.Drawing.Color.LimeGreen;
            this.btndeleteris.BackColor = System.Drawing.Color.DarkGreen;
            this.btndeleteris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndeleteris.BorderRadius = 5;
            this.btndeleteris.ButtonText = "    DELETE";
            this.btndeleteris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btndeleteris, BunifuAnimatorNS.DecorationType.None);
            this.btndeleteris.DisabledColor = System.Drawing.Color.Gray;
            this.btndeleteris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndeleteris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteris.Iconcolor = System.Drawing.Color.Transparent;
            this.btndeleteris.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndeleteris.Iconimage")));
            this.btndeleteris.Iconimage_right = null;
            this.btndeleteris.Iconimage_right_Selected = null;
            this.btndeleteris.Iconimage_Selected = null;
            this.btndeleteris.IconMarginLeft = 20;
            this.btndeleteris.IconMarginRight = 0;
            this.btndeleteris.IconRightVisible = true;
            this.btndeleteris.IconRightZoom = 0D;
            this.btndeleteris.IconVisible = true;
            this.btndeleteris.IconZoom = 50D;
            this.btndeleteris.IsTab = false;
            this.btndeleteris.Location = new System.Drawing.Point(575, 6);
            this.btndeleteris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndeleteris.Name = "btndeleteris";
            this.btndeleteris.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btndeleteris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndeleteris.OnHoverTextColor = System.Drawing.Color.White;
            this.btndeleteris.selected = false;
            this.btndeleteris.Size = new System.Drawing.Size(162, 54);
            this.btndeleteris.TabIndex = 114;
            this.btndeleteris.Text = "    DELETE";
            this.btndeleteris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeleteris.Textcolor = System.Drawing.Color.White;
            this.btndeleteris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteris.Click += new System.EventHandler(this.btndeleteris_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnsearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearch.BorderRadius = 5;
            this.btnsearch.ButtonText = "    SEARCH";
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnsearch, BunifuAnimatorNS.DecorationType.None);
            this.btnsearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsearch.Iconimage")));
            this.btnsearch.Iconimage_right = null;
            this.btnsearch.Iconimage_right_Selected = null;
            this.btnsearch.Iconimage_Selected = null;
            this.btnsearch.IconMarginLeft = 20;
            this.btnsearch.IconMarginRight = 0;
            this.btnsearch.IconRightVisible = true;
            this.btnsearch.IconRightZoom = 0D;
            this.btnsearch.IconVisible = true;
            this.btnsearch.IconZoom = 50D;
            this.btnsearch.IsTab = false;
            this.btnsearch.Location = new System.Drawing.Point(235, 6);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnsearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsearch.selected = false;
            this.btnsearch.Size = new System.Drawing.Size(162, 54);
            this.btnsearch.TabIndex = 114;
            this.btnsearch.Text = "    SEARCH";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Textcolor = System.Drawing.Color.White;
            this.btnsearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btneditris
            // 
            this.btneditris.Activecolor = System.Drawing.Color.LimeGreen;
            this.btneditris.BackColor = System.Drawing.Color.DarkGreen;
            this.btneditris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditris.BorderRadius = 5;
            this.btneditris.ButtonText = "    EDIT";
            this.btneditris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btneditris, BunifuAnimatorNS.DecorationType.None);
            this.btneditris.DisabledColor = System.Drawing.Color.Gray;
            this.btneditris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btneditris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditris.Iconcolor = System.Drawing.Color.Transparent;
            this.btneditris.Iconimage = ((System.Drawing.Image)(resources.GetObject("btneditris.Iconimage")));
            this.btneditris.Iconimage_right = null;
            this.btneditris.Iconimage_right_Selected = null;
            this.btneditris.Iconimage_Selected = null;
            this.btneditris.IconMarginLeft = 20;
            this.btneditris.IconMarginRight = 0;
            this.btneditris.IconRightVisible = true;
            this.btneditris.IconRightZoom = 0D;
            this.btneditris.IconVisible = true;
            this.btneditris.IconZoom = 50D;
            this.btneditris.IsTab = false;
            this.btneditris.Location = new System.Drawing.Point(405, 6);
            this.btneditris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneditris.Name = "btneditris";
            this.btneditris.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btneditris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btneditris.OnHoverTextColor = System.Drawing.Color.White;
            this.btneditris.selected = false;
            this.btneditris.Size = new System.Drawing.Size(162, 54);
            this.btneditris.TabIndex = 114;
            this.btneditris.Text = "    EDIT";
            this.btneditris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditris.Textcolor = System.Drawing.Color.White;
            this.btneditris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditris.Click += new System.EventHandler(this.btneditris_Click);
            // 
            // tableLayoutPanel31
            // 
            this.tableLayoutPanel31.ColumnCount = 2;
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9434F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0566F));
            this.tableLayoutPanel31.Controls.Add(this.tbRisID, 1, 0);
            this.tableLayoutPanel31.Controls.Add(this.tableLayoutPanel32, 0, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel31, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel31.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel31.Name = "tableLayoutPanel31";
            this.tableLayoutPanel31.RowCount = 1;
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel31.Size = new System.Drawing.Size(225, 56);
            this.tableLayoutPanel31.TabIndex = 115;
            // 
            // tbRisID
            // 
            this.tbRisID.BackColor = System.Drawing.Color.White;
            this.tbRisID.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbRisID.BorderColorIdle = System.Drawing.Color.Green;
            this.tbRisID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbRisID.BorderThickness = 3;
            this.tbRisID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbRisID, BunifuAnimatorNS.DecorationType.None);
            this.tbRisID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRisID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRisID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbRisID.isPassword = false;
            this.tbRisID.Location = new System.Drawing.Point(62, 4);
            this.tbRisID.Margin = new System.Windows.Forms.Padding(4);
            this.tbRisID.Name = "tbRisID";
            this.tbRisID.Size = new System.Drawing.Size(159, 48);
            this.tbRisID.TabIndex = 122;
            this.tbRisID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tableLayoutPanel32
            // 
            this.tableLayoutPanel32.ColumnCount = 1;
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel32.Controls.Add(this.label18, 1, 1);
            this.epeks.SetDecoration(this.tableLayoutPanel32, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel32.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel32.Name = "tableLayoutPanel32";
            this.tableLayoutPanel32.RowCount = 3;
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel32.Size = new System.Drawing.Size(52, 50);
            this.tableLayoutPanel32.TabIndex = 123;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.epeks.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(3, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 27);
            this.label18.TabIndex = 112;
            this.label18.Text = "RIS NO:";
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.Green;
            this.panel38.Controls.Add(this.label20);
            this.epeks.SetDecoration(this.panel38, BunifuAnimatorNS.DecorationType.None);
            this.panel38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel38.Location = new System.Drawing.Point(12, 11);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(404, 66);
            this.panel38.TabIndex = 116;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.epeks.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(10, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 33);
            this.label20.TabIndex = 111;
            this.label20.Text = "Personnel";
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.BackColor = System.Drawing.Color.PaleGreen;
            this.tableLayoutPanel29.ColumnCount = 2;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.97113F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.02887F));
            this.tableLayoutPanel29.Controls.Add(this.cbissued, 1, 4);
            this.tableLayoutPanel29.Controls.Add(this.label84, 0, 4);
            this.tableLayoutPanel29.Controls.Add(this.cbreceived, 1, 3);
            this.tableLayoutPanel29.Controls.Add(this.label82, 0, 2);
            this.tableLayoutPanel29.Controls.Add(this.cbdept, 1, 2);
            this.tableLayoutPanel29.Controls.Add(this.label83, 0, 3);
            this.tableLayoutPanel29.Controls.Add(this.label81, 0, 1);
            this.tableLayoutPanel29.Controls.Add(this.cbrequest, 1, 1);
            this.tableLayoutPanel29.Controls.Add(this.label77, 0, 0);
            this.tableLayoutPanel29.Controls.Add(this.dtrisdate, 1, 0);
            this.epeks.SetDecoration(this.tableLayoutPanel29, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(12, 83);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel29.RowCount = 6;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(404, 470);
            this.tableLayoutPanel29.TabIndex = 113;
            // 
            // cbissued
            // 
            this.epeks.SetDecoration(this.cbissued, BunifuAnimatorNS.DecorationType.None);
            this.cbissued.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbissued.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbissued.FormattingEnabled = true;
            this.cbissued.Location = new System.Drawing.Point(131, 184);
            this.cbissued.Name = "cbissued";
            this.cbissued.Size = new System.Drawing.Size(260, 32);
            this.cbissued.TabIndex = 120;
            this.cbissued.Text = "Select";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.epeks.SetDecoration(this.label84, BunifuAnimatorNS.DecorationType.None);
            this.label84.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label84.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(13, 181);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(112, 40);
            this.label84.TabIndex = 121;
            this.label84.Text = "Issued by:";
            // 
            // cbreceived
            // 
            this.epeks.SetDecoration(this.cbreceived, BunifuAnimatorNS.DecorationType.None);
            this.cbreceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbreceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbreceived.FormattingEnabled = true;
            this.cbreceived.Location = new System.Drawing.Point(131, 142);
            this.cbreceived.Name = "cbreceived";
            this.cbreceived.Size = new System.Drawing.Size(260, 32);
            this.cbreceived.TabIndex = 118;
            this.cbreceived.Text = "Select";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.epeks.SetDecoration(this.label82, BunifuAnimatorNS.DecorationType.None);
            this.label82.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label82.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(13, 97);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(112, 42);
            this.label82.TabIndex = 117;
            this.label82.Text = "Department:";
            // 
            // cbdept
            // 
            this.epeks.SetDecoration(this.cbdept, BunifuAnimatorNS.DecorationType.None);
            this.cbdept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdept.FormattingEnabled = true;
            this.cbdept.Location = new System.Drawing.Point(131, 100);
            this.cbdept.Name = "cbdept";
            this.cbdept.Size = new System.Drawing.Size(260, 32);
            this.cbdept.TabIndex = 116;
            this.cbdept.Text = "Select";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.epeks.SetDecoration(this.label83, BunifuAnimatorNS.DecorationType.None);
            this.label83.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label83.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(13, 139);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(112, 42);
            this.label83.TabIndex = 119;
            this.label83.Text = "Received:";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.epeks.SetDecoration(this.label81, BunifuAnimatorNS.DecorationType.None);
            this.label81.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(13, 55);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(101, 36);
            this.label81.TabIndex = 115;
            this.label81.Text = "Requested by:";
            // 
            // cbrequest
            // 
            this.epeks.SetDecoration(this.cbrequest, BunifuAnimatorNS.DecorationType.None);
            this.cbrequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrequest.FormattingEnabled = true;
            this.cbrequest.Location = new System.Drawing.Point(131, 58);
            this.cbrequest.Name = "cbrequest";
            this.cbrequest.Size = new System.Drawing.Size(257, 32);
            this.cbrequest.TabIndex = 112;
            this.cbrequest.Text = "Select";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.epeks.SetDecoration(this.label77, BunifuAnimatorNS.DecorationType.None);
            this.label77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label77.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(13, 10);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(112, 45);
            this.label77.TabIndex = 115;
            this.label77.Text = "Date:";
            // 
            // dtrisdate
            // 
            this.dtrisdate.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.dtrisdate, BunifuAnimatorNS.DecorationType.None);
            this.dtrisdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrisdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtrisdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtrisdate.Location = new System.Drawing.Point(131, 13);
            this.dtrisdate.Name = "dtrisdate";
            this.dtrisdate.Size = new System.Drawing.Size(260, 30);
            this.dtrisdate.TabIndex = 142;
            // 
            // panel42
            // 
            this.panel42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel42.Controls.Add(this.RisLogs);
            this.epeks.SetDecoration(this.panel42, BunifuAnimatorNS.DecorationType.None);
            this.panel42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel42.Location = new System.Drawing.Point(12, 559);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(404, 55);
            this.panel42.TabIndex = 118;
            // 
            // RisLogs
            // 
            this.RisLogs.Activecolor = System.Drawing.Color.LimeGreen;
            this.RisLogs.BackColor = System.Drawing.Color.DarkGreen;
            this.RisLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RisLogs.BorderRadius = 5;
            this.RisLogs.ButtonText = "    LOG HISTORY";
            this.RisLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.RisLogs, BunifuAnimatorNS.DecorationType.None);
            this.RisLogs.DisabledColor = System.Drawing.Color.Gray;
            this.RisLogs.Iconcolor = System.Drawing.Color.Transparent;
            this.RisLogs.Iconimage = ((System.Drawing.Image)(resources.GetObject("RisLogs.Iconimage")));
            this.RisLogs.Iconimage_right = null;
            this.RisLogs.Iconimage_right_Selected = null;
            this.RisLogs.Iconimage_Selected = null;
            this.RisLogs.IconMarginLeft = 20;
            this.RisLogs.IconMarginRight = 0;
            this.RisLogs.IconRightVisible = true;
            this.RisLogs.IconRightZoom = 0D;
            this.RisLogs.IconVisible = true;
            this.RisLogs.IconZoom = 60D;
            this.RisLogs.IsTab = false;
            this.RisLogs.Location = new System.Drawing.Point(6, 3);
            this.RisLogs.Name = "RisLogs";
            this.RisLogs.Normalcolor = System.Drawing.Color.DarkGreen;
            this.RisLogs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RisLogs.OnHoverTextColor = System.Drawing.Color.White;
            this.RisLogs.selected = false;
            this.RisLogs.Size = new System.Drawing.Size(184, 49);
            this.RisLogs.TabIndex = 114;
            this.RisLogs.Text = "    LOG HISTORY";
            this.RisLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RisLogs.Textcolor = System.Drawing.Color.White;
            this.RisLogs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RisLogs.Click += new System.EventHandler(this.RisLogs_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Green;
            this.panel13.Controls.Add(this.lblBadge);
            this.panel13.Controls.Add(this.label19);
            this.panel13.Controls.Add(this.btnNotifExpired);
            this.epeks.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1177, 63);
            this.panel13.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.epeks.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(27, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(231, 33);
            this.label19.TabIndex = 110;
            this.label19.Text = "Notification Logs";
            // 
            // btnNotifExpired
            // 
            this.btnNotifExpired.BackColor = System.Drawing.Color.Green;
            this.epeks.SetDecoration(this.btnNotifExpired, BunifuAnimatorNS.DecorationType.None);
            this.btnNotifExpired.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifExpired.Image")));
            this.btnNotifExpired.ImageActive = null;
            this.btnNotifExpired.Location = new System.Drawing.Point(264, 4);
            this.btnNotifExpired.Name = "btnNotifExpired";
            this.btnNotifExpired.Size = new System.Drawing.Size(59, 54);
            this.btnNotifExpired.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNotifExpired.TabIndex = 113;
            this.btnNotifExpired.TabStop = false;
            this.btnNotifExpired.Zoom = 10;
            // 
            // tInventory
            // 
            this.tInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tInventory.ColumnCount = 3;
            this.tInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tInventory.Controls.Add(this.LVPO, 1, 3);
            this.tInventory.Controls.Add(this.panel33, 1, 4);
            this.tInventory.Controls.Add(this.panel11, 1, 2);
            this.epeks.SetDecoration(this.tInventory, BunifuAnimatorNS.DecorationType.None);
            this.tInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tInventory.Location = new System.Drawing.Point(0, 0);
            this.tInventory.Name = "tInventory";
            this.tInventory.RowCount = 5;
            this.tInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tInventory.Size = new System.Drawing.Size(1177, 680);
            this.tInventory.TabIndex = 3;
            // 
            // LVPO
            // 
            this.LVPO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVPO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader55,
            this.columnHeader56,
            this.columnHeader57,
            this.columnHeader58,
            this.columnHeader59,
            this.columnHeader60,
            this.columnHeader61,
            this.columnHeader70,
            this.columnHeader80,
            this.columnHeader81,
            this.columnHeader82,
            this.columnHeader83});
            this.epeks.SetDecoration(this.LVPO, BunifuAnimatorNS.DecorationType.None);
            this.LVPO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVPO.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVPO.FullRowSelect = true;
            this.LVPO.GridLines = true;
            this.LVPO.HideSelection = false;
            this.LVPO.Location = new System.Drawing.Point(11, 141);
            this.LVPO.Name = "LVPO";
            this.LVPO.Size = new System.Drawing.Size(1155, 465);
            this.LVPO.TabIndex = 113;
            this.LVPO.UseCompatibleStateImageBehavior = false;
            this.LVPO.View = System.Windows.Forms.View.Details;
            this.LVPO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVPO_MouseClick);
            this.LVPO.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LVPO_MouseDoubleClick);
            // 
            // columnHeader55
            // 
            this.columnHeader55.Text = "ITEM ID";
            this.columnHeader55.Width = 120;
            // 
            // columnHeader56
            // 
            this.columnHeader56.Text = "QTY";
            this.columnHeader56.Width = 100;
            // 
            // columnHeader57
            // 
            this.columnHeader57.Text = "UNIT";
            this.columnHeader57.Width = 120;
            // 
            // columnHeader58
            // 
            this.columnHeader58.Text = "ITEM NAME";
            this.columnHeader58.Width = 120;
            // 
            // columnHeader59
            // 
            this.columnHeader59.Text = "UNIT PRICE";
            this.columnHeader59.Width = 120;
            // 
            // columnHeader60
            // 
            this.columnHeader60.Text = "AMOUNT";
            this.columnHeader60.Width = 120;
            // 
            // columnHeader61
            // 
            this.columnHeader61.Text = "SUPPLIER";
            this.columnHeader61.Width = 120;
            // 
            // columnHeader70
            // 
            this.columnHeader70.Text = "CATEGORY";
            this.columnHeader70.Width = 120;
            // 
            // columnHeader80
            // 
            this.columnHeader80.Text = "PO ID";
            this.columnHeader80.Width = 120;
            // 
            // columnHeader81
            // 
            this.columnHeader81.Text = "RE-ORDER LVL";
            this.columnHeader81.Width = 120;
            // 
            // columnHeader82
            // 
            this.columnHeader82.Text = "MO EXPIRE DATE";
            this.columnHeader82.Width = 120;
            // 
            // columnHeader83
            // 
            this.columnHeader83.Text = "EXPIRED DATE";
            this.columnHeader83.Width = 120;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.LightGreen;
            this.panel33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel33.Controls.Add(this.panel44);
            this.epeks.SetDecoration(this.panel33, BunifuAnimatorNS.DecorationType.None);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(11, 612);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(1155, 65);
            this.panel33.TabIndex = 114;
            // 
            // panel44
            // 
            this.panel44.BackColor = System.Drawing.Color.DarkGreen;
            this.panel44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel44.Controls.Add(this.panel46);
            this.panel44.Controls.Add(this.label98);
            this.panel44.Controls.Add(this.label97);
            this.panel44.Controls.Add(this.cbapprovedpo);
            this.panel44.Controls.Add(this.cbreqbypo);
            this.epeks.SetDecoration(this.panel44, BunifuAnimatorNS.DecorationType.None);
            this.panel44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel44.Location = new System.Drawing.Point(0, 0);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(1153, 63);
            this.panel44.TabIndex = 144;
            // 
            // panel46
            // 
            this.panel46.Controls.Add(this.logsToday);
            this.panel46.Controls.Add(this.btnpoprint);
            this.epeks.SetDecoration(this.panel46, BunifuAnimatorNS.DecorationType.None);
            this.panel46.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel46.Location = new System.Drawing.Point(798, 0);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(353, 61);
            this.panel46.TabIndex = 152;
            // 
            // logsToday
            // 
            this.logsToday.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.logsToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.logsToday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logsToday.BorderRadius = 5;
            this.logsToday.ButtonText = "     LOG HISTORY";
            this.logsToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.logsToday, BunifuAnimatorNS.DecorationType.None);
            this.logsToday.DisabledColor = System.Drawing.Color.ForestGreen;
            this.logsToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsToday.ForeColor = System.Drawing.Color.Lime;
            this.logsToday.Iconcolor = System.Drawing.Color.Transparent;
            this.logsToday.Iconimage = ((System.Drawing.Image)(resources.GetObject("logsToday.Iconimage")));
            this.logsToday.Iconimage_right = null;
            this.logsToday.Iconimage_right_Selected = null;
            this.logsToday.Iconimage_Selected = null;
            this.logsToday.IconMarginLeft = 0;
            this.logsToday.IconMarginRight = 0;
            this.logsToday.IconRightVisible = true;
            this.logsToday.IconRightZoom = 0D;
            this.logsToday.IconVisible = true;
            this.logsToday.IconZoom = 50D;
            this.logsToday.IsTab = false;
            this.logsToday.Location = new System.Drawing.Point(13, 7);
            this.logsToday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logsToday.Name = "logsToday";
            this.logsToday.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.logsToday.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.logsToday.OnHoverTextColor = System.Drawing.Color.White;
            this.logsToday.selected = false;
            this.logsToday.Size = new System.Drawing.Size(174, 48);
            this.logsToday.TabIndex = 153;
            this.logsToday.Text = "     LOG HISTORY";
            this.logsToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logsToday.Textcolor = System.Drawing.Color.White;
            this.logsToday.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsToday.Click += new System.EventHandler(this.logsToday_Click);
            // 
            // btnpoprint
            // 
            this.btnpoprint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpoprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpoprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpoprint.BorderRadius = 5;
            this.btnpoprint.ButtonText = "     PRINT";
            this.btnpoprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnpoprint, BunifuAnimatorNS.DecorationType.None);
            this.btnpoprint.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btnpoprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoprint.ForeColor = System.Drawing.Color.Lime;
            this.btnpoprint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnpoprint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnpoprint.Iconimage")));
            this.btnpoprint.Iconimage_right = null;
            this.btnpoprint.Iconimage_right_Selected = null;
            this.btnpoprint.Iconimage_Selected = null;
            this.btnpoprint.IconMarginLeft = 0;
            this.btnpoprint.IconMarginRight = 0;
            this.btnpoprint.IconRightVisible = true;
            this.btnpoprint.IconRightZoom = 0D;
            this.btnpoprint.IconVisible = true;
            this.btnpoprint.IconZoom = 50D;
            this.btnpoprint.IsTab = false;
            this.btnpoprint.Location = new System.Drawing.Point(201, 6);
            this.btnpoprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpoprint.Name = "btnpoprint";
            this.btnpoprint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpoprint.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnpoprint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnpoprint.selected = false;
            this.btnpoprint.Size = new System.Drawing.Size(142, 48);
            this.btnpoprint.TabIndex = 73;
            this.btnpoprint.Text = "     PRINT";
            this.btnpoprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpoprint.Textcolor = System.Drawing.Color.White;
            this.btnpoprint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoprint.Click += new System.EventHandler(this.btnpoprint_Click);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.epeks.SetDecoration(this.label98, BunifuAnimatorNS.DecorationType.None);
            this.label98.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label98.Location = new System.Drawing.Point(433, 20);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(116, 18);
            this.label98.TabIndex = 150;
            this.label98.Text = "Approved by:";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.epeks.SetDecoration(this.label97, BunifuAnimatorNS.DecorationType.None);
            this.label97.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label97.Location = new System.Drawing.Point(3, 20);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(127, 18);
            this.label97.TabIndex = 151;
            this.label97.Text = "Requested by:";
            // 
            // cbapprovedpo
            // 
            this.epeks.SetDecoration(this.cbapprovedpo, BunifuAnimatorNS.DecorationType.None);
            this.cbapprovedpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbapprovedpo.FormattingEnabled = true;
            this.cbapprovedpo.Location = new System.Drawing.Point(551, 13);
            this.cbapprovedpo.Name = "cbapprovedpo";
            this.cbapprovedpo.Size = new System.Drawing.Size(264, 32);
            this.cbapprovedpo.TabIndex = 147;
            this.cbapprovedpo.Text = "Dra. Rosalie P. Hidalgo";
            this.cbapprovedpo.SelectedIndexChanged += new System.EventHandler(this.cbapprovedpo_SelectedIndexChanged);
            // 
            // cbreqbypo
            // 
            this.epeks.SetDecoration(this.cbreqbypo, BunifuAnimatorNS.DecorationType.None);
            this.cbreqbypo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbreqbypo.FormattingEnabled = true;
            this.cbreqbypo.Location = new System.Drawing.Point(132, 14);
            this.cbreqbypo.Name = "cbreqbypo";
            this.cbreqbypo.Size = new System.Drawing.Size(264, 32);
            this.cbreqbypo.TabIndex = 148;
            this.cbreqbypo.Text = "Rielmer John A Isidro";
            this.cbreqbypo.SelectedIndexChanged += new System.EventHandler(this.cbreqbypo_SelectedIndexChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Green;
            this.panel11.Controls.Add(this.panel8);
            this.panel11.Controls.Add(this.btnaddexistingpo);
            this.panel11.Controls.Add(this.btnpoupdate);
            this.panel11.Controls.Add(this.btnpodelete);
            this.panel11.Controls.Add(this.btnposave);
            this.panel11.Controls.Add(this.tbsearchpo);
            this.epeks.SetDecoration(this.panel11, BunifuAnimatorNS.DecorationType.None);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(11, 73);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1155, 62);
            this.panel11.TabIndex = 112;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label76);
            this.panel8.Controls.Add(this.dtpodate);
            this.epeks.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(838, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(317, 62);
            this.panel8.TabIndex = 142;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.epeks.SetDecoration(this.label76, BunifuAnimatorNS.DecorationType.None);
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label76.Location = new System.Drawing.Point(10, 19);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(59, 25);
            this.label76.TabIndex = 112;
            this.label76.Text = "Date:";
            // 
            // dtpodate
            // 
            this.dtpodate.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.dtpodate, BunifuAnimatorNS.DecorationType.None);
            this.dtpodate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpodate.Location = new System.Drawing.Point(75, 16);
            this.dtpodate.Name = "dtpodate";
            this.dtpodate.Size = new System.Drawing.Size(232, 30);
            this.dtpodate.TabIndex = 141;
            // 
            // btnaddexistingpo
            // 
            this.btnaddexistingpo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnaddexistingpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnaddexistingpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddexistingpo.BorderRadius = 5;
            this.btnaddexistingpo.ButtonText = "     ADD ITEM FROM EXISTING P.O I.D.";
            this.btnaddexistingpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnaddexistingpo, BunifuAnimatorNS.DecorationType.None);
            this.btnaddexistingpo.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btnaddexistingpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddexistingpo.ForeColor = System.Drawing.Color.Lime;
            this.btnaddexistingpo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnaddexistingpo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnaddexistingpo.Iconimage")));
            this.btnaddexistingpo.Iconimage_right = null;
            this.btnaddexistingpo.Iconimage_right_Selected = null;
            this.btnaddexistingpo.Iconimage_Selected = null;
            this.btnaddexistingpo.IconMarginLeft = 0;
            this.btnaddexistingpo.IconMarginRight = 0;
            this.btnaddexistingpo.IconRightVisible = true;
            this.btnaddexistingpo.IconRightZoom = 0D;
            this.btnaddexistingpo.IconVisible = true;
            this.btnaddexistingpo.IconZoom = 50D;
            this.btnaddexistingpo.IsTab = false;
            this.btnaddexistingpo.Location = new System.Drawing.Point(635, 8);
            this.btnaddexistingpo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaddexistingpo.Name = "btnaddexistingpo";
            this.btnaddexistingpo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnaddexistingpo.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnaddexistingpo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnaddexistingpo.selected = false;
            this.btnaddexistingpo.Size = new System.Drawing.Size(300, 48);
            this.btnaddexistingpo.TabIndex = 143;
            this.btnaddexistingpo.Text = "     ADD ITEM FROM EXISTING P.O I.D.";
            this.btnaddexistingpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddexistingpo.Textcolor = System.Drawing.Color.White;
            this.btnaddexistingpo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddexistingpo.Click += new System.EventHandler(this.btnaddexistingpo_Click);
            // 
            // btnpoupdate
            // 
            this.btnpoupdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpoupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpoupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpoupdate.BorderRadius = 5;
            this.btnpoupdate.ButtonText = "     EDIT";
            this.btnpoupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnpoupdate, BunifuAnimatorNS.DecorationType.None);
            this.btnpoupdate.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btnpoupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoupdate.ForeColor = System.Drawing.Color.Lime;
            this.btnpoupdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnpoupdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnpoupdate.Iconimage")));
            this.btnpoupdate.Iconimage_right = null;
            this.btnpoupdate.Iconimage_right_Selected = null;
            this.btnpoupdate.Iconimage_Selected = null;
            this.btnpoupdate.IconMarginLeft = 0;
            this.btnpoupdate.IconMarginRight = 0;
            this.btnpoupdate.IconRightVisible = true;
            this.btnpoupdate.IconRightZoom = 0D;
            this.btnpoupdate.IconVisible = true;
            this.btnpoupdate.IconZoom = 50D;
            this.btnpoupdate.IsTab = false;
            this.btnpoupdate.Location = new System.Drawing.Point(202, 8);
            this.btnpoupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpoupdate.Name = "btnpoupdate";
            this.btnpoupdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpoupdate.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnpoupdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnpoupdate.selected = false;
            this.btnpoupdate.Size = new System.Drawing.Size(130, 48);
            this.btnpoupdate.TabIndex = 73;
            this.btnpoupdate.Text = "     EDIT";
            this.btnpoupdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpoupdate.Textcolor = System.Drawing.Color.White;
            this.btnpoupdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoupdate.Click += new System.EventHandler(this.btnpoupdate_Click);
            // 
            // btnpodelete
            // 
            this.btnpodelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpodelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpodelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpodelete.BorderRadius = 5;
            this.btnpodelete.ButtonText = "     DELETE";
            this.btnpodelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnpodelete, BunifuAnimatorNS.DecorationType.None);
            this.btnpodelete.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btnpodelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpodelete.ForeColor = System.Drawing.Color.Lime;
            this.btnpodelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnpodelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnpodelete.Iconimage")));
            this.btnpodelete.Iconimage_right = null;
            this.btnpodelete.Iconimage_right_Selected = null;
            this.btnpodelete.Iconimage_Selected = null;
            this.btnpodelete.IconMarginLeft = 0;
            this.btnpodelete.IconMarginRight = 0;
            this.btnpodelete.IconRightVisible = true;
            this.btnpodelete.IconRightZoom = 0D;
            this.btnpodelete.IconVisible = true;
            this.btnpodelete.IconZoom = 50D;
            this.btnpodelete.IsTab = false;
            this.btnpodelete.Location = new System.Drawing.Point(339, 8);
            this.btnpodelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpodelete.Name = "btnpodelete";
            this.btnpodelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpodelete.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnpodelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnpodelete.selected = false;
            this.btnpodelete.Size = new System.Drawing.Size(142, 48);
            this.btnpodelete.TabIndex = 74;
            this.btnpodelete.Text = "     DELETE";
            this.btnpodelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpodelete.Textcolor = System.Drawing.Color.White;
            this.btnpodelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpodelete.Click += new System.EventHandler(this.btnpodelete_Click);
            // 
            // btnposave
            // 
            this.btnposave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnposave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnposave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnposave.BorderRadius = 5;
            this.btnposave.ButtonText = "     SAVE";
            this.btnposave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnposave, BunifuAnimatorNS.DecorationType.None);
            this.btnposave.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btnposave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnposave.ForeColor = System.Drawing.Color.Lime;
            this.btnposave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnposave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnposave.Iconimage")));
            this.btnposave.Iconimage_right = null;
            this.btnposave.Iconimage_right_Selected = null;
            this.btnposave.Iconimage_Selected = null;
            this.btnposave.IconMarginLeft = 0;
            this.btnposave.IconMarginRight = 0;
            this.btnposave.IconRightVisible = true;
            this.btnposave.IconRightZoom = 0D;
            this.btnposave.IconVisible = true;
            this.btnposave.IconZoom = 50D;
            this.btnposave.IsTab = false;
            this.btnposave.Location = new System.Drawing.Point(487, 8);
            this.btnposave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnposave.Name = "btnposave";
            this.btnposave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnposave.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnposave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnposave.selected = false;
            this.btnposave.Size = new System.Drawing.Size(142, 48);
            this.btnposave.TabIndex = 72;
            this.btnposave.Text = "     SAVE";
            this.btnposave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnposave.Textcolor = System.Drawing.Color.White;
            this.btnposave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnposave.Click += new System.EventHandler(this.btnposave_Click);
            // 
            // tbsearchpo
            // 
            this.tbsearchpo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbsearchpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbsearchpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbsearchpo.BorderRadius = 5;
            this.tbsearchpo.ButtonText = "     SEARCH ITEM";
            this.tbsearchpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.tbsearchpo, BunifuAnimatorNS.DecorationType.None);
            this.tbsearchpo.DisabledColor = System.Drawing.Color.ForestGreen;
            this.tbsearchpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearchpo.ForeColor = System.Drawing.Color.Lime;
            this.tbsearchpo.Iconcolor = System.Drawing.Color.Transparent;
            this.tbsearchpo.Iconimage = ((System.Drawing.Image)(resources.GetObject("tbsearchpo.Iconimage")));
            this.tbsearchpo.Iconimage_right = null;
            this.tbsearchpo.Iconimage_right_Selected = null;
            this.tbsearchpo.Iconimage_Selected = null;
            this.tbsearchpo.IconMarginLeft = 0;
            this.tbsearchpo.IconMarginRight = 0;
            this.tbsearchpo.IconRightVisible = true;
            this.tbsearchpo.IconRightZoom = 0D;
            this.tbsearchpo.IconVisible = true;
            this.tbsearchpo.IconZoom = 50D;
            this.tbsearchpo.IsTab = false;
            this.tbsearchpo.Location = new System.Drawing.Point(8, 8);
            this.tbsearchpo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbsearchpo.Name = "tbsearchpo";
            this.tbsearchpo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbsearchpo.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.tbsearchpo.OnHoverTextColor = System.Drawing.Color.White;
            this.tbsearchpo.selected = false;
            this.tbsearchpo.Size = new System.Drawing.Size(186, 48);
            this.tbsearchpo.TabIndex = 101;
            this.tbsearchpo.Text = "     SEARCH ITEM";
            this.tbsearchpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbsearchpo.Textcolor = System.Drawing.Color.White;
            this.tbsearchpo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearchpo.Click += new System.EventHandler(this.tbsearchpo_Click);
            // 
            // LVnotification
            // 
            this.LVnotification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVnotification.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader51,
            this.columnHeader52,
            this.columnHeader53,
            this.columnHeader50});
            this.epeks.SetDecoration(this.LVnotification, BunifuAnimatorNS.DecorationType.None);
            this.LVnotification.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVnotification.FullRowSelect = true;
            this.LVnotification.HideSelection = false;
            this.LVnotification.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.LVnotification.Location = new System.Drawing.Point(21, 98);
            this.LVnotification.Name = "LVnotification";
            this.LVnotification.ShowItemToolTips = true;
            this.LVnotification.Size = new System.Drawing.Size(574, 568);
            this.LVnotification.TabIndex = 8;
            this.LVnotification.UseCompatibleStateImageBehavior = false;
            this.LVnotification.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "NAME";
            this.columnHeader51.Width = 120;
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "UNIT";
            this.columnHeader52.Width = 150;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "P.O. I.D.";
            this.columnHeader53.Width = 150;
            // 
            // columnHeader50
            // 
            this.columnHeader50.Text = "REMARKS";
            this.columnHeader50.Width = 150;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Green;
            this.panel17.Controls.Add(this.panel27);
            this.panel17.Controls.Add(this.panel14);
            this.panel17.Controls.Add(this.pictureBox7);
            this.epeks.SetDecoration(this.panel17, BunifuAnimatorNS.DecorationType.None);
            this.panel17.Location = new System.Drawing.Point(611, 90);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(660, 588);
            this.panel17.TabIndex = 10;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel27.Controls.Add(this.lblsecond);
            this.panel27.Controls.Add(this.lblDay);
            this.panel27.Controls.Add(this.lbltime);
            this.panel27.Controls.Add(this.lblDate);
            this.epeks.SetDecoration(this.panel27, BunifuAnimatorNS.DecorationType.None);
            this.panel27.Location = new System.Drawing.Point(6, 321);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(675, 255);
            this.panel27.TabIndex = 12;
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.epeks.SetDecoration(this.lblsecond, BunifuAnimatorNS.DecorationType.None);
            this.lblsecond.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecond.ForeColor = System.Drawing.Color.White;
            this.lblsecond.Location = new System.Drawing.Point(362, 26);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(88, 64);
            this.lblsecond.TabIndex = 11;
            this.lblsecond.Text = "22";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.epeks.SetDecoration(this.lblDay, BunifuAnimatorNS.DecorationType.None);
            this.lblDay.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(28, 188);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(268, 64);
            this.lblDay.TabIndex = 11;
            this.lblDay.Text = "Saturday";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.epeks.SetDecoration(this.lbltime, BunifuAnimatorNS.DecorationType.None);
            this.lbltime.Font = new System.Drawing.Font("Consolas", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(6, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(390, 140);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "22:22";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.epeks.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(32, 154);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(245, 40);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "JUNE 25 2018";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.epeks.SetDecoration(this.panel14, BunifuAnimatorNS.DecorationType.None);
            this.panel14.Location = new System.Drawing.Point(3, 337);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(664, 245);
            this.panel14.TabIndex = 13;
            // 
            // pictureBox7
            // 
            this.epeks.SetDecoration(this.pictureBox7, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(29, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(633, 335);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Green;
            this.epeks.SetDecoration(this.panel28, BunifuAnimatorNS.DecorationType.None);
            this.panel28.Location = new System.Drawing.Point(13, 90);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(592, 588);
            this.panel28.TabIndex = 11;
            // 
            // phome
            // 
            this.phome.BackColor = System.Drawing.Color.DarkGreen;
            this.phome.Controls.Add(this.btnPOS);
            this.phome.Controls.Add(this.panel3);
            this.phome.Controls.Add(this.b3);
            this.phome.Controls.Add(this.b2);
            this.phome.Controls.Add(this.btnhome);
            this.phome.Controls.Add(this.b1);
            this.epeks.SetDecoration(this.phome, BunifuAnimatorNS.DecorationType.None);
            this.phome.Dock = System.Windows.Forms.DockStyle.Left;
            this.phome.Location = new System.Drawing.Point(0, 0);
            this.phome.MaximumSize = new System.Drawing.Size(287, 0);
            this.phome.Name = "phome";
            this.phome.Size = new System.Drawing.Size(59, 680);
            this.phome.TabIndex = 1;
            // 
            // btnPOS
            // 
            this.btnPOS.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnPOS.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPOS.BorderRadius = 0;
            this.btnPOS.ButtonText = "     R.I.S";
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnPOS, BunifuAnimatorNS.DecorationType.None);
            this.btnPOS.DisabledColor = System.Drawing.Color.Gray;
            this.btnPOS.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPOS.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPOS.Iconimage")));
            this.btnPOS.Iconimage_right = null;
            this.btnPOS.Iconimage_right_Selected = null;
            this.btnPOS.Iconimage_Selected = null;
            this.btnPOS.IconMarginLeft = 16;
            this.btnPOS.IconMarginRight = 0;
            this.btnPOS.IconRightVisible = true;
            this.btnPOS.IconRightZoom = 0D;
            this.btnPOS.IconVisible = true;
            this.btnPOS.IconZoom = 70D;
            this.btnPOS.IsTab = true;
            this.btnPOS.Location = new System.Drawing.Point(-2, 287);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnPOS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPOS.OnHoverTextColor = System.Drawing.Color.Green;
            this.btnPOS.selected = false;
            this.btnPOS.Size = new System.Drawing.Size(289, 40);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "     R.I.S";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.Textcolor = System.Drawing.Color.White;
            this.btnPOS.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.logo);
            this.panel3.Controls.Add(this.Username);
            this.panel3.Controls.Add(this.pictureBox2);
            this.epeks.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 196);
            this.panel3.TabIndex = 0;
            // 
            // logo
            // 
            this.epeks.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(4, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(50, 48);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 15;
            this.logo.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.epeks.SetDecoration(this.Username, BunifuAnimatorNS.DecorationType.None);
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Username.Location = new System.Drawing.Point(89, 110);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(71, 16);
            this.Username.TabIndex = 14;
            this.Username.Text = "Username";
            // 
            // pictureBox2
            // 
            this.epeks.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(87, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // b3
            // 
            this.b3.Activecolor = System.Drawing.Color.LimeGreen;
            this.b3.BackColor = System.Drawing.Color.DarkGreen;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.BorderRadius = 0;
            this.b3.ButtonText = "     Settings";
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.b3, BunifuAnimatorNS.DecorationType.None);
            this.b3.DisabledColor = System.Drawing.Color.Gray;
            this.b3.Iconcolor = System.Drawing.Color.Transparent;
            this.b3.Iconimage = ((System.Drawing.Image)(resources.GetObject("b3.Iconimage")));
            this.b3.Iconimage_right = null;
            this.b3.Iconimage_right_Selected = null;
            this.b3.Iconimage_Selected = null;
            this.b3.IconMarginLeft = 16;
            this.b3.IconMarginRight = 0;
            this.b3.IconRightVisible = true;
            this.b3.IconRightZoom = 0D;
            this.b3.IconVisible = true;
            this.b3.IconZoom = 70D;
            this.b3.IsTab = true;
            this.b3.Location = new System.Drawing.Point(-5, 374);
            this.b3.Name = "b3";
            this.b3.Normalcolor = System.Drawing.Color.DarkGreen;
            this.b3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b3.OnHoverTextColor = System.Drawing.Color.Green;
            this.b3.selected = false;
            this.b3.Size = new System.Drawing.Size(289, 40);
            this.b3.TabIndex = 0;
            this.b3.Text = "     Settings";
            this.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b3.Textcolor = System.Drawing.Color.White;
            this.b3.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Activecolor = System.Drawing.Color.LimeGreen;
            this.b2.BackColor = System.Drawing.Color.DarkGreen;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.BorderRadius = 0;
            this.b2.ButtonText = "      Report";
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.b2, BunifuAnimatorNS.DecorationType.None);
            this.b2.DisabledColor = System.Drawing.Color.Gray;
            this.b2.Iconcolor = System.Drawing.Color.Transparent;
            this.b2.Iconimage = ((System.Drawing.Image)(resources.GetObject("b2.Iconimage")));
            this.b2.Iconimage_right = null;
            this.b2.Iconimage_right_Selected = null;
            this.b2.Iconimage_Selected = null;
            this.b2.IconMarginLeft = 20;
            this.b2.IconMarginRight = 0;
            this.b2.IconRightVisible = true;
            this.b2.IconRightZoom = 0D;
            this.b2.IconVisible = true;
            this.b2.IconZoom = 60D;
            this.b2.IsTab = true;
            this.b2.Location = new System.Drawing.Point(-4, 331);
            this.b2.Name = "b2";
            this.b2.Normalcolor = System.Drawing.Color.DarkGreen;
            this.b2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b2.OnHoverTextColor = System.Drawing.Color.Green;
            this.b2.selected = false;
            this.b2.Size = new System.Drawing.Size(289, 40);
            this.b2.TabIndex = 0;
            this.b2.Text = "      Report";
            this.b2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b2.Textcolor = System.Drawing.Color.White;
            this.b2.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // btnhome
            // 
            this.btnhome.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnhome.BackColor = System.Drawing.Color.DarkGreen;
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.BorderRadius = 0;
            this.btnhome.ButtonText = "     Home";
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
            this.btnhome.DisabledColor = System.Drawing.Color.Gray;
            this.btnhome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnhome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnhome.Iconimage")));
            this.btnhome.Iconimage_right = null;
            this.btnhome.Iconimage_right_Selected = null;
            this.btnhome.Iconimage_Selected = null;
            this.btnhome.IconMarginLeft = 18;
            this.btnhome.IconMarginRight = 0;
            this.btnhome.IconRightVisible = true;
            this.btnhome.IconRightZoom = 0D;
            this.btnhome.IconVisible = true;
            this.btnhome.IconZoom = 70D;
            this.btnhome.IsTab = true;
            this.btnhome.Location = new System.Drawing.Point(-5, 202);
            this.btnhome.Name = "btnhome";
            this.btnhome.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnhome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnhome.OnHoverTextColor = System.Drawing.Color.Green;
            this.btnhome.selected = false;
            this.btnhome.Size = new System.Drawing.Size(290, 40);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "     Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Textcolor = System.Drawing.Color.White;
            this.btnhome.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // b1
            // 
            this.b1.Activecolor = System.Drawing.Color.LimeGreen;
            this.b1.BackColor = System.Drawing.Color.DarkGreen;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.BorderRadius = 0;
            this.b1.ButtonText = "     Purchase Order";
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.b1, BunifuAnimatorNS.DecorationType.None);
            this.b1.DisabledColor = System.Drawing.Color.Gray;
            this.b1.Iconcolor = System.Drawing.Color.Transparent;
            this.b1.Iconimage = ((System.Drawing.Image)(resources.GetObject("b1.Iconimage")));
            this.b1.Iconimage_right = null;
            this.b1.Iconimage_right_Selected = null;
            this.b1.Iconimage_Selected = null;
            this.b1.IconMarginLeft = 18;
            this.b1.IconMarginRight = 0;
            this.b1.IconRightVisible = true;
            this.b1.IconRightZoom = 0D;
            this.b1.IconVisible = true;
            this.b1.IconZoom = 70D;
            this.b1.IsTab = true;
            this.b1.Location = new System.Drawing.Point(-5, 244);
            this.b1.Name = "b1";
            this.b1.Normalcolor = System.Drawing.Color.DarkGreen;
            this.b1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b1.OnHoverTextColor = System.Drawing.Color.Green;
            this.b1.selected = false;
            this.b1.Size = new System.Drawing.Size(292, 40);
            this.b1.TabIndex = 0;
            this.b1.Text = "     Purchase Order";
            this.b1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b1.Textcolor = System.Drawing.Color.White;
            this.b1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // ppoedit
            // 
            this.ppoedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ppoedit.Controls.Add(this.btnclosepoedit);
            this.ppoedit.Controls.Add(this.panel30);
            this.ppoedit.Controls.Add(this.label73);
            this.epeks.SetDecoration(this.ppoedit, BunifuAnimatorNS.DecorationType.None);
            this.ppoedit.Location = new System.Drawing.Point(219, 106);
            this.ppoedit.Name = "ppoedit";
            this.ppoedit.Size = new System.Drawing.Size(801, 595);
            this.ppoedit.TabIndex = 30;
            // 
            // btnclosepoedit
            // 
            this.btnclosepoedit.BackColor = System.Drawing.Color.Transparent;
            this.epeks.SetDecoration(this.btnclosepoedit, BunifuAnimatorNS.DecorationType.None);
            this.btnclosepoedit.Image = ((System.Drawing.Image)(resources.GetObject("btnclosepoedit.Image")));
            this.btnclosepoedit.ImageActive = null;
            this.btnclosepoedit.Location = new System.Drawing.Point(765, 3);
            this.btnclosepoedit.Name = "btnclosepoedit";
            this.btnclosepoedit.Size = new System.Drawing.Size(27, 29);
            this.btnclosepoedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclosepoedit.TabIndex = 118;
            this.btnclosepoedit.TabStop = false;
            this.btnclosepoedit.Zoom = 10;
            this.btnclosepoedit.Click += new System.EventHandler(this.btnclosepoedit_Click);
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.PaleGreen;
            this.panel30.Controls.Add(this.hideMeEditPanel);
            this.panel30.Controls.Add(this.cbitemcatup);
            this.panel30.Controls.Add(this.label96);
            this.panel30.Controls.Add(this.tbunitup);
            this.panel30.Controls.Add(this.tbumeasureupdate);
            this.panel30.Controls.Add(this.cbucatup);
            this.panel30.Controls.Add(this.label95);
            this.panel30.Controls.Add(this.label75);
            this.panel30.Controls.Add(this.tbitemnameupdate);
            this.panel30.Controls.Add(this.label74);
            this.panel30.Controls.Add(this.tbitemidupate);
            this.panel30.Controls.Add(this.label40);
            this.panel30.Controls.Add(this.tbpoidupdate);
            this.panel30.Controls.Add(this.nmqtyupdate);
            this.panel30.Controls.Add(this.dtexpired);
            this.panel30.Controls.Add(this.dtmob4expire);
            this.panel30.Controls.Add(this.label45);
            this.panel30.Controls.Add(this.label46);
            this.panel30.Controls.Add(this.tbreorderup);
            this.panel30.Controls.Add(this.label68);
            this.panel30.Controls.Add(this.tbamountup);
            this.panel30.Controls.Add(this.label69);
            this.panel30.Controls.Add(this.label70);
            this.panel30.Controls.Add(this.tbupriceupdate);
            this.panel30.Controls.Add(this.label71);
            this.panel30.Controls.Add(this.cbsupup);
            this.panel30.Controls.Add(this.label72);
            this.panel30.Controls.Add(this.panel34);
            this.epeks.SetDecoration(this.panel30, BunifuAnimatorNS.DecorationType.None);
            this.panel30.Location = new System.Drawing.Point(7, 43);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(786, 546);
            this.panel30.TabIndex = 119;
            // 
            // hideMeEditPanel
            // 
            this.epeks.SetDecoration(this.hideMeEditPanel, BunifuAnimatorNS.DecorationType.None);
            this.hideMeEditPanel.Location = new System.Drawing.Point(432, 279);
            this.hideMeEditPanel.Name = "hideMeEditPanel";
            this.hideMeEditPanel.Size = new System.Drawing.Size(350, 156);
            this.hideMeEditPanel.TabIndex = 157;
            // 
            // cbitemcatup
            // 
            this.epeks.SetDecoration(this.cbitemcatup, BunifuAnimatorNS.DecorationType.None);
            this.cbitemcatup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbitemcatup.FormattingEnabled = true;
            this.cbitemcatup.Location = new System.Drawing.Point(439, 153);
            this.cbitemcatup.Name = "cbitemcatup";
            this.cbitemcatup.Size = new System.Drawing.Size(322, 33);
            this.cbitemcatup.TabIndex = 156;
            this.cbitemcatup.Text = "SELECT";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.epeks.SetDecoration(this.label96, BunifuAnimatorNS.DecorationType.None);
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(438, 128);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(145, 20);
            this.label96.TabIndex = 155;
            this.label96.Text = "ITEM CATEGORY:";
            // 
            // tbunitup
            // 
            this.epeks.SetDecoration(this.tbunitup, BunifuAnimatorNS.DecorationType.None);
            this.tbunitup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunitup.FormattingEnabled = true;
            this.tbunitup.Location = new System.Drawing.Point(262, 382);
            this.tbunitup.Name = "tbunitup";
            this.tbunitup.Size = new System.Drawing.Size(100, 33);
            this.tbunitup.TabIndex = 154;
            this.tbunitup.Text = "SELECT";
            // 
            // tbumeasureupdate
            // 
            this.epeks.SetDecoration(this.tbumeasureupdate, BunifuAnimatorNS.DecorationType.None);
            this.tbumeasureupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbumeasureupdate.FormattingEnabled = true;
            this.tbumeasureupdate.Location = new System.Drawing.Point(160, 382);
            this.tbumeasureupdate.Name = "tbumeasureupdate";
            this.tbumeasureupdate.Size = new System.Drawing.Size(98, 33);
            this.tbumeasureupdate.TabIndex = 154;
            this.tbumeasureupdate.Text = "SELECT";
            // 
            // cbucatup
            // 
            this.epeks.SetDecoration(this.cbucatup, BunifuAnimatorNS.DecorationType.None);
            this.cbucatup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbucatup.FormattingEnabled = true;
            this.cbucatup.Location = new System.Drawing.Point(27, 382);
            this.cbucatup.Name = "cbucatup";
            this.cbucatup.Size = new System.Drawing.Size(130, 33);
            this.cbucatup.TabIndex = 154;
            this.cbucatup.Text = "SELECT";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.epeks.SetDecoration(this.label95, BunifuAnimatorNS.DecorationType.None);
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(24, 359);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(50, 20);
            this.label95.TabIndex = 153;
            this.label95.Text = "UNIT:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.epeks.SetDecoration(this.label75, BunifuAnimatorNS.DecorationType.None);
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label75.Location = new System.Drawing.Point(23, 198);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(101, 20);
            this.label75.TabIndex = 148;
            this.label75.Text = "ITEM NAME:";
            // 
            // tbitemnameupdate
            // 
            this.tbitemnameupdate.BackColor = System.Drawing.Color.White;
            this.tbitemnameupdate.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbitemnameupdate.BorderColorIdle = System.Drawing.Color.Green;
            this.tbitemnameupdate.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbitemnameupdate.BorderThickness = 3;
            this.tbitemnameupdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbitemnameupdate, BunifuAnimatorNS.DecorationType.None);
            this.tbitemnameupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbitemnameupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbitemnameupdate.isPassword = false;
            this.tbitemnameupdate.Location = new System.Drawing.Point(27, 223);
            this.tbitemnameupdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbitemnameupdate.Name = "tbitemnameupdate";
            this.tbitemnameupdate.Size = new System.Drawing.Size(335, 46);
            this.tbitemnameupdate.TabIndex = 147;
            this.tbitemnameupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.epeks.SetDecoration(this.label74, BunifuAnimatorNS.DecorationType.None);
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label74.Location = new System.Drawing.Point(22, 109);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(72, 20);
            this.label74.TabIndex = 146;
            this.label74.Text = "ITEM ID:";
            // 
            // tbitemidupate
            // 
            this.tbitemidupate.BackColor = System.Drawing.Color.White;
            this.tbitemidupate.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbitemidupate.BorderColorIdle = System.Drawing.Color.Green;
            this.tbitemidupate.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbitemidupate.BorderThickness = 3;
            this.tbitemidupate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbitemidupate, BunifuAnimatorNS.DecorationType.None);
            this.tbitemidupate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbitemidupate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbitemidupate.isPassword = false;
            this.tbitemidupate.Location = new System.Drawing.Point(27, 134);
            this.tbitemidupate.Margin = new System.Windows.Forms.Padding(4);
            this.tbitemidupate.Name = "tbitemidupate";
            this.tbitemidupate.Size = new System.Drawing.Size(335, 46);
            this.tbitemidupate.TabIndex = 145;
            this.tbitemidupate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.epeks.SetDecoration(this.label40, BunifuAnimatorNS.DecorationType.None);
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label40.Location = new System.Drawing.Point(25, 27);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 20);
            this.label40.TabIndex = 141;
            this.label40.Text = "PO ID:";
            // 
            // tbpoidupdate
            // 
            this.tbpoidupdate.BackColor = System.Drawing.Color.White;
            this.tbpoidupdate.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbpoidupdate.BorderColorIdle = System.Drawing.Color.Green;
            this.tbpoidupdate.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbpoidupdate.BorderThickness = 3;
            this.tbpoidupdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbpoidupdate, BunifuAnimatorNS.DecorationType.None);
            this.tbpoidupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpoidupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbpoidupdate.isPassword = false;
            this.tbpoidupdate.Location = new System.Drawing.Point(27, 52);
            this.tbpoidupdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbpoidupdate.Name = "tbpoidupdate";
            this.tbpoidupdate.Size = new System.Drawing.Size(335, 46);
            this.tbpoidupdate.TabIndex = 134;
            this.tbpoidupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nmqtyupdate
            // 
            this.epeks.SetDecoration(this.nmqtyupdate, BunifuAnimatorNS.DecorationType.None);
            this.nmqtyupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmqtyupdate.Location = new System.Drawing.Point(27, 307);
            this.nmqtyupdate.Name = "nmqtyupdate";
            this.nmqtyupdate.Size = new System.Drawing.Size(146, 44);
            this.nmqtyupdate.TabIndex = 142;
            this.nmqtyupdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nmqtyupdate_MouseUp);
            // 
            // dtexpired
            // 
            this.dtexpired.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.dtexpired, BunifuAnimatorNS.DecorationType.None);
            this.dtexpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtexpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtexpired.Location = new System.Drawing.Point(439, 383);
            this.dtexpired.Name = "dtexpired";
            this.dtexpired.Size = new System.Drawing.Size(322, 27);
            this.dtexpired.TabIndex = 139;
            // 
            // dtmob4expire
            // 
            this.dtmob4expire.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.dtmob4expire, BunifuAnimatorNS.DecorationType.None);
            this.dtmob4expire.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmob4expire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmob4expire.Location = new System.Drawing.Point(439, 310);
            this.dtmob4expire.Name = "dtmob4expire";
            this.dtmob4expire.Size = new System.Drawing.Size(322, 27);
            this.dtmob4expire.TabIndex = 140;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.epeks.SetDecoration(this.label45, BunifuAnimatorNS.DecorationType.None);
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(436, 360);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(132, 20);
            this.label45.TabIndex = 137;
            this.label45.Text = "EXPIRED DATE:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.epeks.SetDecoration(this.label46, BunifuAnimatorNS.DecorationType.None);
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(435, 287);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(177, 20);
            this.label46.TabIndex = 138;
            this.label46.Text = "MO. BEFORE EXPIRE:";
            // 
            // tbreorderup
            // 
            this.tbreorderup.BackColor = System.Drawing.Color.White;
            this.tbreorderup.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbreorderup.BorderColorIdle = System.Drawing.Color.Green;
            this.tbreorderup.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbreorderup.BorderThickness = 3;
            this.tbreorderup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbreorderup, BunifuAnimatorNS.DecorationType.None);
            this.tbreorderup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbreorderup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbreorderup.isPassword = false;
            this.tbreorderup.Location = new System.Drawing.Point(609, 56);
            this.tbreorderup.Margin = new System.Windows.Forms.Padding(4);
            this.tbreorderup.Name = "tbreorderup";
            this.tbreorderup.Size = new System.Drawing.Size(150, 44);
            this.tbreorderup.TabIndex = 136;
            this.tbreorderup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.epeks.SetDecoration(this.label68, BunifuAnimatorNS.DecorationType.None);
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label68.Location = new System.Drawing.Point(607, 31);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(155, 20);
            this.label68.TabIndex = 135;
            this.label68.Text = "RE-ORDER LEVEL:";
            // 
            // tbamountup
            // 
            this.tbamountup.BackColor = System.Drawing.Color.White;
            this.tbamountup.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbamountup.BorderColorIdle = System.Drawing.Color.Green;
            this.tbamountup.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbamountup.BorderThickness = 3;
            this.tbamountup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbamountup, BunifuAnimatorNS.DecorationType.None);
            this.tbamountup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamountup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbamountup.isPassword = false;
            this.tbamountup.Location = new System.Drawing.Point(439, 56);
            this.tbamountup.Margin = new System.Windows.Forms.Padding(4);
            this.tbamountup.Name = "tbamountup";
            this.tbamountup.Size = new System.Drawing.Size(158, 44);
            this.tbamountup.TabIndex = 133;
            this.tbamountup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.epeks.SetDecoration(this.label69, BunifuAnimatorNS.DecorationType.None);
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label69.Location = new System.Drawing.Point(438, 31);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(81, 20);
            this.label69.TabIndex = 132;
            this.label69.Text = "AMOUNT:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.epeks.SetDecoration(this.label70, BunifuAnimatorNS.DecorationType.None);
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label70.Location = new System.Drawing.Point(23, 281);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(45, 20);
            this.label70.TabIndex = 131;
            this.label70.Text = "QTY:";
            // 
            // tbupriceupdate
            // 
            this.tbupriceupdate.BackColor = System.Drawing.Color.White;
            this.tbupriceupdate.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbupriceupdate.BorderColorIdle = System.Drawing.Color.Green;
            this.tbupriceupdate.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbupriceupdate.BorderThickness = 3;
            this.tbupriceupdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbupriceupdate, BunifuAnimatorNS.DecorationType.None);
            this.tbupriceupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbupriceupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbupriceupdate.isPassword = false;
            this.tbupriceupdate.Location = new System.Drawing.Point(202, 306);
            this.tbupriceupdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbupriceupdate.Name = "tbupriceupdate";
            this.tbupriceupdate.Size = new System.Drawing.Size(160, 44);
            this.tbupriceupdate.TabIndex = 130;
            this.tbupriceupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbupriceupdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbupriceupdate_KeyPress);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.epeks.SetDecoration(this.label71, BunifuAnimatorNS.DecorationType.None);
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label71.Location = new System.Drawing.Point(198, 281);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(103, 20);
            this.label71.TabIndex = 129;
            this.label71.Text = "UNIT PRICE:";
            // 
            // cbsupup
            // 
            this.epeks.SetDecoration(this.cbsupup, BunifuAnimatorNS.DecorationType.None);
            this.cbsupup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsupup.FormattingEnabled = true;
            this.cbsupup.Location = new System.Drawing.Point(442, 231);
            this.cbsupup.Name = "cbsupup";
            this.cbsupup.Size = new System.Drawing.Size(323, 33);
            this.cbsupup.TabIndex = 128;
            this.cbsupup.Text = "SELECT";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.epeks.SetDecoration(this.label72, BunifuAnimatorNS.DecorationType.None);
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(438, 206);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(93, 20);
            this.label72.TabIndex = 127;
            this.label72.Text = "SUPPLIER:";
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.DarkGreen;
            this.panel34.Controls.Add(this.btnupdatepo);
            this.epeks.SetDecoration(this.panel34, BunifuAnimatorNS.DecorationType.None);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel34.Location = new System.Drawing.Point(0, 483);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(786, 63);
            this.panel34.TabIndex = 144;
            // 
            // btnupdatepo
            // 
            this.btnupdatepo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdatepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdatepo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdatepo.BorderRadius = 5;
            this.btnupdatepo.ButtonText = "     UPDATE";
            this.btnupdatepo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btnupdatepo, BunifuAnimatorNS.DecorationType.None);
            this.btnupdatepo.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btnupdatepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatepo.ForeColor = System.Drawing.Color.Lime;
            this.btnupdatepo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdatepo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnupdatepo.Iconimage")));
            this.btnupdatepo.Iconimage_right = null;
            this.btnupdatepo.Iconimage_right_Selected = null;
            this.btnupdatepo.Iconimage_Selected = null;
            this.btnupdatepo.IconMarginLeft = 0;
            this.btnupdatepo.IconMarginRight = 0;
            this.btnupdatepo.IconRightVisible = true;
            this.btnupdatepo.IconRightZoom = 0D;
            this.btnupdatepo.IconVisible = true;
            this.btnupdatepo.IconZoom = 50D;
            this.btnupdatepo.IsTab = false;
            this.btnupdatepo.Location = new System.Drawing.Point(642, 9);
            this.btnupdatepo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdatepo.Name = "btnupdatepo";
            this.btnupdatepo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdatepo.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnupdatepo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdatepo.selected = false;
            this.btnupdatepo.Size = new System.Drawing.Size(142, 48);
            this.btnupdatepo.TabIndex = 143;
            this.btnupdatepo.Text = "     UPDATE";
            this.btnupdatepo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdatepo.Textcolor = System.Drawing.Color.White;
            this.btnupdatepo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatepo.Click += new System.EventHandler(this.btnupdatepo_Click);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.epeks.SetDecoration(this.label73, BunifuAnimatorNS.DecorationType.None);
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(3, 11);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(160, 20);
            this.label73.TabIndex = 145;
            this.label73.Text = "EDIT ITEM DETAILS";
            // 
            // psearchpo
            // 
            this.psearchpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.psearchpo.Controls.Add(this.LVPOSEARCH);
            this.psearchpo.Controls.Add(this.panel25);
            this.psearchpo.Controls.Add(this.panel36);
            this.psearchpo.Controls.Add(this.psearchclose);
            this.psearchpo.Controls.Add(this.label41);
            this.epeks.SetDecoration(this.psearchpo, BunifuAnimatorNS.DecorationType.None);
            this.psearchpo.Location = new System.Drawing.Point(86, 79);
            this.psearchpo.Name = "psearchpo";
            this.psearchpo.Size = new System.Drawing.Size(1118, 645);
            this.psearchpo.TabIndex = 123;
            // 
            // LVPOSEARCH
            // 
            this.LVPOSEARCH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader91,
            this.columnHeader92,
            this.columnHeader93,
            this.columnHeader94,
            this.columnHeader43});
            this.epeks.SetDecoration(this.LVPOSEARCH, BunifuAnimatorNS.DecorationType.None);
            this.LVPOSEARCH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVPOSEARCH.FullRowSelect = true;
            this.LVPOSEARCH.GridLines = true;
            this.LVPOSEARCH.HideSelection = false;
            this.LVPOSEARCH.Location = new System.Drawing.Point(3, 90);
            this.LVPOSEARCH.Name = "LVPOSEARCH";
            this.LVPOSEARCH.Size = new System.Drawing.Size(751, 542);
            this.LVPOSEARCH.TabIndex = 116;
            this.LVPOSEARCH.UseCompatibleStateImageBehavior = false;
            this.LVPOSEARCH.View = System.Windows.Forms.View.Details;
            this.LVPOSEARCH.SelectedIndexChanged += new System.EventHandler(this.LVPOSEARCH_SelectedIndexChanged);
            // 
            // columnHeader91
            // 
            this.columnHeader91.Text = "ITEM ID";
            this.columnHeader91.Width = 80;
            // 
            // columnHeader92
            // 
            this.columnHeader92.Text = "ITEM NAME";
            this.columnHeader92.Width = 150;
            // 
            // columnHeader93
            // 
            this.columnHeader93.Text = "CATEGORY";
            this.columnHeader93.Width = 200;
            // 
            // columnHeader94
            // 
            this.columnHeader94.Text = "UNIT";
            this.columnHeader94.Width = 150;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "UNIT PRICE";
            this.columnHeader43.Width = 180;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.PaleGreen;
            this.panel25.Controls.Add(this.hideDate);
            this.panel25.Controls.Add(this.btn_ADD);
            this.panel25.Controls.Add(this.panel32);
            this.panel25.Controls.Add(this.label3);
            this.panel25.Controls.Add(this.tb_poid);
            this.panel25.Controls.Add(this.tbqty);
            this.panel25.Controls.Add(this.dt_expired_date);
            this.panel25.Controls.Add(this.dt_before_expire);
            this.panel25.Controls.Add(this.label17);
            this.panel25.Controls.Add(this.label16);
            this.panel25.Controls.Add(this.tb_poreorderedlvl);
            this.panel25.Controls.Add(this.label14);
            this.panel25.Controls.Add(this.tbamount);
            this.panel25.Controls.Add(this.label78);
            this.panel25.Controls.Add(this.label48);
            this.panel25.Controls.Add(this.tbunitprice);
            this.panel25.Controls.Add(this.label47);
            this.panel25.Controls.Add(this.tbsupplier);
            this.panel25.Controls.Add(this.label39);
            this.epeks.SetDecoration(this.panel25, BunifuAnimatorNS.DecorationType.None);
            this.panel25.Location = new System.Drawing.Point(761, 32);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(352, 600);
            this.panel25.TabIndex = 122;
            // 
            // hideDate
            // 
            this.epeks.SetDecoration(this.hideDate, BunifuAnimatorNS.DecorationType.None);
            this.hideDate.Location = new System.Drawing.Point(10, 398);
            this.hideDate.Name = "hideDate";
            this.hideDate.Size = new System.Drawing.Size(339, 138);
            this.hideDate.TabIndex = 127;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ADD.BorderRadius = 5;
            this.btn_ADD.ButtonText = "            ADD";
            this.btn_ADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epeks.SetDecoration(this.btn_ADD, BunifuAnimatorNS.DecorationType.None);
            this.btn_ADD.DisabledColor = System.Drawing.Color.ForestGreen;
            this.btn_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ADD.ForeColor = System.Drawing.Color.Lime;
            this.btn_ADD.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ADD.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ADD.Iconimage")));
            this.btn_ADD.Iconimage_right = null;
            this.btn_ADD.Iconimage_right_Selected = null;
            this.btn_ADD.Iconimage_Selected = null;
            this.btn_ADD.IconMarginLeft = 80;
            this.btn_ADD.IconMarginRight = 0;
            this.btn_ADD.IconRightVisible = true;
            this.btn_ADD.IconRightZoom = 0D;
            this.btn_ADD.IconVisible = true;
            this.btn_ADD.IconZoom = 50D;
            this.btn_ADD.IsTab = false;
            this.btn_ADD.Location = new System.Drawing.Point(19, 540);
            this.btn_ADD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ADD.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btn_ADD.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ADD.selected = false;
            this.btn_ADD.Size = new System.Drawing.Size(314, 48);
            this.btn_ADD.TabIndex = 126;
            this.btn_ADD.Text = "            ADD";
            this.btn_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ADD.Textcolor = System.Drawing.Color.White;
            this.btn_ADD.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click_1);
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.Green;
            this.panel32.Controls.Add(this.label42);
            this.panel32.Controls.Add(this.getItemName);
            this.epeks.SetDecoration(this.panel32, BunifuAnimatorNS.DecorationType.None);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel32.Location = new System.Drawing.Point(0, 0);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(352, 62);
            this.panel32.TabIndex = 125;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.epeks.SetDecoration(this.label42, BunifuAnimatorNS.DecorationType.None);
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label42.Location = new System.Drawing.Point(3, 6);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(182, 25);
            this.label42.TabIndex = 121;
            this.label42.Text = "SELECTED  ITEM:";
            // 
            // getItemName
            // 
            this.getItemName.AutoSize = true;
            this.epeks.SetDecoration(this.getItemName, BunifuAnimatorNS.DecorationType.None);
            this.getItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getItemName.ForeColor = System.Drawing.Color.GreenYellow;
            this.getItemName.Location = new System.Drawing.Point(5, 32);
            this.getItemName.Name = "getItemName";
            this.getItemName.Size = new System.Drawing.Size(60, 25);
            this.getItemName.TabIndex = 124;
            this.getItemName.Text = "ITEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.epeks.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 116;
            this.label3.Text = "PO ID:";
            // 
            // tb_poid
            // 
            this.tb_poid.BackColor = System.Drawing.Color.White;
            this.tb_poid.BorderColorFocused = System.Drawing.Color.Lime;
            this.tb_poid.BorderColorIdle = System.Drawing.Color.Green;
            this.tb_poid.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_poid.BorderThickness = 3;
            this.tb_poid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tb_poid, BunifuAnimatorNS.DecorationType.None);
            this.tb_poid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_poid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_poid.isPassword = false;
            this.tb_poid.Location = new System.Drawing.Point(15, 96);
            this.tb_poid.Margin = new System.Windows.Forms.Padding(4);
            this.tb_poid.Name = "tb_poid";
            this.tb_poid.Size = new System.Drawing.Size(315, 46);
            this.tb_poid.TabIndex = 109;
            this.tb_poid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_poid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tb_poid_MouseUp);
            // 
            // tbqty
            // 
            this.epeks.SetDecoration(this.tbqty, BunifuAnimatorNS.DecorationType.None);
            this.tbqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty.Location = new System.Drawing.Point(184, 257);
            this.tbqty.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.tbqty.Name = "tbqty";
            this.tbqty.Size = new System.Drawing.Size(146, 44);
            this.tbqty.TabIndex = 117;
            this.tbqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqty_KeyPress_1);
            this.tbqty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbqty_KeyUp);
            this.tbqty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbqty_MouseClick);
            this.tbqty.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbqty_MouseUp);
            // 
            // dt_expired_date
            // 
            this.dt_expired_date.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.dt_expired_date, BunifuAnimatorNS.DecorationType.None);
            this.dt_expired_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_expired_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_expired_date.Location = new System.Drawing.Point(17, 501);
            this.dt_expired_date.Name = "dt_expired_date";
            this.dt_expired_date.Size = new System.Drawing.Size(312, 27);
            this.dt_expired_date.TabIndex = 114;
            // 
            // dt_before_expire
            // 
            this.dt_before_expire.CustomFormat = "yyyy-MM-dd";
            this.epeks.SetDecoration(this.dt_before_expire, BunifuAnimatorNS.DecorationType.None);
            this.dt_before_expire.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_before_expire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_before_expire.Location = new System.Drawing.Point(16, 435);
            this.dt_before_expire.Name = "dt_before_expire";
            this.dt_before_expire.Size = new System.Drawing.Size(313, 27);
            this.dt_before_expire.TabIndex = 115;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.epeks.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 476);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 20);
            this.label17.TabIndex = 112;
            this.label17.Text = "EXPIRED DATE:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.epeks.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 410);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 20);
            this.label16.TabIndex = 113;
            this.label16.Text = "MO. BEFORE EXPIRE:";
            // 
            // tb_poreorderedlvl
            // 
            this.tb_poreorderedlvl.BackColor = System.Drawing.Color.White;
            this.tb_poreorderedlvl.BorderColorFocused = System.Drawing.Color.Lime;
            this.tb_poreorderedlvl.BorderColorIdle = System.Drawing.Color.Green;
            this.tb_poreorderedlvl.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_poreorderedlvl.BorderThickness = 3;
            this.tb_poreorderedlvl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tb_poreorderedlvl, BunifuAnimatorNS.DecorationType.None);
            this.tb_poreorderedlvl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_poreorderedlvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_poreorderedlvl.isPassword = false;
            this.tb_poreorderedlvl.Location = new System.Drawing.Point(184, 343);
            this.tb_poreorderedlvl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_poreorderedlvl.Name = "tb_poreorderedlvl";
            this.tb_poreorderedlvl.Size = new System.Drawing.Size(146, 44);
            this.tb_poreorderedlvl.TabIndex = 111;
            this.tb_poreorderedlvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_poreorderedlvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_poreorderedlvl_KeyPress_1);
            this.tb_poreorderedlvl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_poreorderedlvl_MouseClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.epeks.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(175, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 20);
            this.label14.TabIndex = 110;
            this.label14.Text = "RE-ORDER LEVEL:";
            // 
            // tbamount
            // 
            this.tbamount.BackColor = System.Drawing.Color.White;
            this.tbamount.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbamount.BorderColorIdle = System.Drawing.Color.Green;
            this.tbamount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbamount.BorderThickness = 3;
            this.tbamount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbamount, BunifuAnimatorNS.DecorationType.None);
            this.tbamount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbamount.isPassword = false;
            this.tbamount.Location = new System.Drawing.Point(16, 344);
            this.tbamount.Margin = new System.Windows.Forms.Padding(4);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(155, 44);
            this.tbamount.TabIndex = 108;
            this.tbamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbamount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbamount_MouseClick);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.epeks.SetDecoration(this.label78, BunifuAnimatorNS.DecorationType.None);
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label78.Location = new System.Drawing.Point(19, 319);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(81, 20);
            this.label78.TabIndex = 107;
            this.label78.Text = "AMOUNT:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.epeks.SetDecoration(this.label48, BunifuAnimatorNS.DecorationType.None);
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label48.Location = new System.Drawing.Point(190, 229);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(45, 20);
            this.label48.TabIndex = 105;
            this.label48.Text = "QTY:";
            // 
            // tbunitprice
            // 
            this.tbunitprice.BackColor = System.Drawing.Color.White;
            this.tbunitprice.BorderColorFocused = System.Drawing.Color.Lime;
            this.tbunitprice.BorderColorIdle = System.Drawing.Color.Green;
            this.tbunitprice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbunitprice.BorderThickness = 3;
            this.tbunitprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epeks.SetDecoration(this.tbunitprice, BunifuAnimatorNS.DecorationType.None);
            this.tbunitprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunitprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbunitprice.isPassword = false;
            this.tbunitprice.Location = new System.Drawing.Point(14, 259);
            this.tbunitprice.Margin = new System.Windows.Forms.Padding(4);
            this.tbunitprice.Name = "tbunitprice";
            this.tbunitprice.Size = new System.Drawing.Size(157, 44);
            this.tbunitprice.TabIndex = 104;
            this.tbunitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbunitprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbunitprice_KeyPress_1);
            this.tbunitprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbunitprice_KeyUp);
            this.tbunitprice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbunitprice_MouseClick);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.epeks.SetDecoration(this.label47, BunifuAnimatorNS.DecorationType.None);
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label47.Location = new System.Drawing.Point(12, 229);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(103, 20);
            this.label47.TabIndex = 103;
            this.label47.Text = "UNIT PRICE:";
            // 
            // tbsupplier
            // 
            this.epeks.SetDecoration(this.tbsupplier, BunifuAnimatorNS.DecorationType.None);
            this.tbsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsupplier.FormattingEnabled = true;
            this.tbsupplier.Location = new System.Drawing.Point(15, 176);
            this.tbsupplier.Name = "tbsupplier";
            this.tbsupplier.Size = new System.Drawing.Size(315, 33);
            this.tbsupplier.TabIndex = 102;
            this.tbsupplier.Text = "SELECT";
            this.tbsupplier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbsupplier_MouseClick_1);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.epeks.SetDecoration(this.label39, BunifuAnimatorNS.DecorationType.None);
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(12, 152);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(93, 20);
            this.label39.TabIndex = 101;
            this.label39.Text = "SUPPLIER:";
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.Green;
            this.panel36.Controls.Add(this.cbcategoryitem);
            this.panel36.Controls.Add(this.tbsearchpoitem);
            this.panel36.Controls.Add(this.pictureBox10);
            this.epeks.SetDecoration(this.panel36, BunifuAnimatorNS.DecorationType.None);
            this.panel36.Location = new System.Drawing.Point(2, 32);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(751, 54);
            this.panel36.TabIndex = 115;
            // 
            // cbcategoryitem
            // 
            this.epeks.SetDecoration(this.cbcategoryitem, BunifuAnimatorNS.DecorationType.None);
            this.cbcategoryitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoryitem.FormattingEnabled = true;
            this.cbcategoryitem.Location = new System.Drawing.Point(14, 12);
            this.cbcategoryitem.Name = "cbcategoryitem";
            this.cbcategoryitem.Size = new System.Drawing.Size(270, 32);
            this.cbcategoryitem.TabIndex = 113;
            this.cbcategoryitem.Text = "Select filter category";
            this.cbcategoryitem.SelectedIndexChanged += new System.EventHandler(this.cbcategoryitem_SelectedIndexChanged);
            this.cbcategoryitem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbcategoryitem_MouseClick);
            // 
            // tbsearchpoitem
            // 
            this.tbsearchpoitem.AllowDrop = true;
            this.tbsearchpoitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbsearchpoitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbsearchpoitem.BackColor = System.Drawing.Color.White;
            this.tbsearchpoitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epeks.SetDecoration(this.tbsearchpoitem, BunifuAnimatorNS.DecorationType.None);
            this.tbsearchpoitem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearchpoitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbsearchpoitem.Location = new System.Drawing.Point(407, 8);
            this.tbsearchpoitem.Name = "tbsearchpoitem";
            this.tbsearchpoitem.Size = new System.Drawing.Size(338, 39);
            this.tbsearchpoitem.TabIndex = 109;
            this.tbsearchpoitem.TextChanged += new System.EventHandler(this.tbsearchpoitem_TextChanged);
            // 
            // pictureBox10
            // 
            this.epeks.SetDecoration(this.pictureBox10, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(366, 11);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(41, 34);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 110;
            this.pictureBox10.TabStop = false;
            // 
            // psearchclose
            // 
            this.psearchclose.BackColor = System.Drawing.Color.Transparent;
            this.epeks.SetDecoration(this.psearchclose, BunifuAnimatorNS.DecorationType.None);
            this.psearchclose.Image = ((System.Drawing.Image)(resources.GetObject("psearchclose.Image")));
            this.psearchclose.ImageActive = null;
            this.psearchclose.Location = new System.Drawing.Point(1088, 2);
            this.psearchclose.Name = "psearchclose";
            this.psearchclose.Size = new System.Drawing.Size(27, 29);
            this.psearchclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.psearchclose.TabIndex = 117;
            this.psearchclose.TabStop = false;
            this.psearchclose.Zoom = 10;
            this.psearchclose.Click += new System.EventHandler(this.psearchclose_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.epeks.SetDecoration(this.label41, BunifuAnimatorNS.DecorationType.None);
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(3, 7);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(296, 17);
            this.label41.TabIndex = 121;
            this.label41.Text = "SEARCH BOX (Press F5 to refresh the Table)";
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // epeks
            // 
            this.epeks.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.epeks.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.epeks.DefaultAnimation = animation1;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1236, 727);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ppoedit);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelsearch);
            this.Controls.Add(this.psearchpo);
            this.epeks.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Form";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Responsive_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Responsive_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.btn_slidePanel)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrequiredqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnx)).EndInit();
            this.panelsearch.ResumeLayout(false);
            this.panelsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncloseme)).EndInit();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel48.ResumeLayout(false);
            this.panel48.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtysearch)).EndInit();
            this.panel40.ResumeLayout(false);
            this.panel40.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.psearch.ResumeLayout(false);
            this.psearch.PerformLayout();
            this.pdate.ResumeLayout(false);
            this.pset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider1)).EndInit();
            this.paneltitleris.ResumeLayout(false);
            this.paneltitleris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.add_panel.ResumeLayout(false);
            this.preports.ResumeLayout(false);
            this.psettings.ResumeLayout(false);
            this.panelCP.ResumeLayout(false);
            this.productset.ResumeLayout(false);
            this.p_category.ResumeLayout(false);
            this.paddproduct.ResumeLayout(false);
            this.additem_panel.ResumeLayout(false);
            this.additem_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitPrice)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.catpanel.ResumeLayout(false);
            this.catpanel.PerformLayout();
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.supppanel.ResumeLayout(false);
            this.supppanel.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.unitpanel.ResumeLayout(false);
            this.unitpanel.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.emppanel.ResumeLayout(false);
            this.emppanel.PerformLayout();
            this.panel45.ResumeLayout(false);
            this.panel45.PerformLayout();
            this.deppanel.ResumeLayout(false);
            this.deppanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel26.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isearch)).EndInit();
            this.panelitemedit.ResumeLayout(false);
            this.panelitemedit.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panelpassword.ResumeLayout(false);
            this.panelpassword.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.p_rsales.ResumeLayout(false);
            this.p_returned_med.ResumeLayout(false);
            this.p_invmed.ResumeLayout(false);
            this.p_unusedstocks.ResumeLayout(false);
            this.p_expired.ResumeLayout(false);
            this.panel_recap.ResumeLayout(false);
            this.panel_outstock.ResumeLayout(false);
            this.panel_outstock.PerformLayout();
            this.panel_pending_item.ResumeLayout(false);
            this.panel_pending_item.PerformLayout();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel25.PerformLayout();
            this.p_HistoryLogs.ResumeLayout(false);
            this.p_HistoryLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Closeme)).EndInit();
            this.p_damageMed.ResumeLayout(false);
            this.p_damageMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_expClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_expInputno)).EndInit();
            this.tb_generatedLogs.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.PMtable.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.RTable.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel47.ResumeLayout(false);
            this.panel47.PerformLayout();
            this.panel50.ResumeLayout(false);
            this.panelRIS.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.tableLayoutPanel28.ResumeLayout(false);
            this.tableLayoutPanel31.ResumeLayout(false);
            this.tableLayoutPanel32.ResumeLayout(false);
            this.tableLayoutPanel32.PerformLayout();
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.tableLayoutPanel29.ResumeLayout(false);
            this.tableLayoutPanel29.PerformLayout();
            this.panel42.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotifExpired)).EndInit();
            this.tInventory.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel44.ResumeLayout(false);
            this.panel44.PerformLayout();
            this.panel46.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.phome.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ppoedit.ResumeLayout(false);
            this.ppoedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclosepoedit)).EndInit();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmqtyupdate)).EndInit();
            this.panel34.ResumeLayout(false);
            this.psearchpo.ResumeLayout(false);
            this.psearchpo.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbqty)).EndInit();
            this.panel36.ResumeLayout(false);
            this.panel36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psearchclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btn_slidePanel;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPM;
        private System.Windows.Forms.Label timein;
        private System.Windows.Forms.Label time_in;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelsearch;
        private Bunifu.Framework.UI.BunifuImageButton btncloseme;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.TextBox tbsearchitem;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.ListView LVSearch;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.NumericUpDown qtysearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnaddsearch;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.ColumnHeader columnHeader75;
        private System.Windows.Forms.ColumnHeader columnHeader77;
        private System.Windows.Forms.ColumnHeader columnHeader78;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label88;
        private Bunifu.Framework.UI.BunifuImageButton btnx;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.NumericUpDown btnrequiredqty;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox selecteditemtb;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.NumericUpDown currentqty;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdatetbris;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label tbselecteditem;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.LinkLabel hideme;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.ColumnHeader columnHeader88;
        private System.Windows.Forms.ComboBox cbcategorysearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel psearch;
        private System.Windows.Forms.Panel pdate;
        private System.Windows.Forms.Panel pset;
        private Bunifu.Framework.UI.BunifuFlatButton btnaddproduct;
        private Bunifu.Framework.UI.BunifuFlatButton btncatSettings;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuImageButton slider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuImageButton slider1;
        private Bunifu.Framework.UI.BunifuTileButton rreturn;
        private Bunifu.Framework.UI.BunifuTileButton btnrequested_items;
        private Bunifu.Framework.UI.BunifuTileButton btn_unused;
        private Bunifu.Framework.UI.BunifuTileButton rinventory;
        private Bunifu.Framework.UI.BunifuTileButton rexpired;
        private System.Windows.Forms.Panel paneltitleris;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Panel add_panel;
        private System.Windows.Forms.Panel preports;
        private System.Windows.Forms.Panel psettings;
        private System.Windows.Forms.Panel panelCP;
        private System.Windows.Forms.Panel productset;
        private System.Windows.Forms.Panel p_category;
        private System.Windows.Forms.Panel paddproduct;
        private System.Windows.Forms.Panel additem_panel;
        private Bunifu.Framework.UI.BunifuFlatButton btnsaveproduct;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addproductcategory;
        private System.Windows.Forms.ComboBox cbaddunit;
        private System.Windows.Forms.ComboBox cbaddunitmeasure;
        private System.Windows.Forms.ComboBox cbcategoryunit;
        private System.Windows.Forms.Label label49;
        private Bunifu.Framework.UI.BunifuMetroTextbox ProductName;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Panel catpanel;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.ComboBox cbcat;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate4;
        private Bunifu.Framework.UI.BunifuFlatButton btnsave4;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbcat;
        private System.Windows.Forms.Panel supppanel;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblsupname;
        private Bunifu.Framework.UI.BunifuMetroTextbox supnametxt;
        private System.Windows.Forms.ComboBox cb_set_supplier;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sve2;
        private System.Windows.Forms.Panel unitpanel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbunitSelector;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cb_set_unit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sve3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_setunit;
        private System.Windows.Forms.Panel emppanel;
        private System.Windows.Forms.Panel panel45;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbfullname;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdatefn;
        private Bunifu.Framework.UI.BunifuFlatButton btnsavefn;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbfullname;
        private System.Windows.Forms.Panel deppanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbdepartment;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate5;
        private Bunifu.Framework.UI.BunifuFlatButton btnsave5;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbdepartment;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuFlatButton btndep;
        private Bunifu.Framework.UI.BunifuFlatButton btnemp;
        private Bunifu.Framework.UI.BunifuFlatButton btnunit;
        private Bunifu.Framework.UI.BunifuFlatButton btnsup;
        private Bunifu.Framework.UI.BunifuFlatButton btncat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.Panel panel26;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox isearch;
        private System.Windows.Forms.ListView LVitem;
        private System.Windows.Forms.ColumnHeader columnHeader84;
        private System.Windows.Forms.ColumnHeader columnHeader85;
        private System.Windows.Forms.ColumnHeader columnHeader86;
        private System.Windows.Forms.ColumnHeader columnHeader87;
        private System.Windows.Forms.Panel panelpassword;
        private System.Windows.Forms.CheckBox cshow;
        private Bunifu.Framework.UI.BunifuFlatButton Blog;
        private System.Windows.Forms.Panel panel16;
        private Bunifu.Framework.UI.BunifuFlatButton savePassword;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox tcpw;
        private Bunifu.Framework.UI.BunifuMetroTextbox tnpw;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tpw;
        private Bunifu.Framework.UI.BunifuMetroTextbox tun;
        private System.Windows.Forms.CheckBox shownew;
        private System.Windows.Forms.Label getid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.CheckBox checkBox1;
        private MetroFramework.Controls.MetroComboBox cgender;
        private MetroFramework.Controls.MetroComboBox ctitle;
        private Bunifu.Framework.UI.BunifuMetroTextbox tempid;
        private Bunifu.Framework.UI.BunifuMetroTextbox tfn;
        private Bunifu.Framework.UI.BunifuMetroTextbox tusername;
        private Bunifu.Framework.UI.BunifuMetroTextbox tln;
        private Bunifu.Framework.UI.BunifuMetroTextbox tpassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox tmn;
        private Bunifu.Framework.UI.BunifuFlatButton saveUser;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel p_rsales;
        private System.Windows.Forms.Panel p_returned_med;
        private System.Windows.Forms.Panel p_invmed;
        private System.Windows.Forms.Panel p_unusedstocks;
        private System.Windows.Forms.Panel p_expired;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.ListView LVEXP;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ColumnHeader columnHeader49;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private Bunifu.Framework.UI.BunifuFlatButton btn_expiredLogs;
        private Bunifu.Framework.UI.BunifuFlatButton btnExpired;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.ComboBox cb_expBatch;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox cb_dateExp;
        private System.Windows.Forms.Label label62;
        private Bunifu.Framework.UI.BunifuFlatButton btnfetchexp;
        private System.Windows.Forms.Panel p_damageMed;
        private Bunifu.Framework.UI.BunifuImageButton btn_expClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetdamaged;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown tb_expInputno;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_expQty;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_itemnamedamage;
        private System.Windows.Forms.Panel p_HistoryLogs;
        private System.Windows.Forms.ComboBox batchbtn;
        private Bunifu.Framework.UI.BunifuImageButton btn_Closeme;
        private System.Windows.Forms.ListView LVLogs;
        private System.Windows.Forms.ColumnHeader columnHeader62;
        private System.Windows.Forms.ColumnHeader columnHeader63;
        private System.Windows.Forms.ColumnHeader columnHeader64;
        private System.Windows.Forms.ColumnHeader columnHeader65;
        private System.Windows.Forms.ColumnHeader columnHeader66;
        private System.Windows.Forms.ColumnHeader columnHeader67;
        private System.Windows.Forms.ColumnHeader columnHeader68;
        private System.Windows.Forms.Label MedLOGS;
        private Bunifu.Framework.UI.BunifuTileButton btn_prnitExpDamaged;
        private System.Windows.Forms.TableLayoutPanel tb_generatedLogs;
        private System.Windows.Forms.ListView GLLV;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroDateTime GLfromdate;
        private Bunifu.Framework.UI.BunifuFlatButton btn_fetchrecordGL;
        private System.Windows.Forms.ComboBox cb_batchGL;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private MetroFramework.Controls.MetroDateTime GLtodate;
        private System.Windows.Forms.TableLayoutPanel PMtable;
        private System.Windows.Forms.ListView PMLV;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private Bunifu.Framework.UI.BunifuTileButton btn_PMprint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroDateTime dateforIM;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuFlatButton PMfetchbtn;
        private System.Windows.Forms.ComboBox cb_batchno;
        private System.Windows.Forms.TableLayoutPanel RTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private MetroFramework.Controls.MetroDateTime rfrom;
        private MetroFramework.Controls.MetroDateTime rto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_rfetch;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.ListView rlistview;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private Bunifu.Framework.UI.BunifuTileButton btn_rprint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroDateTime from;
        private MetroFramework.Controls.MetroDateTime to;
        private Bunifu.Framework.UI.BunifuFlatButton btnfetch;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ListView LVsales;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private Bunifu.Framework.UI.BunifuMetroTextbox total_monthly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private Bunifu.Framework.UI.BunifuTileButton btn_Charge;
        private Bunifu.Framework.UI.BunifuTileButton sprint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroDateTime fromdate;
        private MetroFramework.Controls.MetroDateTime todate;
        private Bunifu.Framework.UI.BunifuFlatButton fetch;
        private Bunifu.Framework.UI.BunifuTileButton btnprint;
        private System.Windows.Forms.ListView LVreport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Panel panelRIS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.ListView LVRIS;
        private System.Windows.Forms.ColumnHeader columnHeader71;
        private System.Windows.Forms.ColumnHeader columnHeader72;
        private System.Windows.Forms.ColumnHeader columnHeader73;
        private System.Windows.Forms.ColumnHeader columnHeader74;
        private System.Windows.Forms.ColumnHeader columnHeader79;
        private System.Windows.Forms.Panel panel41;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintRIS;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveRIS;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel28;
        private Bunifu.Framework.UI.BunifuFlatButton btndeleteris;
        private Bunifu.Framework.UI.BunifuFlatButton btnsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btneditris;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel31;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbRisID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel29;
        private System.Windows.Forms.ComboBox cbissued;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.ComboBox cbreceived;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.ComboBox cbdept;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.ComboBox cbrequest;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblBadge;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel tInventory;
        private Bunifu.Framework.UI.BunifuFlatButton btnpoupdate;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.ListView LVPO;
        private System.Windows.Forms.ColumnHeader columnHeader55;
        private System.Windows.Forms.ColumnHeader columnHeader56;
        private System.Windows.Forms.ColumnHeader columnHeader57;
        private System.Windows.Forms.ColumnHeader columnHeader58;
        private System.Windows.Forms.ColumnHeader columnHeader59;
        private System.Windows.Forms.ColumnHeader columnHeader60;
        private System.Windows.Forms.ColumnHeader columnHeader61;
        private System.Windows.Forms.ColumnHeader columnHeader70;
        private System.Windows.Forms.ColumnHeader columnHeader80;
        private System.Windows.Forms.ColumnHeader columnHeader81;
        private System.Windows.Forms.ColumnHeader columnHeader82;
        private System.Windows.Forms.ColumnHeader columnHeader83;
        private System.Windows.Forms.Panel panel33;
        private Bunifu.Framework.UI.BunifuFlatButton btnpodelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnpoprint;
        private Bunifu.Framework.UI.BunifuFlatButton btnposave;
        private System.Windows.Forms.ListView LVnotification;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel phome;
        private Bunifu.Framework.UI.BunifuFlatButton btnPOS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton b3;
        private Bunifu.Framework.UI.BunifuFlatButton b2;
        private Bunifu.Framework.UI.BunifuFlatButton btnhome;
        private Bunifu.Framework.UI.BunifuFlatButton b1;
        private System.Windows.Forms.ColumnHeader columnHeader89;
        private System.Windows.Forms.Panel panelitemedit;
        private System.Windows.Forms.Panel panel24;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label label63;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbname;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox cbitemcat;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label67;
        private Bunifu.Framework.UI.BunifuFlatButton tbsearchpo;
        private System.Windows.Forms.Panel psearchpo;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ListView LVPOSEARCH;
        private System.Windows.Forms.ColumnHeader columnHeader91;
        private System.Windows.Forms.ColumnHeader columnHeader92;
        private System.Windows.Forms.ColumnHeader columnHeader93;
        private System.Windows.Forms.ColumnHeader columnHeader94;
        private Bunifu.Framework.UI.BunifuImageButton psearchclose;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label getItemName;
        private System.Windows.Forms.NumericUpDown tbqty;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.ComboBox cbcategoryitem;
        private System.Windows.Forms.TextBox tbsearchpoitem;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_poid;
        private System.Windows.Forms.DateTimePicker dt_expired_date;
        private System.Windows.Forms.DateTimePicker dt_before_expire;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_poreorderedlvl;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbamount;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label48;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbunitprice;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox tbsupplier;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label psearch_add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ADD;
        private System.Windows.Forms.Panel ppoedit;
        private System.Windows.Forms.Label label73;
        private Bunifu.Framework.UI.BunifuImageButton btnclosepoedit;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label label75;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbitemnameupdate;
        private System.Windows.Forms.Label label74;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbitemidupate;
        private System.Windows.Forms.Label label40;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbpoidupdate;
        private System.Windows.Forms.NumericUpDown nmqtyupdate;
        private System.Windows.Forms.DateTimePicker dtexpired;
        private System.Windows.Forms.DateTimePicker dtmob4expire;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbreorderup;
        private System.Windows.Forms.Label label68;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbamountup;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbupriceupdate;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.ComboBox cbsupup;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Panel panel34;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdatepo;
        private System.Windows.Forms.ComboBox cbitemcatup;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.ComboBox tbunitup;
        private System.Windows.Forms.ComboBox tbumeasureupdate;
        private System.Windows.Forms.ComboBox cbucatup;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.DateTimePicker dtpodate;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.ColumnHeader columnHeader69;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.DateTimePicker dtrisdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnaddexistingpo;
        private Bunifu.Framework.UI.BunifuFlatButton btnrefreshresult;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.ComboBox cbapprovedpo;
        private System.Windows.Forms.ComboBox cbreqbypo;
        private System.Windows.Forms.ColumnHeader columnHeader90;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.ColumnHeader columnHeader95;
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.ComboBox cblogreceived;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.ComboBox cblogissued;
        private System.Windows.Forms.Panel panel50;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox cblogreq;
        private System.Windows.Forms.ComboBox cbdepreport;
        private Bunifu.Framework.UI.BunifuFlatButton logsToday;
        private Bunifu.Framework.UI.BunifuFlatButton RisLogs;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.NumericUpDown unitPrice;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.Panel hideDate;
        private System.Windows.Forms.Panel hideMeEditPanel;
        private Bunifu.Framework.UI.BunifuImageButton btnNotifExpired;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.TextBox tbGrandTotal;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private Bunifu.Framework.UI.BunifuTileButton btn_recap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox tbgetyear;
        private System.Windows.Forms.ColumnHeader columnHeader50;
        private System.Windows.Forms.ColumnHeader columnHeader76;
        private System.Windows.Forms.ColumnHeader columnHeader96;
        private Bunifu.Framework.UI.BunifuTileButton btn_outofstock;
        private Bunifu.Framework.UI.BunifuTileButton btn_po;
        private BunifuAnimatorNS.BunifuTransition epeks;
        private System.Windows.Forms.Panel panel_recap;
        private System.Windows.Forms.Panel panel_outstock;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Panel panel_pending_item;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.ComboBox cb_suppliername;
        private System.Windows.Forms.ComboBox cb_categorySignature;
        private System.Windows.Forms.ColumnHeader columnHeader97;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label104;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbitemid;
        private System.Windows.Forms.Label label66;
        private Bunifu.Framework.UI.BunifuMetroTextbox editUnitPrice;
    }
}