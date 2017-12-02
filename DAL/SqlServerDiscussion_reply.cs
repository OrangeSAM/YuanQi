using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlServerDiscussion_reply : Idiscussion_reply
    {
        public int DeleteDiscussion_re(int direply_id)
        {
            string sql = "delete from discussion_reply where direply_id=@direply_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@direply_id",direply_id),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public int Insert(discussion_reply discussion_reply)
        {
            string sql = "insert into discussion_reply(discomt_id,user_id ,reply_cont,reply_time)values(@discomt_id,@user_id ,@reply_cont,@reply_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@discomt_id",discussion_reply.discomt_id),
                new SqlParameter("@user_id",discussion_reply.user_id),
                new SqlParameter("@reply_cont",discussion_reply.reply_cont),
                new SqlParameter("@reply_time",discussion_reply.reply_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select discussion_reply.*,a.user_name as 回复者,b.user_name as 被回复者 from discussion_reply c,users a,users b,discussion_comt d where a.user_id=c.user_id and b.user_id=d.user_id and c.discomt_id=d.discomt_id";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectDiscussion_re(int discomt_id)
        {
            string sql = "select discussion_reply.*,a.user_name as 回复者,b.user_name as 被回复者 from discussion_reply c,users a,users b,discussion_comt d where a.user_id=c.user_id and b.user_id=d.user_id and c.discomt_id=d.discomt_id and d.discomt_id=@discomt_id";
            SqlParameter[] sp = { new SqlParameter("@discomt_id", discomt_id), };
            return DBHelper.GetFillData(sql,sp);
        }

        public DataTable UserDiscussion_re(int user_id)
        {
            string sql = "select discussion_reply.*,a.user_name as 回复者,b.user_name as 被回复者 from discussion_reply c,users a,users b,discussion_comt d where a.user_id=c.user_id and b.user_id=d.user_id and c.discomt_id=d.discomt_id and d.user_id=@user_id";
            SqlParameter[] sp = { new SqlParameter("@user_id", user_id), };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
