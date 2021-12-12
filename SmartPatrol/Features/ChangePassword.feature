Feature: Change Password
	Check the changing password

@smoke @positive
Scenario: Change the password successfully
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	| P@ssw0rd        | P@ssw0rd    | P@ssw0rd           |
	Then I click SaveChangePassword button for success
	And I Should see the ChangePasswordConfirmation message


@smoke @negative
Scenario: validate the OldPassword mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	|                 | P@ssw0rd    | P@ssw0rd           |
	Then I click SaveChangePassword button
	And I Should see the ChangePassrequiredFieldError message


@smoke @negative
Scenario: validate the NewPassword mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	|   P@ssw0rd      |             | P@ssw0rd           |
	Then I click SaveChangePassword button
	And I Should see the ChangePassrequiredFieldError message



@smoke @negative
Scenario: validate the ConfirmNewPassword mandatory field
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	|     P@ssw0rd    | P@ssw0rd    |                    |
	Then I click SaveChangePassword button
	And I Should see the ChangePassrequiredFieldError message


@smoke @negative
Scenario: verify the Current password
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	| admin           | P@ssw0rd    | P@ssw0rd           |
	Then I click SaveChangePassword button
	And I Should see the OldPasswordError message


	
@smoke @negative
Scenario: verify that the new password and confirm password are matched
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	| P@ssw0rd        |  admin      | P@ssw0rd           |
	Then I click SaveChangePassword button
	And I Should see the MatchingPasswordError message


@smoke @negative
Scenario: verify that the new password Complexity Max Length 8
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	| P@ssw0rd        |  admin      | admin              |
	Then I click SaveChangePassword button
	And I Should see the MaxLength message


@smoke @negative
Scenario: verify that the new password Complexity Contain Numbers
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	| P@ssw0rd        |  adminadmin | adminadmin         |
	Then I click SaveChangePassword button
	And I Should see the ContainNumbers message


@smoke @negative
Scenario: verify that the new password Complexity Contain Special Characters 
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword  | ConfirmNewPassword |
	| P@ssw0rd        | adminadmin123| adminadmin123      |
	Then I click SaveChangePassword button
	And I Should see the ContainSpecialCharacters message


@smoke @negative
Scenario: verify that the new password Complexity Contain Upper Case Letters  
	Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword   | ConfirmNewPassword |
	| P@ssw0rd        | adminadmin123@| adminadmin123@     |
	Then I click SaveChangePassword button
	And I Should see the ContainUpperCaseLetters message




@smoke @negative
Scenario: verify that the new password Complexity Contain Lower Case Letters  
Given I Have navigated to the application
	And I see application opened
	When I enter username and password
	| username | password |
	| awafeek  | P@ssw0rd |
	Then I Click login button and see the dashboardpage
	And I Click the username button
	Then click the changepassword link
	And I enter Current password, New password and Confirm new password
	| CurrentPassword | NewPassword | ConfirmNewPassword |
	| P@ssw0rd        | 12345678@M  | 12345678@M         |
	Then I click SaveChangePassword button
	And I Should see the ContainLowerCaseLetters message
