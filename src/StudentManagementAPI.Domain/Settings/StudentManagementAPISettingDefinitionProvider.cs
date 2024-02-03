using Volo.Abp.Settings;

namespace StudentManagementAPI.Settings;

public class StudentManagementAPISettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentManagementAPISettings.MySetting1));
    }
}
