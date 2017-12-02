using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public interface Irider_article
    {
        int InsertRider_art(rider_article rider_article );
        DataTable SelectRider_art(int riarticle_id);
        DataTable SelectAll();
        int UpdateLike(int riarticle_id);
        int UpdateDislike(int riarticle_id);
        DataTable SelectUserRider_art(int user_id);
    }
}
