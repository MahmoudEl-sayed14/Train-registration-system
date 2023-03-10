using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Train_Registration_System
{
    internal class Validations : Paths
    {
        public bool IsValidPhoneNumber(string phone)
        {
            string[] phonesNumber = File.ReadAllLines(PhonePath);
            string pattern = @"^(010|011|012|015)\d{8}$";
            return !(phonesNumber.Contains(phone)) && Regex.IsMatch(phone, pattern);
        }
        public bool IsValidEmail(string email)
        {
            string []emails = File.ReadAllLines(EmailPath);
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" +"@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            return !(emails.Contains(email)) && Regex.IsMatch(email, pattern);
        }
        public bool IsvalidName(string name)
        {
            string[] names = File.ReadAllLines(UserNamePath);
            return !names.Contains(name);
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
                message.ShowError("The email address is already in use by another user or is invalid;\nPlease enter a valid email address. ");
                return;
            }
            if (!IsValidPhoneNumber(phone))
            {
                message.ShowError("The phone number is used by another user or is not a valid phone number;\nPlease enter a valid phone number.");
                return;
            }
            if (!IsvalidName(name))
            {
                message.ShowError("Name you have provided is currently in use by another user.");
                return;
            }

            var user = new User();
            user.InsertUser(name, email, phone, password);
            message.ShowSuccess("Account created successfully.");
        }        
    }
}
