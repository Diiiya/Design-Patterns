using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);
        }
        public override void Update()
        {
            Console.WriteLine("Binary observer: " + Convert.ToString(subject.GetState(), 2));
        }
    }
}
