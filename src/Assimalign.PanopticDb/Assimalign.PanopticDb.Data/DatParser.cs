using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.PanopticDb.Data
{
    public class DatParser : FileStream, IDatParser
    {
        public DatParser(string path, FileMode mode) : base(path, mode)
        {

        }

        

        // Page Sizes are 8 KB 
        public int PageSize { get; private set; } = 8192;

        // Dat File Header Size is 1MB;
        public long HeaderSize { get; private set; } = 1000000;

        // Lenth of the Entire File - the Haader / Page Size should include the total count of all pages in DAT File
        public long PageCount => base.Length - HeaderSize / PageSize;

        // Sets the Stream Position to start of a page
        // If the position does not match a valid starting position of a page, than an InvalidPagePositionException is thrown.
        public void GoToPage(long position)
        {
            // Since the division operator for long will round up or down 
            // We need to grab the correct location of the Page within the stream
            var pageCount = position / PageSize; 
            var correctPosition = pageCount * PageSize;

            if (position != correctPosition || position > base.Length)
                throw new Exception("");

            base.Position = position;
        }

        public void AlterateExtends(object Extends)

        public void GetExtends()
        {

        }





    }
}
