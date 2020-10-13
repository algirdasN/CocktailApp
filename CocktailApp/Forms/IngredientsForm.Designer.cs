using System.Windows.Forms;

namespace CocktailApp
{
    partial class IngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EditModeCheckBox = new System.Windows.Forms.CheckBox();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
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
            this.FilterLabel = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.IngredientsTable = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F);
            this.label1.Location = new System.Drawing.Point(283, 52);
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
            this.BackButton.Location = new System.Drawing.Point(27, 22);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 60);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.ExitButton.Location = new System.Drawing.Point(827, 22);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 60);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EditModeCheckBox
            // 
            this.EditModeCheckBox.AutoSize = true;
            this.EditModeCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditModeCheckBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditModeCheckBox.Location = new System.Drawing.Point(677, 180);
            this.EditModeCheckBox.Name = "EditModeCheckBox";
            this.EditModeCheckBox.Size = new System.Drawing.Size(140, 31);
            this.EditModeCheckBox.TabIndex = 4;
            this.EditModeCheckBox.Text = "Edit mode";
            this.EditModeCheckBox.UseVisualStyleBackColor = true;
            this.EditModeCheckBox.CheckedChanged += new System.EventHandler(this.EditModeCheckBox_CheckedChanged);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.EditPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EditPanel.Controls.Add(this.VolumeLabel);
            this.EditPanel.Controls.Add(this.SuccessLabel);
            this.EditPanel.Controls.Add(this.BrandTextBox);
            this.EditPanel.Controls.Add(this.TypeComboBox);
            this.EditPanel.Controls.Add(this.VolumeTextBox);
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
            this.EditPanel.Location = new System.Drawing.Point(552, 227);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(360, 370);
            this.EditPanel.TabIndex = 5;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeLabel.Location = new System.Drawing.Point(10, 130);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(117, 24);
            this.VolumeLabel.TabIndex = 20;
            this.VolumeLabel.Text = "Volume (ml)";
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.Location = new System.Drawing.Point(10, 245);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(336, 30);
            this.SuccessLabel.TabIndex = 16;
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.BrandTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.BrandTextBox.Location = new System.Drawing.Point(140, 79);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(205, 26);
            this.BrandTextBox.TabIndex = 12;
            this.BrandTextBox.TextChanged += new System.EventHandler(this.BrandTextBox_TextChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = System.Drawing.Color.SeaShell;
            this.TypeComboBox.Font = new System.Drawing.Font("Arial", 12F);
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(140, 29);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(205, 26);
            this.TypeComboBox.Sorted = true;
            this.TypeComboBox.TabIndex = 11;
            this.TypeComboBox.TextChanged += new System.EventHandler(this.TypeComboBox_TextChanged);
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.VolumeTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.VolumeTextBox.Location = new System.Drawing.Point(140, 129);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(205, 26);
            this.VolumeTextBox.TabIndex = 13;
            this.VolumeTextBox.TextChanged += new System.EventHandler(this.VolumeTextBox_TextChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.SandyBrown;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.RemoveButton.FlatAppearance.BorderSize = 3;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Arial", 14F);
            this.RemoveButton.Location = new System.Drawing.Point(246, 305);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 40);
            this.RemoveButton.TabIndex = 19;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(10, 30);
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
            this.EditButton.Font = new System.Drawing.Font("Arial", 14F);
            this.EditButton.Location = new System.Drawing.Point(128, 305);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 40);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(10, 180);
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
            this.AddButton.Font = new System.Drawing.Font("Arial", 14F);
            this.AddButton.Location = new System.Drawing.Point(10, 305);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 40);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLabel.Location = new System.Drawing.Point(10, 80);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(65, 24);
            this.BrandLabel.TabIndex = 15;
            this.BrandLabel.Text = "Brand";
            // 
            // QuarterRadioButton
            // 
            this.QuarterRadioButton.AutoSize = true;
            this.QuarterRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.QuarterRadioButton.Location = new System.Drawing.Point(265, 181);
            this.QuarterRadioButton.Name = "QuarterRadioButton";
            this.QuarterRadioButton.Size = new System.Drawing.Size(78, 22);
            this.QuarterRadioButton.TabIndex = 16;
            this.QuarterRadioButton.TabStop = true;
            this.QuarterRadioButton.Text = "Quarter";
            this.QuarterRadioButton.UseVisualStyleBackColor = true;
            this.QuarterRadioButton.CheckedChanged += new System.EventHandler(this.QuarterRadioButton_CheckedChanged);
            // 
            // FullRadioButton
            // 
            this.FullRadioButton.AutoSize = true;
            this.FullRadioButton.Checked = true;
            this.FullRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.FullRadioButton.Location = new System.Drawing.Point(145, 181);
            this.FullRadioButton.Name = "FullRadioButton";
            this.FullRadioButton.Size = new System.Drawing.Size(50, 22);
            this.FullRadioButton.TabIndex = 14;
            this.FullRadioButton.TabStop = true;
            this.FullRadioButton.Text = "Full";
            this.FullRadioButton.UseVisualStyleBackColor = true;
            this.FullRadioButton.CheckedChanged += new System.EventHandler(this.FullRadioButton_CheckedChanged);
            // 
            // HalfRadioButton
            // 
            this.HalfRadioButton.AutoSize = true;
            this.HalfRadioButton.Font = new System.Drawing.Font("Arial", 12F);
            this.HalfRadioButton.Location = new System.Drawing.Point(205, 181);
            this.HalfRadioButton.Name = "HalfRadioButton";
            this.HalfRadioButton.Size = new System.Drawing.Size(53, 22);
            this.HalfRadioButton.TabIndex = 15;
            this.HalfRadioButton.TabStop = true;
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
            this.FilterDropDown.Location = new System.Drawing.Point(262, 185);
            this.FilterDropDown.Name = "FilterDropDown";
            this.FilterDropDown.Size = new System.Drawing.Size(200, 26);
            this.FilterDropDown.Sorted = true;
            this.FilterDropDown.TabIndex = 1;
            this.FilterDropDown.TextChanged += new System.EventHandler(this.FIlterDropDown_TextChanged);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.FilterLabel.Location = new System.Drawing.Point(102, 187);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(118, 22);
            this.FilterLabel.TabIndex = 15;
            this.FilterLabel.Text = "Filter by type";
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
            this.ImportButton.Location = new System.Drawing.Point(592, 627);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(120, 40);
            this.ImportButton.TabIndex = 2;
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
            this.ExportButton.Font = new System.Drawing.Font("Arial", 14F);
            this.ExportButton.Location = new System.Drawing.Point(752, 627);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(120, 40);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IngredientsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IngredientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Brand,
            this.VolumeInfo,
            this.LevelInfo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IngredientsTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.IngredientsTable.EnableHeadersVisualStyles = false;
            this.IngredientsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.IngredientsTable.Location = new System.Drawing.Point(42, 227);
            this.IngredientsTable.MultiSelect = false;
            this.IngredientsTable.Name = "IngredientsTable";
            this.IngredientsTable.RowHeadersVisible = false;
            this.IngredientsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.IngredientsTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IngredientsTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsTable.RowTemplate.Height = 25;
            this.IngredientsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IngredientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IngredientsTable.Size = new System.Drawing.Size(480, 453);
            this.IngredientsTable.TabIndex = 1;
            this.IngredientsTable.TabStop = false;
            this.IngredientsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IngredientsTable_CellClick);
            this.IngredientsTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.IngredientsTable_ColumnHeaderMouseClick);
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
            this.Brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VolumeInfo
            // 
            this.VolumeInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VolumeInfo.DataPropertyName = "VolumeInfo";
            this.VolumeInfo.FillWeight = 50F;
            this.VolumeInfo.HeaderText = "Volume";
            this.VolumeInfo.MinimumWidth = 90;
            this.VolumeInfo.Name = "VolumeInfo";
            this.VolumeInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LevelInfo
            // 
            this.LevelInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LevelInfo.DataPropertyName = "LevelInfo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.LevelInfo.FillWeight = 50F;
            this.LevelInfo.HeaderText = "Remains";
            this.LevelInfo.MinimumWidth = 90;
            this.LevelInfo.Name = "LevelInfo";
            this.LevelInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(954, 714);
            this.ControlBox = false;
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterDropDown);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.EditModeCheckBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.IngredientsTable);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "IngredientsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowIngredients_FormClosing);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView IngredientsTable;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox EditModeCheckBox;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox VolumeTextBox;
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
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label VolumeLabel;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn VolumeInfo;
        private DataGridViewTextBoxColumn LevelInfo;
    }
}