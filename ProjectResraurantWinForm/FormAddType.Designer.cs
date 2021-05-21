
namespace ProjectResraurantWinForm
{
    partial class FormAddType
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
            this.textBoxAddType = new System.Windows.Forms.TextBox();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.labelAddType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAddType
            // 
            this.textBoxAddType.Location = new System.Drawing.Point(12, 27);
            this.textBoxAddType.Name = "textBoxAddType";
            this.textBoxAddType.Size = new System.Drawing.Size(211, 23);
            this.textBoxAddType.TabIndex = 0;
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(75, 56);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(75, 23);
            this.buttonAddType.TabIndex = 1;
            this.buttonAddType.Text = "Добавить";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // labelAddType
            // 
            this.labelAddType.AutoSize = true;
            this.labelAddType.Location = new System.Drawing.Point(12, 9);
            this.labelAddType.Name = "labelAddType";
            this.labelAddType.Size = new System.Drawing.Size(212, 15);
            this.labelAddType.TabIndex = 2;
            this.labelAddType.Text = "Введите название нового типа блюда";
            // 
            // FormAddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 86);
            this.Controls.Add(this.labelAddType);
            this.Controls.Add(this.buttonAddType);
            this.Controls.Add(this.textBoxAddType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddType;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.Label labelAddType;
    }
}