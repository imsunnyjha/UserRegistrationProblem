using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem!");

            //FirstName Validation
            while (true)
            {
                string firstNamePattern = @"^[A-Z][a-z]{2,}$";
                Console.WriteLine("Enter First Name: ");
                string firstName = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(firstName, firstNamePattern))
                    {
                        Console.WriteLine("First Name: " + firstName + " validated!");
                        break;
                    }
                    else
                    {
                        throw new UserRegistrationCustomException("First letter must be capital and minimum of length 3");
                    }
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //LastName Validation
            while (true)
            {
                string lastNamePattern = @"^[A-Z][a-z]{2,}$";
                Console.WriteLine("Enter Last Name: ");
                string lastName = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(lastName, lastNamePattern))
                    {
                        Console.WriteLine("Last Name: " + lastName + " validated!");
                        break;
                    }
                    else
                    {
                        throw new UserRegistrationCustomException("First letter must be capital and minimum of length 3");
                    }
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //EmailId Validation
            while (true)
            {
                string emailIdPattern = @"^[a-z][a-z0-9.+-]+(\.[a-z0-9]+)?@[a-z0-9]+\.[a-z]{2,}(\.[a-z]{2,})?$";
                Console.WriteLine("Enter Email Id: ");
                string emailId = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(emailId, emailIdPattern))
                    {
                        Console.WriteLine("Email Id: " + emailId + " validated!");
                        break;
                    }
                    else
                    {
                        throw new UserRegistrationCustomException("Email Id should be in proper format!");
                    }
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //Mobile Number Validation
            while (true)
            {
                string mobileNumberPattern = @"^[+][1-9][0-9]+\s[1-9][0-9]{9}$";
                Console.WriteLine("Enter Mobile Number: ");
                string mobileNumber = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(mobileNumber, mobileNumberPattern))
                    {
                        Console.WriteLine("Mobile Number: " + mobileNumber + " validated!");
                        break;
                    }
                    else
                    {
                        throw new UserRegistrationCustomException("Mobile Number should be in proper format with country code!");
                    }
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //Password Generation
            while (true)
            {
                string passwordPattern = @"(?=.*[A-Z])(?=.*\w)(?=.*\d)(?=[^\W]*[\W][^\W]*$).{8,}$";
                Console.WriteLine("Enter Password of minimum 8 characters: ");
                string password = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(password, passwordPattern))
                    {
                        Console.WriteLine("Password validated!");
                        break;
                    }
                    else
                    {
                        throw new UserRegistrationCustomException("Password should be in proper format!");
                    }
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("USER REGISTERED SUCCESFULLY!");
        }
    }
}

