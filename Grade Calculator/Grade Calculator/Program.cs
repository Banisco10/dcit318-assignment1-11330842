using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********DCIT 318 ASSIGNMENT********");
            GradeCalculator();
        }

        static void GradeCalculator()
        {
            Console.Write("Enter your grade(0-100): ");
            int grade;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out grade))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                    continue;
                }

                break; 
            }

            if (grade >= 90)
                Console.WriteLine("Your grade is: A");
            else if (grade >= 80)
                Console.WriteLine("Your grade is: B");
            else if (grade >= 70)
                Console.WriteLine("Your grade is: C");
            else if (grade >= 60)
                Console.WriteLine("Your grade is: D");
            else
                Console.WriteLine("Your grade is: F");
                

        }
    }
}
