using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Write a program that displays the sum of the elements of an array.

            int[] numbers = new int[] { 1, 4, 6, 7, 3 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i]; 
            }
            Console.WriteLine($"The sum of all the numbers from an array are: {sum}");

            Console.ReadKey();
        }
    }
}
