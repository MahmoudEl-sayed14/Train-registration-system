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
    public partial class TicketRegister : UserControl
    {
        readonly string email, tripName;
        public TicketRegister(string email, string tripName)
        {
            InitializeComponent();

            var style = new Style();
            style.RoundButtonBorder(saveBtn);
            style.RoundButtonBorder(cancelBtn);

            this.email = email;
            this.tripName = tripName;
        }

        private void Trip_Load(object sender, EventArgs e)
        {
            DisableBookedButtons(tripName); 
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = (button.BackColor == Color.White) ? Color.Green : Color.White;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<string> selectedButtons = new List<string>();

            for (int i = 1; i <= 32; i++)
            {
                Button? button = Controls["btn" + i] as Button;
                if (button?.BackColor == Color.Green)
                {
                    selectedButtons.Add(i.ToString());
                    button.Enabled = false;
                    button.BackColor = Color.White;
                }
            }

            if (selectedButtons.Count > 0)
            {
                string[] selectedButtonsArray = selectedButtons.ToArray();
                var ticket = new TripManager();
                ticket.BookTickets(email, tripName, selectedButtonsArray);
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 32; i++)
            {
                Button? button = Controls["btn" + i] as Button;
                button.BackColor = Color.White;
            }
        }
        private void DisableBookedButtons(string tripName)
        {
            var ticket = new TripManager();
            string[]? bookedTickets = ticket.GetAllBookedTickets(tripName);

            if (bookedTickets != null)
            {
                foreach (string userBookedTickets in bookedTickets)
                {
                    string[] numbers = userBookedTickets.Split(' ');

                    foreach (string number in numbers)
                    {
                        if (int.TryParse(number, out int buttonNumber))
                        {
                            Button? button = Controls["btn" + buttonNumber] as Button;
                            button.Enabled = false;
                        }
                    }
                }
            }
        }   
    }
}
