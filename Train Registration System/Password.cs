using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class Password : Paths
    {
        public bool UserChangePassword(string email, string current, string newPassword)
        {
            var user = new User();

            var userData = user.GetUserData(email);
            int id = Convert.ToInt32(userData["id"]);

            string[] passwords = File.ReadAllLines(PasswordPath);

            if (id != -1 && passwords[id] == current)
            {
                passwords[id] = newPassword;
                File.WriteAllLines(PasswordPath, passwords);
                return true;
            }
            return false;
        }
        public bool AdminChangePassword(string current, string newPassword)
        {
            string passwords = File.ReadAllText(AdminPasswordPath);

            if (passwords == current)
            {
                File.WriteAllText(AdminPasswordPath, newPassword);
                return true;
            }
            return false;
        }
    }
}
