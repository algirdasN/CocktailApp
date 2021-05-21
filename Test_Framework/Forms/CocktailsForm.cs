using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test_Framework.Forms
{
    public class CocktailsForm : BaseForm
    {
        private string selectedCocktailName;

        public CocktailsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {
        }

        protected override string ID => "CocktailsForm";
        private IList<WindowsElement> cocktailList => driver.FindElementsByXPath("//List[@AutomationId='CocktailsListBox']/ListItem");
        private IList<WindowsElement> favouriteCocktailList =>
            driver.FindElementsByXPath("//List[@AutomationId='CocktailsListBox']/ListItem[contains(@Name, '★')]");
        private IList<WindowsElement> nonfavouriteCocktailList =>
            driver.FindElementsByXPath("//List[@AutomationId='CocktailsListBox']/ListItem[not(contains(@Name, '★'))]");
        private WindowsElement searchBar => driver.FindElementByAccessibilityId("SearchBar");
        private WindowsElement searchButton => driver.FindElementByAccessibilityId("SearchButton");
        private WindowsElement searchByNameRadioButton => driver.FindElementByAccessibilityId("SearchByNameRadioButton");
        private WindowsElement searchByIngredientRadioButton => driver.FindElementByAccessibilityId("SearchByIngredientRadioButton");
        private WindowsElement availableCheckBox => driver.FindElementByAccessibilityId("AvailableCheckBox");
        private WindowsElement favouriteCheckBox => driver.FindElementByAccessibilityId("FavouriteCheckBox");
        private WindowsElement printSingleCocktailButton => driver.FindElementByAccessibilityId("PrintCocktailButton");
        private WindowsElement printAllFavouritesButton => driver.FindElementByAccessibilityId("PrintMenuButton");
        private WindowsElement cocktailNameLabel => driver.FindElementByAccessibilityId("CocktailNameLabel");
        private WindowsElement ingredientsTextBox => driver.FindElementByAccessibilityId("IngredientsTextBox");
        private WindowsElement recipeTextBox => driver.FindElementByAccessibilityId("RecipeTextBox");
        private WindowsElement favouritePictureBox => driver.FindElementByAccessibilityId("FavouritePictureBox");


        public void EnterSearchTerm(string searchTerm)
        {
            searchBar.SendKeys(searchTerm);
        }

        public void ClickSearchButton()
        {
            searchButton.Click();
        }

        public void SelectSearchByName()
        {
            searchByNameRadioButton.Click();
        }

        public void SelectSearchByIngredient()
        {
            searchByIngredientRadioButton.Click();
        }

        public void ClickAvailableCheckBox()
        {
            availableCheckBox.Click();
        }

        public void ClickFavouriteCheckbox()
        {
            favouriteCheckBox.Click();
        }

        public void ClickPrintSingleCocktailButton()
        {
            printSingleCocktailButton.Click();
        }

        public void ClickPrintAllFavouritesButton()
        {
            printAllFavouritesButton.Click();
        }

        public string SelectRandomCocktail()
        {
            IList<WindowsElement> cocktailList = this.cocktailList;

            int rnd = new Random().Next(cocktailList.Count);

            Match match = new Regex(@"^★?(.+) -").Match(cocktailList[rnd].Text);

            selectedCocktailName = match.Groups[1].Value;

            cocktailList[rnd].Click();

            return GetSanitizedCocktailName(selectedCocktailName);
        }

        public void SetFavouriteCocktails(int count)
        {
            if (count > cocktailList.Count)
            {
                Assert.Fail("Selected number is higher that the number of cocktails");
            }

            switch (Math.Sign(count - favouriteCocktailList.Count))
            {
                case 1:
                    SelectFavouriteCocktails(count);
                    break;
                case -1:
                    DeselectFavouriteCocktails(count);
                    break;
            }
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

        public void AssertCocktailSearchByName(string searchTerm)
        {
            Regex regex = new Regex($@".*{searchTerm}.* -", RegexOptions.IgnoreCase);

            foreach (var item in cocktailList)
            {
                Assert.IsTrue(regex.IsMatch(item.Text));
            }
        }

        public void AssertCocktailSearchByIngredient(string searchTerm)
        {
            Regex regex = new Regex($@"- .*{searchTerm}.*$", RegexOptions.IgnoreCase);

            foreach (var item in cocktailList)
            {
                Assert.IsTrue(regex.IsMatch(item.Text));
            }
        }

        private string GetSanitizedCocktailName(string name)
        {
            return Regex.Replace(Regex.Replace(name.ToLower(), @"[^\w\s\.-]", ""), @"\s+", "_");
        }

        private void SelectFavouriteCocktails(int count)
        {
            while (count > favouriteCocktailList.Count)
            {
                IList<WindowsElement> cocktailList = nonfavouriteCocktailList;

                int rnd = new Random().Next(cocktailList.Count);

                Actions actions = new Actions(driver);
                actions.MoveToElement(cocktailList[rnd]).Perform();

                cocktailList[rnd].Click();

                favouritePictureBox.Click();
            }
        }

        private void DeselectFavouriteCocktails(int count)
        {
            while (count < favouriteCocktailList.Count)
            {
                IList<WindowsElement> cocktailList = favouriteCocktailList;

                int rnd = new Random().Next(cocktailList.Count);

                cocktailList[rnd].Click();

                favouritePictureBox.Click();
            }
        }
    }
}