using AutomationKIT_Main.PackageExtensions;

namespace AutomationKIT_Main.ExtensionClasses
{
    public class MainPackageExt
    {
        private IPackageExtensions _packageExtensions;
        public MainPackageExt( IPackageExtensions package)
        {
            _packageExtensions = package;
        }
        public bool AssignUsersToRole(string useremailIds, string SecurityRoleName)
        {
            return _packageExtensions.AssignUsersToRole(useremailIds, SecurityRoleName);
        }

    }
}
