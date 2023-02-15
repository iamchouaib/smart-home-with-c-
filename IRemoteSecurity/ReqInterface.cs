using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteSecurity
{
    public interface ReqInterface
    {

        Boolean request(int id, String token);
    }
}
