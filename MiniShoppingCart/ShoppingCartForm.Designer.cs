namespace MiniShoppingCart
{
    partial class ShoppingCartForm
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
            this.Header = new System.Windows.Forms.Label();
            this.MoviesInStorelistbox = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.MoviesInCartlistbox = new System.Windows.Forms.ListBox();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.RemoveMovieButton = new System.Windows.Forms.Button();
            this.ProfitHeaderlabel = new System.Windows.Forms.Label();
            this.ProfitNumberlabel = new System.Windows.Forms.Label();
            this.MoneySpendHeaderlabel = new System.Windows.Forms.Label();
            this.MoneySpendNumberlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(149, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(210, 32);
            this.Header.TabIndex = 0;
            this.Header.Text = "Shopping Cart";
            // 
            // MoviesInStorelistbox
            // 
            this.MoviesInStorelistbox.BackColor = System.Drawing.SystemColors.Info;
            this.MoviesInStorelistbox.FormattingEnabled = true;
            this.MoviesInStorelistbox.ItemHeight = 20;
            this.MoviesInStorelistbox.Location = new System.Drawing.Point(80, 44);
            this.MoviesInStorelistbox.Name = "MoviesInStorelistbox";
            this.MoviesInStorelistbox.Size = new System.Drawing.Size(361, 84);
            this.MoviesInStorelistbox.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.BackColor = System.Drawing.Color.DarkGray;
            this.AddToCartButton.Location = new System.Drawing.Point(195, 152);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(132, 55);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add to Cart";
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // MoviesInCartlistbox
            // 
            this.MoviesInCartlistbox.BackColor = System.Drawing.SystemColors.Info;
            this.MoviesInCartlistbox.FormattingEnabled = true;
            this.MoviesInCartlistbox.ItemHeight = 20;
            this.MoviesInCartlistbox.Location = new System.Drawing.Point(80, 231);
            this.MoviesInCartlistbox.Name = "MoviesInCartlistbox";
            this.MoviesInCartlistbox.Size = new System.Drawing.Size(361, 84);
            this.MoviesInCartlistbox.TabIndex = 3;
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.BackColor = System.Drawing.Color.DarkGray;
            this.PurchaseButton.Location = new System.Drawing.Point(309, 350);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(132, 55);
            this.PurchaseButton.TabIndex = 4;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = false;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // RemoveMovieButton
            // 
            this.RemoveMovieButton.BackColor = System.Drawing.Color.DarkGray;
            this.RemoveMovieButton.Location = new System.Drawing.Point(80, 350);
            this.RemoveMovieButton.Name = "RemoveMovieButton";
            this.RemoveMovieButton.Size = new System.Drawing.Size(132, 55);
            this.RemoveMovieButton.TabIndex = 5;
            this.RemoveMovieButton.Text = "Remove Movie";
            this.RemoveMovieButton.UseVisualStyleBackColor = false;
            this.RemoveMovieButton.Click += new System.EventHandler(this.RemoveMovieButton_Click);
            // 
            // ProfitHeaderlabel
            // 
            this.ProfitHeaderlabel.AutoSize = true;
            this.ProfitHeaderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfitHeaderlabel.Location = new System.Drawing.Point(525, 26);
            this.ProfitHeaderlabel.Name = "ProfitHeaderlabel";
            this.ProfitHeaderlabel.Size = new System.Drawing.Size(189, 37);
            this.ProfitHeaderlabel.TabIndex = 6;
            this.ProfitHeaderlabel.Text = "Store Profit";
            // 
            // ProfitNumberlabel
            // 
            this.ProfitNumberlabel.AutoSize = true;
            this.ProfitNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfitNumberlabel.Location = new System.Drawing.Point(570, 81);
            this.ProfitNumberlabel.Name = "ProfitNumberlabel";
            this.ProfitNumberlabel.Size = new System.Drawing.Size(92, 32);
            this.ProfitNumberlabel.TabIndex = 6;
            this.ProfitNumberlabel.Text = "$0.00";
            // 
            // MoneySpendHeaderlabel
            // 
            this.MoneySpendHeaderlabel.AutoSize = true;
            this.MoneySpendHeaderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneySpendHeaderlabel.Location = new System.Drawing.Point(479, 231);
            this.MoneySpendHeaderlabel.Name = "MoneySpendHeaderlabel";
            this.MoneySpendHeaderlabel.Size = new System.Drawing.Size(278, 32);
            this.MoneySpendHeaderlabel.TabIndex = 8;
            this.MoneySpendHeaderlabel.Text = "Total Money Spend";
            // 
            // MoneySpendNumberlabel
            // 
            this.MoneySpendNumberlabel.AutoSize = true;
            this.MoneySpendNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneySpendNumberlabel.Location = new System.Drawing.Point(579, 283);
            this.MoneySpendNumberlabel.Name = "MoneySpendNumberlabel";
            this.MoneySpendNumberlabel.Size = new System.Drawing.Size(92, 32);
            this.MoneySpendNumberlabel.TabIndex = 9;
            this.MoneySpendNumberlabel.Text = "$0.00";
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.MoneySpendNumberlabel);
            this.Controls.Add(this.MoneySpendHeaderlabel);
            this.Controls.Add(this.ProfitNumberlabel);
            this.Controls.Add(this.ProfitHeaderlabel);
            this.Controls.Add(this.RemoveMovieButton);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.MoviesInCartlistbox);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.MoviesInStorelistbox);
            this.Controls.Add(this.Header);
            this.Name = "ShoppingCartForm";
            this.Text = "Shopping Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.ListBox MoviesInStorelistbox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ListBox MoviesInCartlistbox;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Button RemoveMovieButton;
        private System.Windows.Forms.Label ProfitHeaderlabel;
        private System.Windows.Forms.Label ProfitNumberlabel;
        private System.Windows.Forms.Label MoneySpendHeaderlabel;
        private System.Windows.Forms.Label MoneySpendNumberlabel;
    }
}

