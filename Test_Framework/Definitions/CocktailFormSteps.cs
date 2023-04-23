using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;
using Test_Framework.Forms;

namespace Test_Framework.Definitions
{

    [Binding]
    public sealed class CocktailFormSteps
    {
        private WindowsDriver<WindowsElement> driver;

        private MainForm mainForm;
        private CocktailsForm cocktailsForm;
        private OpenFolderDialog openFolderDialog;
        private MsgBox msgBox;

        private string destinationPath;
        private string selectedCocktail;
        private string menuName;
        private int pageCount;

        public CocktailFormSteps(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;

            InitiateForms();
        }

        private void InitiateForms()
        {
            mainForm = new MainForm(driver);
            cocktailsForm = new CocktailsForm(driver);
            openFolderDialog = new OpenFolderDialog(driver);
            msgBox = new MsgBox(driver);
        }

        [Given(@"That I navigated to Cocktails window")]
        public void GivenThatINavigatedToCocktailsWindow()
        {
            mainForm.ClickCocktailsButton();
            cocktailsForm.AssertWindowChange();
        }

        [Given(@"That Search by Name radio button is selected")]
        public void GivenThatSearchByNameRadioButtonIsSelected()
        {
            cocktailsForm.SelectSearchByName();
        }

        [Given(@"That Search by Ingredients radio button is selected")]
        public void GivenThatSearchByIngredientsRadioButtonIsSelected()
        {
            cocktailsForm.SelectSearchByIngredient();
        }

        [When(@"I select a Cocktail in Cocktail window")]
        public void WhenISelectARandomCocktailInCocktailWindow()
        {
            selectedCocktail = cocktailsForm.SelectRandomCocktail();
        }

        [When(@"I tick Show Only Available checkbox")]
        public void WhenITickShowOnlyAvailableCheckbox()
        {
            cocktailsForm.ClickAvailableCheckBox();
        }

        [When(@"I tick Show Only Favourite checkbox")]
        public void WhenITickShowOnlyFavouriteCheckbox()
        {
            cocktailsForm.ClickFavouriteCheckbox();
        }

        [When(@"I enter '(.*)' into search bar and click search")]
        public void WhenIEnterIntoSearchBarAndClickSearch(string searchTerm)
        {
            cocktailsForm.EnterSearchTerm(searchTerm);
            cocktailsForm.ClickSearchButton();
        }

        [When(@"I enter '(.*)' into search bar and press enter")]
        public void WhenIEnterIntoSearchBarAndPressEnter(string searchTerm)
        {
            cocktailsForm.EnterSearchTerm(searchTerm + Keys.Enter);
        }

        [When(@"I click Print single Cocktail button")]
        public void WhenIClickPrintSingleCocktailButton()
        {
            cocktailsForm.ClickPrintSingleCocktailButton();
        }

        [When(@"I select '(.*)' as a destination folder")]
        public void WhenISelectAsADestinationFolder(string destPath)
        {
            destinationPath = new Regex(@"\\$").Replace(destPath, "");

            openFolderDialog.OpenFolderByPath(destinationPath);
        }

        [When(@"I set '(.*)' Cocktails as favourite")]
        public void WhenISetRandomCocktailsAsFavourite(int p0)
        {
            pageCount = p0;

            cocktailsForm.SetFavouriteCocktails(p0);
        }

        [When(@"I click Print all favourites button")]
        public void WhenIClickPrintAllFavouritesButton()
        {
            menuName = "Cocktail_menu_" + DateTime.Now.ToString("d", CultureInfo.InstalledUICulture) + ".pdf";

            cocktailsForm.ClickPrintAllFavouritesButton();
        }

        [Then(@"Selected Cocktail details should be displayed")]
        public void ThenSelectedCocktailDetailsShouldBeDisplayed()
        {
            cocktailsForm.AssertCocktailInfoIsDisplayed();
        }

        [Then(@"Only available Cocktails should be displayed")]
        public void ThenOnlyAvailableCocktailsShouldBeDisplayed()
        {
            cocktailsForm.AssertOnlyAvailableDisplayed();
        }

        [Then(@"Only favourited Cocktails should be displayed")]
        public void ThenOnlyFavouritedCocktailsShouldBeDisplayed()
        {
            cocktailsForm.AssertOnlyFavouritedDisplayed();
        }

        [Then(@"Only Cocktails with names containing '(.*)' should be displayed")]
        public void ThenOnlyCocktailsWithNamesContainingShouldBeDisplayed(string searchTerm)
        {
            cocktailsForm.AssertCocktailSearchByName(searchTerm);
        }

        [Then(@"Only Cocktails with an ingredient containing '(.*)' should be displayed")]
        public void ThenOnlyCocktailsWithAnIngredientContainingShouldBeDisplayed(string searchTerm)
        {
            cocktailsForm.AssertCocktailSearchByIngredient(searchTerm);
        }

        [Then(@"Success message box should be displayed")]
        public void ThenSuccessMessageBoxShouldBeDisplayed()
        {
            msgBox.SwitchFocusToMsgBox();
            
            string fileName = menuName ?? selectedCocktail + ".png";

            string title = menuName == null ? "Print cocktail" : "Print menu";

            AssertMessageBoxText(title, "Success!", destinationPath, fileName);

            msgBox.ClickOkButton();

            cocktailsForm.SwitchToActiveWindow();
        }

        [Then(@"Selected Cocktail's image should be exported to correct folder")]
        public void ThenSelectedCocktailSImageShouldBeExportedToCorrectFolder()
        {
            var filePath = destinationPath + "\\" + selectedCocktail + ".png";

            Assert.IsTrue(File.Exists(filePath));

            File.Delete(filePath);
        }

        [Then(@"All favourite cocktails should be exported as PDF to correct folder")]
        public void ThenAllFavouriteCocktailsShouldBeExportedAsPDFToCorrectFolder()
        {
            var filePath = destinationPath + "\\" + menuName;

            Assert.IsTrue(File.Exists(filePath));

            using (StreamReader sr = new StreamReader(File.OpenRead(filePath)))
            {
                MatchCollection matches = new Regex(@"/Type\s*/Page[^s]").Matches(sr.ReadToEnd());

                Assert.AreEqual(pageCount, matches.Count);
            }

            File.Delete(filePath);
        }

        [Then(@"Error message box should be displayed")]
        public void ThenErrorMessageBoxShouldBeDisplayed()
        {
            AssertMessageBoxText("Print cocktail", "No cocktails favourited.");

            msgBox.ClickOkButton();
        }

        public void AssertMessageBoxText(string title, params string[] text)
        {
            Assert.AreEqual(title, msgBox.GetMessageTitle());

            foreach (var item in text)
            {
                Assert.IsTrue(msgBox.GetMessageText().Contains(item));
            }
        }
    }
}