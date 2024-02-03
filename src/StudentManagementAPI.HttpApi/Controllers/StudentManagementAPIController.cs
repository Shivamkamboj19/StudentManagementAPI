using StudentManagementAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentManagementAPI.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentManagementAPIController : AbpControllerBase
{
    protected StudentManagementAPIController()
    {
        LocalizationResource = typeof(StudentManagementAPIResource);
    }
}
