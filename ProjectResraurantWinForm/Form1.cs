using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectResraurantWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTypesMenu();
            DishListBoxUpdate();
            DishListBox.SelectedIndexChanged += DishListBox_IndexClick;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DishListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DishListBoxUpdate()
        {
            DishListBox.Items.Clear();
            foreach (var dish in Dish.dishes)
                DishListBox.Items.Add(dish.DishName);
        }
        private void InitializeTypesMenu()
        {
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
                        Dish.AllTypeDishes.Add(readedType);
                    }
                }
            }
            else
            {
                Dish.AllTypeDishes.Add("Салат");
                Dish.AllTypeDishes.Add("Суп");
                Dish.AllTypeDishes.Add("Паста");
                Dish.AllTypeDishes.Add("Горячее блюдо");
                Dish.AllTypeDishes.Add("Десерт");
                Dish.SaveInTxtTypesFood();
            }
            for(int i = 0; i < Dish.AllTypeDishes.Count; i++)
            {
                TabPage myTabPage = new TabPage(Dish.AllTypeDishes[i]);
                tabControl2.TabPages.Add(myTabPage);
                tabControl2.TabPages[i + 1].UseVisualStyleBackColor = true;
                Dish.list.Add(new ListBox());
                Dish.list[i].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                var searchedFoodMenu = from query in Dish.dishes
                                       where query.TypeOfDish.Contains(Dish.AllTypeDishes[i])
                                       select query;
                List<Dish> printedFoodMenuClone = new List<Dish>();
                foreach (var temp in searchedFoodMenu)
                {
                    printedFoodMenuClone.Add(temp);
                }
                Dish.list[i].Size = new Size(DishListBox.Size.Width - 200, DishListBox.Size.Height - 260);
                Dish.list[i].Location = new Point(3, 4);
                tabControl2.TabPages[i + 1].Controls.Add(Dish.list[i]);
                Dish.list[i].Items.Clear();
                foreach (var dish in printedFoodMenuClone)
                    Dish.list[i].Items.Add(dish.DishName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NameDishTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DishListBox_IndexClick(object sender, EventArgs e)
        {
            int index = DishListBox.SelectedIndex;
            NameDishTextBox.Text = DishListBox.Items[index].ToString();
        }
    }
}
