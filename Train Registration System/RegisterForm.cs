using System.IO;
using System.Windows.Forms;

namespace Train_Registration_System
{
    public partial class RegisterForm : Form
    {
        bool _passwordVisible = false;
        readonly ErrorProvider errorProvider;
        public RegisterForm()
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
                    case "nameTxt":
                        pictureBox = userPictureBox;
                        break;
                    case "phoneTxt":
                        pictureBox = phonePictureBox;
                        break;
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
                    case "nameTxt":
                        pictureBox = userPictureBox;
                        break;
                    case "phoneTxt":
                        pictureBox = phonePictureBox;
                        break;
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
        private void Clear_Form()
        {
            nameTxt.Clear();
            phoneTxt.Clear();
            emailTxt.Clear();
            passwordTxt.Clear();

            userPictureBox.Show();
            phonePictureBox.Show();
            mailPictureBox.Show();
            lockPictureBox.Show();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear_Form();
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var validations = new Validations();
            string name = nameTxt.Text;
            string phone = phoneTxt.Text;
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            validations.IsValidForm(name, phone, email, password);
            Clear_Form();
        }
        private void BackToLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
        private void NameTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string name = nameTxt.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider.SetError(nameTxt, "Please fill this field.");
            }
            else
            {
                errorProvider.SetError(nameTxt, null);
            }
        }
        private void PhoneTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string phone = phoneTxt.Text.Trim();
            var validations = new Validations();

            if (!validations.IsValidPhoneNumber(phone))
            {
                errorProvider.SetError(phoneTxt, "Please enter a valid phone number.");
            }
            else
            {
                errorProvider.SetError(phoneTxt, null);
            }
        }
        private void EmailTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = emailTxt.Text.Trim();
            var validations = new Validations();

            if (!validations.IsValidEmail(email))
            {
                errorProvider.SetError(emailTxt, "Please enter a valid email.");
            }
            else
            {
                errorProvider.SetError(emailTxt, null);
            }
        }
        private void PasswordTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string password = passwordTxt.Text.Trim();
            if (string.IsNullOrEmpty(password) || password.Length < 6 || password.Length > 20)
            {
                errorProvider.SetError(passwordTxt, "Password must be more than 6 digits and less than 20.");
            }
            else
            {
                errorProvider.SetError(passwordTxt, null);
            }
        }
        private void PhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void RegisterFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
            Application.Exit();
        }
    }
}