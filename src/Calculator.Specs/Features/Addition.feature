Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given the calculator is running

@UserInterface
Scenario Outline: Add two numbers together
	Given I have entered <left> into the calculator
	And I have entered <right> into the calculator
	When I press add
	Then the result should be <result> on the screen

	Examples: 
	| left | right | result |
	| 50   | 70    | 120    |
	| 20   | 30    | 50     |
	| 60   | 30    | 90     |
	| 80   | 90    | 170    |
