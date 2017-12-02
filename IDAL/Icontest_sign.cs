using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data.SqlClient;
using System.Data;

namespace IDAL
{
  public  interface Icontest_sign
    {
        int InsertSign(contest_sign contest_sign);
        DataTable SelectContestUser(int contest_id);
        DataTable SelectUserContest(int user_id);
    }
}
