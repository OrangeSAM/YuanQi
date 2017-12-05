using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class dayphoto_comt
    {
        public int daycomt_id { get; set; }
        public int user_id { get; set; }
        public int photo_id { get; set; }
        public DateTime comt_time { get; set; }
        public string comt_cont { get; set; }
        public int like_count { get; set; }
        public int comt_count { get; set; }
    }
}
