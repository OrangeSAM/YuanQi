
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlServerContest_new : Icontest_news
    {
        public int InsertNews(contest_news news)
        {
            string sql = "insert into contest_news(news_title,news_cont,pub_time)values(@news_title,@news_cont,@pub_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@news_title",news.news_title),
                new SqlParameter("@news_cont",news.news_cont),
                new SqlParameter("@pub_time",news.pub_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select * from contest_news order by pub_time";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectNews(int NewsId)
        {
            string sql = "select * from contest_news where news_id=@news_id order by pub_time";
            SqlParameter[] sp =
            {
                new SqlParameter("@news_id",NewsId),
            };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}