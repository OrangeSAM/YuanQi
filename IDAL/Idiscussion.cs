using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace IDAL
{
   public interface Idiscussion
    {
        int InsertDiscussion(discussion discussion);
        DataTable SelectDiscussion(int discussion_id);
        DataTable SelectAll();
        int DeleteDiscussion(int discussion_id);
        DataTable SelectPubNum();//查询用户发帖数量
    }
}
