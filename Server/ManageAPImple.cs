using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
namespace Server
{
    class ManageAPImple : MarshalByRefObject, IRemoteServer.ManageAPInterface
    {
        ConnectDb cn = new ConnectDb();
        public ManageAPImple()
        {
            cn.Connect();
        }


        public Boolean AddPerson(String fName, String password, String zone)
        {


            if (cn.open)
            {
                string query = "INSERT INTO users(fullname,username,password,zone) VALUES(@fullname,@username,@password,@zone)";
                //string query = "INSERT INTO users(fullname) VALUES(@fullname)";

                Random random = new Random();
                String userName = new string(Enumerable.Repeat(fName, 6).Select(s => s[random.Next(s.Length)]).ToArray());
                MySqlCommand cmd = new MySqlCommand(query, cn.connection);
                cmd.Parameters.AddWithValue("@fullname", fName);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@zone", zone);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public List<IRemoteServer.Person> allUsers()
        {


            List<IRemoteServer.Person> users = new List<IRemoteServer.Person>();



            string connStr = "server=localhost;uid=root;password=chouaibe19;database=minproject;";



            string query = "select * from users";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);




            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                Console.WriteLine(rdr[1] + " -- " + rdr[2] + " -- " + rdr[3]);

                IRemoteServer.Person p = new IRemoteServer.Person()
                {
                    Id = Int32.Parse(rdr[0].ToString()),
                    FullName = rdr[1].ToString(),
                    UserName = rdr[3].ToString(),
                    Zone = rdr[4].ToString(),
                    IsAutorised = bool.Parse(rdr[5].ToString()),
                };


                users.Add(p);


            }

            return users;
        }

        public Boolean deletePerson(String userName)
        {


            if (cn.open)
            {
                string query = "DELETE FROM users WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(query, cn.connection);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;

        }

        public Boolean updatePerson(String fullName, String Zone, String userName, String oldUserName)
        {


            try
            {
                if (cn.open)
                {
                    string query = "UPDATE users SET fullname=@fullname ,username=@username,zone=@zone WHERE username=@oldusername";
                    MySqlCommand cmd = new MySqlCommand(query, cn.connection);

                    cmd.Parameters.AddWithValue("@fullname", fullName);
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@oldusername", oldUserName);
                    cmd.Parameters.AddWithValue("@zone", Zone);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;

            }
            catch (MySqlException e)
            {

                Console.Write(e);
                return false;


            }


        }
        public Boolean  AutorisePerson(String userName, Boolean p)
        {


            if (cn.open)
            {
                string query = "UPDATE users SET isAutorised=@isAutorised WHERE username=@id";
                MySqlCommand cmd = new MySqlCommand(query, cn.connection);
                cmd.Parameters.AddWithValue("@id", userName);
                cmd.Parameters.AddWithValue("@isAutorised", p);
                cmd.ExecuteNonQuery();
                return true;
            }

            return false;



            {


            }



        }





        public Boolean checkDoorState()
        {
            string connStr = "server=localhost;uid=root;password=chouaibe19;database=minproject;";



            string queryd = "select * from doors";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmdd = new MySqlCommand(queryd, conn);




            MySqlDataReader rdr = cmdd.ExecuteReader();
            Boolean state = false;
            while (rdr.Read())
            {
                    state = bool.Parse(rdr[1].ToString());
            }

            return state;
        
        }

        public Boolean toggleDoor() {

            if (cn.open)
            {
                string query = "UPDATE doors SET state=@state WHERE id=1";
                MySqlCommand cmd = new MySqlCommand(query, cn.connection);

                cmd.Parameters.AddWithValue("@state", !checkDoorState());
               
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }



        public Boolean changePassword(String old ,  String newP){



               if (!old.Equals("1234")) { return false; }

               if (cn.open)
               {
                   string query = "UPDATE doors SET password=@pass WHERE id=1";
                   MySqlCommand cmd = new MySqlCommand(query, cn.connection);

                   cmd.Parameters.AddWithValue("@pass", newP);

                   cmd.ExecuteNonQuery();
                   return true;
               }
               return false;
        
        }

        public List<IRemoteServer.RequestDoorcs> getRequsts()
        {


            List<IRemoteServer.RequestDoorcs> requests = new List<IRemoteServer.RequestDoorcs>();



            string connStr = "server=localhost;uid=root;password=chouaibe19;database=minproject;";



            string query = "SELECT requests.id , date , accepte , fullname , zone FROM requests JOIN users ON requests.id_user = users.id;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);




            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                Console.Write(rdr[0] + "--" + rdr[1] + "--" + rdr[2] + "--" + rdr[3] + "--" + rdr[4] + "--");

                IRemoteServer.RequestDoorcs p = new IRemoteServer.RequestDoorcs()
                {
                    Id = Int32.Parse(rdr[0].ToString()),
                    Date = rdr[1].ToString(),
                    Accepte = bool.Parse(rdr[2].ToString()),
                    FullName = rdr[3].ToString(),
                    Zone = rdr[4].ToString(),


                };


                requests.Add(p);


            }

            return requests;
        }

    }
       
    }

