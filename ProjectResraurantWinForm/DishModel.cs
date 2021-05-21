using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectResraurantWinForm
{
    class DishModel
    {
        public static List<Dish> dishes = new List<Dish>();
        public static List<string> AllTypeDishes = new List<string>();
        public static List<ListBox> listTypePage = new List<ListBox>();
        public static void InitializeTypesMenu()
        {
            AllTypeDishes.Clear();
            string nameTxtTypesFood = "AllTypeDishes.txt";
            if (File.Exists(nameTxtTypesFood))
            {
                using (StreamReader sr = new StreamReader(nameTxtTypesFood))
                {
                    while (true)
                    {
                        string readedType = sr.ReadLine();
                        if (readedType == null)
                            break;
                        AllTypeDishes.Add(readedType);
                    }
                }
            }
            else
            {
                AllTypeDishes.Add("Салат");
                AllTypeDishes.Add("Суп");
                AllTypeDishes.Add("Паста");
                AllTypeDishes.Add("Горячее блюдо");
                AllTypeDishes.Add("Десерт");
                SaveInTxtTypesFood();
            }
            
        }
        public static void InitializeDishMenu()
        {
            dishes.Clear();
            string nameTxtDishMenu = "DishMenu.txt";
            if (File.Exists(nameTxtDishMenu))
            {
                using (StreamReader sr = new StreamReader(nameTxtDishMenu))
                {
                    while (true)
                    {
                        string readedString = sr.ReadLine();
                        if (readedString == null)
                            break;
                        string[] words = readedString.Split(new char[] { '|' });
                        string readedName = words[0];
                        string readedType = words[1];
                        int readedPrice = int.Parse(words[2]);
                        int readedTimeCooking = int.Parse(words[3]);
                        string readedDescription = words[4];
                        string pictureDish = words[5];
                        dishes.Add(new Dish(readedName, readedType, readedPrice, readedTimeCooking, readedDescription, pictureDish));
                    }
                }
            }
            else
            {
                dishes.Add(new Dish("Салат \"Нисуаз\"", "Салат", 590, 20, "Обжаренные кусочки филе тунца, анчоусы, свежий огурец, помидоры черри, зелёная стручковая фасоль, отварной мини картофель, перепелиное яйцо, салат Айсберг, кольца красного лука, каперсы 260 г.", @"Pictures\Салат Нисуаз.jpg"));
                dishes.Add(new Dish("Салат овощной \"Греческий\"", "Салат", 550, 15, "Свежие огурцы, болгарский перец, помидоры, маслины, оливки, сыр Фета, красный лук, запрвляется соусом \"бальзамик\" 250 г.", @"Pictures\Салат овощной Греческий.jpg"));
                dishes.Add(new Dish("Салат с куриной печенью", "Салат", 570, 25, "Листья салатов Лолло Россо, Руккола и Романо с обжаренными кусочками куриной печени, с помидорами черри и дольками персика Заправляется соево-медовым соусом 230 г.", @"Pictures\Салат с куриной печенью.jpg"));
                dishes.Add(new Dish("Борщ со сметанной", "Суп", 390, 40, "Говядина, морковь, свёкла, картофель, капуста, лук репчатый, томатная паста, сахар, уксус, масло сливочное, сметана, зелень.", @"Pictures\Борщ со сметанной.jpg"));
                dishes.Add(new Dish("Суп \"Том Ям\"", "Суп", 560, 30, "Самый популярный тайский суп — том ям. У него специфический острый вкус с кисловатым оттенком и очень приятным ароматом, состоящим из сочетания запахов бульона, имбиря, лимонного сорго и других компонентов. Надо сказать, что в самом Таиланде существует много разновидностей этого блюда.", @"Pictures\Суп Том Ям.jpg"));
                dishes.Add(new Dish("Суп лапша куриная с перепелиным яйцом", "Суп", 380, 40, "Легкий куриный бульон с домашней лапшой, нежным куриным филе и перепелиным яйцом", @"Pictures\Суп лапша куриная с перепелинным яйцом.jpg"));
                dishes.Add(new Dish("Феттучини с лососем и шпинатом", "Паста", 660, 40, "Феттучини с лососем, шпинатом, сливочным соусом и сыром Пармезан 280 г", @"Pictures\Феттучини с лососем и шпинатом.jpg"));
                dishes.Add(new Dish("Лапша в азиатском стиле", "Паста", 670, 45, "Китайская лапша с овощами и тигровыми креветками 250 г.", @"Pictures\Лапша в азиатском стиле.jpg"));
                dishes.Add(new Dish("Спагетти Карбонара", "Паста", 650, 35, "Спагетти с беконом, яйцом, сливочным соусом и сыром Пармезан 260 г.", @"Pictures\Спагетти Карбонара.jpg"));
                dishes.Add(new Dish("Стейк из тунца в кунжуте", "Горячее блюдо", 890, 50, "Подается с овощным салатом из свежего огурца, томатов, стручковой фасоли и листьями салата Романо 170/120 г.", @"Pictures\Стейк из тунца в кунжуте.jpg"));
                dishes.Add(new Dish("Бефстроганов в сливочно-грибном соусе с картофельным пюре", "Горячее блюдо", 690, 45, "Подается с солёным огурцом, свежим помидором и красным луком 160/150 г.", @"Pictures\Бефстроганов в сливочно-грибном соусе с картофельным пюре.jpg"));
                dishes.Add(new Dish("Бургер говяжий", "Горячее блюдо", 650, 30, "Мясная котлета из мяса молодого бычка, булочка, помидор, огурец маринованный, бекон, яйцо сыр Чеддер, красный лук, лист салата Подается с картофелем \"фри\" и фирменным соусом Бургер 140/80/150/30 г.", @"Pictures\Бургер говяжий.jpg"));
                dishes.Add(new Dish("Наггетсы куриные", "Горячее блюдо", 410, 25, "Подаются с картофелем \"фри\" и сырным соусом 130/150/50 г.", @"Pictures\Наггетсы куриные.jpg"));
                dishes.Add(new Dish("Вареники с картофелем и репчатым луком", "Горячее блюдо", 390, 25, "Подаются со сметаной и луком \"фри\" 210/50/20 г.", @"Pictures\Вареники с картофелем и репчатым луком.jpg"));
                dishes.Add(new Dish("Медовик", "Десерт", 280, 30, "Настоящий медовый торт, отличающийся особым вкусом – нежным, изысканным, но при этом абсолютно не приторным. 140г.", @"Pictures\Медовик.jpg"));
                dishes.Add(new Dish("\"Наполеон\" с айвой", "Десерт", 280, 25, "Очень вкусный и нежный торт из тех, что готовят на Кавказе. Айва у нас очень популярна и по тому ее часто используют в выпечке, торту она придает необычайный аромат", @"Pictures\Наполеон с айвой.jpg"));
                dishes.Add(new Dish("Вафли Венские с ванильным кремом", "Десерт", 280, 30, "Венские вафли мягкие и имеют довольно большие размеры. С ванильным кремом. 110г.", @"Pictures\Вафли Венские с ванильным кремом.jpg"));
                dishes.Add(new Dish("Мороженое", "Десерт", 150, 10, "Ванильное, Клубничное, Шоколадное, Фисташковое 1 шарик / 50 г.", "Pictures\\Мороженное.jpg"));
                SaveInTxtFoodMenu();
            }
        }
        static public void SaveInTxtFoodMenu()
        {
            string nameTxtFoodMenu = "DishMenu.txt";
            using (StreamWriter sw = new StreamWriter(nameTxtFoodMenu, false)) // открываем файл
            {
                foreach (var temp in dishes)
                {
                    sw.Write(temp.DishName + "|" + temp.TypeOfDish + "|" + temp.PriceOfDIsh + "|" + temp.CookingTime + "|" + temp.DescriptionDish + "|" + temp.PictureDish);
                    sw.WriteLine();
                }
            }
        } // сохранение меню в файл DishMenu.txt
        static public void SaveInTxtTypesFood()
        {
            string nameTxtTypesFood = "AllTypeDishes.txt";
            using (StreamWriter sw = new StreamWriter(nameTxtTypesFood, false)) // открываем файл
            {
                foreach (var temp in AllTypeDishes)
                    sw.WriteLine(temp);
            }
        } //сохранеие типов блюд в файл TypesFood.txt
        public static void AddType(string type)
        {
            AllTypeDishes.Add(type);
            SaveInTxtTypesFood();
        }
    }
}
