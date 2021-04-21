using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Files
{
    internal enum FileFlags
    {
        EOL = 0, // End of Line
        EOS = 2, // End of Segment,
        EOB = 1, // End of Block
        EOC = 4, // End of Container 
        EOF = 1  // End of File
    }
}
