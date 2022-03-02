using System;
using System.Collections.Generic;
using System.Text;
using T07.Contracts;

namespace T07.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<ISoldier> privates;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }
        // this is new shorthand syntax
        public IReadOnlyCollection<ISoldier> Privates => this.privates;
        //Classical way of retuning the get method 
        //{
        //    get
        //    {
        //     return this.privates
        //    }
        //}
        public void AddPrivate(ISoldier @private)
        {
            this.privates.Add(@private);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Privates: ");
            foreach (var @private in this.privates)
            {
                sb.AppendLine($"  {@private.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
