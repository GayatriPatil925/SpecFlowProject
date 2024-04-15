Feature: Doing some calculation 

Aruthmatic operation

@tag1
Scenario: Doing Addition
	Given I have nos as "<num1>" and "<num2>" 
	When I add those nos 
	Then I should print the result
Examples: 
| num1 | num2 |
| 10   | 20   |
| 30   | 40   |