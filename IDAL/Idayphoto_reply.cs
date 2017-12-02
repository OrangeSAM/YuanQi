using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public  interface Idayphoto_reply
    {
        int InsertDayphoto_re(dayphoto_reply dayphoto_reply);
        DataTable SelectDayphoto_re(int dayreply_id);       
        DataTable UserDayphoto_re(int user_id);
        DataTable SelectAll();
        int DeleteDayphoto_re(int dayreply_id);
    }
}
