using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_assignment_4_9th_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("\nSum of elements: " + sum);

            double average = (double)sum / numbers.Length;
            Console.WriteLine("Average of elements: " + average);

        }
    }
}
