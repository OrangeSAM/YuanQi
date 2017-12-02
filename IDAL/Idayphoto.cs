using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public  interface Idayphoto
    {
        int InsertDayphoto(dayphoto photo);
        int DeleteDayphoto(int photo_id);
        DataTable SelectAll();
        DataTable SelectDayphoto(int photo_id);
        DataTable SelectDay(string type,string year,string month);
    }
}
