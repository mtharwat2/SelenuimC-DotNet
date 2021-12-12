using SmartPatrol.Pages;
using SmartPatrolFramework.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SmartPatrol.Steps
{

    [Binding]
    internal class ForgotPasswordSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public ForgotPasswordSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [Then(@"I click the reset password link")]
        public void ThenIClickTheResetPasswordLink()
        {
            string url = "http://devpatrol.getgroup.com/login/reset?email=mtharwat@getgroup.com&token=CfDJ8JXuOrRZZ%2bdBh39wF%2fxP4y2mVRwnWpup0UsOA2X4qmU%2bUn4o9nCjLPdMdrsexRVe6LYvjAB%2bYwxWmTlkfHwrImaDh%2b9yX5vl5UmMBRAEAQE%2by%2bNT8%2bh7n4pJ%2fXj5kCD89sAQWt9%2beJkyWR9pu3KFuuuuN8TEyxRyMOMyeF4j81HlLZA6EQFImOrMFQkZsUnVv8JfpCX4jXOr7uLLpKwzhAfWlL00l%2bMGxkUjs28yXf1k";

            //another login by settings
            _parallelConfig.Driver.Navigate().GoToUrl(url);
            //DriverContext.Browser.GoToUrl(url);
            _parallelConfig.Driver.Manage().Window.Maximize();
            
        }


        [Then(@"I click the Expired reset password link")]
        public void ThenIClickTheExpiredResetPasswordLink()
        {
            string url = "http://devpatrol.getgroup.com/login/reset?email=mtharwat@getgroup.com&token=CfDJ8JXuOrRZZ%2bdBh39wF%2fxP4y0iJ%2bljaf0m9AW9J%2fTMacmTX51Ue6gDRKkGBZ%2bBMc5tfrObjhNgMq8YP8V96%2bKRQ6m%2fJT2H9An0gUYx4LdphsCIjoMu09xAJB0TZE76WHBvAHbJmum%2bzOMEDlNX%2bDvblj4HLfU3Prn%2bx%2f3Ibmc3mmLUUaRWtYwVpl5KrmH4nNKamYLHPn1jala3Uxi7uM9EJXeKdeCSBPH4%2bDwXErkpLs04";

            //another login by settings
            _parallelConfig.Driver.Navigate().GoToUrl(url);
            //DriverContext.Browser.GoToUrl(url);
            _parallelConfig.Driver.Manage().Window.Maximize();
        }


        [Then(@"I see the Reset Password Page")]
        public void ThenISeeTheResetPasswordPage()
        {
            _parallelConfig.CurrentPage.As<ForgotPasswordPage>().CheckIfPasswordExist();
        }


        [Then(@"I enter New password and Confirm new password")]
        public void ThenIEnterNewPasswordAndConfirmNewPassword(Table table)
        {

            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ResetPassword(data.NewPassword, data.ConfirmPassword);
        }

        [Then(@"I Click the Save button and see the Login Page")]
        public void ThenIClickTheSaveButtonAndSeeTheLoginPage()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ClickSave();
        }

        
        

        [When(@"I click ForgotPassword button and see the ForgotPassword Page")]
        public void WhenIClickForgotPasswordButtonAndSeeTheForgotPasswordPage()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickForgotpassword();
        }


        [Then(@"I enter the Email")]
        public void ThenIEnterTheEmail(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ForgotPassword(data.Email);
        }

       

        [Then(@"I click the Arabic button")]
        public void ThenIClickTheArabicButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickArabic();
        }

        [Then(@"I Click the English button")]
        public void ThenIClickTheEnglishButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickEnglish();
        }

       
        [Then(@"I Click the SendLink button")]
        public void ThenIClickTheSendLinkButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ForgotPasswordPage>().ClickSendLink();
        }


    }
}
