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
            DishModel.listTypePage[0].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DishModel.listTypePage[0].Size = new Size(411, 410);
            DishModel.listTypePage[0].Location = new Point(3, 4);
            DishModel.listTypePage[0].Name = "TypeListBox" + (0);
            tabControlTypesMenu.TabPages[0].Controls.Add(DishModel.listTypePage[0]);
            DishModel.listTypePage[0].Items.Clear();
            foreach (var dish in DishModel.dishes)
                DishModel.listTypePage[0].Items.Add(dish.DishName);
            for (int i = 0; i < DishModel.AllTypeDishes.Count; i++)
            {
                myTabPage = new TabPage(DishModel.AllTypeDishes[i]);
                tabControlTypesMenu.TabPages.Add(myTabPage);
                tabControlTypesMenu.TabPages[i + 1].UseVisualStyleBackColor = true;
                var searchedFoodMenu = from query in DishModel.dishes
                                       where query.TypeOfDish.Contains(DishModel.AllTypeDishes[i])
                                       select query;
                DishModel.listTypePage.Add(new ListBox());
                DishModel.listTypePage[i + 1].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                DishModel.listTypePage[i + 1].Size = new Size(411, 410);
                DishModel.listTypePage[i + 1].Location = new Point(3, 4);
                DishModel.listTypePage[i + 1].Name = "TypeListBox" + (i + 1);
                tabControlTypesMenu.TabPages[i + 1].Controls.Add(DishModel.listTypePage[i + 1]);
                DishModel.listTypePage[i + 1].Items.Clear();
                foreach (var dish in searchedFoodMenu)
                    DishModel.listTypePage[i + 1].Items.Add(dish.DishName);
            }
        }

        public static void UpdateInformation(ListBox enteredListBox, TextBox NameDishTextBox, PictureBox pictureBoxDish, TextBox textBoxTimeCooking, TextBox textBoxTypeDish, TextBox PriceDishTextBox, TextBox textBoxDescription)
        {
            int index = enteredListBox.SelectedIndex;
            string nameDish = enteredListBox.Items[index].ToString();
            NameDishTextBox.Text = nameDish;
            int indexDish = DishModel.dishes.FindIndex(x => x.DishName.Equals(nameDish));
            string addressPicture = DishModel.dishes[indexDish].PictureDish;
            try
            {
                pictureBoxDish.Image = Image.FromFile(addressPicture);
            }
            catch
            {
                pictureBoxDish.Image = pictureBoxDish.ErrorImage;
            }
            textBoxTimeCooking.Text = DishModel.dishes[indexDish].CookingTime.ToString();
            textBoxTypeDish.Text = DishModel.dishes[indexDish].TypeOfDish;
            PriceDishTextBox.Text = DishModel.dishes[indexDish].PriceOfDIsh.ToString();
            textBoxDescription.Text = DishModel.dishes[indexDish].DescriptionDish;
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
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            DishModel.AddType(type);
            form1.Initialization();

        }
    }
}
