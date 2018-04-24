using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace IDAL
{
   public  interface Itrrecord_col
    {
        int UpdateClickNum(int trcol_id);
        int InsertTrrecord(trrecord_col trrecord_Col);
    }
}
