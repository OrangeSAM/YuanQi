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
   public  class SqlServerActivity:Iactivity
    {
        public int InsertActivity(activity activity)
        {
            string sql = "insert into activity(pub_time,user_id,activity_cont) values(@pub_time,@user_id,@activity_cont) ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@pub_time",activity.pub_time),
                new SqlParameter("@user_id",activity.user_id),
                new SqlParameter("@activity_cont",activity.activity_cont)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
       public  SqlDataReader Selectusers(string user_name)//查询用户参加了什么活动
        {
            string sql = "select activity_id,act_name from user_id,activity where user.user_id=activity.user_id and user_name=@user_name";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@user_name",user_name),
            };
            return DBHelper.GetDataReader(sql, sp);
        }
        
        public DataTable SelectAll()
        {
            string sql = "select * from activity where activity_id=@activity_id";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectActivity(int activity_id)
        {
            string sql = "select *,user_name where users.user_id=activity.user_id and activity_id=@activity_id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@activity_id",activity_id),
            };
            return  DBHelper.GetFillData(sql, sp);
        }


    }
}
