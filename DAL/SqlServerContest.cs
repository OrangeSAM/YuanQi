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
   public  class SqlServerContest:Icontest
    {
        public DataTable SelectAll()
        {
            string sql = "select * from contest order by con_time ";
            return DBHelper.GetFillData(sql);
        }
        public int InsertContest(contest contest)
        {
            string sql = "insert into contest(con_title,con_intro,con_place,con_time) values(@con_title,@con_intro,@con_place,@con_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@con_title",contest.con_title),
                new SqlParameter("@con_intro",contest.con_intro),
                new SqlParameter("@con_place",contest.con_place),
                new SqlParameter("con_time",contest.con_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public  DataTable SelectContest(int ConId)
        {
            string sql = "select * from contest where contest_id =@contest_id  order by con_time ";
            SqlParameter[] sp =
            {
                new SqlParameter("contest_id ",ConId),
            };
            return  DBHelper.GetFillData(sql,sp);
        }
    }
}
