using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniManager.App.Models.Common;

namespace UniManager.App.Models.Employees
{
    public interface IFaculty : IEmployee
    {
        string Subject { get; set; }
        FacultyTitle Title { get; set; }
    }
}
