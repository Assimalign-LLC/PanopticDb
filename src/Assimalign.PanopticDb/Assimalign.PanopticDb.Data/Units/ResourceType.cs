using System;

namespace Assimalign.PanopticDb.Data.Units
{
    internal enum ResourceType : short
    {
        RDBFile = 1,                // Relational Database File
        NRKeyValuePairFile = 2,     // Non-Relational Key Value Paired Database File
        NRDocFile = 3,              // Non-Relational Document Database File
        NRColumnFamilyFile = 4,     // Non-Relational Column Database File
        NRGraphFile = 5,            // Non-Relational Graph File
        NRFSGridFile = 6,           // Non-Relational File-System Grid Database File

        // We set system files to 100 to leave room for future database files within pipeline
        LogFile = 101,
        BackupFile = 102,
    }
}
