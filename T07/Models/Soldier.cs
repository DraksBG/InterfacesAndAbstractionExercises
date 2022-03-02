using System;
using System.Collections.Generic;
using System.Text;
using T07.Contracts;

namespace T07.Models
{
    public abstract class Soldier : ISoldier
    {
        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public override string ToString()
            => $"Name: {this.FirstName} {this.LastName} Id: {this.Id} ";


    }
}
