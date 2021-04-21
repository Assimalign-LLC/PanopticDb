using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Indexing.BTree
{
	internal class BTreeNode<TKey, TPointer>
	{
		private int Degree;

		public BTreeNode(int degree)
		{
			this.Degree = degree;
			this.Children = new List<BTreeNode<TKey, TPointer>>(degree);
			this.Entries = new List<BTreeEntry<TKey, TPointer>>(degree);
		}

		public List<BTreeNode<TKey, TPointer>> Children { get; set; }

		public List<BTreeEntry<TKey, TPointer>> Entries { get; set; }

		public bool IsLeaf
		{
			get
			{
				return this.Children.Count == 0;
			}
		}

		public bool HasReachedMaxEntries
		{
			get
			{
				return this.Entries.Count == (2 * this.Degree) - 1;
			}
		}

		public bool HasReachedMinEntries
		{
			get
			{
				return this.Entries.Count == this.Degree - 1;
			}
		}
	}
}
