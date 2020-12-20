using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class PasteCommand : Command
    {
        readonly App app;
        readonly Editor editor;

        public PasteCommand(App app, Editor editor) : base(app, editor)
        {
            this.app = app;
            this.editor = editor;
        }
        public override bool Execute()
        {
            SaveBackup();
            editor.ReplaceText(app.clipboard);
            return true;
        }
    }
}
