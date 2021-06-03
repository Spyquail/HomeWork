using System;
using System.Windows.Forms;

namespace ProjectResraurantWinForm
{
    public partial class FormAddType : Form
    {
        public FormAddType()
        {
            InitializeComponent();
            textBoxAddType.KeyDown += FormAddType_KeyDown;
        }
        private void buttonAddType_Click(object sender, EventArgs e)
        {
            DishPresenter.AddType(textBoxAddType.Text);
        }
        private void FormAddType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonAddType_Click(sender, e);
        }
    }
}
