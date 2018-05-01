using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class SqlServerAlbum:Ialbum
    {
        public int InsertAlbum(album album)
        {
            string sql = "insert into album(creater_id,create_time,album_intro,photo)values(@creater_id,@create_time,@album_intro,@photo)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@creater_id",album.creater_id),
                new SqlParameter("@create_time",album.create_time),
                new SqlParameter("@album_intro",album.album_intro),
                new SqlParameter("@photo",album.photo),

            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public int UpdateAlbum(album album)
        {
            string sql = "update album set creater_id=@creater_id,create_time=@create_time,album_intro=@album_intro,photo_amount=@photo_amount,photo=@photo";
            SqlParameter[] sp = new SqlParameter[]
           {
                new SqlParameter("@creater_id",album.creater_id),
                new SqlParameter("@create_time",album.create_time),
                new SqlParameter("@album_intro",album.album_intro),
                new SqlParameter("@photo",album.photo),

           };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectAll()
        {
            string sql = "select *,col_num from album,album_col where album.album_id=album_col.album_id";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectAlbumCover(int album_id)
        {
            string sql = "select * from album where album_id=@album_id order by create_time desc";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@album_id",album_id),
            };
            return DBHelper.GetFillData(sql,sp);
        }
        public DataTable Selectusers(int user_id)
        {
            string sql = "select * from album,users  where album.creater_id=users.user_id and creater_id=@user_id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@user_id",user_id)
            };
            return DBHelper.GetFillData(sql, sp);
        }

    }
}
