
namespace ProjectResraurantWinForm
{
    partial class FormAddDish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddDish = new System.Windows.Forms.Button();
            this.textBoxNameDish = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxTypeDish = new System.Windows.Forms.ComboBox();
            this.labelNameDish = new System.Windows.Forms.Label();
            this.labelTypeDish = new System.Windows.Forms.Label();
            this.labelTimeCooking = new System.Windows.Forms.Label();
            this.labelPriceDish = new System.Windows.Forms.Label();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTimeCooking = new System.Windows.Forms.MaskedTextBox();
            this.buttonSelectPicture = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddDish
            // 
            this.buttonAddDish.Location = new System.Drawing.Point(212, 247);
            this.buttonAddDish.Name = "buttonAddDish";
            this.buttonAddDish.Size = new System.Drawing.Size(136, 23);
            this.buttonAddDish.TabIndex = 0;
            this.buttonAddDish.Text = "Добавить блюдо";
            this.buttonAddDish.UseVisualStyleBackColor = true;
            this.buttonAddDish.Click += new System.EventHandler(this.buttonAddDish_Click);
            // 
            // textBoxNameDish
            // 
            this.textBoxNameDish.Location = new System.Drawing.Point(116, 11);
            this.textBoxNameDish.Name = "textBoxNameDish";
            this.textBoxNameDish.Size = new System.Drawing.Size(232, 23);
            this.textBoxNameDish.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 156);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(552, 85);
            this.textBoxDescription.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(354, 11);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(210, 139);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // comboBoxTypeDish
            // 
            this.comboBoxTypeDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDish.FormattingEnabled = true;
            this.comboBoxTypeDish.Location = new System.Drawing.Point(116, 40);
            this.comboBoxTypeDish.Name = "comboBoxTypeDish";
            this.comboBoxTypeDish.Size = new System.Drawing.Size(100, 23);
            this.comboBoxTypeDish.TabIndex = 6;
            // 
            // labelNameDish
            // 
            this.labelNameDish.AutoSize = true;
            this.labelNameDish.Location = new System.Drawing.Point(12, 15);
            this.labelNameDish.Name = "labelNameDish";
            this.labelNameDish.Size = new System.Drawing.Size(101, 15);
            this.labelNameDish.TabIndex = 7;
            this.labelNameDish.Text = "Название блюда:";
            // 
            // labelTypeDish
            // 
            this.labelTypeDish.AutoSize = true;
            this.labelTypeDish.Location = new System.Drawing.Point(44, 43);
            this.labelTypeDish.Name = "labelTypeDish";
            this.labelTypeDish.Size = new System.Drawing.Size(69, 15);
            this.labelTypeDish.TabIndex = 8;
            this.labelTypeDish.Text = "Тип блюда:";
            // 
            // labelTimeCooking
            // 
            this.labelTimeCooking.AutoSize = true;
            this.labelTimeCooking.Location = new System.Drawing.Point(22, 104);
            this.labelTimeCooking.Name = "labelTimeCooking";
            this.labelTimeCooking.Size = new System.Drawing.Size(91, 15);
            this.labelTimeCooking.TabIndex = 9;
            this.labelTimeCooking.Text = "Время готовки:";
            // 
            // labelPriceDish
            // 
            this.labelPriceDish.AutoSize = true;
            this.labelPriceDish.Location = new System.Drawing.Point(36, 73);
            this.labelPriceDish.Name = "labelPriceDish";
            this.labelPriceDish.Size = new System.Drawing.Size(77, 15);
            this.labelPriceDish.TabIndex = 10;
            this.labelPriceDish.Text = "Цена блюда:";
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(116, 70);
            this.maskedTextBoxPrice.Mask = "00000";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.PromptChar = ' ';
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxPrice.TabIndex = 11;
            this.maskedTextBoxPrice.ValidatingType = typeof(int);
            this.maskedTextBoxPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxTimeCooking
            // 
            this.maskedTextBoxTimeCooking.Location = new System.Drawing.Point(116, 100);
            this.maskedTextBoxTimeCooking.Mask = "00000";
            this.maskedTextBoxTimeCooking.Name = "maskedTextBoxTimeCooking";
            this.maskedTextBoxTimeCooking.PromptChar = ' ';
            this.maskedTextBoxTimeCooking.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxTimeCooking.TabIndex = 12;
            this.maskedTextBoxTimeCooking.ValidatingType = typeof(int);
            this.maskedTextBoxTimeCooking.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // buttonSelectPicture
            // 
            this.buttonSelectPicture.Location = new System.Drawing.Point(273, 75);
            this.buttonSelectPicture.Name = "buttonSelectPicture";
            this.buttonSelectPicture.Size = new System.Drawing.Size(75, 48);
            this.buttonSelectPicture.TabIndex = 13;
            this.buttonSelectPicture.Text = "Выбрать картинку";
            this.buttonSelectPicture.UseVisualStyleBackColor = true;
            this.buttonSelectPicture.Click += new System.EventHandler(this.buttonSelectPicture_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(225, 138);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(104, 15);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Описание блюда:";
            // 
            // FormAddDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 277);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonSelectPicture);
            this.Controls.Add(this.maskedTextBoxTimeCooking);
            this.Controls.Add(this.maskedTextBoxPrice);
            this.Controls.Add(this.labelPriceDish);
            this.Controls.Add(this.labelTimeCooking);
            this.Controls.Add(this.labelTypeDish);
            this.Controls.Add(this.labelNameDish);
            this.Controls.Add(this.comboBoxTypeDish);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxNameDish);
            this.Controls.Add(this.buttonAddDish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddDish";
            this.Text = "Добавление блюда";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddDish;
        private System.Windows.Forms.TextBox textBoxNameDish;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBoxTypeDish;
        private System.Windows.Forms.Label labelNameDish;
        private System.Windows.Forms.Label labelTypeDish;
        private System.Windows.Forms.Label labelTimeCooking;
        private System.Windows.Forms.Label labelPriceDish;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTimeCooking;
        private System.Windows.Forms.Button buttonSelectPicture;
        private System.Windows.Forms.Label labelDescription;
    }
}