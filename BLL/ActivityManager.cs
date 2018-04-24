using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using DALFactory;
using Models;

namespace BLL
{
   public  class ActivityManager
    {
        private static Iactivity iactivity = DataAccess.Createactivity();
        public static  int InsertActivity(activity activity)
        {
            return iactivity.InsertActivity(activity);
        }
        public static  DataTable Selectusers(string user_name)
        {
            return iactivity.Selectusers(user_name);
        }
        public static  DataTable SelectAll()
        {
            return iactivity.SelectAll();
        }
        public static  DataTable SelectActivity(int activity_id)
        {
            return iactivity.SelectActivity(activity_id);
        }

    }
}
