using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SmartPatrolFramework.Base;
using SmartPatrolFramework.Extensions;
using SmartPatrolFramework.Helpers;

namespace SmartPatrol.Pages
{
    internal class UsersPage : BasePage
    {
        public UsersPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
        }

        IWebElement BtnAddUser => _parallelConfig.Driver.FindElement(By.Id("add-new"));
        IWebElement tblUsersList => _parallelConfig.Driver.FindElement(By.Id("user-table"));

        IWebElement BtnEditFirstUser => _parallelConfig.Driver.FindElement(By.Id("edit-row-0"));

        IWebElement BtndeleteFirstUser => _parallelConfig.Driver.FindElement(By.Id("delete-row-0"));

        IWebElement BtndeactivateFirstUser => _parallelConfig.Driver.FindElement(By.Id("block-row-0"));

        IWebElement BtnFirstUser => _parallelConfig.Driver.FindElement(By.XPath("/html/body/app-root/app-layout/div/main/section/app-security/p-tabview/div/div/p-tabpanel[1]/div/app-list-users/div/section/div[2]/div/p-table/div/div/table/tbody/tr[1]/td[1]/p-tablecheckbox/div/div[2]"));

        IWebElement BtnSecondUser => _parallelConfig.Driver.FindElement(By.XPath("/html/body/app-root/app-layout/div/main/section/app-security/p-tabview/div/div/p-tabpanel[1]/div/app-list-users/div/section/div[2]/div/p-table/div/div/table/tbody/tr[2]/td[1]/p-tablecheckbox/div/div[2]"));

        IWebElement BtnDeleteAllUsers => _parallelConfig.Driver.FindElement(By.Id("delete-all-selected"));


        IWebElement BtnDeactivateAllUsers => _parallelConfig.Driver.FindElement(By.Id("block-all-selected"));

        //IWebElement Status => _parallelConfig.Driver.FindElement(By.CssSelector("[class='green_dot']"));

        public CreateUserPage ClickAddUser()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkAddUser = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("add-new")));
            lnkAddUser.Click();
            return new CreateUserPage(_parallelConfig);
        }


        //public IWebElement GetUsersList()
        //{
        //    return tblUsersList;
        //}

        public UsersPage GetUsersList()
        {
            //var table = CurrentPage.As<EmployeePage>().GetEmployeeList();

            HtmlTableHelper.ReadTable(tblUsersList);


            return new UsersPage(_parallelConfig);
        }
        

        public UsersPage ClickDeleteUser()
        {



            //WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            //IWebElement BtnDelete = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-layout/div/main/section/app-security/p-tabview/div/div/p-tabpanel[1]/div/app-list-users/div/section/div[2]/div/p-table/div/div/table/tbody/tr[3]/td[9]/div/div/span[3]/img")));
            //BtnDelete.Click();
            //HtmlTableHelper.ReadTable(tblUsersList);
            HtmlTableHelper.PerformActionOnCell("8", "User name", "testuser", "Delete");
            return new UsersPage(_parallelConfig);
        }

        internal void CheckIfAddUserExist()
        {
            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BtnAddUser = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("add-new")));
            BtnAddUser.AssertElementPresent();
        }

        internal bool CheckIfAddUserNotExist()
        {
            try
            {
                bool ele = BtnAddUser.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        

        internal void CheckIfEditUserExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();


            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BtnEditUser = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit-row-0")));
            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtnEditUser).Perform();
            BtnEditUser.AssertElementPresent();
        }

        internal bool CheckIfEditUserNotExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();
            try
            {
                bool ele = BtnEditFirstUser.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        

        internal void CheckIfDeleteUserExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();


            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BtndeleteUser = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("delete-row-0")));
            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtndeleteUser).Perform();
            BtndeleteUser.AssertElementPresent();

        }

        public UsersPage SelectMultipleUsers()
        {
            BtnFirstUser.Click();
            BtnSecondUser.Click();

            return new UsersPage(_parallelConfig);
        }

        internal void CheckIfDeleteAllUsersExist()
        {
            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtnDeleteAllUsers).Perform();
            BtnDeleteAllUsers.AssertElementPresent();
        }


        internal void CheckIfDeactivateAllUsersExist()
        {
            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtnDeactivateAllUsers).Perform();
            BtnDeactivateAllUsers.AssertElementPresent();
        }

        



        internal bool CheckIfDeleteUserNotExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();
            try
            {
                bool ele = BtndeleteFirstUser.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        internal void CheckIfDeactivateUserExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();


            WebDriverWait wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BtndeactivateUser = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("block-row-0")));
            Actions actions = new Actions(_parallelConfig.Driver);
            actions.MoveToElement(BtndeactivateUser).Perform();
            BtndeactivateUser.AssertElementPresent();

        }


        internal bool CheckIfDeactivateUserNotExist()
        {
            WebDriverWait waitF = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(10));
            waitF.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement lnkFirstRow = waitF.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("[class='p-column-data ng-star-inserted']")));
            Actions actionsNew = new Actions(_parallelConfig.Driver);
            actionsNew.MoveToElement(lnkFirstRow).Perform();
            try
            {
                bool ele = BtndeactivateFirstUser.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        public UsersPage SelectActivatedUsers()
        {
            String before_xpath = "/html/body/app-root/app-layout/div/main/section/app-security/p-tabview/div/div/p-tabpanel[1]/div/app-list-users/div/section/div[2]/div/p-table/div/div/table/tbody/tr[";
            String after_xpath = "]/td[9]/span[2]";

            for (int i = 1; i <= 5; i++)
            {
                String status = _parallelConfig.Driver.FindElement(By.XPath(before_xpath + i + after_xpath)).GetLinkText();

                //string status = _parallelConfig.Driver.FindElement(By.XPath(before_xpath + i + after_xpath)).GetLinkText();
                Console.WriteLine(status);
                if (status.Equals("active"))
                {
                    _parallelConfig.Driver.FindElement(By.XPath("/html/body/app-root/app-layout/div/main/section/app-security/p-tabview/div/div/p-tabpanel[1]/div/app-list-users/div/section/div[2]/div/p-table/div/div/table/tbody/tr[" + i + "]/td[1]/p-tablecheckbox/div/div[2]")).Click();
                }
            }

            //for (int i = 1; i <= 10; i++)
            //{

            //    string status = _parallelConfig.Driver.FindElement(By.CssSelector("[class='green_dot']")).GetLinkText();
            //    if (status.Contains("active"))
            //    {
            //        _parallelConfig.Driver.FindElement(By.XPath("/html/body/app-root/app-layout/div/main/section/app-security/p-tabview/div/div/p-tabpanel[1]/div/app-list-users/div/section/div[2]/div/p-table/div/div/table/tbody/tr[" + i + "]/td[1]/p-tablecheckbox/div/div[2]")).Click();
            //    }



            //}



            return new UsersPage(_parallelConfig);
        }

        






    }

}

