using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using SmartPatrolFramework.Base;

using static SmartPatrolFramework.Base.Browser;

namespace SmartPatrolFramework.Configuration
{
    public class ConfigReader
    {
        //public static void SetFrameworkSettings()
        //    {

        //        XPathItem aut;
        //        XPathItem testtype;
        //        XPathItem islog;
        //        XPathItem isreport;
        //        XPathItem buildname;
        //        XPathItem logPath;
        //    XPathItem appConnection;

        //        string strFilename = Environment.CurrentDirectory.ToString() + "\\Configuration\\GlobalConfig.xml";
        //        FileStream stream = new FileStream(strFilename, FileMode.Open);
        //        XPathDocument document = new XPathDocument(stream);
        //        XPathNavigator navigator = document.CreateNavigator();

        //        //Get XML Details and pass it in XPathItem type variables
        //        aut = navigator.SelectSingleNode("SmartPatrolFramework/RunSettings/AUT");
        //        buildname = navigator.SelectSingleNode("SmartPatrolFramework/RunSettings/BuildName");
        //        testtype = navigator.SelectSingleNode("SmartPatrolFramework/RunSettings/TestType");
        //        islog = navigator.SelectSingleNode("SmartPatrolFramework/RunSettings/IsLog");
        //        isreport = navigator.SelectSingleNode("SmartPatrolFramework/RunSettings/IsReport");
        //        logPath = navigator.SelectSingleNode("SmartPatrolFramework/RunSettings/LogPath");
        //    appConnection = navigator.SelectSingleNode("SmartPatrolFramework/RunSettings/ApplicationDb");

        //    //Set XML Details in the property to be used accross framework
        //    Settings.AUT = aut.Value.ToString();
        //        Settings.BuildName = buildname.Value.ToString();
        //        Settings.TestType = testtype.Value.ToString();
        //        Settings.IsLog = islog.Value.ToString();
        //        Settings.IsReporting = isreport.Value.ToString();
        //        Settings.LogPath = logPath.Value.ToString();
        //    Settings.AppConnectionString = appConnection.Value.ToString();
        //    }

        public static void SetFrameworkSettings()
        {

            var _builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");


            IConfigurationRoot configurationRoot = _builder.Build();


            Settings.AUT = configurationRoot.GetSection("testSettings").Get<TestSettings>().AUT;
            Settings.TestType = configurationRoot.GetSection("testSettings").Get<TestSettings>().TestType;
            Settings.IsLog = configurationRoot.GetSection("testSettings").Get<TestSettings>().IsLog;
            // Settings.IsReporting = SPTestConfiguration.SPSettings.TestSettings["staging"].IsReadOnly;
            Settings.LogPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().LogPath;
            // Settings.AppConnectionString = configurationRoot.GetSection("testSettings").Get<TestSettings>().AUTConnectionString;
            Settings.BrowserType = configurationRoot.GetSection("testSettings").Get<TestSettings>().Browser;

        }


    }
}