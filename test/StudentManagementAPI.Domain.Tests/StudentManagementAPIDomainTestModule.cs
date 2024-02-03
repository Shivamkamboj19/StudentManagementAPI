using Volo.Abp.Modularity;

namespace StudentManagementAPI;

[DependsOn(
    typeof(StudentManagementAPIDomainModule),
    typeof(StudentManagementAPITestBaseModule)
)]
public class StudentManagementAPIDomainTestModule : AbpModule
{

}
