Feature: MSTestContext
	Having the TestContext available will allow for a lot more automation flexibility
	for when integrating the test suit with Microsoft Test Manager

Scenario: MS Test Context available in the scenario context
	When this scenario is generated
	Then the scenario context contains a key of MSTestContext
