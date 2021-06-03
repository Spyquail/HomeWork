using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectResraurantWinForm
{
    class DishPresenter
    {
        static int fullPrice = 0;
        static int fullTmeCooking = 0;
        static Form1 form1 = (Form1)Application.OpenForms["Form1"];
        public static int premission = 0; // 0 - usershop 1 - userCart 2 - Adminshop 3 - adminCart
        public static void Initialize(TabControl tabControlTypesMenu)
        {
            DishModel.InitializeDishMenu();
            DishModel.InitializeTypesMenu();
            tabControlTypesMenu.TabPages.Clear();

            Form1.listTypePage.Clear();
            TabPage myTabPage = new TabPage("Всё");
            tabControlTypesMenu.TabPages.Add(myTabPage);
            tabControlTypesMenu.TabPages[0].UseVisualStyleBackColor = true;
            Form1.listTypePage.Add(new DataGridView());
            Form1.listTypePage[0].Dock = DockStyle.Fill;
            Form1.listTypePage[0].Name = "dataGridView" + (0);
            tabControlTypesMenu.TabPages[0].Controls.Add(Form1.listTypePage[0]);
            Form1.listTypePage[0].Rows.Clear();
            Form1.listTypePage[0].ColumnCount = 3;
            Form1.listTypePage[0].AllowUserToAddRows = false;
            Form1.listTypePage[0].RowHeadersVisible = false;
            Form1.listTypePage[0].SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Form1.listTypePage[0].AllowUserToResizeRows = false;
            Form1.listTypePage[0].ReadOnly = true;
            Form1.listTypePage[0].GridColor = SystemColors.ControlLightLight;
            Form1.listTypePage[0].BackgroundColor = SystemColors.ControlLightLight;
            foreach (var dish in DishModel.dishes)
            {
                Form1.listTypePage[0].Columns[1].Name = "Название";
                Form1.listTypePage[0].Columns[1].Width = 316;
                Form1.listTypePage[0].Columns[2].Width = 40;
                Form1.listTypePage[0].Columns[2].Name = "Цена";
                Form1.listTypePage[0].Columns[0].Name = "ID";
                Form1.listTypePage[0].Columns[0].Visible = false;
                Form1.listTypePage[0].Rows.Add(dish.Id, dish.DishName, dish.PriceOfDIsh);
            }
               
            for (int i = 0; i < DishModel.AllTypeDishes.Count; i++)
            {
                myTabPage = new TabPage(DishModel.AllTypeDishes[i]);
                tabControlTypesMenu.TabPages.Add(myTabPage);
                tabControlTypesMenu.TabPages[i + 1].UseVisualStyleBackColor = true;
                var searchedFoodMenu = from query in DishModel.dishes
                                       where query.TypeOfDish.Contains(DishModel.AllTypeDishes[i])
                                       select query;
                Form1.listTypePage.Add(new DataGridView());
                Form1.listTypePage[i + 1].Name = "TypeListBox" + (i + 1);
                Form1.listTypePage[i + 1].Dock = DockStyle.Fill;
                tabControlTypesMenu.TabPages[i + 1].Controls.Add(Form1.listTypePage[i + 1]);
                Form1.listTypePage[i + 1].Rows.Clear();
                Form1.listTypePage[i + 1].ColumnCount = 3;
                Form1.listTypePage[i + 1].AllowUserToAddRows = false;
                Form1.listTypePage[i + 1].RowHeadersVisible = false;
                Form1.listTypePage[i + 1].SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Form1.listTypePage[i + 1].AllowUserToResizeRows = false;
                Form1.listTypePage[i + 1].ReadOnly = true;
                Form1.listTypePage[i + 1].GridColor = SystemColors.ControlLightLight;
                Form1.listTypePage[i + 1].BackgroundColor = SystemColors.ControlLightLight;
                foreach (var dish in searchedFoodMenu)
                {
                    Form1.listTypePage[i + 1].Columns[1].Name = "Название";
                    Form1.listTypePage[i + 1].Columns[1].Width = 333;
                    Form1.listTypePage[i + 1].Columns[2].Width = 40;
                    Form1.listTypePage[i + 1].Columns[2].Name = "Цена";
                    Form1.listTypePage[i + 1].Columns[0].Name = "ID";
                    Form1.listTypePage[i + 1].Columns[0].Visible = false;
                    Form1.listTypePage[i + 1].Rows.Add(dish.Id, dish.DishName, dish.PriceOfDIsh);
                }
            }
        }
        public static void InitializeCart()
        {
            form1.dataGridViewShopingCart.ColumnCount = 4;
            form1.dataGridViewShopingCart.Rows.Clear();
            form1.dataGridViewShopingCart.Columns[1].Name = "Название";
            form1.dataGridViewShopingCart.Columns[1].Width = 304;
            form1.dataGridViewShopingCart.Columns[2].Name = "Цена";
            form1.dataGridViewShopingCart.Columns[2].Width = 45;
            form1.dataGridViewShopingCart.Columns[3].Name = "Кол-во";
            form1.dataGridViewShopingCart.Columns[3].Width = 35;
            form1.dataGridViewShopingCart.Columns[0].Name = "ID";
            form1.dataGridViewShopingCart.Columns[0].Visible = false;
            foreach (var dishId in DishModel.Cart)
            {
                bool check = true;
                for (int i = 0; i < form1.dataGridViewShopingCart.Rows.Count; i++)
                {
                    int findedId = int.Parse(form1.dataGridViewShopingCart[0, i].Value.ToString());
                    if (findedId == dishId)
                        check = false;
                }
                int indexDish = DishModel.dishes.FindIndex(x => x.Id.Equals(dishId));
                if (check)
                {
                    form1.dataGridViewShopingCart.Rows.Add(DishModel.dishes[indexDish].Id, DishModel.dishes[indexDish].DishName, DishModel.dishes[indexDish].PriceOfDIsh, NumberOfDish(dishId));
                }
            }
        }
        public static void UpdateInformation(int id)
        {
            if (Application.OpenForms.OfType<Form1>().Any())
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
                form1.comboBoxTypeDishEdit.DataSource = null;
                form1.comboBoxTypeDishEdit.DataSource = DishModel.AllTypeDishes;
                form1.comboBoxTypeDishEdit.SelectedItem = DishModel.dishes[indexDish].TypeOfDish;
                form1.maskedTextBoxPriceDishEdit.Text = DishModel.dishes[indexDish].PriceOfDIsh.ToString();
                form1.textBoxDescriptionEdit.Text = DishModel.dishes[indexDish].DescriptionDish;
                form1.labelPriceDishUser.Text = "Цена: " + DishModel.dishes[indexDish].PriceOfDIsh.ToString() + " Руб.";
                form1.labelTimeCookUser.Text = "Время готовки: " + DishModel.dishes[indexDish].CookingTime.ToString() + " мин.";
                form1.labelTypeDishUser.Text = "Тип блюда: " + DishModel.dishes[indexDish].TypeOfDish.ToString();
                form1.textBoxDescriptionUser.Text = DishModel.dishes[indexDish].DescriptionDish;
                form1.textBoxDescriptionEdit.Text = DishModel.dishes[indexDish].DescriptionDish;
                form1.textBoxNumberOfDish.Text = NumberOfDish(id).ToString();
                fullPrice = 0;
                fullTmeCooking = 0;
                foreach (var tempId in DishModel.Cart)
                {
                    int tempIndexDish = DishModel.dishes.FindIndex(x => x.Id.Equals(tempId));
                    fullPrice += DishModel.dishes[tempIndexDish].PriceOfDIsh;
                    fullTmeCooking += DishModel.dishes[tempIndexDish].CookingTime;
                }
                form1.labelFullPrice.Text = "Полная стоимость: " + fullPrice + " руб";
                form1.labelFullTimeCooking.Text = "Общее время: " + fullTmeCooking + " мин";
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
        }
        public static List<Dish> GetDishes()
        {
            return DishModel.dishes;
        }
        public static List<DataGridView> GetListType()
        {
            return Form1.listTypePage;
        }
        public static List<string> GetAllType()
        {
            return ProjectResraurantWinForm.DishModel.AllTypeDishes;
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
        public static void AddDish(Dish newDish)
        {
            string directory = newDish.PictureDish;
            if (newDish.PictureDish != "")
                newDish.PictureDish = @$"Pictures\{newDish.Id}.jpg";
            if (DishModel.AddDish(newDish))
            {
                if(newDish.PictureDish != "")
                    File.Copy(directory, @$"Pictures\{newDish.Id}.jpg", true);
                MessageBox.Show("Новое блюдо добавлено", "Успех");
                form1.Initialization();
                FormAddDish formAddDish = (FormAddDish)Application.OpenForms["FormAddDish"];
                formAddDish.Close();
            }
            else
                MessageBox.Show("Такое блюдо уже есть", "Error");
        }
        public static void AddInCart(int id)
        {
            DishModel.AddToCart(id);
            InitializeCart();
            UpdateInformation(id);
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
                case 4:
                    MessageBox.Show("Слишком длинное название блюда!", "Error");
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
        public static void EditTimeCooking(int id, int timeCooking)
        {
            DishModel.EditTimeCooking(id, timeCooking);
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
        public static void EditPictureDish(int id)
        {
            OpenFileDialog OPF = new();
            OPF.Filter = "Файлы jpg|*.jpg";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                string directoryPicture = OPF.FileName;
                try
                {
                    File.Copy(directoryPicture, @$"Pictures\{id}.jpg", true);
                    DishModel.EditPictureDish(id, @$"Pictures\{id}.jpg");
                    form1.Initialization();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public static void RemoveType(string removedType)
        {
            bool check = DishModel.dishes.Exists(x => x.TypeOfDish.Equals(removedType));
            if (!check)
            {
                MessageBox.Show("Тип блюда: " + removedType + " успешно удалён!", "Успех");
                DishModel.RemoveType(removedType);
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                form1.Initialization();
                form1.HideAll();
            }
            else
            {
                MessageBox.Show("Удалить тип нельзя, есть блюда с выбранным типом. Необходимо сменить тип или удалить блюда", "Error");
            }
        }
        public static void RemoveDish(int id)
        {
            if(DishModel.Cart.Contains(id))
            {
                MessageBox.Show("Корзина содержит удаляемое блюдо, уберите его из корзины", "Error");
            }
            else
            {
                DishModel.RemoveDish(id);
                MessageBox.Show("Блюдо удалено", "Успех");
                form1.Initialization();
                form1.HideAll();
            }
        }
        public static void RemoveFromCart(int id)
        {
            DishModel.RemoveFromCart(id);
            InitializeCart();
            UpdateInformation(id);
            if (!DishModel.Cart.Contains(id))
                form1.HideAll();     
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
            form1.HideAll();
        }
        public static int NumberOfDish(int enteredId)
        {
            int number = 0;
            foreach (var dishid in DishModel.Cart)
            {
                if (dishid == enteredId)
                    number++;
            }
            return number;
        }
        public static void MakeAnOrder()
        {
            if (DishModel.Cart.Count != 0)
            {
                MessageBox.Show($"Заказ сделан!\nВремя готовки: {fullTmeCooking} мин\nК оплате: {fullPrice} руб", "Успех");
                DishModel.Cart.Clear();
                form1.Initialization();
                InitializeCart();
                form1.labelFullPrice.Text = "Полная стоимость: " + 0 + " руб";
                form1.labelFullTimeCooking.Text = "Общее время: " + 0 + " мин";
            }
            else
                MessageBox.Show("Корзина пуста :(");
        }
    }
}
