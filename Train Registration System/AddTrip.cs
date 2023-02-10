using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Registration_System
{
    public partial class AddTrip : UserControl
    {
        public AddTrip()
        {
            InitializeComponent();
            var style = new Style();
            style.RoundButtonBorder(addTripBtn);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void addTripBtn_Click(object sender, EventArgs e)
        {
            var message = new Style();
            if (!IsEmptyTrip())
            {
                DateTime selectedDate = date.Value.Date;
                string dateOnlyString = selectedDate.ToString("dd/MM/yyyy");

                string time = BuildTimeString(hourTxt.Text, minTxt.Text, timeComboBox.Text);
                
                var trip = new Trip();
                trip.InsertTripData(tripNameTxt.Text, fromComboBox.Text, toComboBox.Text, trainNumberTxt.Text, platformNumberTxt.Text, dateOnlyString, time, ticketPriceTxt.Text);

                message.ShowSuccess("Trip added.");
                clear();
            }
            else
            {
                message.ShowError("Please fill out all fields of the trip.");
            }
        }
        private void clear()
        {
            tripNameTxt.Text =
            fromComboBox.Text =
            toComboBox.Text =
            trainNumberTxt.Text =
            platformNumberTxt.Text =
            hourTxt.Text =
            minTxt.Text =
            timeComboBox.Text =
            ticketPriceTxt.Text = string.Empty;
        }
        private bool IsEmptyTrip()
        {
            Control[] controls = { tripNameTxt, fromComboBox, toComboBox, trainNumberTxt, platformNumberTxt, hourTxt, minTxt, timeComboBox, ticketPriceTxt };
            foreach (Control control in controls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    return true;
                }
            }
            return false;
        }
        private string BuildTimeString(string hour, string min, string timeOfDay)
        {
            return hour + " : " + min + " : " + timeOfDay;
        }
        
    }
}
