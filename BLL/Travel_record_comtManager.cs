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
    public class Travel_record_comtManager
    {
        private static Itravel_record_comt itravel_Record_Comt = DataAccess.Createtravel_record_comt();
        public static int InsertTravel_record_comt(travel_record_comt travel_Record_Comt)
        {
            return itravel_Record_Comt.InsertTravel_record_comt(travel_Record_Comt);
        }
        public static DataTable SelectAll()
        {
            return itravel_Record_Comt.SelectAll();
        }
        public  static DataTable SelectTravel_record_comt(int trrecord_id)
        {
            return itravel_Record_Comt.SelectTravel_record_comt(trrecord_id);
        }
        public static int DeleteTravel_record_comt(int trcomt_id)
        {
            return itravel_Record_Comt.DeleteTravel_record_comt(trcomt_id);
        }
    }
}
