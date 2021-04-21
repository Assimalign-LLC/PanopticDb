using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Main
{
    class ObjectCreationContext : IObjectCreationContext
    {
        public void RestoreEnvironment(ThreadConnectionDescriptor threadConnectionDescriptor, IObjectCreationContext objectCreationContext)
        {
            if (objectCreationContext == null)
                return;


        }

        public IObjectCreationContext SetBackup(ThreadConnectionDescriptor threadConnectionDescriptor)
        {
            throw new NotImplementedException();
        }
    }
}
