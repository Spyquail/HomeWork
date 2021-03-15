using System;

namespace HomeWork1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 10 символов, обозначающих 4 стороны света на русском языке. Пример: сСюЮвВзЗЗЗ");
            
            
            int x = 0, y = 0;
            for(int i = 0; i < 10; i++)
            {
                char symbol = Convert.ToChar(Console.ReadLine());
                switch(symbol)
                {
                    case 'с': y++; break;
                    case 'С': y++; break;
                    case 'ю': y--; break;
                    case 'Ю': y--; break;
                    case 'в': x++; break;
                    case 'В': x++; break;
                    case 'з': x--; break;
                    case 'З': x--; break;
                    default:  Console.WriteLine("Нет такого пути"); break;
                }
            }
            double distace = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine($"Расстояние до точки: {distace}");
            
        }
    }
}
