using System;
using System.Linq;

namespace CocktailApp
{
    public static class Format
    {
        public static string CapitalizeFirst(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }

        public static string CapitalizeEvery(string str)
        {
            return string.Join(" ", str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(s => CapitalizeFirst(s)));
        }
    }
}
