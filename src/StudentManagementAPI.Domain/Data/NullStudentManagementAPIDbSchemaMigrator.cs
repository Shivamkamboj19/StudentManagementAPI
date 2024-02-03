using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StudentManagementAPI.Data;

/* This is used if database provider does't define
 * IStudentManagementAPIDbSchemaMigrator implementation.
 */
public class NullStudentManagementAPIDbSchemaMigrator : IStudentManagementAPIDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
