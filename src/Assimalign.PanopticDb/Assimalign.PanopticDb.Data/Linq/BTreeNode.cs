using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.PanopticDb.Data.Linq
{
    internal class BTreeNode<TKey, TPointer>
    {
        private int degree;

        public BTreeNode(int degree)
        {
            this.degree = degree;
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
                return this.Entries.Count == (2 * this.degree) - 1;
            }
        }

        public bool HasReachedMinEntries
        {
            get
            {
                return this.Entries.Count == this.degree - 1;
            }
        }
    }
}
