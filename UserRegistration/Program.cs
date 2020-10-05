﻿using System;
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
                Console.WriteLine("First Name: " + firstName + " validated!");

            //LastName Validation
            string lastNamePattern = @"^[A-Z][a-z]{2,}$";
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            if (!Regex.IsMatch(lastName, lastNamePattern))
                Console.WriteLine("Last Name should be in proper format!");
            else
                Console.WriteLine("Last Name: " + lastName + " validated!");

            //EmailId Validation
            string emailIdPattern = @"^[a-z][a-z0-9]+(\.[a-z0-9]+)?@[a-z0-9]+\.[a-z]{2,}(\.[a-z]{2,})?$";
            Console.WriteLine("Enter Email Id: ");
            string emailId = Console.ReadLine();
            if (!Regex.IsMatch(emailId, emailIdPattern))
                Console.WriteLine("Email Id should be in proper format!");
            else
                Console.WriteLine("Email Id: " + emailId + " validated!");
        }
    }
}
