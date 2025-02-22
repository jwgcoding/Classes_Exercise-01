﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_01
{
    public class Employee
    {
        // TODO: Create a private field _password of type string
        private string _password;

        // TODO: Create a public FirstName property of type string
        public string FirstName { get; set; }

        // TODO: Create a public LastName property of type string
        public string LastName { get; set; }
        // TODO: Create a public MiddleInitial property of type char
        public char MiddleInitial { get; set; }
        // TODO: Create a public EmailAddress property of type string
        public string EmailAddress { get; set; }
        // TODO: Create a public PhoneNumber property of type string
        public string PhoneNumber { get; set; }

        // TODO: Create a public Title property of type string
        public string Title { get; set; }
        // TODO: Create a public DateOfBirth property of type DateTime
        public DateTime DateOfBirth { get; set; }

        // TODO: Create a parameterized constructor that sets all of the properties correctly  
        public Employee(string firstName, char middle, string lastName, string emailAddress, string phoneNumber
            , string title, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleInitial = middle;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Title = title;
            DateOfBirth = dob;
        }
        
        // TODO: Create a method that sets the employee's password
            // TODO: Create a method to display the employee's password
            // TODO: Create an EmployeeReport() method that takes in an employee
            // and returns all of the props creatively displayed to the console

        public static void SetPassword(Employee e, string pass)
        {
            e._password = pass;
        }
       
        public static void ShowPassword(Employee e)
        {
            Console.WriteLine($"Your password is: {e._password}");
        }

        // TODO: Create an EmployeeReport() method that takes in an employee and returns all of the props creatively displayed to the console
        public static void EmployeeReport(Employee e)
        {
            Console.Write($"First Name:\t{e.FirstName}\n");
            Console.Write($"Middle Initial:\t{e.MiddleInitial}\n");
            Console.Write($"Last Name:\t{e.LastName}\n");
            Console.Write($"Email Address:\t{e.EmailAddress}\n");
            Console.Write($"Phone Number:\t{e.PhoneNumber}\n");
            Console.Write($"Title:\t{e.Title}\n");
            Console.Write($"DoB:\t{e.DateOfBirth}\n");
        }
    }

}
