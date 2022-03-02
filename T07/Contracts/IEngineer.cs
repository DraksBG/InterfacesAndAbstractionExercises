using System;
using System.Collections.Generic;
using System.Text;

namespace T07.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }

    
}
