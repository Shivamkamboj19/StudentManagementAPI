using Volo.Abp.Modularity;

namespace StudentManagementAPI;

[DependsOn(
    typeof(StudentManagementAPIApplicationModule),
    typeof(StudentManagementAPIDomainTestModule)
)]
public class StudentManagementAPIApplicationTestModule : AbpModule
{

}
