using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniManager.App.Models.Employees;

namespace UniManager.App.Models.Departments
{
    public interface IDepartment
    {
        int Id { get; set; }
        List<IEmployee> Employees { get; set; }
        
    }
}
