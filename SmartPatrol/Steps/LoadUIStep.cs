using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartPatrol.Pages;
using SmartPatrolFramework.Base;
using TechTalk.SpecFlow;

namespace SmartPatrol.Steps
{
    [Binding]
    internal class LoadUIStep : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public LoadUIStep(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        [Then(@"I Should see the Security tab")]
        public void ThenIShouldSeeTheSecurityTab()
        {
            _parallelConfig.CurrentPage.As<DashboardPage>().CheckIfSecurityExist();
        }



        [Then(@"I Should see the Roles tab")]
        public void ThenIShouldSeeTheRolesTab()
        {
            _parallelConfig.CurrentPage.As<SecurityPage>().CheckIfRolesExist();
        }

        [Then(@"I Should see the Users tab")]
        public void ThenIShouldSeeTheUsersTab()
        {
            _parallelConfig.CurrentPage.As<SecurityPage>().CheckIfUsersExist();
        }



        [Then(@"I Should not see the Users tab")]
        public void ThenIShouldNotSeeTheUsersTab()
        {
           _parallelConfig.CurrentPage.As<SecurityPage>().CheckIfUsersNotExist();
            
        }

        [Then(@"I Should not see the Roles tab")]
        public void ThenIShouldNotSeeTheRolesTab()
        {
            _parallelConfig.CurrentPage.As<SecurityPage>().CheckIfRolesNotExist();
        }


        [Then(@"I Should see the AddRole button")]
        public void ThenIShouldSeeTheAddRoleButton()
        {
            _parallelConfig.CurrentPage.As<RolesPage>().CheckIfAddRoleExist();
        }


        [Then(@"I Should not see the AddRole button")]
        public void ThenIShouldNotSeeTheAddRoleButton()
        {
            _parallelConfig.CurrentPage.As<RolesPage>().CheckIfAddRoleNotExist();
        }


        [Then(@"I Should see the EditRole button")]
        public void ThenIShouldSeeTheEditButton()
        {
            _parallelConfig.CurrentPage.As<RolesPage>().CheckIfEditRoleExist();
        }

        [Then(@"I Should see the DeleteRole button")]
        public void ThenIShouldSeeTheDeleteButton()
        {
            _parallelConfig.CurrentPage.As<RolesPage>().CheckIfDeleteRoleExist();
        }

        [Then(@"I Should not see the EditRole button")]
        public void ThenIShouldNotSeeTheEditRoleButton()
        {
            _parallelConfig.CurrentPage.As<RolesPage>().CheckIfEditRoleNotExist();
        }

        [Then(@"I Should not see the DeleteRole button")]
        public void ThenIShouldNotSeeTheDeleteRoleButton()
        {
            _parallelConfig.CurrentPage.As<RolesPage>().CheckIfDeleteRoleNotExist();
        }

        [Then(@"I Select the FirstRole and SecondRole")]
        public void ThenISelectTheFirstRoleAndSecondRole()
        {
            _parallelConfig.CurrentPage.As<RolesPage>().SelectMultipleRoles();
        }

        [Then(@"I Should see the DeleteAllRole button")]
        public void ThenIShouldSeeTheDeleteAllRoleButton()
        {
            _parallelConfig.CurrentPage.As<RolesPage>().CheckIfDeleteAllRolesExist();
        }

        [Then(@"I Should see the AddUser button")]
        public void ThenIShouldSeeTheAddUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfAddUserExist();
        }

        [Then(@"I Should see the EditUser button")]
        public void ThenIShouldSeeTheEditUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfEditUserExist();
        }

        [Then(@"I Should see the DeleteUser button")]
        public void ThenIShouldSeeTheDeleteUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfDeleteUserExist();
        }

        [Then(@"I Should see the DeactivateUser button")]
        public void ThenIShouldSeeTheDeactivateUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfDeactivateUserExist();
        }

        [Then(@"I Should not see the AddUser button")]
        public void ThenIShouldNotSeeTheAddUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfAddUserNotExist();
        }

        [Then(@"I Should not see the EditUser button")]
        public void ThenIShouldNotSeeTheEditUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfEditUserNotExist();
        }

        [Then(@"I Should not see the DeleteUser button")]
        public void ThenIShouldNotSeeTheDeleteUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfDeleteUserNotExist();
        }

        [Then(@"I Should not see the DeactivateUser button")]
        public void ThenIShouldNotSeeTheDeactivateUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfDeactivateUserNotExist();
        }


        [Then(@"I Should see the DeleteAllUsers button")]
        public void ThenIShouldSeeTheDeleteAllUsersButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfDeleteAllUsersExist();
        }

        [Then(@"I Select the FirstUser and SecondUser")]
        public void ThenISelectTheFirstUserAndSecondUser()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().SelectMultipleUsers();
        }

        [Then(@"I Select the Activated Users")]
        public void ThenISelectTheActivatedUsers()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().SelectActivatedUsers();
        }


        [Then(@"I Should see the DeactivateAllUser button")]
        public void ThenIShouldSeeTheDeactivateAllUserButton()
        {
            _parallelConfig.CurrentPage.As<UsersPage>().CheckIfDeactivateAllUsersExist();
        }



    }
}
