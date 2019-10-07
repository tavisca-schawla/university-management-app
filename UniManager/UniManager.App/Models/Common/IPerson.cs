using System;
using UniManager.App.Models.Common;

namespace UniManager.App.Models.Employees
{
    public interface IPerson
    {
        int Name { get; set; }

        Gender Gender { get; set; }

        DateTime DateOfBirth { get; set; }

        Address Address { get; set; }

        string PhoneNumber { get; set; }

    }
}