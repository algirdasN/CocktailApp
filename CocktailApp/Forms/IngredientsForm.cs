using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CocktailApp
{
    public partial class ShowIngredients : Form
    {
        public ShowIngredients()
        {
            InitializeComponent();

            Data.GetIngredients();

            RefreshIngredientsTable();

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
        private void IngredientsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EditModeCheckBox.Checked)
            {
                FillTextBoxes();
            }
        }

        private void FIlterDropDown_TextChanged(object sender, EventArgs e)
        {
            RefreshIngredientsTable();
        }

        private void EditModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var check = EditModeCheckBox.Checked;

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

        private void FullRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LevelTextBox.Text = "Full";
            SuccessLabelClear();
        }

        private void HalfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LevelTextBox.Text = "Half";
            SuccessLabelClear();
        }

        private void QuarterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LevelTextBox.Text = "Quarter";
            SuccessLabelClear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TextBoxValidation())
            {
                Data.AddEditIngredient(
                    mode: "Add",
                    id: "0",
                    type: Format.CapitalizeFirst(TypeComboBox.Text.Trim()),
                    brand: Format.CapitalizeEvery(BrandTextBox.Text),
                    level: LevelTextBox.Text);

                AddToComboBox();

                RefreshAfterEdit();
            }
            else
            {
                SuccessLabelError();
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
                    brand: Format.CapitalizeEvery(BrandTextBox.Text),
                    level: LevelTextBox.Text);

                AddToComboBox();

                RefreshAfterEdit();
            }
            else
            {
                SuccessLabelError();
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

        private void TypeComboBox_TextChanged(object sender, EventArgs e)
        {
            SuccessLabelClear();
        }

        private void BrandTextBox_TextChanged(object sender, EventArgs e)
        {
            SuccessLabelClear();
        }

        private void RefreshIngredientsTable()
        {
            IngredientsTable.DataSource = Data.Ingredients.FindAll(i => i.Type.ToLower().Contains(FilterDropDown.Text.ToLower()));
            IngredientsTable.Columns["Id"].Visible = false;
        }

        private void PopulateComboBox()
        {
            var list = Data.Ingredients.Select(i => i.Type).Distinct().ToArray();

            TypeComboBox.Items.AddRange(list);
            FilterDropDown.Items.AddRange(list);
        }

        private void FillTextBoxes()
        {
            if (IngredientsTable.SelectedRows.Count > 0)
            {
                TypeComboBox.Text = IngredientsTable.SelectedCells[1].Value.ToString();
                BrandTextBox.Text = IngredientsTable.SelectedCells[2].Value.ToString();
                switch (IngredientsTable.SelectedCells[3].Value.ToString())
                {
                    case "Full":
                        FullRadioButton.Checked = true;
                        break;
                    case "Half":
                        HalfRadioButton.Checked = true;
                        break;
                    case "Quarter":
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
            FullRadioButton.Checked = true;
        }

        private void AddToComboBox()
        {
            var text = Format.CapitalizeFirst(TypeComboBox.Text);

            if (!TypeComboBox.Items.Contains(text))
            {
                TypeComboBox.Items.Add(text);
                FilterDropDown.Items.Add(text);
            }
        }

        private bool TextBoxValidation()
        {
            return TypeComboBox.Text.Trim() != "" && BrandTextBox.Text.Trim() != "";
        }

        private void RefreshAfterEdit()
        {
            Data.GetIngredients();

            RefreshIngredientsTable();

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

        private void SuccessLabelError()
        {
            SuccessLabel.Text = "All fields must be filled!";
        }

        private void SuccessLabelNoSelection()
        {
            SuccessLabel.Text = "Select an ingredient";
        }
    }
}
