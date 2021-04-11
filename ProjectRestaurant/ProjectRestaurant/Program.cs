using System;
using System.Collections.Generic;

namespace ProjectRestaurant
{
    class Program
    {
        
        static public string[] MenuStrings =
        {
        "1 - Просмотреть всё меню",
        "2 - Поиск блюда",
        "3 - Вывести блюда определённого типа",
        "4 - Администрирование",
        "5 - Выход"
        };
        static public string[] AdminMenuStrings =
        {
        "1 - Добавить блюдо",
        "2 - Удалить блюдо",
        "3 - Добавить тип блюда",
        "4 - Удалить тип блюда",
        "5 - Изменить имеющееся блюдо",
        "6 - Выход в главное меню"
        };
        static public List<string>  TypesFood = new List<string>();
        static string login = "admin";
        static string password = "admin";
        static Dictionary<int, Dish> foodMenu = new Dictionary<int, Dish>();

        static public void PrintMenu(string[] menuItem)
        {
            
            foreach (var menuString in menuItem)
            {
                Console.WriteLine(menuString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую пункту меню.");
        }
        static public void InitializationFoodMenu() // Название блюда, тип, цена, время готовки, описание
        {
            foodMenu.Add(1, new Dish ( "Салат \"Нисуаз\"", "Салат", 590, 20, "Обжаренные кусочки филе тунца, анчоусы, свежий огурец, помидоры черри, зелёная стручковая фасоль, отварной мини картофель, перепелиное яйцо, салат Айсберг, кольца красного лука, каперсы 260 г."));
            foodMenu.Add(2, new Dish ( "Салат овощной \"Греческий\"", "Салат", 550, 15, "Свежие огурцы, болгарский перец, помидоры, маслины, оливки, сыр Фета, красный лук, запрвляется соусом \"бальзамик\" 250 г."));
            foodMenu.Add(3, new Dish ( "Салат с куриной печенью", "Салат", 570, 25, "Листья салатов Лолло Россо, Руккола и Романо с обжаренными кусочками куриной печени, с помидорами черри и дольками персика Заправляется соево-медовым соусом 230 г."));
            foodMenu.Add(4, new Dish ( "Борщ со сметанной", "Суп", 390, 40, "Говядина, морковь, свёкла, картофель, капуста, лук репчатый, томатная паста, сахар, уксус, масло сливочное, сметана, зелень."));
            foodMenu.Add(5, new Dish ( "Суп \"Том Ям\"", "Суп", 560, 30, "Самый популярный тайский суп — том ям. У него специфический острый вкус с кисловатым оттенком и очень приятным ароматом, состоящим из сочетания запахов бульона, имбиря, лимонного сорго и других компонентов. Надо сказать, что в самом Таиланде существует много разновидностей этого блюда."));
            foodMenu.Add(6, new Dish ( "Суп лапша куриная с перепелиным яйцом", "Суп", 380, 40, "Легкий куриный бульон с домашней лапшой, нежным куриным филе и перепелиным яйцом"));
            foodMenu.Add(7, new Dish ( "Феттучини с лососем и шпинатом", "Паста", 660, 40, "Феттучини с лососем, шпинатом, сливочным соусом и сыром Пармезан 280 г"));
            foodMenu.Add(8, new Dish ( "Лапша в азиатском стиле", "Паста", 670, 45, "Китайская лапша с овощами и тигровыми креветками 250 г."));
            foodMenu.Add(9, new Dish ( "Спагетти Карбонара","Паста", 650, 35, "Спагетти с беконом, яйцом, сливочным соусом и сыром Пармезан 260 г."));
            foodMenu.Add(10, new Dish ( "Стейк из тунца в кунжуте", "Горячее блюдо", 890, 50, "Подается с овощным салатом из свежего огурца, томатов, стручковой фасоли и листьями салата Романо 170/120 г."));
            foodMenu.Add(11, new Dish ( "Бефстроганов в сливочно-грибном соусе с картофельным пюре", "Горячее блюдо", 690, 45, "Подается с солёным огурцом, свежим помидором и красным луком 160/150 г."));
            foodMenu.Add(12, new Dish ( "Бургер говяжий", "Горячее блюдо", 650, 30, "Мясная котлета из мяса молодого бычка, булочка, помидор, огурец маринованный, бекон, яйцо сыр Чеддер, красный лук, лист салата Подается с картофелем \"фри\" и фирменным соусом Бургер 140/80/150/30 г."));
            foodMenu.Add(13, new Dish ( "Наггетсы куриные", "Горячее блюдо", 410, 25, "Подаются с картофелем \"фри\" и сырным соусом 130/150/50 г."));
            foodMenu.Add(14, new Dish ( "Вареники с картофелем и репчатым луком", "Горячее блюдо", 390, 25, "Подаются со сметаной и луком \"фри\" 210/50/20 г."));
            foodMenu.Add(15, new Dish ( "Медовик", "Десерт", 280, 30, "Настоящий медовый торт, отличающийся особым вкусом – нежным, изысканным, но при этом абсолютно не приторным. 140г."));
            foodMenu.Add(16, new Dish ( "\"Наполеон\" с айвой", "Десерт", 280, 25, "Очень вкусный и нежный торт из тех, что готовят на Кавказе. Айва у нас очень популярна и по тому ее часто используют в выпечке, торту она придает необычайный аромат"));
            foodMenu.Add(17, new Dish ( "Вафли Венские с ванильным кремом", "Десерт", 280, 30, "Венские вафли мягкие и имеют довольно большие размеры. С ванильным кремом. 110г."));
            foodMenu.Add(18, new Dish ( "Мороженое", "Десерт", 150, 10, "Ванильное, Клубничное, Шоколадное, Фисташковое 1 шарик / 50 г."));
            TypesFood.Add("Салат");
            TypesFood.Add("Суп");
            TypesFood.Add("Паста");
            TypesFood.Add("Горячее блюдо");
            TypesFood.Add("Десерт");
        }
        static public void PrintFoodMenu()
        {
            while (true)
            {
                List<int> indexOfDish = new List<int>();
                Console.Clear();
                foreach (KeyValuePair<int, Dish> keyValue in foodMenu)
                {
                    Console.Write(keyValue.Key + " " + keyValue.Value.Name + " " + keyValue.Value.Price + " руб");
                    indexOfDish.Add(keyValue.Key);
                    Console.WriteLine();
                }
                Console.WriteLine("Чтобы узнать подробнее введите номер блюда. Esc для выхода в главное меню");
                string enteredString = EnterString();
                int stringToInt;
                Console.Clear();
                if(int.TryParse(enteredString, out stringToInt))
                {
                    if(indexOfDish.Contains(stringToInt))
                    {
                        Console.WriteLine(foodMenu[stringToInt].Name + " Тип: " + foodMenu[stringToInt].Type + " Цена: " + foodMenu[stringToInt].Price + " руб" + " Время готовки: " + foodMenu[stringToInt].TimeCooking + " минут");
                        Console.WriteLine("Описание: " + foodMenu[stringToInt].Description);
                        Console.WriteLine("Нажмите любую клавишу для перехода к списку блюд...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Нет такого блюда. Нажмите любую клавишу для выхода к списку блюд...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    if (enteredString.Equals("Esc"))
                        break;
                    Console.WriteLine("Нет такого блюда. Нажмите любую клавишу для выхода к списку блюд...");
                    Console.ReadKey();
                }
            }
        }
        static public void AddFood()
        {
            string enteredTypeFood;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите тип блюда: ");
                int i = 1;
                for(i = 1; i <= TypesFood.Count; i++)
                {
                    Console.WriteLine(i + ". " + TypesFood[i - 1]);
                }
                Console.WriteLine("Для добавления нового типа введите " + i);
                string enteredSymbol = EnterString();
                int stringToInt;
                Console.Clear();
                if (int.TryParse(enteredSymbol, out stringToInt))
                {
                    if((i  - stringToInt) >= 0)
                    {
                        if(stringToInt == i )
                        {
                            AddTypeFood();
                        }
                        else
                        {
                            enteredTypeFood = TypesFood[stringToInt - 1];
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
                    Console.WriteLine("Нет такого типа. Нажмите любую клавиш для возврата...");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Введите название блюда: ");
            string enteredNameFood = EnterString();
            int enteredPriceFood;
            Console.WriteLine("Введите цену блюда: ");
            while(true)
            {
                string enteredStringPrice = EnterString();
                int stringToIntPrice;
                if (int.TryParse(enteredStringPrice, out stringToIntPrice))
                {
                    if (stringToIntPrice > 0)
                    {
                        enteredPriceFood = stringToIntPrice;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Цена не может быть отрицательной");
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение. Попробуйте ещё раз: ");
                }
            }
            Console.WriteLine("Введите время готовки: ");
            int enteredTimeCooking;
            while (true)
            {
                string enteredStringTimeCooking = EnterString();
                int stringToIntTimeCooking;
                if (int.TryParse(enteredStringTimeCooking, out stringToIntTimeCooking))
                {
                    if (stringToIntTimeCooking > 0)
                    {
                        enteredTimeCooking= stringToIntTimeCooking;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Время не может быть отрицательным");
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение. Попробуйте ещё раз: ");
                }
            }
            Console.WriteLine("Введите описание блюда: ");
            string enteredDescription = EnterString();
            foodMenu.Add((foodMenu.Count + 1), new Dish(enteredNameFood, enteredTypeFood, enteredPriceFood, enteredTimeCooking, enteredDescription));
            Console.WriteLine("Блюдо добавлено! Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void AddTypeFood()
        {
            Console.Clear();
            Console.WriteLine("***Добавление нового типа блюда***");
            Console.WriteLine("Введите название типа блюда: ");
            TypesFood.Add(EnterString());
            Console.WriteLine("Тип блюда добавлен! Нажмите любую клавишу для возврата... ");
            Console.ReadKey();

        }
        static public void RemoveTypeFood()
        {
            Console.Clear();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер типа блюда, которое хотите удалить. Esc для выхода");
                int i = 1;
                for(i = 1; i <= TypesFood.Count; i++)
                {
                    Console.WriteLine(i + ". " + TypesFood[i - 1]);
                }
                string enteredString = EnterString();
                int stringToIntType;
                if (int.TryParse(enteredString, out stringToIntType))
                {
                    if ((i - stringToIntType) > 0)
                    {
                        Console.WriteLine("Вы желаете удалить " + TypesFood[stringToIntType - 1]);
                        Console.WriteLine("Подтвердите удаление нажатием \"y\"");
                        ConsoleKeyInfo enteredKey = Console.ReadKey();
                        Console.WriteLine();
                        if(enteredKey.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine("Тип \"" + TypesFood[stringToIntType - 1] + "\" успешно удален");
                            TypesFood.RemoveAt(stringToIntType - 1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Отмена удалена. Нажмите любую клавиш для возврата...");
                            Console.ReadKey();
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
                    if (enteredString.Equals("Esc"))
                        break;
                    Console.WriteLine("Нет такого типа. Нажмите любую клавиш для возврата...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void RemoveFood()
        {
            Console.Clear();
            Console.WriteLine("");
            //string enteredShortFormat = Console.ReadLine();
            //bool checkFormat = foodMenu.ContainsKey(enteredShortFormat);
            //if (checkFormat)
            //{
            //    Console.WriteLine(foodMenu[enteredShortFormat]);
            //}
            //else
            //{
            //    Console.WriteLine("Такого формата нет ");
            //}
            //Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            //Console.ReadKey();
        }
        static public void SearchFood()
        {

        }

        static void Main(string[] args)
        {
            InitializationFoodMenu();
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                Console.Clear();
                Console.WriteLine("***Меню ресторана***");
                PrintMenu(MenuStrings);
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1: //"1 - Просмотреть всё меню",
                        PrintFoodMenu();   
                        break;
                    case ConsoleKey.D2:  //"2 - Поиск блюда",
                       // RemoveFormat();
                        break;
                    case ConsoleKey.D3: //"3 - Вывести блюда определённого типа"
                        //PrintFormat();
                        break;
                    case ConsoleKey.D4:  //"4 - Администрирование"
                        AdminMenu();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D5); //"5 - Выход"
            Console.Clear();
            Console.WriteLine("Удачи!");

        }
        static public void AdminMenu()
        {
            Console.Clear();
            Console.Write("Введите логин: ");
            string enteredLogin = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string enteredPassword = Console.ReadLine();
            Console.Clear();
            if ((enteredLogin == login) && (enteredPassword == password))
            {
                Console.WriteLine("Верный пароль");
                ConsoleKey key = ConsoleKey.Enter;
                do
                {
                    Console.Clear();
                    Console.WriteLine("***Меню администратора ресторана***");
                    PrintMenu(AdminMenuStrings);
                    key = Console.ReadKey().Key;
                    switch (key)
                    {
                        case ConsoleKey.D1: //1 - Добавить блюдо",
                            AddFood();
                            break;
                        case ConsoleKey.D2:  //""2 - Удалить блюдо",


                            break;
                        case ConsoleKey.D3: //""3 - Добавить тип блюда",
                            AddTypeFood();
                            break;
                        case ConsoleKey.D4: //""3 - Добавить тип блюда",
                            RemoveTypeFood();
                            break;
                        case ConsoleKey.D5: //""5 - Изменить имеющееся блюдо",
    
                            break;
                        default: continue;
                    }
                } while (key != ConsoleKey.D6); // "6 - Выход в главное меню"

            }
            else
            {
                Console.WriteLine("Неверный пароль");
                Console.WriteLine("Нажмите любую клавишу чтобы выйти в главное меню...");
                Console.ReadKey();
            }
            
        }
        static string EnterString()
        {
            string enteredString = "";
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(false);
                if (pressedKey.Key == ConsoleKey.Escape)
                {
                    enteredString = "Esc";
                    break;
                }
                else
                {
                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    else
                    {
                        if(pressedKey.Key == ConsoleKey.Backspace)
                        {
                            enteredString = enteredString.Remove(enteredString.Length - 1);
                            Console.Write(" \b");
                        }
                        else
                        {
                            enteredString = enteredString + pressedKey.KeyChar;
                        }
                    }
                }
            }
            Console.WriteLine();
            return enteredString;
        }
    }
}
