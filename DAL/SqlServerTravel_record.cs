﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;

namespace DAL
{
   public  class SqlServerTravel_record:Itravel_record
    {
       public int InsertTravel_record(travel_record travel_Record)
        {
            string sql = "insert into travel_record(user_id,record_author,record_title,record_cont,record_cover,pub_time) values (@user_id,@record_author,@record_title,@record_cont,@record_cover,@pub_time)";
            SqlParameter[] para =
            {
                new SqlParameter ("@user_id",travel_Record .user_id),
                new SqlParameter ("@record_author",travel_Record .record_author ),
                new SqlParameter ("@record_title",travel_Record .record_title ),
                new SqlParameter ("@record_cont",travel_Record .record_cont ),
                new SqlParameter ("@record_cover",travel_Record .record_cover ),
                new SqlParameter ("@pub_time",travel_Record.pub_time)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
                
        }
       public  DataTable SelectTravel_record(int trrecord_id)
        {
            string sql = "select *,user_name from travel_record,users where travel_record.user_id=users.user_id and trrecord_id=@trrecord_id";
            SqlParameter[] para = { new SqlParameter("@trrecord_id", trrecord_id) };
            return DBHelper.GetFillData(sql, para);
        }
        public DataTable SelectUserTravel_record(string user_id)
        {
            string sql = "select * from travel_record where user_id=@user_id";
            SqlParameter[] sp =
            {
                new SqlParameter ("@user_id",user_id )

             };
            return DBHelper.GetFillData(sql, sp);

        }
       public  DataTable SelectAll()
        {
            string sql = "select a.*,b.user_name,b.user_photo from travel_record a,users b where a.user_id=b.user_id order by pub_time desc";
            return DBHelper.GetFillData(sql);
        }
      

        public int UpdateLike(int trrecord_id)
        {
            string sql = "update travel_record set like_count=like_count+1 where trrecord_id=@trrecord_id";
            SqlParameter[] para = { new SqlParameter("@trrecord_id", trrecord_id) };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }

        public int UpdateDislike(int trrecord_id)
        {
            string sql = "update travel_record set like_count=like_count-1 where trrecord_id=@trrecord_id";
            SqlParameter[] para = { new SqlParameter("@trrecord_id", trrecord_id) };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }

        public DataTable SelectTop(int top)
        {
            string sql = "select top " + top + " * from travel_record,users where travel_record.user_id=users.user_id order by col_count desc";
            return DBHelper.GetFillData(sql);
        }

        public int getLikecount(int trrecord_id)
        {
            string sql = "select like_count from travel_record where trrecord_id=@trrecord_id ";
            SqlParameter[] sp =
            {
                new SqlParameter("@trrecord_id",trrecord_id)
            };
            return DBHelper.ExecuteScalar<int>(sql, sp);


        }
        public int UpdateCol(int trrecord_id)
        {
            string sql = "update travel_record  set col_count=col_count+1 where trrecord_id=@trrecord_id";
            SqlParameter[] para = { new SqlParameter("@trrecord_id", trrecord_id) };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public DataTable SelectUserrecord_col(int user_id)
        {
            string sql = "select record_cover,record_title from trrecord_col,travel_record where trrecord_col.user_id=@user_id and travel_record.trrecord_id=trrecord_col.trrecord_id" ;
            SqlParameter[] sp =
            {
                new SqlParameter ("@user_id",user_id )

             };
            return DBHelper.GetFillData(sql, sp);

        }
    }
}
