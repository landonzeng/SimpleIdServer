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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AuthorizationCodeGrantTypeErrorsFeature : object, Xunit.IClassFixture<AuthorizationCodeGrantTypeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AuthorizationCodeGrantTypeErrors.feature"
#line hidden
        
        public AuthorizationCodeGrantTypeErrorsFeature(AuthorizationCodeGrantTypeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "AuthorizationCodeGrantTypeErrors", "\tCheck errors returned when using \'authorization_code\' grant-type", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code\' with no code parameter")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code\' with no code parameter")]
        public void SendGrant_TypeAuthorization_CodeWithNoCodeParameter()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code\' with no code parameter", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table114 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table114.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table114, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("JSON \'$.error_description\'=\'missing parameter code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code\' with no redirect_uri")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code\' with no redirect_uri")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeWithNoRedirect_Uri()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code\' with no redirect_uri", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table115 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table115.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table115.AddRow(new string[] {
                            "code",
                            "code"});
#line 15
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table115, "When ");
#line hidden
#line 20
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("JSON \'$.error_description\'=\'missing parameter redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost,clien" +
            "t_id=firstClient,client_secret=password\' with unauthorized grant_type")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost,clien" +
            "t_id=firstClient,client_secret=password\' with unauthorized grant_type")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeRedirect_UriHttpLocalhostClient_IdFirstClientClient_SecretPasswordWithUnauthorizedGrant_Type()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost,clien" +
                    "t_id=firstClient,client_secret=password\' with unauthorized grant_type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table116 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table116.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table116.AddRow(new string[] {
                            "code",
                            "code"});
                table116.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost"});
                table116.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table116.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 26
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table116, "When ");
#line hidden
#line 34
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("JSON \'$.error_description\'=\'grant type authorization_code is not supported by the" +
                        " client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with previous issued token")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with previous issued token")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeRedirect_UriHttpLocalhost8080Client_IdThirdClientClient_SecretPasswordWithPreviousIssuedToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
                    "client_id=thirdClient,client_secret=password\' with previous issued token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 40
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table117 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table117.AddRow(new string[] {
                            "response_type",
                            "code"});
                table117.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table117.AddRow(new string[] {
                            "state",
                            "state"});
                table117.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table117.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table117.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 41
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table117, "When ");
#line hidden
#line 50
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table118 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table118.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table118.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table118.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table118.AddRow(new string[] {
                            "code",
                            "$code$"});
                table118.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 52
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table118, "And ");
#line hidden
                TechTalk.SpecFlow.Table table119 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table119.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table119.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table119.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table119.AddRow(new string[] {
                            "code",
                            "$code$"});
                table119.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 60
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table119, "And ");
#line hidden
#line 68
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("JSON \'$.error_description\'=\'authorization code has already been used, all tokens " +
                        "previously issued have been revoked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with bad code")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with bad code")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeRedirect_UriHttpLocalhost8080Client_IdThirdClientClient_SecretPasswordWithBadCode()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
                    "client_id=thirdClient,client_secret=password\' with bad code", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table120 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table120.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table120.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table120.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table120.AddRow(new string[] {
                            "code",
                            "invalidCode"});
                table120.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 74
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table120, "When ");
#line hidden
#line 82
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("JSON \'$.error_description\'=\'bad authorization code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with code not issued by the client" +
            "")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with code not issued by the client" +
            "")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeRedirect_UriHttpLocalhost8080Client_IdThirdClientClient_SecretPasswordWithCodeNotIssuedByTheClient()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
                    "client_id=thirdClient,client_secret=password\' with code not issued by the client" +
                    "", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 87
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 88
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table121 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table121.AddRow(new string[] {
                            "response_type",
                            "code"});
                table121.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table121.AddRow(new string[] {
                            "state",
                            "state"});
                table121.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table121.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table121.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 89
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table121, "When ");
#line hidden
#line 98
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table122 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table122.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table122.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table122.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table122.AddRow(new string[] {
                            "code",
                            "$code$"});
                table122.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:9080"});
#line 100
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table122, "And ");
#line hidden
#line 108
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And("JSON \'$.error_description\'=\'not the same redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                AuthorizationCodeGrantTypeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AuthorizationCodeGrantTypeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion