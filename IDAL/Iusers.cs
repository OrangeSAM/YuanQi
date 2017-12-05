using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
    public  interface Iusers
    {
        int Insert(users us);
        SqlDataReader Login(string name, string pwd);
        SqlDataReader Selectusername(string user_name);
        DataTable GetUsers(Models.users user);
        int Update(users us);
    }

}

