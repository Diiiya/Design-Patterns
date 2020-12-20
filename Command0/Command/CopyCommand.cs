using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CopyCommand : Command
    {
        readonly App app;
        readonly Editor editor;
        public CopyCommand(App app, Editor editor) : base(app, editor)
        {
            this.app = app;
            this.editor = editor;
        }
        public override bool Execute()
        {
            app.clipboard = editor.GetText();
            return false;
        }
    }
}
