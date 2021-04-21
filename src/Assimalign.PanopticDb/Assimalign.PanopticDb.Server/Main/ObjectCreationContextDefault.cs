using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Main
{
    class ObjectCreationContextDefault : IObjectCreationContext
    {
        public void RestoreEnvironment(ThreadConnectionDescriptor threadConnectionDescriptor, IObjectCreationContext objectCreationContext)
        {
            throw new NotImplementedException();
        }

        public IObjectCreationContext SetBackup(ThreadConnectionDescriptor threadConnectionDescriptor)
        {
            throw new NotImplementedException();
        }
    }
}
