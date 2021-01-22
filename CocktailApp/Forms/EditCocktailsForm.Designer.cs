namespace CocktailApp.Forms
{
    partial class EditCocktailsForm
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.IngredientTagsPanel = new System.Windows.Forms.Panel();
            this.IngredientTagLabel = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.UploadedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.FullIngredientsPanel = new System.Windows.Forms.Panel();
            this.FullIngredientsLabel = new System.Windows.Forms.Label();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.RecipeLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.NamePanel.SuspendLayout();
            this.IngredientTagsPanel.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadedImagePictureBox)).BeginInit();
            this.FullIngredientsPanel.SuspendLayout();
            this.RecipePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F);
            this.label1.Location = new System.Drawing.Point(256, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 75);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edit cocktails";
            // 
            // SearchByIngredientRadioButton
            // 
            this.SearchByIngredientRadioButton.AutoSize = true;
            this.SearchByIngredientRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.SearchByIngredientRadioButton.Location = new System.Drawing.Point(37, 248);
            this.SearchByIngredientRadioButton.Name = "SearchByIngredientRadioButton";
            this.SearchByIngredientRadioButton.Size = new System.Drawing.Size(169, 22);
            this.SearchByIngredientRadioButton.TabIndex = 4;
            this.SearchByIngredientRadioButton.TabStop = true;
            this.SearchByIngredientRadioButton.Text = "Search by ingredient";
            this.SearchByIngredientRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByNameRadioButton
            // 
            this.SearchByNameRadioButton.AutoSize = true;
            this.SearchByNameRadioButton.Checked = true;
            this.SearchByNameRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.SearchByNameRadioButton.Location = new System.Drawing.Point(37, 220);
            this.SearchByNameRadioButton.Name = "SearchByNameRadioButton";
            this.SearchByNameRadioButton.Size = new System.Drawing.Size(139, 22);
            this.SearchByNameRadioButton.TabIndex = 3;
            this.SearchByNameRadioButton.TabStop = true;
            this.SearchByNameRadioButton.Text = "Search by name";
            this.SearchByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.SeaShell;
            this.SearchBar.Font = new System.Drawing.Font("Arial", 15F);
            this.SearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SearchBar.Location = new System.Drawing.Point(27, 179);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(200, 30);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBar_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.SandyBrown;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.SearchButton.FlatAppearance.BorderSize = 2;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Arial", 14F);
            this.SearchButton.Location = new System.Drawing.Point(247, 178);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 32);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CocktailsListBox
            // 
            this.CocktailsListBox.BackColor = System.Drawing.Color.SeaShell;
            this.CocktailsListBox.DisplayMember = "Info";
            this.CocktailsListBox.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.CocktailsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CocktailsListBox.FormattingEnabled = true;
            this.CocktailsListBox.HorizontalScrollbar = true;
            this.CocktailsListBox.ItemHeight = 24;
            this.CocktailsListBox.Location = new System.Drawing.Point(27, 282);
            this.CocktailsListBox.Name = "CocktailsListBox";
            this.CocktailsListBox.Size = new System.Drawing.Size(320, 340);
            this.CocktailsListBox.TabIndex = 5;
            this.CocktailsListBox.ValueMember = "Id";
            this.CocktailsListBox.SelectedIndexChanged += new System.EventHandler(this.CocktailsListBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.NameTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NameTextBox.Location = new System.Drawing.Point(97, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(435, 26);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.TextChanged += new System.EventHandler(this.InputFieldsChanged);
            // 
            // IngredientTagListBox
            // 
            this.IngredientTagListBox.BackColor = System.Drawing.Color.SeaShell;
            this.IngredientTagListBox.Font = new System.Drawing.Font("Arial", 10F);
            this.IngredientTagListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.IngredientTagListBox.FormattingEnabled = true;
            this.IngredientTagListBox.ItemHeight = 16;
            this.IngredientTagListBox.Location = new System.Drawing.Point(352, 5);
            this.IngredientTagListBox.Name = "IngredientTagListBox";
            this.IngredientTagListBox.Size = new System.Drawing.Size(180, 68);
            this.IngredientTagListBox.TabIndex = 15;
            // 
            // IngredientTagsComboBox
            // 
            this.IngredientTagsComboBox.BackColor = System.Drawing.Color.SeaShell;
            this.IngredientTagsComboBox.Font = new System.Drawing.Font("Arial", 10F);
            this.IngredientTagsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.IngredientTagsComboBox.FormattingEnabled = true;
            this.IngredientTagsComboBox.Location = new System.Drawing.Point(7, 46);
            this.IngredientTagsComboBox.Name = "IngredientTagsComboBox";
            this.IngredientTagsComboBox.Size = new System.Drawing.Size(180, 24);
            this.IngredientTagsComboBox.TabIndex = 12;
            this.IngredientTagsComboBox.SelectedIndexChanged += new System.EventHandler(this.InputFieldsChanged);
            this.IngredientTagsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngredientTagsComboBox_KeyPress);
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.BackColor = System.Drawing.Color.SandyBrown;
            this.AddIngredientButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.AddIngredientButton.FlatAppearance.BorderSize = 2;
            this.AddIngredientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.AddIngredientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.AddIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIngredientButton.Font = new System.Drawing.Font("Arial", 11F);
            this.AddIngredientButton.Location = new System.Drawing.Point(212, 5);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(120, 30);
            this.AddIngredientButton.TabIndex = 13;
            this.AddIngredientButton.Text = "Add tag";
            this.AddIngredientButton.UseVisualStyleBackColor = false;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // RemoveIngredientButton
            // 
            this.RemoveIngredientButton.BackColor = System.Drawing.Color.SandyBrown;
            this.RemoveIngredientButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.RemoveIngredientButton.FlatAppearance.BorderSize = 2;
            this.RemoveIngredientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.RemoveIngredientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.RemoveIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveIngredientButton.Font = new System.Drawing.Font("Arial", 11F);
            this.RemoveIngredientButton.Location = new System.Drawing.Point(212, 43);
            this.RemoveIngredientButton.Name = "RemoveIngredientButton";
            this.RemoveIngredientButton.Size = new System.Drawing.Size(120, 30);
            this.RemoveIngredientButton.TabIndex = 14;
            this.RemoveIngredientButton.Text = "Remove tag";
            this.RemoveIngredientButton.UseVisualStyleBackColor = false;
            this.RemoveIngredientButton.Click += new System.EventHandler(this.RemoveIngredientButton_Click);
            // 
            // FullIngredientInfoTextBox
            // 
            this.FullIngredientInfoTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.FullIngredientInfoTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.FullIngredientInfoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FullIngredientInfoTextBox.Location = new System.Drawing.Point(5, 33);
            this.FullIngredientInfoTextBox.Multiline = true;
            this.FullIngredientInfoTextBox.Name = "FullIngredientInfoTextBox";
            this.FullIngredientInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FullIngredientInfoTextBox.Size = new System.Drawing.Size(280, 102);
            this.FullIngredientInfoTextBox.TabIndex = 16;
            this.FullIngredientInfoTextBox.TextChanged += new System.EventHandler(this.InputFieldsChanged);
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.Color.SandyBrown;
            this.UploadButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.UploadButton.FlatAppearance.BorderSize = 2;
            this.UploadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.UploadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Arial", 12F);
            this.UploadButton.Location = new System.Drawing.Point(10, 257);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(100, 30);
            this.UploadButton.TabIndex = 18;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = false;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // UploadedFileLabel
            // 
            this.UploadedFileLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadedFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UploadedFileLabel.Location = new System.Drawing.Point(5, 197);
            this.UploadedFileLabel.Name = "UploadedFileLabel";
            this.UploadedFileLabel.Size = new System.Drawing.Size(220, 54);
            this.UploadedFileLabel.TabIndex = 31;
            this.UploadedFileLabel.Text = "No image uploaded";
            this.UploadedFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecipeTextBox
            // 
            this.RecipeTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.RecipeTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.RecipeTextBox.Location = new System.Drawing.Point(5, 33);
            this.RecipeTextBox.Multiline = true;
            this.RecipeTextBox.Name = "RecipeTextBox";
            this.RecipeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecipeTextBox.Size = new System.Drawing.Size(280, 102);
            this.RecipeTextBox.TabIndex = 17;
            this.RecipeTextBox.TextChanged += new System.EventHandler(this.InputFieldsChanged);
            // 
            // AddCocktailButton
            // 
            this.AddCocktailButton.BackColor = System.Drawing.Color.SandyBrown;
            this.AddCocktailButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.AddCocktailButton.FlatAppearance.BorderSize = 2;
            this.AddCocktailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.AddCocktailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.AddCocktailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCocktailButton.Font = new System.Drawing.Font("Arial", 14F);
            this.AddCocktailButton.Location = new System.Drawing.Point(382, 637);
            this.AddCocktailButton.Name = "AddCocktailButton";
            this.AddCocktailButton.Size = new System.Drawing.Size(94, 45);
            this.AddCocktailButton.TabIndex = 15;
            this.AddCocktailButton.Text = "Add";
            this.AddCocktailButton.UseVisualStyleBackColor = false;
            this.AddCocktailButton.Click += new System.EventHandler(this.AddCocktailButton_Click);
            // 
            // EditCocktailButton
            // 
            this.EditCocktailButton.BackColor = System.Drawing.Color.SandyBrown;
            this.EditCocktailButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.EditCocktailButton.FlatAppearance.BorderSize = 2;
            this.EditCocktailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.EditCocktailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.EditCocktailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCocktailButton.Font = new System.Drawing.Font("Arial", 14F);
            this.EditCocktailButton.Location = new System.Drawing.Point(484, 637);
            this.EditCocktailButton.Name = "EditCocktailButton";
            this.EditCocktailButton.Size = new System.Drawing.Size(94, 45);
            this.EditCocktailButton.TabIndex = 16;
            this.EditCocktailButton.Text = "Edit";
            this.EditCocktailButton.UseVisualStyleBackColor = false;
            this.EditCocktailButton.Click += new System.EventHandler(this.EditCocktailButton_Click);
            // 
            // RemoveCocktailButton
            // 
            this.RemoveCocktailButton.BackColor = System.Drawing.Color.SandyBrown;
            this.RemoveCocktailButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.RemoveCocktailButton.FlatAppearance.BorderSize = 2;
            this.RemoveCocktailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.RemoveCocktailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.RemoveCocktailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCocktailButton.Font = new System.Drawing.Font("Arial", 14F);
            this.RemoveCocktailButton.Location = new System.Drawing.Point(588, 637);
            this.RemoveCocktailButton.Name = "RemoveCocktailButton";
            this.RemoveCocktailButton.Size = new System.Drawing.Size(94, 45);
            this.RemoveCocktailButton.TabIndex = 17;
            this.RemoveCocktailButton.Text = "Remove";
            this.RemoveCocktailButton.UseVisualStyleBackColor = false;
            this.RemoveCocktailButton.Click += new System.EventHandler(this.RemoveCocktailButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.NameLabel.Location = new System.Drawing.Point(17, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ClearButton.FlatAppearance.BorderSize = 2;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 12F);
            this.ClearButton.Location = new System.Drawing.Point(120, 257);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 30);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Italic);
            this.SuccessLabel.Location = new System.Drawing.Point(692, 627);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(240, 65);
            this.SuccessLabel.TabIndex = 44;
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.NamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NamePanel.Controls.Add(this.NameLabel);
            this.NamePanel.Controls.Add(this.NameTextBox);
            this.NamePanel.Location = new System.Drawing.Point(382, 172);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(550, 44);
            this.NamePanel.TabIndex = 10;
            // 
            // IngredientTagsPanel
            // 
            this.IngredientTagsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.IngredientTagsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IngredientTagsPanel.Controls.Add(this.RemoveIngredientButton);
            this.IngredientTagsPanel.Controls.Add(this.IngredientTagLabel);
            this.IngredientTagsPanel.Controls.Add(this.AddIngredientButton);
            this.IngredientTagsPanel.Controls.Add(this.IngredientTagsComboBox);
            this.IngredientTagsPanel.Controls.Add(this.IngredientTagListBox);
            this.IngredientTagsPanel.Location = new System.Drawing.Point(382, 222);
            this.IngredientTagsPanel.Name = "IngredientTagsPanel";
            this.IngredientTagsPanel.Size = new System.Drawing.Size(550, 88);
            this.IngredientTagsPanel.TabIndex = 11;
            // 
            // IngredientTagLabel
            // 
            this.IngredientTagLabel.AutoSize = true;
            this.IngredientTagLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.IngredientTagLabel.Location = new System.Drawing.Point(17, 8);
            this.IngredientTagLabel.Name = "IngredientTagLabel";
            this.IngredientTagLabel.Size = new System.Drawing.Size(136, 22);
            this.IngredientTagLabel.TabIndex = 25;
            this.IngredientTagLabel.Text = "Ingredient tags";
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagePanel.Controls.Add(this.ClearButton);
            this.ImagePanel.Controls.Add(this.UploadedImagePictureBox);
            this.ImagePanel.Controls.Add(this.ImageLabel);
            this.ImagePanel.Controls.Add(this.UploadButton);
            this.ImagePanel.Controls.Add(this.UploadedFileLabel);
            this.ImagePanel.Location = new System.Drawing.Point(692, 316);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(240, 306);
            this.ImagePanel.TabIndex = 14;
            // 
            // UploadedImagePictureBox
            // 
            this.UploadedImagePictureBox.Image = global::CocktailApp.Properties.Resources.placeholder_image;
            this.UploadedImagePictureBox.InitialImage = global::CocktailApp.Properties.Resources.placeholder_image;
            this.UploadedImagePictureBox.Location = new System.Drawing.Point(35, 32);
            this.UploadedImagePictureBox.Name = "UploadedImagePictureBox";
            this.UploadedImagePictureBox.Size = new System.Drawing.Size(160, 160);
            this.UploadedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadedImagePictureBox.TabIndex = 35;
            this.UploadedImagePictureBox.TabStop = false;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.ImageLabel.Location = new System.Drawing.Point(42, 5);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(147, 22);
            this.ImageLabel.TabIndex = 34;
            this.ImageLabel.Text = "Image (optional)";
            // 
            // FullIngredientsPanel
            // 
            this.FullIngredientsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.FullIngredientsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FullIngredientsPanel.Controls.Add(this.FullIngredientsLabel);
            this.FullIngredientsPanel.Controls.Add(this.FullIngredientInfoTextBox);
            this.FullIngredientsPanel.Location = new System.Drawing.Point(382, 316);
            this.FullIngredientsPanel.Name = "FullIngredientsPanel";
            this.FullIngredientsPanel.Size = new System.Drawing.Size(300, 150);
            this.FullIngredientsPanel.TabIndex = 12;
            // 
            // FullIngredientsLabel
            // 
            this.FullIngredientsLabel.AutoSize = true;
            this.FullIngredientsLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.FullIngredientsLabel.Location = new System.Drawing.Point(80, 5);
            this.FullIngredientsLabel.Name = "FullIngredientsLabel";
            this.FullIngredientsLabel.Size = new System.Drawing.Size(138, 22);
            this.FullIngredientsLabel.TabIndex = 29;
            this.FullIngredientsLabel.Text = "Full ingredients";
            // 
            // RecipePanel
            // 
            this.RecipePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.RecipePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RecipePanel.Controls.Add(this.RecipeLabel);
            this.RecipePanel.Controls.Add(this.RecipeTextBox);
            this.RecipePanel.Location = new System.Drawing.Point(382, 472);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(300, 150);
            this.RecipePanel.TabIndex = 13;
            // 
            // RecipeLabel
            // 
            this.RecipeLabel.AutoSize = true;
            this.RecipeLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.RecipeLabel.Location = new System.Drawing.Point(73, 5);
            this.RecipeLabel.Name = "RecipeLabel";
            this.RecipeLabel.Size = new System.Drawing.Size(154, 22);
            this.RecipeLabel.TabIndex = 34;
            this.RecipeLabel.Text = "Recipe (optional)";
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ExportButton.FlatAppearance.BorderSize = 3;
            this.ExportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Arial", 14F);
            this.ExportButton.Location = new System.Drawing.Point(217, 637);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(120, 45);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ImportButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ImportButton.FlatAppearance.BorderSize = 3;
            this.ImportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ImportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Arial", 14F);
            this.ImportButton.Location = new System.Drawing.Point(37, 637);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(120, 45);
            this.ImportButton.TabIndex = 6;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // EditCocktailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 714);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.RecipePanel);
            this.Controls.Add(this.FullIngredientsPanel);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.IngredientTagsPanel);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.RemoveCocktailButton);
            this.Controls.Add(this.EditCocktailButton);
            this.Controls.Add(this.AddCocktailButton);
            this.Controls.Add(this.SearchByIngredientRadioButton);
            this.Controls.Add(this.SearchByNameRadioButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CocktailsListBox);
            this.Controls.Add(this.label1);
            this.Name = "EditCocktailsForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.CocktailsListBox, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.SearchBar, 0);
            this.Controls.SetChildIndex(this.SearchByNameRadioButton, 0);
            this.Controls.SetChildIndex(this.SearchByIngredientRadioButton, 0);
            this.Controls.SetChildIndex(this.AddCocktailButton, 0);
            this.Controls.SetChildIndex(this.EditCocktailButton, 0);
            this.Controls.SetChildIndex(this.RemoveCocktailButton, 0);
            this.Controls.SetChildIndex(this.SuccessLabel, 0);
            this.Controls.SetChildIndex(this.NamePanel, 0);
            this.Controls.SetChildIndex(this.IngredientTagsPanel, 0);
            this.Controls.SetChildIndex(this.ImagePanel, 0);
            this.Controls.SetChildIndex(this.FullIngredientsPanel, 0);
            this.Controls.SetChildIndex(this.RecipePanel, 0);
            this.Controls.SetChildIndex(this.ImportButton, 0);
            this.Controls.SetChildIndex(this.ExportButton, 0);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.IngredientTagsPanel.ResumeLayout(false);
            this.IngredientTagsPanel.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadedImagePictureBox)).EndInit();
            this.FullIngredientsPanel.ResumeLayout(false);
            this.FullIngredientsPanel.PerformLayout();
            this.RecipePanel.ResumeLayout(false);
            this.RecipePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox RecipeTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Panel IngredientTagsPanel;
        private System.Windows.Forms.Label IngredientTagLabel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox UploadedImagePictureBox;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Panel FullIngredientsPanel;
        private System.Windows.Forms.Label FullIngredientsLabel;
        private System.Windows.Forms.Panel RecipePanel;
        private System.Windows.Forms.Label RecipeLabel;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
    }
}