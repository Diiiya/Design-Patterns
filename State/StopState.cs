using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class StopState : State
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state.");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Stop state >";
        }
    }
}
