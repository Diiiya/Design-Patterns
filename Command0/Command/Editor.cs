using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Editor
    {
        public string text;

        public string GetText()
        {
            //Console.WriteLine(this.text);
            return this.text;
        }

        public void DeleteText()
        {
            this.text = "";
        }

        public void ReplaceText(string newText)
        {
            this.text = newText;
        }
    }
}
