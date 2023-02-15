using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveillance
{
    

        class SurvImpl : MarshalByRefObject, IRemoteSurveillance.ManageSurveillaneInterface
        {
            IRemoteServer.SAveTempHuInterface th =
                (IRemoteServer.SAveTempHuInterface)Activator.GetObject(typeof(IRemoteServer.SAveTempHuInterface), "tcp://localhost:1756/surv");
            public string viewTemp()
            {
                return th.getTemp();
            }
            public string viewHum()
            {
                return th.getHum();
            }
        }


    
}
