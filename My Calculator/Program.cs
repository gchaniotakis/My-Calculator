using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // place this code inside Program.cs, within the Main method

            // Declare variables and then instantiate to zero
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt16(Console.ReadLine());     //Answer to Question 5
            // Line 13: convert num1 to integer

            // Ask the user to type the second number
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt16(Console.ReadLine());     //Answer to Question 5
            // Line 18: convert num2 to integer

            // Ask the user to choose an option
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Your result: {num1} + {num2} = " + (num1 + num2)); // Line 32
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                // Return text for an incorrect option entry
                default:
                    Console.WriteLine("That is an incorrect option entry, please try again.");
                    break;
            }
            // Wait for the user to respond before closing
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
