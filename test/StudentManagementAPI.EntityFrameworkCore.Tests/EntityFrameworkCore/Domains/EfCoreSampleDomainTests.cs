using StudentManagementAPI.Samples;
using Xunit;

namespace StudentManagementAPI.EntityFrameworkCore.Domains;

[Collection(StudentManagementAPITestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StudentManagementAPIEntityFrameworkCoreTestModule>
{

}
