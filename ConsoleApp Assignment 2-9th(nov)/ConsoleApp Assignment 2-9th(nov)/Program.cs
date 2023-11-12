using System;
namespace ConsoleApp_Assignment_2_9th_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 natural numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); 

            
            Console.WriteLine("First 10 even natural numbers:");
            int evenCounter = 1;
            while (evenCounter <= 10)
            {
                if (evenCounter % 2 == 0)
                {
                    Console.Write(evenCounter + " ");
                }
                evenCounter++;
            }

            Console.WriteLine(); 

           
            Console.WriteLine("First 10 odd natural numbers:");
            int oddCounter = 1;
            do
            {
                if (oddCounter % 2 != 0)
                {
                    Console.Write(oddCounter + " ");
                }
                oddCounter++;
            } while (oddCounter <= 10);

        }
    }
}
