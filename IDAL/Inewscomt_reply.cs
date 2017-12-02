using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;

namespace IDAL
{
   public  interface Inewscomt_reply
    {
        int Insert(newscomt_reply newscomt_reply );
        DataTable SelectNewscomt_re(int newscomt_id);
        DataTable UserNewscomt_re(int user_id);
        DataTable SelectAll();
        int DeleteNewscomt_re(int newscomt_id);
    }
}
