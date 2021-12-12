using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SmartPatrolFramework.Base;
using SmartPatrolFramework.Extensions;

namespace SmartPatrol.Pages
{
    internal class SecurityPage : BasePage
    {
        public SecurityPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }


        IWebElement TabUsers => _parallelConfig.Driver.FindElement(By.Id("user-tab"));

        IWebElement TabRoles => _parallelConfig.Driver.FindElement(By.Id("role-tab"));



        public IWebElement GetUsersList()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement tblUsersList = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("user-table")));


            return tblUsersList;
        }

        internal void CheckIfRolesExist()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement TabRoles = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("role-tab")));
            TabRoles.AssertElementPresent();
        }

        internal void CheckIfUsersExist()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement TabUsers = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("user-tab")));
            TabUsers.AssertElementPresent();
        }

        internal bool CheckIfUsersNotExist()
        {
            
            try
            {
                bool ele = TabUsers.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        




        internal bool CheckIfRolesNotExist()
        {
            try
            {
                bool ele = TabRoles.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }



        public RolesPage ClickRoles()
        {

            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement TabRoles = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("role-tab")));
            TabRoles.Click();
            return new RolesPage(_parallelConfig);

        }

        public UsersPage ClickUsers()
        {

            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement TabUsers = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-tabview-nav-link p-ripple']")));
            TabUsers.Click();
            return new UsersPage(_parallelConfig);

        }

        
    }
}



           
            
