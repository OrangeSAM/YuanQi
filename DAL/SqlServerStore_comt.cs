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
    public class SqlServerStore_comt : Istore_comt
    {
        public int DeleteStore_comt(int stcomt_id)
        {
            string sql = "delete from store_comt where stcomt_id=@stcomt_id ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter ("@stcomt_id",stcomt_id)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public int InsertStore_comt(store_comt store_Comt)
        {
            string sql = "insert into store_comt(user_id,store_id,comt_cont,comt_time) values(@user_id,@store_id,@comt_cont,@comt_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@user_id",store_Comt.user_id),
                new SqlParameter("@store_id",store_Comt.store_id),
                new SqlParameter("@comt_cont",store_Comt.comt_cont),
                new SqlParameter("@comt_time",store_Comt.comt_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select a.*,b.user_name,c.store_name from store_comt a,users b,store c where a.user_id=b.user_id and b.store_id=c.store_id";

            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectStore_comt(int stcomt_id)
        {
            string sql = "select store_comt.*,user_name from store_comt,users where store_comt.user_id=users.user_id and stcomt_id=@stcomt_id order by comt_time desc";
            SqlParameter[] sp = { new SqlParameter("@stcomt_id", stcomt_id) };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
