Feature: Data validation for users and roles
	Check that the validation of Users Username,Email and Role Arabic / English Name

@smoke @positive
Scenario: Check the duplication for Username
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I should see the language label
	And I Click the Security link
	Then I Click the AddUser link
	When I enter the UserName and Email
	 | UserName  | Email              | 
	 | awafeek   | Marian@test.com    | 
	#And I Click the Next button
    Then I Should see the UsernameValidation message




@smoke @positive
Scenario: Check the duplication for Email
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I should see the language label
	And I Click the Security link
	Then I Click the AddUser link
	When I enter the UserName and Email
     | UserName       | Email                   | 
	 | AutomateTest   | awafeek@example.com     |  
    And I Click the Next button
	Then I Should see the EmailValidation message
    



@smoke @positive
Scenario: Check the duplication for Arabic Role Name
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I should see the language label
	And I Click the Security link
	Then I Click the Role link
	Then I Click the AddRole link
	When I enter the ArabicName and EnglishName
         | ArabicName |EnglishName |
         | امن النظام |AutomateTesting |
    #And I Click the Next button
	Then I Should see the ArabicRoleNameValidation message
    



@smoke @positive
Scenario: Check the duplication for English Role Name
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I should see the language label
	And I Click the Security link
	Then I Click the Role link
	Then I Click the Addrole link
	When I enter the ArabicName and EnglishName
         | ArabicName | EnglishName |
         | اوتوميتتست| Security |
    And I Click the Next button
	Then I Should see the EnglishRoleNameValidation message
