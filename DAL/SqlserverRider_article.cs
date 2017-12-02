using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using models;

namespace DAL
{
    public class SqlserverRider_article : Irider_article
    {
        public int InsertRider_art(rider_article rider_article)
        {
            string sql = "insert into rider_article(user_id,riarticle_title,riarticle_cont) values (@user_id,@riarticle_title,@riarticle_cont)";
            SqlParameter[] para =
            {
                new SqlParameter("@user_id",rider_article .user_id),
                new SqlParameter ("@riarticle_title",rider_article .riarticle_title  ),
                new SqlParameter ("@riarticle_cont",rider_article .riarticle_cont )
                
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }

        public DataTable SelectAll()
        {
            string sql = "select a.*,b.user_name from rider_article a,users b where a.user_id=b.user_id order by pub_time desc";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectRider_art(int riarticle_id)
        {
            string sql = "select *,user_name,user_id from rider_article,users where rider_article.user_id=users.user_id and riarticle_id=@riarticle_id";
            SqlParameter[] para = { new SqlParameter("@riarticle_id",riarticle_id) };
            return DBHelper.GetFillData(sql, para);
        }


        public int UpdateDislike(int riarticle_id)
        {
            string sql = "update rider_article set Dislike=Dislike+1 where riarticle_id=@riarticle_id";
            SqlParameter[] para = { new SqlParameter("@riarticle_id", riarticle_id) };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }

        public int UpdateLike(int riarticle_id)
        {
            string sql = "update rider_article set Like=Like+1 where riarticle_id=@riarticle_id";
            SqlParameter[] para = { new SqlParameter("@riarticle_id", riarticle_id) };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public  DataTable SelectUserRider_art(int user_id)
        {
            string sql = "select * from rider_article where user_id=@user_id";
            SqlParameter[] sp =
            {
                new SqlParameter ("@user_id",user_id )

             };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
