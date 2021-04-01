using System;
using System.Collections.Generic;

namespace ExtraWork3._2
{
    class Program
    {
        static List<int> numbers1 = new List<int>(0);
        static List<int> numbers2 = new List<int>(0);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа для первого набора (отрицательное число означает окончание ввода) ");
            Console.Write("Первое число: ");
            EnterNumbers(numbers1);
            PrintNumbers(numbers1);
            Console.WriteLine("Введите числа для второго набора (отрицательное число означает окончание ввода) ");
            Console.Write("Первое число: ");
            EnterNumbers(numbers2);
            PrintNumbers(numbers2);
            CheckNumbers();
        }
        static public void EnterNumbers(List<int> numbers)
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
        static public void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine("Введённые числа: ");
            foreach (var temp in numbers)
            {
                Console.Write($"{temp} ");
            }
            Console.WriteLine();
        }
        static public void CheckNumbers()
        {
            
        }
    }
}
