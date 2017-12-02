using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;


namespace IDAL
{
   public interface Idiscussion_comt
    {
        int InsertDiscussion_comt(discussion_comt discussion_comt);
        int DeleteDiscussion_comt(int discomt_id);
        DataTable SelectDiscussion_comt(int discussion_id);
        DataTable SelectAll();

    }
}
