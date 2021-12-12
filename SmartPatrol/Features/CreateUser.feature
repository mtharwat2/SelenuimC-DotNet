Feature: Create Users
	Responsible for Add , Edit Delete users and check if the functionality works

Background: 
	#Given I Delete User 'Marian' before I start running test

@smoke @positive
Scenario: Create User with all details
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Click the AddUser link
	And I enter following details
	| EnglishName     | ArabicName | UserName  | Email              | Usertype      |
	| Marian          |  ماريان   | marianTest| Marian@test.com    | Administrator |
	Then I Click the Next button
	#And I should see the UserRoles tab
	#And I Select the UserRole
	#Then I Click the Next button
	#And I Click the Save button




@smoke @negative
Scenario: validate the EnglishName mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Click the AddUser link
	And I enter following details
	| EnglishName     | ArabicName | UserName  | Email              | Usertype      |
	|                 |  ماريان    | marianTest| Marian@test.com    | Administrator |
	Then I Click the Next button
	And I Should see the requiredFieldsError message


@smoke @negative
Scenario: validate the ArabicName mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Click the AddUser link
	And I enter following details
	| EnglishName     | ArabicName | UserName  | Email              | Usertype      |
	|  Marian         |            | marianTest| Marian@test.com    | Administrator |
	Then I Click the Next button
	And I Should see the requiredFieldsError message


@smoke @negative
Scenario: validate the UserName mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Click the AddUser link
	And I enter following details
	| EnglishName     | ArabicName | UserName  | Email              | Usertype      |
	|  Marian         |     ماريان |           | Marian@test.com    | Administrator |
	Then I Click the Next button
	And I Should see the requiredFieldsError message


@smoke @negative
Scenario: validate the Email mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Click the AddUser link
	And I enter following details
	| EnglishName     | ArabicName | UserName  | Email  | Usertype      |
	|  Marian         |    ماريان | marianTest |       | Administrator |
	Then I Click the Next button
	And I Should see the requiredFieldsError message
	 

@smoke @negative
Scenario: validate the Usertype mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Click the AddUser link
	And I enter following details
	| EnglishName     | ArabicName | UserName   | Email              | Usertype      |
	|  Marian         |     ماريان | marianTest| Marian@test.com    |                |
	Then I Click the Next button
	And I Should see the requiredFieldsError message


@smoke @positive
Scenario: Search by valid Role in the Roles List
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Click the AddUser link
	And I enter following details
	| EnglishName     | ArabicName | UserName          | Email              | Usertype      |
	| AutomateTest    |  ماريان   | marianAutomateTest| Marian@test.com    | Administrator |
	Then I Click the Next button
	And I should see the UserRoles tab
	And I enter the role in search field
	| search  |
	| Everyone|
	Then I Should see the search result


@smoke @negative
Scenario: Search by invalid Role in the Roles List
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Click the AddUser link
	And I enter following details
	| EnglishName     | ArabicName | UserName          | Email              | Usertype      |
	| AutomateTest    |  ماريان   | marianAutomateTest| Marian@test.com    | Administrator |
	Then I Click the Next button
	And I should see the UserRoles tab
	And I enter the role in search field
	| search  |
	| TestTest|
	Then I Should not see the search result
