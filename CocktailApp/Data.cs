using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CocktailApp
{
    public static class Data
    {
        public static List<Cocktail> Cocktails { get; private set; }
        public static List<Ingredient> Ingredients { get; private set; }
        public static List<Cocktail> AvailableCocktails => Cocktails.Where(c => c.IsAvailable()).ToList();
        private static IDbConnection Connection =>
            new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        public static void GetIngredients()
        {
            using (IDbConnection connect = Connection)
            {
                Ingredients = connect.Query<Ingredient>("SELECT * FROM Ingredients ORDER BY Type").ToList();
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
                var query = $"SELECT * FROM Cocktails WHERE {searchby} LIKE @{searchby} ORDER BY Name";
                using (IDbConnection connect = Connection)
                {
                    switch (searchby)
                    {
                        case "Name":
                            Cocktails = connect.Query<Cocktail>(query, new { Name = '%' + term + '%' }).ToList();
                            break;
                        case "Ingredients":
                            Cocktails = connect.Query<Cocktail>(query, new { Ingredients = '%' + term + '%' }).ToList();
                            break;
                    }
                }
            }
        }

        public static void FavouriteCocktail(string id, bool check)
        {
            var query = $"UPDATE Cocktails SET Favourite = {(check ? 1 : 0)} WHERE Id = {id}";

            using (IDbConnection connect = Connection)
            {
                connect.Open();
                using (var sqlCmd = new SqlCommand(query, (SqlConnection)connect))
                {
                    sqlCmd.ExecuteNonQuery();
                }
                connect.Close();
            }
        }

        public static void AddEditIngredient(
            string mode, string id, string type, string brand, string level)
        {
            using (IDbConnection connect = Connection)
            {
                connect.Open();
                using (var sqlCmd = new SqlCommand($"Ingredient{mode}", (SqlConnection)connect))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@Id", id);
                    sqlCmd.Parameters.AddWithValue("@Type", type);
                    sqlCmd.Parameters.AddWithValue("@Brand", brand);
                    sqlCmd.Parameters.AddWithValue("@Level", level);

                    sqlCmd.ExecuteNonQuery();
                }
                connect.Close();
            }
        }

        public static void RemoveIngredient(string id)
        {
            using (IDbConnection connect = Connection)
            {
                connect.Open();
                using (var sqlCmd = new SqlCommand($"IngredientDelete", (SqlConnection)connect))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@Id", id);

                    sqlCmd.ExecuteNonQuery();
                }
                connect.Close();
            }
        }

        public static void AddEditCocktail(
            string mode, string id, string name, string ingredients, string fullIngredients, string recipe, byte[] image)
        {
            using (IDbConnection connect = Connection)
            {
                connect.Open();
                using (var sqlCmd = new SqlCommand($"Cocktail{mode}", (SqlConnection)connect))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@Id", id);
                    sqlCmd.Parameters.AddWithValue("@Name", name);
                    sqlCmd.Parameters.AddWithValue("@Ingredients", ingredients);
                    sqlCmd.Parameters.AddWithValue("@FullIngredients", fullIngredients);
                    sqlCmd.Parameters.AddWithValue("@Recipe", recipe);

                    if (image == null)
                    {
                        sqlCmd.Parameters.Add(new SqlParameter("@Image", SqlDbType.Image) { Value = DBNull.Value });
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Image", image);
                    }

                    sqlCmd.ExecuteNonQuery();
                }
                connect.Close();
            }
        }

        public static void RemoveCocktail(string id)
        {
            using (IDbConnection connect = Connection)
            {
                connect.Open();
                using (var sqlCmd = new SqlCommand("CocktailDelete", (SqlConnection)connect))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@Id", id);

                    sqlCmd.ExecuteNonQuery();
                }
                connect.Close();
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
                            if (currentRow[0] != "Type" || currentRow[1] != "Brand" || currentRow[2] != "Level")
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
                                mode: "Add",
                                id: "0",
                                type: currentRow[0],
                                brand: currentRow[1],
                                level: currentRow[2]);
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
            var query = "SELECT Type, Brand, Level FROM Ingredients ORDER BY Type";

            try
            {
                using (IDbConnection connect = Connection)
                using (var csvFile = new StreamWriter(filePath + "\\" + fileName))
                {
                    connect.Open();
                    using (var reader = new SqlCommand(query, (SqlConnection)connect).ExecuteReader())
                    {
                        csvFile.WriteLine("{0};{1};{2}",
                            reader.GetName(0), reader.GetName(1), reader.GetName(2));

                        while (reader.Read())
                        {
                            csvFile.WriteLine("{0};{1};{2}",
                                reader[0], reader[1], reader[2]);
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
                            var currentCocktail = Cocktails.FirstOrDefault(c => c.Name == currentRow[0]);
                            
                            byte[] image = currentRow[4].Any() ? Convert.FromBase64String(currentRow[4]) : null;

                            AddEditCocktail(
                                mode: currentCocktail == null ? "Add" : "Edit",
                                id: currentCocktail == null ? "0" : currentCocktail.Id,
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
                    using (var reader = new SqlCommand(query, (SqlConnection)connect).ExecuteReader())
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
