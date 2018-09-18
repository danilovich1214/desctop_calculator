Feature: CalculatorCalculation
	In order to avoid silly mistakes	
	I want to be told the sum of number and MR

Scenario Outline: Addition number to memory number
	Given I open the calculator application in <ViewName> View	
	When I have entered 12 into the calculator
	And I add the number 999
	And I add the result to the memory
	And I have entered 19 into the calculator
	And I add current result to the memory number
	Then The result should be 1030
Examples: 
	| ViewName   |
	| Standard   |
	| Scientific |