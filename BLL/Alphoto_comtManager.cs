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
   public  class Alphoto_comtManager
    {
        private static Ialphoto_comt ialphoto_comt = DataAccess.Createalphoto_comt();
        public static  int InsertAlp_comt(alphoto_comt alphotos_comt)
        {
            return ialphoto_comt.InsertAlp_comt(alphotos_comt);
        }

    }
}
