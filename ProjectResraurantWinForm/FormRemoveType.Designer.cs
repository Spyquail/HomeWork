
namespace ProjectResraurantWinForm
{
    partial class FormRemoveType
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
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.buttonRemoveType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.ItemHeight = 15;
            this.listBoxTypes.Location = new System.Drawing.Point(13, 13);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.Size = new System.Drawing.Size(224, 259);
            this.listBoxTypes.TabIndex = 0;
            this.listBoxTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxTypes_SelectedIndexChanged);
            // 
            // buttonRemoveType
            // 
            this.buttonRemoveType.Location = new System.Drawing.Point(244, 13);
            this.buttonRemoveType.Name = "buttonRemoveType";
            this.buttonRemoveType.Size = new System.Drawing.Size(122, 21);
            this.buttonRemoveType.TabIndex = 1;
            this.buttonRemoveType.Text = "Удалить тип";
            this.buttonRemoveType.UseVisualStyleBackColor = true;
            this.buttonRemoveType.Visible = false;
            this.buttonRemoveType.Click += new System.EventHandler(this.buttonRemoveType_Click);
            // 
            // FormRemoveType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 285);
            this.Controls.Add(this.buttonRemoveType);
            this.Controls.Add(this.listBoxTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRemoveType";
            this.Text = "Удалить тип";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTypes;
        private System.Windows.Forms.Button buttonRemoveType;
    }
}