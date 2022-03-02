using System;
using System.Collections.Generic;
using System.Text;
using T04.Contracts;
using T05.Contracts;

namespace T04.Models
{
   public class Citizen : IIdentifiable, IBirthable
    {
        public Citizen(string id, string name, int age, string birthdate)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
        }
        public string Id { get; set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Birthdate { get; set; }
    }
}
