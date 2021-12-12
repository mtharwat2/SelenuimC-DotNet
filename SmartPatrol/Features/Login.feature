Feature: Login
	Check if the login functionality is working
	as expected with different permutations and combinations of data

Background: 
	#Given 

@smoke @positive
Scenario: Check Login with correct username and password
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	Then I should see the language label


@smoke @negative
Scenario: Check Login with wrong username and password
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | admin    |
	Then I Click login button
	And I Should see the InvalidCredential message
	


#@smoke @positive
#Scenario: Check Login by expired password
#	Given I Have navigated to the application
#	And I see application opened
#	When I enter username and password
#	| username         | password |
#	| ExpiredPassword  | P@ssw0rd |
#	Then I Click login button
#	And I Should see the ExpiredPassword message



@smoke @positive
Scenario: Check Login with Remember me Option
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Check remember me Option
	And I Click login button and see the dashboardpage									 
	Then I Close the browser
	And I redirected to the application
	Then I see application opened
	Then I should see the language label


@smoke @positive
Scenario: Check login when the account is disabled
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username         | password |
	| DisabledAccount  | P@ssw0rd |
	Then I Click login button
	And I Should see the DisabledAccount message


@smoke @positive
Scenario: Check login when the time limitation encountered
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username      | password |
	| LimitedHours  | P@ssw0rd |
	Then I Click login button
	And I Should see the LimitedHours message


@smoke @positive
Scenario: Check user should change his password after first login
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username    | password |
	| FirstLogin  | P@ssw0rd |
	Then I Click login button
	And I Should see the FirstLogin message


@smoke @negative
Scenario: validate the username mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  |          |
	And I Click login button
	Then I Should see the requiredFieldError message


@smoke @negative
Scenario: validate the password mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	|          | P@ssw0rd  |
	And I Click login button
	Then I Should see the requiredFieldError message


@smoke @positive
Scenario: Check Login by expired account
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username      | password |
	| ExpiredAccount| P@ssw0rd |
	Then I Click login button
	And I Should see the ExpiredAccount message