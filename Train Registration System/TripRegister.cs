using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Train_Registration_System
{
    public partial class TripRegister : UserControl
    {
        public TripRegister()
        {
            InitializeComponent();
        }

        private void TripRegister_Load(object sender, EventArgs e)
        {
            var trip = new Trip();
            var tripData = trip.GetTripData();
            
            destinationLabel.Text = $"Today we will go to: {tripData["to"]}";
            tripNameLabel.Text = $"Trip Name: {tripData["tripName"]}";
            stationLabel.Text = $"From: {tripData["from"]}";
            trainNoLabel.Text = $"Train Number: {tripData["trainNumber"]}";
            PlatformLabel.Text = $"Platform: {tripData["platformNumber"]}";
            dateLabel.Text = $"Date: {tripData["date"]}";
            timeLabel.Text = $"Time: {tripData["time"]}";
            priceLabel.Text = $"Price: {tripData["price"]}";
            
        }
    }
}
