using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using models;

namespace IDAL
{
   public  interface Itravel_record
    {
        int InsertTravel_record(travel_record travel_Record );
        DataTable SelectTravel_record(int trreccord_id);
        DataTable SelectUserTravel_record(int user_id);//查询用户写了那些游记
        DataTable SelectAll();
        //DataTable SelectPub_time(DateTime date);
        int UpdateLike(int trreccord_id);
        int UpdateDislike(int trreccord_id);
    }
}
