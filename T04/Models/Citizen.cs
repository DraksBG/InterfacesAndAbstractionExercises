using System;
using System.Collections.Generic;
using System.Text;
using T04.Contracts;

namespace T04.Models
{
   public class Citizen : IIdentifiable
    {
        public Citizen(string id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public string Id { get; set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}
