using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> elements = new HashSet<string>();

            SortedSet<string> elements = new SortedSet<string>();
            
            int linesNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= linesNumber; i++)
            {
                string[] nextElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string element in nextElements)
                {
                    elements.Add(element);
                }
            }

            foreach (string element in elements) //.OrderBy(x => x))
            {
                Console.Write($"{element} ");
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
