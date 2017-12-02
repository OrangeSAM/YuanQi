using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;

namespace IDAL
{
   public interface Ialbum
    {
        int InsertAlbum(album album);
        int UpdateAlbum(album album);
        //DataTable SelectAlbum(string album_name);
        //int UpdateLike(int AlmId);
        //int UpdateDislike(int AlmId);
    }
}
