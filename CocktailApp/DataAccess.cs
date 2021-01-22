using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace CocktailApp
{
    public static class DataAccess
    {
        /*
         * This class is used for data transfer to and from the database.
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
    }
}
