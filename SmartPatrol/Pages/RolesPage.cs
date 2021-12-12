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
    internal class RolesPage : BasePage
    {
        public RolesPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }



        
        IWebElement BtnEditRoleFirst => _parallelConfig.Driver.FindElement(By.Id("edit-row-0"));
        IWebElement BtndeleteRole => _parallelConfig.Driver.FindElement(By.Id("delete-row-0"));
        IWebElement BtnAddRole => _parallelConfig.Driver.FindElement(By.Id("add-new"));

        IWebElement BtnFirstRole => _parallelConfig.Driver.FindElement(By.XPath("/html/body/app-root/app-layout/div/main/section/app-security/p-tabview/div/div/p-tabpanel/div/app-list-roles/div/section/div[2]/div/p-table/div/div/table/tbody/tr[1]/td[1]/p-tablecheckbox/div/div[2]"));
        
        IWebElement BtnSecondRole => _parallelConfig.Driver.FindElement(By.XPath("/html/body/app-root/app-layout/div/main/section/app-security/p-tabview/div/div/p-tabpanel/div/app-list-roles/div/section/div[2]/div/p-table/div/div/table/tbody/tr[2]/td[1]/p-tablecheckbox/div/div[2]"));

        IWebElement BtnDeleteAllRole => _parallelConfig.Driver.FindElement(By.Id("delete-all"));

        

        public RolesPage ClickAddRole()
        {

            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkAddRole = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("add-new")));
            lnkAddRole.Click();

            return new RolesPage(_parallelConfig);
        }

        internal void CheckIfAddRoleExist()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BtnAddRole = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("add-new")));
            BtnAddRole.AssertElementPresent();
        }

        internal bool CheckIfAddRoleNotExist()
        {
            try
            {
                bool ele = BtnAddRole.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }
        

        internal void CheckIfEditRoleExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();


            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BtnEditRole = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit-row-0")));
            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtnEditRole).Perform();
            BtnEditRole.AssertElementPresent();
        }

        internal void CheckIfDeleteRoleExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();


            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BtndeleteRole = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("delete-row-0")));
            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtndeleteRole).Perform();
            BtndeleteRole.AssertElementPresent();

        }



        internal bool CheckIfEditRoleNotExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();


            try
            {
                bool ele = BtnEditRoleFirst.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }



        }

        internal bool CheckIfDeleteRoleNotExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();


            try
            {
                bool ele = BtndeleteRole.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        public RolesPage SelectMultipleRoles()
        {

            
            BtnFirstRole.Click();
            BtnSecondRole.Click();

            return new RolesPage(_parallelConfig);
        }

        internal void CheckIfDeleteAllRolesExist()
        {
            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtnDeleteAllRole).Perform();
            BtnDeleteAllRole.AssertElementPresent();
        }
        
    }
}
