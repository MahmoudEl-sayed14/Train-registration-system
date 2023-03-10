using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Train_Registration_System
{
    internal class User : Paths
    {
        private static void Insert(string path, string item)
        {
            File.AppendAllLines(path, new[] { item });
        }
        public void InsertUser(string name, string email, string phone, string password)
        {
            var queries = new[] { UserNamePath, EmailPath, PhonePath, PasswordPath };
            var values = new[] { name, email, phone, password };

            for (var i = 0; i < queries.Length; i++)
            {
                Insert(queries[i], values[i]);
            }
        }
        private int GetUserId(string email)
        {
            string[] emails = File.ReadAllLines(EmailPath);
            int index = Array.IndexOf(emails, email);
            return index;
        }
        public bool UserChangePassword(string email, string currentPassword, string newPassword)
        {
            bool isAdmin = email.Equals("admin", StringComparison.OrdinalIgnoreCase);
            if (isAdmin)
            {
                string adminPassword = File.ReadAllText(AdminPasswordPath);
                if (adminPassword.Equals(currentPassword))
                {
                    File.WriteAllText(AdminPasswordPath, newPassword);
                    return true;
                }
            }
            else
            {
                var user = new User();
                var userData = user.GetUserData(email);
                int id = Convert.ToInt32(userData["id"]);

                string[] passwords = File.ReadAllLines(PasswordPath);

                if (id != -1 && passwords[id] == currentPassword)
                {
                    passwords[id] = newPassword;
                    File.WriteAllLines(PasswordPath, passwords);
                    return true;
                }
                return false;
            }
            return false;
        }
        public Dictionary<string, string> GetUserData(string email)
        {
            int index = GetUserId(email);

            if (index < 0)
            {
                return new Dictionary<string, string>
                {
                    ["name"] = null,
                    ["phone"] = null,
                    ["email"] = null,
                    ["id"] = "-1"
                };
            }

            string[] names = File.ReadAllLines(UserNamePath);
            string[] phones = File.ReadAllLines(PhonePath);
            string id = index.ToString();

            return new Dictionary<string, string>
            {
                ["name"] = names[index],
                ["phone"] = phones[index],
                ["email"] = email,
                ["id"] = id
            };
        }
    }
}


