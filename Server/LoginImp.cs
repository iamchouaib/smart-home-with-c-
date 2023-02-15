using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace Server
{



    class LoginImp : MarshalByRefObject, IRemoteAuth.AuthInterface
    {

        public LoginImp()
        {

        }

        Connection con = new Connection();







        public IRemoteServer.Person login(String email, String password)
        {



            try
            {

                con.Open();

                string query = "SELECT * from `users` where username='" + email + "' and password='" + password + "'";

                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {
                    IRemoteServer.Person p = new IRemoteServer.Person();
                    while (row.Read())
                    {

                        p.Id =  Int32.Parse(row["id"].ToString());
                        p.FullName = row["fullname"].ToString();
                        p.UserName = row["username"].ToString();
                        p.Password = row["password"].ToString();
                        p.Zone = row["zone"].ToString();
                        String a  = row["isAdmin"].ToString();

                        if (a.Equals("1"))
                        {
                            p.Type = "admin";
                        }
                        else {
                            p.Type = "person";
                        }
                        string b = row["isAutorised"].ToString();
                        if (b.Equals("1"))
                        {
                            p.IsAutorised = true;
                        }
                        else
                        {
                            p.IsAutorised = false;
                        }
                    }


                    return p;
                }



                return null;

            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
                return null;

            }



        }

        public Boolean logout()
        {
            Console.Write("LogedOut");
            return true;
        }



































    }



}










