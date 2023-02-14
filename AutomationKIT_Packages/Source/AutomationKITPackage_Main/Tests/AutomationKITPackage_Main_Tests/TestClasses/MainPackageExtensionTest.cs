using FakeItEasy;
using AutomationKIT_Main.Adapters;
using Microsoft.Xrm.Sdk;
using AutomationKITPackage_Main_Tests.Services;
using AutomationKIT_Main.ExtensionClasses;
using AutomationKIT_Main;
using Microsoft.Extensions.Logging;


namespace AutomationKITPackage_Main_Tests.TestClasses
{
    [TestClass]
    public class MainPackageExtensionTest
    {
        private ICrmServiceAdapter _fakecrmServiceAdapter;        
        private ILogger _fakelogger;
        private MainPackageExtSVC _MainPackageextService;

        [TestInitialize]
        public void initializer()
        {
            _fakelogger = A.Fake<ILogger>();
            _fakecrmServiceAdapter = A.Fake<ICrmServiceAdapter>();
            _MainPackageextService = new MainPackageExtSVC(_fakecrmServiceAdapter, _fakelogger);
        }

        [TestMethod]
        public void AssignRoles_Test_with_Valid_Parameters_Returns_True()
        {
            //Arrange
            string useremailid = "Test@abc.com";
            string securityRole = "System Administrator";
            Guid TestUserId = new Guid();
            Guid TestRoleID = new Guid();
            
            MainPackageExt mainpkgExt = new MainPackageExt(_MainPackageextService);

            A.CallTo(() => _fakecrmServiceAdapter.RetrieveSecurityGroupID(securityRole)).Returns(TestRoleID);
            A.CallTo(() => _fakecrmServiceAdapter.RetrieveUserId(useremailid)).Returns(TestUserId);
                       
            //Act
            var result = _MainPackageextService.AssignUsersToRole(useremailid, securityRole);

            //Assert
            A.CallTo(() => _fakecrmServiceAdapter.Associate(Constants.systemuser.LogicalName, TestUserId, new Relationship("systemuserroles_association"), new EntityReferenceCollection() { new EntityReference(Constants.role.LogicalName, TestRoleID) })).WithAnyArguments().MustHaveHappenedOnceExactly();            
            Assert.IsNotNull(_MainPackageextService);
            Assert.IsNotNull(_fakecrmServiceAdapter);
            Assert.IsNotNull(mainpkgExt);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void AssignRoles_Test_with_EmptyEmailID_Parameters_Returns_False()
        {
            //Arrange
            string useremailid = "";
            string securityRole = "System Administrator";
            Guid TestUserId = new Guid();
            Guid TestRoleID = new Guid();
            
            MainPackageExt mainpkgExt = new MainPackageExt(_MainPackageextService);
            A.CallTo(() => _fakecrmServiceAdapter.RetrieveSecurityGroupID(securityRole)).Returns(TestRoleID);
            string ErrorDetails = "Email id is Empty or blank";

            //Act
            var result = mainpkgExt.AssignUsersToRole(useremailid, securityRole);

            //Assert        
            //Assert Logger should be created with error message
            A.CallTo(_fakelogger).Where(
               call => call.Method.Name == "Log" && call.GetArgument<LogLevel>(0) == LogLevel.Error && call.Arguments[2].ToString().Contains(ErrorDetails)) // Modify with your type of log
            .MustHaveHappened(1, Times.Exactly);

            Assert.IsNotNull(mainpkgExt);
            Assert.IsNotNull(_fakecrmServiceAdapter);
            Assert.IsNotNull(mainpkgExt);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void AssignRoles_Test_with_EmptySecurityRole_Parameters_Returns_False()
        {
            //Arrange
            string useremailid = "test@abc.com";
            string securityRole = "";
            Guid TestUserId = new Guid();
            Guid TestRoleID = new Guid();

            MainPackageExt mainpkgExt = new MainPackageExt(_MainPackageextService);
            A.CallTo(() => _fakecrmServiceAdapter.RetrieveSecurityGroupID(securityRole)).Returns(TestRoleID);
            string ErrorDetails = "Security role is Empty or blank";

            //Act
            var result = mainpkgExt.AssignUsersToRole(useremailid, securityRole);

            //Assert        
            //Assert Logger should be created with error message
            A.CallTo(_fakelogger).Where(
               call => call.Method.Name == "Log" && call.GetArgument<LogLevel>(0) == LogLevel.Error && call.Arguments[2].ToString().Contains(ErrorDetails)) // Modify with your type of log
            .MustHaveHappened(1, Times.Exactly);

            Assert.IsNotNull(mainpkgExt);
            Assert.IsNotNull(_fakecrmServiceAdapter);
            Assert.IsNotNull(mainpkgExt);
            Assert.AreEqual(result, false);
        }

        [TestCleanup]
        public void cleanup()
        {
            _MainPackageextService = null;
            _fakecrmServiceAdapter = null;
            _fakelogger = null;
        }
    }
}