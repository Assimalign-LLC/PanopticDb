using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Fields
{
    public enum FieldType : int
    {
        PANOPTIC_TYPE_DECIMAL,
        PANOPTIC_TYPE_TINY,
        PANOPTIC_TYPE_SHORT,
        PANOPTIC_TYPE_LONG,
        PANOPTIC_TYPE_FLOAT,
        PANOPTIC_TYPE_DOUBLE,
        PANOPTIC_TYPE_NULL,
        PANOPTIC_TYPE_TIMESTAMP,
        PANOPTIC_TYPE_LONGLONG,
        PANOPTIC_TYPE_INT24,
        PANOPTIC_TYPE_DATE,
        PANOPTIC_TYPE_TIME,
        PANOPTIC_TYPE_DATETIME,
        PANOPTIC_TYPE_YEAR,
        PANOPTIC_TYPE_NEWDATE, /**< Internal to PANOPTIC. Not used in protocol */
        PANOPTIC_TYPE_VARCHAR,
        PANOPTIC_TYPE_BIT,
        PANOPTIC_TYPE_TIMESTAMP2,
        PANOPTIC_TYPE_DATETIME2,   /**< Internal to PANOPTIC. Not used in protocol */
        PANOPTIC_TYPE_TIME2,       /**< Internal to PANOPTIC. Not used in protocol */
        PANOPTIC_TYPE_TYPED_ARRAY, /**< Used for replication only */
        PANOPTIC_TYPE_INVALID = 243,
        PANOPTIC_TYPE_BOOL = 244, /**< Currently just a placeholder */
        PANOPTIC_TYPE_JSON = 245,
        PANOPTIC_TYPE_NEWDECIMAL = 246,
        PANOPTIC_TYPE_ENUM = 247,
        PANOPTIC_TYPE_SET = 248,
        PANOPTIC_TYPE_TINY_BLOB = 249,
        PANOPTIC_TYPE_MEDIUM_BLOB = 250,
        PANOPTIC_TYPE_LONG_BLOB = 251,
        PANOPTIC_TYPE_BLOB = 252,
        PANOPTIC_TYPE_VAR_STRING = 253,
        PANOPTIC_TYPE_STRING = 254,
        PANOPTIC_TYPE_GEOMETRY = 255
    }
}
