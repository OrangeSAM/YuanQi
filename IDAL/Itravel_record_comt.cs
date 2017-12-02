using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using models;

namespace IDAL
{
   public  interface Itravel_record_comt
    {
        int InsertTravel_record_comt(travel_record_comt travel_Record_Comt );
        DataTable SelectAll();
        DataTable SelectTravel_record_comt(int trrecord_id);
        int DeleteTravel_record_comt(int trcomt_id);

    }
}
