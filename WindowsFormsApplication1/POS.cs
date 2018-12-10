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
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class POS : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=maheseco; port= 3306; username=root;password=");

        MySqlDataAdapter Adapter;
        DataTable dt = new DataTable();
        MySqlDataReader reader;
        MySqlCommand Cmd;
        private DataSet ds = new DataSet();



        public POS(string user, string num1)
        {
            InitializeComponent();
            lUsername.Text = user;
            timein.Text = num1;
            this.KeyPreview = true;
            postId();
            lbl_notif.Visible = false;

            tbchange2.ForeColor = Color.Black;
            postId();
        }

        private void POS_Load(object sender, EventArgs e)
        {

            //star to display the clock
            clock.Start();

            //list for selected items
            LVPOS.View = View.Details;
            LVPOS.FullRowSelect = true;

            LVPOS.Columns.Add("ID#", 60);
            LVPOS.Columns.Add("ITEM NAME", 150);
            LVPOS.Columns.Add("UNIT", 150);
            LVPOS.Columns.Add("COST", 170);
            LVPOS.Columns.Add("ITEM qty", 90);
            //       LVPOS.Columns.Add("SUBTOTAL", 90);
            //       LVPOS.Columns.Add("DISC %", 90);
            //       LVPOS.Columns.Add("NETTOTAL", 90);
            //       LVPOS.Columns.Add("DISC AMT", 90);


            //grit for users
            welcome();


            titems.Enabled = false;
            bottompanel.Enabled = false;
            tbigtotal.Enabled = false;
            tchange.Enabled = false;
            textID.Enabled = false;
            textName.Enabled = false;
            textBrand.Enabled = false;

            textCost.Enabled = false;
            textUnit.Enabled = false;
            uptotal.Visible = false;
            tdiscount.Enabled = false;
            upqty.Enabled = false;
            // pinpanel.Visible = false;


            dpanel.Visible = false;
            textStock.Enabled = false;

            qty_del.Visible = false;
            sqty.Visible = false;

            //t_pincode.isPassword = true;

            itemlist.View = View.Details;
            itemlist.FullRowSelect = true;


            itemlist.Columns.Add("ITEM ID", 125);
            itemlist.Columns.Add("ITEM NAME", 125);
            itemlist.Columns.Add("BRAND", 125);
            itemlist.Columns.Add("UNIT", 125);
            itemlist.Columns.Add("UNIT COST", 125);
            itemlist.Columns.Add("STOCK", 125);
            itemlist.Columns.Add("Batch No.", 125);



              retrive();

            // tdis.Enabled = false;
            // pdiscount.Visible = false;
            pid.Enabled = false;

            pcharge.Visible = false;
            pcharge.Width = 0;


            //discount
            textdisc.Enabled = false;
            //  pupdate1.Visible = false;

            //pinpanel.Visible = false;
            // pupdate1.Visible = false;
            //dpanel.Visible = false;

            titemname.Enabled = false;
            ditem.Enabled = false;

            viewpanel.SendToBack();

            ControlExtension.Draggable(viewpanel, true);
            ControlExtension.Draggable(pupdate1, true);
            ControlExtension.Draggable(dpanel, true);
            ControlExtension.Draggable(pinpanel, true);
            ControlExtension.Draggable(gbCharge, true);
            ControlExtension.Draggable(pdone, true);
            ControlExtension.Draggable(backpinpanel, true);


            finalamt.Enabled = false;
            invoice_no.Enabled = false;

            tbchange2.Enabled = false;
            tbchange2.Text = tchange.Text;
            MessageBoxNotif();
            fillNotification();
        }

        void MessageBoxNotif()
        {
            connection.Open();
            Cmd = new MySqlCommand("SELECT * from drug_product where beforeExp ='" + timenow + "' ", connection);

            string sid;
            try
            {

                reader = Cmd.ExecuteReader();

                while (reader.Read())
                {

                    sid = reader.GetString("ItemName");
                    //cb_batchno.Items.Add(sid);
                    //MessageBox.Show("The medicine " + sid + " is expired!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipText = "There is an expired medicine";
                    notifyIcon1.ShowBalloonTip(1000);
                    notifyIcon1.BalloonTipTitle = "EXPIRED";
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        string timenow;

        void fillNotification()
        {

            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy-MM-dd");
            timenow = MySQLFormatDate.ToString();

            try
            {
                connection.Close();

                Adapter = new MySqlDataAdapter("SELECT * from drug_product where beforeExp ='" + timenow + "' ", connection);
                ds.Reset();
                Adapter.Fill(ds);

                LvNotif.Items.Clear();
                // LVEXP.Items.Clear();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        LvNotif.Items.Add(ds.Tables[0].Rows[i]["ItemName"].ToString());
                        LvNotif.Items[LvNotif.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["unit"].ToString());
                        LvNotif.Items[LvNotif.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["batchNo"].ToString());

                    }


                    connection.Close();



                    //int cnt = 0;

                    for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                    {
                        int y;


                        if (x < 0)
                        {

                        }
                        else
                        {
                            y = x + 1;
                            lbl_notif.Text = Convert.ToString(y);
                            lbl_notif.Visible = true;
                        }


                        //cnt++;

                    }



                }

                //Inventorymed_total();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();
        }


        void postId()
        {

            if (pid.Text == "")
            {
                pid.Text = "001";
            }
            else
            {
                connection.Open();
                try
                {
                    Cmd = new MySqlCommand("SELECT max(PO_id)+1 FROM transaction", connection);
                    pid.Text = Cmd.ExecuteScalar().ToString();
                }
                finally
                {
                    connection.Close();
                }
            }
            
        }

        void scape()
        {
            if (MessageBox.Show("Do you want to exit now?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                mform frm = new mform();
                frm.Show();
                connection.Close();
            }
        }


        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            scape();
        }




        private void clock_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy-MM-dd HH:mm:ss");
            atime.Text = MySQLFormatDate.ToString();

            DateTime time = DateTime.Now;
            string MySQLFormattime = time.ToString("HH:mm:ss");
            ldate.Text = MySQLFormatDate.ToString();

        }



        private void populateLV(String id, String name, String brand, String unit, String ucost, String stock, String batchNO)
        {
            String[] row = { id, name, brand, unit, ucost, stock, batchNO };

            ListViewItem item = new ListViewItem(row);

            itemlist.Items.Add(item);

        }
        //this is line for query of reorder level.
        private void add(String id, String name, String unit, String cost, String qty, String total, String disc, String subtotal, String discamt)
        {
            String[] row = { id, name, unit, cost, qty, total, disc, subtotal, discamt };
            ListViewItem item = new ListViewItem(row);

            LVPOS.FullRowSelect = true;


            //ListViewItem item = new ListViewItem(OnMouseHover);
            LVPOS.Items.Add(item);

        }


        private void retrive()
        {
            //  string sql = "SELECT product.prod_id ,prod_cat.item,  prod_cat.brand, prod_brand.unit, product.U_Cost, prod_brand.qty FROM product join prod_brand on prod_brand.brand_id = prod_id join prod_cat on prod_cat.cat_id = prod_id";
            string sql = "SELECT ItemID, ItemName,  brand, unit, price, stockQty, batchNo FROM drug where stockQty !=0 ";
            //string sql = "SELECT ItemID, ItemName, brand, unit, TRUNCATE(price, 2) as price ,stockQty, bathNo FROM drug";
            Cmd = new MySqlCommand(sql, connection);

            try
            {
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
        //dsfadaf

        string sampleID;
        int rstock = 0;
        int reordered_num = 0;
        void reOrdered_level()
        {

            string sql = "SELECT * FROM drug WHERE ItemID ='" + sampleID + "' ";
            Cmd = new MySqlCommand(sql, connection);

            connection.Open();
            //execute reader
            reader = Cmd.ExecuteReader();

            if (reader.Read())
            {
                reordered_num = reader.GetInt32("reOrdered");
                rstock = reader.GetInt32("stockQty");

                // samplestock.Text = Convert.ToString(rstock);

                //condition for reOrdered vs. stock
                if (reordered_num < rstock)
                {
                    // MessageBox.Show("your stock is Good", "INFORMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("your stock is " + rstock + " and it's running out!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }
            else
            {

                MessageBox.Show("NO DATA FILL");
            }
            reader.Close();

            connection.Close();
        }

        int stockfortotalConsume;
        void totalConsumeItem()
        {
            connection.Open();
            string sql = "SELECT * FROM drug_consume WHERE ItemID ='" + sampleID + "' ";
            Cmd = new MySqlCommand(sql, connection);
            //execute reader
            reader = Cmd.ExecuteReader();

            if (reader.Read())
            {
                stockfortotalConsume = reader.GetInt32("stockQty2");
            }
            else
            {
                MessageBox.Show("NO DATA FILL");
            }
            reader.Close();

            connection.Close();

        }

        int totalQty;
        void ConsumeItem()
        {
            connection.Open();
            string sql = "SELECT * FROM drug_consume WHERE ItemID ='" + sampleID + "' ";
            Cmd = new MySqlCommand(sql, connection);
            //execute reader
            reader = Cmd.ExecuteReader();

            if (reader.Read())
            {
                int batch1 = reader.GetInt32("batchNo");

                //  int batch = Convert.ToInt32(batchh.Text);

                if (batch == batch1)
                {
                    reader.Close();

                    //computation for totalConsumeqty
                    totalQty = stockfortotalConsume + int.Parse(nqty.Text);
                    //condition for add qty of item
                    string sql1 = "UPDATE drug_consume SET stockQty2='" + totalQty + "'  WHERE ItemID='" + sampleID + "' && batchNo=" + batch + " ";

                    // connection.Open();

                    Cmd = new MySqlCommand(sql1, connection);

                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            //  MessageBox.Show("data is now updated");
                        }
                        else
                        {
                            //  MessageBox.Show("data is not updated");
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

                MessageBox.Show("NO DATA FILL");
            }
            reader.Close();

            connection.Close();
        }




        private void btnsearch_Click(object sender, EventArgs e)
        {
            permission posfrm = new permission();
            posfrm.Show();

            btnsearch.Enabled = false;
        }



        private void btnsearch_Click_1(object sender, EventArgs e)
        {

            viewpanel.Enabled = true;
            viewpanel.BringToFront();
            disableBtn();
            this.KeyPreview = false;

            backpinpanel.SendToBack();
            backpinpanel.Visible = false;
            btndone.Enabled = false;

        }

        int batch;
        //this part need to path for reorder level query
        private void itemlist_MouseClick(object sender, MouseEventArgs e)
        {
            //itemlist.HoverSelection = true;

            textID.Text = itemlist.SelectedItems[0].SubItems[0].Text;
            textName.Text = itemlist.SelectedItems[0].SubItems[1].Text;
            textBrand.Text = itemlist.SelectedItems[0].SubItems[2].Text;
            textUnit.Text = itemlist.SelectedItems[0].SubItems[3].Text;
            textCost.Text = itemlist.SelectedItems[0].SubItems[4].Text;
            textStock.Text = itemlist.SelectedItems[0].SubItems[5].Text;
            // batchh.Text = itemlist.SelectedItems[0].SubItems[6].Text;

            //for reorder level
            //sampleid.Text = itemlist.SelectedItems[0].SubItems[0].Text;
            sampleID = itemlist.SelectedItems[0].SubItems[0].Text;
            rstock = int.Parse(itemlist.SelectedItems[0].SubItems[5].Text);
            batch = int.Parse(itemlist.SelectedItems[0].SubItems[6].Text);



            nqty.Value = 0;

            //  string sql = "SELECT ItemID, ItemName,  brand, unit, price, stockQty FROM drug";

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            totalConsumeItem();
            ConsumeItem();
            reOrdered_level();

            

            try
            {
                int zero = int.Parse(nqty.Text);
                double cost = double.Parse(textCost.Text);
                double ddisc = double.Parse(tdiscount.Text);

                if (zero == 0)
                {
                    // btn_add.Enabled = false;
                    MessageBox.Show("Please Enter QTY!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //  btn_add.Enabled = true;

                }
                else
                {
                    btn_add.Enabled = true;
                    int firstnum = int.Parse(nqty.Text);
                    int secondnum = int.Parse(titems.Text);
                    //double totalamt = 0.00;



                    if (secondnum > 0)
                    {
                        titems.Text = Convert.ToString((Convert.ToInt32(titems.Text) + Convert.ToInt32(nqty.Text)));

                        uptotal.Text = Convert.ToString((Convert.ToDouble(textCost.Text) * Convert.ToInt32(nqty.Text)));

                        //discount
                        tdiscount.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) * Convert.ToDouble(ndisc.Text)));
                        subtotal.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) - Convert.ToDouble(tdiscount.Text)));

                        Double x;
                        Double.TryParse(bottompanel.Text, out x);
                        bottompanel.Text = x.ToString(".00");

                        //add to LVPOS_listview
                        add(textID.Text, textName.Text, textUnit.Text, textCost.Text, nqty.Text, uptotal.Text, ndisc.Text, subtotal.Text, tdiscount.Text);

                        textStock.Text = Convert.ToString((Convert.ToInt32(textStock.Text) - Convert.ToInt32(nqty.Text)));
                        //====================updating stock qty
                        up_qty();

                        search_tb.Text = "search";
                        itemlist.Items.Clear();
                        retrive();

                    }
                    else if (secondnum == 0)
                    {
                        titems.Text = Convert.ToString((0 + Convert.ToInt32(nqty.Text)));

                        if (cost > 0)
                        {
                            uptotal.Text = Convert.ToString((Convert.ToDouble(textCost.Text) * Convert.ToInt32(nqty.Text)));


                            //discount
                            tdiscount.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) * Convert.ToDouble(ndisc.Text)));
                            subtotal.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) - Convert.ToDouble(tdiscount.Text)));


                            //add to LVPOS_listview
                            add(textID.Text, textName.Text, textUnit.Text, textCost.Text, nqty.Text, uptotal.Text, ndisc.Text, subtotal.Text, tdiscount.Text);

                            textStock.Text = Convert.ToString((Convert.ToInt32(textStock.Text) - Convert.ToInt32(nqty.Text)));
                            //=====================updating stock qty
                            up_qty();

                            search_tb.Text = "search";
                            //automaticaly refresh every qty of the item
                            itemlist.Items.Clear();
                            retrive();

                            Double x;
                            Double.TryParse(bottompanel.Text, out x);
                            bottompanel.Text = x.ToString(".00");

                        }

                    }

                    nqty.Text = "0";
                    ndisc.Value = 0;


                }

                cal();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select the item", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        //=====================updating stock function
        private void up_qty()
        {

            string sql1 = "UPDATE drug SET stockQty='" + textStock.Text + "'  WHERE ItemID='" + textID.Text + "' ";

            connection.Open();

            Cmd = new MySqlCommand(sql1, connection);


            try
            {
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    //  MessageBox.Show("data is now updated");

                }
                else
                {
                    //  MessageBox.Show("data is not updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();


        }




        private double discamt = 0.00;
        //========function for calculation
        private void cal()
        {

            double ColumnAvg = 0.00;
            double disctotal = 0.00;
            double displaydisc = 0.00;



            for (int i = 0; i < LVPOS.Items.Count; i++)
            {
                ColumnAvg += double.Parse(LVPOS.Items[i].SubItems[5].Text);
                displaydisc += double.Parse(LVPOS.Items[i].SubItems[8].Text);
                disctotal += double.Parse(LVPOS.Items[i].SubItems[7].Text);
                discamt += double.Parse(LVPOS.Items[i].SubItems[7].Text);
            }

           
            bottompanel.Text = ColumnAvg.ToString();
            tbigtotal.Text = disctotal.ToString();
            tdiscount.Text = displaydisc.ToString();

            Double x;
            Double.TryParse(bottompanel.Text, out x);
            bottompanel.Text = x.ToString(".00");

            Double y;
            Double.TryParse(tbigtotal.Text, out y);
            tbigtotal.Text = y.ToString(".00");

            Double z;
            Double.TryParse(tdiscount.Text, out z);
            tdiscount.Text = z.ToString(".00");

        }

        void remove()
        {
            if (titemname.Text == "Item name")
            {
                MessageBox.Show("Select atleast 1 item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                totalConsumeItem1();

                disableBtn();
                //delete();
                LVPOS.SendToBack();
                pinpanel.Visible = false;
                pupdate1.Visible = false;
                //   tablePOS.SendToBack();
                gbCharge.Visible = false;

                dpanel.Visible = true;
                dpanel.BringToFront();
                // panel2.Visible = false;
            }
        }


        private void btnremove_Click(object sender, EventArgs e)
        {
            remove();
        }


        void ConsumeItemDelete()
        {
            connection.Open();
            string sql = "SELECT * FROM drug_consume WHERE ItemID=" + int.Parse(qty_del.Text) + " ";
            Cmd = new MySqlCommand(sql, connection);
            //execute reader
            reader = Cmd.ExecuteReader();

            if (reader.Read())
            {
                int batch1 = reader.GetInt32("batchNo");

                reader.Close();
                //condition for add qty of item
                int totalQty1 = stockfortotalConsume1 - selectedQty;

                string sql1 = "UPDATE drug_consume SET stockQty2='" + totalQty1 + "'  WHERE ItemID=" + qty_del.Text + " && batchNo=" + batch1 + " ";

                // connection.Open();

                Cmd = new MySqlCommand(sql1, connection);

                try
                {
                    if (Cmd.ExecuteNonQuery() == 1)
                    {
                        //  MessageBox.Show("data is now updated");
                    }
                    else
                    {
                        //  MessageBox.Show("data is not updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                connection.Close();

                // }

            }
            else
            {

                MessageBox.Show("NO DATA FILL");
            }
            reader.Close();

            connection.Close();
        }

        //===========function for delete
        private void delete()
        {
            // try
            // {

            //qty_del.Text = LVPOS.SelectedItems[0].SubItems[0].Text;
            upqty.Text = LVPOS.SelectedItems[0].SubItems[4].Text;
            unitcost.Text = LVPOS.SelectedItems[0].SubItems[5].Text;
            textdisc.Text = LVPOS.SelectedItems[0].SubItems[6].Text;
            subtext.Text = LVPOS.SelectedItems[0].SubItems[7].Text;

            if (MessageBox.Show("Do you want to delete the selected item?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                for (int i = 0; i < LVPOS.Items.Count; i++)
                {
                    if (LVPOS.Items[i].Selected)
                    {

                        //compute the deleted item and subtract to the total amount and qty
                        bottompanel.Text = Convert.ToString((Convert.ToDouble(bottompanel.Text) - Convert.ToDouble(unitcost.Text)));

                        //tbigtotal.Text = bottompanel.Text;

                        titems.Text = Convert.ToString((Convert.ToInt32(titems.Text) - Convert.ToInt32(upqty.Text)));

                        //add the stock to the database
                        sqty.Text = Convert.ToString((Convert.ToInt32(sqty.Text) + Convert.ToInt32(upqty.Text)));

                        //tdiscount.Text = tdiscount
                        //subtotal.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) + Convert.ToDouble(subtext.Text)));

                        double dc = double.Parse(textdisc.Text);

                        if (dc < 0.00)
                        {
                            tbigtotal.Text = Convert.ToString((Convert.ToDouble(unitcost.Text) - Convert.ToDouble(bottompanel.Text)));
                        }
                        else
                        {
                            ///for maintenances
                            ///LVPOS.SelectedItems[0].SubItems[8].Text = subtext.Text;
                            tdiscount.Text = Convert.ToString((Convert.ToDouble(tdiscount.Text) - Convert.ToDouble(disclast.Text)));
                            tbigtotal.Text = Convert.ToString((Convert.ToDouble(tbigtotal.Text) - Convert.ToDouble(subtext.Text)));


                        }



                        up_qtyforup();
                        itemlist.Items.Clear();
                        retrive();

                        sqty.Text = "";
                        //get the value of sqty and update it
                        LVPOS.Items[i].Remove();
                        i--;


                    }

                }

                clr();

            }
            else
            {
                MessageBox.Show("Item is still not deleted,", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            // }
            //  catch (Exception )
            //  {
            //      MessageBox.Show("Choose item to Delete!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //   }

        }
        /// 
        private void retrieveStock()
        {
            string query = "SELECT * FROM drug WHERE  ItemID=" + int.Parse(qty_del.Text) + " ";


            Cmd = new MySqlCommand(query, connection);

            connection.Open();

            //execute reader
            reader = Cmd.ExecuteReader();

            if (reader.Read())
            {
                sqty.Text = reader.GetInt32("stockQty").ToString();
            }
            else
            {
                textStock.Text = "";
                MessageBox.Show("NO DATA FILL");
            }
            reader.Close();

            connection.Close();

        }

        int stockfortotalConsume1;
        void totalConsumeItem1()
        {

            try
            {
                connection.Open();
                string sql = "SELECT * FROM drug_consume WHERE ItemID =" + qty_del.Text + " ";
                Cmd = new MySqlCommand(sql, connection);
                //execute reader
                reader = Cmd.ExecuteReader();

                if (reader.Read())
                {
                    stockfortotalConsume1 = reader.GetInt32("stockQty2");
                }
                else
                {
                    MessageBox.Show("NO DATA FILL");
                }
                reader.Close();

                connection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                string sql = "SELECT * FROM drug_consume WHERE ItemID =" + qty_del.Text + " ";
                Cmd = new MySqlCommand(sql, connection);
                //execute reader
                reader = Cmd.ExecuteReader();

                if (reader.Read())
                {
                    stockfortotalConsume1 = reader.GetInt32("stockQty2");
                }
                else
                {
                    MessageBox.Show("Select 1 item first");
                }
                reader.Close();

                connection.Close();
            }

        }



        void ConsumeItemUpdate()
        {
            connection.Open();
            string sql = "SELECT * FROM drug_consume WHERE ItemID=" + int.Parse(qty_del.Text) + " ";
            Cmd = new MySqlCommand(sql, connection);
            //execute reader
            reader = Cmd.ExecuteReader();

            if (reader.Read())
            {
                int batch1 = reader.GetInt32("batchNo");

                //  if (batch == batch1)
                // {
                reader.Close();

                // LVPOS.SelectedItems[0].SubItems[4].Text = upqty2.Text;

                int qty = int.Parse(upqty.Text);
                int qty2 = int.Parse(upqty2.Value.ToString());

                if (qty > qty2)
                {

                    totalQty = stockfortotalConsume1 - int.Parse(totalqty.Text);
                    //condition for add qty of item
                    string sql1 = "UPDATE drug_consume SET stockQty2='" + totalQty + "'  WHERE ItemID=" + qty_del.Text + " && batchNo=" + batch1 + " ";

                    // connection.Open();

                    Cmd = new MySqlCommand(sql1, connection);

                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            //  MessageBox.Show("data is now updated");
                        }
                        else
                        {
                            //  MessageBox.Show("data is not updated");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (qty < qty2)
                {

                    totalQty = stockfortotalConsume1 + int.Parse(totalqty.Text);
                    //condition for add qty of item
                    string sql1 = "UPDATE drug_consume SET stockQty2='" + totalQty + "'  WHERE ItemID=" + qty_del.Text + "  && batchNo=" + batch1 + " ";

                    // connection.Open();

                    Cmd = new MySqlCommand(sql1, connection);

                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            //  MessageBox.Show("data is now updated");
                        }
                        else
                        {
                            //  MessageBox.Show("data is not updated");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("error");
                }


                connection.Close();

                //}

            }
            else
            {

                MessageBox.Show("NO DATA FILL");
            }
            reader.Close();

            connection.Close();
        }



        //======function for update
        private void update()
        {
            try
            {

                LVPOS.SelectedItems[0].SubItems[4].Text = upqty2.Text;
                LVPOS.SelectedItems[0].SubItems[6].Text = UDiscount.Text;


                unitcost.Text = LVPOS.SelectedItems[0].SubItems[3].Text;
                textdisc.Text = LVPOS.SelectedItems[0].SubItems[6].Text;


                int qty = int.Parse(upqty.Text);
                int qty2 = int.Parse(upqty2.Value.ToString());


                double uncost = double.Parse(unitcost.Text);


                discount();

                if (qty > qty2)//kapag maliit yung unang input qty2 or nagbabawas
                {


                    totalqty.Text = Convert.ToString((Convert.ToInt32(upqty.Text) - Convert.ToInt32(upqty2.Text)));

                    titems.Text = Convert.ToString((Convert.ToInt32(titems.Text) - Convert.ToInt32(totalqty.Text)));

                    uptotal.Text = Convert.ToString((Convert.ToDouble(unitcost.Text) * Convert.ToInt32(upqty2.Text)));
                    LVPOS.SelectedItems[0].SubItems[5].Text = uptotal.Text;


                    //discount


                    LVPOS.SelectedItems[0].SubItems[6].Text = UDiscount.Value.ToString();

                    subtext.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) * Convert.ToDouble(UDiscount.Value.ToString())));
                    LVPOS.SelectedItems[0].SubItems[8].Text = subtext.Text;

                    totaldiscount.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) - Convert.ToDouble(subtext.Text)));
                    LVPOS.SelectedItems[0].SubItems[7].Text = totaldiscount.Text;



                    // LVPOS.SelectedItems[0].SubItems[7].Text = uptotal.Text;


                    textStock.Text = Convert.ToString((Convert.ToInt32(textStock.Text) + Convert.ToInt32(t_ans.Text)));

                    sqty.Text = Convert.ToString((Convert.ToInt32(sqty.Text) + Convert.ToInt32(t_ans.Text)));
                    up_qtyforup();

                    //refresh
                    itemlist.Items.Clear();
                    retrive();


                }
                else if (qty < qty2)//kapag malaki yung unang input mag a-add qty2 nagdadagdag
                {



                    totalqty.Text = Convert.ToString((Convert.ToInt32(upqty2.Text) - Convert.ToInt32(upqty.Text)));

                    titems.Text = Convert.ToString((Convert.ToInt32(titems.Text) + Convert.ToInt32(totalqty.Text)));

                    uptotal.Text = Convert.ToString((Convert.ToDouble(unitcost.Text) * Convert.ToInt32(upqty2.Text)));

                    //discount

                    LVPOS.SelectedItems[0].SubItems[6].Text = UDiscount.Value.ToString();

                    subtext.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) * Convert.ToDouble(UDiscount.Value.ToString())));
                    LVPOS.SelectedItems[0].SubItems[8].Text = subtext.Text;

                    totaldiscount.Text = Convert.ToString((Convert.ToDouble(uptotal.Text) - Convert.ToDouble(subtext.Text)));
                    LVPOS.SelectedItems[0].SubItems[7].Text = totaldiscount.Text;


                    //  LVPOS.SelectedItems[0].SubItems[7].Text = uptotal.Text;
                    LVPOS.SelectedItems[0].SubItems[5].Text = uptotal.Text;

                    textStock.Text = Convert.ToString((Convert.ToInt32(textStock.Text) - Convert.ToInt32(t_ans.Text)));

                    sqty.Text = Convert.ToString((Convert.ToInt32(sqty.Text) - Convert.ToInt32(t_ans.Text)));
                    up_qtyforup();

                    //refresh
                    itemlist.Items.Clear();
                    retrive();


                }
                else if (qty2 == 0)
                {
                    MessageBox.Show("Select 1 item to update! in Item list", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                cal();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose item to update!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        void discount()
        {
            //convertdisc.Text = UDiscount.DecimalPlaces.ToString();

            double ddisc1 = double.Parse(textdisc.Text);
            double ddisc2 = double.Parse(UDiscount.DecimalPlaces.ToString());//here is the textbox wherein you can input whether big or small %
            //discount

            if (ddisc1 > ddisc2)
            {

                LVPOS.SelectedItems[0].SubItems[6].Text = UDiscount.Value.ToString();

                subtext.Text = Convert.ToString((Convert.ToDouble(t_ans.Text) * Convert.ToDouble(UDiscount.Value.ToString())));
                totaldiscount.Text = Convert.ToString((Convert.ToDouble(t_ans.Text) - Convert.ToDouble(subtext.Text)));

                LVPOS.SelectedItems[0].SubItems[7].Text = totaldiscount.Text;
                LVPOS.SelectedItems[0].SubItems[8].Text = subtext.Text;
                // subtext.Text = LVPOS.SelectedItems[0].SubItems[7].Text;
            }
            else if (ddisc1 < ddisc2)
            {
                LVPOS.SelectedItems[0].SubItems[6].Text = UDiscount.Value.ToString();

                subtext.Text = Convert.ToString((Convert.ToDouble(t_ans.Text) * Convert.ToDouble(UDiscount.Value.ToString())));
                totaldiscount.Text = Convert.ToString((Convert.ToDouble(t_ans.Text) - Convert.ToDouble(subtext.Text)));

                LVPOS.SelectedItems[0].SubItems[7].Text = totaldiscount.Text;
                LVPOS.SelectedItems[0].SubItems[8].Text = subtext.Text;
            }
            else if (ddisc1 == 0)
            {
                subtext.Text = uptotal.Text;

                LVPOS.SelectedItems[0].SubItems[7].Text = subtext.Text;
                LVPOS.SelectedItems[0].SubItems[8].Text = UDiscount.Value.ToString();
            }
        }

        private void up_qtyforup()
        {

            string sql1 = "UPDATE drug SET  stockQty='" + sqty.Text + "'  WHERE ItemID=" + qty_del.Text + " ";

            connection.Open();

            Cmd = new MySqlCommand(sql1, connection);


            try
            {
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("data is now updated");
                }
                else
                {
                    //MessageBox.Show("data is not updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();


        }

        void clickmeupdate()
        {
            if (titemname.Text == "Item name")
            {
                MessageBox.Show("Select atleast 1 item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                disableBtn();
                panel6.SendToBack();

                LVPOS.SendToBack();
                pinpanel.Visible = false;
                dpanel.Visible = false;

                pupdate1.Visible = true;
                pupdate1.BringToFront();

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clickmeupdate();
        }


        //dfasdfas

        int selectedQty;

        private void LVPOS_MouseClick(object sender, MouseEventArgs e)
        {
            qty_del.Text = LVPOS.SelectedItems[0].SubItems[0].Text;

            ditem.Text = LVPOS.SelectedItems[0].SubItems[1].Text;
            titemname.Text = LVPOS.SelectedItems[0].SubItems[1].Text;

            unitcost.Text = LVPOS.SelectedItems[0].SubItems[3].Text;

            upqty.Text = LVPOS.SelectedItems[0].SubItems[4].Text;
            upqty2.Text = LVPOS.SelectedItems[0].SubItems[4].Text;

            t_ans.Text = LVPOS.SelectedItems[0].SubItems[5].Text;

            UDiscount.Text = LVPOS.SelectedItems[0].SubItems[6].Text;
            textdisc.Text = LVPOS.SelectedItems[0].SubItems[6].Text;

            subtext.Text = LVPOS.SelectedItems[0].SubItems[7].Text;

            disclast.Text = LVPOS.SelectedItems[0].SubItems[8].Text;

            retrieveStock();
            selectedQty = int.Parse(LVPOS.SelectedItems[0].SubItems[4].Text);


        }

        private void upqty2_Leave(object sender, EventArgs e)
        {
            if (upqty2.Text == "")
            {
                upqty2.Text = "0";
                upqty2.ForeColor = Color.Green;
            }
        }

        private void upqty2_Enter(object sender, EventArgs e)
        {
            if (upqty2.Text == "0")
            {
                upqty2.Text = "";
                upqty2.ForeColor = Color.Green;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void tAmt_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {

                connection.Close();
                connection.Open();

                Cmd = new MySqlCommand();

                Cmd.Connection = connection;


                Cmd.CommandText = "SELECT ItemID, ItemName,  brand, unit, price, stockQty, batchNo FROM drug WHERE ItemName LIKE '%" + search_tb.Text + "%' ";

                Adapter = new MySqlDataAdapter();

                Adapter.SelectCommand = Cmd;

                dt = new DataTable();

                Adapter.Fill(dt);

                itemlist.Items.Clear();
                foreach (DataRow r in dt.Rows)
                {

                    ListViewItem list = itemlist.Items.Add(r["ItemID"].ToString());
                    list.SubItems.Add(r["ItemName"].ToString());
                    list.SubItems.Add(r["brand"].ToString());
                    list.SubItems.Add(r["unit"].ToString());
                    list.SubItems.Add(r["price"].ToString());
                    list.SubItems.Add(r["stockQty"].ToString());
                    list.SubItems.Add(r["batchNo"].ToString());

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();

            connection.Close();

        }



        private void update_enter_Click(object sender, EventArgs e)
        {
            // update();
            upqty.Text = "0";
            upqty2.Text = "0";
        }




        private void upqty2_Enter_1(object sender, EventArgs e)
        {
            if (upqty2.Text == "0")
            {
                upqty2.Text = "";
                upqty2.ForeColor = Color.Green;
            }
        }

        private void upqty2_Leave_1(object sender, EventArgs e)
        {
            if (upqty2.Text == "")
            {
                upqty2.Text = "0";
                upqty2.ForeColor = Color.Green;
            }
        }


        private void upqty2_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                t_pincode.Focus();
                t_pincode.Text = "";



                t_pincode.isPassword = true;
                t_pincode.Focus();
                t_pincode.Text = "";

                if (upqty.Text == "0")
                {
                    MessageBox.Show("Select 1 item to update in item list!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pinpanel.Visible = true;
                }
            }

        }

        private void t_pincode_Enter(object sender, EventArgs e)
        {
            if (t_pincode.Text == "Pincode")
            {
                t_pincode.Text = "";
                t_pincode.ForeColor = Color.White;
                t_pincode.isPassword = true;
            }
        }

        private void t_pincode_Leave(object sender, EventArgs e)
        {
            if (t_pincode.Text == "")
            {
                t_pincode.Text = "Pincode";
                t_pincode.ForeColor = Color.White;
                t_pincode.isPassword = true;
            }
        }

        //============update_click

        private void update_enter_Click_1(object sender, EventArgs e)
        {
            string Password = t_pincode.Text.Trim();

            var pincode = Pin.login(Password);

            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill all given fields!");
            }
            else
            {
                if (Password == pincode.password)
                {
                    update();
                    //  MessageBox.Show("Quantity updated!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LVPOS.BringToFront();
                    t_pincode.Text = "Pincode";
                    t_pincode.isPassword = false;

                    totalConsumeItem1();
                    ConsumeItemUpdate();

                    upqty.Text = "0";
                    upqty2.Text = "0";
                    pupdate1.SendToBack();
                    pinpanel.SendToBack();


                    LVPOS.BringToFront();


                    //clear
                    upqty.Text = "0";
                    upqty2.Text = "0";
                    enableBtn();

                }
                else
                {
                    MessageBox.Show("Oops! Wrong Password .", "Hint", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void tpincode2_Enter(object sender, EventArgs e)
        {
            if (t_pincode.Text == "Pincode")
            {
                tpincode2.Text = "";
                tpincode2.ForeColor = Color.White;
                tpincode2.isPassword = true;
            }
        }

        private void tpincode2_Leave(object sender, EventArgs e)
        {
            if (t_pincode.Text == "")
            {
                tpincode2.Text = "Pincode";
                tpincode2.ForeColor = Color.White;
                tpincode2.isPassword = true;
            }
        }
        //========del_click
        private void btndel_Click(object sender, EventArgs e)
        {
            string Password = tpincode2.Text.Trim();

            var pincode = Pin.login(Password);

            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill all given fields!");
            }
            else
            {
                if (Password == pincode.password)
                {
                    delete();


                    //function for delete consumed
                    ConsumeItemDelete();


                    //MessageBox.Show("Item Deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //cpanel.Visible = true;
                    tpincode2.Text = "Pincode";
                    tpincode2.isPassword = false;
                    dpanel.SendToBack();

                    LVPOS.BringToFront();
                    enableBtn();

                }
                else
                {
                    MessageBox.Show("Oops! Wrong Password .", "Hint", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
        //==========deleted_enter
        private void tpincode2_KeyDown(object sender, KeyEventArgs e)
        {
            if (tpincode2.Text == null)
            {
                tpincode2.Text = "Password";
                tpincode2.ForeColor = Color.Silver;
            }

            if (e.KeyCode == Keys.Enter)
            {
                string Password = tpincode2.Text.Trim();

                var pincode = Pin.login(Password);

                if (String.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Please fill all given fields!");
                }
                else
                {
                    if (Password == pincode.password)
                    {
                        delete();
                        // MessageBox.Show("Item Deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        //function for delete consumed
                        ConsumeItemDelete();


                        tpincode2.Text = "Pincode";
                        tpincode2.isPassword = false;

                        dpanel.SendToBack();

                        LVPOS.BringToFront();
                        //clear
                        // upqty.Text = "0";
                        // upqty2.Text = "0";

                    }
                    else
                    {
                        MessageBox.Show("Oops! Wrong Password .", "Hint", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //===========update_enter
        private void t_pincode_KeyDown(object sender, KeyEventArgs e)
        {
            if (t_pincode.Text == null)
            {
                t_pincode.Text = "Password";
                t_pincode.ForeColor = Color.Silver;
            }

            if (e.KeyCode == Keys.Enter)
            {
                string Password = t_pincode.Text.Trim();

                var pincode = Pin.login(Password);

                if (String.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Please fill all given fields!");
                }
                else
                {
                    if (Password == pincode.password)
                    {
                        update();
                        //MessageBox.Show("Quantity updated!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LVPOS.BringToFront();
                        t_pincode.Text = "Pincode";
                        t_pincode.isPassword = false;
                        totalConsumeItem1();
                        ConsumeItemUpdate();

                        upqty.Text = "0";
                        upqty2.Text = "0";


                        pupdate1.SendToBack();
                        pinpanel.SendToBack();

                        LVPOS.BringToFront();

                        //clear
                        upqty.Text = "0";
                        upqty2.Text = "0";

                    }
                    else
                    {
                        MessageBox.Show("Oops! Wrong Password .", "Hint", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tAmt_Leave(object sender, EventArgs e)
        {
            if (tAmt.Text == "")
            {
                tAmt.Text = "0.00";
            }
        }

        private void tAmt_Enter(object sender, EventArgs e)
        {
            if (tAmt.Text == "0.00")
            {
                tAmt.Text = "";

            }
        }

        private void search_tb_Enter(object sender, EventArgs e)
        {
            if (search_tb.Text == "search")
            {
                search_tb.Text = "";

            }
        }

        private void search_tb_Leave(object sender, EventArgs e)
        {
            if (search_tb.Text == "")
            {
                search_tb.Text = "search";

                itemlist.Items.Clear();
                retrive();
            }

        }




        private void upqty2_KeyDown_1(object sender, KeyEventArgs e)
        {

            int qty = int.Parse(upqty.Text);
            int qty2 = int.Parse(upqty2.Text);



            if (e.KeyCode == Keys.Enter)
            {
                if (upqty.Text == "0" || upqty2.Value == 0)
                {
                    MessageBox.Show("Please, Do not Enter 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    t_pincode.Focus();
                    t_pincode.Text = "";



                    t_pincode.isPassword = true;
                    t_pincode.Focus();
                    t_pincode.Text = "";
                    pinpanel.Visible = true;
                    pinpanel.BringToFront();
                }
            }
        }



        //writetoCodelater


        string iid;
        double ucost = 0;
        int qty = 0;
        string iname;
        double sdisc;
        double sdiscp;
        double totaldb;
        double stotaldb;




        private void btn_print_Click(object sender, EventArgs e)
        {
            if (tbigtotal.Text == "Total")
            {
                MessageBox.Show("There is no selected Items", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {


                if (MessageBox.Show("Save the current transaction?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    double moretotal = Convert.ToDouble(tbigtotal.Text);
                    double lesstotal = Convert.ToDouble(tAmt.Text);

                  
                        if (tchange.Text == "0.00")
                        {
                            MessageBox.Show("Fill the tendered given field", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            for (int i = 0; i < LVPOS.Items.Count; i++)
                            {
                                // ConsumeItem();


                                iid = LVPOS.Items[i].SubItems[0].Text;//ok
                                iname = Convert.ToString(LVPOS.Items[i].SubItems[1].Text);//ok
                                ucost = Convert.ToDouble(LVPOS.Items[i].SubItems[3].Text);//ok
                                qty = Convert.ToInt32(LVPOS.Items[i].SubItems[4].Text);//ok
                                sdisc = Convert.ToDouble(LVPOS.Items[i].SubItems[8].Text);
                                sdiscp = Convert.ToDouble(LVPOS.Items[i].SubItems[6].Text);
                                totaldb = Convert.ToDouble(LVPOS.Items[i].SubItems[5].Text);
                                stotaldb = Convert.ToDouble(LVPOS.Items[i].SubItems[7].Text);//ok


                                connection.Open();

                                Cmd = new MySqlCommand("INSERT into transaction (cashier_name, PO_id, pro_id, item, cost, qty,discount_amt, transaction_date, dispercent, total, subtotal)"
                                    + "values('" + lUsername.Text + "','" + pid.Text + "','" + iid + "','" + iname + "','" + ucost + "','" + qty + "' , '" + sdisc + "', '" + atime.Text + "', '" + sdiscp + "', '" + totaldb + "', '" + stotaldb + "'  )", connection);

                                MySqlCommand Cmd1 = new MySqlCommand("INSERT into order_line (POnum, ItemID, Orderqty, UnitCost, Discount)"
                                   + "values('" + pid.Text + "','" + iid + "','" + qty + "','" + ucost + "','" + sdisc + "' )", connection);


                                // MySqlDataReader myReader;
                                try
                                {
                                    if (Cmd.ExecuteNonQuery() == 1 && Cmd1.ExecuteNonQuery() == 1)
                                    {
                                        //MessageBox.Show("data is Saved");

                                    }

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                connection.Close();
                            }

                            connection.Open();

                            Cmd = new MySqlCommand("INSERT into sales_report (transactionNum, totalqty, total, subtotal, discpercent,  discount_amount, Date, time,  cashier)"
                            + "values('" + pid.Text + "','" + titems.Text + "','" + tbigtotal.Text + "','" + bottompanel.Text + "','" + tdiscount.Text + "' , '" + discamt + "', '" + atime.Text + "', '" + ldate.Text + "', '" + lUsername.Text + "')", connection);

                            MySqlCommand Cmd2 = new MySqlCommand("INSERT into porder (POnum, ItemID, ChargeRef, OrderDate)"
                            + "values('" + pid.Text + "','" + iid + "','" + lUsername.Text + "','" + atime.Text + "')", connection);

                            // MySqlDataReader myReader;
                            try
                            {
                                if (Cmd.ExecuteNonQuery() == 1 && Cmd2.ExecuteNonQuery() == 1)
                                {
                                    //MessageBox.Show("data is Saved");
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }



                            connection.Close();

                            postId();
                            titems.Text = "0";
                            bottompanel.Text = "0";
                            tdiscount.Text = "0";
                            tAmt.Text = "0";
                            tchange.Text = "0";
                            tbigtotal.Text = "Total";
                            ndisc.Text = "0.00";
                            LVPOS.Items.Clear();



                            Cursor.Current = Cursors.WaitCursor;

                            //new printReceipt(lUsername.Text, timein.Text, pid.Text).ShowDialog();
                            pdone.SendToBack();
                            pdone.Visible = false;

                            this.KeyPreview = true;
                            btnsearch.Enabled = true;
                            btnremove.Enabled = true;
                            btnUpdate.Enabled = true;
                            btn_return.Enabled = true;
                            btndone.Enabled = true;
                            btndone.Enabled = true;
                            btn_log.Enabled = true;
                            logout.Enabled = true;
                            btn_charge.Enabled = true;
                        }

                        
                   

                    

                    //save the transaction line

                }
                else
                {
                    MessageBox.Show("Transaction not save!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }


        }





        private void nqty_Enter(object sender, EventArgs e)
        {
            if (nqty.Text == "0")
            {
                nqty.Text = "";

            }
        }

        private void nqty_Leave(object sender, EventArgs e)
        {
            if (nqty.Text == "")
            {
                nqty.Text = "0";

            }
        }



        private void btn_charge_Click(object sender, EventArgs e)
        {


            if (tbigtotal.Text == "Total")
            {
                MessageBox.Show("You have to select Atleast 1 Item from Search button", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                gbCharge.BringToFront();
                gbCharge.Visible = true;

                invoice_no.Text = pid.Text;
                finalamt.Text = tbigtotal.Text;

                //disable the all button
                this.KeyPreview = false;
                btnsearch.Enabled = false;
                btnremove.Enabled = false;
                btnUpdate.Enabled = false;
                btn_return.Enabled = false;
                btndone.Enabled = false;
                btndone.Enabled = false;
                btn_log.Enabled = false;
                logout.Enabled = false;
                btn_charge.Enabled = false;
            }
        }



        private void POS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                scape();//close
            }
            else if (e.KeyCode == Keys.F1)
            {
                viewpanel.BringToFront();
                backpinpanel.Visible = false;
                disableBtn();
                btndone.Enabled = false;
            }
            else if (e.KeyCode == Keys.F2)
            {
                remove();

            }
            else if (e.KeyCode == Keys.F3)
            {
                clickmeupdate();

            }
            else if (e.KeyCode == Keys.F4)
            {
                rturn();

            }
        }

        private void btn_done_Click(object sender, EventArgs e)
        {

            btnsearch.Enabled = true;
            btnremove.Enabled = true;
            btnUpdate.Enabled = true;
            btn_print.Enabled = true;
            //  btn_discount.Enabled = true;
            btn_charge.Enabled = true;

            pcharge.Visible = false;
        }

        void rturn()
        {
            // disableBtn();

            returnMedicine rM = new returnMedicine(lUsername);
            rM.ShowDialog();

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            rturn();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UDiscount_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                if (textdisc.Text == "0")
                {
                    MessageBox.Show("Please, Do not Enter 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    t_pincode.Focus();
                    t_pincode.Text = "";



                    t_pincode.isPassword = true;
                    t_pincode.Focus();
                    t_pincode.Text = "";
                    pinpanel.Visible = true;
                    pinpanel.BringToFront();
                }
            }
        }

        private void update_enter_KeyDown(object sender, KeyEventArgs e)
        {
            // pinpanel.SendToBack();
            pinpanel.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            pupdate1.Visible = false;
            enableBtn();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            pinpanel.Visible = false;
            enableBtn();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            dpanel.Visible = false;
            enableBtn();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (upqty2.Value == 0)
            {
                MessageBox.Show("Do not enter no. 0!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void clr()
        {
            titemname.Text = "Item name";
            ditem.Text = "Item name";
            upqty.Text = "0";
            upqty2.Value = 0;
            textdisc.Text = "0";
            UDiscount.Value = 0;
            ndisc.Value = 0;
            nqty.Value = 0;
        }

        private void release_Click(object sender, EventArgs e)
        {
            viewpanel.Visible = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            viewpanel.BringToFront();
        }

        private void closeme_Click(object sender, EventArgs e)
        {
            viewpanel.SendToBack();
            enableBtn();
            this.KeyPreview = true;
            btndone.Enabled = true;
        }

        void disableBtn()
        {
            btnsearch.Enabled = false;
            btnremove.Enabled = false;
            btnUpdate.Enabled = false;
            btn_return.Enabled = false;
            btn_print.Enabled = false;
            btn_charge.Enabled = false;
            btn_log.Enabled = false;

        }

        void enableBtn()
        {
            btnsearch.Enabled = true;
            btnremove.Enabled = true;
            btnUpdate.Enabled = true;
            btn_return.Enabled = true;
            btn_print.Enabled = true;
            btn_charge.Enabled = true;
            btn_log.Enabled = true;
        }

        void welcome()
        {
            MessageBox.Show("Welcome Cashier: " + lUsername.Text + " ", "GREETINGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_reprice_Click(object sender, EventArgs e)
        {
            //  new printReceipt(lUsername.Text, timein.Text, pid.Text).ShowDialog();

            log_form showmehistory = new log_form(lUsername);
            showmehistory.ShowDialog();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void close_Click(object sender, EventArgs e)
        {
            gbCharge.SendToBack();
            gbCharge.Visible = false;


            //enable the all button
            this.KeyPreview = true;
            btnsearch.Enabled = true;
            btnremove.Enabled = true;
            btnUpdate.Enabled = true;
            btn_return.Enabled = true;
            btndone.Enabled = true;
            btndone.Enabled = true;
            btn_log.Enabled = true;
            logout.Enabled = true;

            btn_charge.Enabled = true;
        }

        private void pname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                t_pincode.Focus();
                nurse.Text = "";
            }

        }

        private void room_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nurse_KeyDown(object sender, KeyEventArgs e)
        {
            //condition for save
        }

        private void btndone_Click(object sender, EventArgs e)
        {


            if (tbigtotal.Text == "Total")
            {
                MessageBox.Show("Select Item First", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Are you sure??", "DONE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    pdone.BringToFront();

                    this.KeyPreview = false;
                    btnsearch.Enabled = false;
                    btnremove.Enabled = false;
                    btnUpdate.Enabled = false;
                    btn_return.Enabled = false;
                    btndone.Enabled = false;
                    btn_charge.Enabled = false;
                    btn_log.Enabled = false;

                    logout.Enabled = false;

                }
                else
                {
                    ///not show
                }
            }


        }


        private void btnback_Click(object sender, EventArgs e)
        {

            gbCharge.Visible = false;

            viewpanel.SendToBack();
            pinpanel.SendToBack();
            pupdate1.SendToBack();

            LVPOS.SendToBack();
            pinpanel.Visible = false;
            dpanel.Visible = false;
            pdone.BringToFront();
            backpinpanel.BringToFront();
            backpinpanel.Visible = true;

        }

        private void tbbackpin_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbbackpin.Text == null)
            {
                tbbackpin.Text = "Password";
                tbbackpin.ForeColor = Color.Silver;
            }

            if (e.KeyCode == Keys.Enter)
            {
                string Password = tbbackpin.Text.Trim();

                var pincode = Pin.login(Password);

                if (String.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Please fill all given fields!");
                }
                else
                {
                    if (Password == pincode.password)
                    {

                        // MessageBox.Show("Item Deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        tbbackpin.Text = "Pincode";
                        tbbackpin.isPassword = false;
                        //enable all buttons

                        backpinpanel.SendToBack();
                        pdone.SendToBack();

                        this.KeyPreview = true;
                        btnsearch.Enabled = true;
                        btnremove.Enabled = true;
                        btnUpdate.Enabled = true;
                        btn_return.Enabled = true;
                        btndone.Enabled = true;
                        btn_charge.Enabled = true;
                        btn_log.Enabled = true;

                        logout.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Oops! Wrong Password .", "Hint", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnbackpin_Click(object sender, EventArgs e)
        {
            if (tbbackpin.Text == null)
            {
                tbbackpin.Text = "Password";
                tbbackpin.ForeColor = Color.Silver;
            }


            string Password = tbbackpin.Text.Trim();

            var pincode = Pin.login(Password);

            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill all given fields!");
            }
            else
            {
                if (Password == pincode.password)
                {

                    // MessageBox.Show("Item Deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    tbbackpin.Text = "Pincode";
                    tbbackpin.isPassword = false;
                    //enable all buttons

                    backpinpanel.SendToBack();
                    pdone.SendToBack();

                    this.KeyPreview = true;
                    btnsearch.Enabled = true;
                    btnremove.Enabled = true;
                    btnUpdate.Enabled = true;
                    btn_return.Enabled = true;
                    btndone.Enabled = true;
                    btn_charge.Enabled = true;
                    btn_log.Enabled = true;

                    logout.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Oops! Wrong Password .", "Hint", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }

        }

        private void tbbackpin_Enter(object sender, EventArgs e)
        {
            if (tbbackpin.Text == "Pincode")
            {
                tbbackpin.Text = "";
                tbbackpin.ForeColor = Color.White;
                tbbackpin.isPassword = true;
            }
        }

        private void tbbackpin_Leave(object sender, EventArgs e)
        {
            if (tbbackpin.Text == "")
            {
                tbbackpin.Text = "Pincode";
                tbbackpin.ForeColor = Color.White;
                tbbackpin.isPassword = true;
            }
        }



        private void btn_done_Click_1(object sender, EventArgs e)
        {

            //if (titems.Text != "0")
            //{
            if (tbigtotal.Text == "Total")
            {
                MessageBox.Show("There is no selected Items", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //    try
                //  {
                if (pname.Text == "" && nurse.Text == "" && nup_roomnum.Value == 0)
                {
                    MessageBox.Show("The Patient name, Room no. and Nurse name fields are all required to fill in", "REQUIRED!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("All items will save in In patient logs, Continue?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {


                        //save the transaction line
                        for (int i = 0; i < LVPOS.Items.Count; i++)
                        {
                            // ConsumeItem();


                            iid =LVPOS.Items[i].SubItems[0].Text;//ok
                            iname = Convert.ToString(LVPOS.Items[i].SubItems[1].Text);//ok
                            ucost = Convert.ToDouble(LVPOS.Items[i].SubItems[3].Text);//ok
                            qty = Convert.ToInt32(LVPOS.Items[i].SubItems[4].Text);//ok
                            sdisc = Convert.ToDouble(LVPOS.Items[i].SubItems[8].Text);
                            sdiscp = Convert.ToDouble(LVPOS.Items[i].SubItems[6].Text);
                            totaldb = Convert.ToDouble(LVPOS.Items[i].SubItems[5].Text);
                            stotaldb = Convert.ToDouble(LVPOS.Items[i].SubItems[7].Text);//ok


                            connection.Open();

                            Cmd = new MySqlCommand("INSERT into transaction (cashier_name, PO_id, pro_id, item, cost, qty,discount_amt, transaction_date, dispercent, total, subtotal)"
                                + "values('" + lUsername.Text + "','" + pid.Text + "','" + iid + "','" + iname + "','" + ucost + "','" + qty + "' , '" + sdisc + "', '" + atime.Text + "', '" + sdiscp + "', '" + totaldb + "', '" + stotaldb + "'  )", connection);

                            MySqlCommand Cmd1 = new MySqlCommand("INSERT into order_line (POnum, ItemID, Orderqty, UnitCost, Discount)"
                               + "values('" + pid.Text + "','" + iid + "','" + qty + "','" + ucost + "','" + sdisc + "' )", connection);


                            // MySqlDataReader myReader;
                            try
                            {
                                if (Cmd.ExecuteNonQuery() == 1 && Cmd1.ExecuteNonQuery() == 1)
                                {
                                    //MessageBox.Show("data is Saved");

                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            connection.Close();
                        }

                        connection.Open();

                        Cmd = new MySqlCommand("INSERT into sales_report (transactionNum, totalqty, total, subtotal, discpercent,  discount_amount, Date, time,  cashier)"
                       + "values('" + pid.Text + "','" + titems.Text + "','" + tbigtotal.Text + "','" + bottompanel.Text + "','" + tdiscount.Text + "' , '" + discamt + "', '" + atime.Text + "', '" + ldate.Text + "', '" + lUsername.Text + "')", connection);

                        MySqlCommand Cmd2 = new MySqlCommand("INSERT into porder (POnum, ItemID, ChargeRef, OrderDate)"
                       + "values('" + pid.Text + "','" + iid + "','" + lUsername.Text + "','" + atime.Text + "')", connection);

                        MySqlCommand Cmd3 = new MySqlCommand("INSERT into charge (invoice_no, patientName, RoomNo, Bill, nurse)"
                       + "values('" + pid.Text + "','" + pname.Text + "','" + nup_roomnum.Text + "','" + tbigtotal.Text + "', '" + nurse.Text + "')", connection);

                        // MySqlDataReader myReader;
                        try
                        {
                            if (Cmd.ExecuteNonQuery() == 1 && Cmd2.ExecuteNonQuery() == 1 && Cmd3.ExecuteNonQuery() == 1)
                            {
                                //MessageBox.Show("data is Saved");

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }



                        connection.Close();

                        postId();
                        titems.Text = "0";
                        bottompanel.Text = "0";
                        tdiscount.Text = "0";
                        tAmt.Text = "0";
                        tchange.Text = "0";
                        tbigtotal.Text = "Total";
                        ndisc.Text = "0.00";
                        LVPOS.Items.Clear();



                        Cursor.Current = Cursors.WaitCursor;
                        //new printReceipt(lUsername.Text, timein.Text, pid.Text).ShowDialog();

                        this.KeyPreview = true;
                        btnsearch.Enabled = true;
                        btnremove.Enabled = true;
                        btnUpdate.Enabled = true;
                        btn_return.Enabled = true;
                        btndone.Enabled = true;
                        btndone.Enabled = true;
                        btn_log.Enabled = true;
                        logout.Enabled = true;
                        btn_charge.Enabled = true;


                    }
                    else
                    {
                        MessageBox.Show("Transaction not save! All transactions need to be save", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                //     }
                //     catch(Exception)
                //     {
                //         MessageBox.Show("Click me again, When you are sure!");

            }
            //}
            //else
            //{
            //    MessageBox.Show("There is no selected Items", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}


        }

        private void nup_roomnum_Enter(object sender, EventArgs e)
        {

        }

        private void nup_roomnum_Leave(object sender, EventArgs e)
        {

        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            backpinpanel.SendToBack();
        }

        private void btn_notif_Click(object sender, EventArgs e)
        {
            p_notification.BringToFront();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            p_notification.SendToBack();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = true;
            this.Show();
        }


      

        private void tAmt_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tAmt.Text, "  ^ [0-9]"))
            {
                tAmt.Text = "";
            }
        }

        private void tAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tAmt_Enter_1(object sender, EventArgs e)
        {
            if (tAmt.Text == "0.00")
            {
                tAmt.Text = "";

            }
        }

        private void tAmt_Leave_1(object sender, EventArgs e)
        {
            if (tAmt.Text == "")
            {
                tAmt.Text = "0.00";
            }
        }

        private void tAmt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (tAmt.Text == null)
            {
                tAmt.Text = "Password";
                tAmt.ForeColor = Color.Silver;
            }

                if (e.KeyCode == Keys.Enter)
                {
               
                       double moretotal = Convert.ToDouble(tbigtotal.Text);
                       double lesstotal = Convert.ToDouble(tAmt.Text);

                        if (moretotal > lesstotal)
                        {
                            MessageBox.Show("You must fill the exact or more than the net total amount", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {

                               Cursor.Current = Cursors.WaitCursor;

                                double computeChange = Double.Parse(tAmt.Text) - Double.Parse(tbigtotal.Text);

                                tchange.Text = Convert.ToString(computeChange);

                                tbchange2.Text = tchange.Text;
                                Double change;
                                Double.TryParse(tchange.Text, out change);
                                tchange.Text = change.ToString(".00");
                    

                        }


                }
            }

        private void logout_MouseClick(object sender, MouseEventArgs e)
        {
            scape();
        }
    }
 }
