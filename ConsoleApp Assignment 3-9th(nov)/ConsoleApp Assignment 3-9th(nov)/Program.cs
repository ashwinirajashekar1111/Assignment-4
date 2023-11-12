using System;
namespace ConsoleApp_Assignment_3_9th_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            int first = 0, second = 1;

            Console.WriteLine("First 10 numbers in the Fibonacci sequence:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(first + " ");

                int temp = first;
                first = second;
                second = temp + second;


            }
        }
    }
}

