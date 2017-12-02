using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class store_comt
    {
        public int stcomt_id { get; set; }
        public string comt_cont { get; set; }
        public DateTime comt_time { get; set; }
        public int user_id { get; set; }
        public int store_id { get; set; }
        public int like_count { get; set; }
    }
}
