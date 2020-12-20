using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class UndoCommand : Command
    {
        readonly App app;
        readonly Editor editor;

        public UndoCommand(App app, Editor editor) : base(app, editor)
        {
            this.app = app;
            this.editor = editor;
        }
        public override bool Execute()
        {
            app.Undo();
            return false;
        }
    }
}
