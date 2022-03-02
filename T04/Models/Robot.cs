using System;
using System.Collections.Generic;
using System.Text;
using T04.Contracts;

namespace T04.Models
{
   public class Robot : IIdentifiable
    {
        public Robot(string id, string model)
        {
            this.Id = id;
            this.Model = model;
        }
        public string Id { get; set; }
        public string Model { get; private set; }
    }
}
