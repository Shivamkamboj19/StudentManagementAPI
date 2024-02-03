using Volo.Abp.Modularity;

namespace StudentManagementAPI;

/* Inherit from this class for your domain layer tests. */
public abstract class StudentManagementAPIDomainTestBase<TStartupModule> : StudentManagementAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
