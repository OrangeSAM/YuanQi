using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DALFactory;
using IDAL;

namespace BLL
{
    public class IndentManager
    {
        private static Iindent i = DataAccess.Createindent();
        public static int InsertIndent(indent indent)
        {
            return i.InsertIndent(indent);
        }
    }
}
