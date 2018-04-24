using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace IDAL
{
   public  interface Itravel_record
    {
        int InsertTravel_record(travel_record travel_Record );
        DataTable SelectTravel_record(int trreccord_id);
        DataTable SelectUserTravel_record(string user_id);//查询用户写了那些游记
        DataTable SelectAll();
        DataTable SelectTop(int top);
        //DataTable SelectPub_time(DateTime date);
        int UpdateLike(int trrecord_id);
        int UpdateDislike(int trrecord_id);
        int UpdateCol(int trrecord_id);
        int getLikecount(int trrecord_id);
        DataTable SelectUserrecord_col(int user_id);
    }
}
