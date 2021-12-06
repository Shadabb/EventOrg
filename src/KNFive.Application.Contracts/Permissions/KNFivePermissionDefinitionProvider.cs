using KNFive.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace KNFive.Permissions
{
    public class KNFivePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(KNFivePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(KNFivePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<KNFiveResource>(name);
        }
    }
}
