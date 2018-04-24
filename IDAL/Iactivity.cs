using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public  interface Iactivity
   {
        int InsertActivity(activity activity);
       
        DataTable Selectusers(string user_name);
        DataTable SelectActivity(int activity_id);
        DataTable SelectAll();
        //DataTable SelectActDate(DateTime date);


    }
}
