using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace StudentManagementAPI;

[Dependency(ReplaceServices = true)]
public class StudentManagementAPIBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentManagementAPI";
}
