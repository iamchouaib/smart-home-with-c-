using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;

namespace SecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {

           
                    TcpChannel login_channel = new TcpChannel(1758);
           ChannelServices.RegisterChannel(login_channel);
           RemotingConfiguration.RegisterWellKnownServiceType(typeof(SecuritySystem.ReqImp), "rq", WellKnownObjectMode.Singleton);



           Console.Read();
        

        }
    }
}
