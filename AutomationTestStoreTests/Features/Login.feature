Feature: Login

#discreption: This feature represents a login function of an application positive scenarios as well as negetive scenarios.


Scenario: Successful Login
	Given User launches the application
	When User navigates to login page
	And User enters username "sarthakmathur"
	And User enters password "sarthak@123"
	And User clicks on login button
	Then User should be logged in successfully
