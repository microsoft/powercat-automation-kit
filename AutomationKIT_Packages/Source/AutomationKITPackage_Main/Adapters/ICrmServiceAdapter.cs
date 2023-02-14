using System;
using Microsoft.Xrm.Sdk;

namespace AutomationKIT_Main.Adapters
{
    public interface ICrmServiceAdapter:IOrganizationService
    {

        Guid RetrieveUserId(string emailId);
        Guid RetrieveSecurityGroupID(string securityGroupName);
        
    }

}
