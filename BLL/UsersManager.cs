using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;
using DALFactory;

namespace BLL
{
   public  class UsersManager
    {
        private static Iusers iusers = DataAccess.Createusers();
        public static SqlDataReader Login(string name, string pwd)
        {
            return iusers.Login(name, pwd);
        }
        public static int Insert(users us)
        {
            return iusers.Insert(us);
        }
        public static SqlDataReader Selectusername(string user_name)
        {
            return iusers.Selectusername(user_name);
        }
        public static DataTable GetUsers(users user)
        {
            return iusers.GetUsers(user);
        }
        public static int Update(users us)
        {
            return iusers.Update(us);
        }
    }
}
