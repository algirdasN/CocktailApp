using System.Windows.Forms.VisualStyles;

namespace CocktailApp
{
    partial class ShowIngredients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowIngredients));
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.IngredientsTable = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EditModeCheckBox = new System.Windows.Forms.CheckBox();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.LevelTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.QuarterRadioButton = new System.Windows.Forms.RadioButton();
            this.FullRadioButton = new System.Windows.Forms.RadioButton();
            this.HalfRadioButton = new System.Windows.Forms.RadioButton();
            this.FilterDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsTable)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F);
            this.label1.Location = new System.Drawing.Point(286, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingredients";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SandyBrown;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.BackButton.FlatAppearance.BorderSize = 3;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.BackButton.Location = new System.Drawing.Point(20, 20);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 60);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // IngredientsTable
            // 
            this.IngredientsTable.AllowUserToAddRows = false;
            this.IngredientsTable.AllowUserToDeleteRows = false;
            this.IngredientsTable.AllowUserToResizeColumns = false;
            this.IngredientsTable.AllowUserToResizeRows = false;
            this.IngredientsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.IngredientsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.IngredientsTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IngredientsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IngredientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Brand,
            this.Level});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IngredientsTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.IngredientsTable.EnableHeadersVisualStyles = false;
            this.IngredientsTable.Location = new System.Drawing.Point(40, 250);
            this.IngredientsTable.MultiSelect = false;
            this.IngredientsTable.Name = "IngredientsTable";
            this.IngredientsTable.ReadOnly = true;
            this.IngredientsTable.RowHeadersVisible = false;
            this.IngredientsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.IngredientsTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IngredientsTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsTable.RowTemplate.Height = 25;
            this.IngredientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IngredientsTable.Size = new System.Drawing.Size(400, 330);
            this.IngredientsTable.TabIndex = 1;
            this.IngredientsTable.TabStop = false;
            this.IngredientsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IngredientsTable_CellClick);
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "Type";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.DefaultCellStyle = dataGridViewCellStyle2;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 100;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brand.DataPropertyName = "Brand";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.DefaultCellStyle = dataGridViewCellStyle3;
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 100;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Level.DataPropertyName = "Level";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.DefaultCellStyle = dataGridViewCellStyle4;
            this.Level.HeaderText = "Remaining";
            this.Level.MinimumWidth = 100;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ExitButton.FlatAppearance.BorderSize = 3;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.ExitButton.Location = new System.Drawing.Point(825, 20);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 60);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EditModeCheckBox
            // 
            this.EditModeCheckBox.AutoSize = true;
            this.EditModeCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditModeCheckBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditModeCheckBox.Location = new System.Drawing.Point(650, 205);
            this.EditModeCheckBox.Name = "EditModeCheckBox";
            this.EditModeCheckBox.Size = new System.Drawing.Size(140, 31);
            this.EditModeCheckBox.TabIndex = 2;
            this.EditModeCheckBox.Text = "Edit mode";
            this.EditModeCheckBox.UseVisualStyleBackColor = true;
            this.EditModeCheckBox.CheckedChanged += new System.EventHandler(this.EditModeCheckBox_CheckedChanged);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.EditPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EditPanel.Controls.Add(this.SuccessLabel);
            this.EditPanel.Controls.Add(this.BrandTextBox);
            this.EditPanel.Controls.Add(this.TypeComboBox);
            this.EditPanel.Controls.Add(this.LevelTextBox);
            this.EditPanel.Controls.Add(this.RemoveButton);
            this.EditPanel.Controls.Add(this.TypeLabel);
            this.EditPanel.Controls.Add(this.EditButton);
            this.EditPanel.Controls.Add(this.LevelLabel);
            this.EditPanel.Controls.Add(this.AddButton);
            this.EditPanel.Controls.Add(this.BrandLabel);
            this.EditPanel.Controls.Add(this.QuarterRadioButton);
            this.EditPanel.Controls.Add(this.FullRadioButton);
            this.EditPanel.Controls.Add(this.HalfRadioButton);
            this.EditPanel.Enabled = false;
            this.EditPanel.Location = new System.Drawing.Point(505, 250);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(400, 405);
            this.EditPanel.TabIndex = 13;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.Location = new System.Drawing.Point(15, 275);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(370, 30);
            this.SuccessLabel.TabIndex = 16;
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.BrandTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.BrandTextBox.Location = new System.Drawing.Point(160, 90);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(225, 26);
            this.BrandTextBox.TabIndex = 2;
            this.BrandTextBox.TextChanged += new System.EventHandler(this.BrandTextBox_TextChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = System.Drawing.Color.SeaShell;
            this.TypeComboBox.Font = new System.Drawing.Font("Arial", 12F);
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(160, 30);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(225, 26);
            this.TypeComboBox.Sorted = true;
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.TextChanged += new System.EventHandler(this.TypeComboBox_TextChanged);
            // 
            // LevelTextBox
            // 
            this.LevelTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LevelTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.LevelTextBox.Location = new System.Drawing.Point(160, 150);
            this.LevelTextBox.Name = "LevelTextBox";
            this.LevelTextBox.ReadOnly = true;
            this.LevelTextBox.Size = new System.Drawing.Size(225, 26);
            this.LevelTextBox.TabIndex = 3;
            this.LevelTextBox.Text = "Full";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.SandyBrown;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.RemoveButton.FlatAppearance.BorderSize = 3;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(275, 340);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(110, 50);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(20, 32);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(55, 24);
            this.TypeLabel.TabIndex = 13;
            this.TypeLabel.Text = "Type";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SandyBrown;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.EditButton.FlatAppearance.BorderSize = 3;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(145, 340);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 50);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(20, 152);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(108, 24);
            this.LevelLabel.TabIndex = 14;
            this.LevelLabel.Text = "Remaining";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.SandyBrown;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.AddButton.FlatAppearance.BorderSize = 3;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(15, 340);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 50);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLabel.Location = new System.Drawing.Point(20, 92);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(65, 24);
            this.BrandLabel.TabIndex = 15;
            this.BrandLabel.Text = "Brand";
            // 
            // QuarterRadioButton
            // 
            this.QuarterRadioButton.AutoSize = true;
            this.QuarterRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.QuarterRadioButton.Location = new System.Drawing.Point(295, 180);
            this.QuarterRadioButton.Name = "QuarterRadioButton";
            this.QuarterRadioButton.Size = new System.Drawing.Size(78, 22);
            this.QuarterRadioButton.TabIndex = 4;
            this.QuarterRadioButton.Text = "Quarter";
            this.QuarterRadioButton.UseVisualStyleBackColor = true;
            this.QuarterRadioButton.CheckedChanged += new System.EventHandler(this.QuarterRadioButton_CheckedChanged);
            // 
            // FullRadioButton
            // 
            this.FullRadioButton.AutoSize = true;
            this.FullRadioButton.Checked = true;
            this.FullRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.FullRadioButton.Location = new System.Drawing.Point(165, 180);
            this.FullRadioButton.Name = "FullRadioButton";
            this.FullRadioButton.Size = new System.Drawing.Size(50, 22);
            this.FullRadioButton.TabIndex = 4;
            this.FullRadioButton.TabStop = true;
            this.FullRadioButton.Text = "Full";
            this.FullRadioButton.UseVisualStyleBackColor = true;
            this.FullRadioButton.CheckedChanged += new System.EventHandler(this.FullRadioButton_CheckedChanged);
            // 
            // HalfRadioButton
            // 
            this.HalfRadioButton.AutoSize = true;
            this.HalfRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.HalfRadioButton.Location = new System.Drawing.Point(230, 180);
            this.HalfRadioButton.Name = "HalfRadioButton";
            this.HalfRadioButton.Size = new System.Drawing.Size(53, 22);
            this.HalfRadioButton.TabIndex = 4;
            this.HalfRadioButton.Text = "Half";
            this.HalfRadioButton.UseVisualStyleBackColor = true;
            this.HalfRadioButton.CheckedChanged += new System.EventHandler(this.HalfRadioButton_CheckedChanged);
            // 
            // FilterDropDown
            // 
            this.FilterDropDown.BackColor = System.Drawing.Color.SeaShell;
            this.FilterDropDown.Font = new System.Drawing.Font("Arial", 12F);
            this.FilterDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FilterDropDown.FormattingEnabled = true;
            this.FilterDropDown.Location = new System.Drawing.Point(190, 204);
            this.FilterDropDown.Name = "FilterDropDown";
            this.FilterDropDown.Size = new System.Drawing.Size(250, 26);
            this.FilterDropDown.Sorted = true;
            this.FilterDropDown.TabIndex = 14;
            this.FilterDropDown.TextChanged += new System.EventHandler(this.FIlterDropDown_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(50, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter by type";
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ImportButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ImportButton.FlatAppearance.BorderSize = 3;
            this.ImportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ImportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(50, 592);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(150, 50);
            this.ImportButton.TabIndex = 17;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ExportButton.FlatAppearance.BorderSize = 3;
            this.ExportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(280, 592);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(150, 50);
            this.ExportButton.TabIndex = 18;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ShowIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.ControlBox = false;
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterDropDown);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.EditModeCheckBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.IngredientsTable);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "ShowIngredients";
            this.Text = "ShowIngredients";
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsTable)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView IngredientsTable;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox EditModeCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox LevelTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.RadioButton QuarterRadioButton;
        private System.Windows.Forms.RadioButton FullRadioButton;
        private System.Windows.Forms.RadioButton HalfRadioButton;
        private System.Windows.Forms.ComboBox FilterDropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
    }
}