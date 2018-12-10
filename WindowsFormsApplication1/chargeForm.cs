using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Timers;


namespace BRIGHTSIDE_IDEA_POS
{

   
    public partial class chargeForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=maheseco; port= 3306; username=root;password=");

        private MySqlDataAdapter Adapter;
        private DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private MySqlCommand Cmd;

        MySqlDataReader Reader;



        public chargeForm()
        {
            InitializeComponent();
            autoComplete1();
        }

        private void tb_searchPatient_TextChanged(object sender, EventArgs e)
        {

        }

        void autoComplete1()
        {
            tb_searchPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb_searchPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection colll = new AutoCompleteStringCollection();

            try
            {
                string sql = "SELECT * FROM charge";
                Cmd = new MySqlCommand(sql, connection);
                connection.Open();

                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {

                    string item2 = Reader.GetString("patientName");
                    colll.Add(item2);

                }

                connection.Close();

            }
            catch
            {

            }
            tb_searchPatient.AutoCompleteCustomSource = colll;
        }

        private void tb_searchPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    // MySqlCommand command = new MySqlCommand();
                    connection.Open();

                    Cmd = new MySqlCommand();

                    Cmd.Connection = connection;


                    Cmd.CommandText = "SELECT * FROM charge WHERE patientName LIKE '%" + tb_searchPatient.Text + "%' ";

                    Adapter = new MySqlDataAdapter();

                    Adapter.SelectCommand = Cmd;

                    dt = new DataTable();

                    Adapter.Fill(dt);

                    listView1.Items.Clear();
                    foreach (DataRow r in dt.Rows)
                    {

                        ListViewItem list = listView1.Items.Add(r["invoice_no"].ToString());
                        list.SubItems.Add(r["patientName"].ToString());
                        list.SubItems.Add(r["RoomNo"].ToString());
                        list.SubItems.Add(r["Bill"].ToString());
                        list.SubItems.Add(r["nurse"].ToString());
                       
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
}
