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
            for (int i = 0; i < massive.GetLength(0); i++) // Цикл для ввода значений
            {
                for(int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{i + 1},{j + 1} значение массива: ");
                    massive[i, j] = EnterValueInt();
                }
            }
            Console.WriteLine("Ваша матрица:");
            for (int i = 0; i < massive.GetLength(0); i++) // Цикл для вывода массива на консоль
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{massive[i, j]} "); 
                }
                Console.WriteLine();
            }
            int symmetry = 1; // Переменная для проверки симметричности
            int matrixRow = 1; // Переменная для оптимизации проверки, чтобы не сравнить диагональ и дважды те же значения
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = matrixRow; j < massive.GetLength(1); j++)
                {
                    int check = massive[i, j] - massive[j, i]; // Проверка значений относительно дигонали у симмитречной матрицы равны 0
                    if (check != 0) symmetry = 0;
                }
                matrixRow++;
            }
            if(symmetry == 1)
            {
                Console.WriteLine("Матрциа симметрична");
            }
            else
            {
                Console.WriteLine("Матрица не симметрична");
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
