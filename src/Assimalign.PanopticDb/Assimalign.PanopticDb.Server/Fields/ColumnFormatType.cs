using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Fields
{
    internal enum ColumnFormatType
    {
        COLUMN_FORMAT_TYPE_DEFAULT = 0, /* Not specified (use engine default) */
        COLUMN_FORMAT_TYPE_FIXED = 1,   /* FIXED format */
        COLUMN_FORMAT_TYPE_DYNAMIC = 2  /* DYNAMIC forma */
    }
}
