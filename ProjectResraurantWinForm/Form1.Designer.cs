
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
            this.textBoxTimeCookingEdit = new System.Windows.Forms.TextBox();
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
            this.AddFoodInCartbutton = new System.Windows.Forms.Button();
            this.labelTimeCookingEdit = new System.Windows.Forms.Label();
            this.labelTypeDishEdit = new System.Windows.Forms.Label();
            this.pictureBoxDish = new System.Windows.Forms.PictureBox();
            this.LabelNameFoodEdit = new System.Windows.Forms.Label();
            this.LabelPriceDishEdit = new System.Windows.Forms.Label();
            this.textBoxDescriptionEdit = new System.Windows.Forms.TextBox();
            this.TextBoxNameDishEdit = new System.Windows.Forms.TextBox();
            this.labelNameDishUser = new System.Windows.Forms.Label();
            this.labelPriceDishUser = new System.Windows.Forms.Label();
            this.labelTypeDishUser = new System.Windows.Forms.Label();
            this.labelTimeCookUser = new System.Windows.Forms.Label();
            this.textBoxDescriptionUser = new System.Windows.Forms.TextBox();
            this.buttonSaveDescription = new System.Windows.Forms.Button();
            this.maskedTextBoxPriceDishEdit = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTimeCookEdit = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTypeDishEdit = new System.Windows.Forms.ComboBox();
            this.tabControlMainMenu.SuspendLayout();
            this.Menu.SuspendLayout();
            this.ShoppingCart.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDish)).BeginInit();
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
            this.tabControlMainMenu.Size = new System.Drawing.Size(400, 470);
            this.tabControlMainMenu.TabIndex = 1;
            this.tabControlMainMenu.SelectedIndexChanged += new System.EventHandler(this.tabControlMainMenu_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Menu.Controls.Add(this.textBoxTimeCookingEdit);
            this.Menu.Controls.Add(this.tabControlTypesMenu);
            this.Menu.Location = new System.Drawing.Point(4, 24);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3);
            this.Menu.Size = new System.Drawing.Size(392, 442);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Меню";
            // 
            // textBoxTimeCookingEdit
            // 
            this.textBoxTimeCookingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimeCookingEdit.Location = new System.Drawing.Point(478, 264);
            this.textBoxTimeCookingEdit.Multiline = true;
            this.textBoxTimeCookingEdit.Name = "textBoxTimeCookingEdit";
            this.textBoxTimeCookingEdit.ReadOnly = true;
            this.textBoxTimeCookingEdit.Size = new System.Drawing.Size(168, 23);
            this.textBoxTimeCookingEdit.TabIndex = 10;
            this.textBoxTimeCookingEdit.Visible = false;
            // 
            // tabControlTypesMenu
            // 
            this.tabControlTypesMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTypesMenu.Location = new System.Drawing.Point(3, 3);
            this.tabControlTypesMenu.Name = "tabControlTypesMenu";
            this.tabControlTypesMenu.SelectedIndex = 0;
            this.tabControlTypesMenu.Size = new System.Drawing.Size(386, 436);
            this.tabControlTypesMenu.TabIndex = 1;
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShoppingCart.Controls.Add(this.ShoppingCartListBox);
            this.ShoppingCart.Location = new System.Drawing.Point(4, 24);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Padding = new System.Windows.Forms.Padding(3);
            this.ShoppingCart.Size = new System.Drawing.Size(392, 442);
            this.ShoppingCart.TabIndex = 1;
            this.ShoppingCart.Text = "Корзина";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShoppingCartListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 15;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(3, 3);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(386, 436);
            this.ShoppingCartListBox.TabIndex = 0;
            this.ShoppingCartListBox.SelectedIndexChanged += new System.EventHandler(this.ShoppingCartListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
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
            // AddFoodInCartbutton
            // 
            this.AddFoodInCartbutton.Location = new System.Drawing.Point(703, 250);
            this.AddFoodInCartbutton.Name = "AddFoodInCartbutton";
            this.AddFoodInCartbutton.Size = new System.Drawing.Size(95, 82);
            this.AddFoodInCartbutton.TabIndex = 24;
            this.AddFoodInCartbutton.Text = "Добавить в корзину";
            this.AddFoodInCartbutton.UseVisualStyleBackColor = true;
            this.AddFoodInCartbutton.Visible = false;
            this.AddFoodInCartbutton.Click += new System.EventHandler(this.AddFoodInCartbutton_Click);
            // 
            // labelTimeCookingEdit
            // 
            this.labelTimeCookingEdit.AutoSize = true;
            this.labelTimeCookingEdit.Location = new System.Drawing.Point(431, 312);
            this.labelTimeCookingEdit.Name = "labelTimeCookingEdit";
            this.labelTimeCookingEdit.Size = new System.Drawing.Size(91, 15);
            this.labelTimeCookingEdit.TabIndex = 22;
            this.labelTimeCookingEdit.Text = "Время готовки:";
            this.labelTimeCookingEdit.Visible = false;
            // 
            // labelTypeDishEdit
            // 
            this.labelTypeDishEdit.AutoSize = true;
            this.labelTypeDishEdit.Location = new System.Drawing.Point(451, 283);
            this.labelTypeDishEdit.Name = "labelTypeDishEdit";
            this.labelTypeDishEdit.Size = new System.Drawing.Size(69, 15);
            this.labelTypeDishEdit.TabIndex = 21;
            this.labelTypeDishEdit.Text = "Тип блюда:";
            this.labelTypeDishEdit.Visible = false;
            // 
            // pictureBoxDish
            // 
            this.pictureBoxDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDish.Location = new System.Drawing.Point(455, 116);
            this.pictureBoxDish.Name = "pictureBoxDish";
            this.pictureBoxDish.Size = new System.Drawing.Size(305, 128);
            this.pictureBoxDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDish.TabIndex = 20;
            this.pictureBoxDish.TabStop = false;
            // 
            // LabelNameFoodEdit
            // 
            this.LabelNameFoodEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNameFoodEdit.AutoSize = true;
            this.LabelNameFoodEdit.Location = new System.Drawing.Point(548, 50);
            this.LabelNameFoodEdit.Name = "LabelNameFoodEdit";
            this.LabelNameFoodEdit.Size = new System.Drawing.Size(101, 15);
            this.LabelNameFoodEdit.TabIndex = 19;
            this.LabelNameFoodEdit.Text = "Название блюда:";
            this.LabelNameFoodEdit.Visible = false;
            // 
            // LabelPriceDishEdit
            // 
            this.LabelPriceDishEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPriceDishEdit.AutoSize = true;
            this.LabelPriceDishEdit.Location = new System.Drawing.Point(482, 254);
            this.LabelPriceDishEdit.Name = "LabelPriceDishEdit";
            this.LabelPriceDishEdit.Size = new System.Drawing.Size(38, 15);
            this.LabelPriceDishEdit.TabIndex = 18;
            this.LabelPriceDishEdit.Text = "Цена:";
            this.LabelPriceDishEdit.Visible = false;
            // 
            // textBoxDescriptionEdit
            // 
            this.textBoxDescriptionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescriptionEdit.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescriptionEdit.Location = new System.Drawing.Point(433, 338);
            this.textBoxDescriptionEdit.Multiline = true;
            this.textBoxDescriptionEdit.Name = "textBoxDescriptionEdit";
            this.textBoxDescriptionEdit.Size = new System.Drawing.Size(365, 123);
            this.textBoxDescriptionEdit.TabIndex = 15;
            this.textBoxDescriptionEdit.Visible = false;
            // 
            // TextBoxNameDishEdit
            // 
            this.TextBoxNameDishEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxNameDishEdit.Location = new System.Drawing.Point(455, 72);
            this.TextBoxNameDishEdit.Name = "TextBoxNameDishEdit";
            this.TextBoxNameDishEdit.Size = new System.Drawing.Size(305, 23);
            this.TextBoxNameDishEdit.TabIndex = 14;
            this.TextBoxNameDishEdit.Visible = false;
            this.TextBoxNameDishEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNameDishEdit_KeyPress);
            // 
            // labelNameDishUser
            // 
            this.labelNameDishUser.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameDishUser.Location = new System.Drawing.Point(455, 26);
            this.labelNameDishUser.Name = "labelNameDishUser";
            this.labelNameDishUser.Size = new System.Drawing.Size(305, 87);
            this.labelNameDishUser.TabIndex = 23;
            this.labelNameDishUser.Text = "labelNameDishUser";
            this.labelNameDishUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelNameDishUser.Visible = false;
            // 
            // labelPriceDishUser
            // 
            this.labelPriceDishUser.AutoSize = true;
            this.labelPriceDishUser.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceDishUser.Location = new System.Drawing.Point(490, 247);
            this.labelPriceDishUser.Name = "labelPriceDishUser";
            this.labelPriceDishUser.Size = new System.Drawing.Size(135, 26);
            this.labelPriceDishUser.TabIndex = 26;
            this.labelPriceDishUser.Text = "labelPriceDishUser";
            this.labelPriceDishUser.Visible = false;
            // 
            // labelTypeDishUser
            // 
            this.labelTypeDishUser.AutoSize = true;
            this.labelTypeDishUser.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypeDishUser.Location = new System.Drawing.Point(490, 280);
            this.labelTypeDishUser.Name = "labelTypeDishUser";
            this.labelTypeDishUser.Size = new System.Drawing.Size(129, 26);
            this.labelTypeDishUser.TabIndex = 27;
            this.labelTypeDishUser.Text = "labelTypeDishUser";
            this.labelTypeDishUser.Visible = false;
            // 
            // labelTimeCookUser
            // 
            this.labelTimeCookUser.AutoSize = true;
            this.labelTimeCookUser.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeCookUser.Location = new System.Drawing.Point(490, 309);
            this.labelTimeCookUser.Name = "labelTimeCookUser";
            this.labelTimeCookUser.Size = new System.Drawing.Size(134, 26);
            this.labelTimeCookUser.TabIndex = 28;
            this.labelTimeCookUser.Text = "labelTimeCookUser";
            this.labelTimeCookUser.Visible = false;
            // 
            // textBoxDescriptionUser
            // 
            this.textBoxDescriptionUser.Location = new System.Drawing.Point(431, 338);
            this.textBoxDescriptionUser.Multiline = true;
            this.textBoxDescriptionUser.Name = "textBoxDescriptionUser";
            this.textBoxDescriptionUser.ReadOnly = true;
            this.textBoxDescriptionUser.Size = new System.Drawing.Size(365, 123);
            this.textBoxDescriptionUser.TabIndex = 29;
            this.textBoxDescriptionUser.Visible = false;
            // 
            // buttonSaveDescription
            // 
            this.buttonSaveDescription.Location = new System.Drawing.Point(538, 466);
            this.buttonSaveDescription.Name = "buttonSaveDescription";
            this.buttonSaveDescription.Size = new System.Drawing.Size(146, 23);
            this.buttonSaveDescription.TabIndex = 30;
            this.buttonSaveDescription.Text = "Сохранить описание";
            this.buttonSaveDescription.UseVisualStyleBackColor = true;
            this.buttonSaveDescription.Visible = false;
            this.buttonSaveDescription.Click += new System.EventHandler(this.buttonSaveDescription_Click);
            // 
            // maskedTextBoxPriceDishEdit
            // 
            this.maskedTextBoxPriceDishEdit.Location = new System.Drawing.Point(529, 250);
            this.maskedTextBoxPriceDishEdit.Mask = "00000";
            this.maskedTextBoxPriceDishEdit.Name = "maskedTextBoxPriceDishEdit";
            this.maskedTextBoxPriceDishEdit.PromptChar = ' ';
            this.maskedTextBoxPriceDishEdit.Size = new System.Drawing.Size(168, 23);
            this.maskedTextBoxPriceDishEdit.TabIndex = 31;
            this.maskedTextBoxPriceDishEdit.ValidatingType = typeof(int);
            this.maskedTextBoxPriceDishEdit.Visible = false;
            this.maskedTextBoxPriceDishEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxPriceDishEdit_KeyPress);
            // 
            // maskedTextBoxTimeCookEdit
            // 
            this.maskedTextBoxTimeCookEdit.Location = new System.Drawing.Point(529, 309);
            this.maskedTextBoxTimeCookEdit.Mask = "00000";
            this.maskedTextBoxTimeCookEdit.Name = "maskedTextBoxTimeCookEdit";
            this.maskedTextBoxTimeCookEdit.PromptChar = ' ';
            this.maskedTextBoxTimeCookEdit.Size = new System.Drawing.Size(167, 23);
            this.maskedTextBoxTimeCookEdit.TabIndex = 32;
            this.maskedTextBoxTimeCookEdit.ValidatingType = typeof(int);
            this.maskedTextBoxTimeCookEdit.Visible = false;
            this.maskedTextBoxTimeCookEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxTimeCookEdit_KeyPress);
            // 
            // comboBoxTypeDishEdit
            // 
            this.comboBoxTypeDishEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDishEdit.FormattingEnabled = true;
            this.comboBoxTypeDishEdit.Location = new System.Drawing.Point(529, 280);
            this.comboBoxTypeDishEdit.Name = "comboBoxTypeDishEdit";
            this.comboBoxTypeDishEdit.Size = new System.Drawing.Size(167, 23);
            this.comboBoxTypeDishEdit.TabIndex = 33;
            this.comboBoxTypeDishEdit.Visible = false;
            this.comboBoxTypeDishEdit.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTypeDishEdit_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 495);
            this.Controls.Add(this.comboBoxTypeDishEdit);
            this.Controls.Add(this.maskedTextBoxTimeCookEdit);
            this.Controls.Add(this.maskedTextBoxPriceDishEdit);
            this.Controls.Add(this.buttonSaveDescription);
            this.Controls.Add(this.textBoxDescriptionUser);
            this.Controls.Add(this.labelTimeCookUser);
            this.Controls.Add(this.labelTypeDishUser);
            this.Controls.Add(this.labelPriceDishUser);
            this.Controls.Add(this.AddFoodInCartbutton);
            this.Controls.Add(this.labelTimeCookingEdit);
            this.Controls.Add(this.labelTypeDishEdit);
            this.Controls.Add(this.pictureBoxDish);
            this.Controls.Add(this.LabelNameFoodEdit);
            this.Controls.Add(this.LabelPriceDishEdit);
            this.Controls.Add(this.textBoxDescriptionEdit);
            this.Controls.Add(this.TextBoxNameDishEdit);
            this.Controls.Add(this.labelNameDishUser);
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
            this.ShoppingCart.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMainMenu;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage ShoppingCart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControlTypesMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAuthorization;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddDish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveDish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditDish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.TextBox textBoxTimeCookingEdit;
        public System.Windows.Forms.Button AddFoodInCartbutton;
        public System.Windows.Forms.Label labelTimeCookingEdit;
        public System.Windows.Forms.Label labelTypeDishEdit;
        public System.Windows.Forms.PictureBox pictureBoxDish;
        public System.Windows.Forms.Label LabelNameFoodEdit;
        public System.Windows.Forms.Label LabelPriceDishEdit;
        public System.Windows.Forms.TextBox textBoxDescriptionEdit;
        public System.Windows.Forms.TextBox TextBoxNameDishEdit;
        public System.Windows.Forms.Label labelNameDishUser;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        public System.Windows.Forms.Label labelPriceDishUser;
        public System.Windows.Forms.Label labelTypeDishUser;
        public System.Windows.Forms.Label labelTimeCookUser;
        public System.Windows.Forms.TextBox textBoxDescriptionUser;
        private System.Windows.Forms.Button buttonSaveDescription;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPriceDishEdit;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxTimeCookEdit;
        public System.Windows.Forms.ComboBox comboBoxTypeDishEdit;
    }
}

