using System.Threading.Tasks;

namespace StudentManagementAPI.Data;

public interface IStudentManagementAPIDbSchemaMigrator
{
    Task MigrateAsync();
}
