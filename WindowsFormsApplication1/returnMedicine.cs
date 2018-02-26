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

namespace WindowsFormsApplication1
{

   
    public partial class returnMedicine : Form
    {
         

        MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=maheseco; port= 3306; username=root;password=");

        private MySqlDataAdapter Adapter;
        private DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private MySqlCommand Cmd;

        MySqlDataReader Reader;


        public returnMedicine()
        {
            InitializeComponent();
            itemname.Enabled = false;

            fillcombo();

            qty.Enabled = false;
        }

        

        private void rsearch_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void item_Enter(object sender, EventArgs e)
        {

        }

        private void item_Leave(object sender, EventArgs e)
        {

        }


        

        private void cinvoice_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {

                // MySqlCommand command = new MySqlCommand();
                //connection.Open();

                Cmd = new MySqlCommand();

                Cmd.Connection = connection;

                //Cmd.CommandText = "SELECT transaction.qty, transaction.cost, transaction.transaction_date, transaction.cashier_name, drug.ItemName  FROM transaction join drug on drug.ItemID = PO_id WHERE transaction.PO_id LIKE '%" + cinvoice.Text + "%'  ";
                //Cmd.CommandText = "SELECT * FROM transaction WHERE ItemName LIKE '%" + cinvoice.Text + "%' ";
                Cmd.CommandText = "SELECT transaction.pro_id, transaction.qty, transaction.cost, transaction.transaction_date, transaction.cashier_name, transaction.item FROM transaction WHERE PO_id LIKE '%" + cinvoice.Text + "%'  ";
                Adapter = new MySqlDataAdapter();

                Adapter.SelectCommand = Cmd;

                dt = new DataTable();

                Adapter.Fill(dt);

                LVreturn.Items.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    ListViewItem list = LVreturn.Items.Add(r["pro_id"].ToString());
                    list.SubItems.Add(r["item"].ToString());
                    list.SubItems.Add(r["qty"].ToString());
                    list.SubItems.Add(r["cost"].ToString());
                    list.SubItems.Add(r["transaction_date"].ToString());
                    list.SubItems.Add(r["cashier_name"].ToString());

                }

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            

            connection.Close();
        }

      

        private void returnMedicine_Load(object sender, EventArgs e)
        {
            
        }

        void fillcombo()
        {
            Cmd = new MySqlCommand("SELECT DISTINCT PO_id from transaction ORDER BY PO_id ", connection);
            

            try
            {
                connection.Open();
                Reader = Cmd.ExecuteReader();


                while (Reader.Read())
                {
                    string sid = Reader.GetString("PO_id");
                    cinvoice.Items.Add(sid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }


        int iid;
        double ucost;
        string datepur;
        string incashier;
       
        private void LVreturn_MouseClick(object sender, MouseEventArgs e)
        {
           

            iid = int.Parse(LVreturn.SelectedItems[0].SubItems[0].Text);
            itemname.Text = LVreturn.SelectedItems[0].SubItems[1].Text;
            qty.Text = LVreturn.SelectedItems[0].SubItems[2].Text;
            ucost = double.Parse(LVreturn.SelectedItems[0].SubItems[3].Text);
            diskarte.Text = LVreturn.SelectedItems[0].SubItems[4].Text;
            incashier = LVreturn.SelectedItems[0].SubItems[5].Text;

          
        }


        
        private void btn_return_Click(object sender, EventArgs e)
        {         
            int conqty = int.Parse(qty.Text);
            int editqty = int.Parse(TB_editable.Text);

            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy-MM-dd");
            datepur = MySQLFormatDate.ToString();

            if(conqty == 0)
            {
                MessageBox.Show("" + qty.Text + " is invalid input. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (editqty > conqty)
                {
                    MessageBox.Show("you exceed the available qty " + qty.Text + ". ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (editqty < 1)
                {
                    MessageBox.Show("" + TB_editable.Text + " no. of qty is invalid input. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.Open();

                    Cmd = new MySqlCommand("INSERT INTO medicinelogreturn (ItemId ,Item, qty, POnum, Incharge, Amount, DateReturn, datePurchased)"
                        + "VALUES('" + iid + "', '" + itemname.Text + "', '" + TB_editable.Text + "', '" + cinvoice.Text + "', '" + incashier + "', '" + ucost + "', '" + DP_dateReturn.Text + "', '" + diskarte.Text + "')", connection);

                    try
                    {
                        if (Cmd.ExecuteNonQuery() == 1)
                        {
                            //MessageBox.Show("data is Saved");

                            try
                            {

                                Cmd = new MySqlCommand("DELETE from maheseco.transaction where PO_id IN ('" + cinvoice.Text + "') && transaction.pro_id IN ('" + iid + "')", connection);
                                //Cmd.ExecuteNonQuery();

                                Reader = Cmd.ExecuteReader();
                                MessageBox.Show("The " + itemname.Text + " has returned.", "Medicine has", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                while (Reader.Read())
                                {
                                }
                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
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

        private void TB_editable_Enter(object sender, EventArgs e)
        {
            if (TB_editable.Value == 0)
            {
                TB_editable.Text = "";
               
                
            }
        }

        private void TB_editable_Leave(object sender, EventArgs e)
        {
            if (TB_editable.Value == 0)
            {
                TB_editable.Text = "0";
                               
            }
        }
    }
}
