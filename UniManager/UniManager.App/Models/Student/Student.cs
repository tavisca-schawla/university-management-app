using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniManager.App.Models.Common;
using UniManager.App.Models.Employees;

namespace UniManager.App.Models.Student
{
    public class Student: IPerson, IStudent
    {
        public int Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public long PhoneNumber { get; set; }
        public int RollNo { get; set; }
        public Course Course { get; set; }
    }
}
