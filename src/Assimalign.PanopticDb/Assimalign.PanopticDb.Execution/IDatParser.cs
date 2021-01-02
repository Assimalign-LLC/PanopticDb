using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.PanopticDb.Execution
{
    /* Implementation Requirements for Parsing DAT File
     * 1. Need a Method to Locate Correct Page Locations ✓
     * 2. Need a Method to Read Current Page
     */
    internal interface IDatParser : IDisposable
    {
        int PageSize { get; }

        long HeaderSize { get; }

        long PageCount { get; }
       
        void GoToPage(long position);

    }
}
