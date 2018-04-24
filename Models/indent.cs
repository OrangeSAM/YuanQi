using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class indent
    {
        public int indent_id { get; set; }
        public int user_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public string indent_state { get; set; }
        public DateTime indent_date { get; set; }
        public float indent_price { get; set; }
    }
}
