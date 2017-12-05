using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class trrecord_col
    {
        public int trcol_id { get; set; }
        public int user_id { get; set; } 
        public int trrecord_id { get; set; }
        public DateTime col_time { get; set; }
        public int col_num { get; set; }
    }
}
