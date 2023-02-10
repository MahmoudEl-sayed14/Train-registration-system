using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class Ticket : Paths
    {
        public void UserBookedTickets(string email, string[] elements)
        {
            string bookedTickets = string.Join(" ", elements);

            var user = new User();

            var userData = user.GetUserData(email);
            int id = Convert.ToInt32(userData["id"]);

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
        public string GetUserTickets(string email)
        {
            string[] tickets = File.ReadAllLines(TicketPath);
            var user = new User();

            var userData = user.GetUserData(email);
            int id = Convert.ToInt32(userData["id"]);

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
                MessageBox.Show("An error occurred while reading the file: " + ex.Message);
                return new string[] { };
            }
        }
    }
}
