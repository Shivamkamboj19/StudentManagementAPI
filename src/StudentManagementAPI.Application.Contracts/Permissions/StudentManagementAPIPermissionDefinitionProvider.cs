using StudentManagementAPI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace StudentManagementAPI.Permissions;

public class StudentManagementAPIPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentManagementAPIPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentManagementAPIPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentManagementAPIResource>(name);
    }
}
