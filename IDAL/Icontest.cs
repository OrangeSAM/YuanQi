using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;


namespace IDAL
{
   public  interface Icontest
    {
        int InsertContest(contest contest);
        //DataTable SelectTodayContest(string con_title);
        //SqlDataReader Selectusers(string user_name);
        DataTable SelectContest(int ConId);
        DataTable SelectAll();
        //DataTable SelectConDate(DateTime date);
        //DataTable SelectConIntro(string intro);
        //int UpdateLike(int ConId);
        //int UpdateDislike(int ConId);
    }
}
