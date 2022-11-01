using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UniquArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13. Write a program to display all the unique elements in an array.



            int[] money = { 50, 1, 5, 10, 20, 1, 50, 20, 5, 100, 2, 10, 50 };

            Console.Write("The unique elements in an array are: ");

            for (int i = 0; i < money.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (money[i] == money[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.Write(money[i] + ",");
                }
            }

            Console.ReadKey();
        }
    }
}
