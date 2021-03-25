using System;

namespace ExtraWork2._1
{
    class Program
    {
        static void Main(string[] args)   // Сложность алгоритма O(n)
        {
            Console.WriteLine("Введите размер матрицы n для формулы (2*n + 1): ");
            int enterVolue = Convert.ToInt32(Console.ReadLine());
            int arraySize = 2 * enterVolue + 1;
            int[,] massive = new int[arraySize, arraySize];
            int loopVariable = 1; // Переменная для смены направления
            int count = 0; // Счётчик для увеличения количества шагов
            int numberValues = 1; // Количество шагов в определённом направлении
            int positionVertical = enterVolue;  // Координаты элемента массива, с которым работаем в данный момент
            int positionHorisontal = enterVolue ;
            int volue = 0; // Переменная для заполнения массива
            int intermediativeVar = 0; // Промежуточная переменная для передачи значения из цикла
            while (true) // Цикл для заполнения массива с разными направлениями
            {
                switch (loopVariable)
                {
                    case 1: // up
                        for(int y = positionVertical; y >= (positionVertical - numberValues); y--)
                        {
                            massive[y, positionHorisontal] = volue; 
                            volue++;
                            intermediativeVar = y;
                            if (volue >= arraySize * arraySize) 
                                break; //Условие окончания массива и выход из цикла
                        }
                        positionVertical = intermediativeVar;
                        volue--;
                        break;
                    case 2: // left
                        for (int x = positionHorisontal; x >= (positionHorisontal - numberValues); x--)
                        {
                            massive[positionVertical, x] = volue;    
                            volue++;
                            intermediativeVar = x;
                        }
                        positionHorisontal = intermediativeVar;

                        volue--;
                        break;
                    case 3: // down
                        for (int y = positionVertical; y <= (positionVertical + numberValues); y++)
                        {
                            massive[y, positionHorisontal] = volue;
                            volue++;
                            intermediativeVar = y;
                        }
                        positionVertical = intermediativeVar;
                        volue--;
                        break;
                    case 4: // right
                        for (int x = positionHorisontal; x <= (positionHorisontal + numberValues); x++)
                        {
                            massive[positionVertical, x] = volue;
                            volue++;
                            intermediativeVar = x;
                        }
                        positionHorisontal = intermediativeVar;
                        volue--;
                        break;
                }
                count++;
                if(count == 2) // Условие для увеличения количества шагов и обнуления счётчика
                {
                    numberValues++;
                    count = 0;
                }
                if (loopVariable == 4) 
                    loopVariable = 1; // Условие для смены направления 
                else 
                    loopVariable++;
                if (volue >= (arraySize * arraySize) - 2) 
                    break; // Условие для выхода из цикла при окончании 
            }
            for (int i = 0; i < massive.GetLength(0); i++) // Цикл для вывода массива на консоль
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{massive[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
