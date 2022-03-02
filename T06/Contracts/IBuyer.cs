using System;

namespace T06.Contracts
{
    public interface IBuyer
    {
        string Name { get; }
        int Food { get; }
        void BuyFood();
    }
}
