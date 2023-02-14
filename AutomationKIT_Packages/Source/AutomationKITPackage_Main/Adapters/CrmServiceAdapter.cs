using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;

namespace AutomationKIT_Main.Adapters
{
    public class CrmServiceAdapter : ICrmServiceAdapter, IDisposable

    {
        private readonly CrmServiceClient crmSvc;

        public CrmServiceAdapter(CrmServiceClient crmSvc)
        {
            this.crmSvc = crmSvc;
          
        }       

        public void Associate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            this.crmSvc.Associate(entityName, entityId, relationship, relatedEntities);
        }

        public Guid Create(Entity entity)
        {
            return this.crmSvc.Create(entity);
        }

        public void Delete(string entityName, Guid id)
        {
            this.crmSvc.Delete(entityName, id);
        }

        public void Disassociate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            this.crmSvc.Disassociate(entityName, entityId, relationship, relatedEntities);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            this.crmSvc.Dispose();
        }

        public OrganizationResponse Execute(OrganizationRequest request)
        {
            return this.crmSvc.Execute(request); 
        }

        public Entity Retrieve(string entityName, Guid id, ColumnSet columnSet)
        {
            return this.crmSvc.Retrieve(entityName, id, columnSet); 
        }

        public EntityCollection RetrieveMultiple(QueryBase query)
        {
            return this.crmSvc.RetrieveMultiple(query);
        }

        public Guid RetrieveSecurityGroupID(string securityGroupName)
        {
            var queryRoles = new QueryExpression(Constants.role.LogicalName);
            queryRoles.ColumnSet.AddColumns(Constants.role.Fields.roleid);
            queryRoles.ColumnSet.AddColumns(Constants.role.Fields.name);
            queryRoles.Criteria.AddCondition(Constants.role.Fields.name, ConditionOperator.Equal, securityGroupName);
            Guid roleId = Guid.Empty;
            try
            {
                var resultroles = this.crmSvc.RetrieveMultiple(queryRoles);
                var results = resultroles.Entities[0];
                roleId = (Guid)results[Constants.role.Fields.roleid];
            }  
            catch { throw new Exception("Unable to featch Role to assign "); }   
            return roleId;
        }

        public Guid RetrieveUserId(string emailId)
        {
            var queryusers = new QueryExpression(Constants.systemuser.LogicalName);
            queryusers.ColumnSet.AddColumns(Constants.systemuser.Fields.systemuserid);
            queryusers.Criteria.AddCondition(Constants.systemuser.Fields.internalemailaddress, ConditionOperator.Equal, emailId);
            Guid userId = Guid.Empty;
            try
            {
                var resultusers = this.crmSvc.RetrieveMultiple(queryusers);
                var results = resultusers.Entities[0];
                userId= (Guid)results[Constants.systemuser.Fields.systemuserid];
            }
            catch { throw new Exception("Unable to featch User id to assign "); }

            return userId;
                    
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
