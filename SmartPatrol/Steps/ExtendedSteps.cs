using System;
using SmartPatrol.Pages;
using SmartPatrolFramework.Base;
using SmartPatrolFramework.Configuration;
using SmartPatrolFramework.Helpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowSmartPatrol.Steps
{
    [Binding]
    internal class ExtendedSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public ExtendedSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        public virtual void NavigateSite()
        {
            //string url = "http://devpatrol.getgroup.com/";

            //another login by settings
            _parallelConfig.Driver.Navigate().GoToUrl(Settings.AUT);
            //DriverContext.Browser.GoToUrl(url);
            _parallelConfig.Driver.Manage().Window.Maximize();
            LogHelper.Write("Navigated to the login page");
        }


        //[Then(@"I Have navigated to the application")]
        [Given(@"I Have navigated to the application")]
        public void IHaveNavigatedToTheApplication()
        {
            NavigateSite();
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
        }

        [Then(@"I redirected to the application")]
        public void ThenIRedirectedToTheApplication()
        {

           
           // string url = "http://devpatrol.getgroup.com/";

            //another login by settings
            _parallelConfig.Driver.Navigate().GoToUrl(Settings.AUT);
            //DriverContext.Browser.GoToUrl(url);
            _parallelConfig.Driver.Manage().Window.Maximize();
        }


        [Then(@"I see application opened")]
        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            _parallelConfig.CurrentPage.As<LoginPage>().CheckIfLoginExist();
        }



        [Then(@"I enter username and password")]
        [When(@"I enter username and password")]
        public void WhenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<LoginPage>().Login(data.username, data.password);
        }


        [Then(@"I Click login button and see the dashboardpage")]
        public void ThenIClickLoginButtonAndSeeTheDashboardpage()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickLoginButton();
        }


      
        [Then(@"I Should see the (.*) message")]
        public void ThenIShouldSeeTheMessage(String msg)
        {
            if (msg == "InvalidCredential")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ShowInvalidCredMsg();
            //else if (msg == "ExpiredPassword")
            //    _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ShowExpiredPasswordMsg();
            else if (msg == "LimitedHours")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ShowLimitedHoursMsg();
            else if (msg == "FirstLogin")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ShowFirstLoginMsg();
            else if (msg == "requiredFieldError")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ShowrequiredFieldErrorMsg();
            else if (msg == "ExpiredAccount")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ShowExpAccMsg();
            else if (msg == "DisabledAccount")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ShowDisAccMsg();
            else if (msg == "ChangePasswordConfirmation")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowChangePassConfirmMsg();
            else if (msg == "ChangePassrequiredFieldError")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowrequiredFieldErrorMsg();
            else if (msg == "OldPasswordError")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowOldPasswordErrorMsg();
            else if (msg == "MatchingPasswordError")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowMatchingPasswordErrorMsg();
            else if (msg == "MaxLength")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowMaxLengthMsg();
            else if (msg == "ContainNumbers")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowContainNumbersMsg();
            else if (msg == "ContainSpecialCharacters")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowContainSpecialCharactersMsg();
            else if (msg == "ContainUpperCaseLetters")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowContainUpperCaseLettersMsg();
            else if (msg == "ContainLowerCaseLetters")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ShowContainLowerCaseLettersMsg();
            else if (msg == "UsernameValidation")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateUserPage>().ShowUsernameValidationsMsg();
            else if (msg == "EmailValidation")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateUserPage>().ShowEmailValidationsMsg();
            else if (msg == "ArabicRoleNameValidation")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateRolePage>().ShowArabicRoleNameValidationMsg();
            else if (msg == "EnglishRoleNameValidation")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateRolePage>().ShowEnglishRoleNameValidationMsg();
            else if (msg == "requiredFieldsError")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateUserPage>().ShowrequiredFieldsErrorMsg();
            else if (msg == "ValidateEmail")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowValidateEmailMsg();
            else if (msg == "EmailRequiredField")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowEmailRequiredMsg();
            else if (msg == "WrongEmail")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowWrongEmailMsg();
            //else if (msg == "confirmationResetPassword")
            //    _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowConResetPassMsg();
            else if (msg == "ConSendLink")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowConSendLinkMsg();
            else if (msg == "ExpiryLink")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowExpiryLinkMsg();
            else if (msg == "ForgotPassrequiredFieldError")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowForgotPassReqFieldMsg();
            else if (msg == "ForgotMatchingPasswordError")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowForgotMatchingPassMsg();
            else if (msg == "ForgotMaxLength")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowForgotMaxLengthMsg();
            else if (msg == "ForgotContainNumbers")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowContainNumMsg();
            else if (msg == "ForgotContainSpecialCharacters")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowForgotSpecialCharMsg();
            else if (msg == "ForgotContainUpperCaseLetters")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowForgotUpperCaseMsg();
            else if (msg == "ForgotContainLowerCaseLetters")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ShowForgotLowerCaseMsg();

            
        }

        [Then(@"I Click the (.*) link")]
        public void ThenIClickTheLink(string linkName)
        {
            if (linkName == "Security")
           _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<DashboardPage>().ClickSecurity();
            else if (linkName == "AddUser")
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<UsersPage>().ClickAddUser();
            else if (linkName == "Roles")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<SecurityPage>().ClickRoles();
            else if (linkName == "AddRole")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<RolesPage>().ClickAddRole();
            else if (linkName == "Users")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<SecurityPage>().ClickUsers();


        }





    }




  




    //    [Then(@"I Click (.*) button")]
    //    public void ThenIClickButton(string buttonName)
    //    {
    //        if (buttonName == "login")
    //            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickLoginButton();

    //        else if (buttonName == "createnew")
    //            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<UsersPage>().ClickCreateNew();
    //        else if (buttonName == "Next")
    //            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateUserPage>().ClickNextButton();
    //        else if (buttonName == "Save")
    //            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateUserPage>().ClickSaveButton();

    //    }

    //    [Then(@"I Click (.*) link")]
    //    public void ThenIClickLink(string linkName)
    //    {
    //        

    //        else if (linkName == "user")
    //        _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<UsersPage>().ClickCreateNew();
    //    }
    //}
}
