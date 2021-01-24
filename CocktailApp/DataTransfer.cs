using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CocktailApp
{
    class DataTransfer
    {
        /*
         * This class is used for data transfer to and from .csv files.
         */

        public static void ImportIngredients(string fileName)
        {
            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    bool headers = true;
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        var currentRow = line.Split(';');

                        if (headers == true)
                        {
                            if (currentRow[0] != "Type" || currentRow[1] != "Brand" ||
                                currentRow[2] != "Volume" || currentRow[3] != "Level")
                            {
                                MessageBox.Show("Incorrect CSV file headers.", "Data import");
                                return;
                            }
                            else
                            {
                                headers = false;
                            }
                        }
                        else
                        {
                            DataAccess.AddEditIngredient(
                                type: currentRow[0],
                                brand: currentRow[1],
                                volume: currentRow[2],
                                level: currentRow[3]);
                        }
                    }
                    MsgBox.ShowAsync("Ingredients imported successfully.", "Data import");
                }
            }
            catch (Exception e)
            {
                MsgBox.ShowAsync("Error occured\r\n\r\n" + e.Message, "Data import");
            }
        }

        public static void ExportIngredients(string filePath)
        {
            var fileName = DateTime.Now.ToString("d") + "_Ingredients.csv";

            try
            {
                using (var csvFile = new StreamWriter(filePath + "\\" + fileName))
                {
                    csvFile.WriteLine("Type;Brand;Volume;Level");

                    foreach (var item in DataAccess.Ingredients)
                    {
                        csvFile.WriteLine("{0};{1};{2};{3}", item.Type, item.Brand, item.Volume, item.Level);
                    }

                    csvFile.Close();
                }
                MessageBox.Show("Ingredients exported successfully.\r\n\r\nFile location: " + filePath +
                                "\r\nFile name: " + fileName, "Data export");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured\r\n\r\n" + e.Message , "Data export");
            }
        }

        public static void ImportCocktails(string fileName)
        {
            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    bool headers = true;
                    string line;
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        var currentRow = line.Split(';');

                        if (headers == true)
                        {
                            if (currentRow[0] != "Name" ||
                                currentRow[1] != "Ingredients" ||
                                currentRow[2] != "FullIngredients" ||
                                currentRow[3] != "Recipe" ||
                                currentRow[4] != "Image")
                            {
                                MessageBox.Show("Incorrect CSV file headers.", "Data import");
                                return;
                            }
                            else
                            {
                                headers = false;
                            }
                        }
                        else
                        {
                            byte[] image = currentRow[4].Any() ? Convert.FromBase64String(currentRow[4]) : null;

                            DataAccess.AddEditCocktail(
                                name: currentRow[0],
                                ingredients: currentRow[1],
                                fullIngredients: currentRow[2],
                                recipe: currentRow[3],
                                image: image);
                        }
                    }
                    MsgBox.ShowAsync("Cocktails imported successfully.", "Data import");
                }
            }
            catch (Exception e)
            {
                MsgBox.ShowAsync($"Error occured\r\n\r\n" + e.Message, "Data import");
            }
        }

        public static void ExportCocktails(string filePath)
        {
            DataAccess.GetCocktails();

            var fileName = DateTime.Now.ToString("d") + "_Cocktails.csv";

            try
            {
                using (var csvFile = new StreamWriter(filePath + "\\" + fileName))
                {
                    csvFile.WriteLine("Name;Ingredients;FullIngredients;Recipe;Image");

                    foreach (var item in DataAccess.Cocktails)
                    {
                        csvFile.WriteLine("{0};{1};{2};{3};{4}", item.Name, item.Ingredients, item.FullIngredients, item.Recipe, 
                            item.Image != null ? Convert.ToBase64String(item.Image) : "");
                    }

                    csvFile.Close();
                }
                MessageBox.Show("Cocktails exported successfully.\r\n\r\nFile location: " + filePath +
                                "\r\nFile name: " + fileName, "Data export");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured\r\n\r\n" + e.Message, "Data export");
            }
        }
    }
}
