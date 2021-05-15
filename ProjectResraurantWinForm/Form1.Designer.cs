
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
            this.DishListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.TabPage();
            this.NameFoodLabel = new System.Windows.Forms.Label();
            this.PriceDishLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PriceDishTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NameDishTextBox = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.AllDishMenu = new System.Windows.Forms.TabPage();
            this.ShoppingCart = new System.Windows.Forms.TabPage();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.AllDishMenu.SuspendLayout();
            this.ShoppingCart.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DishListBox
            // 
            this.DishListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DishListBox.FormattingEnabled = true;
            this.DishListBox.ItemHeight = 20;
            this.DishListBox.Location = new System.Drawing.Point(3, 5);
            this.DishListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DishListBox.Name = "DishListBox";
            this.DishListBox.Size = new System.Drawing.Size(452, 484);
            this.DishListBox.TabIndex = 0;
            this.DishListBox.SelectedIndexChanged += new System.EventHandler(this.DishListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Menu);
            this.tabControl1.Controls.Add(this.ShoppingCart);
            this.tabControl1.Location = new System.Drawing.Point(-1, 35);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 575);
            this.tabControl1.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Menu.Controls.Add(this.NameFoodLabel);
            this.Menu.Controls.Add(this.PriceDishLabel);
            this.Menu.Controls.Add(this.textBox4);
            this.Menu.Controls.Add(this.PriceDishTextBox);
            this.Menu.Controls.Add(this.textBox2);
            this.Menu.Controls.Add(this.NameDishTextBox);
            this.Menu.Controls.Add(this.tabControl2);
            this.Menu.Location = new System.Drawing.Point(4, 29);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu.Size = new System.Drawing.Size(907, 542);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Меню";
            this.Menu.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // NameFoodLabel
            // 
            this.NameFoodLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameFoodLabel.AutoSize = true;
            this.NameFoodLabel.Location = new System.Drawing.Point(467, 39);
            this.NameFoodLabel.Name = "NameFoodLabel";
            this.NameFoodLabel.Size = new System.Drawing.Size(129, 20);
            this.NameFoodLabel.TabIndex = 7;
            this.NameFoodLabel.Text = "Название блюда:";
            this.NameFoodLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PriceDishLabel
            // 
            this.PriceDishLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PriceDishLabel.AutoSize = true;
            this.PriceDishLabel.Location = new System.Drawing.Point(547, 99);
            this.PriceDishLabel.Name = "PriceDishLabel";
            this.PriceDishLabel.Size = new System.Drawing.Size(48, 20);
            this.PriceDishLabel.TabIndex = 6;
            this.PriceDishLabel.Text = "Цена:";
            this.PriceDishLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(599, 156);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(191, 29);
            this.textBox4.TabIndex = 5;
            // 
            // PriceDishTextBox
            // 
            this.PriceDishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceDishTextBox.Location = new System.Drawing.Point(599, 99);
            this.PriceDishTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceDishTextBox.Multiline = true;
            this.PriceDishTextBox.Name = "PriceDishTextBox";
            this.PriceDishTextBox.ReadOnly = true;
            this.PriceDishTextBox.Size = new System.Drawing.Size(153, 29);
            this.PriceDishTextBox.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(480, 327);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(417, 197);
            this.textBox2.TabIndex = 3;
            // 
            // NameDishTextBox
            // 
            this.NameDishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameDishTextBox.Location = new System.Drawing.Point(599, 36);
            this.NameDishTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameDishTextBox.Multiline = true;
            this.NameDishTextBox.Name = "NameDishTextBox";
            this.NameDishTextBox.ReadOnly = true;
            this.NameDishTextBox.Size = new System.Drawing.Size(254, 29);
            this.NameDishTextBox.TabIndex = 2;
            this.NameDishTextBox.TextChanged += new System.EventHandler(this.NameDishTextBox_TextChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.AllDishMenu);
            this.tabControl2.Location = new System.Drawing.Point(3, 4);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(468, 539);
            this.tabControl2.TabIndex = 1;
            // 
            // AllDishMenu
            // 
            this.AllDishMenu.Controls.Add(this.DishListBox);
            this.AllDishMenu.Location = new System.Drawing.Point(4, 29);
            this.AllDishMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllDishMenu.Name = "AllDishMenu";
            this.AllDishMenu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllDishMenu.Size = new System.Drawing.Size(460, 506);
            this.AllDishMenu.TabIndex = 0;
            this.AllDishMenu.Text = "Всё";
            this.AllDishMenu.UseVisualStyleBackColor = true;
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShoppingCart.Controls.Add(this.ShoppingCartListBox);
            this.ShoppingCart.Location = new System.Drawing.Point(4, 29);
            this.ShoppingCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShoppingCart.Size = new System.Drawing.Size(905, 534);
            this.ShoppingCart.TabIndex = 1;
            this.ShoppingCart.Text = "Корзина";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 20;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(11, 21);
            this.ShoppingCartListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(387, 324);
            this.ShoppingCartListBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 21);
            this.toolStripMenuItem1.Text = "Администрирование";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 27);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.AllDishMenu.ResumeLayout(false);
            this.ShoppingCart.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DishListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage ShoppingCart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage AllDishMenu;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox PriceDishTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox NameDishTextBox;
        private System.Windows.Forms.Label NameFoodLabel;
        private System.Windows.Forms.Label PriceDishLabel;
    }
}

