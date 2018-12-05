using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventV2.ModelLocal
{
    public class UserLogin
    {
        public string IdUser { get; set; }
        public string Password { get; set; }

        public UserLogin(string idUser, string password)
        {
            IdUser= idUser;
            Password = password;
        }
        public UserLogin()
        {
           
        }
    }
}
