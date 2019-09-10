using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;
using UniManager.App.Models.Student;
using UniManager.App.Models.Employees;

namespace UniManager.Tests.Student
{
    public class StudentFixture
    {
        private IStudent _student = new UniManager.App.Models.Student.Student();
        [Fact]
        public void Student_should_have_implemented_person_interface()
        {
            _student.GetType().Should().Implement<IPerson>();
        }
        [Fact]
        public void Student_should_have_implemneted_Istudent_interface()
        {
            _student.GetType().Should().Implement<IStudent>();
        }
    }
}
