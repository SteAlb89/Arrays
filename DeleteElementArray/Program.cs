using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Write a program to delete an element from an array at a specified position.\

            string[] programmingLanguage = new string[6] { "Python", "C#", "Java", "JavaScript", "C", "C++" };

            foreach(string languageBefore in programmingLanguage)
            {
                Console.WriteLine($"Programming languages before removing : {languageBefore}");
            }

            Console.WriteLine("********************************************");

            Array.Clear(programmingLanguage, 1, programmingLanguage.Length-3);
            foreach(string languageAfter in programmingLanguage)
            {
                Console.WriteLine($"Programming languages after removing: {languageAfter}");
            }

            Console.ReadKey();
        }
    }
}
