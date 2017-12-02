using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class activity
    {
        public int avtivity_id { get; set; }
        public DateTime pub_time { get; set; }
        public int user_id { get; set; }
        public string activity_cont { get; set; }
        public string act_name { get; set; }
    }
}
