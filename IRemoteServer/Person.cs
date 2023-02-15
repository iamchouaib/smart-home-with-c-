using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace IRemoteServer 
{

    [Serializable]
    public class Person 
    {
    
     public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Zone { get; set; }
        public Boolean IsAutorised { get; set; }
        public string Type { get; set; }
   
 



        public Person()
        { }





    }
}
