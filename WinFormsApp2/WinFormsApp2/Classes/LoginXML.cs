using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Enum;
using WinFormsApp2.Interfaces;
using System.Collections.Generic;

namespace WinFormsApp2.Classes
{
    class LoginXML : ILogin
    {
        Dictionary<string, User> UserData = new Dictionary<string, User>();
        public void LoadUsers()
        {
            string path = System.IO.Path.GetFullPath(@"..\..\..\");
            path = string.Concat(path, "\\UserData\\UserData.xml");

            string userData = File.ReadAllText(path);
            JObject json = JObject.Parse(userData);
            JToken jt = json.GetValue("Userdata");
            foreach(JToken v in jt.Children())
            {
                User u = new User(v);
                UserData.Add(u.Username, u);
            }
        }

        public User Login(string username, string password)
        {
            if(UserData.ContainsKey(username))
            {
                User loggedin = UserData[username];
                if (password.Equals(loggedin.Password))
                    return loggedin;
            }
            return null;
        }

        public bool Logout()
        {
            return true;
        }

    }
}
