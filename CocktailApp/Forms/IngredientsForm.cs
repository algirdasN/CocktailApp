﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CocktailApp
{
    public partial class IngredientsForm : Form
    {
        private List<Ingredient> IngredientList;

        private int SortedColumn;

        private bool SortAsc = true;

        public IngredientsForm()
        {
            InitializeComponent();

            PopulateIngredientsTable();

            IngredientsTable.Columns["Id"].Visible = false;
            IngredientsTable.Columns["Volume"].Visible = false;
            IngredientsTable.Columns["Level"].Visible = false;

            PopulateComboBox();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            mainMenu.Location = Location;
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!((sender as Form).ActiveControl is Button))
            {
                Application.Exit();
            }
        }

        private void IngredientsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EditModeCheckBox.Checked)
            {
                FillTextBoxes();
            }
        }

        private void FIlterDropDown_TextChanged(object sender, EventArgs e)
        {
            var currencyManager = (CurrencyManager)BindingContext[IngredientsTable.DataSource];

            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in IngredientsTable.Rows)
            {
                row.Visible = row.Cells[1].Value.ToString().IndexOf(FilterDropDown.Text, StringComparison.OrdinalIgnoreCase) >= 0;
            }

            currencyManager.ResumeBinding();
        }

        private void IngredientsTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SortAsc = !(e.ColumnIndex == SortedColumn && SortAsc);

            SortedColumn = e.ColumnIndex;

            SortIngredients();

            var id = IngredientsTable.SelectedCells[0].Value.ToString();

            IngredientsTable.DataSource = IngredientList;

            foreach (DataGridViewRow row in IngredientsTable.Rows)
            {
                if (row.Cells[0].Value.ToString() == id)
                {
                    row.Selected = true;
                    break;
                }
            } 
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "CSV files | *.csv*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Data.ImportIngredients(dialog.FileName);

                PopulateIngredientsTable();

                FilterDropDown.Text = "";
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Data.ExportIngredients(dialog.SelectedPath);
            }
        }

        private void EditModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool check = EditModeCheckBox.Checked;

            EditPanel.Enabled = check;

            IngredientsTable.DefaultCellStyle.SelectionForeColor = check ?
                Color.SeaShell : IngredientsTable.DefaultCellStyle.ForeColor;

            IngredientsTable.DefaultCellStyle.SelectionBackColor = check ?
                Color.CornflowerBlue : IngredientsTable.DefaultCellStyle.BackColor;

            if (check)
            {
                IngredientsTable.ClearSelection();

                FillTextBoxes();
            }
            else
            {
                Unselect();

                SuccessLabelClear();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TextBoxValidation())
            {
                Data.AddEditIngredient(
                  mode: "Add",
                  id: "0",
                  type: Format.CapitalizeFirst(TypeComboBox.Text.Trim()),
                  brand: BrandTextBox.Text.Trim(),
                  volume: VolumeTextBox.Text.Trim(),
                  level: FullRadioButton.Checked ? "full" :
                      HalfRadioButton.Checked ? "half" : "quarter");

                AddToComboBox();

                RefreshAfterEdit();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (IngredientsTable.SelectedRows.Count == 0)
            {
                SuccessLabelNoSelection();
            }
            else if (TextBoxValidation())
            {
                Data.AddEditIngredient(
                mode: "Edit",
                id: IngredientsTable.SelectedCells[0].Value.ToString(),
                type: Format.CapitalizeFirst(TypeComboBox.Text.Trim()),
                brand: BrandTextBox.Text.Trim(),
                volume: VolumeTextBox.Text.Trim(),
                level: FullRadioButton.Checked ? "full" :
                    HalfRadioButton.Checked ? "half" : "quarter");

                AddToComboBox();

                RefreshAfterEdit();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (IngredientsTable.SelectedRows.Count > 0)
            {
                Data.RemoveIngredient(IngredientsTable.SelectedCells[0].Value.ToString());

                RefreshAfterEdit();
            }
            else
            {
                SuccessLabelNoSelection();
            }
        }

        private void InputFieldsChanged(object sender, EventArgs e)
        {
            SuccessLabelClear();
        }

        private void PopulateIngredientsTable()
        {
            Data.GetIngredients();

            IngredientList = new List<Ingredient>(Data.Ingredients);

            IngredientsTable.DataSource = IngredientList;

        }

        private void PopulateComboBox()
        {
            var arr = Data.Ingredients.Select(i => i.Type).Distinct().ToArray();

            TypeComboBox.Items.AddRange(arr);
            FilterDropDown.Items.AddRange(arr);
        }

        private void SortIngredients()
        {
            switch (SortedColumn)
            {
                case 1:
                    IngredientList = SortAsc ?
                        IngredientList.OrderBy(i => i.Type).ToList() : IngredientList.OrderByDescending(i => i.Type).ToList();
                    break;
                case 2:
                    IngredientList = SortAsc ?
                        IngredientList.OrderBy(i => i.Brand).ToList() : IngredientList.OrderByDescending(i => i.Brand).ToList();
                    break;
                case 5:
                    IngredientList = SortAsc ?
                        IngredientList.OrderBy(i => i.Volume).ToList() : IngredientList.OrderByDescending(i => i.Volume).ToList();
                    break;
                case 6:
                    IngredientList = SortAsc ?
                        IngredientList.OrderBy(i => i.Level).ToList() : IngredientList.OrderByDescending(i => i.Level).ToList();
                    break;
            }
        }

        private void FillTextBoxes()
        {
            if (IngredientsTable.SelectedRows.Count > 0)
            {
                TypeComboBox.Text = IngredientsTable.SelectedCells[1].Value.ToString();
                BrandTextBox.Text = IngredientsTable.SelectedCells[2].Value.ToString();
                VolumeTextBox.Text = IngredientsTable.SelectedCells[3].Value.ToString();

                switch (IngredientsTable.SelectedCells[4].Value.ToString())
                {
                    case "full":
                        FullRadioButton.Checked = true;
                        break;
                    case "half":
                        HalfRadioButton.Checked = true;
                        break;
                    case "quarter":
                        QuarterRadioButton.Checked = true;
                        break;
                }
            }
        }

        private void Unselect()
        {
            IngredientsTable.ClearSelection();

            TypeComboBox.Text = "";
            BrandTextBox.Text = "";
            VolumeTextBox.Text = "";
            FullRadioButton.Checked = true;
        }

        private void AddToComboBox()
        {
            string text = Format.CapitalizeFirst(TypeComboBox.Text);

            if (!TypeComboBox.Items.Contains(text))
            {
                TypeComboBox.Items.Add(text);
                FilterDropDown.Items.Add(text);
            }
        }

        private bool TextBoxValidation()
        {
            if (TypeComboBox.Text.Trim() == "" || BrandTextBox.Text.Trim() == "" || VolumeTextBox.Text.Trim() == "")
            {
                SuccessLabelEmpty();

                return false;
            }
            else if (!int.TryParse(VolumeTextBox.Text.Trim(), out _))
            {
                SuccessLabelInvalid();

                return false;
            }
            else
            {
                return true;
            }

        }

        private void RefreshAfterEdit()
        {
            PopulateIngredientsTable();

            Unselect();

            SuccessLabelSuccess();
        }

        private void SuccessLabelClear()
        {
            SuccessLabel.Text = "";
        }

        private void SuccessLabelSuccess()
        {
            SuccessLabel.Text = "Success!";
        }

        private void SuccessLabelEmpty()
        {
            SuccessLabel.Text = "All fields must be filled!";
        }

        private void SuccessLabelInvalid()
        {
            SuccessLabel.Text = "Volume must be an integer!";
        }

        private void SuccessLabelNoSelection()
        {
            SuccessLabel.Text = "Select an ingredient";
        }
    }
}
