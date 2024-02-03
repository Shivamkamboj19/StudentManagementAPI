using StudentManagementAPI.Localization;
using Volo.Abp.AspNetCore.Components;

namespace StudentManagementAPI.Blazor;

public abstract class StudentManagementAPIComponentBase : AbpComponentBase
{
    protected StudentManagementAPIComponentBase()
    {
        LocalizationResource = typeof(StudentManagementAPIResource);
    }
}
