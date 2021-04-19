using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;

namespace ProjectRestaurant
{
    class Program
    {
        static public string[] MenuStrings =
        {
        "1 - Просмотреть всё меню",
        "2 - Поиск блюда",
        "3 - Вывести блюда определённого типа",
        "4 - Перейти в корзину",
        "5 - Администрирование",
        "6 - Выход"
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
        static List<int> order = new List<int>();
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
        static public void PrintFoodMenu(Dictionary<int, Dish> printedFoodMenu)
        {
            int count = 0;
            while (true)
            {
                List<int> indexOfDish = new List<int>();
                foreach (KeyValuePair<int, Dish> keyValue in printedFoodMenu)
                {
                    indexOfDish.Add(keyValue.Key);
                }
            PrintNewPage:
                Console.Clear();
                for (int i = count; i < (count + 9); i++)
                {
                    if (i < indexOfDish.Count)
                    {
                        Console.Write((i - count + 1) +  " " + printedFoodMenu[indexOfDish[i]].Name + " " + printedFoodMenu[indexOfDish[i]].Price + " руб");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Чтобы узнать подробнее введите номер блюда. \"0\" - страница назад. \"-\" - страница вперёд.");
                Console.WriteLine("\"=\" - для фильтрации по цене. \"Esc\" - для выхода в главное меню");
                int stringToInt;
                ConsoleKeyInfo enteredStringKey = Console.ReadKey(true);
                char enteredChar = enteredStringKey.KeyChar;
                string enteredString = "";
                enteredString = enteredString + enteredChar;
                if (int.TryParse(enteredString, out stringToInt) && enteredStringKey.Key != ConsoleKey.D0)
                {
                    if (stringToInt <= 9 && stringToInt > 0 && stringToInt + count <= indexOfDish.Count)
                    {
                        Console.Clear();
                        Console.WriteLine(printedFoodMenu[indexOfDish[stringToInt + count - 1]].Name + " Тип: " + printedFoodMenu[indexOfDish[stringToInt + count - 1]].Type + " Цена: " + printedFoodMenu[indexOfDish[stringToInt + count - 1]].Price + " руб" + " Время готовки: " + printedFoodMenu[indexOfDish[stringToInt + count - 1]].TimeCooking + " минут");
                        Console.WriteLine("Описание: " + printedFoodMenu[indexOfDish[stringToInt + count - 1]].Description);
                        Console.WriteLine("Нажмите \"1\" для добавления в коризну. Нажмите любую другую клавишу для перехода к списку блюд...");
                        while(true)
                        {
                            if (Console.ReadKey(true).Key == ConsoleKey.D1)
                            {
                                order.Add(indexOfDish[stringToInt + count - 1]);
                                Console.WriteLine("Блюдо добавлено в заказ");
                            }
                            else
                                break;
                        } 
                    }
                    else
                    {
                        Console.WriteLine("Нет такого блюда. Нажмите любую клавишу для выхода к списку блюд...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    if (enteredStringKey.Key == ConsoleKey.Escape)
                        break;
                    if(enteredStringKey.Key == ConsoleKey.D0 && count >= 9)
                    {
                        count -= 9;
                        goto PrintNewPage;
                    }
                    if (enteredStringKey.Key == ConsoleKey.OemMinus && count < indexOfDish.Count - 9)
                    {
                        count += 9;
                        goto PrintNewPage;
                    }
                    if (enteredStringKey.Key == ConsoleKey.OemPlus)
                    {
                        
                        FilterMenu(printedFoodMenu);
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Неверная кнопка. Нажмите любую клавишу для выхода к списку блюд...");
                    Console.ReadKey();
                }
            }
        }
        static public void CheckCart()
        {
            int count = 0;
            while (true)
            {
                if(order.Count == 0)
                {
                    Console.WriteLine("Корзина пуста, нажмите любую клавишу для возврата...");
                    Console.ReadKey(true);
                    goto endCheckCart;
                }
                List<int> sortedOrder = order.OrderBy(x => x).ToList();

                Console.Clear();
                int x = 1;
                for (int i = count; i < (count + 9); i++)
                {
                    if (i < sortedOrder.Count())
                    {
                        if(i != count + 8)
                        {
                            if (sortedOrder[i] == sortedOrder[i + 1])
                            {
                                x++;
                            }
                            else
                            {
                                Console.Write((i - count + 1) + " " + foodMenu[sortedOrder[i]].Name + " " + foodMenu[sortedOrder[i]].Price + " руб" + "  x" + x);
                                Console.WriteLine();
                                x = 1;
                            }
                        }
                        if(sortedOrder[i] == sortedOrder[i + 1] )
                        {
                            x++;
                        }
                        else
                        {
                            Console.Write((i - count + 1) + " " + foodMenu[sortedOrder[i]].Name + " " + foodMenu[sortedOrder[i]].Price + " руб" + "  x" + x);
                            Console.WriteLine();
                            x = 1;
                        }
                        
                    }
                }
                //Console.WriteLine("Чтобы узнать подробнее введите номер блюда. \"0\" - страница назад. \"-\" - страница вперёд.");
                //Console.WriteLine("\"=\" - для фильтрации по цене. \"Esc\" - для выхода в главное меню");
                //int stringToInt;
                //ConsoleKeyInfo enteredStringKey = Console.ReadKey(true);
                //char enteredChar = enteredStringKey.KeyChar;
                //string enteredString = "";
                //enteredString = enteredString + enteredChar;
                //if (int.TryParse(enteredString, out stringToInt) && enteredStringKey.Key != ConsoleKey.D0)
                //{
                //    if (stringToInt <= 9 && stringToInt > 0 && stringToInt + count <= order.Count)
                //    {
                //        Console.Clear();
                //        Console.WriteLine(printedFoodMenu[indexOfDish[stringToInt + count - 1]].Name + " Тип: " + printedFoodMenu[indexOfDish[stringToInt + count - 1]].Type + " Цена: " + printedFoodMenu[indexOfDish[stringToInt + count - 1]].Price + " руб" + " Время готовки: " + printedFoodMenu[indexOfDish[stringToInt + count - 1]].TimeCooking + " минут");
                //        Console.WriteLine("Описание: " + printedFoodMenu[indexOfDish[stringToInt + count - 1]].Description);
                //        Console.WriteLine("Нажмите \"1\" для добавления в коризну. Нажмите любую другую клавишу для перехода к списку блюд...");
                //        while (true)
                //        {
                //            if (Console.ReadKey(true).Key == ConsoleKey.D1)
                //            {
                //                order.Add(indexOfDish[stringToInt + count - 1);
                //                Console.WriteLine("Блюдо добавлено в заказ");
                //            }
                //            else
                //                break;
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("Нет такого блюда. Нажмите любую клавишу для выхода к списку блюд...");
                //        Console.ReadKey();
                //    }
                //}
                //else
                //{
                //    if (enteredStringKey.Key == ConsoleKey.Escape)
                //        break;
                //    if (enteredStringKey.Key == ConsoleKey.D0 && count >= 9)
                //    {
                //        count -= 9;
                //        goto PrintNewPage;
                //    }
                //    if (enteredStringKey.Key == ConsoleKey.OemMinus && count < indexOfDish.Count - 9)
                //    {
                //        count += 9;
                //        goto PrintNewPage;
                //    }
                //    if (enteredStringKey.Key == ConsoleKey.OemPlus)
                //    {

                //        FilterMenu(printedFoodMenu);
                //        break;
                //    }
                //    Console.WriteLine();
                //    Console.WriteLine("Неверная кнопка. Нажмите любую клавишу для выхода к списку блюд...");
                //    Console.ReadKey();
                //}
            }
        endCheckCart:
            Console.WriteLine();
        }
        static public void AddFood()
        {
            string enteredTypeFood = "";
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
                ConsoleKeyInfo enteredSymbol = Console.ReadKey(true);
                if (enteredSymbol.Key == ConsoleKey.Escape)
                    goto EndAddingDish;
                int stringToInt;
                char enteredChar = enteredSymbol.KeyChar;
                string enteredString = "";
                enteredString = enteredString + enteredChar;
                Console.Clear();
                if (int.TryParse(enteredString, out stringToInt))
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
                    if (enteredSymbol.Equals("Esc"))
                        goto EndAddingDish;
                    Console.WriteLine("Нет такого типа. Нажмите любую клавиш для возврата...");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Тип: " + enteredTypeFood);
            Console.WriteLine("Введите название блюда: ");
            string enteredNameFood = EnterString();
            if (enteredNameFood == "Esc")
                goto EndAddingDish;
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
                    if (enteredStringPrice.Equals("Esc"))
                        goto EndAddingDish;
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
                    if (enteredStringTimeCooking.Equals("Esc"))
                        goto EndAddingDish;
                    Console.WriteLine("Неверное значение. Попробуйте ещё раз: ");
                }
            }
            Console.WriteLine("Введите описание блюда: ");
            string enteredDescription = EnterString();
            foodMenu.Add((foodMenu.Count + 1), new Dish(enteredNameFood, enteredTypeFood, enteredPriceFood, enteredTimeCooking, enteredDescription));
            Console.WriteLine("Блюдо добавлено! Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        EndAddingDish:
            Console.WriteLine();
        }
        static public void AddTypeFood()
        {
            Console.Clear();
            Console.WriteLine("***Добавление нового типа блюда***");
            Console.WriteLine("Введите название типа блюда. \"Esc\" - для выхода");
            string enteredString = EnterString();
            if (enteredString == "Esc")
                goto endAddTypeFood;
            TypesFood.Add(enteredString);
            Console.WriteLine("Тип блюда добавлен! Нажмите любую клавишу для возврата... ");
            Console.ReadKey();
        endAddTypeFood:
            Console.WriteLine();

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
            while (true)
            {
                Console.Clear();
                List<int> indexOfDish = new List<int>();
                foreach (KeyValuePair<int, Dish> keyValue in foodMenu)
                {
                    Console.Write(keyValue.Key + ". " + keyValue.Value.Name + " " + keyValue.Value.Price + " руб");
                    indexOfDish.Add(keyValue.Key);
                    Console.WriteLine();
                }
                Console.WriteLine("Выберите номер блюда, который хотите удалить. Esc для выхода ");
                string enteredIDDish = EnterString();
                int enteredIDDishToInt;
                if (int.TryParse(enteredIDDish, out enteredIDDishToInt))
                {


                    if(foodMenu.ContainsKey(enteredIDDishToInt))
                    {
                        Console.WriteLine("Вы желаете удалить " + foodMenu[enteredIDDishToInt].Name);
                        Console.WriteLine("Подтвердите удаление нажатием \"y\"");
                        ConsoleKeyInfo enteredKey = Console.ReadKey(true);
                        Console.WriteLine();
                        if (enteredKey.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine("Блюдо \"" + foodMenu[enteredIDDishToInt].Name + "\" успешно удален");
                            foodMenu.Remove(enteredIDDishToInt);
                            Console.WriteLine("Нажмите любую клавиш для возврата...");
                            Console.ReadKey(true);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Отмена удалена. Нажмите любую клавиш для возврата...");
                            Console.ReadKey(true);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нет такого ID. Нажмите любую клавиш для возврата...");
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    if (enteredIDDish.Equals("Esc"))
                        break;
                    Console.WriteLine("Нет такого блюда. Нажмите любую клавиш для возврата...");
                    Console.ReadKey(true);
                }
            }
        }
        static public void SearchFood()
        {
            Console.Clear();
            Console.WriteLine("Введите название того, что хотите найти. \"Esc\" - для выхода");
            string enteredSearchQuery = EnterString();
            if (enteredSearchQuery == "Esc")
                goto endSearchFood;
            var searchedFoodMenu = from query in foodMenu
                                   where query.Value.Name.Contains(enteredSearchQuery)
                                   select query;
            if (searchedFoodMenu.Count() == 0)
            {
                Console.WriteLine("Ничего не найдено :(");
            }
            else
            {
                Console.WriteLine("Найдено: ");
                foreach (KeyValuePair<int, Dish> keyValue in searchedFoodMenu)
                {
                    Console.WriteLine(keyValue.Value.Name);
                }
            }
            Console.WriteLine("Нажмите любую клавишу для выхода в меню...");
            Console.ReadKey(true);
        endSearchFood:
            Console.WriteLine();
        }
        //static public Inflation
        static public void ChangeFood()
        {
            while (true)
            {
                Console.Clear();
                List<int> indexOfDish = new List<int>();
                foreach (KeyValuePair<int, Dish> keyValue in foodMenu)
                {
                    Console.Write(keyValue.Key + ". " + keyValue.Value.Name + " " + keyValue.Value.Price + " руб");
                    indexOfDish.Add(keyValue.Key);
                    Console.WriteLine();
                }
                Console.WriteLine("Выберите номер блюда, который хотите изменить. Esc для выхода ");
                string enteredIDDish = EnterString();
                int enteredIDDishToInt;
                if (int.TryParse(enteredIDDish, out enteredIDDishToInt))
                {
                    if (foodMenu.ContainsKey(enteredIDDishToInt))
                    {
                        Console.Clear();
                        Console.WriteLine("Вы меняете " + foodMenu[enteredIDDishToInt].Name);
                        Console.WriteLine("Выберите тип, который хотите изменить: ");
                        Console.WriteLine("1. Название");
                        Console.WriteLine("2. Тип блюда");
                        Console.WriteLine("3. Цена");
                        Console.WriteLine("4. Время готовки");
                        Console.WriteLine("5. Описание");
                        ConsoleKeyInfo enteredSymbol = Console.ReadKey(true);
                        string enteredSymbolToString = "";
                        enteredSymbolToString += enteredSymbol.KeyChar;
                        int stringToInt;
                        Console.Clear();
                        if (int.TryParse(enteredSymbolToString, out stringToInt))
                        {
                            switch(stringToInt)
                            {
                                case 1:
                                    foodMenu[enteredIDDishToInt].ChangeName();
                                    goto EndChangeDish;
                                case 2:
                                    foodMenu[enteredIDDishToInt].ChangeType();
                                    goto EndChangeDish;
                                case 3:
                                    foodMenu[enteredIDDishToInt].ChangePrice();
                                    goto EndChangeDish;
                                case 4:
                                    foodMenu[enteredIDDishToInt].ChangeTimeCooking();
                                    goto EndChangeDish;
                                case 5:
                                    foodMenu[enteredIDDishToInt].ChangeDescription();
                                    goto EndChangeDish;
                                default:
                                    Console.WriteLine("Нет такого блюда. Нажмите любую клавиш для возврата...");
                                    Console.ReadKey(true);
                                    goto EndChangeDish;
                            }
                        }
                        else
                        {
                            if (enteredSymbol.Equals("Esc"))
                                goto EndChangeDish;
                            Console.WriteLine("Нет такого типа. Нажмите любую клавиш для возврата...");
                            Console.ReadKey(true);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нет такого блюда. Нажмите любую клавиш для возврата...");
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    if (enteredIDDish.Equals("Esc"))
                        goto EndChangeDish;
                    Console.WriteLine("Нет такого блюда. Нажмите любую клавиш для возврата...");
                    Console.ReadKey(true);
                }
            }
        EndChangeDish:
            Console.WriteLine();
        }
        static public void FilterMenu(Dictionary<int, Dish> printedFoodMenu) 
        {
            Dictionary<int, Dish> printedFoodMenuClone = new Dictionary<int, Dish>();

            var filteredFoodMenu = from query in printedFoodMenu
                                   orderby query.Value.Price
                                   select query;
            foreach (var temp in filteredFoodMenu)
            {
                printedFoodMenuClone.Add(temp.Key, temp.Value);
            }
            //Console.ReadKey();
            PrintFoodMenu(printedFoodMenuClone);
        }
        static public string EnterString()
        {
            string enteredString = "";
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
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
                        if (pressedKey.Key == ConsoleKey.Backspace && enteredString.Length != 0)
                        {
                            enteredString = enteredString.Remove(enteredString.Length - 1);
                            Console.SetCursorPosition(0, Console.CursorTop);
                            Console.Write(enteredString + " \b");

                        }
                        else
                        {
                            Console.Write(pressedKey.KeyChar);
                            enteredString = enteredString + pressedKey.KeyChar;
                        }
                    }
                }
            }
            Console.WriteLine();
            return enteredString;
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
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1: //"1 - Просмотреть всё меню",
                        PrintFoodMenu(foodMenu);   
                        break;
                    case ConsoleKey.D2:  //"2 - Поиск блюда",
                        SearchFood();
                        break;
                    case ConsoleKey.D3: //"3 - Вывести блюда определённого типа"
                        //PrintFormat();
                        break;
                    case ConsoleKey.D4:  //"4 - Проверить корзину
                        CheckCart();
                        break;
                    case ConsoleKey.D5:  //5 - Администрирование"
                        AdminMenu();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D6); //"6 - Выход"
            Console.Clear();
            Console.WriteLine("Удачи!");

        }
        static public void AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("Введите логин: ");
            string enteredLogin = EnterString();
            if (enteredLogin == "Esc")
                goto endAdminMenu;
            Console.WriteLine("Введите пароль: ");
            string enteredPassword = EnterString();
            if (enteredPassword == "Esc")
                goto endAdminMenu;
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
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.D1: //1 - Добавить блюдо",
                            AddFood();
                            break;
                        case ConsoleKey.D2:  //""2 - Удалить блюдо",
                            RemoveFood();
                            break;
                        case ConsoleKey.D3: //""3 - Добавить тип блюда",
                            AddTypeFood();
                            break;
                        case ConsoleKey.D4: //""4 - Удалить тип блюда",
                            RemoveTypeFood();
                            break;
                        case ConsoleKey.D5: //""5 - Изменить имеющееся блюдо",
                            ChangeFood();
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
        endAdminMenu:
            Console.WriteLine();
            
        }
    }
}
