namespace CocktailApp.Data
{
    public class Cocktail
    {
        public int? Id { get; private set; }
        public string Name { get; private set; }
        public string Ingredients { get; private set; }
        public string FullIngredients { get; private set; }
        public string Recipe { get; private set; }
        public byte[] Image { get; private set; }
        public bool Favourite { get; private set; }
        public string FullIngredientInfo => "○ " + FullIngredients.Replace("|", "\r\n○ ");
        public string InfoAvailable => GetInfoAvailable();
        public string Info => Name.ToUpper() + " - " + Ingredients.Replace("|", ", ");

        public Cocktail() { }

        public Cocktail(string id, string name, string ingredients, string fullIngredients, string recipe, byte[] image)
        {
            Id = int.TryParse(id, out var i) ? (int?)i : null;
            Name = name;
            Ingredients = ingredients;
            FullIngredients = fullIngredients;
            Recipe = recipe;
            Image = image;
        }

        public bool IsAvailable()
        {
            foreach (string item in Ingredients.Split('|'))
            {
                if (!DataAccess.Ingredients.Exists(i => i.Type == item))
                {
                    return false;
                }
            }
            return true;
        }

        private string GetInfoAvailable()
        {
            string str = Ingredients;

            foreach (string item in Ingredients.Split('|'))
            {
                if (!DataAccess.Ingredients.Exists(i => i.Type == item))
                {
                    str = str.Replace(item, ">>" + item + "<<");
                }
            }

            return (Favourite ? "★" : null) + Name.ToUpper() + " - " + str.Replace("|", ", ");
        }
    }
}
