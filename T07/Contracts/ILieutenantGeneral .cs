using System;
using System.Collections.Generic;
using System.Text;

namespace T07.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<ISoldier> Privates { get; }
    }
}
