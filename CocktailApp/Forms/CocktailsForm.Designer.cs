namespace CocktailApp
{
    partial class Cocktails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cocktails));
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CocktailsListBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.ShowOnlyAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchByNameRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchByIngredientRadioButton = new System.Windows.Forms.RadioButton();
            this.IngredientsTextBox = new System.Windows.Forms.TextBox();
            this.RecipeTextBox = new System.Windows.Forms.TextBox();
            this.CocktailImageBox = new System.Windows.Forms.PictureBox();
            this.CocktailNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CocktailImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(685, 20);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 60);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Arial", 15.75F);
            this.BackButton.Location = new System.Drawing.Point(20, 20);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 60);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cocktails";
            // 
            // CocktailsListBox
            // 
            this.CocktailsListBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocktailsListBox.FormattingEnabled = true;
            this.CocktailsListBox.HorizontalScrollbar = true;
            this.CocktailsListBox.ItemHeight = 20;
            this.CocktailsListBox.Location = new System.Drawing.Point(20, 241);
            this.CocktailsListBox.Name = "CocktailsListBox";
            this.CocktailsListBox.Size = new System.Drawing.Size(320, 304);
            this.CocktailsListBox.TabIndex = 12;
            this.CocktailsListBox.SelectedIndexChanged += new System.EventHandler(this.CocktailsListBox_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(240, 154);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 28);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(20, 155);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(200, 26);
            this.SearchBar.TabIndex = 1;
            // 
            // ShowOnlyAvailableCheckBox
            // 
            this.ShowOnlyAvailableCheckBox.AutoSize = true;
            this.ShowOnlyAvailableCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ShowOnlyAvailableCheckBox.Location = new System.Drawing.Point(200, 201);
            this.ShowOnlyAvailableCheckBox.Name = "ShowOnlyAvailableCheckBox";
            this.ShowOnlyAvailableCheckBox.Size = new System.Drawing.Size(140, 20);
            this.ShowOnlyAvailableCheckBox.TabIndex = 5;
            this.ShowOnlyAvailableCheckBox.Text = "Show only available";
            this.ShowOnlyAvailableCheckBox.UseVisualStyleBackColor = true;
            this.ShowOnlyAvailableCheckBox.CheckedChanged += new System.EventHandler(this.ShowOnlyAvailableCheckBox_CheckedChanged);
            // 
            // SearchByNameRadioButton
            // 
            this.SearchByNameRadioButton.AutoSize = true;
            this.SearchByNameRadioButton.Checked = true;
            this.SearchByNameRadioButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.SearchByNameRadioButton.Location = new System.Drawing.Point(20, 188);
            this.SearchByNameRadioButton.Name = "SearchByNameRadioButton";
            this.SearchByNameRadioButton.Size = new System.Drawing.Size(123, 20);
            this.SearchByNameRadioButton.TabIndex = 3;
            this.SearchByNameRadioButton.TabStop = true;
            this.SearchByNameRadioButton.Text = "Search by Name";
            this.SearchByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByIngredientRadioButton
            // 
            this.SearchByIngredientRadioButton.AutoSize = true;
            this.SearchByIngredientRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByIngredientRadioButton.Location = new System.Drawing.Point(20, 214);
            this.SearchByIngredientRadioButton.Name = "SearchByIngredientRadioButton";
            this.SearchByIngredientRadioButton.Size = new System.Drawing.Size(145, 20);
            this.SearchByIngredientRadioButton.TabIndex = 4;
            this.SearchByIngredientRadioButton.TabStop = true;
            this.SearchByIngredientRadioButton.Text = "Search by Ingredient";
            this.SearchByIngredientRadioButton.UseVisualStyleBackColor = true;
            // 
            // IngredientsTextBox
            // 
            this.IngredientsTextBox.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsTextBox.Location = new System.Drawing.Point(365, 200);
            this.IngredientsTextBox.Multiline = true;
            this.IngredientsTextBox.Name = "IngredientsTextBox";
            this.IngredientsTextBox.ReadOnly = true;
            this.IngredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IngredientsTextBox.Size = new System.Drawing.Size(225, 160);
            this.IngredientsTextBox.TabIndex = 14;
            // 
            // RecipeTextBox
            // 
            this.RecipeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeTextBox.Location = new System.Drawing.Point(365, 375);
            this.RecipeTextBox.Multiline = true;
            this.RecipeTextBox.Name = "RecipeTextBox";
            this.RecipeTextBox.ReadOnly = true;
            this.RecipeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecipeTextBox.Size = new System.Drawing.Size(400, 170);
            this.RecipeTextBox.TabIndex = 15;
            // 
            // CocktailImageBox
            // 
            this.CocktailImageBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("CocktailImageBox.InitialImage")));
            this.CocktailImageBox.Location = new System.Drawing.Point(605, 200);
            this.CocktailImageBox.Name = "CocktailImageBox";
            this.CocktailImageBox.Size = new System.Drawing.Size(160, 160);
            this.CocktailImageBox.TabIndex = 16;
            this.CocktailImageBox.TabStop = false;
            // 
            // CocktailNameLabel
            // 
            this.CocktailNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocktailNameLabel.Location = new System.Drawing.Point(365, 155);
            this.CocktailNameLabel.Name = "CocktailNameLabel";
            this.CocktailNameLabel.Size = new System.Drawing.Size(400, 30);
            this.CocktailNameLabel.TabIndex = 17;
            this.CocktailNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cocktails
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.CocktailNameLabel);
            this.Controls.Add(this.CocktailImageBox);
            this.Controls.Add(this.RecipeTextBox);
            this.Controls.Add(this.IngredientsTextBox);
            this.Controls.Add(this.SearchByIngredientRadioButton);
            this.Controls.Add(this.SearchByNameRadioButton);
            this.Controls.Add(this.ShowOnlyAvailableCheckBox);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CocktailsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Cocktails";
            this.Text = "ShowCocktails";
            ((System.ComponentModel.ISupportInitialize)(this.CocktailImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CocktailsListBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.CheckBox ShowOnlyAvailableCheckBox;
        private System.Windows.Forms.RadioButton SearchByNameRadioButton;
        private System.Windows.Forms.RadioButton SearchByIngredientRadioButton;
        private System.Windows.Forms.TextBox IngredientsTextBox;
        private System.Windows.Forms.TextBox RecipeTextBox;
        private System.Windows.Forms.PictureBox CocktailImageBox;
        private System.Windows.Forms.Label CocktailNameLabel;
    }
}