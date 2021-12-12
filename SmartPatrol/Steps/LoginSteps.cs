using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartPatrol.Pages;
using SmartPatrolFramework.Base;
using SmartPatrolFramework.Configuration;
using SmartPatrolFramework.Helpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowSmartPatrol.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {

        private readonly ParallelConfig _parallelConfig;

        public LoginSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        
        [Then(@"I should see the language label")]
        public void ThenIShouldSeeTheLanguageLabel()
        {
            if (_parallelConfig.CurrentPage.As<DashboardPage>().GetLanguage().Contains("EN"))
                System.Console.WriteLine("Sucess login");
            else
                System.Console.WriteLine("Unsucessful login");

        }



        [Then(@"I Check remember me Option")]
        public void ThenICheckRememberMeOption()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().SelectRememberMe();
        }

        [Then(@"I Close the browser")]
        public void ThenICloseTheBrowser()
        {
            _parallelConfig.Driver.Close();
            //if (_parallelConfig.Driver != null)
            //{
            //    _parallelConfig.Driver.Close();

            //_parallelConfig.Driver.Quit();

            //_parallelConfig.Driver.Dispose();
        }



            //try
            //{
            //    _parallelConfig.Driver.Close();
            //}
            //catch
            //{
            //    _parallelConfig.Driver.Dispose();
            //}
        


        [Then(@"I Click login button")]
        [When(@"I Click login button")]
        public void WhenIClickLoginButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickLoginButtonFailed();
        }

        //[Given(@"I Redirected to the application")]
        //public void GivenIRedirectedToTheApplication()
        //{
        //    NavigateSite();

        //}








        //[Then(@"I should see the Dashboard Page")]
        //public void ThenIShouldSeeTheDashboardPage()
        //{
        //    //  _parallelConfig.CurrentPage =
        //    //_parallelConfig.CurrentPage.As<DashboardPage>().GetLanguage();
        //    //if (_parallelConfig.CurrentPage.As<DashboardPage>().GetLanguage().Contains("english"))
        //    //    System.Console.WriteLine("Sucess login");
        //    //else
        //    //    System.Console.WriteLine("Unsucessful login");

        //    var DashboardPage = _parallelConfig.CurrentPage.As<DashboardPage>();

        //    // Make your assertion:
        //    Assert.AreEqual("EN", DashboardPage.GetLanguage());
        //}







        //[Then(@"I Close the browser")]
        //public void ThenICloseTheBrowser()
        //{
        //    try
        //    {
        //        _parallelConfig.Driver.Close();
        //    }
        //    catch
        //    {
        //        _parallelConfig.Driver.Dispose();
        //    }
        //    // _parallelConfig.Driver.Quit();
        //}









    }
}
