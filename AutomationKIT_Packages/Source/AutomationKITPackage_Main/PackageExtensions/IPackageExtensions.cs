using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationKIT_Main.PackageExtensions
{
    public interface IPackageExtensions
    {
        bool AssignUsersToRole(string userEmailslist, string securityRole);        

    }
}
