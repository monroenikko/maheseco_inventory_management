using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Timers;
using BRIGHTSIDE_IDEA_POS;
using BRIGHTSIDE_IDEA_POS.Crystal_report;

namespace WindowsFormsApplication1
{
    
    public partial class InventoryForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=maheseco_inventory; port= 3306; username=root;password=");
        
        private MySqlDataAdapter Adapter;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
         
        private MySqlCommand Cmd;
         
        MySqlDataReader Reader;

        string getStatus1;
        string getStatus2;
        string getStatus3;

      //  OR.Text, tsupname.Text,Ddate.Text, id.Text
       
        public InventoryForm(string user, string num1)
        {
            InitializeComponent();
            autoComplete();
          //  autoComplete1();

            KeyPreview = true;

            //this is for sidebar start
            lblPM.Text = "HOME";
            tInventory.Visible = false;
            panel13.Visible = true;

            preports.Visible = false;
            psettings.Visible = false;
            pset.Visible = false;//
            pdate.Visible = false;//
            psearch.Visible = false;//
            paneltitleris.Visible = false;
            panelRIS.Visible = false;
            //paddproduct.Visible = false;
            //end sidebar
            tbamount.Enabled = false;

            Username.Text = user;
            timein.Text = num1;
            lblBadge.Hide();

            //for generated batch to inventory medicine
            fillcombo();

            //for generated logs (inventory medicine)
            fillcomboToGL();
            
            fillcomboToEXP();
            

            lblPM.Text = "HOME";
            depFill();

            //tablepanelbatch.Visible = false;
           // tb_pobatchno.Enabled = false;
            label3.Visible = false;

            panel13.Visible = true;
            categorySettings();
            unitCat();
            

            btnhome.selected = true;
            getSuppier();
            btnpoupdate.SendToBack();

            //for search box
            retrieve();
                //generating the po_id
          //  getbatchno();

            phome.Visible = true;

            getitemunit();
            //unitFormedicine();
            //unitcat();
            //unitMeasure();
            retrieveItem();

            retrievePOSEARCH();
            //retrieve_LVPOSEARCH();
            //cbcatsearch();

            //rreturn.Visible = false;
            //btn_unused.Visible = false;
            tbamountup.Enabled = false;

            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy");
            tbgetyear.Text = MySQLFormatDate.ToString();
            ////Reorder();

            tbitemid.Enabled = false;

        }


