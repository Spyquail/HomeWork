using System;

namespace ExtraWork2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы n для формулы (2*n + 1): ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            arraySize = 2 * arraySize + 1;
            int[,] massive = new int[arraySize, arraySize];
            for (int i = 0; i < massive.GetLength(1); i++) // Цикл для ввода значений
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{i + 1},{j + 1} значение массива: ");
                    massive[i, j] = EnterValueInt();
                }
            }
        }
    }
}
