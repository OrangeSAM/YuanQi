using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using models;
using IDAL;

namespace DAL
{
   public  class SqlserverTravel_record:Itravel_record
    {
       public int InsertTravel_record(travel_record travel_Record)
        {
            string sql = "insert into travel_record(user_id,record_author,record_title,record_cont,record_cover) values (@user_id,@record_author,@record_title,@record_cont,@record_cover)";
            SqlParameter[] para =
            {
                new SqlParameter("@user_id",travel_Record .user_id),
                new SqlParameter ("@record_author",travel_Record .record_author ),
                new SqlParameter ("@record_title",travel_Record .record_title ),
                new SqlParameter ("@record_cont",travel_Record .record_cont ),
                new SqlParameter ("@record_cover",travel_Record .record_cover )

            };
            return DBHelper.GetExcuteNonQuery(sql, para);
                
        }
       public  DataTable SelectTravel_record(int trreccord_id)
        {
            string sql = "select *,user_name,user_id from travel_record,users where travel_record.user_id=users.user_id and trreccord_id=@trreccord_id";
            SqlParameter[] para = { new SqlParameter("@trreccord_id", trreccord_id) };
            return DBHelper.GetFillData(sql, para);
        }
        public DataTable SelectUserTravel_record(int user_id)
        {
            string sql = "select * from travel_record where user_id=@user_id";
            SqlParameter[] sp =
            {
                new SqlParameter ("@user_id",user_id )

             };
            return DBHelper.GetFillData(sql, sp);

        }
       public  DataTable SelectAll()
        {
            string sql = "select a.*,b.user_name from travel_record a,users b where a.user_id=b.user_id order by pub_time desc";
            return DBHelper.GetFillData(sql);
        }

        public int UpdateLike(int trreccord_id)
        {
            string sql = "update travel_record set Like=Like+1 where trreccord_id=@trreccord_id";
            SqlParameter[] para = { new SqlParameter("@trreccord_id", trreccord_id) };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }

        public int UpdateDislike(int trreccord_id)
        {
            string sql = "update travel_record set Dislike=Dislike+1 where trreccord_id=@trreccord_id";
            SqlParameter[] para = { new SqlParameter("@trreccord_id", trreccord_id) };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
    }
}
