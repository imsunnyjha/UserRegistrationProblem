using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem!");

            //FirstName Validation
            string firstNamePattern = @"^[A-Z][a-z]{2,}$";
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            if (!Regex.IsMatch(firstName, firstNamePattern))
                Console.WriteLine("First Name should be in proper format!");
            else
                Console.WriteLine(value: firstName + " validated!");
        }
    }
}
