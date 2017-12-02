using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public  interface Irider_article_comt
    {
        int InsertRider_art_comt(rider_article_comt rider_Article_Comt );
        DataTable SelectAll();
        DataTable SelectRiderArt_Comt_cont(string cont);
        DataTable SelectComDate(DateTime date);
    }
}
