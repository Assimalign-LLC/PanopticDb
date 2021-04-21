using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Main
{
    public enum TableReferenceType
    {
        TABLE_REF_NULL = 0,
        TABLE_REF_VIEW,
        TABLE_REF_BASE_TABLE,
        TABLE_REF_I_S_TABLE,
        TABLE_REF_TMP_TABLE
    }
}
