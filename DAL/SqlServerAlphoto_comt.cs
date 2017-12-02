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
   public  class SqlServerAlphoto_comt:Ialphoto_comt
    {
        public int InsertAlp_comt(alphoto_comt alphotos_comt)
        {
            string sql = "insert into alphoto_comt(photos_id,user_id,comt_cont,comt_time)values(@photos_id,@user_id,@comt_cont,@comt_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@photos_id",alphotos_comt.photos_id),
                new SqlParameter("@user_id",alphotos_comt.user_id),
                new SqlParameter("@comt_cont",alphotos_comt.comt_cont),
                new SqlParameter("@comt_time",alphotos_comt.comt_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
