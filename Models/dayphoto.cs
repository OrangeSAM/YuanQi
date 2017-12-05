using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class dayphoto
    {
        public int photo_id { get; set; }
        public int user_id { get; set; }
        public string photo_name { get; set; }
        public DateTime ul_time { get; set; }
        public string path { get; set; }
        public int like_count { get; set; }
    }
}
