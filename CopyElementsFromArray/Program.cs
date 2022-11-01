using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyElementsFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program which copy a specifiec element from one array to other !

            int[] firstNumbers = new int[] { 4, 3, 6, 7, 8, 9 };

            int[] secondNumbers = new int[10];

            //Array.Copy(firstNumbers,secondNumbers,2);
            secondNumbers[0] = firstNumbers[0];

            foreach (int number in secondNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
