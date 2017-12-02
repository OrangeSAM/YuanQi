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
    public class SqlServerAlbum_photos:Ialbum_photos
    {
        public int InsertAlm_Photo(album_photos album_photos)
        {
            string sql = "insert into album_photos(photo,album_id)values(@photo,@album_id)";
            SqlParameter[] sp =
            {
                new SqlParameter("@photo",album_photos.photo),
                new SqlParameter("@album_id",album_photos.album_id),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public int DeleteAlm_Photo(int photos_id)
        {
            SqlParameter[] sp = { new SqlParameter("@photos_id", photos_id) };
            return DBHelper.GetExcuteNonQuery("Deletealbum_photos", System.Data.CommandType.StoredProcedure, sp);
        }
        public DataTable SelectAll()
        {
            string sql = "select * from album_photos";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectTop6()
        {
            string sql = "select * top 6  from album_photos";
            return DBHelper.GetFillData(sql);
        }
    }
}
