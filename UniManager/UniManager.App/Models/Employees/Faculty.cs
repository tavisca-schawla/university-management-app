using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniManager.App.Models.Common;

namespace UniManager.App.Models.Employees
{
    public class Faculty : IFaculty
    {
        public int Id { get; set; }

        public string EmployeeId { get; set; }

        public Department Department { get; set; }

        public FacultyTitle Title { get; set; }

        public string Subject { get; set; }

        public decimal Salary { get; set; }

        public int Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Address Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}
