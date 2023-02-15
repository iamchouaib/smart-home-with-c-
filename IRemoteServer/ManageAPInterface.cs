using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteServer
{
    public interface ManageAPInterface
    {
        Boolean AddPerson(String fName , String password , String zone);

        List<IRemoteServer.Person> allUsers();
        List<IRemoteServer.RequestDoorcs> getRequsts();
       // string EditPerson(Person p);

        Boolean updatePerson(String fullName, String Zone, String userName, String oldUserName);
        Boolean deletePerson(String userName);

        //string AutorisePerson(int id);
        //string BanPerson(int id);


        Boolean checkDoorState();
        Boolean toggleDoor();
        Boolean AutorisePerson(string currentName, Boolean p);

        Boolean changePassword(String old,
           String newP);
    }
}
