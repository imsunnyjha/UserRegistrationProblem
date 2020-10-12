using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem!");

                Validate validate = new Validate();
            FirstName:
                Console.WriteLine("Enter First Name: ");
                string firstName = Console.ReadLine();
                if (validate.ValidateFirstName(firstName) == false)
                {
                    goto FirstName;
                }
            LastName:
                Console.WriteLine("Enter Last Name: ");
                string lastName = Console.ReadLine();
                if (validate.ValidateLastName(lastName) == false)
                {
                    goto LastName;
                }
            EMail:
                Console.WriteLine("Enter EmailId: ");
                string eMail = Console.ReadLine();
                if (validate.ValidateEmail(eMail) == false)
                {
                    goto EMail;
                }
            PhoneNo:
                Console.WriteLine("Enter Phone No: ");
                string phoneNo = Console.ReadLine();
                if (validate.ValidatePhoneNo(phoneNo) == false)
                {
                    goto PhoneNo;
                }
            Password:
                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine();
                if (validate.ValidatePassword(password) == false)
                {
                    goto Password;

                }
        }
    }
}

