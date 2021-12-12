using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SmartPatrolFramework.Base;
using SmartPatrolFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPatrol.Pages
{
    class ForgotPasswordPage : BasePage
    {
        public ForgotPasswordPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }


        //IWebElement TxtEmail => _parallelConfig.Driver.FindElement(By.Id("email"));

        IWebElement BtnSendLink => _parallelConfig.Driver.FindElement(By.CssSelector("[class='btn btn-primary w-100']"));
        




        public void ForgotPassword(string email)
        {


            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement TxtEmail = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("email")));


            TxtEmail.SendKeys(email);
            
        }

        public ForgotPasswordPage ShowValidateEmailMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ValidateEmailMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ValidateEmailMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "Enter a valid email");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowEmailRequiredMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ValidateEmailMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool RF = ValidateEmailMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(RF, "Required field");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowWrongEmailMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement WrongEmailMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-verify-email/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = WrongEmailMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "The email that you specified is not in the system. Please input a valid email!");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ClickSendLink()
        {
            BtnSendLink.Click();
            return new ForgotPasswordPage(_parallelConfig);
        }


        IWebElement TxtNewPass => _parallelConfig.Driver.FindElement(By.Id("newPassword"));

        IWebElement TxtConPass => _parallelConfig.Driver.FindElement(By.Id("confirmPassword"));


        internal void CheckIfPasswordExist()
        {
            TxtNewPass.AssertElementPresent();
        }


        public ForgotPasswordPage ResetPassword(string NewPassword, string ConfirmPassword)
        {
            TxtNewPass.SendKeys(NewPassword);
            TxtConPass.SendKeys(ConfirmPassword);
            return new ForgotPasswordPage(_parallelConfig);
        }

        public LoginPage ClickSave()
        {
            BtnSendLink.Click();
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ConResetPassMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = ConResetPassMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "The Password is reset successfully.");
            return new LoginPage(_parallelConfig);
        }


       

        public ForgotPasswordPage ShowConSendLinkMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ConResetPassMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-verify-email/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = ConResetPassMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "An email has been sent for resetting your password.");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowExpiryLinkMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ConResetPassMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-reset-password/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = ConResetPassMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "Invalid link used / link expired");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowForgotPassReqFieldMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ReqField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool RF = ReqField.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(RF, "Required field");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowForgotMatchingPassMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ForgotMatchingPass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ForgotMatchingPass.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Password does not match ");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowForgotMaxLengthMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ForgotMatchingPass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ForgotMatchingPass.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Minimum length:  8 ");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowContainNumMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ForgotMatchingPass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ForgotMatchingPass.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Must contain numbers ");
            return new ForgotPasswordPage(_parallelConfig);
        }


        public ForgotPasswordPage ShowForgotSpecialCharMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ForgotMatchingPass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ForgotMatchingPass.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Must contain special characters ");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowForgotUpperCaseMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ForgotMatchingPass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ForgotMatchingPass.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Must contain upper case letters ");
            return new ForgotPasswordPage(_parallelConfig);
        }

        public ForgotPasswordPage ShowForgotLowerCaseMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ForgotMatchingPass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ForgotMatchingPass.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "Must contain lower case letters");
            return new ForgotPasswordPage(_parallelConfig);
        }
        
    }
}
