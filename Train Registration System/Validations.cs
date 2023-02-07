using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class Validations
    {
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            string pattern = @"^(010|011|012|015)\d{8}$";
            return Regex.IsMatch(phone, pattern);
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" +
                             "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            return Regex.IsMatch(email, pattern);
        }
        public void IsValidForm(string name, string phone, string email, string password)
        {
            string[] formFields = { name, phone, email, password };

            if (formFields.Any(string.IsNullOrWhiteSpace))
            {
                ShowError("Please fill all form fields.");
                return;
            }

            if (!IsValidEmail(email))
            {
                ShowError("Please enter a valid email address.");
                return;
            }

            if (!IsValidPhoneNumber(phone))
            {
                ShowError("Please enter a valid phone number.");
                return;
            }

            var data = new Data();
            data.InsertData(name, email, phone, password);
            ShowSuccess("Account created successfully.");
        }
        
        public bool LoginUser(string email, string password)
        {
            switch (email)
            {
                case "admin":
                    if (FindAdmin(password))
                    {
                        new AdminDashboard().Show();
                        return true;
                    }
                    break;
                default:
                    if (FindUser(email, password))
                    {
                        new UserDashboard(email).Show();
                        return true;
                    }
                    break;
            }

            ShowError("Incorrect Email or Password");
            return false;
        }
        private bool FindAdmin(string password)
        {
            var data = new Data();
            return data.FindAdmin(password);
        }

        private bool FindUser(string email, string password)
        {
            var data = new Data();
            return data.FindUser(email, password);
        }
    }
}
