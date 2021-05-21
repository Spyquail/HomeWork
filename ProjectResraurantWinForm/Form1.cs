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
            Initialization();
            foreach (var temp in DishPresenter.GetListType())
                temp.SelectedIndexChanged += DishListBox_IndexClick;
            toolStripMenuItemAuthorization.Click += FormAuthorization;
            //toolStripMenuItemAddDish.Click +=;
            toolStripMenuItemAddType.Click += FormAddType;
            //toolStripMenuItemEditDish.Click +=;
            //toolStripMenuItemRemoveDish.Click +=;
            //toolStripMenuItemRemoveType.Click +=;
            toolStripMenuItemExit.Click += Exit;
        }

        private void FormAuthorization(object sender, EventArgs e)
        {
            
            if (!Application.OpenForms.OfType<Form2>().Any())
            {
                Form2 formAuth = new Form2();
                formAuth.Show();
                //formAuth.BringToFront;
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
        }
        public void AuthorizationSuccessful()
        {
            toolStripMenuItemAuthorization.Visible = false;
            toolStripMenuItemAddDish.Visible = true;
            toolStripMenuItemAddType.Visible = true;
            toolStripMenuItemEditDish.Visible = true;
            toolStripMenuItemRemoveDish.Visible = true;
            toolStripMenuItemRemoveType.Visible = true;
            toolStripMenuItemExit.Visible = true;
            labelAuth.Visible = true;
        }

        public void Exit(object sender, EventArgs e)
        {
            
            
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
            
        }

        private void DishListBox_IndexClick(object sender, EventArgs e)
        {
            var enteredListBox = (ListBox)sender;
            if(enteredListBox.SelectedIndex >= 0)
                DishPresenter.UpdateInformation(enteredListBox, NameDishTextBox, pictureBoxDish, textBoxTimeCooking, textBoxTypeDish, PriceDishTextBox,textBoxDescription);
        }
    }
}
