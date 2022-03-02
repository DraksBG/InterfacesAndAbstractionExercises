using System;
using System.Collections.Generic;
using System.Text;

namespace T07.Contracts
{
    public interface ISoldier
    {
        string Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
