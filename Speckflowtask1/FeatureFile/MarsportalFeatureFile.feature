Feature: MarsportalFeatureFile
	
Scenario: Verify whether the user is able to login to the portal using valid cresentials.
	Given I navigate to the Mars portal
	When  I click on Sign in button and enter valid email id and password
	Then  The user is able to click on Login button and loginto the portal

Scenario: Verify whether the user is able to enter language details in profile page

	Given I login to the portal using valid credentials
	When  I click on Add New button in language tab and enter language, language level details and click on Add
	Then  The user is able to add language details and navigate to skills tab

Scenario: Verify whether the user is able to enter skills details in profile page
	Given I login to the portal using valid credentials
	When  I enter language details and navigate to skills tab from language tab and click on Add New button
	And   I enter skills, skills level details and click on Add
	Then  The user is able to add skills details

Scenario: Verify whether the user is able to enter education details in profile page
	Given I login to the portal using valid credentials.
	When  I navigate to Education tab from Skills tab and click on Add New button.
	And   I enter college name, country,title, degree, year details and  click on Add.
	Then  The user is able to add the education details

Scenario: Verify whether the user is able to enter certifications details in profile page
	Given I login to the Mars portal using valid credentials
	When  I navigate to certifications tab from educations tab and click on Add New button.
	And   I enter certificate, certificate from, year details and click on Add.
	Then  The user is able to add certifications details and display on profile page.

Scenario: Verify whether the user is able to verify the details entered in profile page.

	Given I login to the portal using valid credentials.
	When  I enter all the details in profile page(language,skills,education and certifications).
	And   I sign Out of the portal and Login again.
	Then  The user is able to see the details entered by the seller in profile page.


