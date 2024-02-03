using StudentManagementAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace StudentManagementAPI.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentManagementAPIEntityFrameworkCoreModule),
    typeof(StudentManagementAPIApplicationContractsModule)
    )]
public class StudentManagementAPIDbMigratorModule : AbpModule
{
}
