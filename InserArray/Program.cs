using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. Write a program to insert an element into an array at a specified position.

            string[] myWorkers = new string[] { "Jackie", "Sebastian", "Florian", "Gert" };

            myWorkers[myWorkers.Length - 1] = "Stefan";

            foreach(string worker in myWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.ReadKey();
        }
    }
}
