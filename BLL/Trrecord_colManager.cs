using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;
using DALFactory;

namespace BLL
{
   public  class Trrecord_colManager
    {
        private static Itrrecord_col itrrecord_col = DataAccess.Createtrrecord_col();
        public static int UpdateClickNum(int trcol_id)
        {
            return itrrecord_col.UpdateClickNum(trcol_id);
        }
    }
}
