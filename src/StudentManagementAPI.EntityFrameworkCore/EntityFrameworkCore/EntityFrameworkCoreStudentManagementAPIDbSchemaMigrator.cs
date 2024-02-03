using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentManagementAPI.Data;
using Volo.Abp.DependencyInjection;

namespace StudentManagementAPI.EntityFrameworkCore;

public class EntityFrameworkCoreStudentManagementAPIDbSchemaMigrator
    : IStudentManagementAPIDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentManagementAPIDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the StudentManagementAPIDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentManagementAPIDbContext>()
            .Database
            .MigrateAsync();
    }
}
