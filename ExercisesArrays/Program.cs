using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program that displays the elements of an array in different rows.

            int[] numbers = new int[4] { 1, 9, 8, 9 };
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
