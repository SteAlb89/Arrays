using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11. Write a program to reverse the elements in an array.

            int[] positionMovement = { 23, 53, 74, 12, 2, 45, 98 };

            Array.Reverse(positionMovement);
            foreach (int position in positionMovement)
            {
                Console.Write(position + " ");
            }
            Console.ReadKey();
        }
    }
}
