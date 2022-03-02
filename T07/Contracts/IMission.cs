using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using T07.Enums;

namespace T07.Contracts
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }
        void CompleteMission();
    }
}

