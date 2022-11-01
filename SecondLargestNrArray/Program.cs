using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestNrArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Write a program to display the second largest element in an array.

            int[] numbers = new int[6];
           for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Insert a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);
            Console.WriteLine(numbers[numbers.Length -2]);

            Console.ReadKey();
        }
    }
}
