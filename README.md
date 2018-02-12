# Valtech_QA_Automation_challenge_RF

I used 'Visual Studio Community 2017' edition for this test. For the purpose of this test, I used Object Oriented Programming C# language. The .cs files can be accessed by selecting ValTechTest.cs to see the script.
To execute the project, download the zip file: ValtechTestChallengeRF.zip and extract is to your local drive.
Launch the *ValtechTestChallengeRF.sln* solution in Visual Studio. To run the test use 'Test Explorer' and Select [TestMethod1], right click to run selected test.

For the purpose of this test and time contraints, I found the solution was sufficient as it covered all the required validations using C# assert statements. I chose to create a TDD format Unit Test file with TestMethods to validate the test run. Elements were found by using XPath and Class names selenium locators. Used implicit waits for the browser to load in 10 seconds before moving on to next steps of the test. 

Challenges:
Contact Us locations were in Countries and Cities. Best solution was to use FindElements in a List, store in a collection and output the results using WriteLine method.

Given more time, the framework can be enhanced using Page Object model and inheritance for regression.
