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
        private bool _passwordVisible = false;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear_Form();
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
        private void clear_Form()
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
        private void creatAccount_Click(object sender, EventArgs e)
        {
            var registerForm = new registerFrm();
            registerForm.Show();
            Close();
        }        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var authentication = new AuthenticationManager();
            if (authentication.Login(emailTxt.Text, passwordTxt.Text))
            {
                Close();
                return;
            }

            clear_Form();
        }
    }
}
