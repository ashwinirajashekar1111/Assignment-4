using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment5_9th_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your exam score as a percentage: ");
            double examScore = Convert.ToDouble(Console.ReadLine());

            if (examScore >= 90)
            {
                Console.WriteLine("Your letter grade is A.");
            }
            else if (examScore >= 80)
            {
                Console.WriteLine("Your letter grade is B.");
            }
            else if (examScore >= 70)
            {
                Console.WriteLine("Your letter grade is C.");
            }
            else if (examScore >= 60)
            {
                Console.WriteLine("Your letter grade is D.");
            }
            else
            {
                Console.WriteLine("Your letter grade is F.");
            }

        }
    }
}
