﻿namespace CocktailApp
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
            this.AvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchByNameRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchByIngredientRadioButton = new System.Windows.Forms.RadioButton();
            this.IngredientsTextBox = new System.Windows.Forms.TextBox();
            this.RecipeTextBox = new System.Windows.Forms.TextBox();
            this.CocktailNameLabel = new System.Windows.Forms.Label();
            this.FavouritePictureBox = new System.Windows.Forms.PictureBox();
            this.CocktailImageBox = new System.Windows.Forms.PictureBox();
            this.FavouriteCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.FavouritePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CocktailImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ExitButton.Location = new System.Drawing.Point(827, 22);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 60);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SandyBrown;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.BackButton.FlatAppearance.BorderSize = 2;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackButton.Location = new System.Drawing.Point(27, 22);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 60);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(327, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 75);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cocktails";
            // 
            // CocktailsListBox
            // 
            this.CocktailsListBox.BackColor = System.Drawing.Color.SeaShell;
            this.CocktailsListBox.DisplayMember = "InfoAvailable";
            this.CocktailsListBox.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocktailsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CocktailsListBox.FormattingEnabled = true;
            this.CocktailsListBox.HorizontalScrollbar = true;
            this.CocktailsListBox.ItemHeight = 24;
            this.CocktailsListBox.Location = new System.Drawing.Point(27, 294);
            this.CocktailsListBox.Name = "CocktailsListBox";
            this.CocktailsListBox.Size = new System.Drawing.Size(380, 388);
            this.CocktailsListBox.TabIndex = 6;
            this.CocktailsListBox.ValueMember = "Id";
            this.CocktailsListBox.SelectedIndexChanged += new System.EventHandler(this.CocktailsListBox_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.SandyBrown;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.SearchButton.FlatAppearance.BorderSize = 2;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SearchButton.Location = new System.Drawing.Point(287, 176);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(120, 32);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.SeaShell;
            this.SearchBar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SearchBar.Location = new System.Drawing.Point(27, 177);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(240, 30);
            this.SearchBar.TabIndex = 1;
            // 
            // AvailableCheckBox
            // 
            this.AvailableCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableCheckBox.Location = new System.Drawing.Point(237, 219);
            this.AvailableCheckBox.Name = "AvailableCheckBox";
            this.AvailableCheckBox.Size = new System.Drawing.Size(163, 22);
            this.AvailableCheckBox.TabIndex = 5;
            this.AvailableCheckBox.Text = "Show only available";
            this.AvailableCheckBox.UseVisualStyleBackColor = true;
            this.AvailableCheckBox.CheckedChanged += new System.EventHandler(this.ShowOnlyAvailableCheckBox_CheckedChanged);
            // 
            // SearchByNameRadioButton
            // 
            this.SearchByNameRadioButton.AutoSize = true;
            this.SearchByNameRadioButton.Checked = true;
            this.SearchByNameRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByNameRadioButton.Location = new System.Drawing.Point(37, 218);
            this.SearchByNameRadioButton.Name = "SearchByNameRadioButton";
            this.SearchByNameRadioButton.Size = new System.Drawing.Size(139, 22);
            this.SearchByNameRadioButton.TabIndex = 3;
            this.SearchByNameRadioButton.TabStop = true;
            this.SearchByNameRadioButton.Text = "Search by name";
            this.SearchByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByIngredientRadioButton
            // 
            this.SearchByIngredientRadioButton.AutoSize = true;
            this.SearchByIngredientRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.SearchByIngredientRadioButton.Location = new System.Drawing.Point(37, 246);
            this.SearchByIngredientRadioButton.Name = "SearchByIngredientRadioButton";
            this.SearchByIngredientRadioButton.Size = new System.Drawing.Size(169, 22);
            this.SearchByIngredientRadioButton.TabIndex = 4;
            this.SearchByIngredientRadioButton.TabStop = true;
            this.SearchByIngredientRadioButton.Text = "Search by ingredient";
            this.SearchByIngredientRadioButton.UseVisualStyleBackColor = true;
            // 
            // IngredientsTextBox
            // 
            this.IngredientsTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.IngredientsTextBox.Font = new System.Drawing.Font("Arial", 15F);
            this.IngredientsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.IngredientsTextBox.Location = new System.Drawing.Point(427, 232);
            this.IngredientsTextBox.Multiline = true;
            this.IngredientsTextBox.Name = "IngredientsTextBox";
            this.IngredientsTextBox.ReadOnly = true;
            this.IngredientsTextBox.Size = new System.Drawing.Size(240, 240);
            this.IngredientsTextBox.TabIndex = 14;
            this.IngredientsTextBox.TabStop = false;
            // 
            // RecipeTextBox
            // 
            this.RecipeTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.RecipeTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RecipeTextBox.Location = new System.Drawing.Point(427, 492);
            this.RecipeTextBox.Multiline = true;
            this.RecipeTextBox.Name = "RecipeTextBox";
            this.RecipeTextBox.ReadOnly = true;
            this.RecipeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecipeTextBox.Size = new System.Drawing.Size(500, 190);
            this.RecipeTextBox.TabIndex = 15;
            this.RecipeTextBox.TabStop = false;
            // 
            // CocktailNameLabel
            // 
            this.CocktailNameLabel.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.CocktailNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CocktailNameLabel.Location = new System.Drawing.Point(427, 172);
            this.CocktailNameLabel.Name = "CocktailNameLabel";
            this.CocktailNameLabel.Size = new System.Drawing.Size(461, 40);
            this.CocktailNameLabel.TabIndex = 17;
            this.CocktailNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FavouritePictureBox
            // 
            this.FavouritePictureBox.Image = global::CocktailApp.Properties.Resources.empty_star;
            this.FavouritePictureBox.InitialImage = global::CocktailApp.Properties.Resources.empty_star;
            this.FavouritePictureBox.Location = new System.Drawing.Point(887, 172);
            this.FavouritePictureBox.Name = "FavouritePictureBox";
            this.FavouritePictureBox.Size = new System.Drawing.Size(40, 40);
            this.FavouritePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FavouritePictureBox.TabIndex = 23;
            this.FavouritePictureBox.TabStop = false;
            this.FavouritePictureBox.Click += new System.EventHandler(this.FavouritePictureBox_Click);
            // 
            // CocktailImageBox
            // 
            this.CocktailImageBox.Image = global::CocktailApp.Properties.Resources.placeholder_image;
            this.CocktailImageBox.InitialImage = global::CocktailApp.Properties.Resources.placeholder_image;
            this.CocktailImageBox.Location = new System.Drawing.Point(687, 232);
            this.CocktailImageBox.Name = "CocktailImageBox";
            this.CocktailImageBox.Size = new System.Drawing.Size(240, 240);
            this.CocktailImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CocktailImageBox.TabIndex = 16;
            this.CocktailImageBox.TabStop = false;
            // 
            // FavouriteCheckBox
            // 
            this.FavouriteCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavouriteCheckBox.Location = new System.Drawing.Point(237, 247);
            this.FavouriteCheckBox.Name = "FavouriteCheckBox";
            this.FavouriteCheckBox.Size = new System.Drawing.Size(170, 22);
            this.FavouriteCheckBox.TabIndex = 24;
            this.FavouriteCheckBox.Text = "Show only favourites";
            this.FavouriteCheckBox.UseVisualStyleBackColor = true;
            this.FavouriteCheckBox.CheckedChanged += new System.EventHandler(this.FavouriteCheckBox_CheckedChanged);
            // 
            // Cocktails
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.ControlBox = false;
            this.Controls.Add(this.FavouriteCheckBox);
            this.Controls.Add(this.FavouritePictureBox);
            this.Controls.Add(this.CocktailNameLabel);
            this.Controls.Add(this.CocktailImageBox);
            this.Controls.Add(this.RecipeTextBox);
            this.Controls.Add(this.IngredientsTextBox);
            this.Controls.Add(this.SearchByIngredientRadioButton);
            this.Controls.Add(this.SearchByNameRadioButton);
            this.Controls.Add(this.AvailableCheckBox);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CocktailsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "Cocktails";
            ((System.ComponentModel.ISupportInitialize)(this.FavouritePictureBox)).EndInit();
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
        private System.Windows.Forms.CheckBox AvailableCheckBox;
        private System.Windows.Forms.RadioButton SearchByNameRadioButton;
        private System.Windows.Forms.RadioButton SearchByIngredientRadioButton;
        private System.Windows.Forms.TextBox IngredientsTextBox;
        private System.Windows.Forms.TextBox RecipeTextBox;
        private System.Windows.Forms.PictureBox CocktailImageBox;
        private System.Windows.Forms.Label CocktailNameLabel;
        private System.Windows.Forms.PictureBox FavouritePictureBox;
        private System.Windows.Forms.CheckBox FavouriteCheckBox;
    }
}