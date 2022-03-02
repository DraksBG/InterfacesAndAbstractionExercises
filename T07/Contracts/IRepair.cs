using System;
using System.Collections.Generic;
using System.Text;

namespace T07.Contracts
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }
    }
}
