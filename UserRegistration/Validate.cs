using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validate
    {
        string regexFirstName = @"^[A-Z][a-z]{2,}$";
        string regexLastName = @"^[A-Z][a-z]{2,}$";
        string regexEmail = @"^[a-z][a-z0-9.+-]+(\.[a-z0-9]+)?@[a-z0-9]+\.[a-z]{2,}(\.[a-z]{2,})?$";
        string regexPhoneNo = @"^[+][1-9][0-9]+\s[1-9][0-9]{9}$";
        string regexPassword = @"(?=.*[A-Z])(?=.*\w)(?=.*\d)(?=[^\W]*[\W][^\W]*$).{8,}$";

        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, regexFirstName) == true)
            {
                Console.WriteLine("First name is valid!");
                return true;
            }
            return false;

        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, regexLastName) == true)
            {
                Console.WriteLine("Last name is valid!");
                return true;
            }
            return false;
        }
        public bool ValidateEmail(string eMail)
        {
            if (Regex.IsMatch(eMail, regexEmail) == true)
            {
                Console.WriteLine("EmailId is valid!");
                return true;
            }
            return false;
        }
        public bool ValidatePhoneNo(string phoneNo)
        {
            if (Regex.IsMatch(phoneNo, regexPhoneNo) == true)
            {
                Console.WriteLine("Phone No is valid!");
                return true;
            }
            return false;
        }
        public bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, regexPassword) == true)
            {
                Console.WriteLine("Password is valid!");
                return true;
            }
            return false;
        }
    }
}

