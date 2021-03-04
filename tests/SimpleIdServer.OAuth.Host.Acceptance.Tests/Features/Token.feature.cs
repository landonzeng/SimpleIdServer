﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.OAuth.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TokenFeature : object, Xunit.IClassFixture<TokenFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Token.feature"
#line hidden
        
        public TokenFeature(TokenFeature.FixtureData fixtureData, SimpleIdServer_OAuth_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Token", "\tGet access token", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use client_credentials grant type to get an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "Token")]
        [Xunit.TraitAttribute("Description", "Use client_credentials grant type to get an access token")]
        public virtual void UseClient_CredentialsGrantTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use client_credentials grant type to get an access token", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
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
                TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table52.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 5
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table52, "When ");
#line hidden
                TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table53.AddRow(new string[] {
                            "client_id",
                            "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
                table53.AddRow(new string[] {
                            "client_secret",
                            "BankCvSecret"});
                table53.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table53.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 9
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table53, "And ");
#line hidden
#line 16
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.Then("JSON exists \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.Then("JSON exists \'refresh_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.Then("JSON \'token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use client_credentials grant type & use tls_client_auth authentication type to ge" +
            "t an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "Token")]
        [Xunit.TraitAttribute("Description", "Use client_credentials grant type & use tls_client_auth authentication type to ge" +
            "t an access token")]
        public virtual void UseClient_CredentialsGrantTypeUseTls_Client_AuthAuthenticationTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use client_credentials grant type & use tls_client_auth authentication type to ge" +
                    "t an access token", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 23
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
                TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table54.AddRow(new string[] {
                            "token_endpoint_auth_method",
                            "tls_client_auth"});
                table54.AddRow(new string[] {
                            "response_types",
                            "[token]"});
                table54.AddRow(new string[] {
                            "grant_types",
                            "[client_credentials]"});
                table54.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table54.AddRow(new string[] {
                            "redirect_uris",
                            "[http://localhost:8080]"});
                table54.AddRow(new string[] {
                            "tls_client_auth_san_dns",
                            "firstMtlsClient"});
#line 24
 testRunner.When("execute HTTP POST JSON request \'https://localhost:8080/register\'", ((string)(null)), table54, "When ");
#line hidden
#line 33
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table55.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table55.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table55.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table55.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
#line 36
 testRunner.And("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table55, "And ");
#line hidden
#line 43
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.Then("JSON exists \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.Then("JSON exists \'refresh_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.Then("JSON \'token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use password grant type to get an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "Token")]
        [Xunit.TraitAttribute("Description", "Use password grant type to get an access token")]
        public virtual void UsePasswordGrantTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use password grant type to get an access token", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 50
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
                TechTalk.SpecFlow.Table table56 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table56.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 51
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table56, "When ");
#line hidden
                TechTalk.SpecFlow.Table table57 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table57.AddRow(new string[] {
                            "client_id",
                            "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
                table57.AddRow(new string[] {
                            "client_secret",
                            "BankCvSecret"});
                table57.AddRow(new string[] {
                            "username",
                            "administrator"});
                table57.AddRow(new string[] {
                            "password",
                            "password"});
                table57.AddRow(new string[] {
                            "grant_type",
                            "password"});
#line 55
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table57, "And ");
#line hidden
#line 63
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.Then("JSON exists \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.Then("JSON exists \'refresh_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.Then("JSON \'token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use authorization_code grant type to get an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "Token")]
        [Xunit.TraitAttribute("Description", "Use authorization_code grant type to get an access token")]
        public virtual void UseAuthorization_CodeGrantTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use authorization_code grant type to get an access token", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 70
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
                TechTalk.SpecFlow.Table table58 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table58.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 71
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table58, "When ");
#line hidden
#line 75
 testRunner.And("add user consent : user=\'administrator\', scope=\'scope1\', clientId=\'f3d35cce-de69-" +
                        "45bf-958c-4a8796f8ed37\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table59 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table59.AddRow(new string[] {
                            "response_type",
                            "code"});
                table59.AddRow(new string[] {
                            "client_id",
                            "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
                table59.AddRow(new string[] {
                            "state",
                            "state"});
                table59.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table59.AddRow(new string[] {
                            "response_mode",
                            "query"});
#line 77
 testRunner.And("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table59, "And ");
#line hidden
#line 85
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table60 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table60.AddRow(new string[] {
                            "client_id",
                            "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
                table60.AddRow(new string[] {
                            "client_secret",
                            "BankCvSecret"});
                table60.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table60.AddRow(new string[] {
                            "code",
                            "$code$"});
                table60.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 87
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table60, "And ");
#line hidden
#line 95
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 98
 testRunner.Then("JSON exists \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 99
 testRunner.Then("JSON exists \'refresh_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 100
 testRunner.Then("JSON \'token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use refresh_token grant type to get an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "Token")]
        [Xunit.TraitAttribute("Description", "Use refresh_token grant type to get an access token")]
        public virtual void UseRefresh_TokenGrantTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use refresh_token grant type to get an access token", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 102
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
                TechTalk.SpecFlow.Table table61 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table61.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 103
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table61, "When ");
#line hidden
                TechTalk.SpecFlow.Table table62 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table62.AddRow(new string[] {
                            "client_id",
                            "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
                table62.AddRow(new string[] {
                            "client_secret",
                            "BankCvSecret"});
                table62.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table62.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 107
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table62, "And ");
#line hidden
#line 114
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("extract parameter \'refresh_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table63 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table63.AddRow(new string[] {
                            "client_id",
                            "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
                table63.AddRow(new string[] {
                            "client_secret",
                            "BankCvSecret"});
                table63.AddRow(new string[] {
                            "refresh_token",
                            "$refresh_token$"});
                table63.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
#line 117
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table63, "And ");
#line hidden
#line 124
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 126
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 127
 testRunner.Then("JSON exists \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 128
 testRunner.Then("JSON exists \'refresh_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.Then("JSON \'token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Revoke refresh_token")]
        [Xunit.TraitAttribute("FeatureTitle", "Token")]
        [Xunit.TraitAttribute("Description", "Revoke refresh_token")]
        public virtual void RevokeRefresh_Token()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Revoke refresh_token", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 131
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
                TechTalk.SpecFlow.Table table64 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table64.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 132
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table64, "When ");
#line hidden
                TechTalk.SpecFlow.Table table65 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table65.AddRow(new string[] {
                            "client_id",
                            "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
                table65.AddRow(new string[] {
                            "client_secret",
                            "BankCvSecret"});
                table65.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table65.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 136
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table65, "And ");
#line hidden
#line 143
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 144
 testRunner.And("extract parameter \'refresh_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table66 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table66.AddRow(new string[] {
                            "token",
                            "$refresh_token$"});
                table66.AddRow(new string[] {
                            "client_id",
                            "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
                table66.AddRow(new string[] {
                            "client_secret",
                            "BankCvSecret"});
#line 146
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token/revoke\'", ((string)(null)), table66, "And ");
#line hidden
#line 152
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use authorization_code grant type to get an access token (PKCE)")]
        [Xunit.TraitAttribute("FeatureTitle", "Token")]
        [Xunit.TraitAttribute("Description", "Use authorization_code grant type to get an access token (PKCE)")]
        public virtual void UseAuthorization_CodeGrantTypeToGetAnAccessTokenPKCE()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use authorization_code grant type to get an access token (PKCE)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 154
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
                TechTalk.SpecFlow.Table table67 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table67.AddRow(new string[] {
                            "token_endpoint_auth_method",
                            "pkce"});
                table67.AddRow(new string[] {
                            "response_types",
                            "[code]"});
                table67.AddRow(new string[] {
                            "grant_types",
                            "[authorization_code]"});
                table67.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table67.AddRow(new string[] {
                            "redirect_uris",
                            "[http://localhost:8080]"});
#line 155
 testRunner.When("execute HTTP POST JSON request \'https://localhost:8080/register\'", ((string)(null)), table67, "When ");
#line hidden
#line 163
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 164
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 165
 testRunner.And("add user consent : user=\'administrator\', scope=\'scope1\', clientId=\'$client_id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table68 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table68.AddRow(new string[] {
                            "response_type",
                            "code"});
                table68.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table68.AddRow(new string[] {
                            "state",
                            "state"});
                table68.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table68.AddRow(new string[] {
                            "code_challenge",
                            "VpTQii5T_8rgwxA-Wtb2B2q9lg6x-KVldwQLwQKPcCs"});
                table68.AddRow(new string[] {
                            "code_challenge_method",
                            "S256"});
#line 167
 testRunner.And("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table68, "And ");
#line hidden
#line 176
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table69 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table69.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table69.AddRow(new string[] {
                            "client_secret",
                            "BankCvSecret"});
                table69.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table69.AddRow(new string[] {
                            "code",
                            "$code$"});
                table69.AddRow(new string[] {
                            "code_verifier",
                            "code"});
                table69.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 178
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table69, "And ");
#line hidden
#line 187
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 189
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 190
 testRunner.Then("JSON exists \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 191
 testRunner.Then("JSON exists \'refresh_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 192
 testRunner.Then("JSON \'token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TokenFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TokenFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
