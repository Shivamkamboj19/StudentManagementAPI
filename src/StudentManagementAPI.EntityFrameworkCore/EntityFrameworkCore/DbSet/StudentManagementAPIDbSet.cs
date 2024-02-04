using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace StudentManagementAPI.EntityFrameworkCore.DbSet
{
    public static class StudentManagementAPIDbSet
    {
        public static void ConfigureStudentManagementAPIDbSet(this ModelBuilder builder)
        {
            builder.Entity<Student>(b =>
            {
                b.ToTable(StudentManagementAPIConsts.StudentProfile, StudentManagementAPIConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });
        }
    }
}
