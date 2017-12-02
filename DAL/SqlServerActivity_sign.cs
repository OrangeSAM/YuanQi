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
   public class SqlServerActivity_sign:Iactivity_sign
    {
        public int InsertActSign(activity_sign ActSign)
        {
            string sql = "insert into activity_sign(user_id,activity_id,sign_time) values(@user_id,@activity_id,@sign_time)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@user_id",ActSign.user_id),
                new SqlParameter("@activity_id",ActSign.activity_id),
                new SqlParameter("@sign_time",ActSign.sign_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        //public SqlDataReader Selectusers(string user_name)
        //{
        //    string sql="select "
        //}
    }
}
