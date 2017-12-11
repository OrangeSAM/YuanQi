using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;
using DALFactory;

namespace BLL
{
   public  class Travel_recordManager
    {
        private static Itravel_record itravel_record = DataAccess.Createtravel_record();
        public static int InsertTravel_record(travel_record travel_Record)
        {
            return itravel_record.InsertTravel_record(travel_Record);
        }
        public static DataTable SelectTravel_record(int trreccord_id)
        {
            return itravel_record.SelectTravel_record(trreccord_id);
        }
        public static DataTable SelectUserTravel_record(int user_id)
        {
            return itravel_record.SelectUserTravel_record(user_id);
        }
        public static DataTable SelectAll()
        {
            return itravel_record.SelectAll();
        }
        public static DataTable SelectTop(int top)
        {
            return itravel_record.SelectTop(top);
        }

        public static int UpdateLike(int trreccord_id)
        {
            return itravel_record.UpdateLike(trreccord_id);
        }
        public static int UpdateDislike(int trreccord_id)
        {
            return itravel_record.UpdateDislike(trreccord_id);
        }
    }
}
