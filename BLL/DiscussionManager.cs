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
   public  class DiscussionManager
    {
        private static Idiscussion idiscussion = DataAccess.Creatediscussion();
        public static  int DeleteDiscussion(int discussion_id)
        {
            return idiscussion.DeleteDiscussion(discussion_id);
        }
        public static  int InsertDiscussion(discussion discussion)
        {
            return idiscussion.InsertDiscussion(discussion);
        }
        public static  DataTable SelectAll()
        {
            return idiscussion.SelectAll();
        }
        public static  DataTable SelectDiscussion(int discussion_id)
        {
            return idiscussion.SelectDiscussion(discussion_id);
        }
    }
}
