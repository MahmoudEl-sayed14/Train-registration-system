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
    internal class Data : Paths
    {
        private static void Insert(string path, string item)
        {
            File.AppendAllLines(path, new[] { item });
        }
        public void InsertData(string name, string email, string phone, string password)
                {
                    var queries = new[] { UserNamePath, EmailPath, PhonePath, PasswordPath };
                    var values = new[] { name, email, phone, password };

                    for (var i = 0; i < queries.Length; i++)
                    {
                        Insert(queries[i], values[i]);
                    }
                }
        public void InsertTrip(string tripName, string from, string to, string trainNumber, string platformNumber, string date, string time, string price)
        {
            string[] tripInfo = new string[] { to, tripName, from, trainNumber, platformNumber, date, time, price };
            foreach (var info in tripInfo)
            {
                Insert(TripPath, info);
            }
        }               
        
        public bool UserChangePassword(string email, string current, string newPassword)
        {
            int id = GetUserId(email);
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

        public bool FindUser(string email, string password)
        {
            int id = GetUserId(email);
            string[] passwords = File.ReadAllLines(PasswordPath);

            if(id != -1 && passwords[id].Equals(password))
            {
                return true;
            }
            return false;
        }       
        public bool FindAdmin(string password)
        {
            string correctPassword = File.ReadAllText(AdminPasswordPath);
            if (correctPassword == password)
                return true;
            return false;
        }

        public void UserBookedTickets(string email, string[] elements) 
        {
            string bookedTickets = string.Join(" ", elements);
            int id = GetUserId(email);

            string[] emails = File.ReadAllLines(EmailPath);
            string[] Tickets = File.ReadAllLines(TicketPath);

            if (emails[id].Equals(email) && id != -1)
            {
                if (id < Tickets.Length)
                {
                    if (string.IsNullOrWhiteSpace(Tickets[id]))
                        Tickets[id] = bookedTickets;
                    else
                        Tickets[id] = Tickets[id] + " " + bookedTickets;
                }
                else
                {
                    Array.Resize(ref Tickets, id + 1);
                    Tickets[id] = bookedTickets;
                }

                File.WriteAllLines(TicketPath, Tickets);
            }

        }

        private int GetUserId(string email)
        {
            string[] emails = File.ReadAllLines(EmailPath);
            int index = Array.IndexOf(emails, email);
            return index >= 0 ? index : -1;
        }
        public string GetUserTickets(string email)
        {
            string[] tickets = File.ReadAllLines(TicketPath);
            int id = GetUserId(email);
            
            if (id != -1)
            {
                if (id < tickets.Length)
                {
                    if (string.IsNullOrWhiteSpace(tickets[id]))
                        return "Null";
                    else
                        return tickets[id];
                }
                else
                {
                    return "Null";
                }
            }
            return "Email not found";
        }
        public string[] GetAllBookedTickets()
        {
            try
            {
                string[] tickets = File.ReadAllLines(TicketPath);
                return tickets;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
                return new string[] { };
            }
        }
        public Dictionary<string, string> GetTripData()
        {
            string[] tripData = File.ReadAllLines(TripPath);
            if (tripData.Length == 8)
            {
                return new Dictionary<string, string>
                {
                    ["to"] = tripData[0],
                    ["tripName"] = tripData[1],
                    ["from"] = tripData[2],
                    ["trainNumber"] = tripData[3],
                    ["platformNumber"] = tripData[4],
                    ["date"] = tripData[5],
                    ["time"] = tripData[6],
                    ["price"] = tripData[7]
                };
            }
            else
            {
                return new Dictionary<string, string>
                {
                    ["to"] = "Null",
                    ["tripName"] = "Null",
                    ["from"] = "Null",
                    ["trainNumber"] = "Null",
                    ["platformNumber"] = "Null",
                    ["date"] = "Null",
                    ["time"] = "Null",
                    ["price"] = "Null"
                };
            }
        }
        public Dictionary<string, string> GetUserData(string email)
        {
            int id = GetUserId(email);
            string[] names = File.ReadAllLines(UserNamePath);
            string[] phones = File.ReadAllLines(PhonePath);

            return new Dictionary<string, string>
            {
                ["name"] = names[id],
                ["phone"] = phones[id]
            };
        }
    }
}


