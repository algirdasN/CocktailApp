namespace CocktailApp
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.IngredientsButton = new System.Windows.Forms.Button();
            this.EditCocktailsButton = new System.Windows.Forms.Button();
            this.CocktailsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main menu";
            // 
            // IngredientsButton
            // 
            this.IngredientsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsButton.Location = new System.Drawing.Point(300, 360);
            this.IngredientsButton.Name = "IngredientsButton";
            this.IngredientsButton.Size = new System.Drawing.Size(200, 70);
            this.IngredientsButton.TabIndex = 3;
            this.IngredientsButton.Text = "Ingredients";
            this.IngredientsButton.UseVisualStyleBackColor = true;
            this.IngredientsButton.Click += new System.EventHandler(this.IngredientsButton_Click);
            // 
            // EditCocktailsButton
            // 
            this.EditCocktailsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EditCocktailsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCocktailsButton.Location = new System.Drawing.Point(300, 260);
            this.EditCocktailsButton.Name = "EditCocktailsButton";
            this.EditCocktailsButton.Size = new System.Drawing.Size(200, 70);
            this.EditCocktailsButton.TabIndex = 2;
            this.EditCocktailsButton.Text = "Edit cocktails";
            this.EditCocktailsButton.UseVisualStyleBackColor = true;
            this.EditCocktailsButton.Click += new System.EventHandler(this.EditCocktailsButton_Click);
            // 
            // CocktailsButton
            // 
            this.CocktailsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocktailsButton.Location = new System.Drawing.Point(300, 160);
            this.CocktailsButton.Name = "CocktailsButton";
            this.CocktailsButton.Size = new System.Drawing.Size(200, 70);
            this.CocktailsButton.TabIndex = 1;
            this.CocktailsButton.Text = "Cocktails";
            this.CocktailsButton.UseVisualStyleBackColor = true;
            this.CocktailsButton.Click += new System.EventHandler(this.CocktailsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(300, 460);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 70);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CocktailsButton);
            this.Controls.Add(this.EditCocktailsButton);
            this.Controls.Add(this.IngredientsButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IngredientsButton;
        private System.Windows.Forms.Button EditCocktailsButton;
        private System.Windows.Forms.Button CocktailsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

