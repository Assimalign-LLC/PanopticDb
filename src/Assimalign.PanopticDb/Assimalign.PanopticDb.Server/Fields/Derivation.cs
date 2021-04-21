using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Fields
{
    internal enum Derivation
    {
        DERIVATION_IGNORABLE = 6,
        DERIVATION_NUMERIC = 5,
        DERIVATION_COERCIBLE = 4,
        DERIVATION_SYSCONST = 3,
        DERIVATION_IMPLICIT = 2,
        DERIVATION_NONE = 1,
        DERIVATION_EXPLICIT = 0
    }
}
