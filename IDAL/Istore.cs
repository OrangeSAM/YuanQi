using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;

namespace IDAL
{
   public interface Istore
    {
        int InsertStore(store store);
        int UpdateStore(store store);
        int DeleteStore(int store_id);
        DataTable SelectAll();
        DataTable SelectStoreAddr(string store_addr);

    }
}
