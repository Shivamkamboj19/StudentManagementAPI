using System;
using Volo.Abp.Domain.Entities;

namespace StudentManagementAPI.Entities
{
    public class Student : BasicAggregateRoot<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }  = string.Empty;
        public string Email { get; set; } = string.Empty;   
        public string Password {  get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
    }
}
