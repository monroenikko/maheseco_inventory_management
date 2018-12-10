using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//load for api

namespace WindowsFormsApplication1
{
    //declare public static class to perform connection to database and using static to call global variable
    public static class Database
    {
        //creating require variable
        static string database = "mahesecoinventory";
        static string server = "127.0.0.1";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string connectionString = "server=" +server+ "; port=" +port+ "; database=" +database+ "; username=" +username+ "; password=" +password+ ";";
        public static MySqlConnection connection = null;//class api database connection

        static Database()
        {
            connection = new MySqlConnection(connectionString);//pass the parameter to object
        }

        public static bool Open()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static bool Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
