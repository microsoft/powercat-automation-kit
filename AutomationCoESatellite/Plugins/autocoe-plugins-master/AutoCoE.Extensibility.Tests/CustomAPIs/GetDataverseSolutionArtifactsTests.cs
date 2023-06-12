using AutoCoE.Extensibility.Plugins;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace AutoCoE.Extensibility.Tests
{
    [TestClass]
    public class GetDataverseSolutionArtifactsTests : PluginTestBase
    {
        [TestMethod]
        public void GetDataverseSolutionArtifacts_ReturnsAvalidCollection()
        {
            // Arrange
            var fakeServiceProvider = A.Fake<IServiceProvider>();

            var (fakePluginExecutionContext, fakeOrganizationService) = SetupPluginFakes(fakeServiceProvider);
            
            var environmentVariableCollection = new EntityCollection();
            var fakeEnvironmentVariableDefinition = A.Fake<Entity>();
            var TestSolutionId = "48bb3724-38df-4b3b-90d7-c48a8243dd0b";
            var systemUserId = "48db3724-38df-4b3b-90d7-c48a8243dd0b";

            string exceptionMessage = "";

            environmentVariableCollection.Entities.Add(fakeEnvironmentVariableDefinition);

            A.CallTo(() => fakeEnvironmentVariableDefinition.GetAttributeValue<AliasedValue>("v.value"))
                .Returns(new AliasedValue("environmentvariablevalue", "value", systemUserId));

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "environmentvariabledefinition")))
                .Returns(environmentVariableCollection);

            //Assigning solution id
            fakePluginExecutionContext.InputParameters.Add("SolutionManagerSolutionId", TestSolutionId );

            A.CallTo(() => fakePluginExecutionContext.InputParameters["SolutionManagerSolutionId"]).Returns(TestSolutionId);

            var solutionComponentsSummaries = new EntityCollection();
            var solutionComponentsSummary = new Entity("msdyn_solutioncomponentsummary");
            solutionComponentsSummaries.Entities.Add(solutionComponentsSummary);

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "msdyn_solutioncomponentsummary")))
                .Returns(solutionComponentsSummaries);

            // Act
            var plugin = new GetDataverseSolutionArtifacts("","");
            plugin.Execute(fakeServiceProvider);

            //Assert
            var resultSolutioncomponentsummaries = fakePluginExecutionContext.OutputParameters["SolutionArtifacts"] as EntityCollection;
            Assert.AreEqual(resultSolutioncomponentsummaries.Entities.Count, 1);

            Assert.IsTrue(exceptionMessage == "");
        }

        [TestMethod]
        public void GetDataverseSolutionArtifacts_ReturnsAnEmptyCollection()
        {
            // Arrange
            var fakeServiceProvider = A.Fake<IServiceProvider>();

            var (fakePluginExecutionContext, fakeOrganizationService) = SetupPluginFakes(fakeServiceProvider);

            var environmentVariableCollection = new EntityCollection();
            var fakeEnvironmentVariableDefinition = A.Fake<Entity>();
            var TestSolutionId = "48bb3724-38df-4b3b-90d7-c48a8243dd0b";
            var systemUserId = "48db3724-38df-4b3b-90d7-c48a8243dd0b";

            string exceptionMessage = "";

            environmentVariableCollection.Entities.Add(fakeEnvironmentVariableDefinition);

            A.CallTo(() => fakeEnvironmentVariableDefinition.GetAttributeValue<AliasedValue>("v.value"))
                .Returns(new AliasedValue("environmentvariablevalue", "value", systemUserId));

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "environmentvariabledefinition")))
                .Returns(environmentVariableCollection);

            //Assigning solution id
            fakePluginExecutionContext.InputParameters.Add("SolutionManagerSolutionId", TestSolutionId);

            A.CallTo(() => fakePluginExecutionContext.InputParameters["SolutionManagerSolutionId"]).Returns(TestSolutionId);

            var solutionComponentsSummaries = new EntityCollection();
            var solutionComponentsSummary = new Entity("msdyn_solutioncomponentsummary");
            //solutionComponentsSummaries.Entities.Add(solutionComponentsSummary);

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "msdyn_solutioncomponentsummary")))
                .Returns(solutionComponentsSummaries);

            // Act
            var plugin = new GetDataverseSolutionArtifacts("", "");
            plugin.Execute(fakeServiceProvider);

            //Assert
            var resultSolutioncomponentsummaries = fakePluginExecutionContext.OutputParameters["SolutionArtifacts"] as EntityCollection;
            Assert.AreEqual(resultSolutioncomponentsummaries.Entities.Count, 0);

            Assert.IsTrue(exceptionMessage == "");
        }

        [TestMethod]
        public void GetDataverseSolutionArtifacts_ReturnsExceptionWhenDataIsNotFoundForSolution()
        {
            // Arrange
            var fakeServiceProvider = A.Fake<IServiceProvider>();

            var (fakePluginExecutionContext, fakeOrganizationService) = SetupPluginFakes(fakeServiceProvider);

            var environmentVariableCollection = new EntityCollection();
            var fakeEnvironmentVariableDefinition = A.Fake<Entity>();
            var TestSolutionId = "48bb3724-38df-4b3b-90d7-c48a8243dd0b";
            var systemUserId = "48db3724-38df-4b3b-90d7-c48a8243dd0b";

            string exceptionMessage = "";

            environmentVariableCollection.Entities.Add(fakeEnvironmentVariableDefinition);

            A.CallTo(() => fakeEnvironmentVariableDefinition.GetAttributeValue<AliasedValue>("v.value"))
                .Returns(new AliasedValue("environmentvariablevalue", "value", systemUserId));

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "environmentvariabledefinition")))
                .Returns(environmentVariableCollection);

            //Assigning solution id
            fakePluginExecutionContext.InputParameters.Add("SolutionManagerSolutionId", TestSolutionId);

            A.CallTo(() => fakePluginExecutionContext.InputParameters["SolutionManagerSolutionId"]).Returns(TestSolutionId);

            var solutionComponentsSummaries = new EntityCollection();
            var solutionComponentsSummary = new Entity("msdyn_solutioncomponentsummary");
            solutionComponentsSummaries.Entities.Add(solutionComponentsSummary);

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "msdyn_solutioncomponentsummary")))
                .Throws(new InvalidPluginExecutionException("We couldn't able to retrive solution components from table 'msdyn_solutioncomponentsummary'"));

            //A.CallTo(() => fakeShop.NumberOfSweetsSoldOn(DateTime.MaxValue))
 //.Throws(new InvalidDateException("the date is in the future"));

            // Act
            var plugin = new GetDataverseSolutionArtifacts("", "");

            try
            {
                plugin.Execute(fakeServiceProvider);
            }
            catch (Exception ex)
            {

                exceptionMessage=ex.Message;
            }
            

            //Assert
            //var resultSolutioncomponentsummaries = fakePluginExecutionContext.OutputParameters["SolutionArtifacts"] as EntityCollection;
            //Assert.AreEqual(resultSolutioncomponentsummaries.Entities.Count, 0);

            Assert.IsTrue(exceptionMessage.Contains("We couldn't able to retrive solution components from table 'msdyn_solutioncomponentsummary'"));
        }

        [TestMethod]
        public void GetDataverseSolutionArtifacts_ReturnsExceptionInvalidPluginForSolutionProviderisNull()
        {
            // Arrange
            var fakeServiceProvider = A.Fake<IServiceProvider>();

            //IServiceProvider fakeServiceProvider = null;
            var (fakePluginExecutionContext, fakeOrganizationService) = SetupPluginFakes(fakeServiceProvider);

            fakeServiceProvider = null;
            var environmentVariableCollection = new EntityCollection();
            var fakeEnvironmentVariableDefinition = A.Fake<Entity>();
            var TestSolutionId = "48bb3724-38df-4b3b-90d7-c48a8243dd0b";
            var systemUserId = "48db3724-38df-4b3b-90d7-c48a8243dd0b";

            string exceptionMessage = "";

            environmentVariableCollection.Entities.Add(fakeEnvironmentVariableDefinition);

            A.CallTo(() => fakeEnvironmentVariableDefinition.GetAttributeValue<AliasedValue>("v.value"))
                .Returns(new AliasedValue("environmentvariablevalue", "value", systemUserId));

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "environmentvariabledefinition")))
                .Returns(environmentVariableCollection);

            //Assigning solution id
            fakePluginExecutionContext.InputParameters.Add("SolutionManagerSolutionId", TestSolutionId);

            A.CallTo(() => fakePluginExecutionContext.InputParameters["SolutionManagerSolutionId"]).Returns(TestSolutionId);

            var solutionComponentsSummaries = new EntityCollection();
            var solutionComponentsSummary = new Entity("msdyn_solutioncomponentsummary");
            

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "msdyn_solutioncomponentsummary")))
                .Returns(solutionComponentsSummaries);

            // Act
            var plugin = new GetDataverseSolutionArtifacts("", "");

            try
            {
                plugin.Execute(fakeServiceProvider);
            }
            catch (Exception ex )
            {
                
                exceptionMessage = ex.Message;
               
            }
            

            //Assert
          
            Assert.IsTrue(exceptionMessage.Contains("serviceProvider") );
        }

        [TestMethod]
        public void GetDataverseSolutionArtifacts_ReturnsExceptionWhenSystemUserIdisBlankorNull()
        {
            // Arrange
            var fakeServiceProvider = A.Fake<IServiceProvider>();

            var (fakePluginExecutionContext, fakeOrganizationService) = SetupPluginFakes(fakeServiceProvider);

            var environmentVariableCollection = new EntityCollection();
            var fakeEnvironmentVariableDefinition = A.Fake<Entity>();
            var TestSolutionId =  "48bb3724-38df-4b3b-90d7-c48a8243dd0b";
            string systemUserId = null;
            string exceptionMessage = "";

            environmentVariableCollection.Entities.Add(fakeEnvironmentVariableDefinition);

            A.CallTo(() => fakeEnvironmentVariableDefinition.GetAttributeValue<AliasedValue>("v.value"))
                .Returns(new AliasedValue("environmentvariablevalue", "value", systemUserId));

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "environmentvariabledefinition")))
                .Returns(environmentVariableCollection);

            //Assigning solution id
            fakePluginExecutionContext.InputParameters.Add("SolutionManagerSolutionId", TestSolutionId);

            A.CallTo(() => fakePluginExecutionContext.InputParameters["SolutionManagerSolutionId"]).Returns(TestSolutionId);

            var solutionComponentsSummaries = new EntityCollection();
            var solutionComponentsSummary = new Entity("msdyn_solutioncomponentsummary");
            solutionComponentsSummaries.Entities.Add(solutionComponentsSummary);

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "msdyn_solutioncomponentsummary")))
                .Returns(solutionComponentsSummaries);

            // Act
            var plugin = new GetDataverseSolutionArtifacts("", "");
            try
            {
                plugin.Execute(fakeServiceProvider);
            }
            catch (Exception ex)
            {

                exceptionMessage = ex.Message;
                    
                             
            }
            //Assert
            Assert.IsTrue(exceptionMessage.Contains("autocoe_SolutionManagerArtifactsReadUserId"));

        }

        [TestMethod]
        public void GetDataverseSolutionArtifacts_ReturnsExceptionWhenEnvVariableisNotFound()
        {
            // Arrange
            var fakeServiceProvider = A.Fake<IServiceProvider>();

            var (fakePluginExecutionContext, fakeOrganizationService) = SetupPluginFakes(fakeServiceProvider);

            var environmentVariableCollection = new EntityCollection();
            var fakeEnvironmentVariableDefinition = A.Fake<Entity>();
            var TestSolutionId = "48bb3724-38df-4b3b-90d7-c48a8243dd0b";
            string systemUserId = null;
            string exceptionMessage = "";

            //environmentVariableCollection.Entities.Add(fakeEnvironmentVariableDefinition);

            A.CallTo(() => fakeEnvironmentVariableDefinition.GetAttributeValue<AliasedValue>("v.value"))
                .Returns(new AliasedValue("environmentvariablevalue", "value", systemUserId));

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "environmentvariabledefinition")))
                .Returns(environmentVariableCollection);

            //Assigning solution id
            fakePluginExecutionContext.InputParameters.Add("SolutionManagerSolutionId", TestSolutionId);

            A.CallTo(() => fakePluginExecutionContext.InputParameters["SolutionManagerSolutionId"]).Returns(TestSolutionId);

            var solutionComponentsSummaries = new EntityCollection();
            var solutionComponentsSummary = new Entity("msdyn_solutioncomponentsummary");
            solutionComponentsSummaries.Entities.Add(solutionComponentsSummary);

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "msdyn_solutioncomponentsummary")))
                .Returns(solutionComponentsSummaries);

            // Act
            var plugin = new GetDataverseSolutionArtifacts("", "");
            try
            {
                plugin.Execute(fakeServiceProvider);
            }
            catch (Exception ex)
            {

                exceptionMessage = ex.Message;

                Console.WriteLine(exceptionMessage);
                //throw;


            }
            //Assert
            Assert.IsTrue(exceptionMessage.Contains("autocoe_SolutionManagerArtifactsReadUserId"));

        }

        [TestMethod]
        public void GetDataverseSolutionArtifacts_ReturnsExceptionWhenSolutionIdisBlankorNull()
        {   
            // Arrange
            var fakeServiceProvider = A.Fake<IServiceProvider>();

            var (fakePluginExecutionContext, fakeOrganizationService) = SetupPluginFakes(fakeServiceProvider);

            var environmentVariableCollection = new EntityCollection();
            var fakeEnvironmentVariableDefinition = A.Fake<Entity>();
            var TestSolutionId = "";
            var systemUserId = "48db3724-38df-4b3b-90d7-c48a8243dd0b";
            string exceptionMessage="";

            environmentVariableCollection.Entities.Add(fakeEnvironmentVariableDefinition);

            A.CallTo(() => fakeEnvironmentVariableDefinition.GetAttributeValue<AliasedValue>("v.value"))
                .Returns(new AliasedValue("environmentvariablevalue", "value", systemUserId));

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "environmentvariabledefinition")))
                .Returns(environmentVariableCollection);

            //Assigning solution id
            fakePluginExecutionContext.InputParameters.Add("SolutionManagerSolutionId", TestSolutionId);

            A.CallTo(() => fakePluginExecutionContext.InputParameters["SolutionManagerSolutionId"]).Returns(TestSolutionId);

            var solutionComponentsSummaries = new EntityCollection();
            var solutionComponentsSummary = new Entity("msdyn_solutioncomponentsummary");
            solutionComponentsSummaries.Entities.Add(solutionComponentsSummary);

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "msdyn_solutioncomponentsummary")))
                .Returns(solutionComponentsSummaries);
            var plugin = new GetDataverseSolutionArtifacts("", "");
            try
            {
                plugin.Execute(fakeServiceProvider);
            }
            catch (Exception ex)
            {
               exceptionMessage = ex.Message;

            }
            //Assert
            Assert.IsTrue(exceptionMessage.Contains("Unrecognized Guid format"));

        }

        [TestMethod]
        public void GetDataverseSolutionArtifacts_ReturnsExceptionWhenSolutionIdInputParameterIsNotFound()
        {
            // Arrange
            var fakeServiceProvider = A.Fake<IServiceProvider>();

            var (fakePluginExecutionContext, fakeOrganizationService) = SetupPluginFakes(fakeServiceProvider);

            var environmentVariableCollection = new EntityCollection();
            var fakeEnvironmentVariableDefinition = A.Fake<Entity>();
            var TestSolutionId = "";
            var systemUserId = "48db3724-38df-4b3b-90d7-c48a8243dd0b";
            string exceptionMessage = "";

            environmentVariableCollection.Entities.Add(fakeEnvironmentVariableDefinition);

            A.CallTo(() => fakeEnvironmentVariableDefinition.GetAttributeValue<AliasedValue>("v.value"))
                .Returns(new AliasedValue("environmentvariablevalue", "value", systemUserId));

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "environmentvariabledefinition")))
                .Returns(environmentVariableCollection);
            
            A.CallTo(() => fakePluginExecutionContext.InputParameters["SolutionManagerSolutionId"]).Returns(TestSolutionId);

            var solutionComponentsSummaries = new EntityCollection();
            var solutionComponentsSummary = new Entity("msdyn_solutioncomponentsummary");
            solutionComponentsSummaries.Entities.Add(solutionComponentsSummary);

            A.CallTo(
                () => fakeOrganizationService.RetrieveMultiple(A<QueryExpression>.That.Matches(q => q.EntityName == "msdyn_solutioncomponentsummary")))
                .Returns(solutionComponentsSummaries);
            var plugin = new GetDataverseSolutionArtifacts("", "");
            try
            {
                plugin.Execute(fakeServiceProvider);
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;

            }
            //Assert
            Assert.IsTrue(exceptionMessage.Contains("We couldn't find a valid Solution Id in the context.InputParameters Collection"));

        }
    }
}