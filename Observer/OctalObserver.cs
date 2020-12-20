using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);
        }
        public override void Update()
        {
            Console.WriteLine("Octal observer: " + Convert.ToString(subject.GetState(), 8));
        }
    }
}
