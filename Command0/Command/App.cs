using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class App
    {
        public string clipboard;
        public List<Editor> editors;
        public Editor activeEditor;
        public CommandHistory history;

        public void CreateUI()
        {
           /* copy = function() {
                executeCommand(new CopyCommand(this, activeEditor)) }
                copyButton.setCommand(copy)
                shortcuts.onKeyPress("Ctrl+C", copy) 
           ... similarly for cut, paste, undo*/

        }
    }
}
