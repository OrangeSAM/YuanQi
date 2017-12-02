using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;

namespace IDAL
{
   public  interface Inews_comt
    {
        int InsertNews_comt(news_comt  news_comt);
        DataTable SelectAll();
        DataTable SelectNewsComt_cont(string comt_cont);
        DataTable SelectNewsComtDate(DateTime date);
    }
}
