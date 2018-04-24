using System;
using Models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class SqlServerIndent : Iindent
    {
        public int InsertIndent(indent indent)
        {
            string sql = "insert into indent(start_time,end_time,user_id,indent_state,indent_date,indent_price)values(@start_time,@end_time,@user_id,@indent_state,@indent_date,@indent_price)";
            SqlParameter[] sp =
            {
                new SqlParameter("@start_time",indent.start_time),
                new SqlParameter("@end_time",indent.end_time),
                new SqlParameter("@user_id",indent.user_id),
                new SqlParameter("@indent_state",indent.indent_state),
                new SqlParameter("@indent_date",indent.indent_date),
                new SqlParameter("@indent_price",indent.indent_price),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

    }
}
