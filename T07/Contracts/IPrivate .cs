using System;
using System.Collections.Generic;
using System.Text;

namespace T07.Contracts
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
