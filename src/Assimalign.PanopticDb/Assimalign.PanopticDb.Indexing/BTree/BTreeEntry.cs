using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Indexing.BTree
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
