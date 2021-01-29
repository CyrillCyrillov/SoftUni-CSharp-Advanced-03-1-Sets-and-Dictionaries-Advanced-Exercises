using System;
using System.Collections.Generic;
using System.Linq;

namespace Task05_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();

            string inputString = Console.ReadLine();

            foreach (char element in inputString)
            {
                if(!symbolsCount.ContainsKey(element))
                {
                    symbolsCount.Add(element, 1);
                }
                else
                {
                    symbolsCount[element]++;
                }
                
            }

            foreach (var element in symbolsCount)
            {
                Console.WriteLine($"{element.Key}: {element.Value} time/s");
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
