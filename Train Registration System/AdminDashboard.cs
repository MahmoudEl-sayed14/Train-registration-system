using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Registration_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void ShowUserControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            showPanel.Controls.Clear();
            showPanel.Controls.Add(control);
        }
        public void SetUnderlinePanel(Button button)
        {
            underLinePanel.Left = button.Left;
            underLinePanel.Width = button.Width;
            underLinePanel.Visible = true;
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SetUnderlinePanel(homeBtn);

            var trip = new AddTrip();
            ShowUserControl(trip);
        }
        private void TicketBtn_Click(object sender, EventArgs e)
        {
            SetUnderlinePanel(ticketBtn);

            var tickets = new BookedTickets("admin");
            ShowUserControl(tickets);
        }
        private void AccountBtn_Click(object sender, EventArgs e)
        {
            SetUnderlinePanel(accountBtn);

            var admin = new UserAccount("admin");
            ShowUserControl(admin);
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SetUnderlinePanel(searchBtn);

            var search = new Search();
            ShowUserControl(search);
        }
        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
            Application.Exit();
        }
    }
}
