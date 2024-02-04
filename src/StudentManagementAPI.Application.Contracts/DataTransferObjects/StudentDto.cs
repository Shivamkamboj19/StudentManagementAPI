using System;

namespace StudentManagementAPI.DataTransferObjects
{
    public class StudentDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
    }
}
