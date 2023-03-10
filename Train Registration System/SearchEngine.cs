using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Registration_System
{
    internal class SearchEngine : Paths
    {
        private void SearchUserDataInFiles(string searchText, ListBox resultsListBox)
        {
            string[] files = Directory.GetFiles(UserDataPath, "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                if (Path.GetFileName(file).ToLower() == "password.txt")
                {
                    continue;
                }

                foreach (string line in File.ReadAllLines(file))
                {
                    if (line.ToLower().Contains(searchText))
                    {
                        resultsListBox.Items.Add(line);
                    }
                }
            }
        }
        private void SearchTripDataInFiles(string searchText, ListBox resultsListBox)
        {
            var TripManager = new TripManager();
            string[] trips = TripManager.GetAllTrips();
            foreach (string trip in trips)
            {
                if (trip.ToLower().Contains(searchText))
                {
                    resultsListBox.Items.Add(trip);
                }
            }
        }
        public void DisplaySearchSuggestions(string searchQuery, ListBox resultsListBox)
        {
            string search = searchQuery.ToLower();

            SearchUserDataInFiles(search, resultsListBox);
            SearchTripDataInFiles(search, resultsListBox);
        }
        private int FindLineContainingTextInUserDataFiles(string searchText)
        {
            string[] files = Directory.GetFiles(UserDataPath, "*.txt", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                if (Path.GetFileName(file).ToLower() == "password.txt")
                {
                    continue;
                }

                string[] fileLines = File.ReadAllLines(file);
                for (int i = 0; i < fileLines.Length; i++)
                {
                    if (fileLines[i].ToLower().Equals(searchText)) 
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public Dictionary<string, string> DisplaySearchResults(string searchText, ref string type)
        {
            string search = searchText.ToLower();
            int id = FindLineContainingTextInUserDataFiles(search);

            if(id != -1)
            {
                string[] emails = File.ReadAllLines(EmailPath);
                var user = new User();
                var userData = user.GetUserData(emails[id]);
                type = "user";
                return userData;
            }
            else
            {
                var trip = new TripManager();
                var tripData = trip.GetTripData(searchText);
                if(tripData != null)
                {
                    type = "trip";
                    return tripData;
                }
                return null;
            }
        }
    }
}
