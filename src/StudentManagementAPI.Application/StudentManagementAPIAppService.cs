using System;
using System.Collections.Generic;
using System.Text;
using StudentManagementAPI.Localization;
using Volo.Abp.Application.Services;

namespace StudentManagementAPI;

/* Inherit your application services from this class.
 */
public abstract class StudentManagementAPIAppService : ApplicationService
{
    protected StudentManagementAPIAppService()
    {
        LocalizationResource = typeof(StudentManagementAPIResource);
    }
}
