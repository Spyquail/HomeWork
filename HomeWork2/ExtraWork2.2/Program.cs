using System;

namespace ExtraWork2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк ");
            int stringArray = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов ");
            int columnArray = Convert.ToInt32(Console.ReadLine());
            int[,] massive = new int[stringArray, columnArray];
            Random rnd = new Random();
            for (int i = 0; i < massive.GetLength(0); i++)
            { 
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = rnd.Next(0, 999);
                }
            }
            WriteArray(massive);
            int[,] turnedMassive = new int[columnArray, stringArray];
            for (int i = 0; i < turnedMassive.GetLength(0); i++) 
            {
                int tempVar = turnedMassive.GetLength(1) - 1; // Временная переменная для обратной записи значений
                for (int j = 0; j < turnedMassive.GetLength(1); j++)
                {
                    turnedMassive[i, j] = massive[tempVar, i];
                    tempVar--;
                }
            }
            Console.WriteLine();
            WriteArray(turnedMassive);
        }

        static void WriteArray(int[,] massive) // Метод для вывода массива в консоль
        {
            for (int i = 0; i < massive.GetLength(0); i++) 
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    if (massive[i, j] < 100)
                    {
                        if(massive[i, j] < 10)
                            Console.Write($"{massive[i, j]}   ");
                        else
                            Console.Write($"{massive[i, j]}  ");
                    }
                    else 
                        Console.Write($"{massive[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
