using System;
using System.Collections.Generic;
using System.Linq;


namespace Task02_Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> firstSet = new HashSet<string>();
            HashSet<string> secondtSet = new HashSet<string>();

            int[] setsVolume = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int nFirstSet = setsVolume[0];
            int mSecondSet = setsVolume[1];

            for (int i = 1; i <= nFirstSet; i++)
            {
                firstSet.Add(Console.ReadLine());
            }

            for (int i = 1; i <= mSecondSet; i++)
            {
                secondtSet.Add(Console.ReadLine());
            }

            foreach (string element in firstSet)
            {
                if(secondtSet.Contains(element))
                {
                    Console.Write($"{element} ");
                }
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
