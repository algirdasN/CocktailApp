namespace CocktailApp
{
    public class Cocktail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string FullIngredients { get; set; }
        public string Recipe { get; set; }
        public string FullIngredientInfo => "○ " + FullIngredients.Replace(";", "\r\n○ ");
        public string InfoAvailable => GetInfoAvailable();
        public string Info => Name.ToUpper() + " - " + Ingredients.Replace(";", ", ");
        public bool Available => IsAvailable();

        private bool IsAvailable()
        {
            foreach (string item in Ingredients.Split(';'))
            {
                if (!Data.Ingredients.Exists(i => i.Type == item))
                {
                    return false;
                }
            }
            return true;
        }

        private string GetInfoAvailable()
        {
            var str = Ingredients;
            foreach (string item in Ingredients.Split(';'))
            {
                if (!Data.Ingredients.Exists(i => i.Type == item))
                {
                    str = str.Replace(item, ">>" + item + "<<");
                }
            }
            return Name.ToUpper() + " - " + str.Replace(";", ", ");
        }
    }
}
