using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;

namespace IDAL
{
   public  interface Irider_article_reply
    {
        int InsertRiderArt_re(rider_article_reply rider_Article_Reply);
        DataTable SelectRiderArt_re(int rireply_id);
        DataTable UserRiderArt_re(int user_id);
        DataTable SelectAll();
        int DeleteRiderArt_re(int rireply_id);
    }
}
