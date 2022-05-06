@WinAppDriver
@ErniMobileUWP
Feature: WindowsTest

Scenario: Testing windows language refresh
	Given the user navigates to 'Language' page
	When user updates language to 'Spanish'
	Then language updated popup appears