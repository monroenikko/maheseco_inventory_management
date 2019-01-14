using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{  

    public class User
    {
        public string username;
        public string password;
        public string position;
        public string pos_id;
        //function
        public static User login(string username, string password, string position, string pos_id)
        {
            User user = null; //not create object
            user = new User();

            string query = "SELECT * FROM user WHERE username= @username AND password= @password";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Database.connection);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);               

                //execute reader
                MySqlDataReader reader = cmd.ExecuteReader();                

                while (reader.Read())
                {
                    user.username = reader["username"].ToString();//array reader index
                    user.password = reader["password"].ToString();
                    user.position = reader.GetString("position");
                    user.pos_id = reader.GetString("id");
                }
                reader.Close();

            }catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message); 
            }

            return user;
        }

        
    }
}
