using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SmartPatrolFramework.Base;
using SmartPatrolFramework.Extensions;

namespace SmartPatrol.Pages
{
   internal class LoginPage : BasePage
    {
        public LoginPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
        }

        IWebElement Txtname => _parallelConfig.Driver.FindById("name");

        IWebElement Txtpassword => _parallelConfig.Driver.FindElement(By.Id("password"));

        IWebElement Btnlogin => _parallelConfig.Driver.FindElement(By.Id("login"));

        //IWebElement InvalidCredMsg => _parallelConfig.Driver.FindElement(By.XPath("/html/body/app-root/app-login/p-toast/div"));
        

        IWebElement ChBoxRemember => _parallelConfig.Driver.FindElement(By.Id("rememberMe"));

        // IWebElement ExpPassMsg => _parallelConfig.Driver.FindElement(By.CssSelector("span[class='p-confirm-dialog-message ng-tns-c69-1']"));
        //"span[class='p-confirm-dialog-message ng-tns-c69-1']

        IWebElement BtnForgotPass => _parallelConfig.Driver.FindElement(By.Id("forgot"));

        IWebElement BtnEnglish => _parallelConfig.Driver.FindElement(By.Id("english"));

        IWebElement BtnArabic => _parallelConfig.Driver.FindElement(By.Id("arabic"));
        

        public LoginPage ShowInvalidCredMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement InvalidCredMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-login/p-toast/div")));
            InvalidCredMsg.GetLinkText();
            bool b = InvalidCredMsg.Displayed;
            Assert.IsTrue(b, "Invalid Credentials.");
            return new LoginPage(_parallelConfig);

        }

        public LoginPage ShowExpiredPasswordMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ExpPassMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("span[class='p-confirm-dialog-message ng-tns-c69-1']")));
           
            bool M = ExpPassMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "Your password has expired and must be changed.");
            return new LoginPage(_parallelConfig);

        }


        public LoginPage ShowLimitedHoursMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement LimHrsMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-login/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = LimHrsMsg.Displayed;
            _parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "Your account has time restrictions that prevent you from signing in at this time. Please try again later");
            return new LoginPage(_parallelConfig);
        }


        public LoginPage ShowFirstLoginMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement FirstLoginMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-login/p-confirmdialog/div/div/div[2]/span")));

            bool M = FirstLoginMsg.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(M, "Your password must be changed before signing in.");
            return new LoginPage(_parallelConfig);
        }

       
        public LoginPage ShowrequiredFieldErrorMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ReqField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div[class='error-text ng-star-inserted']")));

            bool RF = ReqField.Displayed;
            //_parallelConfig.Driver.Quit();
            Assert.IsTrue(RF, "Required field");
            return new LoginPage(_parallelConfig);

        }

        public LoginPage ShowExpAccMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ExpAccMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-login/p-toast/div")));

            bool M = ExpAccMsg.Displayed;
            Assert.IsTrue(M, "Your account has expired. Please contact your system administrator.");
            return new LoginPage(_parallelConfig);
        }

        public LoginPage ShowDisAccMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement DisAccMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-login/p-toast/div")));

            bool M = DisAccMsg.Displayed;
            Assert.IsTrue(M, "Your account has been disabled. Please contact your system administrator.");
            return new LoginPage(_parallelConfig);
        }


        public LoginPage SelectRememberMe()
        {
            ChBoxRemember.Click();
            return new LoginPage(_parallelConfig);
        }
        //[FindsBy(How = How.Id , Using = "security")]
        //public IWebElement TabSecurity { get; set; }



        //[FindsBy(How = How.Id, Using = "name")]
        //IWebElement Txtname { get; set; }

        //[FindsBy(How = How.Id, Using = "password")]

        //IWebElement Txtpassword { get; set; }

        //[FindsBy(How = How.Id, Using = "login")]

        //IWebElement Btnlogin { get; set; }

        public void Login(string userName, string password)
        {
            Txtname.SendKeys(userName);
            Txtpassword.SendKeys(password);
           // Btnlogin.Submit();
        }

        //internal BasePage ClickLoginButton()
        //{
        //    Btnlogin.Submit();
        //    return new DashboardPage(_parallelConfig);
        //}


        public DashboardPage ClickLoginButton()
        {
            Btnlogin.Submit();
            return new DashboardPage(_parallelConfig);
        }

        public LoginPage ClickLoginButtonFailed()
        {
            Btnlogin.Submit();
            return new LoginPage(_parallelConfig);
        }

        

        internal void CheckIfLoginExist()
        {
            Txtname.AssertElementPresent();
        }


        public ForgotPasswordPage ClickForgotpassword()
        {
            //WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            //IWebElement BtnForgotPass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("forgot")));


            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtnForgotPass).Perform();
            BtnForgotPass.Click();
            return new ForgotPasswordPage(_parallelConfig);
        }

        public LoginPage ClickEnglish()
        {

            BtnEnglish.Click();
            return new LoginPage(_parallelConfig);
        }

        public LoginPage ClickArabic()
        {

            BtnArabic.Click();
            return new LoginPage(_parallelConfig);
        }

        

        //public LoginPage ShowWarningMsg()
        //{
        //    InvalidCredMsg.AssertElementPresent();
        //    return new LoginPage(_parallelConfig);
        //}
    }
}
