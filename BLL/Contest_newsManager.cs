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
   public  class Contest_newsManager
    {
        private static Icontest_news icontest_news = DataAccess.Createcontest_news();
        public static  int InsertNews(contest_news news)
        {
            return icontest_news.InsertNews(news);
        }
        public static  DataTable SelectAll()
        {
            return icontest_news.SelectAll();

        }
        public static  DataTable SelectNews(int NewsId)
        {
            return icontest_news.SelectNews (NewsId);
        }
    }
}
