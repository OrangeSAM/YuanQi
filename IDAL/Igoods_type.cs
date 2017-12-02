using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;

namespace IDAL
{
   public  interface Igoods_type
    {
        int InsertType(goods_type goods_type);
        DataTable  SelectALL();
        DataTable SelectType(string type_id);


    }
}
