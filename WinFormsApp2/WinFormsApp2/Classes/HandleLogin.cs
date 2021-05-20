using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Interfaces;

namespace WinFormsApp2.Classes
{
    class HandleLogin
    {
        ILogin LoginSys;
        public HandleLogin()
        {
            // Read type of login form (xml or db or other) from some details file and create loginsys object as per that.
            LoginSys = new LoginXML();
            LoginSys.LoadUsers();
        }

        public User Login(string username, string pwd)
        {
            return LoginSys.Login(username, pwd);
        }

        public void logout()
        {
            LoginSys.Logout();
        }
    }
}
