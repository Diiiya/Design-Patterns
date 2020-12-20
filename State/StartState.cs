using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class StartState : State
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state: ");
            context.SetState(this);
        }

        public override String ToString()
        {
            return "Start state > ";
        }
    }
}
