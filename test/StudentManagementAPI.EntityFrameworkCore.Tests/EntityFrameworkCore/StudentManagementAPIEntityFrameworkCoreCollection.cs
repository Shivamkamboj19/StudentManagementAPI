﻿using Xunit;

namespace StudentManagementAPI.EntityFrameworkCore;

[CollectionDefinition(StudentManagementAPITestConsts.CollectionDefinitionName)]
public class StudentManagementAPIEntityFrameworkCoreCollection : ICollectionFixture<StudentManagementAPIEntityFrameworkCoreFixture>
{

}
