using System.IO;

namespace Train_Registration_System
{
    public partial class registerFrm : Form
    {
        private bool _passwordVisible = false;
        public registerFrm()
        {
            InitializeComponent();
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear_Form();
        }

        private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       
        private void backToLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            Hide();

        }

        private void clear_Form()
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

        private void registerBtn_Click(object sender, EventArgs e)
        {
            var validations = new Validations();
            validations.IsValidForm(nameTxt.Text, phoneTxt.Text, emailTxt.Text, passwordTxt.Text);
            clear_Form();
        }
    }
}