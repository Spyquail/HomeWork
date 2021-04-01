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
            Console.WriteLine("Первый набор чисел: ");
            PrintNumbers(numbers1);
            Console.WriteLine("Второй набор чисел: ");
            PrintNumbers(numbers2);
            CheckNumbers();
            Console.WriteLine("Первая самая длинная последовательность чисел, которая есть в обоих наборах: ");
            PrintNumbers(numbers4);
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
            foreach (var temp in numbers)
            {
                Console.Write($"{temp} ");
            }
            Console.WriteLine();
        }
        static List<int> numbers3 = new List<int>(0);
        static List<int> numbers4 = new List<int>(0);
        static public void CheckNumbers()
        {
            for (int i = 0; i < numbers1.Count; i++)
            {
                for (int j = 0; j < numbers2.Count; j++)
                {
                    if (numbers1[i] == numbers2[j])
                    {
                        numbers3.Add(numbers1[i]);
                        i++;
                    }
                    else
                    {
                        if (numbers3.Count > numbers4.Count)
                        {
                            numbers4.Clear();
                            for (int k = 0; k < numbers3.Count; k++)
                                numbers4.Add(numbers3[k]);
                            numbers3.Clear();
                        }
                        else
                            numbers3.Clear();
                    }
                }
                if (numbers3.Count > numbers4.Count)
                {
                    numbers4.Clear();
                    for (int k = 0; k < numbers3.Count; k++)
                        numbers4.Add(numbers3[k]);
                    numbers3.Clear();
                }   
            }
        }
    }
}
