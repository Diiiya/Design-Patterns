using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CutCommand : Command
    {
        readonly App app;
        readonly Editor editor;

        public CutCommand(App app, Editor editor) : base(app, editor)
        {
            this.app = app;
            this.editor = editor;
        }
        public override bool Execute()
        {
            SaveBackup();
            app.clipboard = editor.GetText();
            editor.DeleteText();
            return true;
        }
    }
}
