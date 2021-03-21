using System;

namespace HomeWork_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int arraySize = EnterValueInt();
            int[,] massive = new int[arraySize, arraySize];
            for (int i = 0; i < massive.GetLength(1); i++)
            {
                for(int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{i + 1},{j + 1} значение массива: ");
                    massive[i, j] = EnterValueInt();
                }
            }
            Console.WriteLine("Ваша матрица:");
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{massive[i, j]} "); 
                }
                Console.WriteLine();
            }

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
