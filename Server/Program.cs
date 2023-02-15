using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

        // TcpChannel ch = new TcpChannel(1456);
        //   ChannelServices.RegisterChannel(ch);

            ManageAPImple app = new ManageAPImple();

          TcpChannel login_channel = new TcpChannel(1756);
           ChannelServices.RegisterChannel(login_channel , false);
           RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server.ManageAPImple), "obj", WellKnownObjectMode.Singleton);




         //   RemotingServices.Marshal(app , "obj" , app.GetType());

          RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server.LoginImp), "login", WellKnownObjectMode.Singleton);


          RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server.SaveTempAndHumImp), "surv", WellKnownObjectMode.Singleton);
          RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server.SaveRequestImp), "req", WellKnownObjectMode.Singleton);


            
            Console.Read();
        }
    }
}
