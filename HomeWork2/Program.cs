using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int arraySize = EnterValueInt();
            int[] massive = new int[arraySize];
            Console.WriteLine("Введите значения массива в порядке возрастания");
            for(int i = 0; i < massive.Length; i++)
            {
                Console.Write($"{i + 1} значение массива: ");
                massive[i] = EnterValueInt();
            }
            Console.WriteLine("Ваш массив:");
            foreach (int i in massive)
            {
                Console.Write($"{massive[i]} ");
            }
            int amountrUniqueNumbers = 1;
            for(int j = 1; j < massive.Length; j++)
            {
                if (massive[j] != massive[j - 1]) amountrUniqueNumbers++;
            }
            Console.WriteLine($"Количество разных чисел: {amountrUniqueNumbers}");
        }

        static int EnterValueInt()
        {
            int value;
            while (true) // Цикл для ввода размера массива и проверки значения
            {
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out value);
                if (check)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Такое значение не подходит, попробуйте ещё раз: ");
                }
            }

            return value;
        }
    }
}
