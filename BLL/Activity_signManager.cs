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
   public  class Activity_signManager
    {
        private static Iactivity_sign iactivity_sign = DataAccess.Createactivity_sign();
        public static  int InsertActSign(activity_sign ActSign)
        {
            return iactivity_sign.InsertActSign(ActSign);
        }
        public static DataTable SelectAct_sign(int activity_id)
        {
            return iactivity_sign.SelectAct_sign(activity_id);
        }


    }
}
