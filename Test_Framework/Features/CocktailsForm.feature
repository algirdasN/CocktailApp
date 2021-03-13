@Cocktails
Feature: Cocktails form
	Testing functionality of Cocktails form

@Back
Scenario: Go back to Main window
	Given I navigated to Cocktails window
	When I click Back button
	Then Only Main window should be displayed

@Exit
Scenario: Exit the application
	Given I navigated to Cocktails window
	When I click Exit button
	Then Application should close