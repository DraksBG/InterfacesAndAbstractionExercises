using System;
using System.Collections.Generic;
using System.Text;
using T07.Contracts;
using T07.Enums;

namespace T07.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            ParseState(state);
        }

        private void ParseState(string stateStr)
        {
            State state;

            bool parsed = Enum.TryParse<State>(stateStr, out state);
            if (!parsed)
            {
                throw new ArgumentException("Invalid Mission!");
            }

            this.State = state;
        }

        public string CodeName { get; private set; }
        public State State { get; private set; }
        public void CompleteMission()
        {
            if (this.State == State.Finished)
            {
                throw new InvalidOperationException("Mission already finished!");
            }

            this.State = State.Finished;
        }

        public override string ToString()
            => $"Code Name: {this.CodeName} State: {this.State.ToString()}";

    }
}
