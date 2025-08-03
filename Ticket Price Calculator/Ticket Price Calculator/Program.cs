using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********DCIT 318 ASSIGNMENT********");
            TicketPriceCalculator();
        }

        static void TicketPriceCalculator()
        {
                Console.Write("Enter your age: ");
                int age;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative");
                    continue;
                }

                break;
            }

            if (age <= 12 || age >= 65)
                Console.WriteLine("Your ticket is GHC 7");
            else
                Console.WriteLine("Your ticket is GHC 10");

                    
        }
    }
}
