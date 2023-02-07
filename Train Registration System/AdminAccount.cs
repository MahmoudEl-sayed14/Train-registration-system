﻿using System;
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
            PictureBox lockPictureBox = null;
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
            PictureBox lockPictureBox = null;
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

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            RoundButtonBorder(saveBtn);
            var data = new Data();

            string[] allTickets = data.GetAllBookedTickets();
            string tickets = string.Join(" ", allTickets);

            bookedTicketsLabel.Text += tickets;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPassword = currentPasswordTxt.Text;
                string newPassword = newPasswordTxt.Text;
                string confirmPassword = confirmNewPasswordTxt.Text;

                ValidatePasswordChangeInput(currentPassword, newPassword, confirmPassword);

                bool passwordChanged = ChangePassword(currentPassword, newPassword);
                if (passwordChanged)
                {
                    MessageBox.Show("Password changed successfully!", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorrect current password. Please try again.", "Password Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var data = new Data();
            return data.AdminChangePassword(currentPassword, newPassword);
        }
    }
}