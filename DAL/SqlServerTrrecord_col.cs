using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public  class SqlServerTrrecord_col:Itrrecord_col
    {
        public int UpdateClickNum(int trcol_id)
        {
            string sql = "update trrecord_col set col_num=col_num+1 where trcol_id=@trcol_id";
            SqlParameter[] sp = { new SqlParameter("@trcol_id", trcol_id) };
            return DBHelper.GetExcuteNonQuery(sql,sp);
        }
        public int InsertTrrecord(trrecord_col trrecord_Col)
        {
            string sql = "insert into trrecord_col(user_id,trrecord_id,col_time) values(@user_id,@trrecord_id,@col_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@user_id",trrecord_Col.user_id),
                new SqlParameter("@trrecord_id",trrecord_Col.trrecord_id),
                new SqlParameter("@col_time",trrecord_Col.col_time),
                //new SqlParameter("@col_num",trrecord_Col.col_num),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
