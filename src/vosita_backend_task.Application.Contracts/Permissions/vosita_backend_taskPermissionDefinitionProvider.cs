using vosita_backend_task.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace vosita_backend_task.Permissions;

public class vosita_backend_taskPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(vosita_backend_taskPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(vosita_backend_taskPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<vosita_backend_taskResource>(name);
    }
}
