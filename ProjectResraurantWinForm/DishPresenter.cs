using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectResraurantWinForm
{
    class DishPresenter
    {
        static Form1 form1 = (Form1)Application.OpenForms["Form1"];
        public static int premission = 0; // 0 - usershop 1 - userCart 2 - Adminshop 3 - adminCart
        public static void Initialize(TabControl tabControlTypesMenu)
        {
            DishModel.InitializeDishMenu();
            DishModel.InitializeTypesMenu();
            tabControlTypesMenu.TabPages.Clear();
            DishModel.listTypePage.Clear();
            TabPage myTabPage = new TabPage("Всё");
            tabControlTypesMenu.TabPages.Add(myTabPage);
            tabControlTypesMenu.TabPages[0].UseVisualStyleBackColor = true;
            DishModel.listTypePage.Add(new ListBox());
            DishModel.listTypePage[0].Dock = DockStyle.Fill;
            DishModel.listTypePage[0].Name = "TypeListBox" + (0);
            tabControlTypesMenu.TabPages[0].Controls.Add(DishModel.listTypePage[0]);
            DishModel.listTypePage[0].Items.Clear();
            foreach (var dish in DishModel.dishes)
            {
                DishModel.listTypePage[0].DisplayMember = "DishName";
                DishModel.listTypePage[0].ValueMember = "Id";
                DishModel.listTypePage[0].Items.Add(dish);
            }
               
            for (int i = 0; i < DishModel.AllTypeDishes.Count; i++)
            {
                myTabPage = new TabPage(DishModel.AllTypeDishes[i]);
                tabControlTypesMenu.TabPages.Add(myTabPage);
                tabControlTypesMenu.TabPages[i + 1].UseVisualStyleBackColor = true;
                var searchedFoodMenu = from query in DishModel.dishes
                                       where query.TypeOfDish.Contains(DishModel.AllTypeDishes[i])
                                       select query;
                DishModel.listTypePage.Add(new ListBox());
                DishModel.listTypePage[i + 1].Name = "TypeListBox" + (i + 1);
                DishModel.listTypePage[i + 1].Dock = DockStyle.Fill;
                tabControlTypesMenu.TabPages[i + 1].Controls.Add(DishModel.listTypePage[i + 1]);
                DishModel.listTypePage[i + 1].Items.Clear();
                foreach (var dish in searchedFoodMenu)
                {
                    DishModel.listTypePage[i + 1].DisplayMember = "DishName";
                    DishModel.listTypePage[i + 1].ValueMember = "Id";
                    DishModel.listTypePage[i + 1].Items.Add(dish);
                }
                
            }
        }
        public static void InitializeCart(ListBox ShoppingCartListBox)
        {
            ShoppingCartListBox.Items.Clear();
            foreach (var dish in DishModel.Cart)
            {
                //ShoppingCartListBox.DataSource = DishModel.Cart;
                ShoppingCartListBox.Items.Add(dish);
                ShoppingCartListBox.DisplayMember = "DishName";
                ShoppingCartListBox.ValueMember = "Id";
            }
        }

        public static void UpdateInformation(int id)
        {
            
            int indexDish = DishModel.dishes.FindIndex(x => x.Id.Equals(id));
            string nameDish = DishModel.dishes[indexDish].DishName;
            form1.TextBoxNameDishEdit.Text = nameDish;
            form1.labelNameDishUser.Text = nameDish;
            string addressPicture = DishModel.dishes[indexDish].PictureDish;
            try
            {
                form1.pictureBoxDish.Image = Image.FromFile(addressPicture);
            }
            catch
            {
                form1.pictureBoxDish.Image = form1.pictureBoxDish.ErrorImage;
            }
            form1.maskedTextBoxTimeCookEdit.Text = DishModel.dishes[indexDish].CookingTime.ToString();
            //form1.labelTimeCookingEdit.Show()
            form1.comboBoxTypeDishEdit.DataSource = DishModel.AllTypeDishes;
            form1.comboBoxTypeDishEdit.SelectedItem = DishModel.dishes[indexDish].TypeOfDish;
            form1.maskedTextBoxPriceDishEdit.Text = DishModel.dishes[indexDish].PriceOfDIsh.ToString();
            form1.textBoxDescriptionEdit.Text = DishModel.dishes[indexDish].DescriptionDish;
            form1.labelPriceDishUser.Text = "Цена: " + DishModel.dishes[indexDish].PriceOfDIsh.ToString() + " Руб.";
            form1.labelTimeCookUser.Text = "Время готовки: " + DishModel.dishes[indexDish].CookingTime.ToString() + " мин.";
            form1.labelTypeDishUser.Text = "Тип блюда: " + DishModel.dishes[indexDish].TypeOfDish.ToString();
            form1.textBoxDescriptionUser.Text = DishModel.dishes[indexDish].DescriptionDish;
            form1.textBoxDescriptionEdit.Text = DishModel.dishes[indexDish].DescriptionDish;
            //form1.
            switch (premission)
            {
                case 0:
                    form1.ShowBoxUserShop();
                    break;
                case 1:
                    form1.ShowBoxUserCart();
                    break;
                case 2:
                    form1.ShowBoxAdminShop();
                    break;
                case 3:
                    form1.ShowBoxUserCart();
                    break;
            }
        }

        public static List<Dish> GetDishes()
        {
            return DishModel.dishes;
        }

        public static List<ListBox> GetListType()
        {
            return DishModel.listTypePage;
        }

        public static void Autharization(TextBox login, TextBox password)
        {

            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            Form2 form2 = (Form2)Application.OpenForms["Form2"];
            if (login.Text == "admin" && password.Text == "admin")
            {
                form2.Close();
                form1.AuthorizationSuccessful();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Error");
                login.Text = "";
                password.Text = "";
            }
            
        }

        public static void AddType(string type)
        {
            if(DishModel.AddType(type))
            {
                MessageBox.Show("Тип блюда: " + type + " успешно добавлен!", "Успех");
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                form1.Initialization();
                FormAddType formAddType = (FormAddType)Application.OpenForms["FormAddType"];
                formAddType.Close();
            }
            else
            {
                MessageBox.Show("Ошибка! Данный тип уже добавлен.", "Error");
            }   
        }

        public static void EditDishName(int id, string newNameDish)
        {
            switch (DishModel.EditDishName(id, newNameDish))
            {
                case 0:
                    MessageBox.Show("Такое название блюда уже используется!", "Error");
                    break;
                case 1:
                    MessageBox.Show("Название блюда содержит недопустимые символы!", "Error");
                    break;
                case 2:
                    MessageBox.Show("Название блюда должно содержать символы!", "Error");
                    break;
                case 3:
                    MessageBox.Show("Название блюда успешно изменено", "Успех");
                    
                    form1.Initialization();
                    break;
            }
            
        }
        public static void EditPriceDish(int id, int newPrice)
        {
            DishModel.EditPriceDish(id, newPrice);
            MessageBox.Show("Новая цена установлена", "Успех");
            form1.Initialization();
        }
        public static void EditTimeCooking(int id, int newPrice)
        {
            DishModel.EditTimeCooking(id, newPrice);
            MessageBox.Show("Новое время готовки установлено", "Успех");
            form1.Initialization();

        }
        public static void EditDescriptionDish(int id, string newDescription)
        {
            DishModel.EditDescriptionDish(id, newDescription);
            MessageBox.Show("Новое описание блюда установлено", "Успех");
            form1.Initialization();

        }
        public static void EditTypeDish(int id, int indexType)
        {
            string newType = DishModel.AllTypeDishes[indexType];
            DishModel.EditTypeDish(id, newType);
            form1.Initialization();
        }
        public static void AddInCart(int id, ListBox ShoppingCartListBox)
        {
            DishModel.AddToCart(id);
            InitializeCart(ShoppingCartListBox);
        }
        public static void GoToCart()
        {
            if (premission == 2)
                premission = 3;
            else
                premission = 1;
            form1.HideAll();
        }
        public static void GoToShop(int index)
        {

            if (premission == 3)
                premission = 2;
            else
                premission = 0;
            //int index = tabControlTypesMenu.SelectedIndex;
            DishModel.listTypePage[index].ClearSelected();
            
            form1.HideAll();
        }
        

    }
}
