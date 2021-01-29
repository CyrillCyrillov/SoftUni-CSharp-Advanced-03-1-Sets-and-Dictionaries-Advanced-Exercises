using System;
using System.Collections.Generic;
using System.Linq;

namespace Task04_Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countNumbers = new Dictionary<string, int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string nextNumber = Console.ReadLine();
                if (!countNumbers.ContainsKey(nextNumber))
                {
                    countNumbers.Add(nextNumber, 1);
                }
                else
                {
                    countNumbers[nextNumber]++;
                }
            }

            foreach (var element in countNumbers)
            {
                if((element.Value) % 2 == 0)
                {
                    Console.WriteLine(element.Key);
                    break;
                }
            }
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
