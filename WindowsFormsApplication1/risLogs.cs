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
    public partial class risLogs : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=mahesecoinventory; port= 3306; username=root;password=");

        private MySqlDataAdapter Adapter;
        private DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private MySqlCommand Cmd;

        MySqlDataReader Reader;

        private string un;
        public risLogs(Label uname)
        {
            InitializeComponent();

            un = uname.Text;
            lbl_username1.Text = un.ToString();
        }

        private void risLogs_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string MySQLFormatDate = date.ToString("yyyy-MM-dd");
            atime1.Text = MySQLFormatDate.ToString();

            Cursor.Current = Cursors.WaitCursor;
            try
            {

                Adapter = new MySqlDataAdapter("SELECT * FROM ris_logs WHERE risdate = '" + atime1.Text + "' ORDER BY ris_num desc;", connection);
                ds.Reset();
                Adapter.Fill(ds);

                LVLogsPO.Items.Clear();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        LVLogsPO.Items.Add(ds.Tables[0].Rows[i]["risno"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ponum"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["itemnum"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risitem"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risunit"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["risqty"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["ending"].ToString());
                        LVLogsPO.Items[LVLogsPO.Items.Count - 1].SubItems.Add(ds.Tables[0].Rows[i]["department"].ToString());
                 

                    }

                    if (!System.IO.Directory.Exists(@"C:\ProgramData\Crystal_Report_Data_Source"))
                    {
                        System.IO.Directory.CreateDirectory(@"C:\ProgramData\Crystal_Report_Data_Source");
                    }

                    ds.WriteXml(@"C:\ProgramData\Crystal_Report_Data_Source\TodayHistoryLogsForRis.xml");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Adapter.Dispose();
            connection.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Crystal_report_HistoryLogs.risForm getreport = new Crystal_report_HistoryLogs.risForm();

            getreport.ShowDialog();
        }
    }
}
