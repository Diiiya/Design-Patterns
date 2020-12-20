using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    abstract class Command
    {
        protected App app;
        protected Editor editor;
        protected string backup;

        public Command(App app, Editor editor)
        {
            this.app = app;
            this.editor = editor;
        }

        public void SaveBackup()
        {
            backup = editor.text;
        }

        public void Undo()
        {
            editor.text = backup;
        }

        public abstract bool Execute();
    }
}
