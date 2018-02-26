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
    public partial class log_form : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=maheseco; port= 3306; username=root;password=");


        private MySqlDataAdapter Adapter;
        private DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private MySqlCommand Cmd;

        MySqlDataReader Reader;

        private string un;

        public log_form(Label uname)
        {
            InitializeComponent();

            un = uname.Text;

            lbl_username.Text = un.ToString();
        }

        private void log_form_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy-MM-dd");
            atime.Text = MySQLFormatDate.ToString();


            Cursor.Current = Cursors.WaitCursor;
            try
            {

                Adapter = new MySqlDataAdapter("SELECT * FROM transaction WHERE transaction_date = '" + atime.Text + "' ;", connection);
                ds.Reset();
                Adapter.Fill(ds);

                LVLogs.Items.Clear();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        LVLogs.Items.Add(ds.Tables[0].Rows[i]["cashier_name"].ToString());
                        LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["PO_id"].ToString());
                        LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["item"].ToString());
                        LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["cost"].ToString());
                        LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["qty"].ToString());
                        LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["discount_amt"].ToString());
                        LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["total"].ToString());
                        LVLogs.Items[LVLogs.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["subtotal"].ToString());
                    }

                    if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                    {
                        System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                    }

                    ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\TodayHistoryLogs.xml");
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();
            connection.Close();
                                   
        }


        int totalrmed;
        void rMed_total()
        {
            double ColumnAvg = 0;

            for (int i = 0; i < LVLogs.Items.Count; i++)
            {
                ColumnAvg += double.Parse(LVLogs.Items[i].SubItems[7].Text);
            }

            totalrmed = Convert.ToInt32(ColumnAvg.ToString());
            //totalrmed = ColumnAvg.ToString();

        }

        
        private void btnprnit_Click(object sender, EventArgs e)
        {

            rMed_total();

            Cursor.Current = Cursors.WaitCursor;

                ReportTodaysLog showme = new ReportTodaysLog(totalrmed);

                showme.ShowDialog();


        }
    }
}
