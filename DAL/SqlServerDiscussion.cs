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
    public class SqlServerDiscussion : Idiscussion
    {
        public int DeleteDiscussion(int discussion_id)
        {
            SqlParameter[] sp = { new SqlParameter("@discussion_id", discussion_id) };
            return DBHelper.GetExcuteNonQuery("DeleteDiscussion", System.Data.CommandType.StoredProcedure, sp);
        }

        public int InsertDiscussion(discussion discussion)
        {
            string sql = "insert into discussion(dis_title,dis_cont,user_id,pub_time)values(@dis_title,@dis_cont,@user_id,@pub_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@dis_title",discussion.dis_title),
                new SqlParameter("@dis_cont",discussion.dis_cont),
                new SqlParameter("@user_id",discussion.user_id),
                new SqlParameter("@pub_time",discussion.pub_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select disscussion.*,user_name from discussion,users where discusson.user_id=users.user_id order by pub_time";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectDiscussion(int discussion_id)
        {
            string sql = "select *,user_name from discussion,users where discussion.user_id=users.user_id and discussion_id=@discussion_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@discussion_id",discussion_id),
            };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
