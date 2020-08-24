namespace CocktailApp
{
    partial class EditCocktails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCocktails));
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchByIngredientRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchByNameRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CocktailsListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IngredientTagListBox = new System.Windows.Forms.ListBox();
            this.IngredientTagsComboBox = new System.Windows.Forms.ComboBox();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.RemoveIngredientButton = new System.Windows.Forms.Button();
            this.FullIngredientInfoTextBox = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.UploadedFileLabel = new System.Windows.Forms.Label();
            this.RecipeTextBox = new System.Windows.Forms.TextBox();
            this.AddCocktailButton = new System.Windows.Forms.Button();
            this.EditCocktailButton = new System.Windows.Forms.Button();
            this.RemoveCocktailButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IngredientTagsBox = new System.Windows.Forms.GroupBox();
            this.FullIngredientInfoBox = new System.Windows.Forms.GroupBox();
            this.UploadImageBox = new System.Windows.Forms.GroupBox();
            this.RecipeGroupBox = new System.Windows.Forms.GroupBox();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.NameBox.SuspendLayout();
            this.IngredientTagsBox.SuspendLayout();
            this.FullIngredientInfoBox.SuspendLayout();
            this.UploadImageBox.SuspendLayout();
            this.RecipeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.label1.Location = new System.Drawing.Point(231, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edit cocktails";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(685, 20);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 60);
            this.ExitButton.TabIndex = 13;
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
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchByIngredientRadioButton
            // 
            this.SearchByIngredientRadioButton.AutoSize = true;
            this.SearchByIngredientRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByIngredientRadioButton.Location = new System.Drawing.Point(20, 214);
            this.SearchByIngredientRadioButton.Name = "SearchByIngredientRadioButton";
            this.SearchByIngredientRadioButton.Size = new System.Drawing.Size(145, 20);
            this.SearchByIngredientRadioButton.TabIndex = 18;
            this.SearchByIngredientRadioButton.TabStop = true;
            this.SearchByIngredientRadioButton.Text = "Search by Ingredient";
            this.SearchByIngredientRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByNameRadioButton
            // 
            this.SearchByNameRadioButton.AutoSize = true;
            this.SearchByNameRadioButton.Checked = true;
            this.SearchByNameRadioButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.SearchByNameRadioButton.Location = new System.Drawing.Point(20, 188);
            this.SearchByNameRadioButton.Name = "SearchByNameRadioButton";
            this.SearchByNameRadioButton.Size = new System.Drawing.Size(123, 20);
            this.SearchByNameRadioButton.TabIndex = 17;
            this.SearchByNameRadioButton.TabStop = true;
            this.SearchByNameRadioButton.Text = "Search by Name";
            this.SearchByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(20, 155);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(170, 26);
            this.SearchBar.TabIndex = 15;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(210, 154);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 28);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CocktailsListBox
            // 
            this.CocktailsListBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocktailsListBox.FormattingEnabled = true;
            this.CocktailsListBox.HorizontalScrollbar = true;
            this.CocktailsListBox.ItemHeight = 20;
            this.CocktailsListBox.Location = new System.Drawing.Point(20, 241);
            this.CocktailsListBox.Name = "CocktailsListBox";
            this.CocktailsListBox.Size = new System.Drawing.Size(280, 224);
            this.CocktailsListBox.TabIndex = 20;
            this.CocktailsListBox.SelectedIndexChanged += new System.EventHandler(this.CocktailsListBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.NameTextBox.Location = new System.Drawing.Point(80, 20);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(350, 26);
            this.NameTextBox.TabIndex = 22;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // IngredientTagListBox
            // 
            this.IngredientTagListBox.Font = new System.Drawing.Font("Arial", 10F);
            this.IngredientTagListBox.FormattingEnabled = true;
            this.IngredientTagListBox.ItemHeight = 16;
            this.IngredientTagListBox.Location = new System.Drawing.Point(300, 20);
            this.IngredientTagListBox.Name = "IngredientTagListBox";
            this.IngredientTagListBox.Size = new System.Drawing.Size(130, 52);
            this.IngredientTagListBox.TabIndex = 23;
            // 
            // IngredientTagsComboBox
            // 
            this.IngredientTagsComboBox.Font = new System.Drawing.Font("Arial", 10F);
            this.IngredientTagsComboBox.FormattingEnabled = true;
            this.IngredientTagsComboBox.Location = new System.Drawing.Point(10, 35);
            this.IngredientTagsComboBox.Name = "IngredientTagsComboBox";
            this.IngredientTagsComboBox.Size = new System.Drawing.Size(130, 24);
            this.IngredientTagsComboBox.TabIndex = 24;
            this.IngredientTagsComboBox.SelectedIndexChanged += new System.EventHandler(this.IngredientTagsComboBox_SelectedIndexChanged);
            this.IngredientTagsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngredientTagsComboBox_KeyPress);
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Font = new System.Drawing.Font("Arial", 10F);
            this.AddIngredientButton.Location = new System.Drawing.Point(170, 20);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(100, 25);
            this.AddIngredientButton.TabIndex = 25;
            this.AddIngredientButton.Text = "Add tag";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // RemoveIngredientButton
            // 
            this.RemoveIngredientButton.Font = new System.Drawing.Font("Arial", 10F);
            this.RemoveIngredientButton.Location = new System.Drawing.Point(170, 47);
            this.RemoveIngredientButton.Name = "RemoveIngredientButton";
            this.RemoveIngredientButton.Size = new System.Drawing.Size(100, 25);
            this.RemoveIngredientButton.TabIndex = 26;
            this.RemoveIngredientButton.Text = "Remove tag";
            this.RemoveIngredientButton.UseVisualStyleBackColor = true;
            this.RemoveIngredientButton.Click += new System.EventHandler(this.RemoveIngredientButton_Click);
            // 
            // FullIngredientInfoTextBox
            // 
            this.FullIngredientInfoTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.FullIngredientInfoTextBox.Location = new System.Drawing.Point(10, 25);
            this.FullIngredientInfoTextBox.Multiline = true;
            this.FullIngredientInfoTextBox.Name = "FullIngredientInfoTextBox";
            this.FullIngredientInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FullIngredientInfoTextBox.Size = new System.Drawing.Size(190, 86);
            this.FullIngredientInfoTextBox.TabIndex = 28;
            this.FullIngredientInfoTextBox.TextChanged += new System.EventHandler(this.FullIngredientInfoTextBox_TextChanged);
            // 
            // UploadButton
            // 
            this.UploadButton.Font = new System.Drawing.Font("Arial", 12F);
            this.UploadButton.Location = new System.Drawing.Point(45, 80);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(120, 30);
            this.UploadButton.TabIndex = 30;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            // 
            // UploadedFileLabel
            // 
            this.UploadedFileLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadedFileLabel.ForeColor = System.Drawing.Color.Red;
            this.UploadedFileLabel.Location = new System.Drawing.Point(10, 30);
            this.UploadedFileLabel.Name = "UploadedFileLabel";
            this.UploadedFileLabel.Size = new System.Drawing.Size(190, 40);
            this.UploadedFileLabel.TabIndex = 31;
            this.UploadedFileLabel.Text = "Not implemented yet";
            this.UploadedFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecipeTextBox
            // 
            this.RecipeTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.RecipeTextBox.Location = new System.Drawing.Point(10, 24);
            this.RecipeTextBox.Multiline = true;
            this.RecipeTextBox.Name = "RecipeTextBox";
            this.RecipeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecipeTextBox.Size = new System.Drawing.Size(315, 118);
            this.RecipeTextBox.TabIndex = 33;
            this.RecipeTextBox.TextChanged += new System.EventHandler(this.RecipeTextBox_TextChanged);
            // 
            // AddCocktailButton
            // 
            this.AddCocktailButton.Font = new System.Drawing.Font("Arial", 14F);
            this.AddCocktailButton.Location = new System.Drawing.Point(675, 404);
            this.AddCocktailButton.Name = "AddCocktailButton";
            this.AddCocktailButton.Size = new System.Drawing.Size(90, 40);
            this.AddCocktailButton.TabIndex = 35;
            this.AddCocktailButton.Text = "Add";
            this.AddCocktailButton.UseVisualStyleBackColor = true;
            this.AddCocktailButton.Click += new System.EventHandler(this.AddCocktailButton_Click);
            // 
            // EditCocktailButton
            // 
            this.EditCocktailButton.Font = new System.Drawing.Font("Arial", 14F);
            this.EditCocktailButton.Location = new System.Drawing.Point(675, 455);
            this.EditCocktailButton.Name = "EditCocktailButton";
            this.EditCocktailButton.Size = new System.Drawing.Size(90, 40);
            this.EditCocktailButton.TabIndex = 36;
            this.EditCocktailButton.Text = "Edit";
            this.EditCocktailButton.UseVisualStyleBackColor = true;
            this.EditCocktailButton.Click += new System.EventHandler(this.EditCocktailButton_Click);
            // 
            // RemoveCocktailButton
            // 
            this.RemoveCocktailButton.Font = new System.Drawing.Font("Arial", 14F);
            this.RemoveCocktailButton.Location = new System.Drawing.Point(675, 506);
            this.RemoveCocktailButton.Name = "RemoveCocktailButton";
            this.RemoveCocktailButton.Size = new System.Drawing.Size(90, 40);
            this.RemoveCocktailButton.TabIndex = 37;
            this.RemoveCocktailButton.Text = "Remove";
            this.RemoveCocktailButton.UseVisualStyleBackColor = true;
            this.RemoveCocktailButton.Click += new System.EventHandler(this.RemoveCocktailButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Controls.Add(this.NameLabel);
            this.NameBox.Controls.Add(this.NameTextBox);
            this.NameBox.Font = new System.Drawing.Font("Arial", 14F);
            this.NameBox.Location = new System.Drawing.Point(325, 135);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(440, 56);
            this.NameBox.TabIndex = 39;
            this.NameBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(10, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name";
            // 
            // IngredientTagsBox
            // 
            this.IngredientTagsBox.Controls.Add(this.RemoveIngredientButton);
            this.IngredientTagsBox.Controls.Add(this.AddIngredientButton);
            this.IngredientTagsBox.Controls.Add(this.IngredientTagsComboBox);
            this.IngredientTagsBox.Controls.Add(this.IngredientTagListBox);
            this.IngredientTagsBox.Font = new System.Drawing.Font("Arial", 14F);
            this.IngredientTagsBox.Location = new System.Drawing.Point(325, 191);
            this.IngredientTagsBox.Name = "IngredientTagsBox";
            this.IngredientTagsBox.Size = new System.Drawing.Size(440, 82);
            this.IngredientTagsBox.TabIndex = 40;
            this.IngredientTagsBox.TabStop = false;
            this.IngredientTagsBox.Text = "Ingredient tags";
            // 
            // FullIngredientInfoBox
            // 
            this.FullIngredientInfoBox.Controls.Add(this.FullIngredientInfoTextBox);
            this.FullIngredientInfoBox.Font = new System.Drawing.Font("Arial", 14F);
            this.FullIngredientInfoBox.Location = new System.Drawing.Point(325, 273);
            this.FullIngredientInfoBox.Name = "FullIngredientInfoBox";
            this.FullIngredientInfoBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FullIngredientInfoBox.Size = new System.Drawing.Size(210, 121);
            this.FullIngredientInfoBox.TabIndex = 41;
            this.FullIngredientInfoBox.TabStop = false;
            this.FullIngredientInfoBox.Text = "Full ingredient info";
            // 
            // UploadImageBox
            // 
            this.UploadImageBox.Controls.Add(this.UploadedFileLabel);
            this.UploadImageBox.Controls.Add(this.UploadButton);
            this.UploadImageBox.Font = new System.Drawing.Font("Arial", 14F);
            this.UploadImageBox.Location = new System.Drawing.Point(555, 273);
            this.UploadImageBox.Name = "UploadImageBox";
            this.UploadImageBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UploadImageBox.Size = new System.Drawing.Size(210, 121);
            this.UploadImageBox.TabIndex = 42;
            this.UploadImageBox.TabStop = false;
            this.UploadImageBox.Text = "Upload image ";
            // 
            // RecipeGroupBox
            // 
            this.RecipeGroupBox.Controls.Add(this.RecipeTextBox);
            this.RecipeGroupBox.Font = new System.Drawing.Font("Arial", 14F);
            this.RecipeGroupBox.Location = new System.Drawing.Point(325, 394);
            this.RecipeGroupBox.Name = "RecipeGroupBox";
            this.RecipeGroupBox.Size = new System.Drawing.Size(335, 152);
            this.RecipeGroupBox.TabIndex = 43;
            this.RecipeGroupBox.TabStop = false;
            this.RecipeGroupBox.Text = "Recipe";
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.Location = new System.Drawing.Point(20, 475);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(280, 70);
            this.SuccessLabel.TabIndex = 44;
            this.SuccessLabel.Text = "All text fields must be filled!";
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditCocktails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.RecipeGroupBox);
            this.Controls.Add(this.UploadImageBox);
            this.Controls.Add(this.FullIngredientInfoBox);
            this.Controls.Add(this.IngredientTagsBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.RemoveCocktailButton);
            this.Controls.Add(this.EditCocktailButton);
            this.Controls.Add(this.AddCocktailButton);
            this.Controls.Add(this.SearchByIngredientRadioButton);
            this.Controls.Add(this.SearchByNameRadioButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CocktailsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EditCocktails";
            this.Text = "EditCocktails";
            this.NameBox.ResumeLayout(false);
            this.NameBox.PerformLayout();
            this.IngredientTagsBox.ResumeLayout(false);
            this.FullIngredientInfoBox.ResumeLayout(false);
            this.FullIngredientInfoBox.PerformLayout();
            this.UploadImageBox.ResumeLayout(false);
            this.RecipeGroupBox.ResumeLayout(false);
            this.RecipeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RadioButton SearchByIngredientRadioButton;
        private System.Windows.Forms.RadioButton SearchByNameRadioButton;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox CocktailsListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox IngredientTagListBox;
        private System.Windows.Forms.ComboBox IngredientTagsComboBox;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.Button RemoveIngredientButton;
        private System.Windows.Forms.TextBox FullIngredientInfoTextBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label UploadedFileLabel;
        private System.Windows.Forms.Button AddCocktailButton;
        private System.Windows.Forms.Button EditCocktailButton;
        private System.Windows.Forms.Button RemoveCocktailButton;
        private System.Windows.Forms.GroupBox NameBox;
        private System.Windows.Forms.GroupBox IngredientTagsBox;
        private System.Windows.Forms.GroupBox UploadImageBox;
        private System.Windows.Forms.GroupBox RecipeGroupBox;
        private System.Windows.Forms.TextBox RecipeTextBox;
        private System.Windows.Forms.GroupBox FullIngredientInfoBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SuccessLabel;
    }
}