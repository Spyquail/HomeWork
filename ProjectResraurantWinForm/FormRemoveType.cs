using System;
using System.Windows.Forms;

namespace ProjectResraurantWinForm
{
    public partial class FormRemoveType : Form
    {
        string removedType;
        public FormRemoveType()
        {
            InitializeComponent();
            listBoxTypes.SelectedIndexChanged += listBoxTypes_SelectedIndexChanged;
            Initialize();
        }
        private void Initialize()
        {
            listBoxTypes.Items.Clear();
            foreach (var type in DishPresenter.GetAllType())
                listBoxTypes.Items.Add(type);
        }
        private void listBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemoveType.Visible = true;
            var enteredListBox = (ListBox)sender;
            if(enteredListBox.SelectedIndex != -1)
                removedType = enteredListBox.SelectedItem.ToString();
        }
        private void buttonRemoveType_Click(object sender, EventArgs e)
        {
            DishPresenter.RemoveType(removedType);
            listBoxTypes.ClearSelected();
            buttonRemoveType.Visible = false;
            Initialize();
        }
    }
}
