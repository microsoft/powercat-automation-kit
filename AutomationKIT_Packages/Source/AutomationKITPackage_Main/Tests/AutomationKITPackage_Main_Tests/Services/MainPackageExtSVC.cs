using AutomationKIT_Main.Adapters;
using Microsoft.Xrm.Sdk;
using AutomationKIT_Main;
using AutomationKIT_Main.PackageExtensions;
using Microsoft.Extensions.Logging;

namespace AutomationKITPackage_Main_Tests.Services
{
    public class MainPackageExtSVC:PackageExtensions
    {
        private ICrmServiceAdapter crmSvc;
        
        private readonly ILogger logger;

        public MainPackageExtSVC(ICrmServiceAdapter CrmSvc,ILogger logger ):base(CrmSvc, logger)
        {
            this.crmSvc= CrmSvc;
            this.logger = logger;
        }                

        public override bool AssignUsersToRole(string userEmailslist, string securityRole)
        {
            var result = false;
            
            if (string.IsNullOrEmpty(userEmailslist) )
            {
                logger.LogError("Email id is Empty or blank");
                return result;
            }

            if (string.IsNullOrEmpty(securityRole) )
            {
                logger.LogError("Security role is Empty or blank");
                return result;
            }

            var roleid = crmSvc.RetrieveSecurityGroupID(securityRole);   

            string[] usersList = userEmailslist.Split(',');
            for (int i = 0; i < usersList.Length; i++)
            {
                var userid = crmSvc.RetrieveUserId(usersList[i]);

                try
                {
                    
                    crmSvc.Associate(Constants.systemuser.LogicalName, userid, new Relationship("systemuserroles_association"), new EntityReferenceCollection() { new EntityReference(Constants.role.LogicalName, roleid) });
                    this.logger.LogInformation("Role Assigned Successfully.");
                    result = true;
                }
                catch (Exception ex)
                {
                    this.logger.LogError ($"Unable to associate user {usersList[i]} to role {securityRole}. Exception is {ex.Message}.");
                    result = false;
                }

            }


            return result;
        }
    }
}

