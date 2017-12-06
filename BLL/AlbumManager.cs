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
   public  class AlbumManager
    {
        private static Ialbum ialbum = DataAccess.Createalbum();
        public static  int InsertAlbum(album album)
        {
            return ialbum.InsertAlbum(album);
        }
        public static  int UpdateAlbum(album album)
        {
            return ialbum.UpdateAlbum(album);
        }
        public static DataTable SelectAll()
        {
            return ialbum.SelectAll();
        }

    }
}
