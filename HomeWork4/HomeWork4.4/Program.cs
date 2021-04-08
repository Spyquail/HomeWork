using System;
using System.Linq;
using System.Collections.Generic;


namespace HomeWork4._4
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
            Console.WriteLine("Количество различных чисел: " + list.Distinct().Count());
        }
    }
}
