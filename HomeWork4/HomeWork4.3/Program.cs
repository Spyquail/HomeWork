using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(rand.Next(0, 101));
            }
            foreach (var temp in list)
                Console.Write(temp + " ");
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент: " + max(list));
            Console.WriteLine("Минимальный элемент: " + min(list));
        }
        static int max(List<int> list)
        {
           list.OrderBy(x => x);
            int output = list.Distinct().OrderBy(x => x).Last();
            return output;
        }
        static int min(List<int> list)
        {
            list.OrderBy(x => x);
            int output = list.Distinct().OrderBy(x => x).First();
            return output;
        }
    }
}
