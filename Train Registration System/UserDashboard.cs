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
using static System.Windows.Forms.DataFormats;

namespace Train_Registration_System
{
    public partial class UserDashboard : Form
    {
        readonly string email;
        readonly string[] tripsArray = new TripManager().GetAllTrips();
        int currentTripIndex = 0;
        public UserDashboard(string email)
        {
            InitializeComponent();
            this.email = email;  
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            bool isOpen = sidebarPanel.Size.Width == 269;
            SetSidebarWidth(isOpen);
            ToggleUserControlsVisibility(isOpen);
            ToggleButtonTextAndLocation(isOpen);
            ToggleButtonWidth(isOpen);
        }
        private void SetSidebarWidth(bool isOpen)
        {
            sidebarPanel.Width = isOpen ? 73 : 269;
        }
        private void ToggleUserControlsVisibility(bool isOpen)
        {
            userPictureBox.Visible = !isOpen;
            userNameLabel.Visible = !isOpen;
        }
        private void ToggleButtonTextAndLocation(bool isOpen)
        {
            homeBtn.Text = isOpen ? "" : "Home";
            accountBtn.Text = isOpen ? "" : "Account";
            ticketBtn.Text = isOpen ? "" : "Tickets";
            
            homeBtn.Location = isOpen ? new Point(0, 108) : new Point(0, 253);
            ticketBtn.Location = isOpen ? new Point(0, 158) : new Point(0, 309);
        }
        private void ToggleButtonWidth(bool isOpen)
        {
            int width = isOpen ? 73 : 269;
            homeBtn.Width = width;
            accountBtn.Width = width;
            menuBtn.Width = width;
            ticketBtn.Width = width;
        }
        private void ToggleControlsVisibility(bool showControls)
        {
            bookPanel.Visible = showControls;
            leftPictureBox.Visible = showControls;
            rightPictureBox.Visible = showControls;
        }
        private void ShowUserControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            ShowPanel.Controls.Clear();
            ShowPanel.Controls.Add(control); 
        }
        private void Home_Load(object sender, EventArgs e)
        {
            var user = new User();
            Dictionary<string, string> userData = user.GetUserData(email);

            userNameLabel.Text = userData["name"];
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (currentTripIndex >= tripsArray.Length)
            {
                ShowUserControl(new NotFound());
                ToggleControlsVisibility(false);
                return;
            }

            var trip = new TripRegister(tripsArray[currentTripIndex]);

            ShowUserControl(trip);
            ToggleControlsVisibility(true);
        }
        private void AccountBtn_Click(object sender, EventArgs e)
        {
            var user = new UserAccount(email);
            ShowUserControl(user);

            ToggleControlsVisibility(false);
        }
        private void BookBtn_Click(object sender, EventArgs e)
        {
            var ticket = new TicketRegister(email, tripsArray[currentTripIndex]);
            ShowUserControl(ticket);

            ToggleControlsVisibility(false);
        }
        private void TicketBtn_Click(object sender, EventArgs e)
        {
            var tickets = new TripManager();
            var ticketsData = tickets.GetBookedTickets(email);
            if (ticketsData != null)
            {
                var user = new BookedTickets(email);
                ShowUserControl(user);
            }
            else
            {
                var notfound = new NotFound();
                ShowUserControl(notfound);
            }
            bookPanel.Visible = false;
            leftPictureBox.Visible = false;
            rightPictureBox.Visible = false;
            
        }
        private void RightPictureBox_Click(object sender, EventArgs e)
        {
            currentTripIndex++;

            currentTripIndex = ((currentTripIndex % tripsArray.Length) + tripsArray.Length) % tripsArray.Length;
            ShowUserControl(new TripRegister(tripsArray[currentTripIndex]));
        }
        private void LeftPictureBox_Click(object sender, EventArgs e)
        {
            currentTripIndex--;

            currentTripIndex = ((currentTripIndex % tripsArray.Length) + tripsArray.Length) % tripsArray.Length;
            ShowUserControl(new TripRegister(tripsArray[currentTripIndex]));
        }
        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
            Application.Exit();
        }
    }
}
