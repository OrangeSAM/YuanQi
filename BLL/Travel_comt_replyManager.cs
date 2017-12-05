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
    public class Travel_comt_replyManager
    {
        private static Itravel_comt_reply itravel_Comt_Reply = DataAccess.Createtravel_comt_reply();
        public static int InsertTravel_re(travel_comt_reply travel_Comt_Reply)
        {
            return itravel_Comt_Reply.InsertTravel_re(travel_Comt_Reply);
        }
        public static DataTable SelectTravelReply_comt(int trcomt_id)
        {
            return itravel_Comt_Reply.SelectTravelReply_comt(trcomt_id);
        }
        public static DataTable UserTravel_re(int user_id)
        {
            return itravel_Comt_Reply.UserTravel_re(user_id);
        }
        public static DataTable SelectAll()
        {
            return itravel_Comt_Reply.SelectAll();
        }
        public static int DeleteTravel_re(int trreply_id)
        {
            return itravel_Comt_Reply.DeleteTravel_re(trreply_id);
        }
    }
}
