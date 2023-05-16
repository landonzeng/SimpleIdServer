﻿// ------------------------------------------------------------------------------
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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UsersErrorsFeature : object, Xunit.IClassFixture<UsersErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UsersErrors.feature"
#line hidden
        
        public UsersErrorsFeature(UsersErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UsersErrors", "\tCheck errors returned by the /users endpoint", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="access token must be passed (HTTP POST)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "access token must be passed (HTTP POST)")]
        public void AccessTokenMustBePassedHTTPPOST()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("access token must be passed (HTTP POST)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table494 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'https://localhost:8080/users\'", ((string)(null)), table494, "When ");
#line hidden
#line 8
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("JSON \'error\'=\'access_denied\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="access token must be passed (HTTP GET)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "access token must be passed (HTTP GET)")]
        public void AccessTokenMustBePassedHTTPGET()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("access token must be passed (HTTP GET)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table495 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
#line 14
 testRunner.When("execute HTTP GET request \'https://localhost:8080/users/id\'", ((string)(null)), table495, "When ");
#line hidden
#line 17
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.Then("JSON \'error\'=\'access_denied\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.And("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="access token must be passed (HTTP DELETE)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "access token must be passed (HTTP DELETE)")]
        public void AccessTokenMustBePassedHTTPDELETE()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("access token must be passed (HTTP DELETE)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table496 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
#line 23
 testRunner.When("execute HTTP DELETE request \'https://localhost:8080/users/id\'", ((string)(null)), table496, "When ");
#line hidden
#line 26
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.Then("JSON \'error\'=\'access_denied\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.And("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="access token must be passed (HTTP PUT Credentials)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "access token must be passed (HTTP PUT Credentials)")]
        public void AccessTokenMustBePassedHTTPPUTCredentials()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("access token must be passed (HTTP PUT Credentials)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table497 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
#line 32
 testRunner.When("execute HTTP PUT JSON request \'https://localhost:8080/users/id/credentials\'", ((string)(null)), table497, "When ");
#line hidden
#line 35
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.Then("JSON \'error\'=\'access_denied\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.And("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="name is required")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "name is required")]
        public void NameIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("name is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table498 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table498.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table498.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table498.AddRow(new string[] {
                            "scope",
                            "users"});
                table498.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 41
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table498, "When ");
#line hidden
#line 48
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table499 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table499.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 51
 testRunner.When("execute HTTP POST JSON request \'https://localhost:8080/users\'", ((string)(null)), table499, "When ");
#line hidden
#line 55
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.And("JSON \'error_description\'=\'missing parameter name\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="name must be unique")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "name must be unique")]
        public void NameMustBeUnique()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("name must be unique", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 60
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table500 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table500.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table500.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table500.AddRow(new string[] {
                            "scope",
                            "users"});
                table500.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 61
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table500, "When ");
#line hidden
#line 68
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table501 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table501.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table501.AddRow(new string[] {
                            "name",
                            "user"});
#line 71
 testRunner.When("execute HTTP POST JSON request \'https://localhost:8080/users\'", ((string)(null)), table501, "When ");
#line hidden
#line 76
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.And("JSON \'error_description\'=\'the user user already exists\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="get an unknown user")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "get an unknown user")]
        public void GetAnUnknownUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("get an unknown user", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table502 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table502.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table502.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table502.AddRow(new string[] {
                            "scope",
                            "users"});
                table502.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 82
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table502, "When ");
#line hidden
#line 89
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table503 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table503.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 92
 testRunner.When("execute HTTP GET request \'https://localhost:8080/users/id\'", ((string)(null)), table503, "When ");
#line hidden
#line 96
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="remove an unknown user")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "remove an unknown user")]
        public void RemoveAnUnknownUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("remove an unknown user", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 98
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table504 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table504.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table504.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table504.AddRow(new string[] {
                            "scope",
                            "users"});
                table504.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 99
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table504, "When ");
#line hidden
#line 106
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table505 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table505.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 109
 testRunner.When("execute HTTP DELETE request \'https://localhost:8080/users/id\'", ((string)(null)), table505, "When ");
#line hidden
#line 113
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="credential type is required")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "credential type is required")]
        public void CredentialTypeIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("credential type is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 115
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table506 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table506.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table506.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table506.AddRow(new string[] {
                            "scope",
                            "users"});
                table506.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 116
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table506, "When ");
#line hidden
#line 123
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table507 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table507.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 126
 testRunner.When("execute HTTP PUT JSON request \'https://localhost:8080/users/id/credentials\'", ((string)(null)), table507, "When ");
#line hidden
#line 130
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 133
 testRunner.And("JSON \'error_description\'=\'missing parameter type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="credential value is required")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "credential value is required")]
        public void CredentialValueIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("credential value is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 135
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table508 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table508.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table508.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table508.AddRow(new string[] {
                            "scope",
                            "users"});
                table508.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 136
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table508, "When ");
#line hidden
#line 143
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 144
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table509 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table509.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table509.AddRow(new string[] {
                            "type",
                            "type"});
#line 146
 testRunner.When("execute HTTP PUT JSON request \'https://localhost:8080/users/id/credentials\'", ((string)(null)), table509, "When ");
#line hidden
#line 151
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 153
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 154
 testRunner.And("JSON \'error_description\'=\'missing parameter value\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="credential type must be supported")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "credential type must be supported")]
        public void CredentialTypeMustBeSupported()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("credential type must be supported", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 156
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table510 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table510.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table510.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table510.AddRow(new string[] {
                            "scope",
                            "users"});
                table510.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 157
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table510, "When ");
#line hidden
#line 164
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 165
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table511 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table511.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table511.AddRow(new string[] {
                            "type",
                            "type"});
                table511.AddRow(new string[] {
                            "value",
                            "value"});
#line 167
 testRunner.When("execute HTTP PUT JSON request \'https://localhost:8080/users/id/credentials\'", ((string)(null)), table511, "When ");
#line hidden
#line 173
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 175
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 176
 testRunner.And("JSON \'error_description\'=\'the credential type type is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="cannot update credential when user doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "cannot update credential when user doesn\'t exist")]
        public void CannotUpdateCredentialWhenUserDoesntExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("cannot update credential when user doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 178
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table512 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table512.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table512.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table512.AddRow(new string[] {
                            "scope",
                            "users"});
                table512.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 179
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table512, "When ");
#line hidden
#line 186
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 187
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table513 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table513.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table513.AddRow(new string[] {
                            "type",
                            "pwd"});
                table513.AddRow(new string[] {
                            "value",
                            "value"});
#line 189
 testRunner.When("execute HTTP PUT JSON request \'https://localhost:8080/users/id/credentials\'", ((string)(null)), table513, "When ");
#line hidden
#line 195
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UsersErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UsersErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
