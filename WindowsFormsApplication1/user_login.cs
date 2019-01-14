using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    

    public partial class mform : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=maheseco_inventory; port= 3306; username=root;password=");
        MySqlCommand Cmd;
        MySqlDataReader reader;


        public mform()
        {
            InitializeComponent();

        }

        void generatePassword()
        {
            string Username = textUsername1.Text.Trim();
            string Password = textPassword.Text.Trim();

            User user = new User();

            Cursor.Current = Cursors.WaitCursor;

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

                mform pt = null; //not create object
                pt = new mform();

                //if match
                if (Username == user.username && Password == user.password)
                {

                    if (user.position == "cashier")
                    {
                        getid.Text = user.pos_id;

                        string query1 = "SELECT * FROM user_information WHERE  user_id=" + getid.Text + " ";


                        Cmd = new MySqlCommand(query1, connection);

                        connection.Open();

                        //execute reader
                        reader = Cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            getid.Text = reader.GetString("firstname").ToString();

                            POS ca = new POS(getid.Text, atime.Text);
                            ca.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password", "Wrong", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            
                        }
                        reader.Close();

                        connection.Close();

                    }
                    else if (user.position == "admin")
                    {

                        getid.Text = user.pos_id;

                        string query1 = "SELECT * FROM user_information WHERE  user_id=" + getid.Text + " ";


                        Cmd = new MySqlCommand(query1, connection);

                        connection.Open();

                        //execute reader
                        reader = Cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            getid.Text = reader.GetString("firstname").ToString();

                            InventoryForm form = new InventoryForm(getid.Text, atime.Text);
                            form.Show();
                            this.Hide();

                        }
                        else
                        {

                            MessageBox.Show("Wrong Username or Password", "Wrong", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            
                        }
                        reader.Close();

                        connection.Close();


                    }


                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    textPassword.Text = "";
                    if (textPassword.Text == "")
                    {
                        lblhint.Visible = true;
                    }
                    else
                    {
                        lblhint.Visible = false;
                    }
                    
                }
            }
        }


        private void mform_Load(object sender, EventArgs e)
        {
            Database.Open();
            atime.Visible = false;
            tick.Start();
         }

        private void Blog_Click(object sender, EventArgs e)
        {
            generatePassword();
        }

        private void bclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bminimize2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bclose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bminimize1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void cshow_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cshow.Checked == true)
            {
                textPassword.isPassword = false;
            }
            else if(cshow.Checked == false)
            {
                textPassword.isPassword = true;
            }
        }

      
        private void textPassword_Click(object sender, EventArgs e)
        {
            
            textPassword.isPassword = true;
        }

        private void textUsername1_Enter(object sender, EventArgs e)
        {    

            if (textUsername1.Text == "Username")
            {
                textUsername1.Text = "";
                textUsername1.ForeColor = Color.Silver;
            }
        }

        private void textUsername1_Leave(object sender, EventArgs e)
        {
            if (textUsername1.Text == "")
            {
                textUsername1.Text = "Username";
                textUsername1.ForeColor = Color.Silver;
            }

        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            textPassword.isPassword = true;
             

            if (textPassword.Text == "Password")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.Silver;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.isPassword = false;
                textPassword.Text = "Password";
                textPassword.ForeColor = Color.Silver;
            }
        }



        private void textUsername1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textPassword.Text == null)
            {
                textPassword.Text = "Password";
                textPassword.ForeColor = Color.Silver;
            }

            if (e.KeyCode == Keys.Enter)
            {
                textPassword.Focus();
                textPassword.Text= "";
            }
            
        }

      

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                generatePassword();
            }

        }

        


        private void mformpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tick_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.atime.Text = datetime.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
