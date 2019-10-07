using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using UniManager.App.Models.Employees;
using Xunit;

namespace UniManager.Tests.Employees
{
    public class EmployeeFixture
    {
        [Fact]
        public void Employee_should_have_basic_fields()
        {
            Employee employee = new Employee();
            employee.GetType().GetProperty("Id").Should().NotBeNull();
            employee.GetType().GetProperty("EmployeeId").Should().NotBeNull();
            employee.GetType().GetProperty("Department").Should().NotBeNull();
            employee.GetType().GetProperty("Salary").Should().NotBeNull();
            employee.GetType().GetProperty("Name").Should().NotBeNull();
            employee.GetType().GetProperty("Gender").Should().NotBeNull();
            employee.GetType().GetProperty("DateOfBirth").Should().NotBeNull();
            employee.GetType().GetProperty("Address").Should().NotBeNull();
            employee.GetType().GetProperty("PhoneNumber").Should().NotBeNull();
        }
    }
}
