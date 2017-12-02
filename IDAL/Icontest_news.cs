using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public interface Icontest_news
    {
        int InsertNews(contest_news news);
        //DataTable SelectTodayNews(string news_title);
        //SqlDataReader Selectusers(string user_name);
        DataTable SelectNews(int NewsId);
        DataTable SelectAll();
        //DataTable SelectNewsDate(DateTime date);
        //DataTable SelectNewsIntro(string intro);
    }
}
