using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 15.Write a program to separate the elements from an array into 2 other arrays(even and odd).

            int[] numbers = new int[] { 1, 2, 3, 22, 31, 42, 59, 80, 11, 17, 14 };

            //Task 1: Find out how many odd and even numbers are in array
            int evenCount = 0;
            int oddCount = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    evenCount++;
                else
                    oddCount++;

            }
            
            int[] oddNumbers = new int[oddCount];
            int[] evenNumbers = new int[evenCount];

            int j = 0;
            int k = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[j] = numbers[i];
                    j++;
                }
                else
                {
                    oddNumbers[k] = numbers[i];
                    k++;
                }
            }
            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine($"Even numbers are: {evenNumbers[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < oddNumbers.Length; i++)
            {
                Console.WriteLine($"Odd numbers are: {oddNumbers[i]}");
            }


            Console.ReadKey();
        }
    }
}
