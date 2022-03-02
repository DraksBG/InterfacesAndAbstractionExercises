using System;
using System.Collections.Generic;
using System.Text;
using T07.Enums;

namespace T07.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
