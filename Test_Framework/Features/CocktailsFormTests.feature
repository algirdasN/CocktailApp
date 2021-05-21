@Cocktails
Feature: Cocktails form
	Testing of Cocktails form functionality


Background: Navigate to Cocktails window
	Given That I navigated to Cocktails window


@Back
Scenario: Go back to Main window
	When I click Back button
	Then Only Main window should be displayed


@Exit
Scenario: Exit the application
	When I click Exit button
	Then Application should close


@SelectCocktail
Scenario: Select Cocktail to see its details
	When I select a Cocktail in Cocktail window
	Then Selected Cocktail details should be displayed


@FilterCocktail @Available
Scenario: Filter Cocktails by availability
	When I tick Show Only Available checkbox
	Then Only available Cocktails should be displayed


@FilterCocktail @Favourite
Scenario: Filter Cocktails by favourite status
	When I tick Show Only Favourite checkbox
	Then Only favourited Cocktails should be displayed


@FilterCocktail @Available @Favourite
Scenario: Filter Cocktails by availability and favourite status
	When I tick Show Only Available checkbox
	And I tick Show Only Favourite checkbox
	Then Only available Cocktails should be displayed
	And Only favourited Cocktails should be displayed


@Search @ByName
Scenario Outline: Search Cocktails by name
	Given That Search by Name radio button is selected
	When I enter '<search term>' into search bar and click search
	Then Only Cocktails with names containing '<search term>' should be displayed

	Examples:
		| search term |
		| r           |
		| gin         |
		| test        |


@Search @ByIngredient
Scenario: Search Cocktails by ingredients
	Given That Search by Ingredients radio button is selected
	When I enter '<search term>' into search bar and press enter
	Then Only Cocktails with an ingredient containing '<search term>' should be displayed

	Examples:
		| search term |
		| r           |
		| gin         |
		| test        |


@Export @Print @SingleImage
Scenario: Export selected Cocktail as an image
	When I select a Cocktail in Cocktail window
	And I click Print single Cocktail button
	And I select 'D:\test' as a destination folder
	Then Success message box should be displayed
	And Selected Cocktail's image should be exported to correct folder


@Export @Print @Menu
Scenario: Export favourited Cocktails as a PDF menu
	When I set '2' Cocktails as favourite
	And I click Print all favourites button
	And I select 'D:\test' as a destination folder
	Then Success message box should be displayed
	And All favourite cocktails should be exported as PDF to correct folder


@Export @Print @Menu
Scenario: Try to export 0 Cocktails as a PDF menu
	When I set '0' Cocktails as favourite
	And I click Print all favourites button
	Then Error message box should be displayed