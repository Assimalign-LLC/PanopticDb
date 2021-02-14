using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.PanopticDb.Data.Linq
{
    internal class BTreeEntry<TKey, TPointer> : IEquatable<BTreeEntry<TKey, TPointer>>
    {
        public TKey Key { get; set; }

        public TPointer Pointer { get; set; }

        public bool Equals(BTreeEntry<TKey, TPointer> other)
        {
            return this.Key.Equals(other.Key) && this.Pointer.Equals(other.Pointer);
        }
    }
}
