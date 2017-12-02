using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public  interface Idayphoto_comt
    {
        int InsertPhotoComt(dayphoto_comt comt);
        DataTable SelectAll();
        DataTable SelectPhotoComt_cont(string cont);
        DataTable SelectPhotoDate(DateTime date);
    }
}
