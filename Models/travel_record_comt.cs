using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class travel_record_comt
    {
        public int trcomt_id { get; set; }
        public int user_id { get; set; }
        public int trrecord_id { get; set; }
        public string comt_cont { get; set; }
        public int like_count { get; set; }
        public int comt_count { get; set; }
        public DateTime comt_time { get; set; }
    }
}
