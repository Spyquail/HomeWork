using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProjectResraurantWinForm
{
    class DishModel
    {
        public static List<Dish> dishes = new List<Dish>();
        public static List<string> AllTypeDishes = new List<string>();
        public static List<int> Cart = new();  
        static SqlConnection sqlConnection = new SqlConnection("Server=KMR-HD-46419\\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;MultipleActiveResultSets=True;");
        public static void InitializeTypesMenu()
        {
            AllTypeDishes.Clear();
            string sql = "SELECT type FROM AllTypeDishes";
            try
            {
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                sqlConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string readedType = reader.GetString(0);
                        AllTypeDishes.Add(readedType);
                    }
                }
                sqlConnection.Close();
                if (AllTypeDishes.Count == 0)
                {
                    AllTypeDishes.Add("Салат");
                    AllTypeDishes.Add("Суп");
                    AllTypeDishes.Add("Паста");
                    AllTypeDishes.Add("Горячее блюдо");
                    AllTypeDishes.Add("Десерт");
                    SaveInDataBaseTypesMenu();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public static void InitializeDishMenu()
        {
            dishes.Clear();
            string sql = "SELECT id, dishname, typeofdish, priceofdish, cookingtime, descriptiondish, picturedish FROM DishMenu";
            try
            {
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                sqlConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int readedId = reader.GetInt32(0);
                        string readedName = reader.GetString(1);
                        string readedType = reader.GetString(2);
                        int readedPrice = reader.GetInt32(3);
                        int readedTimeCooking = reader.GetInt32(4);
                        string readedDescription = reader.GetString(5);
                        string pictureDish = reader.GetString(6);
                        dishes.Add(new Dish(readedId, readedName, readedType, readedPrice, readedTimeCooking, readedDescription, pictureDish));
                    }
                }
                sqlConnection.Close();
                if( dishes.Count == 0 )
                {
                    dishes.Add(new Dish(0, "Салат \"Нисуаз\"", "Салат", 590, 20, "Обжаренные кусочки филе тунца, анчоусы, свежий огурец, помидоры черри, зелёная стручковая фасоль, отварной мини картофель, перепелиное яйцо, салат Айсберг, кольца красного лука, каперсы 260 г.", @"Pictures\Салат Нисуаз.jpg"));
                    dishes.Add(new Dish(1, "Салат овощной \"Греческий\"", "Салат", 550, 15, "Свежие огурцы, болгарский перец, помидоры, маслины, оливки, сыр Фета, красный лук, запрвляется соусом \"бальзамик\" 250 г.", @"Pictures\Салат овощной Греческий.jpg"));
                    dishes.Add(new Dish(2, "Салат с куриной печенью", "Салат", 570, 25, "Листья салатов Лолло Россо, Руккола и Романо с обжаренными кусочками куриной печени, с помидорами черри и дольками персика Заправляется соево-медовым соусом 230 г.", @"Pictures\Салат с куриной печенью.jpg"));
                    dishes.Add(new Dish(3, "Борщ со сметанной", "Суп", 390, 40, "Говядина, морковь, свёкла, картофель, капуста, лук репчатый, томатная паста, сахар, уксус, масло сливочное, сметана, зелень.", @"Pictures\Борщ со сметанной.jpg"));
                    dishes.Add(new Dish(4, "Суп \"Том Ям\"", "Суп", 560, 30, "Самый популярный тайский суп — том ям. У него специфический острый вкус с кисловатым оттенком и очень приятным ароматом, состоящим из сочетания запахов бульона, имбиря, лимонного сорго и других компонентов. Надо сказать, что в самом Таиланде существует много разновидностей этого блюда.", @"Pictures\Суп Том Ям.jpg"));
                    dishes.Add(new Dish(5, "Суп лапша куриная с перепелиным яйцом", "Суп", 380, 40, "Легкий куриный бульон с домашней лапшой, нежным куриным филе и перепелиным яйцом", @"Pictures\Суп лапша куриная с перепелинным яйцом.jpg"));
                    dishes.Add(new Dish(6, "Феттучини с лососем и шпинатом", "Паста", 660, 40, "Феттучини с лососем, шпинатом, сливочным соусом и сыром Пармезан 280 г", @"Pictures\Феттучини с лососем и шпинатом.jpg"));
                    dishes.Add(new Dish(7, "Лапша в азиатском стиле", "Паста", 670, 45, "Китайская лапша с овощами и тигровыми креветками 250 г.", @"Pictures\Лапша в азиатском стиле.jpg"));
                    dishes.Add(new Dish(8, "Спагетти Карбонара", "Паста", 650, 35, "Спагетти с беконом, яйцом, сливочным соусом и сыром Пармезан 260 г.", @"Pictures\Спагетти Карбонара.jpg"));
                    dishes.Add(new Dish(9, "Стейк из тунца в кунжуте", "Горячее блюдо", 890, 50, "Подается с овощным салатом из свежего огурца, томатов, стручковой фасоли и листьями салата Романо 170/120 г.", @"Pictures\Стейк из тунца в кунжуте.jpg"));
                    dishes.Add(new Dish(10, "Бефстроганов в сливочно-грибном соусе с картофельным пюре", "Горячее блюдо", 690, 45, "Подается с солёным огурцом, свежим помидором и красным луком 160/150 г.", @"Pictures\Бефстроганов в сливочно-грибном соусе с картофельным пюре.jpg"));
                    dishes.Add(new Dish(11, "Бургер говяжий", "Горячее блюдо", 650, 30, "Мясная котлета из мяса молодого бычка, булочка, помидор, огурец маринованный, бекон, яйцо сыр Чеддер, красный лук, лист салата Подается с картофелем \"фри\" и фирменным соусом Бургер 140/80/150/30 г.", @"Pictures\Бургер говяжий.jpg"));
                    dishes.Add(new Dish(12, "Наггетсы куриные", "Горячее блюдо", 410, 25, "Подаются с картофелем \"фри\" и сырным соусом 130/150/50 г.", @"Pictures\Наггетсы куриные.jpg"));
                    dishes.Add(new Dish(13, "Вареники с картофелем и репчатым луком", "Горячее блюдо", 390, 25, "Подаются со сметаной и луком \"фри\" 210/50/20 г.", @"Pictures\Вареники с картофелем и репчатым луком.jpg"));
                    dishes.Add(new Dish(14, "Медовик", "Десерт", 280, 30, "Настоящий медовый торт, отличающийся особым вкусом – нежным, изысканным, но при этом абсолютно не приторным. 140г.", @"Pictures\Медовик.jpg"));
                    dishes.Add(new Dish(15, "\"Наполеон\" с айвой", "Десерт", 280, 25, "Очень вкусный и нежный торт из тех, что готовят на Кавказе. Айва у нас очень популярна и по тому ее часто используют в выпечке, торту она придает необычайный аромат", @"Pictures\Наполеон с айвой.jpg"));
                    dishes.Add(new Dish(16, "Вафли Венские с ванильным кремом", "Десерт", 280, 30, "Венские вафли мягкие и имеют довольно большие размеры. С ванильным кремом. 110г.", @"Pictures\Вафли Венские с ванильным кремом.jpg"));
                    dishes.Add(new Dish(17, "Мороженое", "Десерт", 150, 10, "Ванильное, Клубничное, Шоколадное, Фисташковое 1 шарик / 50 г.", "Pictures\\Мороженное.jpg"));
                    SaveInDataBaseFoodMenu();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        static public void SaveInDataBaseFoodMenu()
        {
            string sql = "DELETE  FROM DishMenu";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQueryAsync();
                sql = "INSERT DishMenu VALUES";
                foreach (var dish in dishes)
                {
                    if (sql[sql.Length - 1] == ')')
                        sql += ",";
                    sql += $" ({dish.Id}, '{dish.DishName}', '{dish.TypeOfDish}', {dish.PriceOfDIsh}, {dish.CookingTime}, '{dish.DescriptionDish}', '{dish.PictureDish}')";
                }
                command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: \n" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        static public void SaveInDataBaseTypesMenu()
        {
            string sql = "DELETE  FROM AllTypeDishes";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
                sql = "INSERT AllTypeDishes VALUES";
                foreach (var type in AllTypeDishes)
                {
                    if (sql[sql.Length - 1] == ')')
                        sql += ",";
                    sql += $" ( '{type}')";
                }
                command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка при сохранении типов: \n" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public static bool AddType(string type)
        {
            if (!AllTypeDishes.Exists(x => x.ToLower().Equals(type.ToLower()))) 
            {
                AllTypeDishes.Add(type);
                SaveInDataBaseTypesMenu();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AddDish(Dish newDish)
        {
            if(!dishes.Exists(x => x.DishName.ToLower().Equals(newDish.DishName.ToLower())))
            {
                dishes.Add(newDish);
                SaveInDataBaseFoodMenu();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void RemoveType(string type)
        {
                AllTypeDishes.Remove(type);
                SaveInDataBaseTypesMenu();
        }
        public static void RemoveDish(int id)
        {
            int indexDish = dishes.FindIndex(x => x.Id.Equals(id));
            dishes.RemoveAt(indexDish);
            SaveInDataBaseFoodMenu();
        }
        public static int EditDishName(int idDishName, string newDishName) 
        {
            bool check = dishes.Exists(x => x.DishName.ToLower().Equals(newDishName));
            if (check)
                return 0; // Такое имя уже используется
            if(newDishName.Contains('|'))
                return 1; //Содержит недопустимые символы
            if (newDishName.Equals(""))
                return 2; //Пустое имя
            if (newDishName.Count() >= 80)
                return 4;
            int indexDish = dishes.FindIndex(x => x.Id.Equals(idDishName));       
            dishes[indexDish].DishName = newDishName;
            SaveInDataBaseFoodMenu();
            return 3; // Название блюда изменено
        }
        public static void EditPriceDish(int idDishName, int newPrice)
        {
            int indexDish = dishes.FindIndex(x => x.Id.Equals(idDishName));
            dishes[indexDish].PriceOfDIsh = newPrice;
            SaveInDataBaseFoodMenu();
        }
        public static void EditTimeCooking(int idDishName, int newTime)
        {
            int indexDish = dishes.FindIndex(x => x.Id.Equals(idDishName));
            dishes[indexDish].CookingTime = newTime;
            SaveInDataBaseFoodMenu();
        }
        public static void EditDescriptionDish(int idDishName, string newDescription)
        {
            int indexDish = dishes.FindIndex(x => x.Id.Equals(idDishName));
            dishes[indexDish].DescriptionDish = newDescription;
            SaveInDataBaseFoodMenu();
        }
        public static void EditTypeDish(int idDishName, string newType)
        {
            int indexDish = dishes.FindIndex(x => x.Id.Equals(idDishName));
            dishes[indexDish].TypeOfDish = newType;
            SaveInDataBaseFoodMenu();
        }
        public static void EditPictureDish(int id, string newPictureDish)
        {
            int indexDish = dishes.FindIndex(x => x.Id.Equals(id));
            dishes[indexDish].PictureDish = newPictureDish;
            SaveInDataBaseFoodMenu();
        }
        public static void AddToCart(int id)
        {
            Cart.Add(id);
        }
        public static void RemoveFromCart(int id)
        { 
            Cart.Remove(id);
        }
    }
}
