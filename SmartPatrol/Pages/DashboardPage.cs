using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

using SmartPatrolFramework.Base;
using SmartPatrolFramework.Extensions;

namespace SmartPatrol.Pages
{
    class DashboardPage : BasePage
    {

        public DashboardPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
        }


        //IWebElement lnkSecurity => DriverContext.Driver.FindElement(By.Id("security"));


        IWebElement lnkLanguage => _parallelConfig.Driver.FindElement(By.Id("english"));




       internal string GetLanguage()
        {
            return lnkLanguage.GetLinkText();
        }

        public DashboardPage ClickUsername()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BtnUsername = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("header_buttons")));
            BtnUsername.Click();
            return new DashboardPage(_parallelConfig);
        }



        public ChangePasswordPage ClickChangePassword()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement LnkChangePassword = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("password")));
            LnkChangePassword.Click();
            return new ChangePasswordPage(_parallelConfig);
        }


        

        public SecurityPage ClickSecurity()
        {

            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(100));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement TabSecurity = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("security")));
            TabSecurity.Click();
            return new SecurityPage(_parallelConfig);
        }


        internal void CheckIfSecurityExist()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(100));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement TabSecurity = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("security")));
            TabSecurity.AssertElementPresent();
        }

        

    }


    
}
