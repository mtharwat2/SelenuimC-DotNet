using System;
using System.Collections.Generic;
using System.Text;
using SmartPatrol.Pages;
using SmartPatrolFramework.Base;
using SmartPatrolFramework.Configuration;
using SmartPatrolFramework.Helpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowSmartPatrol.Steps
{
    [Binding]
    class CreateUserSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        public CreateUserSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }


        [Given(@"I Delete User '(.*)' before I start running test")]
        public void GivenIDeleteUserBeforeIStartRunningTest(string userName)
        {
            string query = "delete from Employees where Name = '" + userName + "'";
            Settings.ApplicationCon.ExecuteQuery(query);
        }


        //[When(@"I enter following details")]
        [Then(@"I enter following details")]
        public void ThenIEnterFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<CreateUserPage>().CreateNewUser(data.EnglishName,
            data.ArabicName, data.UserName, data.Email, data.Usertype.ToString());

        }



        [Then(@"I Click the Next button")]
        [When(@"I Click the Next button")]
        public void WhenIClickTheNextButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateUserPage>().ClickNextButton();
        }


        [Then(@"I should see the UserRoles tab")]
        public void ThenIShouldSeeTheUserRolesTab()
        {

            if (_parallelConfig.CurrentPage.As<CreateUserPage>().GetUserRoleTab().Contains("User Roles"))
                System.Console.WriteLine("Navigate to User Roles tab");
            else
                System.Console.WriteLine("Unsucessful Navigation to User Roles tab");
            
            
        }


        [Then(@"I Click the Save button")]
        public void ThenIClickTheSaveButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreateUserPage>().ClickSaveButton();
        }


        [Then(@"I Select the UserRole")]
        public void ThenISelectTheUserRole()
        {
            _parallelConfig.CurrentPage.As<CreateUserPage>().SelectTheRole();
        }

        [Then(@"I enter the role in search field")]
        public void ThenIEnterTheRoleInSearchField(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<CreateUserPage>().SearchUserRole(data.search);
        }

        [Then(@"I Should see the search result")]
        public void ThenIShouldSeeTheSearchResult()
        {
            if (_parallelConfig.CurrentPage.As<CreateUserPage>().GetSearchUserRole().Contains("Everyone"))
                System.Console.WriteLine("Success Search Result");
            else
                System.Console.WriteLine("Unsucessful Search Result");
        }

        [Then(@"I Should not see the search result")]
        public void ThenIShouldNotSeeTheSearchResult()
        {
            if (_parallelConfig.CurrentPage.As<CreateUserPage>().GetSearchUserRole().Equals(""))
                System.Console.WriteLine("Success Search Result");
            else
                System.Console.WriteLine("Unsucessful Search Result");
        }


    }
}
