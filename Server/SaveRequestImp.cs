using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Server
{
    class SaveRequestImp : MarshalByRefObject , IRemoteServer.SaveReqInterface 
    {


     public   Boolean request(int id ,String token)
        {

       


         //save to db
         Boolean accepte= token.Equals("1234");

       
     
           ConnectDb cn = new ConnectDb();

           cn.Connect();
           try
           {

               if (cn.open)
            {
                string query = "INSERT INTO requests(id_user,date,accepte) VALUES(@id,@date,@accepte)";
        

                
                MySqlCommand cmd = new MySqlCommand(query, cn.connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@accepte", accepte);
              
                cmd.ExecuteNonQuery();
                
            }


           }
           catch (MySqlException e)
           {

               Console.Write(e);
           }
       
            
        




         //check 

         if(accepte){

             return true;
         }


            return false;
        }
    }
}
