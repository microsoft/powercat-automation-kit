using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;
using System;
using AutomationKIT_Main.Adapters;
using Microsoft.Extensions.Logging;

namespace AutomationKIT_Main.PackageExtensions
{
    public class PackageExtensions : IPackageExtensions
    {
        private TraceLogger PackageLogger;
        private readonly ILogger logger;

        private readonly ICrmServiceAdapter CrmSvc;
        

        public PackageExtensions(ICrmServiceAdapter crmSvc, ILogger logger) 
        {
            logger = logger;
            CrmSvc = crmSvc;
        } 

        public virtual bool AssignUsersToRole(string userEmailslist, string securityRole)
        {

            //PackageLog.Log("Assigning users to security role '" + securityRole + "'");
            Guid roleid = Guid.Empty;

            bool result = false;

            if (!string.IsNullOrEmpty(userEmailslist) && !string.IsNullOrEmpty(securityRole))
            {
                // getting role id
                var queryRoles = new QueryExpression("role");
                queryRoles.ColumnSet.AddColumns("roleid");
                queryRoles.ColumnSet.AddColumns("name");
                queryRoles.Criteria.AddCondition("name", ConditionOperator.Equal, securityRole);
                try
                {
                    var resultroles = CrmSvc.RetrieveMultiple(queryRoles);
                    var results = resultroles.Entities[0];
                    roleid = (Guid)results["roleid"];
                }
                catch (Exception ex)
                {
                    PackageLogger.Log("Unable to retrive role information for role '" + securityRole + "'. Erorr: " + ex.Message.ToString());
                    result = false;
                }

                string[] usersList = userEmailslist.Split(',');
                for (int i = 0; i < usersList.Length; i++)
                {     //getting user id              
                    var queryusers = new QueryExpression("systemuser");
                    queryusers.ColumnSet.AddColumns("systemuserid");
                    queryusers.Criteria.AddCondition("internalemailaddress", ConditionOperator.Equal, usersList[i].ToString());

                    var resultusers = CrmSvc.RetrieveMultiple(queryusers);
                    var results = resultusers.Entities[0];

                    Guid userid = (Guid)results["systemuserid"];

                    //assigning user to role
                    if (roleid != Guid.Empty && userid != Guid.Empty)
                    {
                        try
                        {
                            //CrmSvc.DeleteEntityAssociation("systemuser", userid, "role", roleid, "systemuserroles_association");

                            CrmSvc.Associate("systemuser", userid, new Relationship("systemuserroles_association"), new EntityReferenceCollection() { new EntityReference("role", roleid) });
                            result = true;
                        }
                        catch (Exception ex)
                        {
                            PackageLogger.Log("Unable to assign user '" + usersList[i].ToString() + "' to security role '" + securityRole + "'. Error:" + ex.Message.ToString());
                            result = false;
                        }
                    }

                }
            }

            PackageLogger.Log("Completed of assigning roles");
            return result;
        }
    }
}
