using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : ITarget
    {
        private readonly ExternalLibrary externalLibrary;

        public Adapter(ExternalLibrary externalLibrary)
        {
            this.externalLibrary = externalLibrary;
        }
        public string GetRequest()
        {
            return this.externalLibrary.GetSpecificRequest();
        }
    }
}
