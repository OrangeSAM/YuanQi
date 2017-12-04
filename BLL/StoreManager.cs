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
    public class StoreManager
    {
        private static Istore istore = DataAccess.Createstore();
        public static int InsertStore(store store)
        {
            return istore.InsertStore(store);
        }
        public static int UpdateStore(store store)
        {
            return istore.UpdateStore(store);
        }
        public static int DeleteStore(int store_id)
        {
            return istore.DeleteStore(store_id);
        }
        public static DataTable SelectAll()
        {
            return istore.SelectAll();
        }
        public static DataTable SelectStoreAddr(string store_addr)
        {
            return istore.SelectStoreAddr(store_addr);
        }
    }
}
