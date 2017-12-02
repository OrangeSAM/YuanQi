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
   public class SqlServerUsers:Iusers
    {
        public int Insert(users us)
        {
            string sql = "insert into Users(user_name,user_pwd) values(@User_name,@User_pwd)";
         
            SqlParameter[] sp = new SqlParameter[]{

                new SqlParameter("@User_name",us.user_name),
                new SqlParameter("@User_pwd",us.user_pwd),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public SqlDataReader Login(string name,string pwd)
        {
            string sql = "select * from users where user_name=@User_name and user_pwd=@User_pwd";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@User_name",name),
                new SqlParameter("@User_pwd",pwd),
            };
            return DBHelper.GetDataReader(sql, sp);
        }
        public SqlDataReader Selectusername(string user_name)
        {
            string sql = "select * from users where user_name=@Username";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@User_name",user_name),
            };
            return DBHelper.GetDataReader(sql, sp);
        }
        public DataTable GetUsers(users user)
        {
            string sql = "select * from users";
            //SqlParameter[] sp = new SqlParameter[]
            //{
            //    new SqlParameter("@user_id",user.user_id),
            //    new SqlParameter("@user_account",user.user_account),
            //    new SqlParameter("@user_name",user.user_name),
            //    new SqlParameter("@user_pwd",user.user_pwd),
            //    new SqlParameter("user_photo",user.user_photo),
            //    new SqlParameter("@user_sex",user.user_sex),
            //    new SqlParameter("@user_email",user.user_email),
            //    new SqlParameter("@user_phone",user.user_phone),
            //    new SqlParameter("@user_addr",user.user_addr),
            //};
            return DBHelper.GetFillData(sql);
        }
        public int Update(users us)
        {
            string sql = "update users set user_account=@user_account,user_pwd=@user_pwd,user_photo=@user_photo, user_sex=@user_sex, user_email=@user_email, user_phone=@user_phone, user_addr=@user_addr where user_id=@user_id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@user_account",us.user_account),
                new SqlParameter("@user_pwd",us.user_pwd),
                new SqlParameter("user_photo",us.user_photo),
                new SqlParameter("@user_sex",us.user_sex),
                new SqlParameter("@user_email",us.user_email),
                new SqlParameter("@user_phone",us.user_phone),
                new SqlParameter("@user_addr",us.user_addr),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);

                
                
        }
    }
}
