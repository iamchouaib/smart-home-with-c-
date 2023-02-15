using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteServer
{
    public interface SaveReqInterface
    {
        Boolean request(int id, String token);
    }
}
