using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class Trip : Paths
    {
        private static void Insert(string path, string item)
        {
            File.AppendAllLines(path, new[] { item });
        }
        public void InsertTripData(string tripName, string from, string to, string trainNumber, string platformNumber, string date, string time, string price)
        {
            string[] tripInfo = new string[] { to, tripName, from, trainNumber, platformNumber, date, time, price };
            foreach (var info in tripInfo)
            {
                Insert(TripPath, info);
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
    }
}
