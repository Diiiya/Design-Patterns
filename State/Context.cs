using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Context
    {
        State state;
        public Context()
        {
            state = null;
        }

        public State GetState()
        {
            return this.state;
        }

        public void SetState(State state)
        {
            this.state = state;
        }
    }
}
