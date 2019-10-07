using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniManager.App.Models.Common;

namespace UniManager.App.Models.Employees
{
    public interface IEmployee : IPerson
    {
        int Id { get; set; }

        string EmployeeId { get; set; }

        Department Department { get; set; }

        decimal Salary { get; set; }
    }
}
