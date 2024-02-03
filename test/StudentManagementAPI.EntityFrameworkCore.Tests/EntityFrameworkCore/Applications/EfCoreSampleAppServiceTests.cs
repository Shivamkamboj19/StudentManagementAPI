using StudentManagementAPI.Samples;
using Xunit;

namespace StudentManagementAPI.EntityFrameworkCore.Applications;

[Collection(StudentManagementAPITestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StudentManagementAPIEntityFrameworkCoreTestModule>
{

}
