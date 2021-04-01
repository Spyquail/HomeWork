using System;
using System.Collections.Generic;

namespace HomeWork3._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите время работы почты в минутах: ");
            int totalMinutes = EnterInt();
            Console.Write("Введите количество посетителей: ");
            int numberVisitors = EnterInt();
            Queue<int> time = new Queue<int>();
            Console.WriteLine("Введите количество времени, которое потребуется на каждого посетителя");
            for (int i = 1; i <= numberVisitors; i++)
            {
                Console.Write($"На {i} посетителя потратиться: ");
                time.Enqueue(EnterInt());
            }
            int visitorsServed = 0;
            while((totalMinutes > 0) && (time.Count != 0))
            {
                totalMinutes -= time.Dequeue();
                visitorsServed++;
            }
            Console.Write($"Количество необслуженных посетителей: {numberVisitors - visitorsServed}");
        }
        static int EnterInt() // Метод для ввода числа и проверки, что это целое положительное число
        {

            int value;
            while (true)
            {
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out value);
                if (check)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Такие значения не подходят, попробуй другоей значение :) ");
                        Console.Write("Ваше значение: ");
                    }
                    else
                        break;
                }
                else
                {
                    Console.WriteLine("Такое значение не подходит, попробуй ещё раз :) ");
                    Console.Write("Ваше значение: ");
                }
            }
            return value;
        }
    }
    
}
