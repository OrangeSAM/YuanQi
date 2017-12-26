using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Models;
using System.Data;

namespace IDAL
{
   public  interface Iactivity_sign
    {
        int InsertActSign(activity_sign ActSign);
        //SqlDataReader Selectusers(string user_name);
        DataTable SelectAct_sign(int activity_id);
    }
}
