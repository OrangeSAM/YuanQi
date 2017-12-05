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
   public  class Contest_signManager
    {
        private static Icontest_sign icontest_sign = DataAccess.Createcontest_sign();
        public static  int InsertSign(contest_sign contest_sign)
        {
            return icontest_sign.InsertSign(contest_sign);
        }
        public static  DataTable SelectContestUser(int contest_id)
        {
            return icontest_sign.SelectContestUser(contest_id);
        }
        public static  DataTable SelectUserContest(int user_id)
        {
            return icontest_sign.SelectUserContest(user_id);
        }
    }
}
