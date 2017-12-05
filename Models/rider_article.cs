using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class rider_article
    {
        public int riarticle_id { get; set; }
        public int user_id { get; set; }
        public DateTime pub_time { get; set; }
        public int col_count { get; set; }
        public int like_count { get; set; }
        public string riarticle_title { get; set; }
        public string riarticle_cont { get; set; }
    }
}
