using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class travel_record
    {
        public int trrecord_id { get; set; }
        public int user_id { get; set; }
        public string record_author { get; set; }
        public string record_title { get; set; }
        public string record_cont { get; set; }
        public DateTime pub_time { get; set; }
        public int col_count { get; set; }
        public int like_count { get; set; }
        public int comt_count { get; set; }
        public string record_cover { get; set; }

    }
}
