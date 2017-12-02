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
    public class SqlServerAlbum_col:Ialbum_col
    {
       public int UpdateClickNum(int album_col_id)
        {
            string sql = "update album_col set col_num=col_num+1 where album_col_id=@album_col_id";
            SqlParameter[] sp = { new SqlParameter("@album_col_id", album_col_id) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
