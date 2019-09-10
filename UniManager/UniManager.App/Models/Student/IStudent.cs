using System;
using System.Linq;
using System.Threading.Tasks;

namespace UniManager.App.Models.Student
{
    public interface IStudent
    {
        int RollNo { get; set; }
        Course Course { get; set; }
    }
}
