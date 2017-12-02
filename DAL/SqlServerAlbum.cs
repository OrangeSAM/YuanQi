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
       
    }
}
