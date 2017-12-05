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
   public  class AdminManager
    {
        private static Iadmin iadmin = DataAccess.Createadmin();
        public static  DataTable SelectAdmin(string AdminName)
        {
            return iadmin.SelectAdmin(AdminName);
        }
        public static  SqlDataReader Login(string name, string pwd)
        {
            return iadmin.Login(name, pwd);
        }

    }
}
