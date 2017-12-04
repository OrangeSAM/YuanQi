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
   public  class Discussion_replyManager
    {
        private static Idiscussion_reply idiscussion_reply = DataAccess.Creatediscussion_reply();
        public static  int DeleteDiscussion_re(int direply_id)
        {
            return idiscussion_reply.DeleteDiscussion_re(direply_id);
        }
        public static  int Insert(discussion_reply discussion_reply)
        {
            return idiscussion_reply.Insert(discussion_reply);
        }
        public static  DataTable SelectAll()
        {
            return idiscussion_reply.SelectAll();
        }
        public static  DataTable SelectDiscussion_re(int discomt_id)
        {
            return idiscussion_reply.SelectDiscussion_re(discomt_id);
        }
        public static  DataTable UserDiscussion_re(int user_id)
        {
            return idiscussion_reply.UserDiscussion_re(user_id);
        }
    }
}
