

using SmartPatrol.Pages;
using SmartPatrolFramework.Base;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SmartPatrol.Steps
{
    [Binding]
    internal class DataValidationForUsersAndRolesSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public DataValidationForUsersAndRolesSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        [When(@"I enter the UserName and Email")]
        public void WhenIEnterTheUserNameAndEmail(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<CreateUserPage>().AddUserName(data.UserName, data.Email);
        }



        [When(@"I enter the ArabicName and EnglishName")]
        public void WhenIEnterTheArabicNameAndEnglishName(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<CreateRolePage>().AddRoleName(data.ArabicName, data.EnglishName);
        }



       




    }
}
