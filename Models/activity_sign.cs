using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class activity_sign
    {
        public int sign_id { get; set; }
        public int user_id { get; set; }
        public int activity_id { get; set; }
        public DateTime sign_time { get; set; }
        public string user_name { get; set; }
        public string user_phone { get; set; }
    }
}
