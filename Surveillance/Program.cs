using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Surveillance
{
    class Program
    {
        static void Main(string[] args)
        {
            
                TcpChannel survChannel = new TcpChannel(1757);
                ChannelServices.RegisterChannel(survChannel);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Surveillance.SurvImpl), "survimpl", WellKnownObjectMode.Singleton);
                IRemoteServer.SAveTempHuInterface th =
         (IRemoteServer.SAveTempHuInterface)Activator.GetObject(typeof(IRemoteServer.SAveTempHuInterface), "tcp://localhost:1756/surv");

                Console.WriteLine(th.getTemp());
                Console.WriteLine(th.getHum());
                Console.Read();
            
        }
    }
}
