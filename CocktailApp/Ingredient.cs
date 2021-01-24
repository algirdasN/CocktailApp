namespace CocktailApp
{
    public class Ingredient
    {
        public int? Id { get; private set; }
        public string Type { get; private set; }
        public string Brand { get; private set; }
        public int Volume { get; private set; }
        public int Level { get; private set; }
        public string VolumeInfo => Volume < 1000 ? Volume + " ml" : (Volume / 1000) + " l";
        public string LevelInfo => GetLevelInfo();

        public Ingredient() { }

        public Ingredient(string id, string type, string brand, string volume, string level)
        {
            Id = int.TryParse(id, out var i) ? (int?)i : null;
            Type = type;
            Brand = brand;
            Volume = int.Parse(volume);
            Level = int.Parse(level);
        }

        private string GetLevelInfo()
        {
            switch (Level)
            {
                case 3: return "▮▮▮";
                case 2: return "▯▮▮";
                case 1: return "▯▯▮";
                default: return null;
            }
        }
    }
}
