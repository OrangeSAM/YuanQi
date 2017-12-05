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
   public  class Rider_articleManager
    {
        private static Irider_article irider_article = DataAccess.Createrider_article();
        public static  int InsertRider_art(rider_article rider_article)
        {
            return irider_article.InsertRider_art(rider_article);
        }
        public static  DataTable SelectAll()
        {
            return irider_article.SelectAll();
        }
        public static  DataTable SelectRider_art(int riarticle_id)
        {
            return irider_article.SelectRider_art(riarticle_id);
        }
        public static  int UpdateDislike(int riarticle_id)
        {
            return irider_article.UpdateDislike(riarticle_id);
        }
        public static  int UpdateLike(int riarticle_id)
        {
            return irider_article.UpdateLike(riarticle_id);
        }
        public static  DataTable SelectUserRider_art(int user_id)
        {
            return irider_article.SelectUserRider_art(user_id);
        }

    }
}
