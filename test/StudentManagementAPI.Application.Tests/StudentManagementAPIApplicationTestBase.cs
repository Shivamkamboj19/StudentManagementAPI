using Volo.Abp.Modularity;

namespace StudentManagementAPI;

public abstract class StudentManagementAPIApplicationTestBase<TStartupModule> : StudentManagementAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
