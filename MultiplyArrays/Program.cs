using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.Write a program that displays the product of the odd elements in an array.
            int[] numbers = new int[] { 2, 4, 1, 3 ,5};
            int product = 1;

            for (int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    product *= numbers[i];
                }    
            }
            Console.WriteLine($"The product of the odd numbers is : {product}");

            Console.ReadKey();
        }
    }
}
