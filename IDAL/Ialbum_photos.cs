using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;

namespace IDAL
{
   public  interface Ialbum_photos
    {
        int InsertAlm_Photo(album_photos album_photos);
        int DeleteAlm_Photo(int photos_id);
        DataTable SelectAll();
        DataTable SelectTop6();
    }
}
