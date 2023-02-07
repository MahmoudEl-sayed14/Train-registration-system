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

        private void homeBtn_Click(object sender, EventArgs e)
        {
            underLinePanel.Left = homeBtn.Left;
            underLinePanel.Width = homeBtn.Width;
            underLinePanel.Visible = true;
            var trip = new AddTrip();
            ShowUserControl(trip);
        }
        private void ShowUserControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            showPanel.Controls.Clear();
            showPanel.Controls.Add(control);
        }
        private void accountBtn_Click(object sender, EventArgs e)
        {
            underLinePanel.Left = accountBtn.Left;
            underLinePanel.Width = accountBtn.Width;
            underLinePanel.Visible = true;
            var admin = new AdminAccount();
            ShowUserControl(admin);
        }
    }
}
