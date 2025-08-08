using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Activity1who_are_you
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration System");


            // Get first name
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine().Trim();

            // Get last name
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine().Trim();

            // Combine first and last names
            string fullName = firstName + " " + lastName;

            // Display the full name
            Console.WriteLine($"Full Name: {fullName}");
        }
    }
    }

















