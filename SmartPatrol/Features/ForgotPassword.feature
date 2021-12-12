Feature: ForgotPassword
	Simple calculator for adding two numbers

@mytag @positive
Scenario: Reset the password successfully
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword | ConfirmPassword |
    | Test123@         | Test123@      |
	Then I Click the Save button and see the Login Page
	And I Should see the confirmationResetPassword message
	Then I enter username and password
	| username | password |
	| marian   | Test123@ |
	Then I Click login button and see the dashboardpage


@mytag @positive
Scenario: Login with the old password after Reset Password
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword | ConfirmPassword |
    | Test123@         | Test123@      |
	Then I Click the Save button and see the Login Page
	And I Should see the confirmationResetPassword message
	Then I enter username and password
	| username | password |
	| marian   | P@ssw0rd |
	Then I Click login button
	And I Should see the InvalidCredential message 


@mytag @negative
Scenario: Verify the link Expiration
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword | ConfirmPassword |
    | Test123@         | Test123@      |
	Then I Click the SendLink button 
	And I Should see the ExpiryLink message


@smoke @negative
Scenario: verify the mail format
	Given I Have navigated to the application
	And I see application opened
	Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email  |
	| marian |
	And I Should see the ValidateEmail message



@smoke @negative
Scenario: verify the email mandatory field
	Given I Have navigated to the application
	And I see application opened
	Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I Click the SendLink button
	And I Should see the EmailRequiredField message



@smoke @negative
Scenario: verify the email exist in the DB
	Given I Have navigated to the application
	And I see application opened
	Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email  |
	| marian@getgroup.com |
	And I Click the SendLink button
	And I Should see the WrongEmail message




@mytag @negative
Scenario: Verify the NewPassword mandatory field
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword | ConfirmPassword |
    |             | Test123@      |
	Then I Click the SendLink button 
	And I Should see the ForgotPassrequiredFieldError message


@mytag @negative
Scenario: Verify the ConfirmPassword mandatory field
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword | ConfirmPassword |
    |  Test123@   |                 |
	Then I Click the SendLink button 
	And I Should see the ForgotPassrequiredFieldError message




@smoke @negative
Scenario: verify that the new password and confirm password are matched
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	 | NewPassword | ConfirmPassword |
     |  admin      | P@ssw0rd        |
	Then I Click the SendLink button
	And I Should see the ForgotMatchingPasswordError message


@smoke @negative
Scenario: verify that the new password Complexity Max Length 8
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword | ConfirmPassword |
	|  admin      | admin           |
	Then I Click the SendLink button
	And I Should see the ForgotMaxLength message


@smoke @negative
Scenario: verify that the new password Complexity Contain Numbers
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword | ConfirmPassword |
	|  adminadmin | adminadmin      |
	Then I Click the SendLink button
	And I Should see the ForgotContainNumbers message


@smoke @negative
Scenario: verify that the new password Complexity Contain Special Characters 
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword | ConfirmPassword |
	| adminadmin123| adminadmin123  |
	Then I Click the SendLink button
	And I Should see the ForgotContainSpecialCharacters message


@smoke @negative
Scenario: verify that the new password Complexity Contain Upper Case Letters  
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword   | ConfirmPassword |
	| adminadmin123@| adminadmin123@  |
	Then I Click the SendLink button
	And I Should see the ForgotContainUpperCaseLetters message



@smoke @negative
Scenario: verify that the new password Complexity Contain Lower Case Letters  
	Given I Have navigated to the application
	And I see application opened
    Then I click the Arabic button
	And I Click the English button
	When I click ForgotPassword button and see the ForgotPassword Page
	Then I enter the Email
	| Email |
	| mtharwat@getgroup.com |
	And I Click the SendLink button
	And I Should see the ConSendLink message
	Then I click the Expired reset password link
	And I see the Reset Password Page
	Then I enter New password and Confirm new password
	| NewPassword   | ConfirmPassword |
	| 12345678@M    | 12345678@M      |
	Then I Click the SendLink button
	And I Should see the ForgotContainLowerCaseLetters message



