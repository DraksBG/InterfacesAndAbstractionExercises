using System;
using System.Collections.Generic;
using System.Text;
using T07.Contracts;
using T07.Enums;

namespace T07.Models
{
    public class SpecialisedSoldier: Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            ParseCorps(corps);
        }
        public Corps Corps { get; private set; }
        private void ParseCorps(string corpsStr)
        {
            Corps corps;
            bool parsed = Enum.TryParse(corpsStr, out corps);
            if (!parsed)
            {
                throw new ArgumentException("Invalid corps!");
            }

            this.Corps = corps;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps.ToString()}";
        }
    }
}
