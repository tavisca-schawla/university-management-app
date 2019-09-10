using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniManager.App.Models.Common
{
    public class Address
    {
        string FirstLine { get; set; }
        string SecondLine { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }
        int PinCode { get; set; }

    }
}
