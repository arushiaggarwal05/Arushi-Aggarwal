using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Enum;

namespace WinFormsApp2.Classes
{
    class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public EnumUserType UserType { get; set; }

        public User(JToken jt)
        {
            Username = (string)jt["Username"];
            Password = (string)jt["Password"];
            UserType = (EnumUserType)(int)jt["Usertype"];
        }
    }
}
