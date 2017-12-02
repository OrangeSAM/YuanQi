using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using models;

namespace IDAL
{
   public interface Itravel_comt_reply
    {
        int InsertTravel_re(travel_comt_reply travel_Comt_Reply);
        DataTable SelectTravelReply_comt(int trcomt_id);
        DataTable UserTravel_re(int user_id);
        DataTable SelectAll();
        int DeleteTravel_re(int trreply_id);
    }
}
