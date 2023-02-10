using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class AuthenticationManager : Paths
    {
        public bool Login(string email, string password)
        {
            switch (email)
            {
                case "admin":
                    if (FindAdmin(password))
                    {
                        new AdminDashboard().Show();
                        return true;
                    }
                    break;
                default:
                    if (FindUser(email, password))
                    {
                        new UserDashboard(email).Show();
                        return true;
                    }
                    break;
            }
            var message = new Style();
            message.ShowError("Incorrect Email or Password");

            return false;
        }
        private bool FindUser(string email, string password)
        {
            var user = new User();
            
            var userData = user.GetUserData(email);
            int id = Convert.ToInt32(userData["id"]);

            string[] passwords = File.ReadAllLines(PasswordPath);

            if (id != -1 && passwords[id].Equals(password))
            {
                return true;
            }
            return false;
        }
        private bool FindAdmin(string password)
        {
            string correctPassword = File.ReadAllText(AdminPasswordPath);
            if (correctPassword == password)
                return true;
            return false;
        }
    }
}
