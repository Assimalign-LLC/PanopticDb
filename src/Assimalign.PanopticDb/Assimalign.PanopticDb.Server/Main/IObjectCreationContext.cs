using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Main
{
    internal interface IObjectCreationContext
    {
        Char
        IObjectCreationContext SetBackup(ThreadConnectionDescriptor threadConnectionDescriptor);

        IObjectCreationContext CreateBackupContext(ThreadConnectionDescriptor threadConnectionDescriptor);

        void DeleteBackupContext();

        void RestoreEnvironment(ThreadConnectionDescriptor threadConnectionDescriptor, IObjectCreationContext objectCreationContext);

        void ChangeEnvironment(ThreadConnectionDescriptor threadConnectionDescriptor);
    }
}
