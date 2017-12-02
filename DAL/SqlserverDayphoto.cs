using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using models;
using IDAL;

namespace DAL
{
    public class SqlserverDayphoto : Idayphoto
    {
        public int DeleteDayphoto(int photo_id)
        {
            SqlParameter[] sp = { new SqlParameter("@photo_id", photo_id) };
            return DBHelper.GetExcuteNonQuery("DeleteDayphoto", System.Data.CommandType.StoredProcedure, sp);
        }

        public int InsertDayphoto(dayphoto photo)
        {
            string sql = "insert into dayphoto(user_id,photo_id,photo_name,path) values(@user_id,@photo_id,@photo_name,@path)";
            SqlParameter[] sp =
            {
                new SqlParameter ("@user_id",photo .user_id ),
                new SqlParameter ("@photo_id",photo .photo_id ),
                new SqlParameter ("@photo_name",photo .photo_name ),
                new SqlParameter ("@path",photo .path )

            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
            
        }

        public DataTable SelectAll()
        {
            string sql = "select a.*,b.user_name from dayphoto a,users b where a.photo_id=b.photo_id order by ul_time desc";
            return DBHelper.GetFillData(sql);
        }
        public  DataTable SelectDay(string type,string year,string month)
        {
            if (type == "new")
            {
                string sql = "select *,user_name from dayphoto,users where dayphoto.user_id=users.user_id and getdate()<EndTime";
                if (year == "0")
                {
                    if(month == "请选择月份")
                    {
                        sql = sql + "order by ul_time desc";
                        return DBHelper.GetFillData(sql);
                    }
                    else
                    {
                        sql = sql + " and month(ul_time)=" + int.Parse(month) + " order by ul_time desc";
                        return DBHelper.GetFillData(sql);
                    }
                }
                else
                {
                    string sql1 = "select *,user_name from dayphoto,users where dayphoto.user_id=users.user_id and getdate()>EndTime";
                    if (year == "0")
                    {
                        if (month == "请选择月份")
                        {
                            sql1 = sql1 + "order by ul_time desc";
                            return DBHelper.GetFillData(sql1);
                        }
                        else
                        {
                            sql1 = sql1 + " and month(ul_time)=" + int.Parse(month) + "order by ul_time desc";
                            return DBHelper.GetFillData(sql1);
                        }
                    }
                    else
                    {
                        if (month == "请选择月份")
                        {
                            sql1 = sql1 + " and year(ul_time)=" + int.Parse(year) + "order by ul_time desc";
                            return DBHelper.GetFillData(sql1);
                        }
                        else
                        {
                            sql1 = sql1 + " and month(ul_time)=" + int.Parse(month) + " and year(ul_time)=" + int.Parse(year) + "order by ul_time desc";
                            return DBHelper.GetFillData(sql1);
                        }
                    }
                }
            }
        }
        public DataTable SelectDayphoto(int photo_id)
        {
            string sql = "select*,user_name from dayphoto,users where dayphoto.user_id=users.user_id and photo_id=@photo_id";
            SqlParameter[] sp =
            {
                new SqlParameter ("@photp_id",photo_id )

            };
            return DBHelper.GetFillData(sql, sp);
            
        }
    }
}
