using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program that displays all negative numbers in an array.

            int[] numers = new int[] { -12, 87, -35, 12, 23, -19,56, -413 };

            for (int i = 0; i < numers.Length; i++)
            {
                if (numers[i] < 0)
                {
                    Console.WriteLine($"The negative numbers from array are: {numers[i]}");
                }
            }

            Console.ReadKey();
        }
    }
}
