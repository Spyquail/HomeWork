using System;
using System.Collections.Generic;

namespace ProjectRestaurant
{
    class Program
    {
        
            static public string[] MenuStrings =
        {
            "1 - Добавить новый формат",
            "2 - Удалить формат",
            "3 - Вывести весь списое форматов",
            "4 - Вывести определённый формат по короткому описанию",
            "5 - Выход"
        };
            static Dictionary<string, string> formats = new Dictionary<string, string>(5);

            static public void PrintMenu()
            {
                Console.Clear();
                Console.WriteLine("***ФОРМАТЫ ФАЙЛОВ***");
                foreach (var menuString in MenuStrings)
                {
                    Console.WriteLine(menuString);
                }
                Console.WriteLine("Нажмите цифру, соответствующую пункту меню.");
            }
            static public void InitializationFormat()
            {
                formats.Add(".png", "Portable network graphics");
                formats.Add(".pdf", "Portable Document Format");
                formats.Add(".csv", "Comma-Separated Values ");
                formats.Add(".gif", "Graphics Interchange Format");
                formats.Add(".jpeg", "Joint Photographic Experts Group");
            }
            static public void PrintFormat()
            {
                Console.Clear();
                foreach (KeyValuePair<string, string> keyValue in formats)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }
                Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            static public void AddFormat()
            {
                Console.Clear();
                Console.WriteLine("Введите расширение файла в виде .abc : ");
                string enteredShortFormat = Console.ReadLine();
                bool checkFormat = formats.ContainsKey(enteredShortFormat);
                if (checkFormat)
                {
                    Console.WriteLine("Такой формат уже есть");
                }
                else
                {
                    Console.WriteLine("Введите полное название формата: ");
                    string enteredFullFormat = Console.ReadLine();
                    formats.Add(enteredShortFormat, enteredFullFormat);
                    Console.WriteLine("Новый формат добавлен");
                }
                Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            static public void RemoveFormat()
            {
                Console.Clear();
                Console.WriteLine("Введите расширение файла которое хотите удалить в виде .abc :");
                string enteredShortFormat = Console.ReadLine();
                bool checkFormat = formats.ContainsKey(enteredShortFormat);
                if (checkFormat)
                {
                    formats.Remove(enteredShortFormat);
                    Console.WriteLine("Формат успешно удалён");
                }
                else
                {
                    Console.WriteLine("Такого формата нет ");
                }

                Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            static public void OutputFormatDesription()
            {
                Console.Clear();
                Console.WriteLine("Введите расширение в виде .abc :");
                string enteredShortFormat = Console.ReadLine();
                bool checkFormat = formats.ContainsKey(enteredShortFormat);
                if (checkFormat)
                {
                    Console.WriteLine(formats[enteredShortFormat]);
                }
                else
                {
                    Console.WriteLine("Такого формата нет ");
                }
                Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                InitializationFormat();
                ConsoleKey key = ConsoleKey.Enter;
                do
                {
                    PrintMenu();
                    key = Console.ReadKey().Key;
                    switch (key)
                    {
                        case ConsoleKey.D1:
                            AddFormat();
                            break;
                        case ConsoleKey.D2:
                            RemoveFormat();
                            break;
                        case ConsoleKey.D3:
                            PrintFormat();
                            break;
                        case ConsoleKey.D4:
                            OutputFormatDesription();
                            break;
                        default: continue;
                    }
                } while (key != ConsoleKey.D5);
                Console.Clear();
                Console.WriteLine("Удачи!");

            }
    }
}
