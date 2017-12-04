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
   public  class Discussion_comtManager
    {
        private static Idiscussion_comt idiscussion_comt = DataAccess.Creatediscussion_comt();
        public static  int DeleteDiscussion_comt(int discomt_id)
        {
            return idiscussion_comt.DeleteDiscussion_comt(discomt_id);
        }
        public static  int InsertDiscussion_comt(discussion_comt discussion_comt)
        {
            return idiscussion_comt.InsertDiscussion_comt(discussion_comt);
        }
        public static  DataTable SelectAll()
        {
            return idiscussion_comt.SelectAll();
        }
        public static  DataTable SelectDiscussion_comt(int discussion_id)
        {
            return idiscussion_comt.SelectDiscussion_comt(discussion_id);
        }
    }
}
