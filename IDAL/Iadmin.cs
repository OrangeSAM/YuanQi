using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace IDAL
{
   public  interface Iadmin
    {
        DataTable SelectAdmin(string adminname);
        SqlDataReader Login(string name, string pwd);
    }
}
