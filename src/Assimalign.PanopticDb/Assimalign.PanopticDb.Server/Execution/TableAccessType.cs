using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Execution
{
    internal enum TableAccessType
    {
        /** For default initialization.*/
        AT_VOID,
        /** Value has already been fetched / determined by optimizer.*/
        AT_FIXED,
        /** Do a lookup of a single primary key.*/
        AT_PRIMARY_KEY,
        /** Do a lookup of a single unique index key.*/
        AT_UNIQUE_KEY,
        /** Scan an ordered index with a single upper and lower bound pair.*/
        AT_ORDERED_INDEX_SCAN,
        /** Do a multi range read for a set of primary keys.*/
        AT_MULTI_PRIMARY_KEY,
        /** Do a multi range read for a set of unique index keys.*/
        AT_MULTI_UNIQUE_KEY,
        /**
          Do a multi range read for a mix of ranges (for which there is an
          ordered index), and either primary keys or unique index keys.
        */
        AT_MULTI_MIXED,
        /** Scan a table. (No index is assumed to be used.) */
        AT_TABLE_SCAN,
        /** Access method will not be chosen before the execution phase.*/
        AT_UNDECIDED,
        /**
          The access method has properties that prevents it from being pushed to a
          storage engine.
         */
        AT_OTHER
    }
}
