using System;
using System.Collections.Generic;
using System.Text;
using T07.Contracts;

namespace T07.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; }

        public override string ToString() => base.ToString() + $"Salary: {this.Salary:f2}";
        
    }
}
