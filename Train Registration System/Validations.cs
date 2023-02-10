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
        public bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            string pattern = @"^(010|011|012|015)\d{8}$";
            return Regex.IsMatch(phone, pattern);
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" +
                             "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            return Regex.IsMatch(email, pattern);
        }
        public void IsValidForm(string name, string phone, string email, string password)
        {
            string[] formFields = { name, phone, email, password };
            var message = new Style();

            if (formFields.Any(string.IsNullOrWhiteSpace))
            {
                message.ShowError("Please fill all form fields.");
                return;
            }

            if (!IsValidEmail(email))
            {
                message.ShowError("Please enter a valid email address.");
                return;
            }

            if (!IsValidPhoneNumber(phone))
            {
                message.ShowError("Please enter a valid phone number.");
                return;
            }

            var user = new User();
            user.InsertUser(name, email, phone, password);
            message.ShowSuccess("Account created successfully.");
        }        
    }
}
