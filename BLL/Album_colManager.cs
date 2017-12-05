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
   public  class Album_colManager
    {
        private static Ialbum_col ialbum_col = DataAccess.Createalbum_col();
        public static  int UpdateClickNum(int album_col_id)
        {
            return ialbum_col.UpdateClickNum(album_col_id);
        }
    }
}
