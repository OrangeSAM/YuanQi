using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class discussion_comt
    {
        public int discomt_id { get; set; }
        public int user_id { get; set; }
        public int discussion_id { get; set; }
        public string comt_cont { get; set; }
        public DateTime comt_time { get; set; }
        public int like_count { get; set; }
        public int comt_count { get; set; }
    }
}
