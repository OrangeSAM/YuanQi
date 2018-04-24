﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlServerDiscussion : Idiscussion
    {
        public int DeleteDiscussion(int discussion_id)
        {
            SqlParameter[] sp = { new SqlParameter("@discussion_id", discussion_id) };
            return DBHelper.GetExcuteNonQuery("DeleteDiscussion", System.Data.CommandType.StoredProcedure, sp);
        }

        public int InsertDiscussion(discussion discussion)
        {
            string sql = "insert into discussion(user_id,dis_cont,dis_title,pub_time) values(@user_id,@dis_cont,@dis_title,@pub_time)";
            SqlParameter[] sp =
            {
                new SqlParameter("@user_id",discussion.user_id),       
                new SqlParameter("@dis_cont",discussion.dis_cont),
                new SqlParameter("@dis_title",discussion.dis_title),
                new SqlParameter("@pub_time",discussion.pub_time),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select discussion.*,user_name,user_photo from discussion,users where discussion.user_id=users.user_id order by pub_time desc";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectDiscussion(int discussion_id)
        {
            string sql = "select *,user_name from discussion,users where discussion.user_id=users.user_id and discussion_id=@discussion_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@discussion_id",discussion_id),
            };
            return DBHelper.GetFillData(sql, sp);
        }

        public DataTable SelectPubNum()//查询用户发帖数量
        {
            string sql = "select count(*) pub_num,user_name,user_photo from discussion,users where users.user_id=discussion.user_id group by discussion.user_id, user_name, user_photo order by pub_num desc";
            return DBHelper.GetFillData(sql);
        }              
    }
}
