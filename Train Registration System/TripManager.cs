using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class TripManager : Paths
    {
        private static void Insert(string path, string item)
        {
            File.AppendAllLines(path, new[] { item });
        }
        public void InsertTripData(string tripName, string from, string to, string trainNumber, string platformNumber, string date, string time, string price)
        {
            string[] tripInfo = new string[] { to, tripName, from, trainNumber, platformNumber, date, time, price };
            string tripData = string.Join(",", tripInfo);
            Insert(TripPath, tripData);
        }
        public string[] GetAllTrips()
        {
            string[] tripData = File.ReadAllLines(TripPath);

            List<string> trips = new List<string>();
            foreach (string line in tripData)
            {
                string[] values = line.Split(',');
                if (values.Length == 8)
                {
                    string tripName = values[1];
                    trips.Add(tripName);
                }
            }
            return trips.ToArray();
        }
        public Dictionary<string, string>? GetTripData(string tripName)
        {
            string[] tripData = File.ReadAllLines(TripPath);

            foreach (string line in tripData)
            {
                string[] values = line.Split(',');
                if (values.Length == 8 && values[1] == tripName)//
                {
                    return new Dictionary<string, string>
                    {
                        ["to"] = values[0],
                        ["tripName"] = values[1],
                        ["from"] = values[2],
                        ["trainNumber"] = values[3],
                        ["platformNumber"] = values[4],
                        ["date"] = values[5],
                        ["time"] = values[6],
                        ["price"] = values[7]
                    };
                }
            }

            return null;
        }
        public bool DeleteTripData(string tripName)
        {
            List<string> tripData = File.ReadAllLines(TripPath).ToList();
            List<string> bookedtrip = File.ReadAllLines(TicketPath).ToList();

            for (int i = bookedtrip.Count - 1; i >= 0; i--)
            {
                string line = bookedtrip[i];
                string[] values = line.Split(",");
                if (values[1] == tripName)
                {
                    bookedtrip.RemoveAt(i);
                }
            }
            File.WriteAllLines(TicketPath, bookedtrip);

            for (int i = tripData.Count - 1; i >= 0; i--)
            {
                string line = tripData[i];
                string[] values = line.Split(',');
                if (values[1] == tripName)
                {
                    tripData.RemoveAt(i);
                    File.WriteAllLines(TripPath, tripData);
                    return true;
                }
            }
            return false;
        }
        public List<string[]>? GetBookedTickets(string email)
        {
            List<string[]> bookedTickets = new List<string[]>();

            string[] ticketData = File.ReadAllLines(TicketPath);
            foreach (string ticket in ticketData)
            {
                string[] ticketParts = ticket.Split(',');
                if (ticketParts.Length == 3 && ticketParts[0] == email)
                {
                    string tripName = ticketParts[1];
                    string tickets = ticketParts[2];
                    bookedTickets.Add(new string[] { tripName, tickets });
                }
            }

            return (bookedTickets.Count > 0) ? bookedTickets : null;
        }
        public string[]? GetAllBookedTickets(string tripName)
        {
            List<string> bookedTickets = new List<string>();

            string[] ticketData = File.ReadAllLines(TicketPath);
            foreach (string ticket in ticketData)
            {
                string[] ticketParts = ticket.Split(',');
                if (ticketParts.Length == 3 && ticketParts[1] == tripName)
                {
                    bookedTickets.AddRange(ticketParts[2].Split(' '));
                }
            }

            return (bookedTickets.Count > 0) ? bookedTickets.ToArray() : null;
        }
        public void BookTickets(string email, string tripName, string[] tickets)
        {
            string bookedTickets = string.Join(" ", tickets);
            string[] existingBookings = File.ReadAllLines(TicketPath);

            for (int i = 0; i < existingBookings.Length; i++)
            {
                string[] parts = existingBookings[i].Split(',');
                if (parts.Length >= 3 && parts[0] == email && parts[1] == tripName)
                {
                    parts[2] += " " + bookedTickets;
                    existingBookings[i] = string.Join(",", parts);
                    File.WriteAllLines(TicketPath, existingBookings);
                    return;
                }
            }

            string newBooking = $"{email},{tripName},{bookedTickets}" + Environment.NewLine;
            File.AppendAllText(TicketPath, newBooking);
        }
    }
}
