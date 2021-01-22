using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CocktailApp
{
    public static class Data
    {
        /*
         * This class is used for data transfer to and from the database and importing/exporting data to .csv files.
         */

        public static List<Cocktail> Cocktails { get; private set; }
        public static List<Ingredient> Ingredients { get; private set; }
        public static List<Cocktail> AvailableCocktails => Cocktails.Where(c => c.IsAvailable()).ToList();
        private static IDbConnection Connection => new SQLiteConnection(@"Data Source=|DataDirectory|\Database.db; Version=3;");

        public static void GetIngredients()
        {
            using (IDbConnection connect = Connection)
            {
                Ingredients = connect.Query<Ingredient>("SELECT * FROM Ingredients ORDER BY Type, Brand, Level DESC, Volume DESC").ToList();
            }
        }

        public static void GetCocktails()
        {
            using (IDbConnection connect = Connection)
            {
                Cocktails = connect.Query<Cocktail>("SELECT * FROM Cocktails ORDER BY Name").ToList();
            }
        }

        public static void SearchCocktails(string term, string searchby)
        {
            if (term == "")
            {
                GetCocktails();
            }
            else
            {
                var query = $"SELECT * FROM Cocktails WHERE {searchby} LIKE @term ORDER BY Name";

                using (IDbConnection connect = Connection)
                {
                    Cocktails = connect.Query<Cocktail>(query, new { term = '%' + term + '%' }).ToList();
                }
            }
        }

        public static void FavouriteCocktail(string id, bool check)
        {
            var query = $"UPDATE Cocktails SET Favourite = {check} WHERE Id = @Id";

            using (IDbConnection connect = Connection)
            {
                connect.Execute(query, new { Id = id });
            }
        }

        public static void AddEditIngredient(string type, string brand, string volume, string level, string id = null)
        {
            var query = "INSERT OR REPLACE INTO Ingredients(Id, Type, Brand, Volume, Level) " +
                "VALUES(@Id, @Type, @Brand, @Volume, @Level)";

            using (IDbConnection connect = Connection)
            {
                connect.Execute(query, new Ingredient(id, type, brand, volume, level));
            }
        }

        public static void RemoveIngredient(string id)
        {
            var query = "DELETE FROM Ingredients WHERE Id = @Id";

            using (IDbConnection connect = Connection)
            {
                connect.Execute(query, new { Id = id });
            }
        }

        public static void AddEditCocktail(
            string name, string ingredients, string fullIngredients, string recipe, byte[] image, string id = null)
        {
            // This query preserves the Favourite status if record is replaced.
            var query = "INSERT OR REPLACE INTO Cocktails (Id, Name, Ingredients, FullIngredients, Recipe, Image, Favourite) " +
                "VALUES (@Id, @Name, @Ingredients, @FullIngredients, @Recipe, @Image, " +
                "(SELECT Favourite FROM Cocktails WHERE Id = @Id OR Name = @Name))";

            //var query = "INSERT INTO Cocktails(Id, Name, Ingredients, FullIngredients, Recipe, Image) " +
            //    "VALUES(@Id, @Name, @Ingredients, @FullIngredients, @Recipe, @Image) " +
            //    "ON CONFLICT() DO UPDATE SET Name=@Name, Ingredients=@Ingredients, " +
            //    "FullIngredients=@FullIngredients, Recipe=@Recipe, Image=@Image";

            using (IDbConnection connect = Connection)
            {
                connect.Execute(query, new Cocktail(id, name, ingredients, fullIngredients, recipe, image));
            }
        }

        public static void RemoveCocktail(string id)
        {
            var query = "DELETE FROM Cocktails WHERE Id = @Id";

            using (IDbConnection connect = Connection)
            {
                connect.Execute(query, new { Id = id });
            }
        }

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
                            AddEditIngredient(
                                type: currentRow[0],
                                brand: currentRow[1],
                                volume: currentRow[2],
                                level: currentRow[3]);
                        }
                    }
                    MessageBox.Show("Ingredients imported successfully.", "Data import");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured\r\n\r\n" + e.Message, "Data import");
            }
        }

        public static void ExportIngredients(string filePath)
        {
            var fileName = DateTime.Now.ToString("d") + "_Ingredients.csv";
            var query = "SELECT Type, Brand, Volume, Level FROM Ingredients ORDER BY Type, Brand, Volume DESC";

            try
            {
                using (IDbConnection connect = Connection)
                using (var csvFile = new StreamWriter(filePath + "\\" + fileName))
                {
                    connect.Open();
                    using (var reader = new SQLiteCommand(query, (SQLiteConnection)connect).ExecuteReader())
                    {
                        csvFile.WriteLine("{0};{1};{2};{3}",
                            reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                        while (reader.Read())
                        {
                            csvFile.WriteLine("{0};{1};{2};{3}",
                                reader[0], reader[1], reader[2], reader[3]);
                        }
                    }
                    csvFile.Close();
                    connect.Close();
                }
                MessageBox.Show("Ingredients exported successfully.\r\n\r\nFile location: " + filePath +
                                "\r\nFile name: " + fileName, "Data export");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured\r\n\r\n" + e.Message, "Data export");
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

                            AddEditCocktail(
                                name: currentRow[0],
                                ingredients: currentRow[1],
                                fullIngredients: currentRow[2],
                                recipe: currentRow[3],
                                image: image);
                        }
                    }
                    MessageBox.Show("Cocktails imported successfully.", "Data import");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured\r\n\r\n" + e.Message, "Data import");
            }
        }

        public static void ExportCocktails(string filePath)
        {
            var fileName = DateTime.Now.ToString("d") + "_Cocktails.csv";
            var query = "SELECT Name, Ingredients, FullIngredients, Recipe, Image FROM Cocktails ORDER BY Name";

            try
            {
                using (IDbConnection connect = Connection)
                using (var csvFile = new StreamWriter(filePath + "\\" + fileName))
                {
                    connect.Open();
                    using (var reader = new SQLiteCommand(query, (SQLiteConnection)connect).ExecuteReader())
                    {
                        csvFile.WriteLine("{0};{1};{2};{3};{4}",
                            reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4));

                        while (reader.Read())
                        {
                            var image = reader[4].ToString().Any() ? Convert.ToBase64String((byte[])reader[4]) : "";

                            csvFile.WriteLine("{0};{1};{2};{3};{4}",
                                reader[0], reader[1], reader[2], reader[3], image);
                        }
                    }
                    csvFile.Close();
                    connect.Close();
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
