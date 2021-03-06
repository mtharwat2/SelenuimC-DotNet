// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SmartPatrol.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create Users")]
    public partial class CreateUsersFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CreateUser.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Create Users", "\tResponsible for Add , Edit Delete users and check if the functionality works", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create User with all details")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("positive")]
        public virtual void CreateUserWithAllDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke",
                    "positive"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create User with all details", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 9
 testRunner.Given("I Have navigated to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.And("I see application opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table23.AddRow(new string[] {
                            "awafeek",
                            "P@ssw0rd"});
#line 11
 testRunner.When("I enter username and password", ((string)(null)), table23, "When ");
#line hidden
#line 14
 testRunner.Then("I Click login button and see the dashboardpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.And("I Click the Security link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.Then("I Click the AddUser link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "EnglishName",
                            "ArabicName",
                            "UserName",
                            "Email",
                            "Usertype"});
                table24.AddRow(new string[] {
                            "Marian",
                            "ماريان",
                            "marianTest",
                            "Marian@test.com",
                            "Administrator"});
#line 17
 testRunner.And("I enter following details", ((string)(null)), table24, "And ");
#line hidden
#line 20
 testRunner.Then("I Click the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("validate the EnglishName mandatory field")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void ValidateTheEnglishNameMandatoryField()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke",
                    "negative"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("validate the EnglishName mandatory field", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 31
 testRunner.Given("I Have navigated to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
 testRunner.And("I see application opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table25.AddRow(new string[] {
                            "awafeek",
                            "P@ssw0rd"});
#line 33
 testRunner.When("I enter username and password", ((string)(null)), table25, "When ");
#line hidden
#line 36
 testRunner.Then("I Click login button and see the dashboardpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.And("I Click the Security link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then("I Click the AddUser link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "EnglishName",
                            "ArabicName",
                            "UserName",
                            "Email",
                            "Usertype"});
                table26.AddRow(new string[] {
                            "",
                            "ماريان",
                            "marianTest",
                            "Marian@test.com",
                            "Administrator"});
#line 39
 testRunner.And("I enter following details", ((string)(null)), table26, "And ");
#line hidden
#line 42
 testRunner.Then("I Click the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("I Should see the requiredFieldsError message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("validate the ArabicName mandatory field")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void ValidateTheArabicNameMandatoryField()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke",
                    "negative"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("validate the ArabicName mandatory field", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 48
 testRunner.Given("I Have navigated to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 49
 testRunner.And("I see application opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table27.AddRow(new string[] {
                            "awafeek",
                            "P@ssw0rd"});
#line 50
 testRunner.When("I enter username and password", ((string)(null)), table27, "When ");
#line hidden
#line 53
 testRunner.Then("I Click login button and see the dashboardpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.And("I Click the Security link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.Then("I Click the AddUser link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "EnglishName",
                            "ArabicName",
                            "UserName",
                            "Email",
                            "Usertype"});
                table28.AddRow(new string[] {
                            "Marian",
                            "",
                            "marianTest",
                            "Marian@test.com",
                            "Administrator"});
#line 56
 testRunner.And("I enter following details", ((string)(null)), table28, "And ");
#line hidden
#line 59
 testRunner.Then("I Click the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.And("I Should see the requiredFieldsError message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("validate the UserName mandatory field")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void ValidateTheUserNameMandatoryField()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke",
                    "negative"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("validate the UserName mandatory field", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 64
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 65
 testRunner.Given("I Have navigated to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 66
 testRunner.And("I see application opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table29.AddRow(new string[] {
                            "awafeek",
                            "P@ssw0rd"});
#line 67
 testRunner.When("I enter username and password", ((string)(null)), table29, "When ");
#line hidden
#line 70
 testRunner.Then("I Click login button and see the dashboardpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.And("I Click the Security link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.Then("I Click the AddUser link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "EnglishName",
                            "ArabicName",
                            "UserName",
                            "Email",
                            "Usertype"});
                table30.AddRow(new string[] {
                            "Marian",
                            "ماريان",
                            "",
                            "Marian@test.com",
                            "Administrator"});
#line 73
 testRunner.And("I enter following details", ((string)(null)), table30, "And ");
#line hidden
#line 76
 testRunner.Then("I Click the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.And("I Should see the requiredFieldsError message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("validate the Email mandatory field")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void ValidateTheEmailMandatoryField()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke",
                    "negative"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("validate the Email mandatory field", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 82
 testRunner.Given("I Have navigated to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 83
 testRunner.And("I see application opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table31.AddRow(new string[] {
                            "awafeek",
                            "P@ssw0rd"});
#line 84
 testRunner.When("I enter username and password", ((string)(null)), table31, "When ");
#line hidden
#line 87
 testRunner.Then("I Click login button and see the dashboardpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.And("I Click the Security link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.Then("I Click the AddUser link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "EnglishName",
                            "ArabicName",
                            "UserName",
                            "Email",
                            "Usertype"});
                table32.AddRow(new string[] {
                            "Marian",
                            "ماريان",
                            "marianTest",
                            "",
                            "Administrator"});
#line 90
 testRunner.And("I enter following details", ((string)(null)), table32, "And ");
#line hidden
#line 93
 testRunner.Then("I Click the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.And("I Should see the requiredFieldsError message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("validate the Usertype mandatory field")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void ValidateTheUsertypeMandatoryField()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke",
                    "negative"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("validate the Usertype mandatory field", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 98
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 99
 testRunner.Given("I Have navigated to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 100
 testRunner.And("I see application opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table33.AddRow(new string[] {
                            "awafeek",
                            "P@ssw0rd"});
#line 101
 testRunner.When("I enter username and password", ((string)(null)), table33, "When ");
#line hidden
#line 104
 testRunner.Then("I Click login button and see the dashboardpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 105
 testRunner.And("I Click the Security link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.Then("I Click the AddUser link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                            "EnglishName",
                            "ArabicName",
                            "UserName",
                            "Email",
                            "Usertype"});
                table34.AddRow(new string[] {
                            "Marian",
                            "ماريان",
                            "marianTest",
                            "Marian@test.com",
                            ""});
#line 107
 testRunner.And("I enter following details", ((string)(null)), table34, "And ");
#line hidden
#line 110
 testRunner.Then("I Click the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 111
 testRunner.And("I Should see the requiredFieldsError message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search by valid Role in the Roles List")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("positive")]
        public virtual void SearchByValidRoleInTheRolesList()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke",
                    "positive"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by valid Role in the Roles List", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 115
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 116
 testRunner.Given("I Have navigated to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 117
 testRunner.And("I see application opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table35.AddRow(new string[] {
                            "awafeek",
                            "P@ssw0rd"});
#line 118
 testRunner.When("I enter username and password", ((string)(null)), table35, "When ");
#line hidden
#line 121
 testRunner.Then("I Click login button and see the dashboardpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 122
 testRunner.And("I Click the Security link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.Then("I Click the AddUser link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                            "EnglishName",
                            "ArabicName",
                            "UserName",
                            "Email",
                            "Usertype"});
                table36.AddRow(new string[] {
                            "AutomateTest",
                            "ماريان",
                            "marianAutomateTest",
                            "Marian@test.com",
                            "Administrator"});
#line 124
 testRunner.And("I enter following details", ((string)(null)), table36, "And ");
#line hidden
#line 127
 testRunner.Then("I Click the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 128
 testRunner.And("I should see the UserRoles tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                            "search"});
                table37.AddRow(new string[] {
                            "Everyone"});
#line 129
 testRunner.And("I enter the role in search field", ((string)(null)), table37, "And ");
#line hidden
#line 132
 testRunner.Then("I Should see the search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search by invalid Role in the Roles List")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void SearchByInvalidRoleInTheRolesList()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke",
                    "negative"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by invalid Role in the Roles List", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 136
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 137
 testRunner.Given("I Have navigated to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 138
 testRunner.And("I see application opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table38.AddRow(new string[] {
                            "awafeek",
                            "P@ssw0rd"});
#line 139
 testRunner.When("I enter username and password", ((string)(null)), table38, "When ");
#line hidden
#line 142
 testRunner.Then("I Click login button and see the dashboardpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 143
 testRunner.And("I Click the Security link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 144
 testRunner.Then("I Click the AddUser link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                            "EnglishName",
                            "ArabicName",
                            "UserName",
                            "Email",
                            "Usertype"});
                table39.AddRow(new string[] {
                            "AutomateTest",
                            "ماريان",
                            "marianAutomateTest",
                            "Marian@test.com",
                            "Administrator"});
#line 145
 testRunner.And("I enter following details", ((string)(null)), table39, "And ");
#line hidden
#line 148
 testRunner.Then("I Click the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 149
 testRunner.And("I should see the UserRoles tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                            "search"});
                table40.AddRow(new string[] {
                            "TestTest"});
#line 150
 testRunner.And("I enter the role in search field", ((string)(null)), table40, "And ");
#line hidden
#line 153
 testRunner.Then("I Should not see the search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
