using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

using MySql.Data.MySqlClient;
namespace Server
{
    class SaveTempAndHumImp : MarshalByRefObject, IRemoteServer.SAveTempHuInterface
    {
        ConnectDb cn = new ConnectDb();
        public SaveTempAndHumImp()
        {
            cn.Connect();
        }
        Connection con = new Connection();
        public void saveTemp(double t)
        {
            if (cn.open)
            {
                string query = "UPDATE tempHum SET temperature=@t";
                MySqlCommand cmd = new MySqlCommand(query, cn.connection);
                cmd.Parameters.AddWithValue("@t", t);
                cmd.ExecuteNonQuery();
            }
        }
        public void saveHum(double h)
        {
            if (cn.open)
            {
                string query = "UPDATE tempHum SET humidity=@h";
                MySqlCommand cmd = new MySqlCommand(query, cn.connection);
                cmd.Parameters.AddWithValue("@t", h);
                cmd.ExecuteNonQuery();
            }
        }
        public string getTemp()
        {
            try
            {

                con.Open();

                string query = "SELECT temperature from `tempHum` WHERE id=1";

                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {
                    string t = null;
                    while (row.Read())
                    {


                        t = row["temperature"].ToString();

                    }


                    return t;
                }



                return null;

            }
            catch
            {
                return null;

            }
        }
        public string getHum()
        {
            try
            {

                con.Open();

                string query = "SELECT humidity from `tempHum` WHERE id=1";

                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {
                    string h = null;
                    while (row.Read())
                    {


                        h = row["humidity"].ToString();

                    }


                    return h;
                }



                return null;

            }
            catch
            {
                return null;

            }
        }
    }
}
