using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class SqlServerAdmin:Iadmin
    {
        public DataTable SelectAdmin(string AdminName)
        {
            string sql = "select * from admin where admin_name=@admin_name";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@admin_name",AdminName),
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return DBHelper.GetFillData(sql);
        }
        public SqlDataReader Login(string name, string pwd)
        {
            string sql = "select * from admin where admin_name=@admin_name,admin_pwd=@admin_pwd";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@admin_name",name),
                new SqlParameter("@admin_pwd",pwd),
            };
            return DBHelper.GetDataReader(sql, sp);
        }
    }
}
