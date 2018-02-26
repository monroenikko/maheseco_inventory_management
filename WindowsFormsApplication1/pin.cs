using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{

   

    public class Pin
    {
        public string username;
        public string password;
        public string position;
        
        //function
        public static Pin login(string password)
        {
            Pin pincode = null; //not create object
            pincode = new Pin();
             
            string query = "SELECT * FROM log WHERE position= 'admin' AND password= @password";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Database.connection);
                cmd.Prepare();
               // cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);               

                //execute reader
                MySqlDataReader reader = cmd.ExecuteReader();                

                while (reader.Read())
                {
                    // user.username = reader["username"].ToString();//array reader index
                    pincode.password = reader["password"].ToString();
                   // user.position = reader.GetString("position");                    
                }
                reader.Close();

            }catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message); 
            }

            return pincode;
        }

        
    }
}
