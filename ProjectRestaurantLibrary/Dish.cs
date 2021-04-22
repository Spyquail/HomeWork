using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace ProjectRestaurantLibrary
{
    public class Dish
    {
        private string name;
        private string type;
        private int price;
        private int timeCooking;
        private string description;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0) 
                    price = value;
            }
        }
        public int TimeCooking
        {
            get
            {
                return timeCooking;
            }
            set
            {
                if (value >= 0)
                    timeCooking = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public void ChangeName()
        {
            Console.Write("Имя: ");
            string enteredName = EnterString(name);
            if (enteredName != "Esc")
                name = enteredName;
        }
        static public List<string> TypesFood = new List<string>();
        public void ChangeType()
        {
            
            string nameTxtTypesFood = "TypesFood.txt";
            if (File.Exists(nameTxtTypesFood))
            {
                using (StreamReader sr = new StreamReader(nameTxtTypesFood))
                {
                    while (true)
                    {
                        string readedType = sr.ReadLine();
                        if (readedType == null)
                            break;
                        TypesFood.Add(readedType);
                    }
                }
            }
            string enteredTypeFood = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Вы меняете " + name);
                Console.WriteLine("Текущий тип блюда:" + type);
                Console.WriteLine("Выберите новый тип блюда: ");
                int i = 1;
                for (i = 1; i <= TypesFood.Count; i++)
                {
                    Console.WriteLine(i + ". " + TypesFood[i - 1]);
                }
                Console.WriteLine("Для добавления нового типа введите " + i);
                string enteredSymbol = Program.EnterString();
                int stringToInt;
                Console.Clear();
                if (int.TryParse(enteredSymbol, out stringToInt))
                {
                    if ((i - stringToInt) >= 0)
                    {
                        if (stringToInt == i)
                        {
                            Program.AddTypeFood();
                        }
                        else
                        {
                            type = Program.TypesFood[stringToInt - 1];
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нет такого типа. Нажмите любую клавиш для возврата...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    if (enteredSymbol.Equals("Esc"))
                        break;
                    Console.WriteLine("Нет такого типа. Нажмите любую клавиш для возврата...");
                    Console.ReadKey();
                }
            }
        }
        public void ChangePrice()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Редактируемое блюдо: " + name);
                int editedPrice;
                Console.Write("Цена: ");
                string enteredSymbol = EnterString(price.ToString());
                if (int.TryParse(enteredSymbol, out editedPrice))
                {
                    price = editedPrice;
                    break;
                }
                else
                {
                    if (enteredSymbol.Equals("Esc"))
                        break;
                    Console.WriteLine("Неверное значение");
                    Console.WriteLine("Для возвращения нажмите любую клавишу...");
                    Console.ReadKey();
                }   
            }
        }
        public void ChangeTimeCooking()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Редактируемое блюдо: " + name + " Время указано в минутах");
                int editedTimeCooking;
                Console.Write("Время готовки: ");
                string enteredSymbol = EnterString(price.ToString());
                if (int.TryParse(enteredSymbol, out editedTimeCooking))
                {
                    price = editedTimeCooking;
                    break;
                }
                else
                {
                    if (enteredSymbol.Equals("Esc"))
                        break;
                    Console.WriteLine("Неверное значение");
                    Console.WriteLine("Для возвращения нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
        }
        public void ChangeDescription()
        {
            Console.Write("Описание: ");
            string enteredDescription = EnterString(Description);
            if (enteredDescription != "Esc")
                description = enteredDescription;
        }
        static string EnterString(string Default)
        {

            int pos = Console.CursorLeft;
            Console.Write(Default);
            ConsoleKeyInfo info;
            List<char> chars = new List<char>();
            if (string.IsNullOrEmpty(Default) == false)
            {
                chars.AddRange(Default.ToCharArray());
            }

            while (true)
            {
                info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.Backspace && Console.CursorLeft > pos)
                {
                    chars.RemoveAt(chars.Count - 1);
                    Console.CursorLeft -= 1;
                    Console.Write(' ');
                    Console.CursorLeft -= 1;

                }
                else if (info.Key == ConsoleKey.Enter) 
                { 
                    Console.Write(Environment.NewLine); 
                    break; 
                }
                else
                {
                    if(info.Key == ConsoleKey.Spacebar)
                    {
                        Console.Write(' ');    
                    }
                    else
                    {
                        if(info.Key == ConsoleKey.Escape)
                        {
                            return "Esc";
                        }
                        else
                        {
                            if (char.IsLetterOrDigit(info.KeyChar))
                            {
                                Console.Write(info.KeyChar);
                                chars.Add(info.KeyChar);
                            }
                        }
                    }
                }
            }
            return new string(chars.ToArray());
        }
        public override string ToString()
        {
            return name + " Цена: " + price + " руб";
        }
        public Dish(string name, string type, int price, int timeCooking, string description)
        {
            this.name = name;
            this.type = type;
            this.price = price;
            this.timeCooking = timeCooking;
            this.description = description;
        }
        public Dish()
        {
            name = "Не указано";
            type = "Не определён";
            price = 0;
            timeCooking = 0;
            description = "";
        }

        
    }

}
