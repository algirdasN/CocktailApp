namespace CocktailApp
{
    public class Ingredient
    {
        public int Id { get; private set; }
        public string Type { get; private set; }
        public string Brand { get; private set; }
        public int Volume { get; private set; }
        public string Level { get; private set; }
        public string VolumeInfo => Volume < 1000 ? Volume + " ml" : (Volume / 1000) + " l";
        public string LevelInfo => GetLevelInfo();

        private string GetLevelInfo()
        {
            switch (Level)
            {
                case "full": return "▮▮▮";
                case "half": return "▯▮▮";
                case "quarter": return "▯▯▮";
                default: return null;
            }
        }
    }
}
