using System;
using System.Collections.Generic;

namespace ExtraWork3._1
{
    class Program
    {
        static List<int> numbers = new List<int>(0);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа (отрицательное число означает окончание ввода) ");
            Console.Write("Первое число: ");
            EnterNumbers();
            PrintNumbers();
            CheckNumbers();
        }
        static public void EnterNumbers()
        {
            int enteredValue = 1;
            while (enteredValue >= 0)
            {
                while (true) // Цикл для ввода размера массива и проверки значения
                {
                    string input = Console.ReadLine();
                    bool check = int.TryParse(input, out enteredValue);
                    if (check)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Такое значение не подходит, попробуйте ещё раз: ");
                    }
                }
                numbers.Add(enteredValue);
                Console.Write("Следующее число: ");
            }
            Console.Clear();
            numbers.Remove(enteredValue);
        }
        static public void PrintNumbers()
        {
            Console.WriteLine("Введённые числа: ");
            foreach(var temp in numbers)
            {
                Console.Write($"{temp} ");
            }
            Console.WriteLine();
        }
        static public void CheckNumbers()
        {
            int count = 0;
            for(int i = 1; i < (numbers.Count - 1); i++)
            {
                if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
                    count++;
            }
            Console.WriteLine($"Количество чисел, у которых есть соседи со значением меньше самого числа: {count}");
        }
    }
}
