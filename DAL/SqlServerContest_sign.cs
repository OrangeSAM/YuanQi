
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlServerContest_sign : Icontest_sign
    {
        public int InsertSign(contest_sign contest_sign)
        {
            string sql = "insert into contest_sign(user_id,contest_id,sign_time)values(@user_id,@contest_id,@sign_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@user_id",contest_sign.user_id),
                new SqlParameter("@contest_id",contest_sign.contest_id),
                new SqlParameter("@sign_time",contest_sign.sign_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectContestUser(int contest_id)
        {
            string sql = "select a.*,b.user_name from contest a,users b where a.user_id=b.user_id and contest_id=@contest_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@contest_id",contest_id),
            };
            return DBHelper.GetFillData(sql, sp);
        }

        public DataTable SelectUserContest(int user_id)
        {
            string sql = "select b.*,a.con_title from contest a,users b where a.user_id=b.user_id and user_id=@user_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@user_id",user_id),
            };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
