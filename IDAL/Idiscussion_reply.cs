using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public interface Idiscussion_reply
    {
        int Insert(discussion_reply discussion_reply );
        DataTable SelectDiscussion_re(int discomt_id);
        DataTable UserDiscussion_re(int user_id);
        DataTable SelectAll();
        int DeleteDiscussion_re(int direply_id);
    }
}
