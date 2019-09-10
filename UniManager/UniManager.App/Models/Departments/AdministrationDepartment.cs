using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniManager.App.Models.Employees;

namespace UniManager.App.Models.Departments
{
    public class AdministrationDepartment : IDepartment
    {
        public int Id { get; set; }
        public List<IEmployee> Employees { get; set; }
    }
}
