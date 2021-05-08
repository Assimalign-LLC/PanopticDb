using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.PanopticDb.Data.Units
{
    using Constants;

    /* Resource Summary
     * 
     * Glossary:
     * Byte Count   - Is the total count of bytes which will be consumed in the Resources header.
     * Index        - Specifies exactly where in the header the property is located.
     */
    internal class Resource
    {
        private readonly Encoding encoding = GlobalProperties.InternalEncoding;

        public Resource()
        {

        }


        // Byte Count : 16 Bytes (Index: 1 - 16)
        public Guid ResourceId { get; set; }

        // Byte Count : (Index: 17 - 517)
        // Dependeing on Encoding can vary: UTF32 tends to have larger byte arrays
        public string ResourceName { get; set; }

        // Byte Count : 2 Bytes (Index: 518 - 520)
        public ResourceType ResourceType { get; set; }
    }
}
