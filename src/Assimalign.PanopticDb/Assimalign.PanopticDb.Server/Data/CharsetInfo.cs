using System;
using System.Collections.Generic;
using System.Text;

namespace Assimalign.PanopticDb.Server.Data
{
    internal struct CharsetInfo
    {
        uint Number;
        uint PrimaryNumber;
        uint BinaryNumber;
        uint State;
        char CSName;
        char Name;
        string Comment;
        const char* tailoring;
        struct Coll_param *coll_param;
  const uchar* ctype;
        const uchar* to_lower;
        const uchar* to_upper;
        const uchar* sort_order;
        struct MY_UCA_INFO *uca; /* This can be changed in apply_one_rule() */
  const uint16* tab_to_uni;
        const MY_UNI_IDX* tab_from_uni;
        const MY_UNICASE_INFO* caseinfo;
        const struct lex_state_maps_st *state_maps; /* parser internal data */
  const uchar* ident_map;                     /* parser internal data */
        uint strxfrm_multiply;
        uchar caseup_multiply;
        uchar casedn_multiply;
        uint mbminlen;
        uint mbmaxlen;
        uint mbmaxlenlen;
        my_wc_t min_sort_char;
        my_wc_t max_sort_char; /* For LIKE optimization */
        uchar pad_char;
        bool escape_with_backslash_is_dangerous;
        uchar levels_for_compare;

        MY_CHARSET_HANDLER* cset;
        MY_COLLATION_HANDLER* coll;
    }
}
