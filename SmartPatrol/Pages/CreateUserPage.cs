
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SmartPatrolFramework.Base;
using SmartPatrolFramework.Extensions;
using System;

namespace SmartPatrol.Pages
{
    internal class CreateUserPage : BasePage
    {
        public CreateUserPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        //IWebElement txtEnglishName => _parallelConfig.Driver.FindElement(By.Id("englishName"));
        IWebElement txtArabicName => _parallelConfig.Driver.FindElement(By.Id("arabicName"));
        IWebElement txtUsername => _parallelConfig.Driver.FindElement(By.Id("username"));
        IWebElement txtEmail => _parallelConfig.Driver.FindElement(By.Id("email"));

        //IWebElement selectUserType => _parallelConfig.Driver.FindElement(By.CssSelector("[class='ng-star-inserted']"));
        IWebElement selectUserTypeAdministrator => _parallelConfig.Driver.FindElement(By.CssSelector("/html/body/app-root/app-layout/div/main/section/app-user/section/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[1]/div/div/div[5]/div/div/div/div/span/p-dropdown/div/div[3]/div[2]/ul/p-dropdownitem[2]/li/span"));

        IWebElement btnNext => _parallelConfig.Driver.FindElement(By.Id("mainNextBtn"));
        //IWebElement selectRole => _parallelConfig.Driver.FindElement(By.Id("roleEveryone"));
        IWebElement btnsave => _parallelConfig.Driver.FindElement(By.CssSelector("[Class='btn btn-primary w-100']"));

        IWebElement lnkUserRoles => _parallelConfig.Driver.FindElement(By.CssSelector("[class= 'p-tabview-nav']"));


        IWebElement TxtUserRole => _parallelConfig.Driver.FindElement(By.CssSelector("[class= 'w-100 p-inputtext p-component']"));


        IWebElement lnkSearchUserRole => _parallelConfig.Driver.FindElement(By.Id("roleEveryone"));
        


        internal void CreateNewUser(string englishName, string arabicName, string username, string email, string userType)
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement txtEnglishName = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("englishName")));

            txtEnglishName.SendKeys(englishName);
            txtArabicName.SendKeys(arabicName);
            txtUsername.SendKeys(username);
            txtEmail.SendKeys(email);


            WebDriverWait waitUserType = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitUserType.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement selectUserType = waitUserType.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/section/app-user/section/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[1]/div/div/div[5]/div/div[1]/div/div/span/p-dropdown/div/div[2]/span")));
            selectUserType.Click();

            selectUserTypeAdministrator.Click();
        }

        internal void AddUserName(string username, string email)
        {
            txtUsername.SendKeys(username);
            txtEmail.SendKeys(email);
        }


        public CreateUserPage ShowUsernameValidationsMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement UserNameValMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/section/app-user/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = UserNameValMsg.Displayed;
            Assert.IsTrue(M, "Username already exists in the system, please input a different value!");
            return new CreateUserPage(_parallelConfig);
        }



        public CreateUserPage ShowEmailValidationsMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement EmailValMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/section/app-user/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = EmailValMsg.Displayed;
            Assert.IsTrue(M, "Email already exists in the system, please input a different value!");
            return new CreateUserPage(_parallelConfig);
        }

        public CreateUserPage ShowrequiredFieldsErrorMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ReqFieldsMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/section/app-user/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = ReqFieldsMsg.Displayed;
            Assert.IsTrue(M, "Fill all required fields");
            return new CreateUserPage(_parallelConfig);
        }

        

        internal string GetUserRoleTab()
        {
            return lnkUserRoles.GetLinkText();
        }


        

        public CreateUserPage SelectTheRole()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement selectRole = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("roleEveryone")));

            selectRole.Click();
            return new CreateUserPage(_parallelConfig);
        }

        public CreateUserPage ClickNextButton()
        {
            btnNext.Submit();
            return new CreateUserPage(_parallelConfig);
        }



        public CreateUserPage ClickSaveButton()
        {
            btnsave.Submit();
            return new CreateUserPage(_parallelConfig);
        }

        internal void SearchUserRole(string userRole)
        {
            TxtUserRole.SendKeys(userRole);
        }

        internal string GetSearchUserRole()
        {
            return lnkSearchUserRole.GetLinkText();
        }
    }
}
