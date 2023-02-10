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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Train_Registration_System
{
    public partial class AdminAccount : UserControl
    {
        public AdminAccount()
        {
            InitializeComponent();
            var style = new Style();
            style.RoundButtonBorder(saveBtn);
        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {
            changePasswordLabel.Visible = false;
            saveBtn.Visible = true;
            changePasswordPanel.Visible = true;
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            PictureBox? lockPictureBox = null;
            switch (textBox.Name)
            {
                case "currentPasswordTxt":
                    lockPictureBox = lockPictureBox1;
                    break;
                case "newPasswordTxt":
                    lockPictureBox = lockPictureBox2;
                    break;
                case "confirmNewPasswordTxt":
                    lockPictureBox = lockPictureBox3;
                    break;
            }
            lockPictureBox?.Hide();
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            PictureBox? lockPictureBox = null;
            switch (textBox.Name)
            {
                case "currentPasswordTxt":
                    lockPictureBox = lockPictureBox1;
                    break;
                case "newPasswordTxt":
                    lockPictureBox = lockPictureBox2;
                    break;
                case "confirmNewPasswordTxt":
                    lockPictureBox = lockPictureBox3;
                    break;
            }
            if (textBox.Text == "")
                lockPictureBox?.Show();
        }
        
        private void AdminAccount_Load(object sender, EventArgs e)
        {
            var ticket = new Ticket();

            string[] allTickets = ticket.GetAllBookedTickets();
            string tickets = string.Join(" ", allTickets);

            bookedTicketsLabel.Text += tickets;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var message = new Style();
            try
            {
                string currentPassword = currentPasswordTxt.Text;
                string newPassword = newPasswordTxt.Text;
                string confirmPassword = confirmNewPasswordTxt.Text;

                ValidatePasswordChangeInput(currentPassword, newPassword, confirmPassword);

                bool passwordChanged = ChangePassword(currentPassword, newPassword);
            
                if (passwordChanged)
                    message.ShowSuccess("Password changed successfully!");
                else
                    message.ShowError("Incorrect current password. Please try again.");
            }
            catch (Exception ex)
            {
                message.ShowError(ex.Message);
            }
        }
        private void ValidatePasswordChangeInput(string currentPassword, string newPassword, string confirmPassword)
        {
            if (newPassword != confirmPassword)
            {
                throw new Exception("New password and confirm password do not match. Please try again.");
            }
        }
        private bool ChangePassword( string currentPassword, string newPassword)
        {
            var password = new Password();
            return password.AdminChangePassword(currentPassword, newPassword);
        }
    }
}
