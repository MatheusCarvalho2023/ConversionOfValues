using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double decimalFeet;
            double wholeFeet;
            double remainingFeet;
            double remainingInches;
            double inchesValue;

            // Names of both group members and programming experience
            Console.WriteLine("Matheus Santos and Nicholas Galen - Assignment 1 Part 2 \n");

            Console.WriteLine("Matheus Santos programming experience: Low \nNicholas Galen programming experience: Low \n");

            // Input with values in inches
            Console.Write("Enter a value in inches: ");
            inchesValue = Convert.ToDouble(Console.ReadLine());
           
            // Conversion of values into feet/inches
                decimalFeet = inchesValue / 12;
                wholeFeet = Math.Floor(decimalFeet);
                remainingFeet = decimalFeet - wholeFeet;
                remainingInches = Math.Round(remainingFeet * 12, 2);

                // Results in sentence form
                Console.WriteLine($"\nThe entered value is equivalent to {wholeFeet} feet and {remainingInches} inches.");

            // Exit the program
            Console.ReadKey();
        }
    }
}
