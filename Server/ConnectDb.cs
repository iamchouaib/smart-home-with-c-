using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Server
{
    public class ConnectDb
    {
        private static string connectionString = "server=localhost;uid=root;password=chouaibe19;database=minproject;";
  
        public MySqlConnection connection;
        public bool open=false;
        public ConnectDb()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {


                if (!open)
                {
                    connection.Open();
                    Console.Write("connected sucss");
                    open = true;
                }
                    
                    
                

                
                
               
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
                
            }
        }
    }
}
