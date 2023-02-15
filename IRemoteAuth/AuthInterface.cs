using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteAuth
{
    public interface AuthInterface
    {

       IRemoteServer.Person  login(String email, String password);

  

    }
}