        int ybadge;
        private void notify_running_out()
        {
            try
            {
                connection.Close();
                //Adapter.Dispose();

                Adapter = new MySqlDataAdapter("SELECT * FROM inventory_logs WHERE status = 0 && ending != 0 && ending <= reorder_lvl ", connection);
                ds.Reset();
                Adapter.Fill(ds);

                //LVnotification.Items.Clear();
                //LVEXP.Items.Clear();
                string running = "running out!";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        
                        LVnotification.Items.Add(ds.Tables[0].Rows[i]["item_name"].ToString());
                        LVnotification.Items[LVnotification.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_unit"].ToString());
                        LVnotification.Items[LVnotification.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["po_id"].ToString());
                        LVnotification.Items[LVnotification.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["remarks"].ToString());

                    }

                    connection.Close();
                    

                    for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                    {
                        
                        if (x < 0)
                        {

                        }
                        else
                        {
                            ybadge = x + 1;
                            lblBadge.Text = Convert.ToString(ybadge);
                            lblBadge.Show();
                        }

                    }
                }

                //  AutoExpired();
                //AutoExpired1();
                //generateExpiredMeds();
                updateRemarks();
                //Inventorymed_total();
                //  notify_running_out();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }

        

        void updateRemarks()
        {
            string update = "UPDATE inventory_logs SET remarks ='RUNNING OUT!' WHERE status = 0 && ending != 0  ";
            connection.Close();
            connection.Open();
            try
            {
                Cmd = new MySqlCommand(update, connection);
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    // MessageBox.Show("Medicine is now Expired!", "MEDICINE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // MessageBox.Show("Medicine is not Updated!", "MEDICINE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }

        public void Reorder()
        {

            string sql = "SELECT * FROM inventory_logs WHERE status = 0 && ending != 0 ";
            Cmd = new MySqlCommand(sql, connection);

            connection.Close();
            connection.Open();
            //execute reader
            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                reordered_num = Reader.GetInt32("");
                rstock = Reader.GetInt32("ending");
                string item_name = Reader.GetString("item_name");
                //MessageBox.Show("The po_id is selected", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // samplestock.Text = Convert.ToString(rstock);

                //condition for reOrdered vs. stock
                if (reordered_num < rstock)
                {
                    MessageBox.Show("your stock is Good", "INFORMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Your stock " + item_name + " has " + rstock + " pc(s) and it's running out!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    updateRemarks();
                }

            }
            else
            {

                MessageBox.Show("NO DATA FILL");
            }
            Reader.Close();

            connection.Close();
        }

        
        private void Responsive_Load(object sender, EventArgs e)
        {                        
            total_monthly.Enabled = false;
           // P_id.Enabled = false;            

            tb_search.Text = "search";

            //autogenerated id
           // postId();
            UserId();            

            tempid.Enabled = false;

            //panelCP.Visible = false;            

            welcome();
            
            //lblPM.Text = "HOME";

            fillNotification();
            updateRemarks();
            updateRemarksExpired();
            MessageBoxNotif();
            expiredNow();

            nameFill();
            unitCategory();

            p_returned_med.Visible = false;
            retrive();
            //retrieve();

            //GenerateData();
            poqty();           


           // ControlExtension.Draggable(P_EDIT, true);
            ControlExtension.Draggable(p_damageMed, true);
            ControlExtension.Draggable(p_HistoryLogs, true);
            ControlExtension.Draggable(panelsearch, true);
            ControlExtension.Draggable(panelEdit, true);
            ControlExtension.Draggable(psearchpo, true);
            ControlExtension.Draggable(ppoedit, true);


           // tboldprice.Enabled = false;
           // tbitemname.Enabled = false;
            tb_expQty.Enabled = false;
            tb_itemnamedamage.Enabled = false;

            //System.Timers.Timer timer = new System.Timers.Timer();
            //timer.Interval = 1000;
            //timer.Elapsed += Timer_Elapsed;
            //timer.Start();

            timer1.Start();

            selecteditemtb.Enabled = false;
            currentqty.Enabled = false;

            //  tbselecteditem.Enabled = false;
            tbpoidupdate.Enabled = false;

        }

        //private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    circularProgressBar1.Invoke((MethodInvoker)delegate
        //    {
        //        circularProgressBar1.Text = DateTime.Now.ToString("hh:mm:ss");
        //        circularProgressBar1.SubscriptText = DateTime.Now.ToString("tt");
        //    });
        //}

        void AutoExpired()
        {
            string update = "UPDATE purchase_order_logs SET status=1 WHERE before_expire ='" + atime + "' ";
            connection.Close();
            connection.Open();
            try
            {
                Cmd = new MySqlCommand(update, connection);
                if (Cmd.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show("Medicine is now Expired!", "MEDICINE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   // MessageBox.Show("Medicine is not Updated!", "MEDICINE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            connection.Close();
        }

        void AutoExpired1()
        {        
            connection.Close();
            connection.Open();
            Cmd = new MySqlCommand("UPDATE inventory_logs SET status=1 WHERE setmonthdateExp ='" + atime + "' ", connection);

            if (Cmd.ExecuteNonQuery() == 1)
            {
               // MessageBox.Show("Medicine is now Expired!", "MEDICINE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               // MessageBox.Show("Medicine is not Updated!", "MEDICINE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        
        private void generateExpiredMeds()
        {
            try
            {
                // MySqlCommand command = new MySqlCommand();
                

                Adapter = new MySqlDataAdapter("SELECT *, FORMAT(unit_price, 2) as price, FORMAT(total_amt, 2) as total  FROM inventory_logs WHERE pocategory='Medicine' && setmonthdateExp <='" + atime + "' &&  status = 0 ORDER BY item_name ASC", connection);
                ds.Reset();
                Adapter.Fill(ds);

                LVEXP.Items.Clear();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        LVEXP.Items.Add(ds.Tables[0].Rows[i]["inventory_num"].ToString());
                        LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["po_id"].ToString());
                        LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_name"].ToString());
                        LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_unit"].ToString());
                        LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["dateExp"].ToString());
                        LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i][string.Format("{0:#,##0.##}", "price")].ToString());
                        LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                        LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i][string.Format("{0:#,##0.##}", "total")].ToString());
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }

        void updateRemarksExpired()
        {
            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy-MM-dd");
            atime = MySQLFormatDate.ToString();

            string update = "UPDATE inventory_logs SET remarks ='EXPIRED!' WHERE pocategory='Medicine' && setmonthdateExp <='" + atime + "'  ";
            connection.Close();
            connection.Open();
            try
            {
                Cmd = new MySqlCommand(update, connection);
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    // MessageBox.Show("Medicine is now Expired!", "MEDICINE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // MessageBox.Show("Medicine is not Updated!", "MEDICINE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }

        int ybadge2;
        void fillNotification()
        {
            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy-MM-dd");
            atime = MySQLFormatDate.ToString();

            try
            {
                connection.Close();

                Adapter = new MySqlDataAdapter("SELECT * from inventory_logs where pocategory='Medicine' && setmonthdateExp <='" + atime + "' ", connection);
                ds.Reset();
                Adapter.Fill(ds);

                LVnotification.Items.Clear();
                LVEXP.Items.Clear();               

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                       // LVnotification.ForeColor = System.Drawing.Color.Red;
                        LVnotification.Items.Add(ds.Tables[0].Rows[i]["item_name"].ToString());
                        LVnotification.Items[LVnotification.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_unit"].ToString());
                        LVnotification.Items[LVnotification.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["po_id"].ToString());
                        LVnotification.Items[LVnotification.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["remarks"].ToString());
                        //LVnotification.ForeColor = System.Drawing.Color.Red;
                    }

                    connection.Close();
                    //int cnt = 0;

                    for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                    {
                        if (x < 0)
                        {

                        }
                        else
                        {
                            ybadge2 = x + 1;
                            lblBadge.Text = Convert.ToString(ybadge2);
                            lblBadge.Show();
                        }


                        //cnt++;

                    }
                    
                }

                AutoExpired();
                AutoExpired1();
                generateExpiredMeds();
                notify_running_out();


                lblBadge.Text = Convert.ToString(ybadge2 + ybadge);
                lblBadge.Show();
                //Inventorymed_total();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("hh:mm");
            lblsecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void retrive()
        {            
            string insert = "INSERT INTO log (username ,password)"
            + "VALUES('" + tun.Text + "', '" + tpw.Text + "');";

            Cmd = new MySqlCommand(insert, connection);

            try
            {
                connection.Close();
                connection.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void getbatchno()
        {
            try
            {
                connection.Close();
                connection.Open();

                Cmd = new MySqlCommand("SELECT max(po_id)+1 FROM purchase_order", connection);

                tb_poid.Text = Cmd.ExecuteScalar().ToString();

            }
            finally
            {
                connection.Close();
            }
        }


       
        //void postId()
        //{
        //    connection.Open();
        //    try
        //    {
        //        Cmd = new MySqlCommand("SELECT max(ItemID)+1 FROM drug_product", connection);
        //        P_id.Text = Cmd.ExecuteScalar().ToString();
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

        void UserId()
        {
            connection.Close();
            connection.Open();
            try
            {
                Cmd = new MySqlCommand("SELECT max(id)+1 FROM user", connection);
                tempid.Text = Cmd.ExecuteScalar().ToString();
            }
            finally
            {
                connection.Close();
            }
        }





        //clear data

        string unit;

      

        //databinding


        private void tb_search_OnTextChange(object sender, EventArgs e)
        {
            
        }

        

      

      

       
        //int idno;
        

        void autoComplete()
        {
            tb_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection colll = new AutoCompleteStringCollection();

            try
            {                 
                Cmd = new MySqlCommand("SELECT * FROM item_product", connection);

                connection.Close();
                connection.Open();

                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                   
                    string item2 = Reader.GetString("ItemName");
                    colll.Add(item2);

                }
                
                connection.Close();

            }
            catch
            {

            }
            tb_search.AutoCompleteCustomSource = colll;
        }

        private void btn_slidePanel_Click(object sender, EventArgs e)
        {
            logo.Visible = true;
 
            if (phome.Width == 287)
            {
                phome.Visible = false;
                phome.Width = 63;
                epeks.ShowSync(phome);
                 

            }
            else
            {
                logo.Visible = false;
                phome.Visible = false;
                phome.Width = 287;

                epeks.ShowSync(phome);

                btnhome.Visible = true;
                b1.Visible = true;
                b2.Visible = true;
                b3.Visible = true;
               
            }
        }

      

        private void tb_search_Enter(object sender, EventArgs e)
        {
            if (tb_search.Text == "search")
            {
                tb_search.Text = "";
                tb_search.ForeColor = Color.Green;
            }
        }

        private void tb_search_Leave(object sender, EventArgs e)
        {
            if (tb_search.Text == "")
            {
                tb_search.Text = "search";
                tb_search.ForeColor = Color.Green;
            }

            LVitem.Items.Clear();
            retrieveItem();
        }

       

        private void scape()
        {
            if (MessageBox.Show("Are you Sure, Do you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                mform frm = new mform();
                frm.Show();
                connection.Close();

                notifyIcon1.Visible = false;
            }
        }

       
        private void logout_MouseClick(object sender, MouseEventArgs e)
        {
            scape();                       
        }
       

        void getallunit()
        {
            unit = getStatus1 + getStatus2 + getStatus3;
        }




        private void btnhome_Click(object sender, EventArgs e)
        {
            lblPM.Text = "HOME";
            tInventory.Visible = false;
            panel13.Visible = true;
            panel4.Visible = true;
            add_panel.Visible = true;
            panel5.Visible = true;

            preports.Visible = false;
            psettings.Visible = false;
            pset.Visible = false;//
            pdate.Visible = false;//
            psearch.Visible = false;//
            paneltitleris.Visible = false;
            panelRIS.Visible = false;

        }


        private void b1_Click(object sender, EventArgs e)
        {
            //true
            lblPM.Text = "Product Maintenance";
            add_panel.Visible = true;
            psearch.Visible = true;
            tInventory.Visible = true;
            //tablepanelbatch.Visible = true;
            label3.Visible = true;
            panel13.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;


            //false this is where the system affected by bugs
            pdate.Visible = false;
            psettings.Visible = false;
            preports.Visible = false;
            pset.Visible = false;
            panelRIS.Visible = false;
            paneltitleris.Visible = false;

            cbucatup.Items.Clear();
            tbumeasureupdate.Items.Clear();
            tbunitup.Items.Clear();

            cbitemcatup.Items.Clear();
            cbcategoryitem.Items.Clear();
            categorySettings();

           // unitFormedicine();
           // unitcat();
           // unitMeasure();

            cbreqbypo.Items.Clear();
            cbapprovedpo.Items.Clear();
            nameFill();
        }
        

        private void btnPOS_Click(object sender, EventArgs e)
        {
            lblPM.Text = "Requisition and Issue Slip";
            panel4.Visible = true;
            add_panel.Visible = true;
            panel5.Visible = true;

            panel13.Visible = true;
            psearch.Visible = true;
            tInventory.Visible = true;
            //tablepanelbatch.Visible = true;
            label3.Visible = true;
            paneltitleris.Visible = true;
            panelRIS.Visible = true;

           
            preports.Visible = false;
            psettings.Visible = false;
            pset.Visible = false;
            pdate.Visible = false;

            cbcategorysearch.Items.Clear();
            categorySettings();

            cbfullname.Items.Clear();
            cbrequest.Items.Clear();
            cbreceived.Items.Clear();
            cbissued.Items.Clear();
            nameFill();

            cbdepartment.Items.Clear();
            cbdept.Items.Clear();
            depFill();

        }

        private void b2_Click(object sender, EventArgs e)
        {
            //true
            panel5.Visible = true;
            lblPM.Text = "Reports";
            preports.Visible = true;
            pdate.Visible = true;
            add_panel.Visible = true;
            panel13.Visible = true;
            psearch.Visible = true;            
            panel4.Visible = true;

            clearcb();
            depfillclear();


           
            //false
            psettings.Visible = false;
            pset.Visible = false;

            paneltitleris.Visible = false;
            panelRIS.Visible = false;

            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;
            p_invmed.Visible = true;
            p_unusedstocks.Visible = false;

            PMLV.Items.Clear();
            retrieveInventory();
            tbgetyear.Enabled = false;

        }

        private void b3_Click(object sender, EventArgs e)
        {
            //true
            lblPM.Text = "Settings";
            preports.Visible = true;
            psettings.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;



            pdate.Visible = true;//
            add_panel.Visible = true;
            panel13.Visible = true;
            psearch.Visible = true;
            pset.Visible = true;

            //false
            panelRIS.Visible = false;
            paneltitleris.Visible = false;

            //populating unit
            cbcategoryunit.Items.Clear();
            cbaddunitmeasure.Items.Clear();
            cbaddunit.Items.Clear();
            cbcat.Items.Clear();

            cbitemcat.Items.Clear();

            comboBox4.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();

            addproductcategory.Items.Clear();

            categorySettings();


            unitFormedicine();
            unitcat();
            unitMeasure();


        }

     




 




        private void btnAddQty_Click(object sender, EventArgs e)
        {
            
        }

        
      
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;

            panelCP.Visible = false;
            productset.Visible = false;
            tableLayoutPanel1.Visible = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;

            //psettings.Visible = false;
            panelCP.Visible = true;
            productset.Visible = false;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;

            tableLayoutPanel1.Visible = true;
            panelCP.Visible = true;
            productset.Visible = true;
            p_category.Visible = false;

            //retrieveItem(); 
            panelitemedit.Visible = false;
            panel24.Visible = false;
            panel2.Visible = false;

            cbitemcat.Items.Clear();

            comboBox4.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();

            categorySettings();
            unitFormedicine();
            unitcat();
            unitMeasure();

            


        }


        private void btncatSettings_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;

            tableLayoutPanel1.Visible = true;
            panelCP.Visible = true;
            productset.Visible = true;
            p_category.Visible = true;

            
            paddproduct.Visible = false;

            btncat.selected = true;
            btnsup.selected = false;
            btnunit.selected = false;
            btnemp.selected = false;
            btndep.selected = false;

            catpanel.Visible = true;
            unitpanel.Visible = false;
            emppanel.Visible = false;
            supppanel.Visible = false;
            deppanel.Visible = false;

            cbcat.Items.Clear();
            categorySettings();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;

            tableLayoutPanel1.Visible = true;
            panelCP.Visible = true;
            productset.Visible = true;
            p_category.Visible = true;
            paddproduct.Visible = true;

            //lblalertprod.Visible = true;
            //lblred1.Visible = true;
            paddproduct.Visible = true;


            cbcategoryunit.Items.Clear();
            cbaddunitmeasure.Items.Clear();
            cbaddunit.Items.Clear();
            addproductcategory.Items.Clear();

            categorySettings();
            unitFormedicine();
            unitcat();
            unitMeasure();
        }


        //function for keyboard
        private void Responsive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                scape();
            }
            else if (e.KeyCode == Keys.F5)
            {
                PressRefresh();

               
                checkiditem = "";
                getItemName.Text = "ITEM";
                LVPOSEARCH.Items.Clear();
                retrievePOSEARCH();
            }

        }

        

        void welcome()
        {
            MessageBox.Show("Welcome Admin: " + Username.Text + " ", "GREETINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            if (tusername.Text.Contains("blank") && tpassword.Text.Contains("blank") && tfn.Text.Contains("blank") && tmn.Text.Contains("blank") && tln.Text.Contains("blank") && ctitle.PromptText.Contains("--------------Select Title or Position-------------") && cgender.PromptText.Contains("Unknown"))
            {
                MessageBox.Show("Please input the given field(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (MessageBox.Show("Do you want to save it now?", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {


                    //save the item
                    string insert = "INSERT INTO user (id ,username ,password ,position)"
                    + "VALUES('" + tempid.Text + "', '" + tusername.Text + "', '" + tpassword.Text + "','" + ctitle.Text + "');";

                    //modified_ton
                    string insert1 = "INSERT INTO user_information (user_id ,firstname ,middlename ,lastname,  gender)"
                    + "VALUES('" + tempid.Text + "', '" + tfn.Text + "', '" + tmn.Text + "','" + tln.Text + "', '" + cgender.Text + "');";
                    //connection.Open();
                    connection.Close();
                    connection.Open();

                    MySqlCommand Cmd1 = new MySqlCommand(insert1, connection);
                    Cmd = new MySqlCommand(insert, connection);


                    try
                    {
                       
                        if (Cmd.ExecuteNonQuery() == 1 && Cmd1.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("data Saved!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            try
                            {
                                

                                try
                                {
                                    Cmd = new MySqlCommand("SELECT max(uid)+1 FROM log", connection);
                                    tempid.Text = Cmd.ExecuteScalar().ToString();


                                    tusername.Text = "blank";
                                    tpassword.Text = "blank";
                                    tfn.Text = "blank";
                                    tmn.Text = "blank";
                                    tln.Text = "blank";
                                    ctitle.PromptText = "--------------Select Title or Position-------------";
                                    cgender.PromptText = "Unknown";
                                }
                                finally
                                {
                                    connection.Close();
                                }

                            }
                            finally
                            {
                                connection.Close();
                            }

                          

                        }
                        else
                        {
                            MessageBox.Show("data is not Save!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message);
                    }


                    connection.Close();
                }
                else
                {
                    MessageBox.Show("User data is not save", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

 

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Blog_Click(object sender, EventArgs e)
        {
            password();
        }

        private void tpw_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tun_KeyDown(object sender, KeyEventArgs e)
        {
            if (tpw.Text == null)
            {
                tpw.Text = "Enter old Password";
                tpw.ForeColor = Color.Silver;
            }


           
            if (e.KeyCode == Keys.Enter)
            {
                tpw.isPassword = true;
                tpw.Focus();
                tpw.Text = "";
            }
        }

        void password()
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Username = tun.Text.Trim();
                string Password = tpw.Text.Trim();

                User user = new User();

                if (String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Please fill all given fields!");
                }
                else
                {
                    string position = null;
                    string pos_id = null;
                    //call function login
                    user = User.login(Username, Password, position, pos_id);



                    //if match
                    if (Username == user.username && Password == user.password)
                    {

                        if (user.position == "cashier")
                        {
                            getid.Text = user.pos_id;

                            string query1 = "SELECT * FROM user_information WHERE  user_id ='" + getid.Text + "' ";
                            Cmd = new MySqlCommand(query1, connection);

                            connection.Close();
                            connection.Open();

                            //execute reader
                            Reader = Cmd.ExecuteReader();

                            if (Reader.Read())
                            {
                                getid.Text = Reader.GetString("username").ToString();
                                MessageBox.Show("Correct Password!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                panelpassword.Visible = false;
                                connection.Close();

                            }
                            else
                            {

                                MessageBox.Show("NO DATA FILL");
                            }
                            Reader.Close();

                            connection.Close();

                        }
                        else if (user.position == "admin")
                        {

                            getid.Text = user.pos_id;

                            string query1 = "SELECT * FROM user_information WHERE  user_id ='" + getid.Text + "' ";


                            Cmd = new MySqlCommand(query1, connection);

                            connection.Close();
                            connection.Open();

                            //execute reader
                            Reader = Cmd.ExecuteReader();

                            if (Reader.Read())
                            {
                                //getid.Text = Reader.GetString("username").ToString();
                                string query_user = "SELECT * FROM user WHERE  id ='" + getid.Text + "' ";


                                Cmd = new MySqlCommand(query_user, connection);

                                connection.Close();
                                connection.Open();

                                //execute reader
                                Reader = Cmd.ExecuteReader();

                                     if (Reader.Read())
                                        {
                                        getid.Text = Reader.GetString("username").ToString();

                                        MessageBox.Show("Correct Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        panelpassword.Visible = false;
                                        connection.Close();
                                        }
                                    else
                                    {

                                        MessageBox.Show("NO DATA FILL");
                                    }
                                //MessageBox.Show("Correct Password!", "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                                //panelpassword.Visible = false;
                                //connection.Close();
                            }
                            else
                            {

                                MessageBox.Show("NO DATA FILL");
                            }
                            Reader.Close();

                            connection.Close();


                        }
                                           

                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Wrong", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Okay, Double Check your new Password", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cshow.Checked == true)
            {
                tpw.isPassword = false;
            }
            else if (cshow.Checked == false)
            {
                tpw.isPassword = true;
            }
        }

        private void shownew_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        void changePassword()
        {
            if (tnpw.Text == tcpw.Text)
            {
                try
                {
                    if(MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                    {
                        string sql = "UPDATE user SET password='" + tnpw.Text + "'  WHERE username= '" + tun.Text + "'  ";

                        connection.Close();
                        connection.Open();
                        Cmd = new MySqlCommand(sql, connection);


                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Password is now updated!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                panelpassword.Visible = true;

                                tcpw.isPassword = false;
                                tnpw.isPassword = false;
                                tpw.isPassword = false;

                                tcpw.Text = "Confirm new Password";
                                tnpw.Text = "Enter new Password";
                                tpw.Text = "Enter old Password";
                                tun.Text = "Enter your Username";
                            }
                            else
                            {
                                MessageBox.Show("data is not updated");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Okay, Double Check your new Password", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            else
            {

                MessageBox.Show("Wrong Username or Password", "Wrong", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        private void savePassword_Click(object sender, EventArgs e)
        {

            changePassword();
        }

        private void tun_Enter(object sender, EventArgs e)
        {
            if (tun.Text == "Enter your Username")
            {
                tun.Text = "";
                tun.ForeColor = Color.Silver;
            }
        }

        private void tun_Leave(object sender, EventArgs e)
        {
            if (tun.Text == "")
            {
                tun.Text = "Enter your Username";
                tun.ForeColor = Color.Silver;
            }
        }

        private void tpw_Enter(object sender, EventArgs e)
        {
            if (tpw.Text == "Enter old Password")
            {
                tpw.Text = "";
                tpw.ForeColor = Color.Silver;
            }
        }

        private void tpw_Leave(object sender, EventArgs e)
        {
            if (tpw.Text == "")
            {
                tpw.Text = "Enter old Password";
                tpw.ForeColor = Color.Silver;
            }
        }

        private void tnpw_Enter(object sender, EventArgs e)
        {
            if (tnpw.Text == "Enter new Password")
            {
                tnpw.Text = "";
                tnpw.ForeColor = Color.Silver;
            }
        }

        private void tnpw_Leave(object sender, EventArgs e)
        {
            if (tnpw.Text == "")
            {
                tnpw.Text = "Enter new Password";
                tnpw.ForeColor = Color.Silver;
            }
        }

        private void tcpw_Enter(object sender, EventArgs e)
        {
            if (tcpw.Text == "Confirm new Password")
            {
                tcpw.Text = "";
                tcpw.ForeColor = Color.Silver;
            }
        }

        private void tcpw_Leave(object sender, EventArgs e)
        {
            if (tcpw.Text == "")
            {
                tcpw.Text = "Confirm new Password";
                tcpw.ForeColor = Color.Silver;
            }
        }

        private void tnpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (tcpw.Text == null)
            {
                tcpw.Text = "Enter new Password";
                tcpw.ForeColor = Color.Silver;
            }



            if (e.KeyCode == Keys.Enter)
            {
                tcpw.isPassword = true;
                tcpw.Focus();
                tcpw.Text = "";
            }
        }

        private void tcpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (tpw.Text == null)
            {
                tpw.Text = "Enter old Password";
                tpw.ForeColor = Color.Silver;
            }



            if (e.KeyCode == Keys.Enter)
            {
                changePassword();
            }
        }

        private void shownew_CheckStateChanged(object sender, EventArgs e)
        {
            if (shownew.Checked == true)
            {
                tnpw.isPassword = false;
                
            }
            else if (shownew.Checked == false)
            {
                tnpw.isPassword = true;
               
            }
        }

        private void tpw_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password();
                tnpw.isPassword = true;
            }
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            if(todate.Text == fromdate.Text)
            {
                MessageBox.Show("The from date and to date are the same, Pls, choose diff date from FROM", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(cbdepreport.Text == "Select Department")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {

                        Adapter = new MySqlDataAdapter("SELECT * FROM ris WHERE risdate BETWEEN '" + fromdate.Text + "' and '" + todate.Text + "'  ;", connection);
                        ds.Reset();
                        Adapter.Fill(ds);

                        LVreport.Items.Clear();

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                LVreport.Items.Add(ds.Tables[0].Rows[i]["ponum"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risno"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["itemnum"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risitem"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risunit"].ToString());

                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risqty"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["department"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["requestedby"].ToString());

                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["received"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["issued"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risdate"].ToString());

                            }

                            if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                            {
                                System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                            }

                            ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\transaction.xml");
                        }
                        logtotal();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    Adapter.Dispose();

                    connection.Close();
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {

                        Adapter = new MySqlDataAdapter("SELECT * FROM ris WHERE department = '" + cbdepreport.Text + "' && risdate BETWEEN '" + fromdate.Text + "' and '" + todate.Text + "'  ;", connection);
                        ds.Reset();
                        Adapter.Fill(ds);

                        LVreport.Items.Clear();

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                LVreport.Items.Add(ds.Tables[0].Rows[i]["ponum"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risno"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["itemnum"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risitem"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risunit"].ToString());

                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risqty"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["department"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["requestedby"].ToString());

                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["received"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["issued"].ToString());
                                LVreport.Items[LVreport.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risdate"].ToString());

                            }

                            if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                            {
                                System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                            }

                            ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\transaction.xml");
                        }
                        logtotal();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    Adapter.Dispose();

                    connection.Close();
                }
                
            }
            

             
        }

        
        double totalLog = 0;
        void logtotal()
        {
            double ColumnAvg = 0.00;

            for (int i = 0; i < LVreport.Items.Count; i++)
            {
                ColumnAvg += double.Parse(LVreport.Items[i].SubItems[5].Text);
            }

            totalLog = Convert.ToDouble(ColumnAvg.ToString());
        }


        private void btnprint_Click(object sender, EventArgs e)
        {
            if(cblogreq.Text == "Select" || cblogissued.Text == "Select" || cblogreceived.Text == "Select")
            {
                MessageBox.Show("Select the Requested by, Issued by and received by at the bottom. Thank you!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (totalLog == 0.00)
                {
                    MessageBox.Show("Fetch the record first", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    
                    Crystal_risLog prnt = new Crystal_risLog(cblogreq.Text, cblogissued.Text, cblogreceived.Text);

                    prnt.ShowDialog();
                }
            }           
            
        }

   
   
        void totalSales()
        {
            double ColumnAvg = 0.00;

            for (int i = 0; i < LVsales.Items.Count; i++)
            {
                ColumnAvg += double.Parse(LVsales.Items[i].SubItems[3].Text);
            }


            total_monthly.Text = ColumnAvg.ToString();
            
        }

        

        private void sprint_Click(object sender, EventArgs e)
        {
            if(total_monthly.Text == "0.00")
            {
                MessageBox.Show("Fetch the record first","INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                reportSalesPrint sales = new reportSalesPrint(total_monthly.Text);

                sales.ShowDialog();
            }

        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
             
                
                if(cb_category.Text== "IN PATIENT")
                {
                   // Adapter = new MySqlDataAdapter("SELECT product.prod_id ,prod_cat.item,  prod_cat.brand, prod_brand.unit, product.U_Cost, prod_brand.qty FROM product join prod_brand on prod_brand.brand_id = prod_id join prod_cat on prod_cat.cat_id = prod_id", connection);
                    Adapter = new MySqlDataAdapter("SELECT charge.invoice_no, sales_report.transactionNum, sales_report.totalqty, sales_report.total, sales_report.subtotal, sales_report.discpercent, sales_report.discount_amount ,sales_report.Date, sales_report.Time, sales_report.cashier FROM sales_report join charge on sales_report.transactionNum = charge.invoice_no  WHERE sales_report.Date BETWEEN '" + from.Text + "' and '" + to.Text + "' ;", connection);
                    ds.Reset();
                    Adapter.Fill(ds);

                    LVsales.Items.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            LVsales.Items.Add(ds.Tables[0].Rows[i]["transactionNum"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["totalqty"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["total"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["subtotal"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["discpercent"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["discount_amount"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["Date"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["Time"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["cashier"].ToString());

                        }

                        if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                        {
                            System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                        }
                        ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\sales.xml");
                    }
                    totalSales();

                    Double z;
                    Double.TryParse(total_monthly.Text, out z);
                    total_monthly.Text = z.ToString("0.00");
                    Adapter.Dispose();
                }
                else if(cb_category.Text == "OUT PATIENT")
                {
                    Adapter = new MySqlDataAdapter("SELECT * FROM sales_report WHERE Date BETWEEN '" + from.Text + "' and '" + to.Text + "' ;", connection);
                    ds.Reset();
                    Adapter.Fill(ds);

                    LVsales.Items.Clear();



                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            LVsales.Items.Add(ds.Tables[0].Rows[i]["transactionNum"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["totalqty"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["total"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["subtotal"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["discpercent"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["discount_amount"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["Date"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["Time"].ToString());
                            LVsales.Items[LVsales.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["cashier"].ToString());


                        }

                        if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                        {
                            System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                        }

                        ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\sales.xml");
                    }
                    totalSales();

                    Double z;
                    Double.TryParse(total_monthly.Text, out z);
                    total_monthly.Text = z.ToString("0.00");
                    Adapter.Dispose();
                }
                else
                {
                    MessageBox.Show("Choose your sales category in combobox","INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            

            connection.Close();
        }


        int totalrmed = 0;
        void rMed_total()
        {
            int ColumnAvg = 0;

            for (int i = 0; i < rlistview.Items.Count; i++)
            {
                ColumnAvg += int.Parse(rlistview.Items[i].SubItems[2].Text);
            }

            totalrmed = Convert.ToInt32(ColumnAvg.ToString());


        }

        private void btn_rprint_Click(object sender, EventArgs e)
        {
            if (totalrmed.Equals(0) )
            {
                MessageBox.Show("Fetch the record first", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                returnedMedReport rptMED = new returnedMedReport();

                rptMED.ShowDialog();
                
            }

        }

        private void btn_rfetch_Click(object sender, EventArgs e)
        {
            if (rto.Text == rfrom.Text)
            {
                MessageBox.Show("The from date and to date are the same, Pls, choose diff date from FROM","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    Adapter = new MySqlDataAdapter("SELECT * FROM medicinelogreturn WHERE DateReturn BETWEEN '" + rfrom.Text + "' and '" + rto.Text + "' ;", connection);
                    ds.Reset();
                    Adapter.Fill(ds);

                    rlistview.Items.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            rlistview.Items.Add(ds.Tables[0].Rows[i]["POnum"].ToString());
                            rlistview.Items[rlistview.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["Item"].ToString());
                            rlistview.Items[rlistview.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["qty"].ToString());
                            rlistview.Items[rlistview.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["Amount"].ToString());
                            rlistview.Items[rlistview.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["datePurchased"].ToString());
                            rlistview.Items[rlistview.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["DateReturn"].ToString());
                            rlistview.Items[rlistview.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["Incharge"].ToString());
                        }

                        if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                        {
                            System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                        }

                        ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\recordmed.xml");
                    }
                    rMed_total();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                Adapter.Dispose();
                connection.Close();
            }
            
        }

        //button for inventory medicine
        void clearcb()
        {
            cblogreq.Items.Clear();
            cblogissued.Items.Clear();
            cblogreceived.Items.Clear();

            nameFill();
        }

        void depfillclear()
        {
            cbdepreport.Items.Clear();
            depFill();
        }

        private void transact_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            preports.Visible = true;
            p_rsales.Visible = false;
            p_returned_med.Visible = false;

            depfillclear();
            clearcb();
        }

        private void rsales_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;
            
            p_returned_med.Visible = false;
            p_rsales.Visible = true;
        }


        private void rreturn_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;

            p_invmed.Visible = false;
        }

        private void rArStaff_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            p_unusedstocks.Visible = true;
            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;
            p_invmed.Visible = true;
            p_unusedstocks.Visible = true;
            p_expired.Visible = false;
           // p_medicine.Visible = false;
        }

        private void rexpired_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;
            p_invmed.Visible = true;
            p_unusedstocks.Visible = true;
         //   p_medicine.Visible = true;
            p_expired.Visible = true;
            panel_recap.Visible = false;
        }

        private void rinventory_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;
            p_invmed.Visible = true;
            p_unusedstocks.Visible = false;

            PMLV.Items.Clear();
            retrieveInventory();
            tbgetyear.Enabled = false;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;
            p_invmed.Visible = true;
            p_unusedstocks.Visible = true;
        //    p_medicine.Visible = true;
            p_expired.Visible = false;
        }

    
        private void btn_recap_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;
            p_invmed.Visible = true;
            p_unusedstocks.Visible = true;
            //   p_medicine.Visible = true;
            p_expired.Visible = true;
            panel_recap.Visible = true;
            panel_outstock.Visible = false;
        }

        private void btn_outofstock_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;
            p_invmed.Visible = true;
            p_unusedstocks.Visible = true;
            //   p_medicine.Visible = true;
            p_expired.Visible = true;
            panel_recap.Visible = true;
            panel_outstock.Visible = true;
            panel_pending_item.Visible = false;
        }

        private void btn_po_Click(object sender, EventArgs e)
        {
            slider1.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left;
            slider1.Width = ((Bunifu.Framework.UI.BunifuTileButton)sender).Width;

            preports.Visible = true;
            p_rsales.Visible = true;
            p_returned_med.Visible = true;
            p_invmed.Visible = true;
            p_unusedstocks.Visible = true;
            //   p_medicine.Visible = true;
            p_expired.Visible = true;
            panel_recap.Visible = true;
            panel_outstock.Visible = true;
            panel_pending_item.Visible = true;
        }

        private void tusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (tusername.Text == null)
            {
                tusername.Text = "blank";
                 
            }
            

            if (e.KeyCode == Keys.Enter)
            {
                tpassword.Focus();
                tpassword.Text = "";
            }
        }

        private void tpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (tpassword.Text == null)
            {
                tpassword.Text = "blank";

            }


            if (e.KeyCode == Keys.Enter)
            {
                tfn.Focus();
                tfn.Text = "";
            }
        }

        private void tfn_KeyDown(object sender, KeyEventArgs e)
        {
            if (tfn.Text == null)
            {
                tfn.Text = "blank";

            }


            if (e.KeyCode == Keys.Enter)
            {
                tmn.Focus();
                tmn.Text = "";
            }
        }

        private void tmn_KeyDown(object sender, KeyEventArgs e)
        {
            if (tmn.Text == null)
            {
                tmn.Text = "blank";

            }


            if (e.KeyCode == Keys.Enter)
            {
                tln.Focus();
                tln.Text = "";
            }
        }

        private void tln_KeyDown(object sender, KeyEventArgs e)
        {
            if (tln.Text == null)
            {
                tln.Text = "blank";

            }


            if (e.KeyCode == Keys.Enter)
            {
                ctitle.Focus();
                //ctitle.DropDownStyle();
            }
        }

        private void tusername_Enter(object sender, EventArgs e)
        {
             
            if (tusername.Text == "blank")
            {
                tusername.Text = "";
                 
            }
        }

        private void tusername_Leave(object sender, EventArgs e)
        {
            if (tusername.Text == "")
            {
                tusername.Text = "blank";
                
            }
        }

        private void tpassword_Enter(object sender, EventArgs e)
        {
            tpassword.isPassword = true;


            if (tpassword.Text == "blank")
            {
                tpassword.Text = "";
                 
            }
        }

        private void tpassword_Leave(object sender, EventArgs e)
        {
            if (tpassword.Text == "")
            {
                tpassword.isPassword = false;
                tpassword.Text = "blank";
                
            }
        }

        private void tfn_Enter(object sender, EventArgs e)
        {
            if (tfn.Text == "blank")
            {
                tfn.Text = "";
                 
            }
        }

        private void tfn_Leave(object sender, EventArgs e)
        {
            if (tfn.Text == "")
            {
                tfn.Text = "blank";
                
            }
        }

        private void tmn_Enter(object sender, EventArgs e)
        {
            if (tmn.Text == "blank")
            {
                tmn.Text = "";
                
            }
        }

        private void tmn_Leave(object sender, EventArgs e)
        {
            if (tmn.Text == "")
            {
                tmn.Text = "blank";
                 
            }
        }

        private void tln_Enter(object sender, EventArgs e)
        {
            if (tln.Text == "blank")
            {
                tln.Text = "";
                
            }
        }

        private void tln_Leave(object sender, EventArgs e)
        {
            if (tln.Text == "")
            {
                tln.Text = "blank";
                 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tpassword.isPassword = false;
            }
            else if (checkBox1.Checked == false)
            {
                tpassword.isPassword = true;
            }
        }

    
       

       

        private void UnitCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //text_reorder.Focus();
               //ComputeSales();
            }


        }


        string OrNum;
       

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            LVsales.Items.Clear();
            total_monthly.Text = "0.00";
        }

   


        

       

        void fillcombo()
        {
            Cmd = new MySqlCommand("SELECT DISTINCT po_id from inventory_logs ORDER BY inventory_num asc", connection);


            try
            {
                connection.Close();
                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("po_id");
                    cb_batchno.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        
        private void retrieveInventory()
        {
            try
            {
                Adapter = new MySqlDataAdapter("SELECT DISTINCT *, FORMAT(unit_price, 2) as price, FORMAT(total_amt, 2) as total From inventory_logs WHERE ending != 0 && status = 0;", connection);
                ds.Reset();
                Adapter.Fill(ds);

                PMLV.Items.Clear();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        PMLV.Items.Add(ds.Tables[0].Rows[i]["item_num"].ToString());
                        PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_name"].ToString());
                        PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_unit"].ToString());
                        PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["bqty"].ToString());
                        PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["oqty"].ToString());
                        PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                        PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i][string.Format("{0:#,##0.##}", "price")].ToString());
                        PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i][string.Format("{0:#,##0.##}", "total")].ToString());
                    }

                    if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                    {
                        System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                    }

                    ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\inventoryMED.xml");
                }

                Inventorymed_total();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }
       

        private void PMfetchbtn_Click_1(object sender, EventArgs e)
        {
            if (cb_batchno.Text == "----P.O. I.D.----")
            {
                MessageBox.Show("Choose the right P.O. I.D. you want to generate","STOP",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    // FROM product join prod_brand on prod_brand.brand_id = prod_id join prod_cat on prod_cat.cat_id = prod_id WHERE prod_cat.item LIKE '" + tb_search.Text + "' ";                                                                     
                    //Adapter = new MySqlDataAdapter("SELECT DISTINCT reports_po.item_num, reports_po.poitem, reports_po.pounit, reports_po.poqty, ending.poqty2, purchase_order.poqty1 FROM reports_po join ending on ending.po_id = reports_po.po_id join purchase_order on purchase_order.po_id = reports_po.po_id WHERE reports_po.po_id Like '" + cb_batchno.Text + "';", connection);
                    Adapter = new MySqlDataAdapter("SELECT DISTINCT * From inventory_logs WHERE po_id Like '" + cb_batchno.Text + "';", connection);
                    ds.Reset();
                    Adapter.Fill(ds);

                    PMLV.Items.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {                          

                            PMLV.Items.Add(ds.Tables[0].Rows[i]["item_num"].ToString());
                            PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_name"].ToString());
                            PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_unit"].ToString());
                            PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["bqty"].ToString());
                            PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["oqty"].ToString());
                            PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                            PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i][string.Format("{0:0.00}", "unit_price")].ToString());
                            PMLV.Items[PMLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i][string.Format("{0:0.00}", "total_amt")].ToString());
                        }

                        if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                        {
                            System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                        }

                        ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\inventoryMED.xml");
                    }
                    
                    Inventorymed_total();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                Adapter.Dispose();

                connection.Close();
            }
        }

        private void cb_batchno_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PMLV.Items.Clear();
            stock_IM = 0;
            //cb_batchno.Items.Clear();
            //fillcombo();
            //PMLV.Items.Clear();
            //retrieveInventory();
        }

        int stock_IM = 0;
        void Inventorymed_total()
        {
            int ColumnAvg = 0;

            for (int i = 0; i < PMLV.Items.Count; i++)
            {
                ColumnAvg += int.Parse(PMLV.Items[i].SubItems[3].Text);
            }

            stock_IM = Convert.ToInt32(ColumnAvg.ToString());
            
        }

        string mlid;
        string iname;
        string unitforlogs;
        int MLstock = 0;
        int outmedstock = 0;
        int lefmedstock = 0;
        int lefmedstock1 = 0;

        private void btn_PMprint_Click(object sender, EventArgs e)
        {
            if(stock_IM == 0)
            {
                MessageBox.Show("Fetch the report first, before print it","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                
                

                    Cursor.Current = Cursors.WaitCursor;
                    InventoryMedicinePrint rptMED = new InventoryMedicinePrint();

                    rptMED.ShowDialog();

                    cb_batchGL.Items.Clear();

                    fillcombo();
                    fillcomboToGL();
                    PMLV.Items.Clear();
                    cb_batchno.Items.Clear();


                    fillcombo();
            }
        }


        void fillcomboToGL()
        {
            Cmd = new MySqlCommand("SELECT DISTINCT batchNo from med_logs ORDER BY ItemID", connection);


            try
            {
                connection.Close();
                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("batchNo");
                    cb_batchGL.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void btn_fetchrecordGL_Click(object sender, EventArgs e)
        {
            if (cb_batchGL.Text == "----BATCH----")
            {
                MessageBox.Show("Choose the right batch you want to generate", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    // FROM product join prod_brand on prod_brand.brand_id = prod_id join prod_cat on prod_cat.cat_id = prod_id WHERE prod_cat.item LIKE '" + tb_search.Text + "' ";                                                                     
                    //Adapter = new MySqlDataAdapter("SELECT drug_logs.ItemID, drug_logs.ItemName, drug_logs.stockQty1, drug_consume.stockQty2, drug.stockQty FROM drug_logs join drug_consume on drug_consume.ItemID = drug_logs.ItemID join drug on drug.ItemID = drug_logs.ItemID WHERE drug_logs.batchNo Like '" + cb_batchno.Text + "';", connection);

                    //Adapter = new MySqlDataAdapter("SELECT * FROM medicinelogreturn WHERE DateReturn BETWEEN '" + rfrom.Text + "' and '" + rto.Text + "' ;", connection);
                    Adapter = new MySqlDataAdapter("SELECT * FROM med_logs WHERE batchNo="+ cb_batchGL.Text + " && dategenerated BETWEEN '" + GLfromdate.Text + "' and '" + GLtodate.Text + "' ;", connection);
                    ds.Reset();
                    Adapter.Fill(ds);

                    GLLV.Items.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            GLLV.Items.Add(ds.Tables[0].Rows[i]["ItemID"].ToString());
                            GLLV.Items[GLLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["stock"].ToString());
                            GLLV.Items[GLLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["outMed"].ToString());
                            GLLV.Items[GLLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                            GLLV.Items[GLLV.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["batchNo"].ToString());

                        }

                        //if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                        //{
                        //    System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                        //}

                        //ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\inventoryMED.xml");
                    }

                    //Inventorymed_total();
                    cb_batchGL.Items.Clear();
                    fillcomboToGL();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                Adapter.Dispose();

                connection.Close();
            }
        }

        private void cb_batchGL_SelectedIndexChanged(object sender, EventArgs e)
        {
            GLLV.Items.Clear();
        }


       /* void autoComplete1()
        {
            tb_medicinesearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb_medicinesearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection colll = new AutoCompleteStringCollection();

            try
            {                 
                Cmd = new MySqlCommand("SELECT * FROM drug", connection);
                connection.Close();
                connection.Open();

                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {

                    string item2 = Reader.GetString("ItemName");
                    colll.Add(item2);

                }

                connection.Close();

            }
            catch
            {

            }
            tb_medicinesearch.AutoCompleteCustomSource = colll;
        }*/

       /* private void getDrug(String id, String name, String unit, String ucost, String stock, String batchNO, String reqNo)
        {
            String[] row = { id, name,  unit, ucost, stock, batchNO, reqNo };

            ListViewItem item = new ListViewItem(row);

            LVmedicine.Items.Add(item);

        }*/

     /*   private void GenerateData()
        {
            //  string sql = "SELECT product.prod_id ,prod_cat.item,  prod_cat.brand, prod_brand.unit, product.U_Cost, prod_brand.qty FROM product join prod_brand on prod_brand.brand_id = prod_id join prod_cat on prod_cat.cat_id = prod_id";
            string sql = "SELECT  ItemID, ItemName, unit, price, stockQty, batchNo, reqNo FROM drug_product";
            //string sql = "SELECT ItemID, ItemName, brand, unit, TRUNCATE(price, 2) as price ,stockQty, bathNo FROM drug";
            Cmd = new MySqlCommand(sql, connection);

            try
            {
                connection.Close();
                connection.Open();
                Adapter = new MySqlDataAdapter(Cmd);
                Adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    getDrug(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                }
                connection.Close();

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }*/

       
        

       

        void fillcomboToEXP()
        {
            Cmd = new MySqlCommand("SELECT DISTINCT po_id from inventory_logs WHERE pocategory = 'Medicine'  ORDER BY inventory_num ASC", connection);


            try
            {
                connection.Close();
                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("po_id");
                    cb_expBatch.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        

        
        void fillcomboToEXPdate()
        {
            Cmd = new MySqlCommand("SELECT DISTINCT setmonthdateExp from inventory_logs where po_id ='" + cb_expBatch.Text+"' && pocategory ='Medicine' ", connection);


            try
            {
                connection.Close();
                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                                       
                    string sid = Reader.GetDateTime("setmonthdateExp").ToShortDateString();

                    string sourceDateText = sid;
                    DateTime sourceDate = DateTime.Parse(sourceDateText);
                    string formatted = sourceDate.ToString("yyyy-MM-dd");



                    cb_dateExp.Items.Add(formatted);

                    //select convert(varchar, getdate(), 111)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

       


        private void cb_expBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcomboToEXPdate();
            LVEXP.Items.Clear();
            cb_dateExp.Items.Clear();
            fillcomboToEXPdate();
            LVLogs.Items.Clear(); 
        }
        

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if(cb_expBatch.Text.Contains("----BATCH----") && cb_dateExp.Text.Contains("DATE") )
            {
                MessageBox.Show("choose batch and expired date","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (cb_dateExp.Text == "DATE")
                {
                    MessageBox.Show("choose batch and expired date", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        
                        Adapter = new MySqlDataAdapter("SELECT *, FORMAT(unit_price, 2) as price, FORMAT(total_amt, 2) as total  FROM inventory_logs WHERE po_id='" + cb_expBatch.Text + "' && setmonthdateExp ='" + cb_dateExp.Text + "' && pocategory = 'Medicine' ;", connection);
                        ds.Reset();
                        Adapter.Fill(ds);

                        LVEXP.Items.Clear();
                                               
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                               

                                LVEXP.Items.Add(ds.Tables[0].Rows[i]["inventory_num"].ToString());
                                LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["po_id"].ToString());
                                LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_name"].ToString());
                                LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_unit"].ToString());
                                LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["dateExp"].ToString());
                                LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i][string.Format("{0:#,##0.##}", "price")].ToString());
                                LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                                LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i][string.Format("{0:#,##0.##}", "total")].ToString());
                            }

                            expiredNow();
                        }

                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    Adapter.Dispose();

                    connection.Close();
                }
            }
        }


        void MessageBoxNotif()
        {
            connection.Close();
            connection.Open();
            Cmd = new MySqlCommand("SELECT * from inventory_logs where setmonthdateExp ='" + atime + "' ", connection);

            string sid;
            try
            {
                
                Reader = Cmd.ExecuteReader();
                
                while (Reader.Read())
                {

                    sid = Reader.GetString("item_name");
                    //cb_batchno.Items.Add(sid);
                    //MessageBox.Show("The medicine " + sid + " is expired!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                //notifyIcon1.Visible = true;
                //notifyIcon1.BalloonTipText = "There is an expired medicine";
                //notifyIcon1.ShowBalloonTip(1000);
                //notifyIcon1.BalloonTipTitle = "EXPIRED";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //EXPIRATION DAY
        string atime;
        //1212
        
    


        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

      

        private void tb_batchno_KeyDown(object sender, KeyEventArgs e)
        {
            connection.Close();
            if (e.KeyCode == Keys.Enter)
            {
               
               
            }
        }

        private void tb_qty_Enter(object sender, EventArgs e)
        {
            
        }

     
        

       


        string status1;

        private void ractive_CheckedChanged(object sender, EventArgs e)
        {
            string active = "active";
            status1 = active.ToString();
        }

        private void rdactive_CheckedChanged(object sender, EventArgs e)
        {
            string active = "not active";
            status1 = active.ToString();
        }

        

        int textID;
        int expiredBatchNo;
        string expname;
        string expdate;
        string expunit;
        double expPrice;
        int expstock;

        private void LVEXP_MouseClick(object sender, MouseEventArgs e)
        {
            //textID = Convert.ToInt32(LVEXP.SelectedItems[0].SubItems[0].Text);
            //expname = LVEXP.SelectedItems[0].SubItems[1].Text;
            //expiredBatchNo = Convert.ToInt32(LVEXP.SelectedItems[0].SubItems[2].Text);
            //expdate = LVEXP.SelectedItems[0].SubItems[3].Text;
            //expunit = LVEXP.SelectedItems[0].SubItems[4].Text;
            //expPrice = Convert.ToDouble(LVEXP.SelectedItems[0].SubItems[5].Text);
            //expstock = Convert.ToInt32(LVEXP.SelectedItems[0].SubItems[6].Text);

        }

        int exp = 0;
        void expiredNow()
        {
            int ColumnAvg = 0;

            for (int i = 0; i < LVEXP.Items.Count; i++)
            {
               // ColumnAvg += int.Parse(LVEXP.Items[i].SubItems[5].Text);
            }

            exp = Convert.ToInt32(ColumnAvg.ToString());

        }

        void moveTOexpired()
        {
            if (exp == 0)
            {
                MessageBox.Show("Choose the expired medicine", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sourceDateText = expdate;
                DateTime sourceDate = DateTime.Parse(sourceDateText);
                string formatted = sourceDate.ToString("yyyy-MM-dd hh-mm-ss");

                string insert1 = "INSERT INTO expired_meds(ItemID, ItemName, unit, stockQty, price, expDate, batchNo)"
                 + "VALUES('" + textID + "', '" + expname + "', '" + expunit + "', '" + expstock + "', '" + expPrice + "', '" + formatted + "', '" + expiredBatchNo + "');";

                    connection.Close();
                    connection.Open();

                    Cmd = new MySqlCommand(insert1, connection);

                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("data is save to expired med!", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            


                            try
                            {
                                Cmd = new MySqlCommand("DELETE  from drug_product where ItemID IN ('" + textID + "') && batchNo IN ('" + expiredBatchNo + "')", connection);
                                MySqlCommand Cmd1 = new MySqlCommand("DELETE  from drug where ItemID IN ('" + textID + "') && batchNo IN ('" + expiredBatchNo + "')", connection);
                                MySqlCommand Cmd2 = new MySqlCommand("DELETE  from drug_consume where ItemID IN ('" + textID + "') && batchNo IN ('" + expiredBatchNo + "')", connection);

                                connection.Close();
                                connection.Open();

                                Cmd.ExecuteNonQuery();
                                Cmd1.ExecuteNonQuery();
                                Cmd2.ExecuteNonQuery();

                                fillNotification();

                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                 MessageBox.Show(ex.Message);
                            }
                        connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("data is not Save!", "purchase outside", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                    
            }

            
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            moveTOexpired();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = true;
            this.Show();
        }

        private void getMedicine_Click(object sender, EventArgs e)
        {
            if (cb_expBatch.Text == "----BATCH----")
            {
                MessageBox.Show("Select the Batch no of medicine first.","STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    Adapter = new MySqlDataAdapter("SELECT * FROM inventory_logs WHERE po_id='" + cb_expBatch.Text + "';", connection);
                    ds.Reset();
                    Adapter.Fill(ds);

                    LVEXP.Items.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            

                            LVEXP.Items.Add(ds.Tables[0].Rows[i]["item_num"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_name"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["po_id"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["setmonthdateExp"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_unit"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                        }

                        expiredNow();
                        cb_expBatch.Items.Clear();
                        cb_dateExp.Items.Clear();

                        fillcomboToEXP();
                        fillcomboToEXPdate();

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                Adapter.Dispose();

                connection.Close();
            }
            
        }

       private void btn_expClose_Click(object sender, EventArgs e)
        {
            p_damageMed.SendToBack();
        }

        private void tb_expInputno_Enter(object sender, EventArgs e)
        {
            if (tb_expInputno.Text == "0")
            {
                tb_expInputno.Text = "";
               
            }
        }

        private void tb_expInputno_Leave(object sender, EventArgs e)
        {
            if (tb_expInputno.Text == "")
            {
                tb_expInputno.Text = "0";

            }
        }

        void moveTODamage()
        {
            if (exp == 0)
            {
                MessageBox.Show("Choose the expired medicine", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sourceDateText = expdate;
                DateTime sourceDate = DateTime.Parse(sourceDateText);
                string formatted = sourceDate.ToString("yyyy-MM-dd");

                string insert1 = "INSERT INTO expired_meds(ItemID, ItemName, unit, stockQty, price, expDate, batchNo)"
                 + "VALUES('" + textID + "', '" + expname + "', '" + expunit + "', '" + tb_expInputno.Text + "', '" + expPrice + "', '" + formatted + "', '" + expiredBatchNo + "');";

                connection.Close();
                connection.Open();

                Cmd = new MySqlCommand(insert1, connection);

                try
                {
                    if (Cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("data is save to expired med!", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        try
                        {
                            Cmd = new MySqlCommand("DELETE  from drug_product where ItemID IN ('" + textID + "') && batchNo IN ('" + expiredBatchNo + "')", connection);

                            connection.Close();
                            connection.Open();

                            Cmd.ExecuteNonQuery();

                            fillNotification();

                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("data is not Save!", "purchase outside", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();

            }


        }

        private void tb_expInputno_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void LVEXP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            p_damageMed.BringToFront();

            textID = Convert.ToInt32(LVEXP.SelectedItems[0].SubItems[0].Text);
            tb_itemnamedamage.Text = LVEXP.SelectedItems[0].SubItems[1].Text;
            expiredBatchNo = Convert.ToInt32(LVEXP.SelectedItems[0].SubItems[2].Text);
            expdate = LVEXP.SelectedItems[0].SubItems[3].Text;
            expunit = LVEXP.SelectedItems[0].SubItems[4].Text;
            expPrice = Convert.ToDouble(LVEXP.SelectedItems[0].SubItems[5].Text);
            tb_expQty.Text = LVEXP.SelectedItems[0].SubItems[6].Text;

        }

        private void btnSetdamaged_Click(object sender, EventArgs e)
        {
            if(tb_expInputno.Text == "0")
            {
                MessageBox.Show("Please input the qty of the damaged medicine","INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    connection.Close();

                    Cursor.Current = Cursors.WaitCursor;

                    string sql = "SELECT * FROM damaged_meds WHERE ItemID = " + textID + " && batchNo=" + cb_expBatch.Text + "  ";
                    Cmd = new MySqlCommand(sql, connection);

                    connection.Open();
                    //execute reader
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        int DamageStocks = Reader.GetInt32("stockQty");

                       // MessageBox.Show("Batch No is already taken, Please fill the next No.");

                        try
                        {
                            connection.Close();

                            int StockQty1 = Convert.ToInt32(tb_expQty.Text);
                            int StockQty2 = Convert.ToInt32(tb_expInputno.Text);

                            int resulStock = DamageStocks + StockQty2;

                            string sql1 = "UPDATE damaged_meds SET stockQty='" + resulStock + "'  WHERE ItemID=" + textID + " && batchNo=" + cb_expBatch.Text + " ";

                            int resulStock1 = StockQty1 - StockQty2;

                            string sql2 = "UPDATE drug_product SET stockQty='" + resulStock1 + "'  WHERE ItemID=" + textID + " && batchNo=" + cb_expBatch.Text + " ";

                            connection.Open();

                            Cmd = new MySqlCommand(sql1, connection);

                            MySqlCommand Cmd1 = new MySqlCommand(sql2, connection);


                            try
                            {
                                if (Cmd.ExecuteNonQuery() == 1 && Cmd1.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("The Stock of " + tb_itemnamedamage.Text + " is now " + resulStock1 + " is now updated", "SUCCESSFULLY UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LVEXP.Items.Clear();
                                    tb_expInputno.Text = "0";
                                    p_damageMed.SendToBack();
                                }
                                else
                                {
                                    MessageBox.Show("data is not updated");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }


                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        connection.Close();
                    }
                    else
                    {
                        //inserting a new damage medicine
                        string sourceDateText = expdate;
                        DateTime sourceDate = DateTime.Parse(sourceDateText);
                        string formatted = sourceDate.ToString("yyyy-MM-dd");


                        Cursor.Current = Cursors.WaitCursor;

                        //MessageBox.Show("there is no item");

                        string insert1 = "INSERT INTO damaged_meds(ItemID, ItemName, unit, stockQty, price, expDate, batchNo)"
                        + "VALUES('" + textID + "', '" + expname + "', '" + expunit + "', '" + tb_expInputno.Text + "', '" + expPrice + "', '" + formatted + "', '" + cb_expBatch.Text + "');";

                        connection.Close();
                        connection.Open();

                        Cmd = new MySqlCommand(insert1, connection);

                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("data is save to expired med!", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                try
                                {

                                    connection.Close();

                                    int StockQty1 = Convert.ToInt32(tb_expQty.Text);
                                    int StockQty2 = Convert.ToInt32(tb_expInputno.Text);

                                    int resulStock = StockQty1 - StockQty2;

                                    string sql1 = "UPDATE drug_product SET stockQty='" + resulStock + "'  WHERE ItemID=" + textID + " && batchNo=" + cb_expBatch.Text + " ";


                                    connection.Open();

                                    Cmd = new MySqlCommand(sql1, connection);
                                  

                                    try
                                    {
                                        if (Cmd.ExecuteNonQuery() == 1)
                                        {
                                            MessageBox.Show("The Stock of "+ tb_itemnamedamage.Text + " is now " + resulStock + " is now updated","SUCCESSFULLY UPDATE",MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            LVEXP.Items.Clear();
                                            tb_expInputno.Text = "0";
                                            p_damageMed.SendToBack();
                                        }
                                        else
                                        {
                                             MessageBox.Show("data is not updated");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }


                                    connection.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                connection.Close();
                            }
                            else
                            {
                                MessageBox.Show("data is not Save!", "purchase outside", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();

                    }

                }
                catch (Exception ex)
                {

                }
              }
        }

        private void btn_expiredLogs_Click(object sender, EventArgs e)
        {
            LVLogs.Items.Clear();
            batchbtn.Items.Clear();

                p_HistoryLogs.BringToFront();
                MedLOGS.Text = "Expired Medicine Logs";

            Expi();
        }

        private void btn_Closeme_Click(object sender, EventArgs e)
        {
            p_HistoryLogs.SendToBack();
        }

        private void btn_damageLogs_Click(object sender, EventArgs e)
        {
            LVLogs.Items.Clear();
            batchbtn.Items.Clear();

            p_HistoryLogs.BringToFront();
                MedLOGS.Text = "Damaged Medicine Logs";

            Damge();
        }

        private void btn_prnitExpDamaged_Click(object sender, EventArgs e)
        {
            

            if (MedLOGS.Text == "Expired Medicine Logs")
            {
                Cursor.Current = Cursors.WaitCursor;
                expiredLogs rptMED = new expiredLogs();

                rptMED.ShowDialog();
            }
            else if(MedLOGS.Text == "Damaged Medicine Logs")
            {
                Cursor.Current = Cursors.WaitCursor;
                damageLogs rptMED = new damageLogs();

                rptMED.ShowDialog();
            }
        }

        private void batchbtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            batchbtn.Items.Clear();


            if (MedLOGS.Text == "Expired Medicine Logs")
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    Adapter = new MySqlDataAdapter("SELECT * FROM inventory_logs WHERE batchNo='" + batchbtn.Text + "';", connection);
                    ds.Reset();
                    Adapter.Fill(ds);

                    LVLogs.Items.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            LVEXP.Items.Add(ds.Tables[0].Rows[i]["item_num"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_name"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["po_id"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["setmonthdateExp"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item_unit"].ToString());
                            LVEXP.Items[LVEXP.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                        }

                        if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                        {
                            System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                        }

                        ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\ExpiredLogs.xml");

                        expiredNow();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                Adapter.Dispose();

                connection.Close();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    Adapter = new MySqlDataAdapter("SELECT * FROM damaged_meds WHERE batchNo='" + batchbtn.Text + "';", connection);
                    ds.Reset();
                    Adapter.Fill(ds);

                    LVLogs.Items.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            LVLogs.Items.Add(ds.Tables[0].Rows[i]["ItemID"].ToString());
                            LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ItemName"].ToString());
                            LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["batchNo"].ToString());
                            LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["setmonthdateExp"].ToString());
                            LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["unit"].ToString());
                            LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["price"].ToString());
                            LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["stockQty"].ToString());
                        }


                        if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                        {
                            System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                        }

                        ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\DamagedLogs.xml");

                        expiredNow();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                Adapter.Dispose();

                connection.Close();
            }
        }


        void Expi()
        {

           
                Cmd = new MySqlCommand("SELECT DISTINCT po_id from inventory_logs ORDER BY item_name ASC", connection);


                try
                {
                    connection.Open();
                    Reader = Cmd.ExecuteReader();


                    while (Reader.Read())
                    {
                        string sid = Reader.GetString("batchNo");
                        batchbtn.Items.Add(sid);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            
        }

        void Damge()
        {

            Cmd = new MySqlCommand("SELECT DISTINCT po_id from inventory_logs ORDER BY item_name ASC", connection);


                try
                {
                    connection.Open();
                    Reader = Cmd.ExecuteReader();


                    while (Reader.Read())
                    {
                        string sid = Reader.GetString("batchNo");
                        batchbtn.Items.Add(sid);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            

        }

        private void tableLayoutPanel26_Paint(object sender, PaintEventArgs e)
        {

        }

     

       

        private void tbnewprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        

        private void btn_Charge_Click(object sender, EventArgs e)
        {
            chargeForm patient = new chargeForm();
            patient.ShowDialog();
        }

        

    
        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      
       
        private void untCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
                      
        }

        private void srp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');

        }

        private void text_reorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void batchNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

           
        }

        private void tb_req_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       



        void categorySettings()
        {
            Cmd = new MySqlCommand("SELECT * from item_category where id", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("category_name");


                    cbcat.Items.Add(sid);                   
                    //cbcategory.Items.Add(sid);
                    addproductcategory.Items.Add(sid);
                    cbitemcat.Items.Add(sid);
                    cbcategoryitem.Items.Add(sid);
                    cbitemcatup.Items.Add(sid);
                    cbcategorysearch.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        void unitCat()
        {
            Cmd = new MySqlCommand("SELECT * from supplier where id", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("sup_name");
                    // string sid1 = Reader.GetString("SuppAd");



                    //unit1.Items.Add(sid);
                    cb_set_supplier.Items.Add(sid);
                    tbsupplier.Items.Add(sid);
                    cbsupup.Items.Add(sid);
                    cb_suppliername.Items.Add(sid);
                    cbSupplier.Items.Add(sid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        void unitCategory()
        {
            Cmd = new MySqlCommand("SELECT * from unitcategory where ucatNum", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("ucatName");


                  //  cbunitcat.Items.Add(sid);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        void unitMeasure()
        {
            Cmd = new MySqlCommand("SELECT * from unit_measure where id", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("unit_name");

                    //unit2.Items.Add(sid);
                    cb_set_unit.Items.Add(sid);
                 //   cbunitmeasure.Items.Add(sid);
                    cbaddunitmeasure.Items.Add(sid);
                    comboBox3.Items.Add(sid);
                    tbumeasureupdate.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        void getitemunit()
        {
            Cmd = new MySqlCommand("SELECT * from item_unit where id", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("unit");

                    //unit2.Items.Add(sid);
                 //   cbpounit.Items.Add(sid);
                    //cbaddunitmeasure.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

     

        private void tb_batchno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_srp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        private void tb_reOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_untCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

      

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }



        private void cb_set_catUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
           // supnametxt.Text = cb_set_catUnit.Text;

            try
            {
                connection.Close();
                connection.Open();
                string sql = "SELECT *  FROM supplier WHERE sup_name LIKE  '" + cb_set_supplier.Text + "' ";
                Cmd = new MySqlCommand(sql, connection);
                //  connection.Open();
                Reader = Cmd.ExecuteReader();
               
              
                if (Reader.Read())
                {
                    supnametxt.Text = Reader.GetString("sup_name");
                    //supaddtxt.Text = Reader.GetString("SuppAd");

                }
                else
                {
                    MessageBox.Show("not found", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cb_set_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_setunit.Text = cb_set_unit.Text;
        }

       

        private void btn_sve2_Click(object sender, EventArgs e)
        {
            if (supnametxt.Text == "")
            {
                MessageBox.Show("Dont Leave the field Empty", "CATEGORY UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //lblred1.Visible = true;
               // tb_prod.BorderColorIdle = Color.Red;
                
            }
            else
            {
                if (MessageBox.Show("Are you sure, you want to Add " + supnametxt.Text + " as new Supplier?", "CATEGORY UNIT SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();
            //        string insert = "INSERT INTO log (username ,password)"
            //+ "VALUES('" + tun.Text + "', '" + tpw.Text + "');";

                    Cmd = new MySqlCommand("INSERT into supplier (sup_name)"
                                            + "values('" + supnametxt.Text + "')", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            cb_set_supplier.Items.Clear();
                            tbsupplier.Items.Clear();
                            cbsupup.Items.Clear();
                            cb_suppliername.Items.Clear();
                            cbSupplier.Items.Clear();
                            unitCat();
                            cb_set_supplier.Text = "Select Supplier";
                            tbsupplier.Text = "Select";
                            cbsupup.Text = "Select";
                            cb_suppliername.Text = "Select Supplier";
                            cbSupplier.Text = "Select Supplier";





                            MessageBox.Show("Adding " + supnametxt.Text + " as New Supplier is succesfully added", "CATEGORY UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            supnametxt.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else
                {

                }
            }
        }



        private void btn_update2_Click(object sender, EventArgs e)
        {
            if (supnametxt.Text == "")
            {
                MessageBox.Show("Input first the required field", "CATEGORY UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // lblalertprod.Visible = true;
                //tb_prod.BorderColorIdle = Color.Red;


            }
            else
            {
                if (MessageBox.Show("Are you sure, you want to Update " + cb_set_supplier.Text + " as " + supnametxt.Text + " Supplier Panel?", "CATEGORY UNIT SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();

                    Cmd = new MySqlCommand("Update supplier set sup_name = '" + supnametxt.Text + "' where sup_name = '" + cb_set_supplier.Text + "'", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            cb_set_supplier.Items.Clear();
                            cbsupup.Items.Clear();
                            tbsupplier.Items.Clear();
                            cb_suppliername.Items.Clear();
                            cbSupplier.Items.Clear();
                            unitCat();
                            cb_set_supplier.Text = "Select Supplier";
                            cbsupup.Text = "Select";
                            tbsupplier.Text = "Select";
                            cb_suppliername.Text = "Select Supplier";
                            cbSupplier.Text = "Select Supplier";


                          //  MessageBox.Show("Supplier" + tb_prod.Text + " is Successfuly Updated", "CATEGORY UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          // tb_prod.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else
                {

                }
            }
        }

        private void btn_sve3_Click(object sender, EventArgs e)
        {
            if (tb_setunit.Text == "")
            {
                MessageBox.Show("Input first the required field", "UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // lblcidalert.Visible = true;
                tb_setunit.BorderColorIdle = Color.Red;


            }
            else
            {
                if (MessageBox.Show("Are you sure, you want to Add " + tb_setunit.Text + " as new "+ cbunitSelector.Text + " ?", "UNIT SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (cbunitSelector.Text == "Unit Measure")
                    {
                        connection.Close();
                        connection.Open();

                        Cmd = new MySqlCommand("INSERT into unit_measure (unit_name)"
                                                + "values('" + tb_setunit.Text + "')", connection);
                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                cb_set_unit.Items.Clear();
                                cbaddunitmeasure.Items.Clear();
                                comboBox3.Items.Clear();
                                tbumeasureupdate.Items.Clear();
                                tbunitup.Items.Clear();
                                unitMeasure();
                                cb_set_unit.Text = "select unit";
                                tbumeasureupdate.Text = "SELECT";
                                tbunitup.Text = "SELECT";
                             //   cbunitmeasure.Items.Clear();
                             //  cbunitmeasure.Text = "Select";
                                cbunitSelector.Text = "Select";
                                comboBox3.Text = "Select";

                                MessageBox.Show("Unit Measure " + tb_setunit.Text + " is Successfuly Added", "UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tb_setunit.Text = "";
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();
                    }
                    else if (cbunitSelector.Text == "Unit Category")
                    {
                        connection.Close();
                        connection.Open();

                        Cmd = new MySqlCommand("INSERT into unit_category (category_name)"
                                                + "values('" + tb_setunit.Text + "')", connection);
                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                cb_set_unit.Items.Clear();
                                cbcategoryunit.Items.Clear();
                                comboBox4.Items.Clear();
                                cbcategoryitem.Items.Clear();
                                cbucatup.Items.Clear();
                                tbumeasureupdate.Items.Clear();
                                cbcategorysearch.Items.Clear();
                                unitMeasure();
                                cb_set_unit.Text = "select unit";
                                tbumeasureupdate.Text = "SELECT";
                                cbucatup.Text = "SELECT";
                                cbcategorysearch.Text = "Select filter category";
                           //     cbunitmeasure.Items.Clear();
                           //    cbunitmeasure.Text = "Select";
                                cbunitSelector.Text = "Select";
                                comboBox4.Text = "Select";
                                cbcategoryitem.Text = "Select filter category";

                                MessageBox.Show("Unit Category " + tb_setunit.Text + " is Successfuly Added", "UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tb_setunit.Text = "";
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();
                    }
                    else if(cbunitSelector.Text == "Unit")
                    {
                        connection.Close();
                        connection.Open();

                        Cmd = new MySqlCommand("INSERT into item_unit (unit)"
                                                + "values('" + tb_setunit.Text + "')", connection);
                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                cb_set_unit.Items.Clear();
                                cbaddunit.Items.Clear();
                                comboBox2.Items.Clear();
                                tbumeasureupdate.Items.Clear();
                                tbunitup.Items.Clear();
                                unitMeasure();
                                cb_set_unit.Text = "select unit";
                                tbumeasureupdate.Text = "SELECT";
                                tbunitup.Text = "SELECT";
                           //     cbunitmeasure.Items.Clear();
                           //     cbunitmeasure.Text = "Select";
                                cbunitSelector.Text = "Select";
                                comboBox2.Text = "Select";

                                MessageBox.Show("Unit " + tb_setunit.Text + " is Successfuly Added", "UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tb_setunit.Text = "";
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please select first the SELECT CATEGORY FOR EDIT.", "CATEGORY SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    
                }
                else
                {

                }
            }
        }

        private void btn_update3_Click(object sender, EventArgs e)
        {
            if (tb_setunit.Text == "")
            {
                MessageBox.Show("Input first the required field", "UNIT SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //lblalertprod.Visible = true;
                //tb_prod.BorderColorIdle = Color.Red;


            }
            else
            {
                if (MessageBox.Show("Are you sure, you want to Update " + cb_set_unit.Text + " as " + tb_setunit.Text + " Unit ", "UNIT MEASURE SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (cbunitSelector.Text == "Unit Measure")
                    {
                        connection.Close();
                        connection.Open();

                        Cmd = new MySqlCommand("Update unit_measure set unit_name = '" + tb_setunit.Text + "' where unit_name = '" + cb_set_unit.Text + "'", connection);
                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                cb_set_unit.Items.Clear();
                                cbaddunitmeasure.Items.Clear();
                                comboBox3.Items.Clear();
                                tbunitup.Items.Clear();
                                unitMeasure();
                                cb_set_unit.Text = "select category";
                                tbunitup.Text = "SELECT";
                            //    cbunitmeasure.Items.Clear();
                            //     cbunitmeasure.Text = "Select";
                                cbunitSelector.Text = "Select";
                                comboBox3.Text = "Select";

                                MessageBox.Show("Unit  " + tb_setunit.Text + " is Successfuly Updated", "UNIT  SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tb_setunit.Text = "";
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();
                    }
                    else if (cbunitSelector.Text == "Unit Category")
                    {
                        connection.Close();
                        connection.Open();

                        Cmd = new MySqlCommand("Update unit_category set category_name = '" + tb_setunit.Text + "' where category_name = '" + cb_set_unit.Text + "'", connection);
                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                cb_set_unit.Items.Clear();
                                cbcategoryunit.Items.Clear();
                                comboBox4.Items.Clear();
                                cbcategoryitem.Items.Clear();
                                cbucatup.Items.Clear();
                                cbcategorysearch.Items.Clear();
                                unitMeasure();
                                cbcategorysearch.Text = "Select filter category";
                                cb_set_unit.Text = "select category";
                                cbucatup.Text = "SELECT";
                             //   cbunitmeasure.Items.Clear();
                             ///   cbunitmeasure.Text = "Select";
                                cbunitSelector.Text = "Select";
                                comboBox4.Text = "Select";
                                cbcategoryitem.Text = "Select filter category";
                                MessageBox.Show("Unit  " + tb_setunit.Text + " is Successfuly Updated", "UNIT  SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tb_setunit.Text = "";
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();
                    }
                    else if(cbunitSelector.Text == "Unit")
                    {
                        connection.Close();
                        connection.Open();

                        Cmd = new MySqlCommand("Update item_unit set unit = '" + tb_setunit.Text + "' where unit = '" + cb_set_unit.Text + "'", connection);
                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                cb_set_unit.Items.Clear();
                                cbaddunit.Items.Clear();
                                comboBox2.Items.Clear();
                                tbunitup.Items.Clear();
                                unitMeasure();
                                cb_set_unit.Text = "select category";
                                tbunitup.Text = "SELECT";
                           //     cbunitmeasure.Items.Clear();
                           //     cbunitmeasure.Text = "Select";
                                cbunitSelector.Text = "Select";
                                comboBox2.Text = "Select";

                                MessageBox.Show("Unit  " + tb_setunit.Text + " is Successfuly Updated", "UNIT  SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tb_setunit.Text = "";
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please select first the SELECT CATEGORY FOR EDIT.", "CATEGORY SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    
                }
                else
                {

                }
            }
        }

     

      

       
       


       
         void getSuppier()
        {
            Cmd = new MySqlCommand("SELECT * from product where id", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("productname");


                    //unit1.Items.Add(sid);
                 //   cb_set_product.Items.Add(sid);
                  //  cbitem.Items.Add(sid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        void clearField()
        {

           // tb_poid.Text = "";
            tbqty.Text = "";           
            tbunitprice.Text = "";
            tbamount.Text = "";
            tbsupplier.Text = "SELECT";
            tb_poreorderedlvl.Text = "";


        }




        //void validatePO()
        //{
        //    //int ColumnAvg = 0;

        //    //for (int i = 0; i < LVPO.Items.Count; i++)
        //    //{
        //    //    ColumnAvg += int.Parse(LVPO.Items[i].SubItems[0].Text);
        //    //}

        //    checkiditem = ColumnAvg.ToString();

        //}

        string checkiditem;
        string getAllunit;
        private void btn_ADD_Click_1(object sender, EventArgs e)
        {
            if (existing == 1)
            {
                
                try
                {
                    string sql = "SELECT *  FROM purchase_order WHERE po_id LIKE  '" + tb_poid.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);

                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        //MessageBox.Show("The PO ID/PURCHASE ORDER ID is already taken", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (checkiditem == "getdata")
                        {
                            validatesave();
                        }
                        else
                        {
                            MessageBox.Show("Kindly Choose the item from the left table area. Thank you!", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The PO ID/PURCHASE ORDER ID is not exist, Please be sure that P.O. I.D. you input is correct", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                try
                {
                    string sql = "SELECT *  FROM purchase_order WHERE po_id LIKE  '" + tb_poid.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);

                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        MessageBox.Show("The PO ID/PURCHASE ORDER ID is already taken", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("not found", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (checkiditem == "getdata")
                        {
                            validatesave();
                        }
                        else
                        {
                            MessageBox.Show("Kindly Choose the item from the left table area. Thank you!", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

                        
        }

        void addtoPO()
        {
            if (existing == 1)
            {
                try
                {
                    string sql = "SELECT *  FROM purchase_order WHERE po_id LIKE  '" + tb_poid.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);
                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        //if the id is existed
                        add(itemidforpo, tbqty.Text, unitforpo, itemnameforpo, tbunitprice.Text, tbamount.Text, tbsupplier.Text, itemcategory, tb_poid.Text, tb_poreorderedlvl.Text, dt_before_expire.Text, dt_expired_date.Text);
                        poqty();

                        checkiditem = "";
                        getItemName.Text = "ITEM";
                        LVPOSEARCH.Items.Clear();
                        retrievePOSEARCH();
                    }
                    else
                    {
                        MessageBox.Show("The PO ID is not exist", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string sql = "SELECT *  FROM purchase_order WHERE po_id LIKE  '" + tb_poid.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);
                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        MessageBox.Show("The PO ID is already taken", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        //if the poid is not already taken the product will transfer to LVPO or listview
                        add(itemidforpo, tbqty.Text, unitforpo, itemnameforpo, tbunitprice.Text, tbamount.Text, tbsupplier.Text, itemcategory, tb_poid.Text, tb_poreorderedlvl.Text, dt_before_expire.Text, dt_expired_date.Text);
                        poqty();

                        checkiditem = "";
                        getItemName.Text = "ITEM";
                        LVPOSEARCH.Items.Clear();
                        retrievePOSEARCH();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void passtheexistmed()
        {
            if (existing == 1)
            {
                try
                {
                    string sql = "SELECT *  FROM purchase_order WHERE po_id LIKE  '" + tb_poid.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);
                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        //if the poid is existed then it will pass the data into LVPO
                        add(itemidforpo, tbqty.Text, unitforpo, itemnameforpo, tbunitprice.Text, tbamount.Text, tbsupplier.Text, itemcategory, tb_poid.Text, tb_poreorderedlvl.Text, dt_before_expire.Text, dt_expired_date.Text);
                        poqty();

                        checkiditem = "";
                        getItemName.Text = "ITEM";
                        LVPOSEARCH.Items.Clear();
                        retrievePOSEARCH();
                    }
                    else
                    {                        
                        //
                        MessageBox.Show("The PO ID is not exist", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string sql = "SELECT *  FROM purchase_order WHERE po_id LIKE  '" + tb_poid.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);
                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        MessageBox.Show("The PO ID is already taken", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        //if the poid is not already taken the product will transfer to LVPO or listview
                        add(itemidforpo, tbqty.Text, unitforpo, itemnameforpo, tbunitprice.Text, tbamount.Text, tbsupplier.Text, itemcategory, tb_poid.Text, tb_poreorderedlvl.Text, dt_before_expire.Text, dt_expired_date.Text);
                        poqty();

                        checkiditem = "";
                        getItemName.Text = "ITEM";
                        LVPOSEARCH.Items.Clear();
                        retrievePOSEARCH();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void validatesave()
        {          
            
            if (tb_poid.Text == "" || tbsupplier.Text == "SELECT" || tbunitprice.Text == "" || tbqty.Text == "" || tbamount.Text == "" || tbunitprice.Text == "0" || tbqty.Text == "0" || tbamount.Text == "0" || tbunitprice.Text == "0.00" || tbqty.Text == "0.00" || tbamount.Text == "0.00" || tbunitprice.Text == "0.0" || tbqty.Text == "0.0" || tbamount.Text == "0.0" || tb_poreorderedlvl.Text =="" )
            {
                MessageBox.Show("Please  input all require fields at left corner or you input the no. 0 in the qty, amount or unit price field.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //validation for 2 dates but this validation has a breach
                DateTime date = DateTime.Now;
                string MySQLFormatDate = date.ToString("yyyy-MM-dd");
                string timenow = MySQLFormatDate.ToString();

                if (itemcategory == "Medicine")
                {
                    if (dt_before_expire.Text == timenow)
                    {
                        MessageBox.Show("invalid month expired date");
                    }
                    else if (dt_before_expire.Text == dt_expired_date.Text)
                    {
                        MessageBox.Show("invalid month expired date21");

                    }
                    else if (timenow == dt_expired_date.Text)
                    {
                        MessageBox.Show("invalid date expired date");
                    }
                    else
                    {

                        passtheexistmed();
                        
                    }
                }
                else
                {
                    //no need expired date
                    addtoPO();
                    
                }
                

                

            }
        }

      

        private void add(String itemid, String qty, String unitpo, String iname, String unitprice, String amount, String posup, String category, String id, String poreordered, String monthexp, String podatexp)
        {
            String[] row = { itemid, qty, unitpo, iname, unitprice, amount, posup, category, id, poreordered, monthexp, podatexp };
            ListViewItem item = new ListViewItem(row);

            LVPO.FullRowSelect = true;


            //ListViewItem item = new ListViewItem(OnMouseHover);
            LVPO.Items.Add(item);

            clearField();

        }

        private void tbqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbunitprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        private void tbamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        
        //this is for po save item

        string iid;
        int po_qty = 0;
        string pounit;
        string poitem;
        double pounitprice;
        double poamount;
        string posupplier;
        string pocategory;
        string reorderdlvl;
        string mob4;
        string dateexp;
        string savepo;

        private void btnposave_Click(object sender, EventArgs e)
        {
            if(savepo == "saved")
            {
                MessageBox.Show("Transaction is already saved! Please click SEARCH ITEM for new transactions.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Are you sure? REMINDER: SET THE DATE AT THE RIGHT SIDE AREA OF THIS SCREEN BEFORE YOU SAVE IT! THANK YOU!", "PURCHASE ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (cbreqbypo.Text == cbapprovedpo.Text)
                    {                       

                        if (MessageBox.Show("The Requested by and Approved by is not allowed of having the same values, This Transaction will not be Save! Thank you", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        {
                            cbapprovedpo.Text = "Select";
                            
                        }
                    }
                    else
                    {
                        if (cbreqbypo.Text == "Select" || cbapprovedpo.Text == "Select")
                        {
                            MessageBox.Show("Select the Personnel in Requested by and Approved by.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            if (qtyforpo == 0)
                            {
                                MessageBox.Show("Add data first, before you save it.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {

                                Cursor.Current = Cursors.WaitCursor;

                                //save the transaction line
                                for (int i = 0; i < LVPO.Items.Count; i++)
                                {
                                    // ConsumeItem();


                                    iid = LVPO.Items[i].SubItems[0].Text;//ok
                                    po_qty = Convert.ToInt32(LVPO.Items[i].SubItems[1].Text);//ok
                                    pounit = LVPO.Items[i].SubItems[2].Text;
                                    poitem = LVPO.Items[i].SubItems[3].Text;
                                    pounitprice = Convert.ToDouble(LVPO.Items[i].SubItems[4].Text);
                                    poamount = Convert.ToDouble(LVPO.Items[i].SubItems[5].Text);
                                    posupplier = LVPO.Items[i].SubItems[6].Text;
                                    pocategory = LVPO.Items[i].SubItems[7].Text;
                                    reorderdlvl = LVPO.Items[i].SubItems[9].Text;
                                    mob4 = LVPO.Items[i].SubItems[10].Text;
                                    dateexp = LVPO.Items[i].SubItems[11].Text;


                                    connection.Close();
                                    connection.Open();

                                    Cmd = new MySqlCommand("INSERT into purchase_order (item_num, poqty1, pounit, poitem, pounitprice, poamount, Date, posupplier, pocategory, po_id, po_reorderedlvl, before_expire, edate_expire)"
                                        + "values('" + iid + "','" + po_qty + "','" + pounit + "','" + poitem + "','" + pounitprice + "','" + poamount + "', '" + dtpodate.Text + "', '" + posupplier + "', '" + pocategory + "' ,'" + tb_poid.Text + "','" + reorderdlvl + "' ,'" + mob4 + "' ,'" + dateexp + "' )", connection); //, '" + sdisc + "', '" + atime.Text + "', '" + sdiscp + "', '" + totaldb + "', '" + stotaldb + "' 

                                    MySqlCommand Cmd1 = new MySqlCommand("INSERT into reports_po (item_num, poqty, pounit, poitem, pounitprice, poamount, Date, posupplier, pocategory, po_id, po_reorderedlvl, before_expire, edate_expire)"
                                       + "values('" + iid + "','" + po_qty + "','" + pounit + "','" + poitem + "','" + pounitprice + "','" + poamount + "', '" + dtpodate.Text + "', '" + posupplier + "', '" + pocategory + "' ,'" + tb_poid.Text + "','" + reorderdlvl + "' ,'" + mob4 + "' ,'" + dateexp + "' )", connection); //, '" + sdisc + "', '" + atime.Text + "', '" + sdiscp + "', '" + totaldb + "', '" + stotaldb + "' 

                                    MySqlCommand Cmd2 = new MySqlCommand("INSERT into ending (item_num1, poqty2, pounit, poitem, pounitprice, poamount, Date, posupplier, pocategory, po_id)"
                                       + "values('" + iid + "','" + 0 + "','" + pounit + "','" + poitem + "','" + pounitprice + "','" + poamount + "', '" + dtpodate.Text + "', '" + posupplier + "', '" + pocategory + "' ,'" + tb_poid.Text + "')", connection); //, '" + sdisc + "', '" + atime.Text + "', '" + sdiscp + "', '" + totaldb + "', '" + stotaldb + "' 

                                    MySqlCommand Cmd3 = new MySqlCommand("INSERT into po_history (item_num, poqty, pounit, poitem, pounitprice, poamount, Date, posupplier, pocategory, po_id, po_reorderedlvl, before_expire, edate_expire, reqby, approvedby)"
                                       + "values('" + iid + "','" + po_qty + "','" + pounit + "','" + poitem + "','" + pounitprice + "','" + poamount + "', '" + dtpodate.Text + "', '" + posupplier + "', '" + pocategory + "' ,'" + tb_poid.Text + "','" + reorderdlvl + "' ,'" + mob4 + "' ,'" + dateexp + "', '" + cbreqbypo.Text + "', '" + cbapprovedpo.Text + "' )", connection); //, '" + sdisc + "', '" + atime.Text + "', '" + sdiscp + "', '" + totaldb + "', '" + stotaldb + "' 

                                    MySqlCommand Cmd4 = new MySqlCommand("INSERT into purchase_order_logs (item_num, poqty1, pounit, poitem, pounitprice, poamount, Date, posupplier, pocategory, po_id, po_reorderedlvl, before_expire, edate_expire)"
                                                                                            + "values('" + iid + "','" + po_qty + "','" + pounit + "','" + poitem + "','" + pounitprice + "','" + poamount + "', '" + dtpodate.Text + "', '" + posupplier + "', '" + pocategory + "' ,'" + tb_poid.Text + "','" + reorderdlvl + "' ,'" + mob4 + "' ,'" + dateexp + "' )", connection); //, '" + sdisc + "', '" + atime.Text + "', '" + sdiscp + "', '" + totaldb + "', '" + stotaldb + "' 

                                    MySqlCommand Cmd5 = new MySqlCommand("INSERT into inventory_logs (item_num, po_id, item_name, item_unit, unit_price, total_amt, bqty, oqty, ending, reorder_lvl, setmonthdateExp, dateExp, supplier_name, pocategory)"
                                                                                   + "values('" + iid + "','" + tb_poid.Text + "','" + poitem + "','" + pounit + "','" + pounitprice + "','" + poamount + "','" + po_qty + "', '0', " + po_qty + ", '" + reorderdlvl + "' ,'" + mob4 + "' ,'" + dateexp + "' ,'" + posupplier + "', '" + pocategory + "' )", connection); //, '" + sdisc + "', '" + atime.Text + "', '" + sdiscp + "', '" + totaldb + "', '" + stotaldb + "' 

                                    try
                                    {
                                        if (Cmd.ExecuteNonQuery() == 1 && Cmd1.ExecuteNonQuery() == 1 && Cmd2.ExecuteNonQuery() == 1 && Cmd3.ExecuteNonQuery() == 1 && Cmd4.ExecuteNonQuery() == 1 && Cmd5.ExecuteNonQuery() == 1)
                                        {
                                            savepo = "saved";
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }


                                    connection.Close();
                                }
                                MessageBox.Show("data is Saved", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                connection.Close();
                                LVPO.Items.Clear();

                                


                                cb_batchno.Items.Clear();
                                fillcombo();

                                ////for print

                                Cursor.Current = Cursors.WaitCursor;
                                try
                                {
                                    DataSet ds1 = new DataSet();
                                    //this query will show to listview
                                    MySqlDataAdapter Adapter1 = new MySqlDataAdapter("SELECT * FROM po_history WHERE po_id='" + tb_poid.Text + "';", connection);
                                    ds1.Reset();
                                    Adapter1.Fill(ds1);

                                    LVPO.Items.Clear();

                                    if (ds1.Tables[0].Rows.Count > 0)
                                    {
                                        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                                        {
                                            LVPO.Items.Add(ds1.Tables[0].Rows[i]["item_num"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["poqty"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["pounit"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["poitem"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["pounitprice"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["poamount"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["posupplier"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["pocategory"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["po_id"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["po_reorderedlvl"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["before_expire"].ToString());
                                            LVPO.Items[LVPO.Items.Count - 1].SubItems.Add(ds1.Tables[0].Rows[i]["edate_expire"].ToString());
                                        }

                                        if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                                        {
                                            System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                                        }

                                        ds1.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\POprint.xml");

                                        //expiredNow();
                                    }


                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }

                                Adapter.Dispose();
                                connection.Close();
                                // PressRefresh();
                                LVSearch.Items.Clear();
                                retrieve();
                                tbsearch4item();
                                // LVSearch.Items.Clear();
                                // retrieve();
                                // getbatchno();*/
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Transaction not save! All transactions need to be save", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void btnpodelete_Click(object sender, EventArgs e)
        {
            if (savepo == "saved")
            {
                MessageBox.Show("Sorry The Data from the Table is already saved. This is not available for edit/update/Delete. Kindly click Search Item for New Purchase Order", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Are you sure, Do you really want to delete the selected item?", "PURCHASE ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  for (int i = 0; i < LVPO.Items.Count; i++)
                    // {
                    if (qtyforpo == 0)
                    {
                        MessageBox.Show("There is no data in the table.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (selectPOitemrow == "")
                        {
                            MessageBox.Show("You have to select item from table", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            LVPO.Items[0].Remove();
                            MessageBox.Show("Item is now deleted.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    //   i--;
                    //}
                }
                else
                {
                    MessageBox.Show("Item is not deleted.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            
        }

        private void LVPO_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ppoedit.BringToFront();
          // btn_ADD.SendToBack();
           // btnpoupdate.Visible = true;

            selectPOitemrow = LVPO.SelectedItems[0].SubItems[3].Text;

            tbpoidupdate.Text = LVPO.SelectedItems[0].SubItems[8].Text;
            tbitemidupate.Text = LVPO.SelectedItems[0].SubItems[0].Text;
            tbitemnameupdate.Text = LVPO.SelectedItems[0].SubItems[3].Text;
            nmqtyupdate.Text = LVPO.SelectedItems[0].SubItems[1].Text;
            tbupriceupdate.Text = LVPO.SelectedItems[0].SubItems[4].Text;
            tbamountup.Text = LVPO.SelectedItems[0].SubItems[5].Text;
            tbreorderup.Text = LVPO.SelectedItems[0].SubItems[9].Text;
            cbitemcatup.Text = LVPO.SelectedItems[0].SubItems[7].Text;
            dtmob4expire.Text = LVPO.SelectedItems[0].SubItems[10].Text;
            dtexpired.Text = LVPO.SelectedItems[0].SubItems[11].Text;
            cbsupup.Text = LVPO.SelectedItems[0].SubItems[6].Text;


            hidemeEdit();
        }

        void hidemeEdit()
        {
            if(cbitemcatup.Text == "Medicine")
            {
                hideMeEditPanel.Hide();
            }            
            else
            {
                hideMeEditPanel.Show();
            }

        }

        private void updatePOitem()
        {


            LVPO.SelectedItems[0].SubItems[0].Text = tbitemidupate.Text;
            LVPO.SelectedItems[0].SubItems[1].Text = nmqtyupdate.Text;
            LVPO.SelectedItems[0].SubItems[2].Text = getAllUnit;
            // LVPO.SelectedItems[0].SubItems[2].Text = getAllunit;
            LVPO.SelectedItems[0].SubItems[4].Text = tbitemnameupdate.Text;
            LVPO.SelectedItems[0].SubItems[4].Text = tbupriceupdate.Text;
            LVPO.SelectedItems[0].SubItems[5].Text = tbamountup.Text;
            LVPO.SelectedItems[0].SubItems[6].Text = cbsupup.Text;
            LVPO.SelectedItems[0].SubItems[7].Text = cbitemcatup.Text;
            LVPO.SelectedItems[0].SubItems[8].Text = tbpoidupdate.Text;
            LVPO.SelectedItems[0].SubItems[9].Text = tbreorderup.Text;
            LVPO.SelectedItems[0].SubItems[10].Text = dtmob4expire.Text;
            LVPO.SelectedItems[0].SubItems[11].Text = dtexpired.Text;

            clearField();

           // btnpoupdate.Visible = false;
        }

        private void btnpoupdate_Click(object sender, EventArgs e)
        {
            if (qtyforpo == 0)
            {
                MessageBox.Show("There is no data in the table.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (savepo == "saved")
                {
                    MessageBox.Show("Sorry The Data from the Table is already saved. This is not available for edit/update/Delete. Kindly click Search Item for New Purchase Order", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    ppoedit.BringToFront();
                    hidemeEdit();
                }
            }
        }

        private void btnsave4_Click(object sender, EventArgs e)
        {
            if (tbcat.Text == "")
            {
                MessageBox.Show("Input first the required field", "PRODUCT CATEGORY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // lblalertprod.Visible = true;
               // tb_prod.BorderColorIdle = Color.Red;


            }
            else
            {
                if (MessageBox.Show("Are you sure to Add " + tbcat.Text + " as new Category?", "PRODUCT CATEGORY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();

                    Cmd = new MySqlCommand("INSERT into item_category (category_name)"
                                            + "values('" + tbcat.Text + "')", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            cbcat.Items.Clear();
                          
                            addproductcategory.Items.Clear();
                            cbitemcat.Items.Clear();
                            cbitemcatup.Items.Clear();
                            cbcategorysearch.Items.Clear();
                            cbcategoryitem.Items.Clear();

                            categorySettings();
                            cbcat.Text = "Select Category";
                            cbitemcatup.Text = "Select Category";


                            addproductcategory.Text = "Select Item Category";
                            cbitemcat.Text = "Select Item Category";
                            cbcategorysearch.Text = "Select filter category";
                            cbcategoryitem.Text = "Select filter category";

                            MessageBox.Show("Category " + tbcat.Text + " is Successfuly Added", "PRODUCT CATEGORY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbcat.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else
                {

                }
            }
        }

        private void btnupdate4_Click(object sender, EventArgs e)
        {
            if (tbcat.Text == "")
            {
                MessageBox.Show("Input first the required field", "PRODUCT CATEGORY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             //   lblalertprod.Visible = true;
             //   tb_prod.BorderColorIdle = Color.Red;

            
            }
            else
            {
                if (MessageBox.Show("Are you sure, you want to Edit " + cbcat.Text + " as " + tbcat.Text + " Category?", "CATEGORY SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();

                    Cmd = new MySqlCommand("Update item_category set category_name = '" + tbcat.Text + "' where category_name = '" + cbcat.Text + "'", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            cbcat.Items.Clear();
                           
                            addproductcategory.Items.Clear();
                            cbitemcat.Items.Clear();
                            cbitemcatup.Items.Clear();
                            categorySettings();
                            
                            cbcat.Text = "Select Category";
                            cbitemcatup.Text = "Select Category";
                            addproductcategory.Text = "Select Item Category";
                            cbitemcat.Text = "Select Item Category";

                            MessageBox.Show("Category " + tbcat.Text + " is now save", "PRODUCT CATEGORY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbcat.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else
                {

                }
            }
        }

        private void cbcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbcat.Text = cbcat.Text;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
            if (confirmsave == "save")
            {
                if(MessageBox.Show(" NOTE: You have to print first the current transaction! Do you want another Transaction? Thank you!", "REQUISITION AND ISSUE SLIP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LVRIS.Items.Clear();

                    panelsearch.BringToFront();
                    panelsearch.Visible = true;

                    savetheris = "";
                    confirmsave = "";

                    LVSearch.Items.Clear();
                    retrieve();
                    // tbsearch4item();
                    // cbcatsearch();

                    cbrequest.Text = "Select";
                    cbdept.Text = "Select";
                    cbreceived.Text = "Select";
                    cbissued.Text = "Select";

                    tbRisID.Enabled = true;
                }
               
            }
            else
            {
                try
                {
                    string sql = "SELECT *  FROM ris WHERE risno LIKE  '" + tbRisID.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);

                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        MessageBox.Show("The R.I.S I.D is already taken", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("not found", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panelsearch.BringToFront();
                        panelsearch.Visible = true;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btncloseme_Click(object sender, EventArgs e)
        {
            panelsearch.SendToBack();
        }

        //magkasama start
        private void retrieve()
        {
          // Cmd = new MySqlCommand("SELECT po_id, item_num, pocategory, poitem, pounit, poqty1, Date FROM purchase_order WHERE poqty1 !=0 ORDER BY poitem ASC", connection);

           Cmd = new MySqlCommand("SELECT po_id, id, category, item_name, unit, ending_qty, created_at FROM po_section WHERE ending_qty !=0 && status = 0 ORDER BY item_name ASC", connection);

            try
            {
                connection.Close();
                connection.Open();
                Adapter = new MySqlDataAdapter(Cmd);
                Adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateLV(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                }
                connection.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void populateLV(String id, String poid, String cat, String poitem, String unit,  String poqty, String podate)
        {
            String[] row = { id, poid, cat, poitem, unit,  poqty, podate };
            ListViewItem item = new ListViewItem(row);
            LVSearch.Items.Add(item);
        }

    


        string poidsearch;
        string idris;
        string unitris;
        string poitemris;
        string poqtyris;

        private void LVSearch_MouseClick(object sender, MouseEventArgs e)
        {
            poidsearch = LVSearch.SelectedItems[0].SubItems[0].Text;
            idris = LVSearch.SelectedItems[0].SubItems[1].Text;
            tbselecteditem.Text = LVSearch.SelectedItems[0].SubItems[3].Text;
            poitemris = LVSearch.SelectedItems[0].SubItems[3].Text;
            unitris = LVSearch.SelectedItems[0].SubItems[4].Text;
            poqtyris = LVSearch.SelectedItems[0].SubItems[5].Text;



            qtysearch.Value = 0;
            //notify_reorder_lvl();
            reOrdered_level();
        }

        //reordered lvl notif
        string sampleID;
        int rstock = 0;
        int reordered_num = 0;
        
        void reOrdered_level()
        {

            string sql = "SELECT * FROM inventory_logs WHERE item_num ='" + idris + "' && po_id = '"+ poidsearch + "' ";
            Cmd = new MySqlCommand(sql, connection);

            connection.Close();
            connection.Open();
            //execute reader
            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                reordered_num = Reader.GetInt32("reorder_lvl");
                rstock = Reader.GetInt32("ending");
                string item_name = Reader.GetString("item_name");
                //MessageBox.Show("The po_id is selected", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // samplestock.Text = Convert.ToString(rstock);

                //condition for reOrdered vs. stock
                if (reordered_num < rstock)
                {
                    MessageBox.Show("your stock is Good", "INFORMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Your stock "+ item_name + " has " + rstock + " pc(s) and it's running out!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }
            else
            {

                MessageBox.Show("NO DATA FILL");
            }
            Reader.Close();

            connection.Close();
        }


        void notify_reorder_lvl()
        {
            //poidsearch
            //if (poqtyris<)

            try
            {
                string sql = "SELECT *  FROM inventory_logs WHERE item_num LIKE  '" + idris + "' ";
                Cmd = new MySqlCommand(sql, connection);

                connection.Close();
                connection.Open();
                Reader = Cmd.ExecuteReader();

                if (Reader.Read())
                {
                    MessageBox.Show("The po_id is selected", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("po id not found", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //panelsearch.BringToFront();
                    //panelsearch.Visible = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        //end


        private void add(String poid, String itemid, String qty, String unit, String description, String endingbalance)
        {
            String[] row = { poid, itemid, qty, unit, description, endingbalance };
            ListViewItem item = new ListViewItem(row);                    
            LVRIS.Items.Add(item);
        }

        private void btnaddsearch_Click(object sender, EventArgs e)
        {
           
            if(tbselecteditem.Text == "ITEM")
            {
                MessageBox.Show("Please Choose item from the Table.", "SEARCH BOX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (qtysearch.Value == 0)
                {
                    MessageBox.Show("Please, input the desire qty first", "SEARCH BOX");
                }
                else
                {
                   
                    int totalqty = Convert.ToInt32(poqtyris) - Convert.ToInt32(qtysearch.Text);

                    LVSearch.SelectedItems[0].SubItems[5].Text = totalqty.ToString();

                    if (totalqty < 0)
                    {
                        MessageBox.Show("The input qty has exceeded from available qty, Please check the available qty. Thank you!", "SEARCH BOX");

                        int backqty = int.Parse(qtysearch.Text) + totalqty;
                        LVSearch.SelectedItems[0].SubItems[5].Text = backqty.ToString();
                        tbselecteditem.Text = "ITEM";
                    }
                    else
                    {
                        add(poidsearch, idris, qtysearch.Text, unitris, poitemris, totalqty.ToString());
                        tbselecteditem.Text = "ITEM";
                        tbsearchitem.Text = "";

                        qtysearch.Text = "0";
                    }

                }
            }

            
            
        }
       // 1212
        

        void validate_delete()
        {
            if (selecteditemtb.Text == "")
            {
                MessageBox.Show("Please select row from the table before press delete.", "R.I.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LVRIS.Items[0].Remove();
                MessageBox.Show("Item is now deleted.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndeleteris_Click(object sender, EventArgs e)
        {
            if(confirmsave == "save")
            {
                MessageBox.Show("Sorry you can not delete any data because it is already saved. Kindly click search and choose Yes for another transaction and it will delete all data from table. Thank you.", "R.I.S", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (MessageBox.Show("Are you sure, Do you really want to delete the selected item?", "PURCHASE ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // for (int i = 0; i < LVRIS.Items.Count; i++)
                    //{
                    validate_delete();
                    //  i--;
                    //}
                }
                else
                {
                    MessageBox.Show("Item is not deleted.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btneditris_Click(object sender, EventArgs e)
        {
            if(confirmsave == "save")
            {
                MessageBox.Show("The Data is unavailable for edit because it is already saved. Kindly click search and choose Yes for another transaction. Thank you.", "R.I.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (selecteditemtb.Text == "")
                {
                    MessageBox.Show("Please select row from the table before press edit.", "R.I.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    panelEdit.BringToFront();
                }
            }
            
            
        }

        private void tbsearch4item()
        {
            try
            {

                // MySqlCommand command = new MySqlCommand();
                connection.Open();

                Cmd = new MySqlCommand();

                Cmd.Connection = connection;


                Cmd.CommandText = "SELECT * FROM inventory_logs WHERE item_name LIKE '%" + tbsearchitem.Text + "%' && ending !=0 && status =0 ORDER BY item_name ASC";

                Adapter = new MySqlDataAdapter();

                Adapter.SelectCommand = Cmd;

                dt = new DataTable();
                Adapter.Fill(dt);

                LVSearch.Items.Clear();
                foreach (DataRow r in dt.Rows)
                {

                    ListViewItem list = LVSearch.Items.Add(r["po_id"].ToString());
                    list.SubItems.Add(r["item_num"].ToString());
                    list.SubItems.Add(r["pocategory"].ToString());
                    list.SubItems.Add(r["item_name"].ToString());
                    list.SubItems.Add(r["item_unit"].ToString());
                    list.SubItems.Add(r["ending"].ToString());
                    list.SubItems.Add(r["date"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }

        private void tbsearchitem_TextChanged(object sender, EventArgs e)
        {
            tbsearch4item();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            panelEdit.SendToBack();
        }

        int finaltotal;

        private void btnupdatetbris_Click(object sender, EventArgs e)
        {
            int totalqtyris;
            
            if(btnrequiredqty.Value == 0)
            {
                MessageBox.Show("The required qty are not allowed because you input 0(ZERO) number, Please input greater than (0)Zero. Thank you", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (currentqty.Value > btnrequiredqty.Value)
                {
                    totalqtyris = Convert.ToInt32(currentqty.Value) - Convert.ToInt32(btnrequiredqty.Value);
                    LVRIS.SelectedItems[0].SubItems[2].Text = totalqtyris.ToString();

                    finaltotal = risending + totalqtyris;
                    LVRIS.SelectedItems[0].SubItems[5].Text = finaltotal.ToString();
                    LVSearch.SelectedItems[0].SubItems[4].Text = finaltotal.ToString();
                    selecteditemtb.Text = "";
                }
                else if (currentqty.Value < btnrequiredqty.Value)
                {
                    totalqtyris = Convert.ToInt32(btnrequiredqty.Value) - Convert.ToInt32(currentqty.Value);
                    LVRIS.SelectedItems[0].SubItems[2].Text = btnrequiredqty.Text;

                    finaltotal = risending - totalqtyris;
                    LVRIS.SelectedItems[0].SubItems[5].Text = finaltotal.ToString();
                    LVSearch.SelectedItems[0].SubItems[4].Text = finaltotal.ToString();
                    selecteditemtb.Text = "";
                }
                //after update
                panelEdit.SendToBack();
            }
            
        }

        string rispono;
        string risno;
        int risqtyupdate;
        int risending;
        private void LVRIS_MouseClick(object sender, MouseEventArgs e)
        {
            rispono = LVRIS.SelectedItems[0].SubItems[0].Text;
            risno = LVRIS.SelectedItems[0].SubItems[1].Text;
            currentqty.Text = LVRIS.SelectedItems[0].SubItems[2].Text;
            risqtyupdate = Convert.ToInt32(LVRIS.SelectedItems[0].SubItems[2].Text);
            selecteditemtb.Text = LVRIS.SelectedItems[0].SubItems[4].Text;
            risending = Convert.ToInt32(LVRIS.SelectedItems[0].SubItems[5].Text);
        }



        string updateqtyavailable;
        private void up_qty()
        {
           // Cmd = new MySqlCommand("UPDATE purchase_order SET poqty1='" + ending + "'  WHERE po_id='"+ rispo + "' && item_num='" + risid + "' ;", connection);
            MySqlCommand Cmd1 = new MySqlCommand("UPDATE inventory_logs SET ending='" + ending + "'  WHERE po_id='" + rispo + "' && item_num='" + risid + "' ;", connection);
            connection.Close();
            connection.Open();

            try
            {
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("the qty is now updated");
                    updateqtyavailable = "qty is now updated";
                }
                else
                {
                     // MessageBox.Show("the qty is not updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

        }

       //this is for inventory query

        int stockfortotalConsume;
        void totalConsumeItem()
        {
            connection.Close();
            connection.Open();
             
            Cmd = new MySqlCommand("SELECT * FROM purchase_order WHERE item_num ='" + risid + "' ", connection);
            //execute reader
            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                stockfortotalConsume = Reader.GetInt32("poqty1");
            }
            else
            {
                MessageBox.Show("NO DATA FILL");
            }
            Reader.Close();

            connection.Close();

        }

        
        int totalQty;
        void ConsumeItem()
        {
            connection.Close();
            connection.Open();

            Cmd = new MySqlCommand("SELECT * FROM purchase_order WHERE item_num ='" + risid + "' ", connection);
            //execute reader
            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                string batch1 = Reader.GetString("po_id");

                // int batch = Convert.ToInt32(batchh.Text);

                if (rispo == batch1)
                {
                    Reader.Close();

                    //computation for totalConsumeqty
                    totalQty = stockfortotalConsume - risqty;
                    //condition for add qty of item
                    // connection.Open();

                    Cmd = new MySqlCommand("UPDATE purchase_order SET poqty1='" + totalQty + "'  WHERE item_num='" + risid + "' && po_id='" + rispo + "' ;", connection);
                  //  Cmd = new MySqlCommand("UPDATE purchase_order SET poqty1='" + ending + "'  WHERE po_id='" + rispo + "' && item_num='" + risid + "' ;", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                           // MessageBox.Show("data is now updated");
                            updateqtyavailable = "qty is now updated";
                        }
                        else
                        {
                            //MessageBox.Show("data is not updated");
                            updateqtyavailable = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    connection.Close();

                }


            }
        }

        int stockfortotalConsume1;
        void totalConsumeEnding()
        {
            connection.Close();
            connection.Open();

            //Cmd = new MySqlCommand("SELECT * FROM ending WHERE item_num1 ='" + risid + "' ", connection);
            Cmd = new MySqlCommand("SELECT * FROM inventory_logs WHERE item_num ='" + risid + "' ", connection);
            //execute reader
            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                stockfortotalConsume1 = Reader.GetInt32("oqty");
            }
            else
            {
                MessageBox.Show("NO DATA FILL");
            }
            Reader.Close();

            connection.Close();

        }


        string updateqtyending;
        int totalQty1;
        void ConsumeForending()
        {
            connection.Close();
            connection.Open();

           // Cmd = new MySqlCommand("SELECT * FROM ending WHERE item_num1 ='" + risid + "' ", connection);
            Cmd = new MySqlCommand("SELECT * FROM inventory_logs WHERE item_num ='" + risid + "' ", connection);
            //execute reader
            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                string batch1 = Reader.GetString("po_id");

                if (rispo == batch1)
                {
                    Reader.Close();

                    //computation for totalConsumeqty
                    totalQty1 = stockfortotalConsume1 + risqty;
                    //condition for add qty of item
                    // connection.Open();

                    Cmd = new MySqlCommand("UPDATE inventory_logs SET oqty='" + totalQty1 + "'  WHERE item_num='" + risid + "' && po_id='" + rispo + "' ;", connection);

                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            //MessageBox.Show("data is now updated");
                            updateqtyending = "qty is now updated";
                        }
                        else
                        {
                            //MessageBox.Show("data is not updated");
                            updateqtyending = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    connection.Close();

                }


            }
        }

        int endingstock;
        int totalendingstock;
        double priceForEnding;
        double totalPriceOfEnding;

        void calculateEnding()
        {
            connection.Close();
            connection.Open();

            
            Cmd = new MySqlCommand("SELECT * FROM inventory_logs WHERE item_num ='" + risid + "' and po_id = '"+ rispo +"' ", connection);
            //execute reader
            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                endingstock = Reader.GetInt32("ending");
                priceForEnding = Reader.GetDouble("unit_price");

                

                Reader.Close();

                //computation for totalConsumeqty
                totalendingstock = endingstock - risqty;
                totalPriceOfEnding = (totalendingstock * priceForEnding);
                //condition for add qty of item                    

                Cmd = new MySqlCommand("UPDATE inventory_logs SET ending='" + totalendingstock + "', total_amt='" + totalPriceOfEnding + "'  WHERE item_num='" + risid + "' and po_id='" + rispo + "' ;", connection);

                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {


                        //  MessageBox.Show("data is now updated");
                        getTotalOuItem();
                        updateqtyending = "qty is now updated";
                        }
                        else
                        {
                            //MessageBox.Show("data is not updated");
                            updateqtyending = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    connection.Close();

                


            }
        }

        int outItemqty;
        int totalOutItem;

        void getTotalOuItem()
        {
            connection.Close();
            connection.Open();


            Cmd = new MySqlCommand("SELECT * FROM inventory_logs WHERE item_num ='" + risid + "' and po_id = '" + rispo + "' ", connection);
            //execute reader
            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                outItemqty = Reader.GetInt32("oqty");


                Reader.Close();

                //computation for totalConsumeqty
                totalOutItem = outItemqty + risqty;
                //condition for add qty of item                    

                Cmd = new MySqlCommand("UPDATE inventory_logs SET oqty='" + totalOutItem + "'  WHERE item_num='" + risid + "' and po_id='" + rispo + "' ;", connection);

                try
                {
                    if (Cmd.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("data is now updated");
                        updateqtyending = "qty is now updated";
                    }
                    else
                    {
                        //MessageBox.Show("data is not updated");
                        updateqtyending = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                connection.Close();




            }
        }

        string rispo;
        string risid;
        int risqty;
        string risunit;
        string risitem;
        string ending;
        string savetheris;

        string confirmsave;

        private void btnSaveRIS_Click(object sender, EventArgs e)
        {
            if(confirmsave == "save")
            {
                MessageBox.Show("The Transaction is already saved!", "R.I.S.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                risqty_LVRIS();

                try
                {
                    string sql = "SELECT *  FROM ris WHERE risno LIKE  '" + tbRisID.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);

                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        MessageBox.Show("The R.I.S NO is already taken", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("not found", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (tbRisID.Text == "")
                        {
                            MessageBox.Show("Please, Fill the correct R.I.S NO. or Do not leave it blank. Thank you.", "R.I.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (cbrequest.Text == "Select" || cbdept.Text == "Select" || cbreceived.Text == "Select" || cbissued.Text == "Select")
                            {
                                MessageBox.Show("Please select the Personnel to complete the transaction before save. Thank you!", "R.I.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (MessageBox.Show("Are you sure do you really want to save now? NOTE: Double check before you save it. Thank you.", "R.I.S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (qtyforris == 0)
                                    {
                                        MessageBox.Show("Please, make sure there is data from the table. Thank you!", "R.I.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < LVRIS.Items.Count; i++)
                                        {
                                            // ConsumeItem();
                                            rispo = LVRIS.Items[i].SubItems[0].Text;
                                            risid = LVRIS.Items[i].SubItems[1].Text;//ok
                                            risqty = Convert.ToInt32(LVRIS.Items[i].SubItems[2].Text);
                                            risunit = LVRIS.Items[i].SubItems[3].Text;//ok
                                            risitem = LVRIS.Items[i].SubItems[4].Text;
                                            ending = LVRIS.Items[i].SubItems[5].Text;




                                            //connection.Close();
                                            
                                            //up_qty();
                                            //updating the total for purchase order
                                            //totalConsumeItem();
                                            //ConsumeItem();

                                            //*********updated calculation***********
                                            calculateEnding();
                                            
                                            //updating the total ending
                                            //totalConsumeEnding();
                                            //ConsumeForending();
                                            
                                            connection.Close();

                                            Cmd = new MySqlCommand("INSERT into ris (risdate, risno, itemnum, risqty, risunit, risitem, ending, requestedby, department, received, issued, ponum)"
                                                + "values('" + dtrisdate.Text + "','" + tbRisID.Text + "','" + risid + "','" + risqty + "','" + risunit + "','" + risitem + "','" + ending + "','" + cbrequest.Text + "','" + cbdept.Text + "' , '" + cbreceived.Text + "', '" + cbissued.Text + "', '" + rispo + "')", connection);

                                            MySqlCommand Cmd1 = new MySqlCommand("INSERT into ris_logs (risdate, risno, itemnum, risqty, risunit, risitem, ending, requestedby, department, received, issued, ponum)"
                                                + "values('" + dtrisdate.Text + "','" + tbRisID.Text + "','" + risid + "','" + risqty + "','" + risunit + "','" + risitem + "','" + ending + "','" + cbrequest.Text + "','" + cbdept.Text + "' , '" + cbreceived.Text + "', '" + cbissued.Text + "', '" + rispo + "')", connection);

                                            connection.Open();
                                            // MySqlCommand Cmd1 = new MySqlCommand("INSERT into order_line (POnum, ItemID, Orderqty, UnitCost, Discount)"
                                            //  + "values('" + pid.Text + "','" + iid + "','" + qty + "','" + ucost + "','" + sdisc + "' )", connection);

                                            // MySqlDataReader myReader;
                                            try
                                            {
                                                if (Cmd.ExecuteNonQuery() == 1 && Cmd1.ExecuteNonQuery() == 1)
                                                {
                                                    //MessageBox.Show("data is Saved");
                                                    savetheris = "data is Saved";
                                                }

                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }

                                            connection.Close();
                                        }

                                        //     updateqtyavailable = "qty is now updated";
                                        if (savetheris == "data is Saved" )
                                        {
                                            MessageBox.Show("Transaction successfully saved!", "R.I.S.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            confirmsave = "save";
                                            LVRIS.Items.Clear();
                                            tbRisID.Enabled = false;
                                            //LVPO.Items.Clear();

                                            ////for print
                                            Cursor.Current = Cursors.WaitCursor;
                                            try
                                            {
                                                DataSet ds3 = new DataSet();
                                                //this query will show to listview
                                                MySqlDataAdapter Adapter1 = new MySqlDataAdapter("SELECT * FROM ris WHERE risno='" + tbRisID.Text + "';", connection);
                                                ds3.Reset();
                                                Adapter1.Fill(ds3);

                                                LVRIS.Items.Clear();

                                                if (ds3.Tables[0].Rows.Count > 0)
                                                {
                                                    for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                                                    {
                                                        LVRIS.Items.Add(ds3.Tables[0].Rows[i]["ponum"].ToString());
                                                        LVRIS.Items[LVRIS.Items.Count - 1].SubItems.Add(ds3.Tables[0].Rows[i]["itemnum"].ToString());
                                                        LVRIS.Items[LVRIS.Items.Count - 1].SubItems.Add(ds3.Tables[0].Rows[i]["risqty"].ToString());
                                                        LVRIS.Items[LVRIS.Items.Count - 1].SubItems.Add(ds3.Tables[0].Rows[i]["risunit"].ToString());
                                                        LVRIS.Items[LVRIS.Items.Count - 1].SubItems.Add(ds3.Tables[0].Rows[i]["risitem"].ToString());
                                                        LVRIS.Items[LVRIS.Items.Count - 1].SubItems.Add(ds3.Tables[0].Rows[i]["ending"].ToString());

                                                    }

                                                    if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                                                    {
                                                        System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                                                    }

                                                    ds3.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\RISprint.xml");

                                                    //expiredNow();
                                                }


                                            }
                                            catch (Exception ex)
                                            {

                                                MessageBox.Show(ex.Message);
                                            }

                                            Adapter.Dispose();

                                            connection.Close();

                                        }
                                        else
                                        {
                                            MessageBox.Show("Transaction not saved!", "R.I.S.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }



                                        // getbatchno();*/
                                    }
                                }

                            }

                        }


                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }


        void depFill()
        {
            Cmd = new MySqlCommand("SELECT * from department where id", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("dep_name");


                    cbdepartment.Items.Add(sid);
                    cbdept.Items.Add(sid);
                    cbdepreport.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }




        void nameFill()
        {
            Cmd = new MySqlCommand("SELECT * from signature where id", connection);

            try
            {
                connection.Close();
                connection.Open();
                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    string sid = Reader.GetString("fullname");
                    string category = Reader.GetString("category");


                    cbfullname.Items.Add(sid);
                    cbrequest.Items.Add(sid);

                    //cb_categorySignature.Items.Clear();
                    
                    //cb_categorySignature.Text = category.ToString();
                   // cb_categorySignature.Items.Add(category);


                    cbreceived.Items.Add(sid);
                    cbissued.Items.Add(sid);
                    cbreqbypo.Items.Add(sid);
                    cbapprovedpo.Items.Add(sid);
                    cblogreq.Items.Add(sid);
                    cblogissued.Items.Add(sid);
                    cblogreceived.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

  

        int qtyforpo = 0;
        void poqty()
        {
            int ColumnAvg = 0;

            for (int i = 0; i < LVPO.Items.Count; i++)
            {
                ColumnAvg += int.Parse(LVPO.Items[i].SubItems[1].Text);
            }

            qtyforpo = Convert.ToInt32(ColumnAvg.ToString());
          //  label14.Text = Convert.ToString(ColumnAvg.ToString());

            //totalrmed = Convert.ToInt32(ColumnAvg.ToString());
        }

        //validation for ris
        int qtyforris = 0;
        void risqty_LVRIS()
        {
            int ColumnAvg = 0;

            for (int i = 0; i < LVRIS.Items.Count; i++)
            {
                ColumnAvg += int.Parse(LVRIS.Items[i].SubItems[2].Text);
            }

            qtyforris = Convert.ToInt32(ColumnAvg.ToString());
            
        }



        private void btnpoprint_Click(object sender, EventArgs e)
        {             
            if(savepo == "saved")
            {
                Cursor.Current = Cursors.WaitCursor;
                poforprint prntme = new poforprint();

                prntme.ShowDialog();
                savepo = "saved";
            }else
            {
                MessageBox.Show("Sorry you have to save your work 1st or maybe you do not have yet data.", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        string selectPOitemrow;
        string getAllUnit;

        private void LVPO_MouseClick(object sender, MouseEventArgs e)
        {
            
            selectPOitemrow = LVPO.SelectedItems[0].SubItems[3].Text;

            getAllUnit = LVPO.SelectedItems[0].SubItems[2].Text;

            tbpoidupdate.Text = LVPO.SelectedItems[0].SubItems[8].Text;
            tbitemidupate.Text = LVPO.SelectedItems[0].SubItems[0].Text;
            tbitemnameupdate.Text = LVPO.SelectedItems[0].SubItems[3].Text;
            nmqtyupdate.Text = LVPO.SelectedItems[0].SubItems[1].Text;
            tbupriceupdate.Text = LVPO.SelectedItems[0].SubItems[4].Text;
            tbamountup.Text = LVPO.SelectedItems[0].SubItems[5].Text;
            tbreorderup.Text = LVPO.SelectedItems[0].SubItems[9].Text;
            cbitemcatup.Text = LVPO.SelectedItems[0].SubItems[7].Text;
            dtmob4expire.Text = LVPO.SelectedItems[0].SubItems[10].Text;
            dtexpired.Text = LVPO.SelectedItems[0].SubItems[11].Text;
            cbsupup.Text = LVPO.SelectedItems[0].SubItems[6].Text;


        }

       

        private void tb_poreorderedlvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      

        private void hideme_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "Inventory Form successfully minimize!";
            notifyIcon1.ShowBalloonTip(1000);
            notifyIcon1.BalloonTipTitle = "INVENTORY FORM";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            catpanel.Visible = true;
            unitpanel.Visible = false;
            emppanel.Visible = false;
            supppanel.Visible = false;
            deppanel.Visible = false;
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            catpanel.Visible = false;
            unitpanel.Visible = false;
            emppanel.Visible = false;
            supppanel.Visible = true;
            deppanel.Visible = false;
        }

        private void btnunit_Click(object sender, EventArgs e)
        {
            catpanel.Visible = false;
            unitpanel.Visible = true;
            emppanel.Visible = false;
            supppanel.Visible = false;
            deppanel.Visible = false;

            selectUnit();
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            catpanel.Visible = false;
            unitpanel.Visible = false;
            emppanel.Visible = true;
            supppanel.Visible = false;
            deppanel.Visible = false;

            cbfullname.Items.Clear();
            nameFill();
        }

        private void btndep_Click(object sender, EventArgs e)
        {
            catpanel.Visible = false;
            unitpanel.Visible = false;
            emppanel.Visible = false;
            supppanel.Visible = false;
            deppanel.Visible = true;

            cbdepartment.Items.Clear();
            depFill();

        }

        string getunitforitem;

        private void btnsaveproduct_Click(object sender, EventArgs e)
        {
           
            if (ProductName.Text == "" && cb_suppliername.Text =="" && addproductcategory.Text == "Select Item Category" && unitPrice.Value == 0)
            {
                MessageBox.Show("Pls. Input the required Information.", "ADD ITEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(cbcategoryunit.Text=="Select" && cbaddunitmeasure.Text=="Select" && cbaddunit.Text== "Select")
                {
                    getunitforitem = "N/A N/A N/A";
                }
                else
                {
                    getunitforitem = cbcategoryunit.Text + " " + cbaddunitmeasure.Text + " " + cbaddunit.Text;
                }
                

                connection.Close();
                connection.Open();

                Cmd = new MySqlCommand("INSERT into item_product (item_name, category, supplier, unit, unit_price)" + 
                "values('" + ProductName.Text + "', '" + addproductcategory.Text + "', '"+ cb_suppliername.Text + "', '" + getunitforitem + "', '"+ unitPrice.Value + "')", connection);
                try
                {                        retrieve();

                    {
                        
                        ProductName.Text = "";
                        addproductcategory.Text = "Select Item Category";

                        cbcategoryunit.Text = "Select";
                        cbaddunitmeasure.Text = "Select";
                        cbaddunit.Text = "Select";
                        
                        unitPrice.Value = 0;

                        MessageBox.Show("Item successfully saved!", "ADD ITEM SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        supnametxt.Text = "";
                        LVitem.Items.Clear();
                        retrieveItem();
                        LVPOSEARCH.Items.Clear();
                        cb_suppliername.Items.Clear();
                        cbSupplier.Items.Clear();
                        //retrieve_LVPOSEARCH();
                        retrievePOSEARCH();
                        LVSearch.Items.Clear();
                        cb_suppliername.Text = "Select Supplier";
                        cbSupplier.Text = "Select Supplier";
                        //getting the data from database
                        cbcatsearch();
                        retrieve();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }
        }

        void unitcat()
        {
            Cmd = new MySqlCommand("SELECT * from unit_category order by id", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("category_name");

                    //unit2.Items.Add(sid);
                    cb_set_unit.Items.Add(sid);
                    cbcategoryunit.Items.Add(sid);
                    cbucatup.Items.Add(sid);
                    comboBox4.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        void unitFormedicine()
        {
            Cmd = new MySqlCommand("SELECT * from item_unit order by id", connection);

            try
            {
                connection.Close();

                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("unit");

                    //unit2.Items.Add(sid);
                    cb_set_unit.Items.Add(sid);
                    cbaddunit.Items.Add(sid);
                    comboBox2.Items.Add(sid);
                    tbunitup.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        void selectUnit()
        {

            if (cbunitSelector.Text == "Unit Measure")
            {
                cb_set_unit.Items.Clear();
                unitMeasure();
            }
            else if (cbunitSelector.Text == "Unit Category")
            {
                cb_set_unit.Items.Clear();
                unitcat();
            }
            else if (cbunitSelector.Text == "Unit")
            {
                cb_set_unit.Items.Clear();
                unitFormedicine();
            }
            else if (cbunitSelector.Text == "select")
            {
                cb_set_unit.Items.Clear();
                cb_set_unit.Text = "select";
            }
        }

        private void cbunitSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_setunit.Text = "";
            cb_set_unit.Text = "select";
            selectUnit();            
        }

        private void btnsave5_Click_1(object sender, EventArgs e)
        {
            if (tbdepartment.Text == "")
            {
                MessageBox.Show("Input first the required field", "DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // lblalertprod.Visible = true;
                //tb_prod.BorderColorIdle = Color.Red;
            }
            else
            {
                if (MessageBox.Show("Are you sure to Add " + tbdepartment.Text + " as new Department?", "DEPARTMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();

                    Cmd = new MySqlCommand("INSERT into department (dep_name)"
                                            + "values('" + tbdepartment.Text + "')", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            cbdepartment.Items.Clear();
                            cbdept.Items.Clear();
                            cbdepreport.Items.Clear();

                            depFill();
                            cbdepartment.Text = "Select Department";
                            tbdepartment.Text = "";
                            cbdept.Text = "Select";
                            cbdepreport.Text = "Select Department";

                            MessageBox.Show("Department " + tbdepartment.Text + " is Successfuly Added", "DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbcat.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else
                {

                }
            }
        }

        private void btnupdate5_Click_1(object sender, EventArgs e)
        {
            if (tbdepartment.Text == "")
            {
                MessageBox.Show("Input first the required field", "DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    lblalertprod.Visible = true;
                //    tb_prod.BorderColorIdle = Color.Red;


            }
            else
            {
                if (MessageBox.Show("Are you sure, you want to Edit " + cbdepartment.Text + " as " + tbdepartment.Text + " DEPARTMENT?", "DEPARTMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();

                    Cmd = new MySqlCommand("Update department set dep_name = '" + tbdepartment.Text + "' where dep_name = '" + cbdepartment.Text + "'", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            cbdepartment.Items.Clear();
                            cbdept.Items.Clear();
                            cbdepreport.Items.Clear();

                            depFill();
                            cbdepartment.Text = "Select Category";
                            cbdept.Text = "Select";
                            tbdepartment.Text = "";
                            cbdepreport.Text = "Select Department";

                            MessageBox.Show("DEPARTMENT " + tbdepartment.Text + " is now save", "DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else
                {

                }
            }
        }

        private void btnsavefn_Click_1(object sender, EventArgs e)
        {
            if (tbfullname.Text == "" && cb_categorySignature.Text == "Select Category")
            {
                MessageBox.Show("Input first the required field", "EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // lblalertprod.Visible = true;
                //tb_prod.BorderColorIdle = Color.Red;


            }
            else
            {
                if (MessageBox.Show("Are you sure to Add " + tbfullname.Text + " as new " + cb_categorySignature.Text + " ?", "EMPLOYEE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();

                    Cmd = new MySqlCommand("INSERT into signature (fullname, category)"
                                            + "values('" + tbfullname.Text + "','" + cb_categorySignature.Text + "')", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            cbfullname.Items.Clear();
                            cbrequest.Items.Clear();
                            cbreceived.Items.Clear();
                            cbissued.Items.Clear();
                            cbreqbypo.Items.Clear();
                            cbapprovedpo.Items.Clear();
                            cblogreq.Items.Clear();
                            cblogissued.Items.Clear();
                            cblogreceived.Items.Clear();
                            cb_categorySignature.Items.Clear();

                            nameFill();
                            cbfullname.Text = "Select Employee";
                            tbfullname.Text = "";
                            cbrequest.Text = "Select";
                            cbreceived.Text = "Select";
                            cbissued.Text = "Select";
                            cbreqbypo.Text = "Select";
                            cbapprovedpo.Text = "Select";

                            cblogreq.Text = "Select";
                            cblogissued.Text = "Select";
                            cblogreceived.Text = "Select";
                            cb_categorySignature.Text = "Select Category";
                            MessageBox.Show("Employee " + tbfullname.Text + " is Successfuly Added", "EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else
                {

                }
            }
        }

        private void btnupdatefn_Click_1(object sender, EventArgs e)
        {
            if (tbfullname.Text == "" && cb_categorySignature.Text == "Select Category")
            {
                MessageBox.Show("Input first the required field", "EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // lblalertprod.Visible = true;
                //tb_prod.BorderColorIdle = Color.Red;

            }
            else
            {
                if (MessageBox.Show("Are you sure, you want to Edit " + cbfullname.Text + " as " + tbfullname.Text + " ," + cb_categorySignature.Text + " ?", "EMPLOYEE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();

                    Cmd = new MySqlCommand("Update signature set fullname = '" + tbfullname.Text + "' , category ='"+ cb_categorySignature.Text + "' where fullname = '" + cbfullname.Text + "'", connection);
                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            cbfullname.Items.Clear();
                            cbrequest.Items.Clear();
                            cbreceived.Items.Clear();
                            cbissued.Items.Clear();
                            cbreqbypo.Items.Clear();
                            cbapprovedpo.Items.Clear();
                            cblogreq.Items.Clear();
                            cblogissued.Items.Clear();
                            cblogreceived.Items.Clear();
                            cb_categorySignature.Items.Clear();

                            nameFill();
                            cbfullname.Text = "Select Employee";
                            tbfullname.Text = "";
                            cbrequest.Text = "Select";
                            cbreceived.Text = "Select";
                            cbissued.Text = "Select";
                            cbreqbypo.Text = "Select";
                            cbapprovedpo.Text = "Select";

                            cblogreq.Text = "Select";
                            cblogissued.Text = "Select";
                            cblogreceived.Text = "Select";
                            cb_categorySignature.Text = "Select Category";

                            MessageBox.Show("EMPLOYEE " + tbfullname.Text + " is now save", "EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbfullname.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else
                {

                }
            }
        }

        private void cbfullname_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //nameFill();
           // tbfullname.Text = "";


            tbfullname.Text = cbfullname.Text;

           
                Cmd = new MySqlCommand("SELECT * from signature where fullname ='"+ tbfullname.Text + "' ", connection);

                try
                {
                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                       // string sid = Reader.GetString("fullname");
                        string category = Reader.GetString("category");


                      //  cbfullname.Items.Add(sid);
                       // cbrequest.Items.Add(sid);

                        cb_categorySignature.Items.Clear();

                        cb_categorySignature.Text = category.ToString();
                        //cb_categorySignature.Items.Add(category);


                        //cbreceived.Items.Add(sid);
                        //cbissued.Items.Add(sid);
                        //cbreqbypo.Items.Add(sid);
                        //cbapprovedpo.Items.Add(sid);
                        //cblogreq.Items.Add(sid);
                        //cblogissued.Items.Add(sid);
                        //cblogreceived.Items.Add(sid);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();


            //cb_categorySignature.Text = 
            //cb_categorySignature.Items.Clear();

            cb_categorySignature.Items.Add("Approved by");
            cb_categorySignature.Items.Add("Issued by");
            cb_categorySignature.Items.Add("Prepared by");
            cb_categorySignature.Items.Add("Received by");
        }

        private void cbdepartment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbdepartment.Text = cbdepartment.Text;
        }

       

        private void retrieveItem()
        {
            Cmd = new MySqlCommand("SELECT id, item_name, supplier, category, unit, unit_price FROM item_product", connection);

            try
            {
                DataTable dtforitem = new DataTable();
                connection.Close();
                connection.Open();
                Adapter = new MySqlDataAdapter(Cmd);
                Adapter.Fill(dtforitem);

                foreach (DataRow row in dtforitem.Rows)
                {
                    itemproduct(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());

                }
                connection.Close();

                dtforitem.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void itemproduct(String id, String name, String supplier, String brand, String unit, String unitPrice)
        {
            String[] row = { id, name, supplier, brand, unit , unitPrice };

            ListViewItem item = new ListViewItem(row);

            LVitem.Items.Add(item);

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            try
            {

                connection.Close();
                connection.Open();

                Cmd = new MySqlCommand();

                Cmd.Connection = connection;


                Cmd.CommandText = "SELECT * FROM item_product WHERE Product_name LIKE '%" + tb_search.Text + "%' ";

                Adapter = new MySqlDataAdapter();

                Adapter.SelectCommand = Cmd;

                DataTable dtforitem = new DataTable();

                Adapter.Fill(dtforitem);

                LVitem.Items.Clear();
                foreach (DataRow r in dtforitem.Rows)
                {

                    ListViewItem list = LVitem.Items.Add(r["Product_id"].ToString());
                    list.SubItems.Add(r["Product_name"].ToString());
                    list.SubItems.Add(r["supplier"].ToString());
                    list.SubItems.Add(r["Category"].ToString());
                    list.SubItems.Add(r["Unit_id"].ToString());
                    list.SubItems.Add(r["unitPrice"].ToString());

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }


      //  string[] resultArray;
        private void LVitem_MouseClick(object sender, MouseEventArgs e)
        {
            tbitemid.Text = LVitem.SelectedItems[0].SubItems[0].Text;
            tbname.Text = LVitem.SelectedItems[0].SubItems[1].Text;
            cbSupplier.Text = LVitem.SelectedItems[0].SubItems[2].Text;
            cbitemcat.Text = LVitem.SelectedItems[0].SubItems[3].Text;

            //start explode
            string getunitforitem = LVitem.SelectedItems[0].SubItems[4].Text;
            string[] resultArray = getunitforitem.Split(new string[] { " " }, StringSplitOptions.None);

            comboBox4.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();

            comboBox4.Text = resultArray[0];
            comboBox3.Text = resultArray[1];
            comboBox2.Text = resultArray[2];
            //end explode

            editUnitPrice.Text = LVitem.SelectedItems[0].SubItems[5].Text;

            unitcat();
            unitFormedicine();
            unitMeasure();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(tbitemid.Text == "")
            {
                MessageBox.Show("Please select item from the item table!","EDIT SETTINGS",MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                panelitemedit.Visible = true;
                panel24.Visible = true;
                panel2.Visible = true;
            }
            
        }
       
        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure do you want to update?", "UPDATE ITEM SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (tbname.Text == "" && cbitemcat.Text == "Select Item Cat egory")
                    {
                        MessageBox.Show("Pls. Input the required Information.", "ADD ITEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (comboBox4.Text == "Select" && comboBox3.Text == "Select" && comboBox2.Text == "Select")
                        {
                            if (getunitforitem == "")
                            {
                                getunitforitem = "N/A N/A N/A";
                            }
                            getunitforitem = "N/A N/A N/A";

                        }
                        else
                        {
                            getunitforitem = comboBox4.Text + " " + comboBox3.Text + " " + comboBox2.Text;
                        }

                        Cmd = new MySqlCommand("UPDATE item_product SET item_name='" + tbname.Text + "', category='" + cbitemcat.Text + "', supplier='" +cbSupplier.Text+ "', unit='" + getunitforitem + "' , unit_price = '"+ editUnitPrice.Text + "'  WHERE id = '" + tbitemid.Text + "'  ", connection);

                        connection.Close();
                        connection.Open();

                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("The Item is now successfully updated!", "UPDATE ITEM SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LVitem.Items.Clear();
                                retrieveItem();

                                panelitemedit.Visible = false;
                                panel24.Visible = false;
                                panel2.Visible = false;

                                tbitemid.Text = "";
                                tbname.Text = "";
                                cbitemcat.Text = "Select Item Category";
                                comboBox4.Text = "Select";
                                comboBox3.Text = "Select";
                                comboBox2.Text = "Select";


                            }
                            else
                            {
                                MessageBox.Show("data is not updated");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();

                    }

                }
                else
                {
                   MessageBox.Show("The item is NOT Updated ", "UPDATE ITEM SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LVitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelitemedit.Visible = false;
            panel24.Visible = false;
            panel2.Visible = false;
        }

        int existing = 0;

        private void tbsearchpo_Click(object sender, EventArgs e)
        {
            tbunitprice.Enabled = false;

            if (savepo == "saved")
            {
                if(MessageBox.Show("New PURCHASE ORDER(P.O.)? The Data from Table will be Clear.", "PURCHASE ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    psearchpo.BringToFront();
                    LVPO.Items.Clear();
                    savepo = "";
                    tb_poid.Text = "";
                    existing = 0;


                    tbitemidupate.Text = "";
                    nmqtyupdate.Text = "";                    
                    tbitemnameupdate.Text = "";
                    tbupriceupdate.Text = "";
                    tbamountup.Text = "";
                    cbsupup.Text = "";
                    cbitemcatup.Text = "";
                    tbpoidupdate.Text = "";
                    tbreorderup.Text = "";
                    dtmob4expire.Text = "";
                    dtexpired.Text = "";
                    cbucatup.Text = "SELECT";
                    tbumeasureupdate.Text = "SELECT";
                    tbunitup.Text = "SELECT";
                    cbreqbypo.Text = "Select";
                    cbapprovedpo.Text = "Select";
                }
                else
                {
                   // MessageBox.Show("Double Check your JOb", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                psearchpo.BringToFront();
                existing = 0;
            }
        }

        private void psearchclose_Click(object sender, EventArgs e)
        {
            
            psearchpo.SendToBack();
            checkiditem = "";
            getItemName.Text = "ITEM";
            LVPOSEARCH.Items.Clear();
            retrievePOSEARCH();
        }

        
        private void retrievePOSEARCH()
        {
            Cmd = new MySqlCommand("SELECT * FROM item_product ORDER BY item_name ASC ", connection);

            try
            {
                DataTable dtforPoSearch = new DataTable();

                connection.Close();
                connection.Open();
                Adapter = new MySqlDataAdapter(Cmd);
                Adapter.Fill(dtforPoSearch);

                foreach (DataRow row in dtforPoSearch.Rows)
                {
                    poSearch(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());

                }
                connection.Close();
                dtforPoSearch.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void poSearch(String id, String itemname, String category, String unititem, String unitPrice)
        {
            string[] row = { id, itemname, category, unititem, unitPrice };

            ListViewItem item = new ListViewItem(row);

            LVPOSEARCH.Items.Add(item);

        }

        void checkPOID()
        {
            if(existing == 1)
            {
                try
                {
                    string sql = "SELECT *  FROM inventory_logs WHERE po_id LIKE  '" + tb_poid.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);

                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        //MessageBox.Show("The PO ID/PURCHASE ORDER ID is already taken", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The PO ID/PURCHASE ORDER ID is not exist, Please be sure that P.O. I.D. you input is correct", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string sql = "SELECT *  FROM purchase_order WHERE po_id LIKE  '" + tb_poid.Text + "' ";
                    Cmd = new MySqlCommand(sql, connection);

                    connection.Close();
                    connection.Open();
                    Reader = Cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        MessageBox.Show("The PO ID/PURCHASE ORDER ID is already taken", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("not found", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void tbsupplier_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (tb_poid.Text == "")
            {
                MessageBox.Show("You must fill the PO ID at the upper area of this screen. Thank you!", "PURCHASE ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                checkPOID();
            }

        }


        string itemidforpo;
        string itemnameforpo;
        string itemcategory;
        string unitforpo;

        private void LVPOSEARCH_MouseClick(object sender, MouseEventArgs e)
        {
            checkiditem = "getdata";
            tbamount.Text = "0";

            itemidforpo = LVPOSEARCH.SelectedItems[0].SubItems[0].Text;
            itemnameforpo = LVPOSEARCH.SelectedItems[0].SubItems[1].Text;
            getItemName.Text = LVPOSEARCH.SelectedItems[0].SubItems[1].Text;
            itemcategory = LVPOSEARCH.SelectedItems[0].SubItems[2].Text;
            unitforpo = LVPOSEARCH.SelectedItems[0].SubItems[3].Text;
            tbunitprice.Text = LVPOSEARCH.SelectedItems[0].SubItems[4].Text;


            tbqty.Value = 0;
            hideDateforPO();


        }

        void hideDateforPO()
        {
            if (itemcategory == "Medicine")
            {
                hideDate.Hide();
            }
            else
            {
                hideDate.Show();
            }
        }

        public void retrieve_LVPOSEARCH()
        {
            try
            {
                DataTable datasearch = new DataTable();

                connection.Open();

                Cmd = new MySqlCommand();

                Cmd.Connection = connection;


                Cmd.CommandText = "SELECT * FROM item_product WHERE category LIKE '%" + cbcategoryitem.Text + "%' ORDER BY item_name ASC ";

                Adapter = new MySqlDataAdapter();

                Adapter.SelectCommand = Cmd;


                Adapter.Fill(datasearch);

                LVSearch.Items.Clear();
                foreach (DataRow r in datasearch.Rows)
                {

                    ListViewItem list = LVPOSEARCH.Items.Add(r["id"].ToString());
                    list.SubItems.Add(r["item_name"].ToString());
                    list.SubItems.Add(r["category"].ToString());
                   // list.SubItems.Add(r["supplier"].ToString());
                    list.SubItems.Add(r["unit"].ToString());
                    list.SubItems.Add(r["unit_price"].ToString());

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }
        //category for search item
        private void cbcategoryitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LVPOSEARCH.Items.Clear();
            retrieve_LVPOSEARCH();


        }

        private void cbcategoryitem_MouseClick(object sender, MouseEventArgs e)
        {
            LVPOSEARCH.Items.Clear();
            retrievePOSEARCH();
            cbcategoryitem.Text = "Select filter category";
        }

        private void tbsearchpoitem_TextChanged(object sender, EventArgs e)
        {
            LVPOSEARCH.Items.Clear();

            try
            {
                DataTable datasearch2 = new DataTable();

                connection.Open();

                Cmd = new MySqlCommand();

                Cmd.Connection = connection;


                Cmd.CommandText = "SELECT * FROM item_product WHERE item_name LIKE '%" + tbsearchpoitem.Text + "%' ORDER BY id ASC ";

                Adapter = new MySqlDataAdapter();

                Adapter.SelectCommand = Cmd;


                Adapter.Fill(datasearch2);

                LVPOSEARCH.Items.Clear();
                foreach (DataRow r in datasearch2.Rows)
                {

                    ListViewItem list = LVPOSEARCH.Items.Add(r["id"].ToString());
                    list.SubItems.Add(r["item_name"].ToString());
                    list.SubItems.Add(r["category"].ToString());
                   // list.SubItems.Add(r["supplier"].ToString());
                    list.SubItems.Add(r["unit"].ToString());
                    list.SubItems.Add(r["unit_price"].ToString());
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }

        private void btnclosepoedit_Click(object sender, EventArgs e)
        {
            ppoedit.SendToBack();
        }

        private void btnupdatepo_Click(object sender, EventArgs e)
        {
            updatePOitem();
            btnpoupdate.BringToFront();

            if (cbucatup.Text == "SELECT" || tbumeasureupdate.Text == "SELECT" || tbunitup.Text == "SELECT")
            {
                LVPO.SelectedItems[0].SubItems[2].Text = getAllUnit;
            }
            else
            {
                string get3combounit = cbucatup.Text + " " + tbumeasureupdate.Text + " " + tbunitup.Text ;
                
                LVPO.SelectedItems[0].SubItems[2].Text = get3combounit;

                
            }
        }

        private void cbcatsearch()
        {
            try
            {
                DataTable dataposearch = new DataTable();

                connection.Open();

                Cmd = new MySqlCommand();

                Cmd.Connection = connection;


                Cmd.CommandText = "SELECT * FROM inventory_logs WHERE pocategory LIKE '%" + cbcategorysearch.Text + "%' && ending !=0 && status = 0 ORDER BY item_name ASC";

                Adapter = new MySqlDataAdapter();

                Adapter.SelectCommand = Cmd;


                Adapter.Fill(dataposearch);

                LVSearch.Items.Clear();
                foreach (DataRow r in dataposearch.Rows)
                {

                    ListViewItem list = LVSearch.Items.Add(r["po_id"].ToString());
                    list.SubItems.Add(r["item_num"].ToString());
                    list.SubItems.Add(r["pocategory"].ToString());
                    list.SubItems.Add(r["item_name"].ToString());
                    list.SubItems.Add(r["item_unit"].ToString());
                    list.SubItems.Add(r["ending"].ToString());
                    list.SubItems.Add(r["date"].ToString());
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }

        private void cbcategorysearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LVSearch.Items.Clear();

            //getting the data from database
            cbcatsearch();
        }

        private void cbcategorysearch_MouseClick(object sender, MouseEventArgs e)
        {
            //LVSearch.Items.Clear();
            // retrievePOSEARCH();
           // retrieve();
            cbcategorysearch.Text = "Select filter category";
        }

        private void tbunitprice_MouseClick(object sender, MouseEventArgs e)
        {
            checkPOID();
        }

        private void tbqty_MouseClick(object sender, MouseEventArgs e)
        {
            checkPOID();
        }

        private void tbamount_MouseClick(object sender, MouseEventArgs e)
        {
            checkPOID();
        }

        private void tb_poreorderedlvl_MouseClick(object sender, MouseEventArgs e)
        {
            checkPOID();
        }

        private void btnPrintRIS_Click(object sender, EventArgs e)
        {
            if (confirmsave == "save")
            {
                Cursor.Current = Cursors.WaitCursor;

                printRIS prntme1 = new printRIS();

                prntme1.ShowDialog();
                confirmsave = "save";
            }
            else
            {
                MessageBox.Show("Sorry you have to save your work 1st or maybe you do not have yet data.", "R.I.S.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnaddexistingpo_Click(object sender, EventArgs e)
        {
            poqty();

            if(existing == 1)
            {
                LVPOSEARCH.Items.Clear();
                retrievePOSEARCH();

                existing = 1;
                psearchpo.BringToFront();                       
                
            }
            else
            {
                if (qtyforpo == 0)
                {
                    if (MessageBox.Show("Add ITEM from Existing P.O I.D.?", "PURCHASE ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tb_poid.Text = "";

                        existing = 1;
                        psearchpo.BringToFront();
                    }
                    else
                    {
                        existing = 0;
                    }
                }
                else
                {
                    if (MessageBox.Show("There is a current data at the Item table. Do you wish to clear it all and make another transaction for ADD ITEM FOR EXISTING P.O. I.D?", "PURCHASE ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LVPO.Items.Clear();
                        tb_poid.Text = "";

                        if (MessageBox.Show("Add ITEM from Existing P.O I.D.?", "PURCHASE ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            existing = 1;
                            tb_poid.Text = "";

                            psearchpo.BringToFront();
                        }
                        else
                        {
                            existing = 0;
                        }


                    }
                    else
                    {
                        MessageBox.Show("There is no deleted data. Please Continue...", "PURCHASE ORDER");
                    }
                }
            }
            
        }

        private void PressRefresh()
        {
            cbcategorysearch.Text = "Select filter category";
            tbselecteditem.Text = "ITEM";
            qtysearch.Text = "0";
            tbsearchitem.Text = "";
            tbsearchpoitem.Text = "";

            LVSearch.Items.Clear();
            retrieve();
            tbsearch4item();
        }

        private void btnrefreshresult_Click(object sender, EventArgs e)
        {
            PressRefresh();
        }

        private void cbdepreport_MouseClick(object sender, MouseEventArgs e)
        {
            LVreport.Items.Clear();
            cbdepreport.Text = "Select Department";
        }

        private void tpw_OnValueChanged(object sender, EventArgs e)
        {
            tpw.isPassword = true;
        }

        private void tbqty_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                tbamount.Text = Convert.ToString(Convert.ToDouble(tbunitprice.Text) * Convert.ToDouble(tbqty.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, Enter the NUMBERS only.");
            }
        }

        private void tbqty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                tbamount.Text = Convert.ToString(Convert.ToDouble(tbunitprice.Text) * Convert.ToDouble(tbqty.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, Enter the NUMBERS only.");
            }
        }

        private void tbunitprice_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                tbamount.Text = Convert.ToString(Convert.ToDouble(tbunitprice.Text) * Convert.ToDouble(tbqty.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, Enter the NUMBERS only.");
            }
            
        }

        private void tbunitprice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
            
        }


        private void tbqty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_poreorderedlvl_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        private void logsToday_Click(object sender, EventArgs e)
        {
            PurchaseOrderLogs historylogs = new PurchaseOrderLogs(Username);
            historylogs.ShowDialog();
        }

        private void RisLogs_Click(object sender, EventArgs e)
        {
            risLogs historylogs1 = new risLogs(Username);
            historylogs1.ShowDialog();
        }

        private void tb_poid_MouseUp(object sender, MouseEventArgs e)
        {
            checkPOID();
        }

        private void returnedMed_Click(object sender, EventArgs e)
        {
       }

        private void nmqtyupdate_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                tbamountup.Text = Convert.ToString(Convert.ToDouble(tbupriceupdate.Text) * Convert.ToDouble(nmqtyupdate.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, Enter the NUMBERS only.");
            }
        }

        private void tbupriceupdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                tbamountup.Text = Convert.ToString(Convert.ToDouble(tbupriceupdate.Text) * Convert.ToDouble(nmqtyupdate.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, Enter the NUMBERS only.");
            }
        }

        private void cbreqbypo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbreqbypo.Text == cbapprovedpo.Text)
            {

                if (MessageBox.Show("The Requested by and Approved by is not allowed of having the same values, This Transaction will not be Save! Thank you", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    cbapprovedpo.Text = "Select";

                }
            }
        }

        private void cbapprovedpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbreqbypo.Text == cbapprovedpo.Text)
            {

                if (MessageBox.Show("The Requested by and Approved by is not allowed of having the same values, This Transaction will not be Save! Thank you", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    cbapprovedpo.Text = "Select";

                }
            }
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked me!");
        }

        private void cb_batchno_MouseClick(object sender, MouseEventArgs e)
        {
            PMLV.Items.Clear();
            retrieveInventory();
        }

        private void cb_expBatch_MouseClick(object sender, MouseEventArgs e)
        {
            LVEXP.Items.Clear();
            generateExpiredMeds();
        }

        private void cbfullname_MouseClick(object sender, MouseEventArgs e)
        {
            tbfullname.Text = "";
            cb_categorySignature.Items.Clear();
            cb_categorySignature.Text = "Select Category";
            cb_categorySignature.Items.Add("Approved by");
            cb_categorySignature.Items.Add("Issued by");
            cb_categorySignature.Items.Add("Prepared by");
            cb_categorySignature.Items.Add("Received by");

            cbfullname.Text = "Select Employee";
            cbfullname.Items.Clear();
            nameFill();
        }

        private void cbdepartment_MouseClick(object sender, MouseEventArgs e)
        {
            tbdepartment.Text = "";
            cbdepartment.Text = "Select Department";
        }

        private void cbcat_MouseClick(object sender, MouseEventArgs e)
        {
            cbcat.Text = "Select Category";
            tbcat.Text = "";
        }

        private void cbunitSelector_MouseClick(object sender, MouseEventArgs e)
        {
            cbunitSelector.Text = "select";
            cb_set_unit.Text = "select";
            tb_setunit.Text = "";
            cb_set_unit.Items.Clear();
        }

        private void cb_set_supplier_MouseClick(object sender, MouseEventArgs e)
        {
            cb_set_supplier.Text = "Select Supplier";
            supnametxt.Text = "";
        }

        private void LVPOSEARCH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_suppliername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }//end

}//end
