using System;
using System.Collections.Generic;
using System.Text;
using T05.Contracts;

namespace T05.Models
{
    public class Pet: IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Birthdate { get; set; }
        public string Name { get; set; }
    }
}
