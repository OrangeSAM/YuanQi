using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public  interface Iactivity
   {
        int InsertActivity(activity activity);
       
        SqlDataReader Selectusers(string user_name);
        DataTable SelectActivity(int activity_id);
        DataTable SelectAll();
        //DataTable SelectActDate(DateTime date);


    }
}
