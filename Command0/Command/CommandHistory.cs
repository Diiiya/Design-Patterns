using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CommandHistory
    {
        Stack<Command> commandsHistory = new Stack<Command>();

        public void Push(Command command)
        {
            commandsHistory.Push(command);
        }

        public void Pop()
        {
            commandsHistory.Pop();
        }
    }
}
