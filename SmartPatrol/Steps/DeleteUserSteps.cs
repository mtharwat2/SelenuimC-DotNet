using SmartPatrol.Pages;
using SmartPatrolFramework.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SmartPatrol.Steps
{
    [Binding]
    internal class DeleteUserSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public DeleteUserSteps (ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        [Then(@"I Check the Users List")]
        public void ThenICheckTheUsersList()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<UsersPage>().GetUsersList();
        }

        [Then(@"I Navigate to the username")]
        public void ThenINavigateToTheUsername(Table table)
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"I Click the Delete button")]
        public void ThenIClickTheDeleteButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<UsersPage>().ClickDeleteUser();
        }

    }
}
