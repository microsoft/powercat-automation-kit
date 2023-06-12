using FakeItEasy;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.PluginTelemetry;
using System;

namespace AutoCoE.Extensibility.Tests
{
    public class PluginTestBase
    {
        internal (IPluginExecutionContext fakePluginExecutionContext, IOrganizationService fakeOrganizationService) SetupPluginFakes(IServiceProvider fakeServiceProvider)
        {
            var fakePluginExecutionContext = A.Fake<IPluginExecutionContext>();
            var fakeExecutionContext = A.Fake<IExecutionContext>();
            var fakeTracingService = A.Fake<ITracingService>();
            var fakeServiceEndpointNotificationService = A.Fake<IServiceEndpointNotificationService>();
            var fakeOrganizationServiceFactory = A.Fake<IOrganizationServiceFactory>();
            var fakeOrganizationService = A.Fake<IOrganizationService>();
            var fakeLogger = A.Fake<ILogger>();

            A.CallTo(
                () => fakeServiceProvider.GetService(typeof(IPluginExecutionContext))
            ).Returns(fakePluginExecutionContext);

            A.CallTo(
                () => fakeServiceProvider.GetService(typeof(IExecutionContext))
            ).Returns(fakeExecutionContext);

            A.CallTo(
                () => fakeServiceProvider.GetService(typeof(ITracingService))
            ).Returns(fakeTracingService);

            A.CallTo(
                () => fakeServiceProvider.GetService(typeof(IServiceEndpointNotificationService))
            ).Returns(fakeServiceEndpointNotificationService);

            A.CallTo(
                () => fakeServiceProvider.GetService(typeof(IOrganizationServiceFactory))
            ).Returns(fakeOrganizationServiceFactory);
            A.CallTo(
                () => fakeServiceProvider.GetService(typeof(ILogger))
            ).Returns(fakeLogger);
            A.CallTo(
                () => fakeOrganizationServiceFactory.CreateOrganizationService(A<Guid>.Ignored)
            ).Returns(fakeOrganizationService);

            return (fakePluginExecutionContext, fakeOrganizationService);
        }
       
    }
}