using Sports.Models.Page1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Services
{
    public class UserRepository_Page1
    {
        static List<Users> userList = new List<Users>();
        public void Insert(Users myUser)
        {
            userList.Add(myUser);
        }
    }
}
