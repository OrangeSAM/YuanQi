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
   public  class Store_comtManager
    {
        private static Istore_comt istore_Comt = DataAccess.Createstore_comt();
        public static int InsertStore_comt(store_comt store_Comt)
        {
            return istore_Comt.InsertStore_comt(store_Comt);
        }
        public static int DeleteStore_comt(int stcomt_id)
        {
            return istore_Comt.DeleteStore_comt(stcomt_id);
        }
        public static DataTable SelectStore_comt(int stcomt_id)
        {
            return istore_Comt.SelectStore_comt(stcomt_id);
        }
        public static DataTable SelectAll()
        {
            return istore_Comt.SelectAll();
        }
    }
}
