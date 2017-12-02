using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;

namespace IDAL
{
  public   interface Ialphoto_comt
    {
        int InsertAlp_comt(alphoto_comt alphotos_comt);
        //DataTable SelectAll();
        //DataTable SelectComt_cont(string cont);
        //DataTable SelectComDate(DateTime date);
    }
}
