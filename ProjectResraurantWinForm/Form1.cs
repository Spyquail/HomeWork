using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectResraurantWinForm
{
    public partial class Form1 : Form
    {
        Dish selectedDish;
        public static List<DataGridView> listTypePage = new();
        public Form1()
        {
            InitializeComponent();
            Initialization();
            toolStripMenuItemAuthorization.Click += FormAuthorization;
            toolStripMenuItemAddDish.Click += FormAddDish;
            toolStripMenuItemAddType.Click += FormAddType;
            toolStripMenuItemRemoveType.Click += FormRemoveType;
            toolStripMenuItemExit.Click += Exit;  
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
                formAddType.ShowDialog();
            }
            else
            {
                FormAddType formAddType = (FormAddType)Application.OpenForms["FormAddType"];
                formAddType.BringToFront();
            }
        }
        private void FormRemoveType(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormRemoveType>().Any())
            {
                FormRemoveType formRemoveType = new FormRemoveType();
                formRemoveType.ShowDialog();
            }
            else
            {
                FormRemoveType formRemoveType = (FormRemoveType)Application.OpenForms["FormRemoveType"];
                formRemoveType.BringToFront();
            }
        }
        private void FormAddDish(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormAddDish>().Any())
            {
                FormAddDish formAddDish = new FormAddDish();
                formAddDish.ShowDialog();
            }
            else
            {
                FormAddDish formAddDish = (FormAddDish)Application.OpenForms["FormAddDish"];
                formAddDish.BringToFront();
            }
        }
        public void Initialization()
        {
            DishPresenter.Initialize(tabControlTypesMenu);
            foreach (var temp in DishPresenter.GetListType())
            {
                temp.SelectionChanged += DataGridView_IndexClick;
                temp.CellClick += DataGridView_CellClick;
            }

            tabControlTypesMenu.SelectedIndexChanged += tabControlTypesMenu_SelectedIndexChanged;

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
        public void DataGridView_IndexClick(object sender, EventArgs e)
        {
            var enteredDataGridView = (DataGridView)sender;
            if(enteredDataGridView != null && enteredDataGridView.Focused == true)
            {
                int indexRow = int.Parse(enteredDataGridView.CurrentRow.Index.ToString());
                int enteredId = int.Parse(enteredDataGridView[0, indexRow].Value.ToString());
                DishPresenter.UpdateInformation(enteredId);
                int indexDish = DishPresenter.GetDishes().FindIndex(x => x.Id.Equals(enteredId));
                selectedDish = DishPresenter.GetDishes()[indexDish];
            }  
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var enteredDataGridView = (DataGridView)sender;
            int indexRow = int.Parse(enteredDataGridView.CurrentRow.Index.ToString());
            if (e.RowIndex == indexRow)
            {
                int enteredId = int.Parse(enteredDataGridView[0, indexRow].Value.ToString());
                DishPresenter.UpdateInformation(enteredId);
            }
        }
        private void AddFoodInCartbutton_Click(object sender, EventArgs e)
        {
            DishPresenter.AddInCart(selectedDish.Id);
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
                    break;
            }
        }
        public void tabControlTypesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAll();
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
            buttonAddMinusDish.Visible = false;
            buttonAddPlusDish.Visible = false;
            textBoxNumberOfDish.Visible = false;
            labelNumberOfDish.Visible = false;
            buttonRemoveDish.Visible = false;
            dataGridViewShopingCart.ClearSelection();
            foreach (var list in listTypePage)
                list.ClearSelection();
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
            labelPriceDishUser.Visible = true;
            labelTypeDishUser.Visible = true;
            labelTimeCookUser.Visible = true;
            textBoxDescriptionUser.Visible = true;
            buttonAddMinusDish.Visible = true;
            buttonAddPlusDish.Visible = true;
            textBoxNumberOfDish.Visible = true;
            labelNumberOfDish.Visible = true;
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
            buttonRemoveDish.Visible = true;
        }
        private void ShoppingCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView_IndexClick(sender, e);
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
        private void maskedTextBoxPriceDishEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            var enteredTextBox = (MaskedTextBox)sender;
            if (e.KeyChar == 13 && enteredTextBox.Focused == true) //Enter
                DishPresenter.EditPriceDish(selectedDish.Id, int.Parse(maskedTextBoxPriceDishEdit.Text));
        }
        private void comboBoxTypeDishEdit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indexType = comboBoxTypeDishEdit.SelectedIndex;
            DishPresenter.EditTypeDish(selectedDish.Id, indexType);
        }
        private void buttonRemoveDish_Click(object sender, EventArgs e)
        {
            DishPresenter.RemoveDish(selectedDish.Id);
        }
        private void buttonAddMinusDish_Click(object sender, EventArgs e)
        {
            DishPresenter.RemoveFromCart(selectedDish.Id);   
        }
        private void buttonAddPlusDish_Click(object sender, EventArgs e)
        {
            DishPresenter.AddInCart(selectedDish.Id);
        }
        private void dataGridViewShopingCart_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView_IndexClick(sender, e);
        }
        private void pictureBoxDish_Click(object sender, EventArgs e)
        {
            if(DishPresenter.premission == 2 || DishPresenter.premission == 3)
                DishPresenter.EditPictureDish(selectedDish.Id);
        }
        private void maskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = ((MaskedTextBox)sender).Text.Length;
        }
        private void maskedTextBoxTimeCookEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            var enteredTextBox = (MaskedTextBox)sender;
            if (e.KeyChar == 13 && enteredTextBox.Focused == true) //Enter
                DishPresenter.EditTimeCooking(selectedDish.Id, int.Parse(maskedTextBoxTimeCookEdit.Text));
        }
        private void buttonMakeAnOrder_Click(object sender, EventArgs e)
        {
            DishPresenter.MakeAnOrder();
        }
    }
}
