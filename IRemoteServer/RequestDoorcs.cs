using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace IRemoteServer
{
         [Serializable]
   public class RequestDoorcs
    {

   


        public int Id { get; set; }
        public string Date { get; set; }
        public string FullName { get; set; }
   
        public string Zone { get; set; }
        public Boolean Accepte { get; set; }
      

        public RequestDoorcs() { }
    }
}
