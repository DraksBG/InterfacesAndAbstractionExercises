using System;
using System.Collections.Generic;
using System.Text;

namespace T07.Contracts
{
    interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
