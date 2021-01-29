using System;
using System.Collections.Generic;
using System.Linq;

namespace Task01_Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
