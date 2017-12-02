using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
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
    }
}
