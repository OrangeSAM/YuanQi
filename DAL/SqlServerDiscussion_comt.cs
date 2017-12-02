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
    public class SqlServerDiscussion_comt : Idiscussion_comt
    {
        public int DeleteDiscussion_comt(int discomt_id)
        {
            string sql = "delete from discussion_comt where discomt_id=@discomt_id delete from discussion_reply where discomt_id=@discomt_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@discomt_id",discomt_id),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public int InsertDiscussion_comt(discussion_comt discussion_comt)
        {
            string sql = "insert into discussion(user_id,discussion_id,comt_cont,comt_time)values(@user_id,@discussion_id,@comt_cont,@comt_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@user_id",discussion_comt.user_id),
                new SqlParameter("@discussion_id",discussion_comt.discussion_id),
                new SqlParameter("@comt_cont",discussion_comt.comt_cont),
                new SqlParameter("@comt_time",discussion_comt.comt_time),

            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select a.*,b.user_name,c.dis_title from discussion_comt a,users b,discussion c where a.user_id=b.user_id and a.user_id=c.user_id";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectDiscussion_comt(int discussion_id)
        {
            string sql = "select discussion_comt.*,user_name from discussion_comt,users where discussion_comt.user_id=users.user_id and discussion_id=@discussion_id order by comt_time desc";
            SqlParameter[] sp =
            {
                new SqlParameter("@discussion_id",discussion_id),
            };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
