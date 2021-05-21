
namespace ProjectResraurantWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMainMenu = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.TabPage();
            this.labelTimeCooking = new System.Windows.Forms.Label();
            this.textBoxTimeCooking = new System.Windows.Forms.TextBox();
            this.labelTypeDish = new System.Windows.Forms.Label();
            this.pictureBoxDish = new System.Windows.Forms.PictureBox();
            this.NameFoodLabel = new System.Windows.Forms.Label();
            this.PriceDishLabel = new System.Windows.Forms.Label();
            this.textBoxTypeDish = new System.Windows.Forms.TextBox();
            this.PriceDishTextBox = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.NameDishTextBox = new System.Windows.Forms.TextBox();
            this.tabControlTypesMenu = new System.Windows.Forms.TabControl();
            this.ShoppingCart = new System.Windows.Forms.TabPage();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAuthorization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddDish = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveDish = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditDish = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAuth = new System.Windows.Forms.Label();
            this.tabControlMainMenu.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDish)).BeginInit();
            this.ShoppingCart.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainMenu
            // 
            this.tabControlMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMainMenu.Controls.Add(this.Menu);
            this.tabControlMainMenu.Controls.Add(this.ShoppingCart);
            this.tabControlMainMenu.Location = new System.Drawing.Point(-1, 26);
            this.tabControlMainMenu.Name = "tabControlMainMenu";
            this.tabControlMainMenu.SelectedIndex = 0;
            this.tabControlMainMenu.Size = new System.Drawing.Size(802, 437);
            this.tabControlMainMenu.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Menu.Controls.Add(this.labelTimeCooking);
            this.Menu.Controls.Add(this.textBoxTimeCooking);
            this.Menu.Controls.Add(this.labelTypeDish);
            this.Menu.Controls.Add(this.pictureBoxDish);
            this.Menu.Controls.Add(this.NameFoodLabel);
            this.Menu.Controls.Add(this.PriceDishLabel);
            this.Menu.Controls.Add(this.textBoxTypeDish);
            this.Menu.Controls.Add(this.PriceDishTextBox);
            this.Menu.Controls.Add(this.textBoxDescription);
            this.Menu.Controls.Add(this.NameDishTextBox);
            this.Menu.Controls.Add(this.tabControlTypesMenu);
            this.Menu.Location = new System.Drawing.Point(4, 24);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3);
            this.Menu.Size = new System.Drawing.Size(794, 409);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Меню";
            // 
            // labelTimeCooking
            // 
            this.labelTimeCooking.AutoSize = true;
            this.labelTimeCooking.Location = new System.Drawing.Point(420, 252);
            this.labelTimeCooking.Name = "labelTimeCooking";
            this.labelTimeCooking.Size = new System.Drawing.Size(91, 15);
            this.labelTimeCooking.TabIndex = 11;
            this.labelTimeCooking.Text = "Время готовки:";
            // 
            // textBoxTimeCooking
            // 
            this.textBoxTimeCooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimeCooking.Location = new System.Drawing.Point(517, 249);
            this.textBoxTimeCooking.Multiline = true;
            this.textBoxTimeCooking.Name = "textBoxTimeCooking";
            this.textBoxTimeCooking.ReadOnly = true;
            this.textBoxTimeCooking.Size = new System.Drawing.Size(168, 23);
            this.textBoxTimeCooking.TabIndex = 10;
            // 
            // labelTypeDish
            // 
            this.labelTypeDish.AutoSize = true;
            this.labelTypeDish.Location = new System.Drawing.Point(442, 223);
            this.labelTypeDish.Name = "labelTypeDish";
            this.labelTypeDish.Size = new System.Drawing.Size(69, 15);
            this.labelTypeDish.TabIndex = 9;
            this.labelTypeDish.Text = "Тип блюда:";
            // 
            // pictureBoxDish
            // 
            this.pictureBoxDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDish.Location = new System.Drawing.Point(444, 56);
            this.pictureBoxDish.Name = "pictureBoxDish";
            this.pictureBoxDish.Size = new System.Drawing.Size(305, 128);
            this.pictureBoxDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDish.TabIndex = 8;
            this.pictureBoxDish.TabStop = false;
            // 
            // NameFoodLabel
            // 
            this.NameFoodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameFoodLabel.AutoSize = true;
            this.NameFoodLabel.Location = new System.Drawing.Point(419, 31);
            this.NameFoodLabel.Name = "NameFoodLabel";
            this.NameFoodLabel.Size = new System.Drawing.Size(101, 15);
            this.NameFoodLabel.TabIndex = 7;
            this.NameFoodLabel.Text = "Название блюда:";
            // 
            // PriceDishLabel
            // 
            this.PriceDishLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceDishLabel.AutoSize = true;
            this.PriceDishLabel.Location = new System.Drawing.Point(471, 194);
            this.PriceDishLabel.Name = "PriceDishLabel";
            this.PriceDishLabel.Size = new System.Drawing.Size(38, 15);
            this.PriceDishLabel.TabIndex = 6;
            this.PriceDishLabel.Text = "Цена:";
            // 
            // textBoxTypeDish
            // 
            this.textBoxTypeDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTypeDish.Location = new System.Drawing.Point(517, 220);
            this.textBoxTypeDish.Multiline = true;
            this.textBoxTypeDish.Name = "textBoxTypeDish";
            this.textBoxTypeDish.ReadOnly = true;
            this.textBoxTypeDish.Size = new System.Drawing.Size(168, 23);
            this.textBoxTypeDish.TabIndex = 5;
            // 
            // PriceDishTextBox
            // 
            this.PriceDishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceDishTextBox.Location = new System.Drawing.Point(517, 191);
            this.PriceDishTextBox.Multiline = true;
            this.PriceDishTextBox.Name = "PriceDishTextBox";
            this.PriceDishTextBox.ReadOnly = true;
            this.PriceDishTextBox.Size = new System.Drawing.Size(168, 23);
            this.PriceDishTextBox.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(422, 277);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(365, 123);
            this.textBoxDescription.TabIndex = 3;
            // 
            // NameDishTextBox
            // 
            this.NameDishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameDishTextBox.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameDishTextBox.Location = new System.Drawing.Point(526, 27);
            this.NameDishTextBox.Multiline = true;
            this.NameDishTextBox.Name = "NameDishTextBox";
            this.NameDishTextBox.ReadOnly = true;
            this.NameDishTextBox.Size = new System.Drawing.Size(223, 23);
            this.NameDishTextBox.TabIndex = 2;
            // 
            // tabControlTypesMenu
            // 
            this.tabControlTypesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlTypesMenu.Location = new System.Drawing.Point(3, 3);
            this.tabControlTypesMenu.Name = "tabControlTypesMenu";
            this.tabControlTypesMenu.SelectedIndex = 0;
            this.tabControlTypesMenu.Size = new System.Drawing.Size(411, 410);
            this.tabControlTypesMenu.TabIndex = 1;
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShoppingCart.Controls.Add(this.ShoppingCartListBox);
            this.ShoppingCart.Location = new System.Drawing.Point(4, 24);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Padding = new System.Windows.Forms.Padding(3);
            this.ShoppingCart.Size = new System.Drawing.Size(794, 409);
            this.ShoppingCart.TabIndex = 1;
            this.ShoppingCart.Text = "Корзина";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 15;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(10, 16);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(339, 244);
            this.ShoppingCartListBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAuthorization,
            this.toolStripMenuItemAddDish,
            this.toolStripMenuItemRemoveDish,
            this.toolStripMenuItemEditDish,
            this.toolStripMenuItemAddType,
            this.toolStripMenuItemRemoveType,
            this.toolStripMenuItemExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 20);
            this.toolStripMenuItem1.Text = "Администрирование";
            // 
            // toolStripMenuItemAuthorization
            // 
            this.toolStripMenuItemAuthorization.Name = "toolStripMenuItemAuthorization";
            this.toolStripMenuItemAuthorization.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemAuthorization.Text = "Авторизация";
            // 
            // toolStripMenuItemAddDish
            // 
            this.toolStripMenuItemAddDish.Name = "toolStripMenuItemAddDish";
            this.toolStripMenuItemAddDish.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemAddDish.Text = "Добавить блюдо";
            this.toolStripMenuItemAddDish.Visible = false;
            // 
            // toolStripMenuItemRemoveDish
            // 
            this.toolStripMenuItemRemoveDish.Name = "toolStripMenuItemRemoveDish";
            this.toolStripMenuItemRemoveDish.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemRemoveDish.Text = "Удалить блюдо";
            this.toolStripMenuItemRemoveDish.Visible = false;
            // 
            // toolStripMenuItemEditDish
            // 
            this.toolStripMenuItemEditDish.Name = "toolStripMenuItemEditDish";
            this.toolStripMenuItemEditDish.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemEditDish.Text = "Редактирование блюда";
            this.toolStripMenuItemEditDish.Visible = false;
            // 
            // toolStripMenuItemAddType
            // 
            this.toolStripMenuItemAddType.Name = "toolStripMenuItemAddType";
            this.toolStripMenuItemAddType.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemAddType.Text = "Добавить тип блюда";
            this.toolStripMenuItemAddType.Visible = false;
            // 
            // toolStripMenuItemRemoveType
            // 
            this.toolStripMenuItemRemoveType.Name = "toolStripMenuItemRemoveType";
            this.toolStripMenuItemRemoveType.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemRemoveType.Text = "Удалить тип блюда";
            this.toolStripMenuItemRemoveType.Visible = false;
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemExit.Text = "Выйти";
            this.toolStripMenuItemExit.Visible = false;
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.ForeColor = System.Drawing.Color.Red;
            this.labelAuth.Location = new System.Drawing.Point(576, 9);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(226, 15);
            this.labelAuth.TabIndex = 3;
            this.labelAuth.Text = "АВТОРИЗОВАН КАК АДМИНИСТРАТОР";
            this.labelAuth.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 462);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.tabControlMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ресторан";
            this.tabControlMainMenu.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDish)).EndInit();
            this.ShoppingCart.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMainMenu;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage ShoppingCart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.TabControl tabControlTypesMenu;
        private System.Windows.Forms.TextBox textBoxTypeDish;
        private System.Windows.Forms.TextBox PriceDishTextBox;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox NameDishTextBox;
        private System.Windows.Forms.Label NameFoodLabel;
        private System.Windows.Forms.Label PriceDishLabel;
        private System.Windows.Forms.PictureBox pictureBoxDish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAuthorization;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddDish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveDish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditDish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label labelTypeDish;
        private System.Windows.Forms.Label labelTimeCooking;
        private System.Windows.Forms.TextBox textBoxTimeCooking;
    }
}

