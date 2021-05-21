@Main
Feature: Main form
	Testing of Main form button functionality


@Cocktails
Scenario: Open cocktails window
	When I click Cocktails button
	Then Only Cocktails window should be displayed


@Ingredients
Scenario: Open Ingredients window
	When I click Ingredients button
	Then Only Ingredients window should be displayed


@EditIngredients
Scenario: Open Edit Cocktails window
	When I click Edit Cocktails button
	Then Only Edit Cocktails window should be displayed


@Exit
Scenario: Exit the application
	When I click Exit button
	Then Application should close