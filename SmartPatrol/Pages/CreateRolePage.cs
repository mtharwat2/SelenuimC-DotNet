using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SmartPatrolFramework.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPatrol.Pages
{
    internal class CreateRolePage : BasePage
    {
        public CreateRolePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        IWebElement txtArabicName => _parallelConfig.Driver.FindElement(By.Id("arabicName"));
        IWebElement txtEnglishName => _parallelConfig.Driver.FindElement(By.Id("englishName"));

        internal void AddRoleName(string arabicName, string englishName)
        {
            txtArabicName.SendKeys(arabicName);
            txtEnglishName.SendKeys(englishName);
        }

        public CreateRolePage ShowArabicRoleNameValidationMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement ArabicRoleNameMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/section/app-role/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = ArabicRoleNameMsg.Displayed;
            Assert.IsTrue(M, "Arabic role name already exists in the system, please input a different value!");
            return new CreateRolePage(_parallelConfig);
        }

        public CreateRolePage ShowEnglishRoleNameValidationMsg()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement EnglishRoleNameMsg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/section/app-role/p-toast/div/p-toastitem/div/div/div/div[2]")));

            bool M = EnglishRoleNameMsg.Displayed;
            Assert.IsTrue(M, "English role name already exists in the system, please input a different value!");
            return new CreateRolePage(_parallelConfig);
        }

        

    }

}
