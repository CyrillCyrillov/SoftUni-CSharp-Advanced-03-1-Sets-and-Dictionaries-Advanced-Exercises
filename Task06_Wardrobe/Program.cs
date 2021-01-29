using System;
using System.Collections.Generic;
using System.Linq;

namespace Task06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrope = new Dictionary<string, Dictionary<string, int>>();

            int numbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                string[] nextLineInfo = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = nextLineInfo[0];

                string[] dress = nextLineInfo[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(!wardrope.ContainsKey(color))
                {
                    wardrope.Add(color, new Dictionary<string, int>());
                }

                foreach (string element in dress)
                {
                    if (!wardrope[color].ContainsKey(element))
                    {
                        wardrope[color].Add(element, 1);
                    }
                    else
                    {
                        wardrope[color][element]++;
                    }
                }
            }

            string[] lookFor = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string lookColor = lookFor[0];
            string lookDress = lookFor[1];

            foreach (var element in wardrope)
            {
                Console.WriteLine($"{element.Key} clothes:");
                foreach (var item in element.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if(element.Key == lookColor && item.Key == lookDress)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
