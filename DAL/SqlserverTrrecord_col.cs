using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public  class SqlserverTrrecord_col:Itrrecord_col
    {
        public int UpdateClickNum(int trcol_id)
        {
            string sql = "update trrecord_col set col_num=col_num+1 where trcol_id=@trcol_id";
            SqlParameter[] sp = { new SqlParameter("@trcol_id", trcol_id) };
            return DBHelper.GetExcuteNonQuery(sql,sp);
        }
    }
}
