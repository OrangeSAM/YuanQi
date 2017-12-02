using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class discussion
    {
        public int discussion_id { get; set; }
        public int user_id { get; set; }
        public DateTime pub_time { get; set; }
        public int comt_count { get; set;}
        public string dis_title { get; set; }
        public string dis_cont { get; set; }
    }
}
