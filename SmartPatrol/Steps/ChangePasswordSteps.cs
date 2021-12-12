using SmartPatrol.Pages;
using SmartPatrolFramework.Base;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SmartPatrol.Steps
{
    [Binding]
    internal class ChangePasswordSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public ChangePasswordSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [Then(@"I Click the username button")]
        public void ThenIClickTheButton()
        {
            
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<DashboardPage>().ClickUsername();
            
           
        }

        [Then(@"I click SaveChangePassword button")]
        public void ThenIClickSaveChangePasswordButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ClickSaveChangePassButtonFailed();
        }



        [Then(@"I click SaveChangePassword button for success")]
        public void ThenIClickSaveChangePasswordButtonForSuccess()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChangePasswordPage>().ClickSaveChangePassButton();
        }

        [Then(@"click the changepassword link")]
        public void ThenClickTheChangepasswordLink()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<DashboardPage>().ClickChangePassword();
        }

        [Then(@"I enter Current password, New password and Confirm new password")]
        public void ThenIEnterCurrentPasswordNewPasswordAndConfirmNewPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<ChangePasswordPage>().ChangePassword(data.CurrentPassword, data.NewPassword, data.ConfirmNewPassword);
        }

       


    }
}
