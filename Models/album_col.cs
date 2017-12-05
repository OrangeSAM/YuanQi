using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class album_col
    {
        public int album_col_id { get; set; }
        public int col_num { get; set; }
        public int album_id { get; set; }
        public int user_id { get; set; }
        public DateTime col_time { get; set; }

    }
}
