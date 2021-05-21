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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBoxLogin.KeyDown += Form2_KeyDown;
            textBoxPassword.KeyDown += Form2_KeyDown;
        }

        private void buttonAutharization_Click(object sender, EventArgs e)
        {
            DishPresenter.Autharization(textBoxLogin, textBoxPassword );
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonAutharization_Click(sender, e);
        }
    }
}
