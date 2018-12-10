using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRIGHTSIDE_IDEA_POS
{
    public partial class PurchaseOrderLogs : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=mahesecoinventory; port= 3306; username=root;password=");

        private MySqlDataAdapter Adapter;
        private DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private MySqlCommand Cmd;

        MySqlDataReader Reader;

        private string un;
        public PurchaseOrderLogs(Label uname)
        {
            InitializeComponent();

            un = uname.Text;

            lbl_username.Text = un.ToString();
        }

        private void PurchaseOrderLogs_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy-MM-dd");
            atime.Text = MySQLFormatDate.ToString();

            Cursor.Current = Cursors.WaitCursor;
            try
            {

                Adapter = new MySqlDataAdapter("SELECT * FROM purchase_order_logs WHERE Date = '" + atime.Text + "' ORDER BY numid desc;", connection);
                ds.Reset();
                Adapter.Fill(ds);

                LVLogsPO.Items.Clear();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        LVLogsPO.Items.Add(ds.Tables[0].Rows[i]["item_num"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["poitem"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["pounit"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["pounitprice"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["poqty1"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["poamount"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["posupplier"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["po_reorderedlvl"].ToString());
                        
                    }

                    if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                    {
                        System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                    }

                    ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\TodayHistoryLogsForPO.xml");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();
            connection.Close();
        }

        private void btnprnit_Click(object sender, EventArgs e)
        {
           
            Cursor.Current = Cursors.WaitCursor;
            Crystal_report_HistoryLogs.purchaseOrderform getreport = new Crystal_report_HistoryLogs.purchaseOrderform();
            
            getreport.ShowDialog();
        }
    }
}
