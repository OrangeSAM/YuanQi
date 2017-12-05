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
   public  class ContestManager
    {
        private static Icontest icontest = DataAccess.Createconntest();
        public static  DataTable SelectAll()
        {
            return icontest.SelectAll();
        }
        public static  int InsertContest(contest contest)
        {
            return icontest.InsertContest(contest);
        }
        public static  DataTable SelectContest(int ConId)
        {
            return icontest.SelectContest(ConId);
        }

    }
}
