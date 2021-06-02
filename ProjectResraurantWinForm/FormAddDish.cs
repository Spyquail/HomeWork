using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectResraurantWinForm
{
    public partial class FormAddDish : Form
    {
        string directoryPicture = "";
        int id = 1;
        public FormAddDish()
        {
            InitializeComponent();
            comboBoxTypeDish.DataSource = DishPresenter.GetAllType();
            
            while(true)
            {
                if (DishPresenter.GetDishes().Exists(x => x.Id == id))
                    id++;
                else
                    break;
            }
        }

        
        private void buttonSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new();
            OPF.Filter = "Файлы jpg|*.jpg";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                directoryPicture = OPF.FileName;
                try
                {
                    pictureBox.Image = Image.FromFile(directoryPicture);
                }
                catch
                {
                    pictureBox.Image = pictureBox.ErrorImage;
                }
            }
        }

        private void buttonAddDish_Click(object sender, EventArgs e)
        {
            if (textBoxDescription.Text != "" && textBoxNameDish.Text != "" && maskedTextBoxPrice.Text != "" && maskedTextBoxTimeCooking.Text != "")
            {
                Dish newDish = new Dish(id, textBoxNameDish.Text, comboBoxTypeDish.Text, int.Parse(maskedTextBoxPrice.Text), int.Parse(maskedTextBoxTimeCooking.Text), textBoxDescription.Text, directoryPicture);
                DishPresenter.AddDish(newDish);
            }
            else
                MessageBox.Show("Все поля являются обязательным для заполнения, кроме картинки", "Error");
        }
    }
}
