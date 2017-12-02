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
   public class SqlServerStore:Istore
    {
        public int InsertStore(store store)
        {
            string sql = "insert into store(store_name,store_photo,store_phone,col_count,store_addr,runtime) values(@store_name,@store_intro,@store_photo,@store_phone,@col_count,@store_addr,@runtime) where store_id=@store_id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@store_id",store.store_name),
                new SqlParameter("@store_photo",store.store_photo),
                new SqlParameter("@store_phone",store.store_phone),
                new SqlParameter("@col_count",store.col_count),
                new SqlParameter("@store_addr",store.store_addr),
                new SqlParameter("@runtime",store.runtime),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public int UpdateStore(store store)
        {
            string sql = "update store set store_name=@store_name,store_intro=@store_intro,store_phone=@store_phone,col_count=@col_count,store_addr=@store_addr,runtime=@runtime where store_id=@store_id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@store_id",store.store_name),
                new SqlParameter("@store_photo",store.store_photo),
                new SqlParameter("@store_phone",store.store_phone),
                new SqlParameter("@col_count",store.col_count),
                new SqlParameter("@store_addr",store.store_addr),
                new SqlParameter("@runtime",store.runtime),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public int DeleteStore(int store_id)
        {
            SqlParameter[] sp = { new SqlParameter("@store_id",store_id) };
            return DBHelper.GetExcuteNonQuery("DeleteStore", System.Data.CommandType.StoredProcedure, sp);
        }
        public DataTable SelectAll()
        {
            string sql = "select * from store";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectStoreAddr(string store_addr)
        {
            string sql = "select store_addr from store where store_addr=@store_addr";
            return DBHelper.GetFillData(sql);
        }



    }
}
