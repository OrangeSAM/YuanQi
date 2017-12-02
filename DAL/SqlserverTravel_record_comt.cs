using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public  class SqlserverTravel_record_comt:Itravel_record_comt 
    {
       public  int InsertTravel_record_comt(travel_record_comt travel_Record_Comt)
        {
            string sql = "insert into travel_record_comt values(@user_id,@trrecord_id,@comt_cont,@comt_time)";
            SqlParameter[] sp =
            {
                new SqlParameter ("@user_id",travel_Record_Comt .user_id ),
                new SqlParameter("@trrecord_id",travel_Record_Comt .trrecord_id),
                new SqlParameter("@comt_cont",travel_Record_Comt .comt_cont),
                new SqlParameter("@comt_time",travel_Record_Comt .comt_time)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
       public  DataTable SelectAll()
        {
            string sql = "select a.*,b.user_name,c.trrecord_name from travel_record_comt a,users b,travel_record c where a.user_id=b.user_id and b.trrecord_id=c.trrecord_id";
            return DBHelper.GetFillData(sql);
        }
       public DataTable SelectTravel_record_comt(int trrecord_id)
        {
            string sql = "select travel_record_comt.*,user_name from travel_record_comt,users where travel_record_comt.user_id=users.user_id and trrecord_id=@trrecord_id order by comt_time desc";
            SqlParameter[] sp = { new SqlParameter("@trrecord_id", trrecord_id) };
            return DBHelper.GetFillData(sql, sp);

        }
       public  int DeleteTravel_record_comt(int trcomt_id)
        {
            string sql = "delete from travel_comt_reply where trcomt_id=@trcomt_id delete from travel_record_comt wheretrcomt_id=@trcomt_id ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter ("@trcomt_id",trcomt_id)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
