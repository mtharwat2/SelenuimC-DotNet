using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SmartPatrolFramework.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPatrol.Pages
{
    class ChangePasswordPage : BasePage
    {
        public ChangePasswordPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }


        //IWebElement TxtCurrentPass => _parallelConfig.Driver.FindElement(By.Id("oldPassword"));

        IWebElement TxtNewPass => _parallelConfig.Driver.FindElement(By.Id("newPassword"));

        IWebElement TxtConNewPass => _parallelConfig.Driver.FindElement(By.Id("confirmPassword"));

        IWebElement BtnSaveChangePass => _parallelConfig.Driver.FindElement(By.CssSelector("button[class='btn btn-primary w-100']"));



        public void ChangePassword(string CurrentPassword, string NewPassword, string ConfirmNewPassword)
        {


            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(100));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement TxtCurrentPass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("oldPassword")));


            TxtCurrentPass.SendKeys(CurrentPassword);
            TxtNewPass.SendKeys(NewPassword);
            TxtConNewPass.SendKeys(ConfirmNewPassword);
        }

        public ChangePasswordPage ClickSaveChangePassButton()
        {
            BtnSaveChangePass.Submit();
            return new ChangePasswordPage(_parallelConfig);
        }

        public ChangePasswordPage ClickSaveChangePassButtonFailed()
        {
            BtnSaveChangePass.Submit();
            return new ChangePasswordPage(_parallelConfig);
        }

        public DashboardPage ShowChangePassConfirmMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ChPassConMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = ChPassConMsg.Displayed;
            Assert.IsTrue(M, "Password changed");
            return new DashboardPage(_parallelConfig);
        }


        public ChangePasswordPage ShowrequiredFieldErrorMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ReqField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool RF = ReqField.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(RF, "Required field");
            return new ChangePasswordPage(_parallelConfig);

        }

        public ChangePasswordPage ShowOldPasswordErrorMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement oldPasswordError = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/section/app-change-password/p-toast/div")));

            bool M = oldPasswordError.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "Wrong old password");
            return new ChangePasswordPage(_parallelConfig);

        }

        public ChangePasswordPage ShowMatchingPasswordErrorMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement matchingPasswordError = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = matchingPasswordError.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "Password does not match");
            return new ChangePasswordPage(_parallelConfig);

        }


        public ChangePasswordPage ShowMaxLengthMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement MaxLengthMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = MaxLengthMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Minimum length:  8 ");
            return new ChangePasswordPage(_parallelConfig);

        }

        public ChangePasswordPage ShowContainNumbersMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ContainNumbersMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ContainNumbersMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Must contain numbers ");
            return new ChangePasswordPage(_parallelConfig);

        }

        public ChangePasswordPage ShowContainSpecialCharactersMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ContainSpecialCharactersMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ContainSpecialCharactersMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Must contain special characters ");
            return new ChangePasswordPage(_parallelConfig);

        }

        public ChangePasswordPage ShowContainUpperCaseLettersMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ContainUpperCaseLettersMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ContainUpperCaseLettersMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Must contain upper case letters ");
            return new ChangePasswordPage(_parallelConfig);

        }

        public ChangePasswordPage ShowContainLowerCaseLettersMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ContainUpperCaseLettersMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool M = ContainUpperCaseLettersMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, " Must contain lower case letters ");
            return new ChangePasswordPage(_parallelConfig);

        }

        
    }
}
