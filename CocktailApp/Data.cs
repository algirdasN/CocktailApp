using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CocktailApp
{
    public static class Data
    {
        public static List<Cocktail> Cocktails;
        public static List<Cocktail> AvailableCocktails => Cocktails.Where(c => c.Available).ToList();
        public static List<Ingredient> Ingredients => GetIngredients();
        private static IDbConnection Connection => 
            new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        
        private static List<Ingredient> GetIngredients()
        {
            using (Connection)
            {
                return Connection.Query<Ingredient>("SELECT * FROM Ingredients ORDER BY Type").ToList();
            }
        }

        private static List<Cocktail> GetCocktails()
        {
            using (Connection)
            {
                return Connection.Query<Cocktail>("SELECT * FROM Cocktails ORDER BY Name").ToList();
            }
        }

        public static void GetNewCocktailList()
        {
            SearchCocktails("", "Name");
        }

        public static void SearchCocktails(string term, string searchby)
        {
            if (term == "")
            {
                Cocktails = GetCocktails();
            }
            else
            {
                var query = $"SELECT * FROM Cocktails WHERE {searchby} LIKE @{searchby} ORDER BY Name";
                using (Connection)
                {
                    switch (searchby)
                    {
                        case "Name":
                            Cocktails = Connection.Query<Cocktail>(query, new { Name = '%' + term + '%' }).ToList();
                            break;
                        case "Ingredients":
                            Cocktails = Connection.Query<Cocktail>(query, new { Ingredients = '%' + term + '%' }).ToList();
                            break;
                    }
                }
            }
        }

        public static void AddEditIngredient(
            string mode, string id, string type, string brand, string level)
        {
            using (var connect = Connection)
            {
                connect.Open();
                SqlCommand sqlCmd = new SqlCommand($"Ingredient{mode}", (SqlConnection)connect)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@Id", id);
                sqlCmd.Parameters.AddWithValue("@Type", type);
                sqlCmd.Parameters.AddWithValue("@Brand", brand);
                sqlCmd.Parameters.AddWithValue("@Level", level);
                sqlCmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void RemoveIngredient(string id)
        {
            using (var connect = Connection)
            {
                connect.Open();
                SqlCommand sqlCmd = new SqlCommand("IngredientDelete", (SqlConnection)connect)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@Id", id);
                sqlCmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void AddEditCocktail(
            string mode, string id, string name, string ingredients, string fullIngredients, string recipe)
        {
            using (var connect = Connection)
            {
                connect.Open();
                SqlCommand sqlCmd = new SqlCommand($"Cocktail{mode}", (SqlConnection)connect)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@Id", id);
                sqlCmd.Parameters.AddWithValue("@Name", name);
                sqlCmd.Parameters.AddWithValue("@Ingredients", ingredients);
                sqlCmd.Parameters.AddWithValue("@FullIngredients", fullIngredients);
                sqlCmd.Parameters.AddWithValue("@Recipe", recipe);
                sqlCmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void RemoveCocktail(string id)
        {
            using (var connect = Connection)
            {
                connect.Open();
                SqlCommand sqlCmd = new SqlCommand("CocktailDelete", (SqlConnection)connect)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@Id", id);
                sqlCmd.ExecuteNonQuery();
                connect.Close();
            }
        }
    }
}
