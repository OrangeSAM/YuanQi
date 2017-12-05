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
   public  class DayphotoManager
    {
        private static Idayphoto idayphoto = DataAccess.Createdayphoto();
        public static  int DeleteDayphoto(int photo_id)
        {
            return idayphoto.DeleteDayphoto(photo_id);
        }
        public static  int InsertDayphoto(dayphoto photo)
        {
            return idayphoto.InsertDayphoto(photo);
        }
        public static  DataTable SelectAll()
        {
            return idayphoto.SelectAll();
        }
        public static  DataTable SelectDay(string type, string year, string month)
        {
            return idayphoto.SelectDay(type, year, month);
        }
        public static   DataTable SelectDayphoto(int photo_id)
        {
            return idayphoto.SelectDayphoto(photo_id);
        }
    }
}
