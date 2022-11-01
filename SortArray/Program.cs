using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10. Write a program to sort an array.

            int[] positionMovement = { 100,1, 30025,23, 53, 74, 12, 2, 45, 98,0 };

            Array.Sort(positionMovement);
            foreach(int position in positionMovement)
            {
                Console.Write(position + " ");
            }
            
            Console.ReadKey();
        }
    }
}
