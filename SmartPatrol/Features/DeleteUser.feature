Feature: Delete User
	

@smoke @positive
Scenario: Delete User
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the Security link
	Then I Check the Users List
	#And I Navigate to the username
	#| username   |
	#| marianTest |
	And I Click the Delete button
	#Then I Should see the DeleteValConfirmation message
	#And I Click the Ok button
	#Then I Should see the DeleteConfirmation message
	#And I Chcek the User List and the user is not exist