using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Fields
{
    internal static class FieldUtility
    {
        public const int FIELDTYPE_TEAR_TO = 243 - 1;
        public const int FIELDTYPE_TEAR_FROM = (int)FieldType.PANOPTIC_TYPE_BIT + 1;
        public const int FIELDTYPE_NUM = (FIELDTYPE_TEAR_FROM + (255 - FIELDTYPE_TEAR_TO));


        public static int FieldTypeTwoIndex(FieldType fieldType)
        {
            var convertFieldType = (int)RealTypeToType(fieldType);
            return (convertFieldType < FIELDTYPE_TEAR_FROM ? convertFieldType : ((int)FIELDTYPE_TEAR_FROM) + (convertFieldType - FIELDTYPE_TEAR_TO) - 1);
        }

        /// <summary>
        /// Convert temporal real types as retuned by field->real_type() to field type as returned by field->type().
        /// </summary>
        /// <param name="fieldType"></param>
        /// <returns></returns>
        public static FieldType RealTypeToType(FieldType fieldType)
        {
            switch (fieldType)
            {
                case FieldType.PANOPTIC_TYPE_TIME2:
                    return FieldType.PANOPTIC_TYPE_TIME;

                case FieldType.PANOPTIC_TYPE_DATETIME2:
                    return FieldType.PANOPTIC_TYPE_DATETIME;

                case FieldType.PANOPTIC_TYPE_TIMESTAMP2:
                    return FieldType.PANOPTIC_TYPE_TIMESTAMP;

                case FieldType.PANOPTIC_TYPE_NEWDATE:
                    return FieldType.PANOPTIC_TYPE_DATE;
                /* Note: NEWDECIMAL is a type, not only a real_type */
                default:
                    return fieldType;
            }
        }
    }
}
