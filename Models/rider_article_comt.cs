using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class rider_article_comt
    {
        public int ricomt_id { get; set; }
        public int user_id { get; set; }
        public int riarticle_id { get; set; }
        public DateTime comt_time { get; set; }
        public string comt_cont { get; set; }
        public int like_count { get; set; }
        public int comt_count { get; set; }
    }
}
