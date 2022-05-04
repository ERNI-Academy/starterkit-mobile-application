@Appiumdriver
@ErniMobileMAUI
@AndroidDriver
Feature: AndroidTest

Scenario: Testing android language refresh
	Given the user navigates to 'Language' page
	When user updates language to 'Spanish'
	Then language updated popup appears