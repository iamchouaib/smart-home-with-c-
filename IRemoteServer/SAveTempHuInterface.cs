using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteServer
{
    public interface SAveTempHuInterface
    {
        void saveTemp(double t);
        void saveHum(double d);
        string getTemp();
        string getHum();


    }
}
