using System;

namespace Assimalign.PanopticDb.Data
{
    internal interface IPagingCommands
    {

        void DeletePage(long position, object page);

        void EditPage(long position, object page);

        void ReplacePage(long position, object page);

        object GetPage(long position);

        object CreatePage();

        void WritePage(long position, object page);
    }
}
