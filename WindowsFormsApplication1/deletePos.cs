using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{

   

    public class Del
    {
        //public string username;
        public string id;
        public string qty;
        
        //function
        public static Del login(string id, string qty)
        {
            Del pos = null; //not create object
            pos = new Del();
             
            string query = "SELECT * FROM prod_brand WHERE brand_id= @id AND qty= @qty";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Database.connection);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@qty", qty);               

                //execute reader
                MySqlDataReader reader = cmd.ExecuteReader();                

                while (reader.Read())
                {
                    pos.id = reader["id"].ToString();//array reader index
                    pos.qty = reader["qty"].ToString();
                   // user.position = reader.GetString("position");                    
                }
                reader.Close();

            }catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message); 
            }

            return pos;
        }

        internal static object login(object id, object qty)
        {
            throw new NotImplementedException();
        }
    }
}
