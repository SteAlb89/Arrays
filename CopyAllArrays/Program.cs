using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAllArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Write a program to copy all elements from one array to another.

            int[] numbers =  { 2, 4, 5, 6, 3, 6 };

            int[] newNumbers = new int[6];

            //Array.Copy(numbers, 0, newNumbers, 0, numbers.Length);

            newNumbers = numbers;

            foreach (int number in newNumbers)
            {
               Console.WriteLine(number);
            }
        }
    }
}
