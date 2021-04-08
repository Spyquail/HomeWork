using System.Linq;
using System.Collections.Generic;
using System;

namespace HomeWork4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(rand.Next(0, 26));
            }
            foreach (var temp in list)
                Console.Write(temp + " ");
            Console.WriteLine();
            Console.WriteLine("Значения в пределах от 10 до 20 включительно (без повторения) в порядке убывания: ");
            var sortedList = list.Distinct().Where(x => ((x >= 10) && (x <= 20))).OrderBy(x => x);
            foreach (var temp in sortedList)
                Console.Write(temp + " ");
        }
    }
}
