using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuritySystem
{
    class ReqImp : MarshalByRefObject , IRemoteSecurity.ReqInterface
    {

        IRemoteServer.SaveReqInterface req = 
            (IRemoteServer.SaveReqInterface)Activator.GetObject(typeof(IRemoteServer.SaveReqInterface), "tcp://localhost:1756/req");

        public Boolean request(int id, String token) {

            return req.request(id, token);

           
        }

   
            
    }
}
