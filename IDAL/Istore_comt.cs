using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;

namespace IDAL
{
   public interface Istore_comt
    {
        int InsertStore_comt(store_comt store_Comt );
        int DeleteStore_comt(int stcomt_id);
        DataTable SelectStore_comt(int stcomt_id);
        DataTable SelectAll();
    }
}
