using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  12. Write a program to display how many duplicates are in an array.

            int[] money = {1, 5, 10, 20, 1,50, 20, 5, 100, 2, 10, 50 };

            int numberOfDuplicates = 0;

            for (int i = 0; i < money.Length; i++)
            {
                int count = 0;
                for (int j = i+1; j < money.Length; j++)
                {
                    if(money[i] == money[j])
                    {
                        count++;                       
                    }
                }
                numberOfDuplicates += count;
            }
            Console.WriteLine($"In array there are {numberOfDuplicates} duplicates");
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
