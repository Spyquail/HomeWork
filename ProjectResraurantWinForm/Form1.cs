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
        Dish selectedDish;
        public Form1()
        {
            InitializeComponent();
            Initialization();

            toolStripMenuItemAuthorization.Click += FormAuthorization;
            //toolStripMenuItemAddDish.Click +=;
            toolStripMenuItemAddType.Click += FormAddType;
            //toolStripMenuItemEditDish.Click +=;
            //toolStripMenuItemRemoveDish.Click +=;
            //toolStripMenuItemRemoveType.Click +=;
            toolStripMenuItemExit.Click += Exit;
            comboBoxTypeDishEdit.SelectedIndexChanged += comboBoxTypeDishEdit_SelectionChangeCommitted;
        }

        private void FormAuthorization(object sender, EventArgs e)
        {

            if (!Application.OpenForms.OfType<Form2>().Any())
            {
                Form2 formAuth = new Form2();
                formAuth.Show();
            }
            else
            {
                Form2 formAuth = (Form2)Application.OpenForms["Form2"];
                formAuth.BringToFront();
            }


        }
        private void FormAddType(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormAddType>().Any())
            {
                FormAddType formAddType = new FormAddType();
                formAddType.Show();
            }
            else
            {
                FormAddType formAddType = (FormAddType)Application.OpenForms["FormAddType"];
                formAddType.BringToFront();
            }
        }
        public void Initialization()
        {
            DishPresenter.Initialize(tabControlTypesMenu);
            foreach (var temp in DishPresenter.GetListType())
                temp.SelectedIndexChanged += DishListBox_IndexClick;
        }
        public void AuthorizationSuccessful()
        {
            if (DishPresenter.premission == 0)
                DishPresenter.premission = 2;
            else
                DishPresenter.premission = 3;
            toolStripMenuItemAuthorization.Visible = false;
            toolStripMenuItemAddDish.Visible = true;
            toolStripMenuItemAddType.Visible = true;
            toolStripMenuItemEditDish.Visible = true;
            toolStripMenuItemRemoveDish.Visible = true;
            toolStripMenuItemRemoveType.Visible = true;
            toolStripMenuItemExit.Visible = true;
            labelAuth.Visible = true;
            HideAll();
        }

        public void Exit(object sender, EventArgs e)
        {

            if (DishPresenter.premission == 3)
                DishPresenter.premission = 1;
            else
                DishPresenter.premission = 0;
            toolStripMenuItemAuthorization.Visible = true;
            toolStripMenuItemAddDish.Visible = false;
            toolStripMenuItemAddType.Visible = false;
            toolStripMenuItemEditDish.Visible = false;
            toolStripMenuItemRemoveDish.Visible = false;
            toolStripMenuItemRemoveType.Visible = false;
            toolStripMenuItemExit.Visible = false;
            labelAuth.Visible = false;
            Form2 form2 = (Form2)Application.OpenForms["Form2"];
            if (Application.OpenForms.OfType<Form2>().Any())
            {
                form2.Close();
            }
            FormAddType formAddType = (FormAddType)Application.OpenForms["FormAddType"];
            if (Application.OpenForms.OfType<FormAddType>().Any())
            {
                formAddType.Close();
            }
            HideAll();
        }

        public void DishListBox_IndexClick(object sender, EventArgs e)
        {
            var enteredListBox = (ListBox)sender;
            selectedDish = (Dish)enteredListBox.SelectedItem;
            if (enteredListBox.SelectedIndex >= 0)
                DishPresenter.UpdateInformation(selectedDish.Id);
        }

        private void AddFoodInCartbutton_Click(object sender, EventArgs e)
        {

            DishPresenter.AddInCart(selectedDish.Id, ShoppingCartListBox);
        }
        
        private void tabControlMainMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tabControlMainMenu.SelectedIndex)
            {
                case 0:

                    int index = tabControlTypesMenu.SelectedIndex;
                    DishPresenter.GoToShop(index);
                    break;
                case 1:
                    DishPresenter.GoToCart();
                    ShoppingCartListBox.ClearSelected();
                    break;
            }


        }
        public void HideAll()
        {
            AddFoodInCartbutton.Visible = false;
            labelTimeCookingEdit.Visible = false;
            labelTypeDishEdit.Visible = false;
            pictureBoxDish.Visible = false;
            LabelNameFoodEdit.Visible = false;
            LabelPriceDishEdit.Visible = false;
            comboBoxTypeDishEdit.Visible = false;
            maskedTextBoxPriceDishEdit.Visible = false;
            textBoxDescriptionEdit.Visible = false;
            TextBoxNameDishEdit.Visible = false;
            labelNameDishUser.Visible = false;
            buttonSaveDescription.Visible = false;
            maskedTextBoxTimeCookEdit.Visible = false; 
            labelPriceDishUser.Visible = false; 
            labelTypeDishUser.Visible = false; 
            labelTimeCookUser.Visible = false; 
            textBoxDescriptionUser.Visible = false; 
    }
        public void ShowBoxUserShop()
        {
            pictureBoxDish.Visible = true;
            labelNameDishUser.Visible = true;
            AddFoodInCartbutton.Visible = true;
            labelPriceDishUser.Visible = true;
            labelTypeDishUser.Visible = true;
            labelTimeCookUser.Visible = true;
            textBoxDescriptionUser.Visible = true;
        }
        public void ShowBoxUserCart()
        {
            pictureBoxDish.Visible = true;
            labelNameDishUser.Visible = true;
            AddFoodInCartbutton.Visible = true;
            labelPriceDishUser.Visible = true;
            labelTypeDishUser.Visible = true;
            labelTimeCookUser.Visible = true;
            textBoxDescriptionUser.Visible = true;
        }
        public void ShowBoxAdminShop()
        {
            AddFoodInCartbutton.Visible = true;
            labelTimeCookingEdit.Visible = true;
            labelTypeDishEdit.Visible = true;
            pictureBoxDish.Visible = true;
            LabelNameFoodEdit.Visible = true;
            LabelPriceDishEdit.Visible = true;
            comboBoxTypeDishEdit.Visible = true;
            maskedTextBoxPriceDishEdit.Visible = true;
            textBoxDescriptionEdit.Visible = true;
            TextBoxNameDishEdit.Visible = true;
            maskedTextBoxTimeCookEdit.Visible = true;
            buttonSaveDescription.Visible = true;
        }

        private void ShoppingCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DishListBox_IndexClick(sender, e);
        }

        private void TextBoxNameDishEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            var enteredTextBox = (TextBox)sender;
            if (e.KeyChar == 13 && enteredTextBox.Focused == true) //Enter
                DishPresenter.EditDishName(selectedDish.Id, TextBoxNameDishEdit.Text);
        }

        private void buttonSaveDescription_Click(object sender, EventArgs e)
        {
            DishPresenter.EditDescriptionDish(selectedDish.Id, textBoxDescriptionEdit.Text);
        }

        private void maskedTextBoxTimeCookEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            var enteredTextBox = (MaskedTextBox)sender;
            if (e.KeyChar == 13 && enteredTextBox.Focused == true) //Enter
                DishPresenter.EditTimeCooking(selectedDish.Id, int.Parse(maskedTextBoxTimeCookEdit.Text));
        }

        private void maskedTextBoxPriceDishEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            var enteredTextBox = (MaskedTextBox)sender;
            if (e.KeyChar == 13 && enteredTextBox.Focused == true) //Enter
                DishPresenter.EditPriceDish(selectedDish.Id, int.Parse(maskedTextBoxPriceDishEdit.Text));
        }

        private void comboBoxTypeDishEdit_SelectionChangeCommitted(object sender, EventArgs e)//Не правильно работает
        {
            int indexType = comboBoxTypeDishEdit.SelectedIndex;
            DishPresenter.EditTypeDish(selectedDish.Id, indexType);
        }
    }
}
