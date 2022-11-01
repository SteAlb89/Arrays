using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Write a program to display the maximum and minimum of an array.

            //int[] myArray = { 1,23,456,12345,67434,844355};

            //Console.WriteLine($"The minimum value number of this array is: {myArray.Min()}");
            //Console.WriteLine($"The maximum value number of this array is: {myArray.Max()}");

            int[] numbers = { 17, 25, 4, 586, 11, 1, 74, 32 };

            //int max = int.MinValue;
            //int min = int.MaxValue;

            //foreach(int i in numbers)
            //{
            //    if(i > max)
            //    {
            //        max = i;
            //    }
            //    else if(i < min)
            //    {
            //        min = i;
            //    }
            //}

            Array.Sort(numbers);
            //Console.WriteLine(String.Join(", ", numbers));

            Console.WriteLine($"Min = {numbers[0]} and Max = {numbers[numbers.Length -1] }");
            Console.ReadKey();
        }
    }
}
