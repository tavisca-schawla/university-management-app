using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using UniManager.App.Models.Employees;
using Xunit;

namespace UniManager.Tests.Employees
{
    public class FacultyFixture
    {
        [Fact]
        public void Faculty_should_have_basic_fields()
        {
            Faculty employee = new Faculty();
            employee.GetType().GetProperty("Id").Should().NotBeNull();
            employee.GetType().GetProperty("EmployeeId").Should().NotBeNull();
            employee.GetType().GetProperty("Department").Should().NotBeNull();
            employee.GetType().GetProperty("Title").Should().NotBeNull();
            employee.GetType().GetProperty("Subject").Should().NotBeNull();
            employee.GetType().GetProperty("Salary").Should().NotBeNull();
            employee.GetType().GetProperty("Name").Should().NotBeNull();
            employee.GetType().GetProperty("Gender").Should().NotBeNull();
            employee.GetType().GetProperty("DateOfBirth").Should().NotBeNull();
            employee.GetType().GetProperty("Address").Should().NotBeNull();
            employee.GetType().GetProperty("PhoneNumber").Should().NotBeNull();
        }
    }
}