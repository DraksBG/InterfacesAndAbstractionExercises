using System;
using System.Collections.Generic;
using System.Text;

namespace T07.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
    }
}
