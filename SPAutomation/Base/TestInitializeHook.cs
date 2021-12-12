using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using SmartPatrolFramework.Configuration;
using SmartPatrolFramework.Helpers;
using TechTalk.SpecFlow;


namespace SmartPatrolFramework.Base
{

    public class TestInitializeHook : Steps
    {
        private readonly ParallelConfig _parallelConfig;

        public TestInitializeHook(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        public void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Set Log
            LogHelper.CreateLogFile();

            //Open Browser
            OpenBrowser(GetBrowserOption(Settings.BrowserType));

            LogHelper.Write("Initialized framework");

        }

        
        private void OpenBrowser(DriverOptions driverOptions)
        {
            

            switch (driverOptions)
            {
                case EdgeOptions edgeOptions:

                    driverOptions = new EdgeOptions();
                    
                    break;
                
                case ChromeOptions chromeOptions:
                   // chromeOptions.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);

                    chromeOptions.AddAdditionalOption(CapabilityType.EnableProfiling, true);

                    break;
            }

            _parallelConfig.Driver = new RemoteWebDriver(new Uri("http://10.4.4.2:4444"), driverOptions.ToCapabilities());

        }

       // private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
       //{
            

       //     switch (browserType)
       // {
       //     case BrowserType.InternetExplorer:
       //             _parallelConfig.Driver = new EdgeDriver();
       //        // DriverContext.Browser = new Browser(DriverContext.Driver);
       //         break;
       //     case BrowserType.Chrome:
       //             _parallelConfig.Driver = new
       //             ();
       //         //DriverContext.Browser = new Browser(DriverContext.Driver);
       //         break;
       //     default:
       //             _parallelConfig.Driver = new ChromeDriver();
       //        // DriverContext.Browser = new Browser(DriverContext.Driver);
       //         break;
       // }
       //}

        public virtual void NavigateSite()
        {
            //DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelper.Write("Opened the browser !!!");
        }

        public DriverOptions GetBrowserOption(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.MSEdge:
                    return new EdgeOptions();
                case BrowserType.Chrome:
                    return new ChromeOptions();
                default:
                    return new ChromeOptions();
            }
        }

    }
}
