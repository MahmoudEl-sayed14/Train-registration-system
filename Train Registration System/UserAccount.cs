using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Registration_System
{
    public partial class UserAccount : UserControl
    {
        readonly string email;
        public UserAccount(string email)
        {
            InitializeComponent();
            this.email = email;
            var style = new Style();
            style.RoundButtonBorder(saveBtn);
            style.RoundButtonBorder(cancelBtn);
        }
        
        private void ValidatePasswordChangeInput(string newPassword, string confirmPassword)
        {
            if (newPassword != confirmPassword)
            {
                throw new Exception("New password and confirm password do not match. Please try again.");
            }
        }
        private bool ChangePassword(string email, string currentPassword, string newPassword)
        {
            var password = new User();
            if(email == "admin")
            {
                return password.UserChangePassword("admin", currentPassword, newPassword);
            }
            return password.UserChangePassword(email, currentPassword, newPassword);
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
        private void Account_Load(object sender, EventArgs e) 
        {
            if (email == "admin")
            {
                changePasswordPanel.Visible = true;
                changePasswordLabel.Visible = false;
                saveBtn.Visible = true;
                cancelBtn.Visible = true;
                return;
            }
            var user = new User();
            var userData = user.GetUserData(email);

            nameLabel.Text = $"Name : {userData["name"]}";
            emailLabel.Text = $"Email : {email}";
            phoneLabel.Text = $"Phone : {userData["phone"]}";
        }
        private void Clear()
        {
            currentPasswordTxt.Clear();
            newPasswordTxt.Clear();
            confirmNewPasswordTxt.Clear();

            lockPictureBox1.Show();
            lockPictureBox2.Show();
            lockPictureBox3.Show();
        }
        private void ChangePasswordLabel_Click(object sender, EventArgs e)
        {
            changePasswordLabel.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            changePasswordPanel.Visible = true;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var message = new Style();
            try
            {
                string currentPassword = currentPasswordTxt.Text;
                string newPassword = newPasswordTxt.Text;
                string confirmPassword = confirmNewPasswordTxt.Text;

                ValidatePasswordChangeInput(newPassword, confirmPassword);
                bool passwordChanged = ChangePassword(email, currentPassword, newPassword);

                if (passwordChanged)
                    message.ShowSuccess("Password changed successfully!");
                else
                    message.ShowError("Incorrect current password. Please try again.");

                Clear();
            }
            catch (Exception ex)
            {
                message.ShowError(ex.Message);
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
