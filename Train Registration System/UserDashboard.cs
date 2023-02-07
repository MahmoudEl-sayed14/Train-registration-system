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
        string email;
        public UserDashboard(string email)
        {
            InitializeComponent();
            this.email = email;  
        }

        private void menuBtn_Click(object sender, EventArgs e)
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
            homeBtn.Location = isOpen ? new Point(0, 108) : new Point(0, 253);
            accountBtn.Text = isOpen ? "" : "Account";
            accountBtn.Location = isOpen ? new Point(0, 158) : new Point(0, 309);
        }
        private void ToggleButtonWidth(bool isOpen)
        {
            int width = isOpen ? 73 : 269;
            homeBtn.Width = width;
            accountBtn.Width = width;
            menuBtn.Width = width;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            var data = new Data();
            Dictionary<string, string> userData = data.GetUserData(email);

            userNameLabel.Text = userData["name"];
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            TripRegister user = new TripRegister();
            ShowUserControl(user);
            bookPanel.Visible = true;
        }
        private void accountBtn_Click(object sender, EventArgs e)
        {
            UserAccount user = new UserAccount();
            user.email = email;
            ShowUserControl(user);
            bookPanel.Visible = false;
        }
        private void bookBtn_Click(object sender, EventArgs e)
        {
            Trip user = new Trip();
            user.email = email;
            ShowUserControl(user);
            bookPanel.Visible = false;
        }
        private void ShowUserControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            showPanel.Controls.Clear();
            showPanel.Controls.Add(control);
        }
    }
}
