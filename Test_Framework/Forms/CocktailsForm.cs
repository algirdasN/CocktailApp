using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test_Framework.Forms
{
    public class CocktailsForm : BaseForm
    {
        private string selectedCocktailName;

        private bool selectedCocktailFavourite;

        public CocktailsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {
        }

        protected override string ID => "CocktailsForm";
        private IList<WindowsElement> cocktailList => driver.FindElementsByXPath("//List[@AutomationId=\"CocktailsListBox\"]/ListItem");
        private WindowsElement cocktailNameLabel => driver.FindElementByAccessibilityId("CocktailNameLabel");
        private WindowsElement ingredientsTextBox => driver.FindElementByAccessibilityId("IngredientsTextBox");
        private WindowsElement recipeTextBox => driver.FindElementByAccessibilityId("RecipeTextBox");
        private WindowsElement availableCheckBox => driver.FindElementByAccessibilityId("AvailableCheckBox");
        private WindowsElement favouriteCheckBox => driver.FindElementByAccessibilityId("FavouriteCheckBox");


        public void Test()
        {
            System.Console.WriteLine();
            foreach (var item in cocktailList)
            {
                System.Console.WriteLine(item.Text);
            }
            System.Console.WriteLine();
        }

        public void SelectRandomCocktail()
        {
            int rnd = new Random().Next(cocktailList.Count);

            Match match = new Regex(@"^(★?)(.+) -").Match(cocktailList[rnd].Text);

            selectedCocktailFavourite = match.Groups[1].Value.Any();

            selectedCocktailName = match.Groups[2].Value;

            cocktailList[rnd].Click();
        }

        public void ClickAvailableCheckBox()
        {
            availableCheckBox.Click();
        }

        public void ClickFavouriteCheckbox()
        {
            favouriteCheckBox.Click();
        }

        public void AssertCocktailInfoIsDisplayed()
        {
            Assert.AreEqual(selectedCocktailName, cocktailNameLabel.Text);

            Assert.IsTrue(ingredientsTextBox.Text.Any());
            
            Assert.IsTrue(recipeTextBox.Text.Any());
        }

        public void AssertOnlyAvailableDisplayed()
        {
            Regex regex = new Regex(@">>.+<<");

            foreach (var item in cocktailList)
            {
                Assert.IsFalse(regex.Matches(item.Text).Any());
            }
        }

        public void AssertOnlyFavouritedDisplayed()
        {
            Regex regex = new Regex(@"★");

            foreach (var item in cocktailList)
            {
                Assert.IsTrue(regex.Matches(item.Text).Any());
            }
        }
    }
}