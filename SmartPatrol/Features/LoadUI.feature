Feature: LoadUI
	Check UI screens are loaded based on user's assigned privileges

@smoke @positive
Scenario: Check Security, Roles and Users is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Roles tab
	And I Should see the Users tab




@smoke @negative
Scenario: Check Security and Roles tab is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityRoles  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Roles tab
	And I Should not see the Users tab
	And I Click the Roles link
	Then I Should see the AddRole button
	And I Should see the EditRole button
	And I Should see the DeleteRole button



@smoke @negative
Scenario: Check Security and Roles tab View only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityRolesView  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Roles tab
	Then I Should not see the Users tab
	And I Click the Roles link
	Then I Should not see the AddRole button
	And I Should not see the EditRole button
	And I Should not see the DeleteRole button


@smoke @negative
Scenario: Check Security and Roles tab add only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityRolesAdd  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Roles tab
	Then I Should not see the Users tab
	And I Click the Roles link
	Then I Should see the AddRole button
	And I Should not see the EditRole button
	And I Should not see the DeleteRole button



@smoke @negative
Scenario: Check Security and Roles tab Edit only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityRolesEdit  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Roles tab
	Then I Should not see the Users tab
	And I Click the Roles link
	Then I Should not see the AddRole button
	And I Should see the EditRole button
	And I Should not see the DeleteRole button




@smoke @negative
Scenario: Check Security and Roles tab Delete only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityRolesDelete  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Roles tab
	Then I Should not see the Users tab
	And I Click the Roles link
	Then I Should not see the AddRole button
	And I Should not see the EditRole button
	And I Should see the DeleteRole button
	Then I Select the FirstRole and SecondRole
	And I Should see the DeleteAllRole button


@smoke @negative
Scenario: Check Security and Users tab is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityUsers  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Users tab
	And I Should not see the Roles tab
	And I Click the Users link
	Then I Should see the AddUser button
	And I Should see the EditUser button
	And I Should see the DeleteUser button
	And I Should see the DeactivateUser button


@smoke @negative
Scenario: Check Security and Users tab View only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityUsersView  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Users tab
	Then I Should not see the Roles tab
	And I Click the Users link
	Then I Should not see the AddUser button
	And I Should not see the EditUser button
	And I Should not see the DeleteUser button
	And I Should not see the DeactivateUser button



@smoke @negative
Scenario: Check Security and Users tab Add only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityUsersAdd  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Users tab
	Then I Should not see the Roles tab
	And I Click the Users link
	Then I Should see the AddUser button
	And I Should not see the EditUser button
	And I Should not see the DeleteUser button
	And I Should not see the DeactivateUser button


@smoke @negative
Scenario: Check Security and Users tab Edit only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityUsersEdit  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Users tab
	Then I Should not see the Roles tab
	And I Click the Users link
	Then I Should not see the AddUser button
	And I Should see the EditUser button
	And I Should not see the DeleteUser button
	And I Should not see the DeactivateUser button



@smoke @negative
Scenario: Check Security and Users tab Delete only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityUsersDelete  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Users tab
	Then I Should not see the Roles tab
	And I Click the Users link
	Then I Should not see the AddUser button
	And I Should not see the EditUser button
	And I Should see the DeleteUser button
	Then I Select the FirstUser and SecondUser
	And I Should see the DeleteAllUsers button
	And I Should not see the DeactivateUser button



@smoke @negative
Scenario: Check Security and Users tab Deactivate only is Exist upon granted privileges
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username       | password |
	| SecurityUsersDeactivate  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Should see the Security tab
	Then I Click the Security link
	And I Should see the Users tab
	Then I Should not see the Roles tab
	And I Click the Users link
	Then I Should not see the AddUser button
	And I Should not see the EditUser button
	And I Should not see the DeleteUser button
	And I Should not see the DeactivateUser button
	Then I Select the Activated Users
	And I Should see the DeactivateAllUser button