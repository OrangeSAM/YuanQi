using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using DALFactory;
using Models;


namespace BLL
{
   public  class Album_photoManager
    {
        private static Ialbum_photos ialbum_photo = DataAccess.Createalbum_photos();
        public static  int InsertAlm_Photo(album_photos album_photos)
        {
            return ialbum_photo.InsertAlm_Photo(album_photos);
        }
        public static  int DeleteAlm_Photo(int photos_id)
        {
            return ialbum_photo.DeleteAlm_Photo(photos_id);
        }
        public static  DataTable SelectAll()
        {
            return ialbum_photo.SelectAll();
        }
        public static  DataTable SelectTop6()
        {
            return ialbum_photo.SelectTop6();
        }
        public static DataTable SelectAlbumId(int AlbumID)
        {
            return ialbum_photo.SelectAlbumId(AlbumID);
        }
    }
}
