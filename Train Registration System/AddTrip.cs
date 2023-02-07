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
            RoundButtonBorder(addTripBtn);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void addTripBtn_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTrip())
            {
                DateTime selectedDate = date.Value.Date;
                string dateOnlyString = selectedDate.ToString("dd/MM/yyyy");

                string time = BuildTimeString(hourTxt.Text, minTxt.Text, timeComboBox.Text);
                
                var data = new Data();
                data.InsertTrip(tripNameTxt.Text, fromComboBox.Text, toComboBox.Text, trainNumberTxt.Text, platformNumberTxt.Text, dateOnlyString, time, ticketPriceTxt.Text);
                
                MessageBox.Show("Trip added.");
                clear();
            }
            else
            {
                MessageBox.Show("Please fill out all fields of the trip.");
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
        private void RoundButtonBorder(Button button)
        {
            button.Font = new Font("Arial", 14, FontStyle.Bold);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 10, 10, 180, 90);
            path.AddArc(button.Width - 11, 0, 10, 10, 270, 90);
            path.AddArc(button.Width - 11, button.Height - 11, 10, 10, 0, 90);
            path.AddArc(0, button.Height - 11, 10, 10, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }
    }
}
