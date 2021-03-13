@Cocktails
Feature: Cocktails form
	Testing of Cocktails form functionality

Background: Navigate to Cocktails window
	Given I navigated to Cocktails window

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
	When I select a random Cocktail in Cocktail window
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