using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using models;
using IDAL;

namespace DAL
{
    public class SqlserverTravel_comt_reply : Itravel_comt_reply
    {
        public int DeleteTravel_re(int trreply_id)
        {
            string sql = "delete from travel_comt_reply where trreply_id=@trreply_id";
            SqlParameter[] sp = { new SqlParameter("@trreply_id", trreply_id) };
            return DBHelper.GetExcuteNonQuery(sql, sp);

        }

        public int InsertTravel_re(travel_comt_reply travel_Comt_Reply)
        {
            string sql = "insert into travel_comt_reply values(@trcomt_id,@user_id,@reply_cont,@reply_time)";
            SqlParameter[] sp =
            {
                new SqlParameter ("@trcomt_id",travel_Comt_Reply .trcomt_id ),
                new SqlParameter ("@user_id",travel_Comt_Reply .user_id ),
                new SqlParameter ("@reply_cont",travel_Comt_Reply .reply_cont ),
                new SqlParameter ("@reply_time",travel_Comt_Reply .reply_time )

            };
            return DBHelper.GetExcuteNonQuery(sql, sp);


        }

        public DataTable SelectAll()
        {
            string sql = "select travel_comt_reply.*,a.user_name as 回复人,b.user_name as 被回复人 from users a,users b,travel_comt_reply,travel_record_comt where a.user_id=travel_comt_reply.user_id and b.user_id=travel_record_comt.user_id and travel_comt_reply.trcomt_id=travel_record_comt.trcomt_id";
          
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectTravelReply_comt(int trcomt_id)
        {
            string sql = "select travel_comt_reply.*,a.user_name as 回复人,b.user_name as 被回复人 from users a,users b,travel_comt_reply,travel_record_comt where a.user_id=travel_comt_reply.user_id and b.user_id=travel_record_comt.user_id and travel_comt_reply.trcomt_id=travel_record_comt.trcomt_id and travel_record_comt.trcomt_id=@trcomt_id";
            SqlParameter[] para = { new SqlParameter("@trcomt_id", trcomt_id) };
            return DBHelper.GetFillData(sql, para);
        }

        public DataTable UserTravel_re(int user_id)
        {
            string sql = "select travel_comt_reply.*,a.user_name as 回复人,b.user_name as 被回复人,trreccord_id from users a,users b,travel_comt_reply,travel_record_comt where a.user_id=travel_comt_reply.user_id and b.user_id=travel_record_comt.user_id and travel_comt_reply.trcomt_id=travel_record_comt.trcomt_id and travel_record_comt.user_id=@user_id order by reply_time desc";
            SqlParameter[] para = { new SqlParameter("@user_id", user_id) };
            return DBHelper.GetFillData(sql, para);
        }
    }
}
