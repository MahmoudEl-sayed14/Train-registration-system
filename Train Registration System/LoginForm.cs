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
    public partial class LoginForm : Form
    {
        bool _passwordVisible = false;
        readonly ErrorProvider errorProvider;
        public LoginForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }
        private void OnInputEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = null;
            if (sender is TextBox textBox)
            {
                switch (textBox.Name)
                {
                    case "emailTxt":
                        pictureBox = mailPictureBox;
                        break;
                    case "passwordTxt":
                        pictureBox = lockPictureBox;
                        break;
                }
            }

            pictureBox?.Hide();
        }
        private void OnInputLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = null;
            if (sender is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
            {
                switch (textBox.Name)
                {
                    case "emailTxt":
                        pictureBox = mailPictureBox;
                        break;
                    case "passwordTxt":
                        pictureBox = lockPictureBox;
                        break;
                }
            }

            pictureBox?.Show();
        }
        private void Clear_Form()
        {
            emailTxt.Clear();
            passwordTxt.Clear();

            mailPictureBox.Show();
            lockPictureBox.Show();
        }
        private void InitializePasswordVisibility()
        {
            passwordTxt.UseSystemPasswordChar = !_passwordVisible;
            hidePictureBox.Visible = !_passwordVisible;
            showPictureBox.Visible = _passwordVisible;
        }
        private void OnPasswordVisibilityToggle(object sender, EventArgs e)
        {
            _passwordVisible = !_passwordVisible;
            InitializePasswordVisibility();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear_Form();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var authentication = new AuthenticationManager();
            if (authentication.Login(emailTxt.Text, passwordTxt.Text))
            {
                this.Hide();
                return;
            }

            Clear_Form();
        }
        private void CreatAccount_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
        private void EmailTxt_Validating(object sender, CancelEventArgs e)
        {
            string email = emailTxt.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                errorProvider.SetError(emailTxt, "Please fill this field.");
            }
            else
            {
                errorProvider.SetError(emailTxt, null);
            }
        }
        private void PasswordTxt_Validating(object sender, CancelEventArgs e)
        {
            string password = passwordTxt.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                errorProvider.SetError(passwordTxt, "Please fill this field."); 
            }
            else
            {
                errorProvider.SetError(passwordTxt, null);
            }
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
            Application.Exit();
        }
    }
}
