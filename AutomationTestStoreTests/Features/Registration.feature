Feature: User Registration


Scenario: Successful User Registration
	Given User navigates to registration page
    When User enters registration details
	| FirstName | LastName | Address   | City      | Country | State     | ZipCode | Password |
	| Sarthak   | Mathur   | Bangalore | Bangalore | India   | Karnataka | 560001  | Test@123 |
    And User accepts privacy policy
    And User submits registration form
    Then User account should be created successfully
